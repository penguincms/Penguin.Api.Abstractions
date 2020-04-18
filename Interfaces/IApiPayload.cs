﻿using System.Collections.Generic;

namespace Penguin.Api.Abstractions.Interfaces
{
    public interface IApiPayload
    {
        string Url { get; }
        IDictionary<string, string> Headers { get; }

        void SetValue(string path, string Value);

        void SetValue(string path, string Value, string newPropName);

        bool TryGetValue(string path, out string value);
    }
}