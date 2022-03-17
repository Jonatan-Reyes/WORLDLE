using System;
using System.Collections.Generic;
namespace WORLDLE {
    public class Country{
        private int numvalue;
        private float c_longitude;
        private float c_latitude;
        private float area;
        private float population;
        private float capita_gdp;
        private string religion;
        private string language;
        private string currency;

        public Country (int num, float lo, float la, float ar,float pop, float gdp, string rel, string lan, string curr) {
            numvalue = num;
            c_longitude = lo;
            c_latitude = la;
            area = ar;
            population = pop;
            capita_gdp = gdp;
            religion = rel;
            currency = curr;
        }

        public void OneComp(float checker, string heuristic) {
            if (checker < 10){
                Console.WriteLine("{0}: close \n", heuristic);
                }
            else if (checker < 5) {
                Console.WriteLine("{0}: correct \n", heuristic);
            }
            else {
                Console.WriteLine("{0}: incorrect \n", heuristic);
            }

        }

        public bool Compare(Country count){
            float longcomp = Math.Abs(c_longitude - count.c_longitude);
            float latcomp = Math.Abs(c_latitude - count.c_latitude);
            float areacomp = Math.Abs(area - count.area)/(area/100);
            float popcomp = Math.Abs(population - count.population)/(population/100);
            float gdpcomp = Math.Abs(capita_gdp - count.capita_gdp)/(popcomp/100);
            bool relcomp = (religion == count.religion);
            bool langcomp = (language == count.language);
            bool cur = (currency == count.currency);
            OneComp(longcomp, "Capital Longitude");
            OneComp(latcomp, "Capital latitude");
            OneComp(areacomp, "Area");
            OneComp(popcomp, "Population");
            OneComp(gdpcomp, "gdp");
            Console.WriteLine(relcomp);
            Console.WriteLine(langcomp);
            Console.WriteLine(cur);
            return (numvalue == count.numvalue);
        }
    }
}