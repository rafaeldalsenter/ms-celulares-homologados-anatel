using System;

namespace MsNetflixTitles.Domain.Builder
{
    public class NetflixTitleBuilder : INetflixTitleBuilder
    {
        private Guid _id;
        private string _cast;
        private string _country;
        private string _description;
        private string _director;
        private int _durationMin;
        private string _title;

        public NetflixTitle Build() => new NetflixTitle(_id, _title, _director, _cast, _country, _durationMin, _description);

        public INetflixTitleBuilder WithCast(string cast)
        {
            _cast = cast;
            return this;
        }

        public INetflixTitleBuilder WithCountry(string country)
        {
            _country = country;
            return this;
        }

        public INetflixTitleBuilder WithDescription(string description)
        {
            _description = description;
            return this;
        }

        public INetflixTitleBuilder WithDirector(string director)
        {
            _director = director;
            return this;
        }

        public INetflixTitleBuilder WithDurationMin(int durationMin)
        {
            _durationMin = durationMin;
            return this;
        }

        public INetflixTitleBuilder WithId(Guid id)
        {
            _id = id;
            return this;
        }

        public INetflixTitleBuilder WithTitle(string title)
        {
            _title = title;
            return this;
        }
    }
}