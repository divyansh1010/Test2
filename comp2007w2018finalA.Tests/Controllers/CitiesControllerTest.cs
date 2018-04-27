using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using comp2007w2018finalA.Models;
using comp2007w2018finalA.Controllers;
using System.Linq;
using System.Web.Mvc;

namespace comp2007w2018finalA.Tests.Controllers
{

    [TestClass]
    public class CitiesControllerTest
    {
        // variables
        Mock<IMockCityRepository> mock;
        CitiesController controller;
        List<City> cities;

        [TestInitialize]
        public void TestInitialize()
        {
            mock = new Mock<IMockCityRepository>();

            cities = new List<City>
            {
                new City { CityId = 1, CityName = "Santa Cruz" },
                new City { CityId = 2, CityName = "Mission Viejo"},
                new City { CityId = 3, CityName = "La Jolla" }
            };

            mock.Setup(m => m.Cities).Returns(cities.AsQueryable());

            controller = new CitiesController(mock.Object);
        }
        [TestMethod]
        public void IndexViewLoads()
        {


            // act
            var x = controller.Index();

            //Assert

            Assert.IsNotNull(x);
        }
        [TestMethod]
        public void IndexValidLoadCities()
        {

            var c = (List<City>)((ViewResult)controller.Index()).Model;

            // assert
            CollectionAssert.AreEqual(cities, c);
        }

        [TestMethod]
        public void DetailsValidId()
        {

            var actual = ((ViewResult)controller.Details(1)).Model;


            Assert.AreEqual(cities[0], actual);
        }

        [TestMethod]
        public void DetailsInvalidId()
        {

            var actual = (ViewResult)controller.Details(4);


            Assert.AreEqual("Error", actual.ViewName);
        }

        [TestMethod]
        public void DetailsNoId()
        {

            var actual = (ViewResult)controller.Details(null);


            Assert.AreEqual("Error", actual.ViewName);
        }

    }
}