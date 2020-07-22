using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Travel.Models;
using System;

namespace Travel.Tests
{
  [TestClass]
  public class TestPlace
  {
    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("New York City");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    
  }
}
