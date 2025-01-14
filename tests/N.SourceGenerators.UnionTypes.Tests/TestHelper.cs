﻿// // Ported from https://andrewlock.net/creating-a-source-generator-part-2-testing-an-incremental-generator-with-snapshot-testing/

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace N.SourceGenerators.UnionTypes.Tests;

public static class TestHelper
{
    public static Task Verify<TGenerator>(string source, string? parametersText = null)
        where TGenerator : IIncrementalGenerator, new()
    {
        // Parse the provided string into a C# syntax tree
        SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(source);
        // Create references for assemblies we require
        // We could add multiple references if required
        IEnumerable<PortableExecutableReference> references = new[]
        {
            MetadataReference.CreateFromFile(typeof(object).Assembly.Location)
        };

        // Create a Roslyn compilation for the syntax tree.
        CSharpCompilation compilation = CSharpCompilation.Create(
            assemblyName: "Tests",
            syntaxTrees: new[] { syntaxTree },
            references);

        // Create an instance of our EnumGenerator incremental source generator
        var generator = new TGenerator();

        // The GeneratorDriver is used to run our generator against a compilation
        GeneratorDriver driver = CSharpGeneratorDriver.Create(generator);

        // Run the source generator!
        driver = driver.RunGenerators(compilation);

        // Use verify to snapshot test the source generator output!
        SettingsTask settingsTask = Verifier
            .Verify(driver)
            .UseDirectory("Snapshots");

        if (parametersText != null)
        {
            settingsTask = settingsTask
                .UseTextForParameters(parametersText);
        }

        return settingsTask;
    }
}