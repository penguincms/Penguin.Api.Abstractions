﻿namespace Penguin.Api.Abstractions.Interfaces
{
    public interface IExecutionCondition
    {
        bool ShouldExecute(IApiPlaylistSessionContainer Container);
    }
}