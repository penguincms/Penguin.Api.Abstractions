using Penguin.Web.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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

        string Url { get; set; }
        IApiPayload Request { get; }
        IApiServerResponse Response { get; }

        bool TryCreate(IHttpServerRequest request, IHttpServerResponse response, out IHttpPlaylistItem item);
    }
}
