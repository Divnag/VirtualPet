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
            Console.Clear();
            Console.WriteLine("Your Pet name :" + name);
            petOne = new DigiPet();

            int userOption;
            petOne.ASC();
            Console.WriteLine("\nCurrent status of your Pet");
            Console.WriteLine("Hunger------ " + petOne.Hunger);
            Console.WriteLine("Thirst level------" + petOne.Thirst);
            Console.WriteLine("Mood of the Bird-----" + petOne.Mood);
            Console.WriteLine("Want to go to Dance-----"+petOne.Dance+"  \n");
            Console.WriteLine("What do you want to do with your pet");
          
           
            do
            {
                
                Console.WriteLine("To Feed Food: select: 1");
                Console.WriteLine("To Feed water: select: 2");
                Console.WriteLine("To Cuddle: select: 3");
                Console.WriteLine("To Dance: select: 4");
                Console.WriteLine("To see status with Pet select: 5.To quit.select :6");
                

              
                userOption = int.Parse(Console.ReadLine());
                
                switch (userOption)
                {
                    
                    case 1:
                        petOne.Feed();
                         petOne.Count++;
                           break;
                    case 2:

                        petOne.Thirsty();
                        petOne.Count++;
                        break;
                    case 3:

                        petOne.Cuddle();
                        petOne.Count++;
                        break;
                    case 4:

                        petOne.MusicTime();
                        petOne.Count++;
                        break;
                    case 5:
                        Console.WriteLine("Current status of your Pet");
                        Console.WriteLine("Hunger------ " + petOne.Hunger);
                        Console.WriteLine("Thirst level ---------" + petOne.Thirst);
                        Console.WriteLine("Mood of the Bird-------- " + petOne.Mood);
                        Console.WriteLine("Want to Dance------"+petOne.Dance+"\n");
                        break;
                    default:

                        Console.WriteLine("Choose appropriate action");
                        break;
                  
                }
               
                if (petOne.Count >= 3)
                {
                    petOne.Tick();
                    
                }
                
            } while (userOption!=6);

            Console.WriteLine("Current status of your Pet");
            Console.WriteLine("Hunger------ " + petOne.Hunger);
            Console.WriteLine("Thirst level ---------" + petOne.Thirst);
            Console.WriteLine("Mood of the Bird-------- " + petOne.Mood);
            Console.WriteLine("Bored------- " + petOne.Boredom);
            Console.WriteLine("Want to Dance\n");
            
        }

    }
}



