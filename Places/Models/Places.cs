using System;
using System.Collections.Generic;

namespace Travel.Models
{
  public class Place
  {
    public string CityName { get; set; }

    public Place(string cityName)
    {
      CityName = cityName;
    }
  }
}