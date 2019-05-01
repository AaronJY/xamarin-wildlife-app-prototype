using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wildlife.Models;

namespace Wildlife.Services
{
    public interface IWildlifeHttpService
    {
        Task<IEnumerable<Species>> GetListing();
        Task<SpeciesDetail> GetSpeciesById(Guid id);
    }
}
