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
                countries.Add(new Country() {});
            }
            score = 0;
            rand = 0;
            running = true;
            //create a random number between 0 and 192
            country = countries[rand];
        }

        public void run (){
            while (running)
                Console.WriteLine("\n guess a country \n");
                guess = Console.ReadLine();
                Country.Compare(guess);
        }
    }
}