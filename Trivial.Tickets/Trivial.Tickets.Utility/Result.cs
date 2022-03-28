﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivial.Tickets.Utility
{
    public class Result<T>
    {
        private Exception? m_Error = null;
        private TypeWrapper<T>? m_Value = null;

        public Result(T Value) => m_Value =
            Value != null ?
            new TypeWrapper<T> { WrappedValue = Value } :
            null;

        public Result(Exception Error) => m_Error = Error;

        public bool HasError => m_Error != null;
        public bool HasValue => m_Value != null;

        public Exception Error => HasError ? m_Error! : throw new NullReferenceException();
        public T Value => HasValue ? m_Value!.WrappedValue : throw new NullReferenceException();

        public static implicit operator Result<T>(T Value) => new Result<T>(Value);
        public static implicit operator Result<T>(Exception Error) => new Result<T>(Error);
        public static implicit operator T(Result<T> R) => R.m_Value.WrappedValue;
        public static implicit operator Exception(Result<T> R) => R.m_Error;

        /* Container for wrapping types 
         * in order to support class, struct and interface types in Maybe */
        private class TypeWrapper<Type>
        {
            public Type WrappedValue { get; set; }
        }

        public static Result<T2> Bind<T1, T2>(Result<T1> Result, Func<T1, Result<T2>> Func) =>
            Result.HasValue ? Func(Result.Value) : new Result<T2>(Result.Error);

        public Result<T2> Bind<T2>(Func<T, Result<T2>> Func) =>
            HasValue ? Func(Value) : new Result<T2>(Error);

        public Result<T2> Map<T2>(Func<T, T2> Func) =>
            HasValue ? new Result<T2>(Func(Value)) : new Result<T2>(Error);
    }
}
