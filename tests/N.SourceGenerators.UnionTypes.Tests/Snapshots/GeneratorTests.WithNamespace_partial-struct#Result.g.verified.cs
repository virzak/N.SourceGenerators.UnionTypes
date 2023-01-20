﻿//HintName: Result.g.cs
// <auto-generated>
//   This code was generated by https://github.com/Ne4to/N.SourceGenerators.UnionTypes
//   Feel free to open an issue
// </auto-generated>
#pragma warning disable
#nullable enable
namespace MyApp
{
    partial struct Result
    {
        private readonly global::MyApp.Success? _success;
        public bool IsSuccess => _success != null;
        public global::MyApp.Success AsSuccess => _success ?? throw new InvalidOperationException("This is not a global::MyApp.Success");
        public Result(global::MyApp.Success Success)
        {
            System.ArgumentNullException.ThrowIfNull(Success);
            _success = Success;
        }

        public static implicit operator Result(global::MyApp.Success Success) => new Result(Success);
        public static explicit operator global::MyApp.Success(Result value) => value.AsSuccess;
        public bool TryGetSuccess([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out global::MyApp.Success? value)
        {
            if (_success != null)
            {
                value = _success;
                return true;
            }
            else
            {
                value = default;
                return false;
            }
        }

        private readonly global::MyApp.Error? _error;
        public bool IsError => _error != null;
        public global::MyApp.Error AsError => _error ?? throw new InvalidOperationException("This is not a global::MyApp.Error");
        public Result(global::MyApp.Error Error)
        {
            System.ArgumentNullException.ThrowIfNull(Error);
            _error = Error;
        }

        public static implicit operator Result(global::MyApp.Error Error) => new Result(Error);
        public static explicit operator global::MyApp.Error(Result value) => value.AsError;
        public bool TryGetError([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out global::MyApp.Error? value)
        {
            if (_error != null)
            {
                value = _error;
                return true;
            }
            else
            {
                value = default;
                return false;
            }
        }

        private readonly global::System.Collections.Generic.IReadOnlyList<int>? _iReadOnlyListOfInt;
        public bool IsIReadOnlyListOfInt => _iReadOnlyListOfInt != null;
        public global::System.Collections.Generic.IReadOnlyList<int> AsIReadOnlyListOfInt => _iReadOnlyListOfInt ?? throw new InvalidOperationException("This is not a global::System.Collections.Generic.IReadOnlyList<int>");
        public Result(global::System.Collections.Generic.IReadOnlyList<int> IReadOnlyListOfInt)
        {
            System.ArgumentNullException.ThrowIfNull(IReadOnlyListOfInt);
            _iReadOnlyListOfInt = IReadOnlyListOfInt;
        }

        public static implicit operator Result(global::System.Collections.Generic.IReadOnlyList<int> IReadOnlyListOfInt) => new Result(IReadOnlyListOfInt);
        public static explicit operator global::System.Collections.Generic.IReadOnlyList<int>(Result value) => value.AsIReadOnlyListOfInt;
        public bool TryGetIReadOnlyListOfInt([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out global::System.Collections.Generic.IReadOnlyList<int>? value)
        {
            if (_iReadOnlyListOfInt != null)
            {
                value = _iReadOnlyListOfInt;
                return true;
            }
            else
            {
                value = default;
                return false;
            }
        }

        private readonly string[]? _arrayOfString;
        public bool IsArrayOfString => _arrayOfString != null;
        public string[] AsArrayOfString => _arrayOfString ?? throw new InvalidOperationException("This is not a string[]");
        public Result(string[] ArrayOfString)
        {
            System.ArgumentNullException.ThrowIfNull(ArrayOfString);
            _arrayOfString = ArrayOfString;
        }

        public static implicit operator Result(string[] ArrayOfString) => new Result(ArrayOfString);
        public static explicit operator string[](Result value) => value.AsArrayOfString;
        public bool TryGetArrayOfString([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out string[]? value)
        {
            if (_arrayOfString != null)
            {
                value = _arrayOfString;
                return true;
            }
            else
            {
                value = default;
                return false;
            }
        }

        private readonly global::System.Tuple<int, string>? _tupleOfIntAndString;
        public bool IsTupleOfIntAndString => _tupleOfIntAndString != null;
        public global::System.Tuple<int, string> AsTupleOfIntAndString => _tupleOfIntAndString ?? throw new InvalidOperationException("This is not a global::System.Tuple<int, string>");
        public Result(global::System.Tuple<int, string> TupleOfIntAndString)
        {
            System.ArgumentNullException.ThrowIfNull(TupleOfIntAndString);
            _tupleOfIntAndString = TupleOfIntAndString;
        }

        public static implicit operator Result(global::System.Tuple<int, string> TupleOfIntAndString) => new Result(TupleOfIntAndString);
        public static explicit operator global::System.Tuple<int, string>(Result value) => value.AsTupleOfIntAndString;
        public bool TryGetTupleOfIntAndString([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out global::System.Tuple<int, string>? value)
        {
            if (_tupleOfIntAndString != null)
            {
                value = _tupleOfIntAndString;
                return true;
            }
            else
            {
                value = default;
                return false;
            }
        }

        public TOut Match<TOut>(global::System.Func<global::MyApp.Success, TOut> matchSuccess, global::System.Func<global::MyApp.Error, TOut> matchError, global::System.Func<global::System.Collections.Generic.IReadOnlyList<int>, TOut> matchIReadOnlyListOfInt, global::System.Func<string[], TOut> matchArrayOfString, global::System.Func<global::System.Tuple<int, string>, TOut> matchTupleOfIntAndString)
        {
            if (IsSuccess)
                return matchSuccess(AsSuccess);
            if (IsError)
                return matchError(AsError);
            if (IsIReadOnlyListOfInt)
                return matchIReadOnlyListOfInt(AsIReadOnlyListOfInt);
            if (IsArrayOfString)
                return matchArrayOfString(AsArrayOfString);
            if (IsTupleOfIntAndString)
                return matchTupleOfIntAndString(AsTupleOfIntAndString);
            throw new InvalidOperationException("Unknown type");
        }

        public async global::System.Threading.Tasks.Task<TOut> MatchAsync<TOut>(global::System.Func<global::MyApp.Success, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<TOut>> matchSuccess, global::System.Func<global::MyApp.Error, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<TOut>> matchError, global::System.Func<global::System.Collections.Generic.IReadOnlyList<int>, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<TOut>> matchIReadOnlyListOfInt, global::System.Func<string[], global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<TOut>> matchArrayOfString, global::System.Func<global::System.Tuple<int, string>, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<TOut>> matchTupleOfIntAndString, global::System.Threading.CancellationToken ct)
        {
            if (IsSuccess)
                return await matchSuccess(AsSuccess, ct).ConfigureAwait(false);
            if (IsError)
                return await matchError(AsError, ct).ConfigureAwait(false);
            if (IsIReadOnlyListOfInt)
                return await matchIReadOnlyListOfInt(AsIReadOnlyListOfInt, ct).ConfigureAwait(false);
            if (IsArrayOfString)
                return await matchArrayOfString(AsArrayOfString, ct).ConfigureAwait(false);
            if (IsTupleOfIntAndString)
                return await matchTupleOfIntAndString(AsTupleOfIntAndString, ct).ConfigureAwait(false);
            throw new InvalidOperationException("Unknown type");
        }

        public void Switch(global::System.Action<global::MyApp.Success> switchSuccess, global::System.Action<global::MyApp.Error> switchError, global::System.Action<global::System.Collections.Generic.IReadOnlyList<int>> switchIReadOnlyListOfInt, global::System.Action<string[]> switchArrayOfString, global::System.Action<global::System.Tuple<int, string>> switchTupleOfIntAndString)
        {
            if (IsSuccess)
            {
                switchSuccess(AsSuccess);
                return;
            }

            if (IsError)
            {
                switchError(AsError);
                return;
            }

            if (IsIReadOnlyListOfInt)
            {
                switchIReadOnlyListOfInt(AsIReadOnlyListOfInt);
                return;
            }

            if (IsArrayOfString)
            {
                switchArrayOfString(AsArrayOfString);
                return;
            }

            if (IsTupleOfIntAndString)
            {
                switchTupleOfIntAndString(AsTupleOfIntAndString);
                return;
            }

            throw new InvalidOperationException("Unknown type");
        }

        public async global::System.Threading.Tasks.Task SwitchAsync(global::System.Func<global::MyApp.Success, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> switchSuccess, global::System.Func<global::MyApp.Error, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> switchError, global::System.Func<global::System.Collections.Generic.IReadOnlyList<int>, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> switchIReadOnlyListOfInt, global::System.Func<string[], global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> switchArrayOfString, global::System.Func<global::System.Tuple<int, string>, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> switchTupleOfIntAndString, global::System.Threading.CancellationToken ct)
        {
            if (IsSuccess)
            {
                await switchSuccess(AsSuccess, ct).ConfigureAwait(false);
                return;
            }

            if (IsError)
            {
                await switchError(AsError, ct).ConfigureAwait(false);
                return;
            }

            if (IsIReadOnlyListOfInt)
            {
                await switchIReadOnlyListOfInt(AsIReadOnlyListOfInt, ct).ConfigureAwait(false);
                return;
            }

            if (IsArrayOfString)
            {
                await switchArrayOfString(AsArrayOfString, ct).ConfigureAwait(false);
                return;
            }

            if (IsTupleOfIntAndString)
            {
                await switchTupleOfIntAndString(AsTupleOfIntAndString, ct).ConfigureAwait(false);
                return;
            }

            throw new InvalidOperationException("Unknown type");
        }

        public global::System.Type ValueType
        {
            get
            {
                if (IsSuccess)
                    return typeof(global::MyApp.Success);
                if (IsError)
                    return typeof(global::MyApp.Error);
                if (IsIReadOnlyListOfInt)
                    return typeof(global::System.Collections.Generic.IReadOnlyList<int>);
                if (IsArrayOfString)
                    return typeof(string[]);
                if (IsTupleOfIntAndString)
                    return typeof(global::System.Tuple<int, string>);
                throw new InvalidOperationException("Unknown type");
            }
        }
    }
}