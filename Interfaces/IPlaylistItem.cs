using System.Collections.Generic;

namespace Penguin.Api.Abstractions.Interfaces
{
    public interface IPlaylistItem<TRequest, TResponse> : IPlaylistItem where TRequest : IApiPayload where TResponse : IApiServerResponse
    {
        new TRequest Request { get; }
        new TResponse Response { get; }

        new IApiServerInteraction<TRequest, TResponse> Execute(IApiPlaylistSessionContainer Container);
    }

    public interface IPlaylistItem
    {
        void Reset();
        bool Enabled { get; }
        bool Executed { get; }
        string Id { get; set; }
        IApiPayload Request { get; }
        IApiServerResponse Response { get; }
        List<ITransformation> Transformations { get; set; }
        string Url { get; set; }

        IApiServerInteraction Execute(IApiPlaylistSessionContainer Container);
    }
}