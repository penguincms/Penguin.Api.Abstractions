using System.Collections.Generic;

namespace Penguin.Api.Abstractions.Interfaces
{
    public interface IPlaylistItem<TReturn> : IPlaylistItem
    {
        new TReturn Execute(IApiPlaylistSessionContainer Container);
    }

    public interface IPlaylistItem
    {
        List<IExecutionCondition> Conditions { get; set; }
        bool Enabled { get; }

        bool Executed { get; }

        string Id { get; set; }

        List<ITransformation> Transformations { get; set; }

        void Execute(IApiPlaylistSessionContainer Container);

        void Reset();
    }
}