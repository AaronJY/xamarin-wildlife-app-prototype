using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wildlife.Services
{
    public class WildlifeHttpService : IWildlifeHttpService
    {
        readonly IRestClient _rest;

        public WildlifeHttpService()
        {
        }
        public WildlifeHttpService(IRestClient restClient)
        {
            _rest = restClient;
        }

        public IEnumerable<object> GetListing()
        {
            return Enumerable.Empty<object>();
        }
    }
}
