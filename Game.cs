using System;
using System.Collections.Generic;
namespace WORLDLE {
    public class game {
        private int score;
        private Country country;
        private List<Country> countries;
        private bool running;


        public game (){
            countries = new List<Country>();
            string[] lines = File.ReadAllLines("contries.csv");
            foreach (string line in lines){
                countries.Add(csvline_country(line));
            }
            score = 0;
            int rand = 0;
            running = true;
            //create a random number between 0 and 192
            country = countries[rand];
        }
        public Country csvline_country (string line){
            string[] s = line.Split(',');
            return new Country(int.Parse(s[0]),
                               float.Parse(s[1]),
                               float.Parse(s[2]),
                               float.Parse(s[3]),
                               float.Parse(s[4]), 
                               float.Parse(s[5]), 
                               s[6], 
                               s[7], 
                               s[8]);
        }

        public void run (){
            while (running){
                Console.WriteLine("\n guess a country \n");
                string guess = Console.ReadLine();//skal tage konsol input
                running = country.Compare(countries[0]);
            Console.WriteLine("{0} you won the game", score);
            }
        }
    }
}