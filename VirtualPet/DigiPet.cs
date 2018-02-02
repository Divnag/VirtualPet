using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class DigiPet
    {
        private string name;
        private int hunger;
        private int thirst;
        private string mood;
        private int boredom;
        private string dance;

        public string Name
        {
            get { return this.name; }
            set { this.Name = value; }
        }


        public int Hunger
        {
            get { return this.hunger; }
        }

        public int Thirst
        {
            get { return this.thirst; }
        }
        public string Mood
        {
            get { return this.mood; }
        }


        public int Boredom
        {
            get { return this.boredom; }
        }

        public string Dance
        {
            get { return this.dance; }
        }



        public DigiPet()
        {
            
            this.hunger = 10;
            this.thirst = 0;
            this.boredom = 5;
            this.mood = "Happy";
            
        }
        
          public DigiPet(string name)
        {

            this.name = name;

        }



        public void Feed()
        {
            Console.WriteLine("Done Feeding\n");
            hunger-=10;
            thirst++;
           
                   
        }

        public void Thirsty()
        {
            Console.WriteLine("Drank Water\n");
            thirst--;
            
        }

        public void Cuddle()
        {
            Console.WriteLine("Time to cuddle\n");
            mood = "Happy";
            boredom-=5;
        }
        public void MusicTime()
        {
            
              Console.WriteLine("Do some good Moves with me \a \a\n");
            mood = "Happy";
            boredom -= 5;

            hunger +=5;
        }

        public void Tick()
        {
            Console.WriteLine("Too Tired of doing activities\n");
            hunger+=10;
            Console.WriteLine("Time to eat\n");

            
            if (hunger >= 5)
            {
                boredom+=5;
               
            }
            if (boredom == 5)
            {
                mood = "sad";
                Console.WriteLine("Feeling sad\n");
                dance = "yes";
            }

            Console.WriteLine("Current status of your Pet");
            Console.WriteLine("Hunger------ " + hunger);
            Console.WriteLine("Thirst level ---------" + thirst);
            Console.WriteLine("Mood of the Dog-------- " + mood);
            Console.WriteLine("Bored------- " + boredom);
            Console.WriteLine("Want to Dance\n");
        }
            
            
    }
}
