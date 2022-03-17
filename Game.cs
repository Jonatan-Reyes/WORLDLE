using System;
using System.Collections.Generic;
namespace WORLDLE {
    public class game {
        private int score;
        private Country country;
        private List<Country> countries;
        private bool running;


        public game (){
            for (int i = 0; i < 192; i++) {
                countries.Add(new Country(10, 10.0f, 10.0f, 10000.0f, 10000.0f, 1.0f, "kristen", "dansk", "kroner"));
            }

            score = 0;
            int rand = 0;
            running = true;
            //create a random number between 0 and 192
            country = countries[rand];
        }

        public void run (){
            while (running){
                Console.WriteLine("\n guess a country \n");
                string guess = Console.ReadLine();//skal tage konsol input
                running = country.Compare(countries[0]);
            }
            Console.WriteLine("{0} you won the game", score);
        }
    }
}