﻿using Penguin.Web.Abstractions.Interfaces;

namespace Penguin.Api.Abstractions.Interfaces
{
    public interface IApiPlaylistSessionContainer
    {
        IWebClient Client { get; }

        IApiServerInteractionCollection Interactions { get; set; }

        IJavascriptEngine JavascriptEngine { get; }

        IObjectArray SessionObjects { get; }
    }
}