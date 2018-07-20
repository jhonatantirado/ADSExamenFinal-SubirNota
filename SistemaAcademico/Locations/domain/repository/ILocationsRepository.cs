using System.Collections.Generic;
namespace Locations.Domain.Repository{
    public interface ILocationsRepository
    {
        void save (Location location);
        void deactivate(long id);
        void activate(long id);
        Location findByUNLocCode (string unLocCode);
        List<Location> findByCountryISOCode (string countryISOCode);
    }
}