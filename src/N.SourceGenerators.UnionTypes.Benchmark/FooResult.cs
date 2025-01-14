﻿public class FooResult : IEquatable<FooResult>
{
    private readonly Success? _success;
    public bool IsSuccess => _success != null;
    public Success AsSuccess => _success ?? throw new InvalidOperationException("This is not a global::Success");
    public FooResult(Success success)
    {
        ArgumentNullException.ThrowIfNull(success);
        _success = success;
    }

    public static implicit operator FooResult(Success success) => new FooResult(success);
    public static explicit operator Success(FooResult value) => value.AsSuccess;
    public bool TryGetSuccess([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out Success? value)
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

    private readonly ValidationError? _validationError;
    public bool IsValidationError => _validationError != null;
    public ValidationError AsValidationError => _validationError ?? throw new InvalidOperationException("This is not a global::ValidationError");
    public FooResult(ValidationError ValidationError)
    {
        ArgumentNullException.ThrowIfNull(ValidationError);
        _validationError = ValidationError;
    }

    public static implicit operator FooResult(ValidationError ValidationError) => new FooResult(ValidationError);
    public static explicit operator ValidationError(FooResult value) => value.AsValidationError;
    public bool TryGetValidationError([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out ValidationError? value)
    {
        if (_validationError != null)
        {
            value = _validationError;
            return true;
        }
        else
        {
            value = default;
            return false;
        }
    }

    private readonly NotFoundError? _notFoundError;
    public bool IsNotFoundError => _notFoundError != null;
    public NotFoundError AsNotFoundError => _notFoundError ?? throw new InvalidOperationException("This is not a global::NotFoundError");
    public FooResult(NotFoundError NotFoundError)
    {
        ArgumentNullException.ThrowIfNull(NotFoundError);
        _notFoundError = NotFoundError;
    }

    public static implicit operator FooResult(NotFoundError NotFoundError) => new FooResult(NotFoundError);
    public static explicit operator NotFoundError(FooResult value) => value.AsNotFoundError;
    public bool TryGetNotFoundError([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out NotFoundError? value)
    {
        if (_notFoundError != null)
        {
            value = _notFoundError;
            return true;
        }
        else
        {
            value = default;
            return false;
        }
    }

    public TOut Match<TOut>(Func<Success, TOut> matchSuccess, Func<ValidationError, TOut> matchValidationError, Func<NotFoundError, TOut> matchNotFoundError)
    {
        if (IsSuccess)
            return matchSuccess(AsSuccess);
        if (IsValidationError)
            return matchValidationError(AsValidationError);
        if (IsNotFoundError)
            return matchNotFoundError(AsNotFoundError);
        throw new InvalidOperationException("Unknown type");
    }

    public async Task<TOut> MatchAsync<TOut>(Func<Success, CancellationToken, Task<TOut>> matchSuccess, Func<ValidationError, CancellationToken, Task<TOut>> matchValidationError, Func<NotFoundError, CancellationToken, Task<TOut>> matchNotFoundError, CancellationToken ct)
    {
        if (IsSuccess)
            return await matchSuccess(AsSuccess, ct).ConfigureAwait(false);
        if (IsValidationError)
            return await matchValidationError(AsValidationError, ct).ConfigureAwait(false);
        if (IsNotFoundError)
            return await matchNotFoundError(AsNotFoundError, ct).ConfigureAwait(false);
        throw new InvalidOperationException("Unknown type");
    }

    public void Switch(Action<Success> switchSuccess, Action<ValidationError> switchValidationError, Action<NotFoundError> switchNotFoundError)
    {
        if (IsSuccess)
        {
            switchSuccess(AsSuccess);
            return;
        }

        if (IsValidationError)
        {
            switchValidationError(AsValidationError);
            return;
        }

        if (IsNotFoundError)
        {
            switchNotFoundError(AsNotFoundError);
            return;
        }

        throw new InvalidOperationException("Unknown type");
    }

    public async Task SwitchAsync(Func<Success, CancellationToken, Task> switchSuccess, Func<ValidationError, CancellationToken, Task> switchValidationError, Func<NotFoundError, CancellationToken, Task> switchNotFoundError, CancellationToken ct)
    {
        if (IsSuccess)
        {
            await switchSuccess(AsSuccess, ct).ConfigureAwait(false);
            return;
        }

        if (IsValidationError)
        {
            await switchValidationError(AsValidationError, ct).ConfigureAwait(false);
            return;
        }

        if (IsNotFoundError)
        {
            await switchNotFoundError(AsNotFoundError, ct).ConfigureAwait(false);
            return;
        }

        throw new InvalidOperationException("Unknown type");
    }

    public Type ValueType
    {
        get
        {
            if (IsSuccess)
                return typeof(Success);
            if (IsValidationError)
                return typeof(ValidationError);
            if (IsNotFoundError)
                return typeof(NotFoundError);
            throw new InvalidOperationException("Unknown type");
        }
    }

    private Object InnerValue
    {
        get
        {
            if (IsSuccess)
                return AsSuccess;
            if (IsValidationError)
                return AsValidationError;
            if (IsNotFoundError)
                return AsNotFoundError;
            throw new InvalidOperationException("Unknown type");
        }
    }

    private string InnerValueAlias
    {
        get
        {
            if (IsSuccess)
                return "Success";
            if (IsValidationError)
                return "ValidationError";
            if (IsNotFoundError)
                return "NotFoundError";
            throw new InvalidOperationException("Unknown type");
        }
    }

    public override int GetHashCode()
    {
        return InnerValue.GetHashCode();
    }

    public static bool operator ==(FooResult? left, FooResult? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(FooResult? left, FooResult? right)
    {
        return !Equals(left, right);
    }

    public bool Equals(FooResult? other)
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
            return EqualityComparer<Success>.Default.Equals(AsSuccess, other.AsSuccess);
        if (IsValidationError)
            return EqualityComparer<ValidationError>.Default.Equals(AsValidationError, other.AsValidationError);
        if (IsNotFoundError)
            return EqualityComparer<NotFoundError>.Default.Equals(AsNotFoundError, other.AsNotFoundError);
        throw new InvalidOperationException("Unknown type");
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

        if (other.GetType() != typeof(FooResult))
        {
            return false;
        }

        return Equals((FooResult)other);
    }
}