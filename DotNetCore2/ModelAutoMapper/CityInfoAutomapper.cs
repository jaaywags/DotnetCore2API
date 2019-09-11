using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore2.ModelAutoMapper
{
    public static class CityInfoAutoMapper
    {
        public static void Build()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Entities.City, Models.CityWithoutPointsOfInterestDto>();
                cfg.CreateMap<Entities.City, Models.CityDto>();
                cfg.CreateMap<Entities.PointOfInterest, Models.PointsOfInterestDto>();
                cfg.CreateMap<Models.PointOfInterestForCreationDto, Entities.PointOfInterest>();
                cfg.CreateMap<Models.PointOfInterestForUpdateDto, Entities.PointOfInterest>();
                cfg.CreateMap<Entities.PointOfInterest, Models.PointOfInterestForUpdateDto>();
            });
        }
    }
}
