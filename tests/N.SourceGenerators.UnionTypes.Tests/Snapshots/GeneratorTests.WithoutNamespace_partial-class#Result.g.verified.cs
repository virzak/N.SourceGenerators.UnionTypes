﻿//HintName: Result.g.cs
// <auto-generated>
//   This code was generated by https://github.com/Ne4to/N.SourceGenerators.UnionTypes
//   Feel free to open an issue
// </auto-generated>
#pragma warning disable
#nullable enable
partial class Result : IEquatable<Result>
{
    private readonly global::Success? _success;
    public bool IsSuccess => _success != null;
    public global::Success AsSuccess
    {
        get
        {
            if (IsSuccess)
                return _success;
            throw new InvalidOperationException($"Inner value is {InnerValueAlias}, not Success");
        }
    }

    public Result(global::Success Success)
    {
        System.ArgumentNullException.ThrowIfNull(Success);
        _success = Success;
    }

    public static implicit operator Result(global::Success Success) => new Result(Success);
    public static explicit operator global::Success(Result value) => value.AsSuccess;
    public bool TryGetSuccess([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out global::Success? value)
    {
        if (IsSuccess)
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

    private readonly global::Error? _error;
    public bool IsError => _error != null;
    public global::Error AsError
    {
        get
        {
            if (IsError)
                return _error;
            throw new InvalidOperationException($"Inner value is {InnerValueAlias}, not Error");
        }
    }

    public Result(global::Error Error)
    {
        System.ArgumentNullException.ThrowIfNull(Error);
        _error = Error;
    }

    public static implicit operator Result(global::Error Error) => new Result(Error);
    public static explicit operator global::Error(Result value) => value.AsError;
    public bool TryGetError([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out global::Error? value)
    {
        if (IsError)
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

    public TOut Match<TOut>(global::System.Func<global::Success, TOut> matchSuccess, global::System.Func<global::Error, TOut> matchError)
    {
        if (IsSuccess)
            return matchSuccess(AsSuccess);
        if (IsError)
            return matchError(AsError);
        throw new InvalidOperationException("Inner type is unknown");
    }

    public async global::System.Threading.Tasks.Task<TOut> MatchAsync<TOut>(global::System.Func<global::Success, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<TOut>> matchSuccess, global::System.Func<global::Error, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<TOut>> matchError, global::System.Threading.CancellationToken ct)
    {
        if (IsSuccess)
            return await matchSuccess(AsSuccess, ct).ConfigureAwait(false);
        if (IsError)
            return await matchError(AsError, ct).ConfigureAwait(false);
        throw new InvalidOperationException("Inner type is unknown");
    }

    public void Switch(global::System.Action<global::Success> switchSuccess, global::System.Action<global::Error> switchError)
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

        throw new InvalidOperationException("Inner type is unknown");
    }

    public async global::System.Threading.Tasks.Task SwitchAsync(global::System.Func<global::Success, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> switchSuccess, global::System.Func<global::Error, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> switchError, global::System.Threading.CancellationToken ct)
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

        throw new InvalidOperationException("Inner type is unknown");
    }

    public global::System.Type ValueType
    {
        get
        {
            if (IsSuccess)
                return typeof(global::Success);
            if (IsError)
                return typeof(global::Error);
            throw new InvalidOperationException("Inner type is unknown");
        }
    }

    private global::System.Object InnerValue
    {
        get
        {
            if (IsSuccess)
                return AsSuccess;
            if (IsError)
                return AsError;
            throw new InvalidOperationException("Inner type is unknown");
        }
    }

    private string InnerValueAlias
    {
        get
        {
            if (IsSuccess)
                return "Success";
            if (IsError)
                return "Error";
            throw new InvalidOperationException("Inner type is unknown");
        }
    }

    public override int GetHashCode()
    {
        return InnerValue.GetHashCode();
    }

    public static bool operator ==(Result? left, Result? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Result? left, Result? right)
    {
        return !Equals(left, right);
    }

    public bool Equals(Result? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        if (ValueType != other.ValueType)
        {
            return false;
        }

        if (IsSuccess)
            return EqualityComparer<global::Success>.Default.Equals(AsSuccess, other.AsSuccess);
        if (IsError)
            return EqualityComparer<global::Error>.Default.Equals(AsError, other.AsError);
        throw new InvalidOperationException("Inner type is unknown");
    }

    public override string ToString()
    {
        return $"{InnerValueAlias} - {InnerValue}";
    }

    public override bool Equals(object? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        if (other.GetType() != typeof(Result))
        {
            return false;
        }

        return Equals((Result)other);
    }
}