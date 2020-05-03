using Penguin.SystemExtensions.Abstractions.Interfaces;
using System.Collections.Generic;

namespace Penguin.Api.Abstractions.Interfaces
{
    public interface IApiServerInteractionCollection : IEnumerable<IApiServerInteraction>
    {
        IPropertyDictionary<string, IApiPayload> Requests { get; }
        IPropertyDictionary<string, IApiServerResponse> Responses { get; }
        IApiServerInteraction this[string id] { get; }

        void Add(string id, IApiServerResponse response);

        void Add(string id, IApiPayload request);

        void Add(string id, IApiServerInteraction interaction);

        void Add(IApiServerInteraction interaction);

        (string Id, IApiPayload Request) Request(string id);

        (string Id, IApiServerResponse Response) Response(string id);
    }
}