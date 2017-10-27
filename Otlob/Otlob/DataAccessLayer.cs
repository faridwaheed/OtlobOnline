using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Otlob
{
    public class DataAccessLayer
    {
        DBEntities DB = new DBEntities();

        public List<Country> GetCountries()
        {
            return DB.Countries.ToList();
        }
        public List<State> GetStates()
        {
            return DB.States.ToList();
        }

        public List<State> GetStatesByCountryID(int CountryID)
        {
            DB.Configuration.ProxyCreationEnabled = false;
            return DB.States.Where(p => p.country_id == CountryID).ToList();
        }

        public List<Pharmacy> GetPharamaciesByStateID(int StateID)
        {
            DB.Configuration.ProxyCreationEnabled = false;
            return DB.Pharmacies.Where(p => p.state_id == StateID).ToList();
        }
    }

}