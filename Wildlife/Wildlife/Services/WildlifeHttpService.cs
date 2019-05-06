using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wildlife.Models;

namespace Wildlife.Services
{
    public class WildlifeHttpService : IWildlifeHttpService
    {
        readonly IRestClient _rest;

        public WildlifeHttpService(IRestClient restClient)
        {
            _rest = restClient;
        }

        public async Task<IEnumerable<Species>> GetListing()
        {
            return new List<Species>
            {
                new Species { Id = Guid.NewGuid(), Name = "Pig" },
                new Species { Id = Guid.NewGuid(), Name = "Cow" },
                new Species { Id = Guid.NewGuid(), Name = "Sheep" }
            };
        }

        public async Task<SpeciesDetail> GetSpeciesById(Guid id)
        {
            return new SpeciesDetail
            {
                Id = id,
                Description = "This is a test description!",
                LatestSighting = DateTime.Now,
                Name = "Eagle"
            };
        }
    }
}
