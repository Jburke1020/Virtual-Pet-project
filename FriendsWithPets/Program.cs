using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsWithPets
{


    class Program
    {
        public static int userNumber;
       




        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("                                   ");
            Console.WriteLine("          Abbie the Ameoba         ");
            Console.WriteLine("                                  ");
            Console.WriteLine("      |   1    |   2    |   3    |");
            Console.WriteLine("      |--------|--------|--------|");
            Console.WriteLine("      | Hunger |" + " Thirst |" + " Energy |");
            Console.WriteLine("      |        |        |        |         ");
            Console.WriteLine("");


            Console.WriteLine("What would you like to do today?");
            DisplayPetcareChoices();         
                
                       
        }
         
            
                
        
         public static void DisplayPetcareChoices()
        {
            Console.WriteLine("[1] Feed your pet\n" +
                              "[2] Water your pet\n" +
                              "[3] Put your pet to bed\n");
            VirtualPet input = new VirtualPet();
            input.GetAnswer(userNumber);
        }
       

        }

        }
       
            
    
    
