using Penguin.Api.Abstractions.Enumerations;
using System;

namespace Penguin.Api.Abstractions.Interfaces
{
    public interface IApiServerResponse : IApiPayload
    {
        string Body { get; set; }
        Exception Exception { get; }
        ApiServerResponseStatus Status { get; set; }
    }
}