using Penguin.Api.Abstractions.ObjectArrays;
using Penguin.Web.Abstractions;
using System.Collections.Generic;

namespace Penguin.Api.Abstractions.Interfaces
{
    public interface IApiPlaylistSessionContainer
    {
        IWebClient Client { get; }
        IJavascriptEngine JavascriptEngine { get; }
        IApiServerInteractionCollection Interactions { get; set; }
        IObjectArray SessionObjects { get; }
    }
}