using System;

namespace MsNetflixTitles.Domain.Builder
{
    public interface INetflixTitleBuilder
    {
        public INetflixTitleBuilder WithId(Guid id);

        public INetflixTitleBuilder WithTitle(string title);

        public INetflixTitleBuilder WithDirector(string director);

        public INetflixTitleBuilder WithCast(string cast);

        public INetflixTitleBuilder WithCountry(string country);

        public INetflixTitleBuilder WithDurationMin(int durationMin);

        public INetflixTitleBuilder WithDescription(string description);

        public NetflixTitle Build();
    }
}