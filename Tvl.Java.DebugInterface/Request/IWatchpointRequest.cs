﻿namespace Tvl.Java.DebugInterface.Request
{
    public interface IWatchpointRequest : IEventRequest
    {
        void AddClassExclusionFilter(string classPattern);

        void AddClassFilter(IReferenceType referenceType);

        void AddClassFilter(string classPattern);

        void AddInstanceFilter(IObjectReference instance);

        void AddThreadFilter(IThreadReference thread);

        IField GetField();
    }
}
