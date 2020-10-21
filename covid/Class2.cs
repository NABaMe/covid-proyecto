using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid
{
    class Class2
    {
        public static class Filtrado
        {
            private static string _valorGlobal = string.Empty;

            public static string valorGlobal
            {
                get { return _valorGlobal; }
                set { _valorGlobal = value; }
            }
        }
        public class Application
            {
                //Acá se reciben todos los datos
                public string Country { get; set; }
                public string CountryCode { get; set; }
                public string Province { get; set; }
                public string City { get; set; }
                public string CityCode { get; set; }
                public string Lat { get; set; }
                public string Lon { get; set; }
                public int Confirmed { get; set; }
                public int Deaths { get; set; }
                public int Recovered { get; set; }
                public int Active { get; set; }
                public DateTime Date { get; set; }

            public override string ToString()
            {
                //Acá se reenvian todos los datos, osea aca tenes que poner los datos que queres usar
                //La primera variable que cargas siempre tiene que ser de tipo String
                return String.Format(Country, Confirmed, Recovered, Deaths, Active, CountryCode, Date);   
            }
        }

        public class Result
            //En este no es necesario pero en la Clase1 si ya que son tipos diferentes de json
            //Crea una lista de todos los datos
        {
            public IList<Application> country { get; set; }
            public DateTime Date { get; set; }
        }
    }
}
