using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.Api.Abstractions.ObjectArrays
{
    public interface IObjectArray
    {
        string this[string index] { get; }
        string Get(string index);
    }
}
