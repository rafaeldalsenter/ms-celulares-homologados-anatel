using Cassandra.Mapping;
using MsNetflixTitles.Domain;

namespace MsNetflixTitles.Api.Configs
{
    public class MapperCassandraContext : Mappings
    {
        public MapperCassandraContext()
        {
            For<NetflixTitle>()
                .TableName("netflix_titles")
                .PartitionKey(u => u.Id)
                .Column(u => u.Id, cm => cm.WithName("id"))
                .Column(u => u.Cast, cm => cm.WithName("cast"))
                .Column(u => u.Country, cm => cm.WithName("country"))
                .Column(u => u.Description, cm => cm.WithName("description"))
                .Column(u => u.Director, cm => cm.WithName("director"))
                .Column(u => u.DurationMin, cm => cm.WithName("duration_min"));
        }
    }
}