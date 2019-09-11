﻿using System.Collections.Generic;

namespace DotNetCore2.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfPointsOfInterest => PointsOfInterest.Count;

        public ICollection<PointsOfInterestDto> PointsOfInterest { get; set; }
            =new List<PointsOfInterestDto>();
    }
}