using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Locations.Domain.Repository;

namespace Locations.API{
    public class LocationController : Controller{
        private readonly ILocationsRepository  _locationsRepository;
        public LocationController(ILocationsRepository locationsRepository)
        {
            _locationsRepository = locationsRepository;
        }
    }
    
}