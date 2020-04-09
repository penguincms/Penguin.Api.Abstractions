using Penguin.Api.Abstractions.Enumerations;

namespace Penguin.Api.Abstractions.Interfaces
{
    public interface IApiServerResponse : IApiPayload
    {
        string Body { get; set; }
        ApiServerResponseStatus Status { get; set; }
    }
}