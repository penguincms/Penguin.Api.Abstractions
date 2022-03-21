using Penguin.Api.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.Api.Abstractions.Extensions
{
    public static class ITryGetReplacementExtensions
    {
        public static string FindReplacement(this ITryGetReplacement source, string toReplace, IApiPlaylistSessionContainer Container)
        {
            if (source.TryFindReplacement(toReplace, Container, out object v))
            {
                return v.ToString();
            }
            else
            {
                throw new Exception($"Can not find replacement for '{toReplace}'");
            }
        }
        public static bool TryFindReplacement(this ITryGetReplacement source, string toReplace, IApiPlaylistSessionContainer Container, out object v)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (toReplace is null)
            {
                throw new ArgumentNullException(nameof(toReplace));
            }

            foreach (string possibility in toReplace.Split(new string[] { " ?? " }, StringSplitOptions.None))
            {
                if (source.TryGetReplacement(possibility.Trim(), Container, out object newValue))
                {
                    v = newValue;
                    return true;
                }
            }

            v = null;
            return false;
        }
    }
}
