using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.Api.Abstractions.Interfaces
{
    public interface ITryGetReplacement
    {
        bool TryGetReplacement(string toReplace, IApiPlaylistSessionContainer Container, out object v);
    }
}
