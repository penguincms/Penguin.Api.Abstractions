using Penguin.Api.Abstractions.Enumerations;
using System;

namespace Penguin.Api.Abstractions.Interfaces
{
    public interface IApiServerResponse : IApiPayload
    {
        string Body { get; set; }
        ApiServerResponseStatus Status { get; set; }
        Exception Exception { get; }
    }
}