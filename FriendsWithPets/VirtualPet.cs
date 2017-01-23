using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsWithPets
{

    class VirtualPet

    {
        private int hunger;
        private int thirst;
        private int energy;


        //Constructors with parameters

        public int Hunger
        {
            get
            {
                return this.hunger;
            }
            set
            {
                this.hunger = value;
            }

        }

        public int Thirst
        {
            get
            {
                return this.thirst;
            }
            set
            {
                this.thirst = value;
            }
        }

        public int Energy
        {
            get
            {
                return this.energy;
            }
            set
            {
                this.energy = value;
            }
        }

        public void GetAnswer(int userNumber)
        {

            {
                while (userNumber < 1 || userNumber > 3)
                    try
                    {
                        Console.Write("Enter a number 1, 2, or 3 from the categories above: ");
                        string userResponse = Console.ReadLine();
                        userNumber = Convert.ToInt32(userResponse);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("That is not a valid number.  Try again.");
                    }
                if (userNumber == 1 || userNumber == 2 || userNumber == 3)
                {
                    string H = "You fed your pet.";
                    string T = "You watered your pet.";
                    string B = "You put your pet to bed";

                    do
                    {
                        if (userNumber == 1)
                        {

                            Console.WriteLine(H);
                            VirtualPet satiatedPet = new VirtualPet();
                            satiatedPet.Hunger = 2;
                            Console.Write(satiatedPet.Hunger + "  is the updated Hunger Level.");
                        }
                        else if (userNumber == 2)
                        {
                            Console.WriteLine(T);
                            VirtualPet quenchedPet = new VirtualPet();
                            quenchedPet.Thirst = 4;
                            Console.Write(quenchedPet.Thirst + "  is the updated Thirst Level.");
                        }
                        else if (userNumber == 3)
                        {
                            Console.WriteLine(B);
                            VirtualPet energizedPet = new VirtualPet();
                            energizedPet.Energy = 2;
                            Console.Write(energizedPet.Energy + "  is the updated Energy Level.");
                        }

                        break;
                    } while (true);

                }


            }


            //Constructors with parameters        
            /* didn't use these methods but wrote them in the class for future use;
               some envoke properties

                    public void StoreKey(int userNumber)
                    {
                        int x;
                        x = userNumber;

                    }
                    public void Update()
                    {
                        //private setter is used in the constructor.
                        this.Score = new Random().Next(51);
                    }
                    public int Score
                    {
                        get;
                        private set;
                    }


                    public void HealthScoreUpdate(int x)
                    {
                        for (int current = userNumber; current <= x; current++)
                            Console.WriteLine(current * 2);

                    }

                    public void ShowHealthScore(int x)
                    {
                        switch (x)
                        {
                            case 3:
                                Console.Write("  is the updated Hunger Level.");
                                break;
                            case 2:
                                Console.Write("  is the updated Thirst Level.");
                                break;
                            case 1:
                                Console.Write("  is the updated Energy Level.");
                                break;
                        }

                    }
                }*/

        }
    }
}