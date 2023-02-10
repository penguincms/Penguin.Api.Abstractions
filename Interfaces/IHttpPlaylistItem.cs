using Penguin.Web.Abstractions.Interfaces;

namespace Penguin.Api.Abstractions.Interfaces
{
    public interface IHttpPlaylistItem<TRequest, TResponse> : IHttpPlaylistItem where TRequest : IApiPayload where TResponse : IApiServerResponse
    {
        new TRequest Request { get; }

        new TResponse Response { get; }

        new IApiServerInteraction<TRequest, TResponse> Execute(IApiPlaylistSessionContainer Container);

        bool TryCreate(IHttpServerRequest request, IHttpServerResponse response, out IHttpPlaylistItem<TRequest, TResponse> item);
    }

    public interface IHttpPlaylistItem : IPlaylistItem<IApiServerInteraction>
    {
        IApiPayload Request { get; }

        IApiServerResponse Response { get; }

        string Url { get; set; }

        bool TryCreate(IHttpServerRequest request, IHttpServerResponse response, out IHttpPlaylistItem item);
    }
}