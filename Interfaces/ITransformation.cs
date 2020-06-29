using System.Collections.Generic;

namespace Penguin.Api.Abstractions.Interfaces
{
    public interface ITransformation
    {
        string DestinationPath { get; set; }
        string SourcePath { get; set; }

        void Transform(KeyValuePair<string, IApiServerResponse> responseToCheck, IApiPayload destination);

        bool TryGetTransformedValue(IApiServerResponse source, out object newValue);
    }
}