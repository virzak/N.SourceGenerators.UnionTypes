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
        private readonly global::MyApp.Success? _Success;
        public bool IsSuccess => _Success != null;
        public global::MyApp.Success AsSuccess => _Success ?? throw new InvalidOperationException("This is not a Success");
        public Result(global::MyApp.Success Success)
        {
            System.ArgumentNullException.ThrowIfNull(Success);
            _Success = Success;
        }

        public static implicit operator Result(global::MyApp.Success Success) => new Result(Success);
        public static explicit operator global::MyApp.Success(Result value) => value.AsSuccess;
        private readonly global::MyApp.Error? _Error;
        public bool IsError => _Error != null;
        public global::MyApp.Error AsError => _Error ?? throw new InvalidOperationException("This is not a Error");
        public Result(global::MyApp.Error Error)
        {
            System.ArgumentNullException.ThrowIfNull(Error);
            _Error = Error;
        }

        public static implicit operator Result(global::MyApp.Error Error) => new Result(Error);
        public static explicit operator global::MyApp.Error(Result value) => value.AsError;
        public TOut Match<TOut>(global::System.Func<global::MyApp.Success, TOut> matchSuccess, global::System.Func<global::MyApp.Error, TOut> matchError)
        {
            if (IsSuccess)
                return matchSuccess(AsSuccess);
            if (IsError)
                return matchError(AsError);
            throw new InvalidOperationException("Unknown type");
        }

        public async global::System.Threading.Tasks.Task<TOut> MatchAsync<TOut>(global::System.Func<global::MyApp.Success, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<TOut>> matchSuccess, global::System.Func<global::MyApp.Error, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<TOut>> matchError, global::System.Threading.CancellationToken ct)
        {
            if (IsSuccess)
                return await matchSuccess(AsSuccess, ct).ConfigureAwait(false);
            if (IsError)
                return await matchError(AsError, ct).ConfigureAwait(false);
            throw new InvalidOperationException("Unknown type");
        }

        public void Switch(global::System.Action<global::MyApp.Success> switchSuccess, global::System.Action<global::MyApp.Error> switchError)
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

            throw new InvalidOperationException("Unknown type");
        }

        public async global::System.Threading.Tasks.Task SwitchAsync(global::System.Func<global::MyApp.Success, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> switchSuccess, global::System.Func<global::MyApp.Error, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> switchError, global::System.Threading.CancellationToken ct)
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
                throw new InvalidOperationException("Unknown type");
            }
        }
    }
}