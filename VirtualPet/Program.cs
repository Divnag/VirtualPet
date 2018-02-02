using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("What do you want to name your Digibird");
            string name = Console.ReadLine();
            DigiPet petOne = new DigiPet(name);
            Console.WriteLine("Your Pet name :" + name);
            petOne = new DigiPet();

            int userOption;
            Console.WriteLine("\nCurrent status of your Pet");
            Console.WriteLine("Hunger------ " + petOne.Hunger);
            Console.WriteLine("Thirst level------" + petOne.Thirst);
            Console.WriteLine("Mood of the Bird-----" + petOne.Mood);
            Console.WriteLine("Want to go to Dance  \n");
            Console.WriteLine("What do you want to do with your pet");
            int count = 0;
            do
            {

                Console.WriteLine("To Feed Food: select: 1");
                Console.WriteLine("To Feed water: select: 2");
                Console.WriteLine("To Cuddle: select: 3");
                Console.WriteLine("To Danace: select: 4");
                Console.WriteLine("To see status with Pet select: 5");


                userOption = int.Parse(Console.ReadLine());

                switch (userOption)
                {
                    case 1:
                        petOne.Feed();
                        count ++;
                        Console.WriteLine(count);
                        break;
                    case 2:

                        petOne.Thirsty();
                        count += 1;
                        break;
                    case 3:

                        petOne.Cuddle();
                        count += 1;
                        break;
                    case 4:

                        petOne.MusicTime();
                        count += 1;
                        break;
                    case 5:
                        Console.WriteLine("Current status of your Pet");
                        Console.WriteLine("Hunger------ " + petOne.Hunger);
                        Console.WriteLine("Thirst level ---------" + petOne.Thirst);
                        Console.WriteLine("Mood of the Dog-------- " + petOne.Mood);
                        Console.WriteLine("Bored------- " + petOne.Boredom);
                        Console.WriteLine("Want to Dance\n");

                        break;
                    default:

                        Console.WriteLine("Choose appropriate action");
                        break;
                  
                }
                if (count >= 3)
                {
                    petOne.Tick();
                }
                //Console.WriteLine("Current status of your Pet");
                //Console.WriteLine("Hunger------ " + petOne.Hunger);
                //Console.WriteLine("Thirst level ---------" + petOne.Thirst);
                //Console.WriteLine("Mood of the Dog-------- " + petOne.Mood);
                //Console.WriteLine("Bored------- " + petOne.Boredom);
                //Console.WriteLine("Want to Dance\n");
                
            } while(userOption!=6);
            
        }
        
     }
}



