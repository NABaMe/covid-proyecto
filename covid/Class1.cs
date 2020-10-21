using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid
{
    class Class1
    {
        public class Global
        {
            //Esta parte mira en la clase2 xd
            public int NewConfirmed { get; set; }
            public int TotalConfirmed { get; set; }
            public int NewDeaths { get; set; }
            public int TotalDeaths { get; set; }
            public int NewRecovered { get; set; }
            public int TotalRecovered { get; set; }
        }

        public class Countries
        {
            public string Country { get; set; }
            public string CountryCode { get; set; }
            public string Slug { get; set; }
            public int NewConfirmed { get; set; }
            public int TotalConfirmed { get; set; }
            public int NewDeaths { get; set; }
            public int TotalDeaths { get; set; }
            public int NewRecovered { get; set; }
            public int TotalRecovered { get; set; }
            public DateTime Date { get; set; }
        }

        public class Result
        {
            public Global Global { get; set; }
            public IList<Countries> countries { get; set; }
            public DateTime Date { get; set; }
        }
    }
}
