using System.Collections.Generic;

namespace Penguin.Api.Abstractions.Interfaces
{
    public interface IApiPayload
    {
        IDictionary<string, string> Headers { get; }
        string Url { get; }

        void SetValue(string path, object Value);

        void SetValue(string path, object Value, string newPropName);

        bool TryGetValue(string path, out object value);
    }
}