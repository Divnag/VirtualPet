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
        private int count = 0;

        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }
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
            this.dance = "yes";

        }

        public DigiPet(string name)
        {

            this.name = name;

        }



        public void Feed()
        {
            Console.Clear();
            string[] foodList = new string[4];
            foodList[0] = "Carrot";
            foodList[1] = "Honey";
            foodList[2] = "Nuts";
            foodList[3] = "Fruit";
            Console.WriteLine("Choose meal to feed the bird {0},{1},{2},{3}",foodList[0],foodList[1],foodList[2],foodList[3]);
            string select = Console.ReadLine();

            if (hunger == 0)
            {
                Console.WriteLine("I am full now");
            }
            else 
            Console.WriteLine("Food was so Tasty."+"I love "+select+"\n");
            count--;
           
            hunger -= hunger;
            thirst++;

            
        }

        public void Thirsty()
        {
            Console.Clear();
           
            count--;
            if (thirst == 0)
            {
                Console.WriteLine("I don't want Water,Thank you");
            }
            else
            {
                Console.WriteLine("Thanks for the water.I was so Thirsty\n");
                thirst -= thirst;
            } 

        }

        public void Cuddle()
        {
            Console.Clear();
            
            Console.WriteLine("Cuddling makes me Happy\n");
            mood = "Happy";
            boredom -= 5;
            hunger += 5;
            
            if(count>3)
            {
                Console.WriteLine("You are Cuddling me a lot SUPER HAPPY!!!!");
            }
        }


        public void MusicTime()
        {
          Console.Clear();
           if (dance == "yes")
            
               
                dance = "no";

                Console.WriteLine("Do some good Moves with me \a \a\n");
                mood = "Happy";
                boredom -= 5;
                hunger += 5;

            if (count > 3)
            {
                Console.WriteLine("Too much Dancing made me tired");
                hunger += 5;
            }

        }

        public void Tick()
        {

           

            if (thirst >= 5)

            {
                Console.WriteLine("Too Tired of doing activities\n");
                
                Console.WriteLine("I am Thirsty\n");
                
                boredom += 5;
                mood = "sad";
                Console.WriteLine("Feeling sad\n");
                dance = "No";
            }

            if (hunger >= 5)

            {
                Console.WriteLine("Too Tired of doing activities\n");

                Console.WriteLine("Time to eat\n");

                boredom += 5;
                mood = "sad";
                Console.WriteLine("Feeling sad\n");
                dance = "No";
            }
        }

        public void ASC()
        {
            //var verbatimString = ". -  __ / 6 |  ~ `  o \' )= '' ";
            
                            Console.WriteLine("        __,---.");
                           Console.WriteLine("       /_|o\\   )");
                            Console.WriteLine("       `- \\/  /");
                            Console.WriteLine("          ,) (,");
                            Console.WriteLine("         //   \\\\");
                            Console.WriteLine("       {(       )}");
                            Console.WriteLine("   ===== /\\ === /\\===============");
                            Console.WriteLine("           |||||");
                            Console.WriteLine("            |||");
                            Console.WriteLine("             |");

         
            }
       
    }


}

