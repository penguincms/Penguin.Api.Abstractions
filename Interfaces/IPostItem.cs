using Penguin.Api.Abstractions.Enumerations;

namespace Penguin.Api.Abstractions.Interfaces
{
    public interface IPostItem
    {
        void FillBody(string source);
        PostMethod Method { get; set; }
    }
}