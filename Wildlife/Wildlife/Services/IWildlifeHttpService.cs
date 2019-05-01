using System.Collections.Generic;

namespace Wildlife.Services
{
    public interface IWildlifeHttpService
    {
        IEnumerable<object> GetListing();
    }
}
