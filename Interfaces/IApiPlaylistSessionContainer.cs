using Penguin.Web.Abstractions;
using System.Collections.Generic;

namespace Penguin.Api.Abstractions.Interfaces
{
    public interface IApiPlaylistSessionContainer
    {
        IWebClient Client { get; }
        IJavascriptEngine JavascriptEngine { get; }
        Dictionary<string, IApiServerResponse> PreviousResponses { get; set; }
    }
}