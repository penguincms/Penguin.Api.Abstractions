using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.Api.Abstractions.Interfaces
{
    public interface IApiServerInteraction<TRequest, TResponse> : IApiServerInteraction where TRequest : IApiPayload where TResponse : IApiServerResponse
    {
        new TRequest Request { get; }
        new TResponse Response { get; }
    }

    public interface IApiServerInteraction
    {
        string Id { get; set; }
        IApiPayload Request { get; }
        IApiServerResponse Response { get; }
    }
}
