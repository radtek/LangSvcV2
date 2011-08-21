﻿namespace Tvl.Java.DebugInterface
{
    /// <summary>
    /// The type of all primitive double values accessed in the target VM. Calls to
    /// <see cref="IValue.GetValueType()"/> will return an implementor of this interface.
    /// </summary>
    public interface IDoubleType : IPrimitiveType
    {
    }
}
