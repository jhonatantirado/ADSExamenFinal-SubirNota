using System.Collections.Generic;
using Common.Infrastructure.Repository;
using Locations.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Locations.Domain.Repository{
    public class LocationsRepository : BaseRepository<Location>, ILocationsRepository
    {
        public LocationsRepository(PracticaExamenContext dbContext) : base(dbContext)
        {
        }

        public void save(Location location)
        {
            base.Update(location);
        }
        public void deactivate(long id){
            Location location = base.GetById(id);
            location.IsActive = false;
            base.Update(location);

        }
        public void activate(long id){
            Location location = base.GetById(id);
            location.IsActive = true;
            base.Update(location);
        }
        public Location findByUNLocCode (string unLocCode){
            return base.Context.Set<Location>().Where(x => x.UNLocCode==unLocCode && x.IsActive).FirstOrDefault();
        }
        public List<Location> findByCountryISOCode (string countryISOCode){
            return base.Context.Set<Location>().Where(x => x.CountryISOCode==countryISOCode && x.IsActive).ToList();
        }
    }
}