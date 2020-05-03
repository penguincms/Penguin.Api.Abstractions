using Penguin.Api.Abstractions.Enumerations;

namespace Penguin.Api.Abstractions.Interfaces
{
    public interface IPostItem
    {
        PostMethod Method { get; set; }

        void FillBody(string source);
    }
}