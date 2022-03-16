namespace WORLDLE {
    public class Country{
        private float c_longitude;
        private float c_latitude;
        private int area;
        private int population;
        private int capita_gdp;
        private string religion;
        private string language;
        private string currency;



        public Country (float lo, float la, int ar,int pop, int gdp, string rel, string lan, string curr) {
            c_longitude = lo
            c_latitude = la
            area = ar
            population = pop
            capita_gdp = gdp
            religion = rel
            language = lan
            currency = curr
        }

        public void Compare(Country count){
            float longcomp = abs(c_longitude - count.c_longitude);
            float latcomp = abs(c_latitude - count.c_latitude);
            int areacomp = area - c.area;
            int popcomp = population - count.population;
            int gdpcomp = capita_gdp - count.capita_gdp;
            bool relcomp = religion == count.religion;
            bool langcomp = language == count.language;
            bool currency = currency == count.currency;
            if (longcomp > )
        }


    }
}