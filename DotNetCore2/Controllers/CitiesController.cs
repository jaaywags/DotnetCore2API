using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCore2.Models;
using DotNetCore2.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore2.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        private ICityInfoRepository _cityInfoRepository;
        public CitiesController(ICityInfoRepository cityInfoRepository)
        {
            _cityInfoRepository = cityInfoRepository;
        }

        [HttpGet()]
        public IActionResult GetCities()
        {
            var cityEntities = _cityInfoRepository.GetCities();
            var results = Mapper.Map<IEnumerable<CityWithoutPointsOfInterestDto>>(cityEntities);

            return Ok(results);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id, bool includePointsOfInterest = false)
        {

            var city = _cityInfoRepository.GetCity(id, includePointsOfInterest);

            if (city == null)
            {
                return NotFound();
            }

            if (includePointsOfInterest == true)
            {
                var cityResults = Mapper.Map<CityDto>(city);
                return Ok(cityResults);
            }


            var cityWithoutPointsOfInterestDtoResult = Mapper.Map<CityWithoutPointsOfInterestDto>(city);
            return Ok(cityWithoutPointsOfInterestDtoResult);


            //            var results = new List<CityWithoutPointsOfInterestDto>();
            //
            //            foreach (var city in cityEntities)
            //            {
            //                results.Add(new CityWithoutPointsOfInterestDto
            //                {
            //                    Id = city.Id,
            //                    Description = city.Description,
            //                    Name = city.Name
            //                });
            //            }
            //
            //            return Ok(results);
        }
    }
}
