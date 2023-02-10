namespace Penguin.Api.Abstractions.Interfaces
{
    public interface IObjectArray
    {
        string this[string index] { get; }

        string Get(string index);
    }
}