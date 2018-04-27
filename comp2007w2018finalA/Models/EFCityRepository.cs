using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace comp2007w2018finalA.Models
{
    public class EFCityRepository : IMockCityRepository
    {
        private FishTacoModel db = new FishTacoModel();

        public IQueryable<City> Cities
        {
            get { return db.Cities; }
        }

    }
}