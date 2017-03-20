using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int 
            int correct = 0;
            int Attack = 1;//Each character starts with 0 
            int Ranged = 1;//You add points by picking then training
            int Magic = 1;//Everyone starts with 1
            int Arraycount = 0;//Initial array is 0 
            int Player_Attack_Type = 0;
            int Player_Health_Points = 20;
            int Player_Looked_Around = 0; //Player looked around in the cell
            int Weak_Health_Potion = 5;
            int Strong_Health_Potion = 20;
            int Random_Health_Potion; //For the random health potion
            int Player_Gold = 0;//You start with 0 gold
            int Rat_Gold = 5; //The gold you get from a Rat
            int Goblin_Gold = 10;
            int Paladin_Gold = 20;
            int Archer_Gold = 20;
            int Wizard_Gold = 20;
            int Dragon_Gold = 1000;







            int Rat_Health_Points;
            int Rat_Maximum_Damage;
            int Goblin_Health_Points;
            int Goblin_Maximum_Damage;
            int Paladin_Health_Points;
            int Paladin_Maximum_Damage;
            int Archer_Health_Points;
            int Archer_Maximum_Damage;
            int Wizard_Health_Points;
            int Wizard_Maximum_Damage;
            int Dragon_Health_Points;
            int Dragon_Maximum_Damage;








            //String;
            string Gender;
            string WarriorType;
            string[] Inventory = new string[20];
            string Input;//This is for the input for Inventory
            string Player_Filled_Cup = "0"; //The metal cup. 0 means it's empty, 1 means it's full
            string Rat;
            string Goblin;
            string Paladin;
            string Archer;
            string Wizard;
            string Dragon;



            //Random integer between 0 and 100(Excluding 100) for combat

            Random random = new Random(); //Instantiated a new random number generator
            int randomNumber = random.Next(0, 100); //the constraints are within an epsilon of 100






            //Enemy Declair System
            Rat = "Rat"; Rat_Health_Points = 12; Rat_Maximum_Damage = 2;
            Goblin = "Goblin"; Goblin_Health_Points = 15; Goblin_Maximum_Damage = 5;
            Paladin = "Paladin"; Paladin_Health_Points = 20; Paladin_Maximum_Damage = 7;
            Archer = "Archer"; Archer_Health_Points = 17; Archer_Maximum_Damage = 12;
            Wizard = "Wizard"; Wizard_Health_Points = 12; Wizard_Maximum_Damage = 15;
            Dragon = "Dragon"; Dragon_Health_Points = 60; Dragon_Maximum_Damage = 100;










            

            do
            {
                Console.Clear();//Clears this same menu so it doesnt keep coming up
                Console.WriteLine("==================================================================================================");
                Console.WriteLine("==================================================================================================");
                Console.WriteLine("==================================================================================================");
                Console.WriteLine("================================   The Transient Prisoner   ======================================");
                Console.WriteLine("==================================================================================================");
                Console.WriteLine("==================================================================================================");
                Console.WriteLine("==================================================================================================");
                Console.WriteLine("================================        Start Game          ======================================");
                Console.WriteLine("==================================================================================================");
                Console.WriteLine("================================          About             ======================================");
                Console.WriteLine("==================================================================================================");
                Console.WriteLine("================================     By: Tareq Karimi       ======================================");
                Console.WriteLine("==================================================================================================");
                Input = Console.ReadLine();
                correct = 0;//Declare it to zero so it won't skip
                if (Input == "Start Game" || Input == "Start")
                {
                    Console.Clear();
                    Console.WriteLine("Are you sure you don't want to at least read About the game and Creator? Yes or No.");
                    Input = Console.ReadLine();
                    if (Input == "Yes")
                    {
                        correct = 1;//This will end the do while loop
                    }
                    if (Input == "No")
                    {
                        correct = 0;//This will loop back to the beginning
                    }
                }
                if (Input == "About")
                {

                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine("Hello, I'm Tareq. Welcome to my game! This is a text based console game, inspired by old console games from the 80s, meaning I did take some lines from other games to make this possible.");
                    Console.WriteLine("This is my first game of hopefully many, and I hope you enjoy it :)");
                    Console.WriteLine("\n");
                    Console.WriteLine(" ");
                    Console.WriteLine("The Transient Prisoner");
                    Console.WriteLine("This game is about a vagabond, travelling for a new home. Upon their path, they come across a subversive Paladin that is looking for trouble.");
                    Console.WriteLine("Unfortunately this passerby is then thrown in prison for harming a Paladin, and he finds out the only way is to pay his way out, through a quest");
                    Console.WriteLine("<Back");
                    Input = Console.ReadLine();
                    if (Input == "Back")
                    {
                        correct = 0;
                    }
                }


            } while (correct == 0);
            correct = 0; //Don't forget to keep adding this, to reset this value   









            //Gender Creation
            do //will run once, if it is required, it will run again. If not it won't run again
            {
                Console.Clear(); //Clears everything on screen
                Console.WriteLine("Please Select a Gender");
                Console.WriteLine("Male / Female");
                Gender = Console.ReadLine(); //It will read your response
                if (Gender == "Male")
                {
                    correct = 1;//This changes the value of correct to 1(overrides), it's an indicator if the user input a proper value
                }
                if (Gender == "Female")
                {
                    correct = 1;
                }
                else { }
            } while (correct == 0); //if correct=0, like we listed before, it will loop back
            correct = 0;//Since we set the value to 1, we have to reset it to 0, so same thing









            //Warrior Creation
            do
            {
                Console.Clear();
                Console.WriteLine("Please choose a WarriorType as seen below");
                Console.WriteLine("Attacker");
                Console.WriteLine("Ranger");
                Console.WriteLine("Mage");
                Console.WriteLine("Balanced");
                Console.WriteLine("Your Choice:");
                WarriorType = Console.ReadLine();
                if (WarriorType == "Attacker")
                {
                    Console.WriteLine("This WarriorType has the following default stats:");
                    Console.WriteLine("Attack: 4");
                    Console.WriteLine("Ranged: 1");
                    Console.WriteLine("Mage: 1");
                    Console.WriteLine("Is this the class you want? Enter Yes/No:");
                    Input = Console.ReadLine();
                    if (Input == "Yes")
                    {
                        correct = 1;
                    }
                    if(Input == "No")
                    {
                        correct = 0;
                    }
                }
                if (WarriorType == "Ranger")
                {
                    Console.WriteLine("This WarriorType has the following default stats:");
                    Console.WriteLine("Attack: 1");
                    Console.WriteLine("Ranged: 4");
                    Console.WriteLine("Mage: 1");
                    Console.WriteLine("Is this the class you want? Enter Yes/No:");
                    Input = Console.ReadLine();
                    if (Input == "Yes")
                    {
                        correct = 1;
                    }
                    if (Input == "No")
                    {
                        correct = 0;
                    }
                }
                if (WarriorType == "Mage")
                {
                    Console.WriteLine("This WarriorType has the following default stats:");
                    Console.WriteLine("Attack: 1");
                    Console.WriteLine("Ranged: 1");
                    Console.WriteLine("Mage: 4");
                    Console.WriteLine("Is this the class you want? Enter Yes/No:");
                    Input = Console.ReadLine();
                    if (Input == "Yes")
                    {
                        correct = 1;
                    }
                    if (Input == "No")
                    {
                        correct = 0;
                    }
                }
                if (WarriorType == "Balanced")
                {
                    Console.WriteLine("This WarriorType has the following default stats:");
                    Console.WriteLine("Attack: 2");
                    Console.WriteLine("Ranged: 2");
                    Console.WriteLine("Mage: 2");
                    Console.WriteLine("Is this the class you want? Enter Yes/No:");
                    Input = Console.ReadLine();
                    if (Input == "Yes")
                    {
                        correct = 1;
                    }
                    if (Input == "No")
                    {
                        correct = 0;
                    }
                }
            } while (correct == 0);
            correct = 0;//Always state this since we set it to 1 to pass the do-while loop




            
            
            
            //Where we give the user their bonus stats
            if (WarriorType == "Attacker")
            {
                Attack += 3; 
            }
            if(WarriorType == "Ranger")
            {
                Ranged += 3;
            }
            if(WarriorType == "Mage")
            {
                Magic += 3;
            }
            if(WarriorType == "Balanced")
            {
                Attack += 1; //or AttackPoints++
                Ranged += 1;
                Magic += 1;
            }





            //Player Description
            do
            {
                Console.Clear();
                Console.WriteLine("Your Full Character Description: ");
                Console.WriteLine("A {0} {1}", Gender, WarriorType);
                Console.WriteLine("Attack: {0}", Attack);
                Console.WriteLine("Ranged: {0}", Ranged);
                Console.WriteLine("Magic: {0}", Magic);
                Console.WriteLine("");
                Console.WriteLine("Continue >");
                Input = Console.ReadLine();
                if (Input == "Continue")
                {
                    correct = 1;
                }
            } while (correct == 0); //If they don't type Continue, it will loop



            //Story Begins
            Console.Clear();
            Console.WriteLine("I'm awaken. Shaken by a man in suited armour");
            Console.ReadLine();
            Console.WriteLine("'You can't sleep here' says the man.");
            Console.ReadLine();
            Console.WriteLine("Who is this man? 'What?' I reply back, in a state of confusion.");
            Console.WriteLine("Who is looking for trouble in the middle of the night?");
            Console.ReadLine();
            Console.WriteLine("'You can't sleep here, this is not your land.' He says.");
            Console.ReadLine();
            Console.WriteLine("'I'm in the middle of a desert, outside the town, not harming anyone. Have you no decency?' I answer back.");
            Console.ReadLine();
            Console.WriteLine("'I said move along you filthy peasant!', he yells.");
            Console.ReadLine();
            Console.WriteLine("My fist clenched, and a surge of blood gushed to my head. This man has to learn a lesson, but I'm at a disadvantage.");
            Console.ReadLine();
            do
            {
                Console.Clear();
                Console.WriteLine("My fist clenched, and a surge of blood gushed to my head. This man has to learn a lesson, but I'm at a disadvantage.");
                Console.ReadLine();
                Console.WriteLine("What do you want to do? Select a number.");
                Console.WriteLine("1. Fight this vacuous, malevolent man. ");
                Console.WriteLine("2. Ignore him completely and go back to sleep");
                Input = Console.ReadLine();
                if (Input == "1")
                {
                    correct = 1;

                    Console.Clear();
                    Console.WriteLine("You swing hard at this man. He gets shoved to the ground");
                    Console.WriteLine("A fight has began");
                    Console.ReadLine();
                }
                if (Input == "2")
                {
                    correct = 1;
                    Console.Clear();
                    Console.WriteLine("You roll around and get ready to sleep again");
                    Console.ReadLine();
                    Console.WriteLine("He grabs you, pulls you back and throws you face first into the dirt");
                    Console.ReadLine();
                    Console.WriteLine("Thats it, you have had enough");
                    Console.WriteLine("A fight has began");
                    Console.ReadLine();
                }
            } while (correct == 0);
            correct = 0; //Restating





            

            //Fighting Paladin Scene
            do
            {
                Console.Clear(); //Clear the screen again
                Console.WriteLine("Your Health is at {0} Points", Player_Health_Points);
                Console.WriteLine("The {0}'s Health is at {1} Points", Paladin, Paladin_Health_Points);
                Console.WriteLine("Enter the number for the type of attack you wish to perform");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Ranged");
                Console.WriteLine("3. Magic");
                Input = Console.ReadLine();
                if (Input == "1" || Input == "Attack")
                {
                    Random Damage_Roll = new Random(); //Instantiates a new random damage 
                    int Random_Damage_Roll = Damage_Roll.Next(0, Attack); //The new random damage ranges from 0 to the guy's attack damage
                    Console.WriteLine("{0}", Random_Damage_Roll);//It outputs the Random_Damage_Roll
                    Random Skill_Point_Roll = new Random();//Setting a skill point roll for Crits
                    int Skill_Point_Outcome = random.Next(0, 11);//A random num between 0 and 10
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)//if the random num is > 0, and your damage > 0, then Crit
                    {
                        Random_Damage_Roll = Random_Damage_Roll * 2;//You will now do twice the damage
                        Console.WriteLine("You did a critical hit, with {0} skill points of damage", Random_Damage_Roll);
                    }

                    else { }

                    Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Paladin);//Tells you the result 
                    Paladin_Health_Points = Paladin_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                }
                if (Input == "2" || Input == "Ranged")
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Ranged);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = random.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)//if the random num is > 0, and your damage > 0, then Crit
                    {
                        Random_Damage_Roll = Random_Damage_Roll * 2;//You will now do twice the damage
                        Console.WriteLine("You did a critical hit, with {0} skill points of damage", Random_Damage_Roll);
                    }

                    else { }

                    Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Paladin);//Tells you the result 
                    Paladin_Health_Points = Paladin_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                }
                if (Input == "3" || Input == "Magic")
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Magic);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = random.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)//if the random num is > 0, and your damage > 0, then Crit
                    {
                        Random_Damage_Roll = Random_Damage_Roll * 2;//You will now do twice the damage
                        Console.WriteLine("You did a critical hit, with {0} skill points of damage", Random_Damage_Roll);
                    }

                    else { }

                    Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Paladin);//Tells you the result 
                    Paladin_Health_Points = Paladin_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                }
                if (Paladin_Health_Points > 0 && ((Input == "1" || Input == "Attack") || (Input == "2" || Input == "Ranged") || (Input == "3" || Input == "Magic")))//If enemy is alive and player inputs a proper value
                {
                    Random Enemy_Damage_Roll = new Random();
                    int Random_Enemy_Damage_Roll = Enemy_Damage_Roll.Next(0, Paladin_Maximum_Damage);
                    Console.WriteLine("The {0} Strikes back, and deals {1} Points of Damage", Paladin, Random_Enemy_Damage_Roll);//A roll to see if enemy is going to hit
                    Player_Health_Points = Player_Health_Points - Random_Enemy_Damage_Roll;//Subtracting damage with my health
                    Console.ReadLine();
                }
                else { }
            } while (Player_Health_Points > 0 && Paladin_Health_Points > 0);
            

            //Battle Completed
            Console.Clear();
            if (Paladin_Health_Points <= 0) //This is in case enemy's hp goes less than 0
            {
                Console.Clear();
                Console.WriteLine("You have knocked the Paladin down. You can now go back to sleep");
                Console.ReadLine();
            }
            if (Player_Health_Points <= 0)//In case your HP is 0 or less
            {
                Console.WriteLine("You are knocked unconscious, losing a battle you probably shouldn't have fought.");
                Console.ReadLine();
            }
            Paladin_Health_Points = 20; //Restating them both after the fight so it doesnt mess us up in the future.
            Player_Health_Points = 20; 




            //Jail Cell
            do
            {
                correct = 0; //Everytime it loops back, we want to make sure correct = 0 so we dont miss nested do while loops
                Console.Clear();
                Console.WriteLine("You have just woken up in what seems like a dungeon lock up, with grey walls all around you, and little to no light in some areas. In front of the bars in front of you, all the way through the room, the set of keys, maybe those are to get you out of this mess?");
                Console.WriteLine("I don't know how I got here, last I remember was that stupid armoured man");
                Console.WriteLine("=========================================================================");
                Console.WriteLine("'Look' around, to see if anything might help you escape.");
                Console.WriteLine("'Bars' to shake the bars that is locking you in.");
                Console.WriteLine("'Barrel' in the corner seems to be leaking something.");
                Console.WriteLine("'Menu' to check you person at this time.");
                Input = Console.ReadLine();
                if (Input == "Menu")
                {
                    correct = 0;
                    Console.WriteLine("Enter Inventory to see Inventory content");
                    Console.WriteLine("Enter Stats, to see your character stats");
                    Console.WriteLine("< Back");
                    Input = Console.ReadLine();
                    if (Input == "Back")
                    {
                        correct = 1;
                    }
                    if (Input == "Inventory")
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Your Inventory Contains:");
                            for (Arraycount = 0; Arraycount < 20; Arraycount++)//Set arraycount to 0, If array count <20 continue, And add an array each time(then display if there is one)
                            {
                                int inventory_position = Arraycount + 1; //The inventory position is 20, since this loops 20 times.
                                Console.SetCursorPosition(0, inventory_position);//Sets the blinking vertical line(cursor) to the position 0, 20(since 20 is the end of the array list) This ensures you never write over an item
                                Console.WriteLine("{0}", Inventory[Arraycount]); //Writes whatever is in your inventory
                            }
                            Console.WriteLine("< Back");
                            Input = Console.ReadLine();
                            if (Input == "Back")
                            {
                                correct = 1;
                            }
                            if (Input != "Back")
                            {
                                correct = 0;
                            }
                        } while (correct == 0);
                    }
                    if (Input == "Stats")
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("You character is:");
                            Console.WriteLine("A {0} {1}", Gender, WarriorType);
                            Console.WriteLine("Attack: {0}", Attack);
                            Console.WriteLine("Ranged: {0}", Ranged);
                            Console.WriteLine("Magic: {0}", Magic);
                            Console.WriteLine("Health: {0}", Player_Health_Points);
                            Console.WriteLine("< Back");
                            Input = Console.ReadLine();
                            if (Input == "Back")
                            {
                                correct = 1;
                            }
                            if (Input != "Back")
                            {
                                correct = 0;
                            }
                        } while (correct == 0);
                    }
                    else { }

                }
                if (Input == "Look")//If they typed look around
                {
                    if (Player_Looked_Around == 1)//If player already looked around and found a rusty cup
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("It's just a dirty old cell, in what seems to be a basement..");
                            Console.WriteLine("< Back");
                            Input = Console.ReadLine();
                            if (Input == "Back")
                            {
                                correct = 1;
                            }
                            if (Input != "Back")
                            {
                                correct = 0;
                            }
                        } while (correct == 0);
                    }
                    if (Player_Looked_Around == 0)//If player has not Looked around yet.
                    {
                        do
                        {
                            Console.Clear();
                            Player_Looked_Around = 1; //This value lets the computer know you already looked for an item
                            Console.WriteLine("You notice something, in the dim lit corner. An old rusty, metal cup. You pick it up, and put it in you inventory");
                            Inventory[0] = "Old Rusty Cup";//Adds an old rusty cup to your Inventory
                            Player_Filled_Cup = "0"; //Adds a cup, but it's empty rn
                            Console.WriteLine("< Back");
                            Input = Console.ReadLine();
                            if (Input == "Back")//If they type back
                            {
                                correct = 1;
                            }
                            if (Input != "Back")//If they type anything but back.
                            {
                                correct = 0;
                            }
                        } while (correct == 0);

                    }

                }
                if (Input == "Barrel")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("A green liquid is leaking out of the barrel. Ow! Don't touch that, it burns your skin!");
                        Console.WriteLine("Do you want to 'Take' some?");
                        Console.WriteLine("< Back");
                        Input = Console.ReadLine();
                        if (Input == "Back")
                        {
                            correct = 1;
                        }
                        if ((Input == "Take" || Input == "Yes") && Inventory[0] == null)//If you want to take some but you have no old rusty cup
                        {
                            do
                            {
                                Console.WriteLine("You don't have anything to carry that liquid with!");
                                Console.WriteLine("< Back");
                                Input = Console.ReadLine();
                                if (Input == "Back")
                                {
                                    correct = 1;
                                }
                                if (Input != "Back")
                                {
                                    correct = 0;
                                }
                            } while (correct == 0);
                        }
                        if (Input == "Take" && Inventory[0] != null)//If there's a metal cup in your inventory
                        {
                            do
                            {
                                Player_Filled_Cup = "1"; //This allows you to pour it on the bars
                                Console.WriteLine("You use the old rusty cup to hold some of the liquid. Is it actually starting to melt the cup...");
                                Console.WriteLine("< Back");
                                Input = Console.ReadLine();
                                if (Input == "Back")
                                {
                                    correct = 1;
                                }
                                if (Input != "Back")
                                {
                                    correct = 0;
                                }
                            } while (correct == 0);
                        }
                        else { }
                    } while (correct == 0);
                }
                if (Input == "Bars")
                {
                    if (Inventory[0] == null)//If there is no old rusty cup in your inventory
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("The bars won't budge, and gave you a wierd feeling upon the touch");
                            Console.WriteLine("< Back");
                            Input = Console.ReadLine();
                            if (Input == "Back")
                            {
                                correct = 1;
                            }
                            if (Input != "Back")
                            {
                                correct = 0;
                            }
                        } while (correct == 0);
                    }
                    //if (Inventory[0] != null && Player_Filled_Cup == "0") //If your inventory has an item inside
                    //    {
                    //        do
                    //        {
                    //            Console.Clear();
                    //            Console.WriteLine("What are you going to do with an empty old rusty cup? Bang the bars?");
                    //            Console.WriteLine("Maybe pick at the walls for 20 years, but this isnt Shawshank");
                    //            Console.WriteLine("< Back");
                    //            Input = Console.ReadLine();
                    //            if (Input == "Back")
                    //            {
                    //                correct = 1;
                    //            }
                    //            if (Input != "Back")
                    //            {
                    //                correct = 0;
                    //            }
                    //        } while (correct == 0);
                    //    }
                    if (Inventory[0] != null)  //If your inventory has an item inside
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Hmm maybe we could use something to destroy the bars...");
                            Console.WriteLine("'Try'?");
                            Console.WriteLine("< Back");
                            Input = Console.ReadLine();
                            if (Input == "Back")
                            {
                                correct = 1;
                            }
                            if (Input != "Back")
                            {
                                correct = 0;
                            }
                            if (Input == "Try")
                            {
                                if (Player_Filled_Cup == "0")//If you haven't filled your cup up with the green liquid
                                {
                                    Console.WriteLine("What are you going to do with an empty old rusty cup? Bang the bars?");
                                    Console.WriteLine("Maybe pick at the walls for 20 years, but this isnt Shawshank");
                                    Console.WriteLine("< Back");
                                    Input = Console.ReadLine();
                                    if (Input == "Back")
                                    {
                                        correct = 1;
                                    }
                                    if (Input != "Back")
                                    {
                                        correct = 0;
                                    }
                                }
                                if (Player_Filled_Cup == "1")//If you filled your cup with the green liquid
                                {
                                    do
                                    {
                                        Console.WriteLine("You pour the liquid on the bars... This seems to be working! This corrosive, viscous green material is slowly destroying the bars!");
                                        Console.WriteLine("Continue >");
                                        Input = Console.ReadLine();
                                        if (Input == "Continue")
                                        {
                                            correct = 2;//This will end the Jail Cell scene
                                        }
                                        if (Input != "Continue")
                                        {
                                            correct = 0;
                                        }
                                    } while (correct == 0);
                                }
                            }
                        } while (correct == 0);
                    }
                    

                  }
                
          } while (correct != 2);//This will only end if you melt the bars. Melting the bars gives correct a value of 10
            correct = 0; //Restating it 

            

            //Escape cell scene
            do
            {
                Console.Clear();
                Console.WriteLine("When the bars melt, you squeeze yourself out of there. Who thought to put corrosive material in a cell?");
                Console.WriteLine("You look to your left, a set of stairs!");
                Console.WriteLine("'Look' around");
                Console.WriteLine("Go up the 'Stairs'");
                Input = Console.ReadLine();
                if (Input == "Look")
                {
                    do
                    {
                        Console.WriteLine("Just a dark cell, a narrow hallway and a set of stairs.");
                        Console.WriteLine("< Back");
                        Input = Console.ReadLine();
                        if (Input == "Back")
                        {
                            correct = 1;
                        }
                        if (Input != "Back")
                        {
                            correct = 0;
                        }
                    } while (correct == 0);
                }
                if (Input == "Stairs")
                {
                    do
                    {
                        Console.WriteLine("You slowly head up the stairs, just in case there are any guards around...");
                        Console.WriteLine("Continue >");
                        Input = Console.ReadLine();
                        if (Input == "Continue")
                        {
                            correct = 2;//You can only go up the stairs if correct = 2
                        }
                        if (Input != "Continue")
                        {
                            correct = 0;
                        }
                    } while (correct == 0);
                }
                else { }
            } while (correct != 2);
            correct = 0;

            
            
            
            //Guard scene
            Console.Clear();
            Console.WriteLine("GUARD: 'HEY! GET BACK TO YOUR CELL!' yells the guard waiting up the stairs.");
            Console.ReadLine();
            Console.WriteLine("ME: 'Hold on! Hold on! I just want to know why I'm here' I replied, as I was slowly inching backwards.");
            Console.ReadLine();
            Console.WriteLine("GUARD: 'Why you're here? You fought with a Paladin!'. Oh no. That man in the shiny armour? That was a Paladin, a hero of the land");
            Console.ReadLine();
            Console.WriteLine("ME: 'But no, I was just defending myself! I, a nomad, was just sleeping in the desert away from the town.'");
            Console.ReadLine();
            Console.WriteLine("ME: 'He came and attacked me! I was asleep, I wasn't doing anything.'");
            Console.ReadLine();
            Console.WriteLine("GUARD: 'Not again. This Paladin is a mess, his status has boosted his ego. But unfortunately I can't let you go'");
            Console.ReadLine();
            Console.WriteLine("ME: 'Please! What can I do to be set free?'");
            Console.ReadLine();
            Console.WriteLine("GUARD: 'Well there is one thing... No nevermind, it's too tall of an order.'");
            Console.ReadLine();
            Console.WriteLine("ME: 'I can do it! It's better than just rotting in a cell");
            Console.ReadLine();
            do
            {
                Console.WriteLine("GUARD: 'Do you think you're up for the Quest? It is the only thing that will set you free'");
                Console.WriteLine("=====================================================================================");
                Console.WriteLine("Continue >");
                Input = Console.ReadLine();
                if (Input == "Continue")
                {
                    correct = 1;
                }
                if (Input != "Continue")
                {
                    correct = 0;
                }
            } while (correct == 0);
            correct = 0;



            //Guard Confirmation Scene
            do
            {
                Console.Clear();
                Console.WriteLine("GUARD: 'There's a Dragon nearby this town, near a stream where we get our water. We need a brave soul to defeat the dragon so we're free.'");
                Console.WriteLine("GUARD: 'Are you up for it'");
                Console.WriteLine("======================");
                Console.WriteLine("Yes, I'm a 'Brave' Soul");
                Console.WriteLine("No, I'm a 'Coward'. I rather go rot in the cell'");
                Input = Console.ReadLine();
                if (Input == "Brave")
                {
                    correct = 1;
                }
                if (Input == "Coward")
                {
                    Console.Clear();
                    Console.WriteLine("GUARD: 'You fool. I knew you were a coward'");
                    Console.WriteLine("Don't do it, you don't want to rot in a cell do you?.");
                    Console.WriteLine("Lets try this again.");
                    Console.ReadLine();
                }
                else { }
            } while (correct != 1);
            correct = 0;

            
            //Brief explanation of game
            do
            {
                Console.Clear();
                Console.WriteLine("Your goal is now to kill the Dragon");
                Console.WriteLine("There will be side quests, gold and level ups for skills every time you fight monsters.");
                Console.WriteLine("There is also a store to purchase armour and health potions");
                Console.WriteLine("This will all lead to destroying the dragon.");
                Console.WriteLine("Continue >");
                Input = Console.ReadLine();

                if (Input == "Continue")
                {
                    correct = 1;
                }
                if (Input != "Continue")
                {
                    correct = 0;
                }
            } while (correct == 0);
            correct = 0;








            
            //Menu of Game
            do
            {
                correct = 0;
                Console.Clear();
                Console.WriteLine("Objective: Kill the Dragon so you are set free.");
                Console.WriteLine("=================================================");
                Console.WriteLine("Select an option");
                Console.WriteLine("1. Quest");
                Console.WriteLine("2. Store");
                Console.WriteLine("3. Inventory");
                Console.WriteLine("4. Player Stats");
                Input = Console.ReadLine();

                //Store
                if (Input == "2" || Input == "Store")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine(" ");
                        Console.WriteLine("Welcome to the General Store!");
                        Console.WriteLine("You can purchase some items to boost your stats");
                        Console.WriteLine("You have currently have {0} Gold.", Player_Gold);
                        Console.WriteLine("================================================");
                        Console.WriteLine("1. 5+ Attack boost = 40 Gold");
                        Console.WriteLine("2. 5+ Ranged boost = 40 Gold");
                        Console.WriteLine("3. 5+ Mage boost = 40 Gold");
                        Console.WriteLine("4. 15+ Attack boost = 80 Gold");
                        Console.WriteLine("5. 15+ Ranged boost = 80 Gold");
                        Console.WriteLine("6. 15+ Mage boost = 80 Gold");
                        Console.WriteLine("7. 5+ Health Pot = 20 Gold");
                        Console.WriteLine("8. 20+ Health Pot = 75 Gold");
                        Console.WriteLine("9. Random Health Pot(+0 - +100hp boost) = 250 Gold");
                        Console.WriteLine("10. 50 Health Boost = 200 Gold");
                        Console.WriteLine("<Back");
                        Input = Console.ReadLine();
                        if (Input == "1" && Player_Gold < 40)
                        {
                            Console.WriteLine("You don't have enough gold!");
                            Console.ReadLine();
                        }
                        if (Input == "1" && Player_Gold >= 40)
                        {
                            Player_Gold = Player_Gold - 40;
                            correct = 0;
                            Attack += 5;
                            Console.WriteLine("Your Attack went up by 5. It is now {0}.", Attack);
                            Console.ReadLine();
                        }
                        if (Input == "2" && Player_Gold < 40)
                        {
                            Console.WriteLine("You don't have enough gold!");
                            Console.ReadLine();
                        }
                        if (Input == "2" && Player_Gold >= 40)
                        {
                            Player_Gold = Player_Gold - 40;
                            correct = 0;
                            Ranged += 5;
                            Console.WriteLine("Your Ranged went up by 5. It is now {0}.", Ranged);
                            Console.ReadLine();
                        }
                        if (Input == "3" && Player_Gold < 40)
                        {
                            Console.WriteLine("You don't have enough gold!");
                            Console.ReadLine();
                        }
                        if (Input == "3" && Player_Gold >= 40)
                        {
                            Player_Gold = Player_Gold - 40;
                            correct = 0;
                            Magic += 5;
                            Console.WriteLine("Your Magic went up by 5. It is now {0}.", Magic);
                            Console.ReadLine();
                        }
                        if (Input == "4" && Player_Gold < 80)
                        {
                            Console.WriteLine("You don't have enough gold!");
                            Console.ReadLine();
                        }
                        if (Input == "4" && Player_Gold >= 80)
                        {
                            Player_Gold = Player_Gold - 80;
                            correct = 0;
                            Attack += 15;
                            Console.WriteLine("Your Attack went up by 15. It is now {0}.", Attack);
                            Console.ReadLine();
                        }
                        if (Input == "5" && Player_Gold < 80)
                        {
                            Console.WriteLine("You don't have enough gold!");
                            Console.ReadLine();
                        }
                        if (Input == "5" && Player_Gold >= 80)
                        {
                            Player_Gold = Player_Gold - 80;
                            correct = 0;
                            Ranged += 15;
                            Console.WriteLine("Your Ranged went up by 15. It is now {0}.", Ranged);
                            Console.ReadLine();
                        }
                        if (Input == "6" && Player_Gold < 80)
                        {
                            Console.WriteLine("You don't have enough gold!");
                            Console.ReadLine();
                        }
                        if (Input == "6" && Player_Gold >= 80)
                        {
                            Player_Gold = Player_Gold - 80;
                            correct = 0;
                            Magic += 15;
                            Console.WriteLine("Your Magic went up by 15. It is now {0}.", Magic);
                            Console.ReadLine();
                        }
                        if (Input == "7" && Player_Gold < 20)
                        {
                            Console.WriteLine("You don't have enough gold!");
                            Console.ReadLine();
                        }
                        if (Input == "7" && Player_Gold >= 20 && Inventory[17] != null)
                        {
                            Console.WriteLine("You already have a Weak Health Pot!");
                            Console.ReadLine();
                        }
                        if (Input == "7" && Player_Gold >= 20 && Inventory[17] == null)
                        {
                            Inventory[17] = "Weak Health Pot";
                            Player_Gold = Player_Gold - 20;
                            correct = 0;
                            Console.WriteLine("A Weak Health Pot has been added to your Inventory");
                            Console.ReadLine();
                        }
                        if (Input == "8" && Player_Gold < 75)
                        {
                            Console.WriteLine("You don't have enough gold!");
                            Console.ReadLine();
                        }
                        if (Input == "8" && Player_Gold >= 75 && Inventory[18] != null)
                        {
                            Console.WriteLine("You already have a Strong Health Pot!");
                            Console.ReadLine();
                        }
                        if (Input == "8" && Player_Gold >= 75 && Inventory[18] == null)
                        {
                            Inventory[18] = "Strong Health Pot";
                            Player_Gold = Player_Gold - 75;
                            correct = 0;
                            Console.WriteLine("A Strong Health Pot has been added to your Inventory");
                            Console.ReadLine();
                        }
                        if (Input == "9" && Player_Gold < 250)
                        {
                            Console.WriteLine("You don't have enough gold!");
                            Console.ReadLine();
                        }
                        if (Input == "9" && Player_Gold >= 250 && Inventory[19] != null)
                        {
                            Console.WriteLine("You already have a Random Health Pot!");
                            Console.ReadLine();
                        }
                        if (Input == "9" && Player_Gold >= 250 && Inventory[19] == null)
                        {
                            Inventory[19] = "Random Health Pot";
                            Player_Gold = Player_Gold - 250;
                            correct = 0;
                            Console.WriteLine("A Random Health Pot has been added to your Inventory");
                            Console.ReadLine();
                        }
                        if (Input == "10" && Player_Gold < 200)
                        {
                            Console.WriteLine("You don't have enough gold!");
                            Console.ReadLine();
                        }
                        if (Input == "10" && Player_Gold >= 200)
                        {
                            Player_Gold = Player_Gold - 200;
                            correct = 0;
                            Player_Health_Points += 50;
                            Console.WriteLine("You gained 50 Health. Your Health is now {0}", Player_Health_Points);
                            Console.ReadLine();
                        }
                        if (Input == "Back")
                        {
                            correct = 1;
                        }
                        else { }
                    } while (correct == 0);

                }

                //Inventory
                if (Input == "3" || Input == "Inventory")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Your Inventory Contains:");
                        for (Arraycount = 0; Arraycount < 20; Arraycount++)//Set arraycount to 0, If array count <20 continue, And add an array each time(then display if there is one)
                        {
                            int inventory_position = Arraycount + 1; //The inventory position is 20, since this loops 20 times.
                            Console.SetCursorPosition(0, inventory_position);//Sets the blinking vertical line(cursor) to the position 0, 20(since 20 is the end of the array list) This ensures you never write over an item
                            Console.WriteLine("{0}", Inventory[Arraycount]); //Writes whatever is in your inventory
                        }
                        Console.WriteLine("< Back");
                        Input = Console.ReadLine();
                        if (Input == "Back")
                        {
                            correct = 1;
                        }
                        if (Input != "Back")
                        {
                            correct = 0;
                        }
                    } while (correct == 0);
                }

                //Stats
                if (Input == "4" || Input == "Stats")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Your Full Character Description: ");
                        Console.WriteLine("A {0} {1}", Gender, WarriorType);
                        Console.WriteLine("Attack: {0}", Attack);
                        Console.WriteLine("Ranged: {0}", Ranged);
                        Console.WriteLine("Magic: {0}", Magic);
                        Console.WriteLine("Health: {0}", Player_Health_Points);
                        Console.WriteLine("Gold: {0}", Player_Gold);
                        Console.WriteLine("");
                        Console.WriteLine("< Back");
                        Input = Console.ReadLine();
                        if (Input == "Back")
                        {
                            correct = 1;
                        }
                    } while (correct == 0); //If they don't type Continue, it will loop
                }

                


                //Quest
                if (Input == "1" || Input == "Quest")
                {
                    Console.WriteLine("The Dragon is quite strong, you must train to get stronger, purchase armour, and get strong enough to fight him.");
                    Console.WriteLine("You gain gold and extra levels with each opponent, and each one is slightly different. The stronger the opponent the higher the reward.");
                    Console.WriteLine("Pick an opponent:");
                    Console.WriteLine("1. Rat");
                    Console.WriteLine("2. Goblin");
                    Console.WriteLine("3. Paladin");
                    Console.WriteLine("4. Archer");
                    Console.WriteLine("5. Wizard");
                    Console.WriteLine("6. Dragon");
                    Console.WriteLine("<Back");
                    Input = Console.ReadLine();

                    //Rat
                    if (Input == "Rat" || Input == "1")
                    {
                        do
                        {
                            correct = 0; //Set the value to 0 again
                            Console.Clear(); //Clear the screen again
                            Console.WriteLine("Your Health is at {0} Points", Player_Health_Points);
                            Console.WriteLine("The {0}'s Health is at {1} Points", Rat, Rat_Health_Points);
                            Console.WriteLine("What do you want to do?");
                            Console.WriteLine("1. Attack");
                            Console.WriteLine("2. Ranged");
                            Console.WriteLine("3. Magic");
                            Console.WriteLine("4. Potion");
                            Input = Console.ReadLine();
                            if (Input == "1" || Input == "Attack")
                            {
                                Random Damage_Roll = new Random(); //Instantiates a new random damage 
                                int Random_Damage_Roll = Damage_Roll.Next(0, Attack); //The new random damage ranges from 0 to the guy's attack damage
                                Console.WriteLine("{0}", Random_Damage_Roll);//It outputs the Random_Damage_Roll
                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Rat);
                                Random Skill_Point_Roll = new Random();//Setting a skill point roll for Crits
                                int Skill_Point_Outcome = random.Next(0, 11);//A random num between 0 and 10
                                if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)//if the random num is > 0, and your damage > 0, then Crit
                                {
                                    Random_Damage_Roll = Random_Damage_Roll + Attack;
                                    Console.WriteLine("You did a critical hit, with {0} skill points of damage", Attack);
                                }

                                else { }

                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Rat);//Tells you the result 
                                Rat_Health_Points = Rat_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                            }
                            if (Input == "2" || Input == "Ranged")
                            {
                                Random Damage_Roll = new Random();
                                int Random_Damage_Roll = Damage_Roll.Next(0, Ranged);
                                Console.WriteLine("{0}", Random_Damage_Roll);
                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Rat);
                                Random Skill_Point_Roll = new Random();
                                int Skill_Point_Outcome = random.Next(0, 11);
                                if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                                {
                                    Random_Damage_Roll = Random_Damage_Roll + Ranged;
                                    Console.WriteLine("You did a critical hit, with {0} skill points of damage", Ranged);
                                }

                                else { }

                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Rat);//Tells you the result 
                                Rat_Health_Points = Rat_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                            }
                            if (Input == "3" || Input == "Magic")
                            {
                                Random Damage_Roll = new Random();
                                int Random_Damage_Roll = Damage_Roll.Next(0, Magic);
                                Console.WriteLine("{0}", Random_Damage_Roll);
                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Rat);
                                Random Skill_Point_Roll = new Random();
                                int Skill_Point_Outcome = random.Next(0, 11);
                                if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                                {
                                    Random_Damage_Roll = Random_Damage_Roll + Magic;
                                    Console.WriteLine("You did a critical hit, with {0} skill points of damage", Magic);
                                }

                                else { }

                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Rat);//Tells you the result 
                                Rat_Health_Points = Rat_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                            }
                            if (Input == "4" || Input == "Potion")
                            {
                                if (Inventory[17] == null && Inventory[18] == null && Inventory[19] == null)//If you don't have any potions
                                {
                                    Console.WriteLine("You don't have any potions");
                                    Console.ReadLine();
                                }
                                if (Inventory[17] != null || Inventory[18] != null || Inventory[19] != null)//If you have potions
                                {
                                    do
                                    {
                                        Console.WriteLine("Which health potion do you want to use?");
                                        Console.WriteLine("1. Weak Health Potion");
                                        Console.WriteLine("2. Strong Health Potion");
                                        Console.WriteLine("3. Random Health Potion(0-100 hp)");
                                        Input = Console.ReadLine();
                                        if (Input == "1" && Inventory[17] == null)//If you don't have a Weak Potion
                                        {
                                            correct = 0;
                                            Console.WriteLine("You don't have a Weak Health Potion.");
                                            Console.ReadLine();
                                        }
                                        if (Input == "1" && Inventory[17] != null)//If you have a Weak Potion
                                        {
                                            Inventory[17] = null; //We get rid of the item upon use
                                            correct = 1;
                                            Player_Health_Points = Player_Health_Points + Weak_Health_Potion;
                                            Console.WriteLine("You use the Weak Health Potion and gain 5 Health");
                                            Console.ReadLine();
                                        }
                                        if (Input == "2" && Inventory[18] == null)//If you don't have a Strong Potion
                                        {
                                            correct = 0;
                                            Console.WriteLine("You don't have a Strong Health Potion.");
                                            Console.ReadLine();
                                        }
                                        if (Input == "2" && Inventory[18] != null)//If you have a Strong Potion
                                        {
                                            Inventory[18] = null; //We get rid of the item upon use
                                            correct = 1;
                                            Player_Health_Points = Player_Health_Points + Strong_Health_Potion;
                                            Console.WriteLine("You use the Strong Health Potion and gain 20 Health");
                                            Console.ReadLine();
                                        }
                                        if (Input == "3" && Inventory[19] == null)//If you don't have a Random Potion
                                        {
                                            correct = 0;
                                            Console.WriteLine("You don't have a Random Health Potion.");
                                            Console.ReadLine();
                                        }
                                        if (Input == "3" && Inventory[19] != null)//If you do have a Random Potion
                                        {
                                            Inventory[19] = null; //We get rid of the item upon use
                                            correct = 1;
                                            Random Health_Roll = new Random();
                                            Random_Health_Potion = Health_Roll.Next(0, 100);
                                            Player_Health_Points = Player_Health_Points + Random_Health_Potion;
                                            Console.WriteLine("You use the Random Health Potions and you gain {0} Health", Random_Health_Potion);
                                            Console.ReadLine();
                                        }
                                    } while (correct == 0);
                                }
                            }
                            if (Rat_Health_Points > 0 && ((Input == "1" || Input == "Attack") || (Input == "2" || Input == "Ranged") || (Input == "3" || Input == "Magic")))//If enemy is alive and player inputs a proper value
                            {
                                Random Enemy_Damage_Roll = new Random();
                                int Random_Enemy_Damage_Roll = Enemy_Damage_Roll.Next(0, Rat_Maximum_Damage);
                                Console.WriteLine("The {0} Strikes back, and deals {1} Points of Damage", Rat, Random_Enemy_Damage_Roll);//A roll to see if enemy is going to hit
                                Player_Health_Points = Player_Health_Points - Random_Enemy_Damage_Roll;//Subtracting damage with my health
                                Console.ReadLine();
                            }
                            else { }
                        } while (Player_Health_Points > 0 && Rat_Health_Points > 0);

                        if (Rat_Health_Points <= 0) //This is in case enemy's hp goes less than 0
                        {
                            correct = 0;//Restating this so that we can run a successful do - while loop
                            do
                            {
                                Rat_Health_Points = 12; //Resets it to 12
                                Player_Gold += 5;//Give player gold 
                                Console.Clear();
                                Console.WriteLine("You have slain the {0}!", Rat);
                                Console.WriteLine("You gained {0} gold", Rat_Gold);
                                Console.WriteLine("You can now upgrade one of your skills. Which skill do you want to upgrade? Select a number.");
                                Console.WriteLine("1. Attack");
                                Console.WriteLine("2. Ranged");
                                Console.WriteLine("3. Magic");
                                Input = Console.ReadLine();
                                if (Input == "1" || Input == "Attack")
                                {
                                    correct = 1; //State it to 1, so that it won't loop again
                                    Attack += 1;
                                    Console.Clear();
                                    Console.WriteLine("You gained 1 Attack Point!");
                                    Console.WriteLine("Your Attack is now {0}.", Attack);
                                    Console.ReadLine();
                                }
                                if (Input == "2" || Input == "Ranged")
                                {
                                    correct = 1;
                                    Ranged += 1;
                                    Console.Clear();
                                    Console.WriteLine("You gained 1 Ranged Point!");
                                    Console.WriteLine("Your Ranged is now {0}", Ranged);
                                    Console.ReadLine();
                                }
                                if (Input == "3" || Input == "Magic")
                                {
                                    correct = 1;
                                    Magic += 1;
                                    Console.Clear();
                                    Console.WriteLine("You gained 1 Magic Point!");
                                    Console.WriteLine("Your Magic is now {0}", Magic);
                                    Console.ReadLine();
                                }
                                else { }
                            } while (correct == 0);
                            correct = 0; //Restate it to not mess it up in the future
                        }
                        if (Player_Health_Points <= 0)//In case your HP is 0 or less
                        {
                            Player_Health_Points = 0;//Resets it to zero
                            Console.WriteLine("Oh dear, you're dead!");
                            Console.WriteLine("The {0} has slain you, you're at 0 Health Points", Rat);
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("==================================Game Over=====================================");
                            Console.ReadLine();
                            System.Environment.Exit(0);//Closes console
                        }
                    }

                    //Goblin
                    if (Input == "Goblin" || Input == "2")
                    {
                        do
                        {
                            correct = 0; //Set the value to 0 again
                            Console.Clear(); //Clear the screen again
                            Console.WriteLine("Your Health is at {0} Points", Player_Health_Points);
                            Console.WriteLine("The {0}'s Health is at {1} Points", Goblin, Goblin_Health_Points);
                            Console.WriteLine("What do you want to do?");
                            Console.WriteLine("1. Attack");
                            Console.WriteLine("2. Ranged");
                            Console.WriteLine("3. Magic");
                            Console.WriteLine("4. Potion");
                            Input = Console.ReadLine();
                            if (Input == "1" || Input == "Attack")
                            {
                                Random Damage_Roll = new Random(); //Instantiates a new random damage 
                                int Random_Damage_Roll = Damage_Roll.Next(0, Attack); //The new random damage ranges from 0 to the guy's attack damage
                                Console.WriteLine("{0}", Random_Damage_Roll);//It outputs the Random_Damage_Roll
                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Goblin);
                                Random Skill_Point_Roll = new Random();//Setting a skill point roll for Crits
                                int Skill_Point_Outcome = random.Next(0, 11);//A random num between 0 and 10
                                if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)//if the random num is > 0, and your damage > 0, then Crit
                                {
                                    Random_Damage_Roll = Random_Damage_Roll + Attack;
                                    Console.WriteLine("You did a critical hit, with {0} skill points of damage", Attack);
                                }

                                else { }

                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Goblin);//Tells you the result 
                                Goblin_Health_Points = Goblin_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                            }
                            if (Input == "2" || Input == "Ranged")
                            {
                                Random Damage_Roll = new Random();
                                int Random_Damage_Roll = Damage_Roll.Next(0, Ranged);
                                Console.WriteLine("{0}", Random_Damage_Roll);
                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Goblin);
                                Random Skill_Point_Roll = new Random();
                                int Skill_Point_Outcome = random.Next(0, 11);
                                if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                                {
                                    Random_Damage_Roll = Random_Damage_Roll + Ranged;
                                    Console.WriteLine("You did a critical hit, with {0} skill points of damage", Ranged);
                                }

                                else { }

                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Goblin);//Tells you the result 
                                Goblin_Health_Points = Goblin_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                            }
                            if (Input == "3" || Input == "Magic")
                            {
                                Random Damage_Roll = new Random();
                                int Random_Damage_Roll = Damage_Roll.Next(0, Magic);
                                Console.WriteLine("{0}", Random_Damage_Roll);
                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Goblin);
                                Random Skill_Point_Roll = new Random();
                                int Skill_Point_Outcome = random.Next(0, 11);
                                if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                                {
                                    Random_Damage_Roll = Random_Damage_Roll + Magic;
                                    Console.WriteLine("You did a critical hit, with {0} skill points of damage", Magic);
                                }

                                else { }

                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Goblin);//Tells you the result 
                                Goblin_Health_Points = Goblin_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                            }
                            if (Input == "4" || Input == "Potion")
                            {
                                if (Inventory[17] == null && Inventory[18] == null && Inventory[19] == null)//If you don't have any potions
                                {
                                    Console.WriteLine("You don't have any potions");
                                    Console.ReadLine();
                                }
                                if (Inventory[17] != null || Inventory[18] != null || Inventory[19] != null)//If you have potions
                                {
                                    do
                                    {
                                        Console.WriteLine("Which health potion do you want to use?");
                                        Console.WriteLine("1. Weak Health Potion");
                                        Console.WriteLine("2. Strong Health Potion");
                                        Console.WriteLine("3. Random Health Potion(0-100 hp)");
                                        Input = Console.ReadLine();
                                        if (Input == "1" && Inventory[17] == null)//If you don't have a Weak Potion
                                        {
                                            correct = 0;
                                            Console.WriteLine("You don't have a Weak Health Potion.");
                                            Console.ReadLine();
                                        }
                                        if (Input == "1" && Inventory[17] != null)//If you have a Weak Potion
                                        {
                                            Inventory[17] = null; //We get rid of the item upon use
                                            correct = 1;
                                            Player_Health_Points = Player_Health_Points + Weak_Health_Potion;
                                            Console.WriteLine("You use the Weak Health Potion and gain 5 Health");
                                            Console.ReadLine();
                                        }
                                        if (Input == "2" && Inventory[18] == null)//If you don't have a Strong Potion
                                        {
                                            correct = 0;
                                            Console.WriteLine("You don't have a Strong Health Potion.");
                                            Console.ReadLine();
                                        }
                                        if (Input == "2" && Inventory[18] != null)//If you have a Strong Potion
                                        {
                                            Inventory[18] = null; //We get rid of the item upon use
                                            correct = 1;
                                            Player_Health_Points = Player_Health_Points + Strong_Health_Potion;
                                            Console.WriteLine("You use the Strong Health Potion and gain 20 Health");
                                            Console.ReadLine();
                                        }
                                        if (Input == "3" && Inventory[19] == null)//If you don't have a Random Potion
                                        {
                                            correct = 0;
                                            Console.WriteLine("You don't have a Random Health Potion.");
                                            Console.ReadLine();
                                        }
                                        if (Input == "3" && Inventory[19] != null)//If you do have a Random Potion
                                        {
                                            Inventory[19] = null; //We get rid of the item upon use
                                            correct = 1;
                                            Random Health_Roll = new Random();
                                            Random_Health_Potion = Health_Roll.Next(0, 100);
                                            Player_Health_Points = Player_Health_Points + Random_Health_Potion;
                                            Console.WriteLine("You use the Random Health Potions and you gain {0} Health", Random_Health_Potion);
                                            Console.ReadLine();
                                        }
                                    } while (correct == 0);
                                }
                            }
                            if (Goblin_Health_Points > 0 && ((Input == "1" || Input == "Attack") || (Input == "2" || Input == "Ranged") || (Input == "3" || Input == "Magic")))//If enemy is alive and player inputs a proper value
                            {
                                Random Enemy_Damage_Roll = new Random();
                                int Random_Enemy_Damage_Roll = Enemy_Damage_Roll.Next(0, Goblin_Maximum_Damage);
                                Console.WriteLine("The {0} Strikes back, and deals {1} Points of Damage", Goblin, Random_Enemy_Damage_Roll);//A roll to see if enemy is going to hit
                                Player_Health_Points = Player_Health_Points - Random_Enemy_Damage_Roll;//Subtracting damage with my health
                                Console.ReadLine();
                            }
                            else { }
                        } while (Player_Health_Points > 0 && Goblin_Health_Points > 0);

                        if (Goblin_Health_Points <= 0) //This is in case enemy's hp goes less than 0
                        {
                            correct = 0;//Restating this so that we can run a successful do - while loop
                            do
                            {
                                Goblin_Health_Points = 15; //Resets it to 15
                                Player_Gold += 10;
                                Console.Clear();
                                Console.WriteLine("You have slain the {0}!", Goblin);
                                Console.WriteLine("You gained {0} gold", Goblin_Gold);
                                Console.WriteLine("You can now upgrade one of your skills. Which skill do you want to upgrade? Select a number.");
                                Console.WriteLine("1. Attack");
                                Console.WriteLine("2. Ranged");
                                Console.WriteLine("3. Magic");
                                Input = Console.ReadLine();
                                if (Input == "1" || Input == "Attack")
                                {
                                    correct = 1; //State it to 1, so that it won't loop again
                                    Attack += 4;
                                    Console.Clear();
                                    Console.WriteLine("You gained 1 Attack Point!");
                                    Console.WriteLine("Your Attack is now {0}.", Attack);
                                    Console.ReadLine();
                                }
                                if (Input == "2" || Input == "Ranged")
                                {
                                    correct = 1;
                                    Ranged += 4;
                                    Console.Clear();
                                    Console.WriteLine("You gained 1 Ranged Point!");
                                    Console.WriteLine("Your Ranged is now {0}", Ranged);
                                    Console.ReadLine();
                                }
                                if (Input == "3" || Input == "Magic")
                                {
                                    correct = 1;
                                    Magic += 4;
                                    Console.Clear();
                                    Console.WriteLine("You gained 1 Magic Point!");
                                    Console.WriteLine("Your Magic is now {0}", Magic);
                                    Console.ReadLine();
                                }
                                else { }
                            } while (correct == 0);
                            correct = 0; //Restate it to not mess it up in the future
                        }
                        if (Player_Health_Points <= 0)//In case your HP is 0 or less
                        {
                            Player_Health_Points = 0;//Resets it to zero
                            Console.WriteLine("Oh dear, you're dead!");
                            Console.WriteLine("The {0} has slain you, you're at 0 Health Points", Goblin);
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("==================================Game Over=====================================");
                            Console.ReadLine();
                            System.Environment.Exit(0);//Closes console
                        }
                    }

                    //Paladin
                    if (Input == "Paladin" || Input == "3")
                    {
                        do
                        {
                            correct = 0; //Set the value to 0 again
                            Console.Clear(); //Clear the screen again
                            Console.WriteLine("Your Health is at {0} Points", Player_Health_Points);
                            Console.WriteLine("The {0}'s Health is at {1} Points", Paladin, Paladin_Health_Points);
                            Console.WriteLine("What do you want to do?");
                            Console.WriteLine("1. Attack");
                            Console.WriteLine("2. Ranged");
                            Console.WriteLine("3. Magic");
                            Console.WriteLine("4. Potion");
                            Input = Console.ReadLine();
                            if (Input == "1" || Input == "Attack")
                            {
                                Random Damage_Roll = new Random(); //Instantiates a new random damage 
                                int Random_Damage_Roll = Damage_Roll.Next(0, Attack); //The new random damage ranges from 0 to the guy's attack damage
                                Console.WriteLine("{0}", Random_Damage_Roll);//It outputs the Random_Damage_Roll
                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Paladin);
                                Random Skill_Point_Roll = new Random();//Setting a skill point roll for Crits
                                int Skill_Point_Outcome = random.Next(0, 11);//A random num between 0 and 10
                                if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)//if the random num is > 0, and your damage > 0, then Crit
                                {
                                    Random_Damage_Roll = Random_Damage_Roll + Attack;
                                    Console.WriteLine("You did a critical hit, with {0} skill points of damage", Attack);
                                }

                                else { }

                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Paladin);//Tells you the result 
                                Paladin_Health_Points = Paladin_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                            }
                            if (Input == "2" || Input == "Ranged")
                            {
                                Random Damage_Roll = new Random();
                                int Random_Damage_Roll = Damage_Roll.Next(0, Ranged);
                                Console.WriteLine("{0}", Random_Damage_Roll);
                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Paladin);
                                Random Skill_Point_Roll = new Random();
                                int Skill_Point_Outcome = random.Next(0, 11);
                                if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                                {
                                    Random_Damage_Roll = Random_Damage_Roll + Ranged;
                                    Console.WriteLine("You did a critical hit, with {0} skill points of damage", Ranged);
                                }

                                else { }

                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Paladin);//Tells you the result 
                                Paladin_Health_Points = Paladin_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                            }
                            if (Input == "3" || Input == "Magic")
                            {
                                Random Damage_Roll = new Random();
                                int Random_Damage_Roll = Damage_Roll.Next(0, Magic);
                                Console.WriteLine("{0}", Random_Damage_Roll);
                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Paladin);
                                Random Skill_Point_Roll = new Random();
                                int Skill_Point_Outcome = random.Next(0, 11);
                                if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                                {
                                    Random_Damage_Roll = Random_Damage_Roll + Magic;
                                    Console.WriteLine("You did a critical hit, with {0} skill points of damage", Magic);
                                }

                                else { }

                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Paladin);//Tells you the result 
                                Paladin_Health_Points = Paladin_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                            }
                            if (Input == "4" || Input == "Potion")
                            {
                                if (Inventory[17] == null && Inventory[18] == null && Inventory[19] == null)//If you don't have any potions
                                {
                                    Console.WriteLine("You don't have any potions");
                                    Console.ReadLine();
                                }
                                if (Inventory[17] != null || Inventory[18] != null || Inventory[19] != null)//If you have potions
                                {
                                    do
                                    {
                                        Console.WriteLine("Which health potion do you want to use?");
                                        Console.WriteLine("1. Weak Health Potion");
                                        Console.WriteLine("2. Strong Health Potion");
                                        Console.WriteLine("3. Random Health Potion(0-100 hp)");
                                        Input = Console.ReadLine();
                                        if (Input == "1" && Inventory[17] == null)//If you don't have a Weak Potion
                                        {
                                            correct = 0;
                                            Console.WriteLine("You don't have a Weak Health Potion.");
                                            Console.ReadLine();
                                        }
                                        if (Input == "1" && Inventory[17] != null)//If you have a Weak Potion
                                        {
                                            Inventory[17] = null; //We get rid of the item upon use
                                            correct = 1;
                                            Player_Health_Points = Player_Health_Points + Weak_Health_Potion;
                                            Console.WriteLine("You use the Weak Health Potion and gain 5 Health");
                                            Console.ReadLine();
                                        }
                                        if (Input == "2" && Inventory[18] == null)//If you don't have a Strong Potion
                                        {
                                            correct = 0;
                                            Console.WriteLine("You don't have a Strong Health Potion.");
                                            Console.ReadLine();
                                        }
                                        if (Input == "2" && Inventory[18] != null)//If you have a Strong Potion
                                        {
                                            Inventory[18] = null; //We get rid of the item upon use
                                            correct = 1;
                                            Player_Health_Points = Player_Health_Points + Strong_Health_Potion;
                                            Console.WriteLine("You use the Strong Health Potion and gain 20 Health");
                                            Console.ReadLine();
                                        }
                                        if (Input == "3" && Inventory[19] == null)//If you don't have a Random Potion
                                        {
                                            correct = 0;
                                            Console.WriteLine("You don't have a Random Health Potion.");
                                            Console.ReadLine();
                                        }
                                        if (Input == "3" && Inventory[19] != null)//If you do have a Random Potion
                                        {
                                            Inventory[19] = null; //We get rid of the item upon use
                                            correct = 1;
                                            Random Health_Roll = new Random();
                                            Random_Health_Potion = Health_Roll.Next(0, 100);
                                            Player_Health_Points = Player_Health_Points + Random_Health_Potion;
                                            Console.WriteLine("You use the Random Health Potions and you gain {0} Health", Random_Health_Potion);
                                            Console.ReadLine();
                                        }
                                    } while (correct == 0);
                                }
                            }
                            if (Paladin_Health_Points > 0 && ((Input == "1" || Input == "Attack") || (Input == "2" || Input == "Ranged") || (Input == "3" || Input == "Magic")))//If enemy is alive and player inputs a proper value
                            {
                                Random Enemy_Damage_Roll = new Random();
                                int Random_Enemy_Damage_Roll = Enemy_Damage_Roll.Next(0, Paladin_Maximum_Damage);
                                Console.WriteLine("The {0} Strikes back, and deals {1} Points of Damage", Paladin, Random_Enemy_Damage_Roll);//A roll to see if enemy is going to hit
                                Player_Health_Points = Player_Health_Points - Random_Enemy_Damage_Roll;//Subtracting damage with my health
                                Console.ReadLine();
                            }
                            else { }
                        } while (Player_Health_Points > 0 && Paladin_Health_Points > 0);

                        if (Paladin_Health_Points <= 0) //This is in case enemy's hp goes less than 0
                        {
                            correct = 0;//Restating this so that we can run a successful do - while loop
                            do
                            {
                                Paladin_Health_Points = 20; //Resets it to 20
                                Player_Gold += 20;
                                Console.Clear();
                                Console.WriteLine("You have slain the {0}!", Paladin);
                                Console.WriteLine("You gained {0} gold", Paladin_Gold);
                                Console.WriteLine("You can now upgrade one of your skills. Which skill do you want to upgrade? Select a number.");
                                Console.WriteLine("1. Attack");
                                Console.WriteLine("2. Ranged");
                                Console.WriteLine("3. Magic");
                                Input = Console.ReadLine();
                                if (Input == "1" || Input == "Attack")
                                {
                                    correct = 1; //State it to 1, so that it won't loop again
                                    Attack += 5;
                                    Console.Clear();
                                    Console.WriteLine("You gained 1 Attack Point!");
                                    Console.WriteLine("Your Attack is now {0}.", Attack);
                                    Console.ReadLine();
                                }
                                if (Input == "2" || Input == "Ranged")
                                {
                                    correct = 1;
                                    Ranged += 5;
                                    Console.Clear();
                                    Console.WriteLine("You gained 1 Ranged Point!");
                                    Console.WriteLine("Your Ranged is now {0}", Ranged);
                                    Console.ReadLine();
                                }
                                if (Input == "3" || Input == "Magic")
                                {
                                    correct = 1;
                                    Magic += 10;//Magic beats Attack
                                    Console.Clear();
                                    Console.WriteLine("You gained 1 Magic Point!");
                                    Console.WriteLine("Your Magic is now {0}", Magic);
                                    Console.ReadLine();
                                }
                                else { }
                            } while (correct == 0);
                            correct = 0; //Restate it to not mess it up in the future
                        }
                        if (Player_Health_Points <= 0)//In case your HP is 0 or less
                        {
                            Player_Health_Points = 0;//Resets it to zero
                            Console.WriteLine("Oh dear, you're dead!");
                            Console.WriteLine("The {0} has slain you, you're at 0 Health Points", Paladin);
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("==================================Game Over=====================================");
                            Console.ReadLine();
                            System.Environment.Exit(0);//Closes console
                        }
                    }

                    //Archer
                    if (Input == "Archer" || Input == "4")
                    {
                        do
                        {
                            correct = 0; //Set the value to 0 again
                            Console.Clear(); //Clear the screen again
                            Console.WriteLine("Your Health is at {0} Points", Player_Health_Points);
                            Console.WriteLine("The {0}'s Health is at {1} Points", Archer, Archer_Health_Points);
                            Console.WriteLine("What do you want to do?");
                            Console.WriteLine("1. Attack");
                            Console.WriteLine("2. Ranged");
                            Console.WriteLine("3. Magic");
                            Console.WriteLine("4. Potion");
                            Input = Console.ReadLine();
                            if (Input == "1" || Input == "Attack")
                            {
                                Random Damage_Roll = new Random(); //Instantiates a new random damage 
                                int Random_Damage_Roll = Damage_Roll.Next(0, Attack); //The new random damage ranges from 0 to the guy's attack damage
                                Console.WriteLine("{0}", Random_Damage_Roll);//It outputs the Random_Damage_Roll
                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Archer);
                                Random Skill_Point_Roll = new Random();//Setting a skill point roll for Crits
                                int Skill_Point_Outcome = random.Next(0, 11);//A random num between 0 and 10
                                if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)//if the random num is > 0, and your damage > 0, then Crit
                                {
                                    Random_Damage_Roll = Random_Damage_Roll + Attack;
                                    Console.WriteLine("You did a critical hit, with {0} skill points of damage", Attack);
                                }

                                else { }

                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Archer);//Tells you the result 
                                Archer_Health_Points = Archer_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                            }
                            if (Input == "2" || Input == "Ranged")
                            {
                                Random Damage_Roll = new Random();
                                int Random_Damage_Roll = Damage_Roll.Next(0, Ranged);
                                Console.WriteLine("{0}", Random_Damage_Roll);
                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Archer);
                                Random Skill_Point_Roll = new Random();
                                int Skill_Point_Outcome = random.Next(0, 11);
                                if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                                {
                                    Random_Damage_Roll = Random_Damage_Roll + Ranged;
                                    Console.WriteLine("You did a critical hit, with {0} skill points of damage", Ranged);
                                }

                                else { }

                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Archer);//Tells you the result 
                                Archer_Health_Points = Archer_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                            }
                            if (Input == "3" || Input == "Magic")
                            {
                                Random Damage_Roll = new Random();
                                int Random_Damage_Roll = Damage_Roll.Next(0, Magic);
                                Console.WriteLine("{0}", Random_Damage_Roll);
                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Archer);
                                Random Skill_Point_Roll = new Random();
                                int Skill_Point_Outcome = random.Next(0, 11);
                                if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                                {
                                    Random_Damage_Roll = Random_Damage_Roll + Magic;
                                    Console.WriteLine("You did a critical hit, with {0} skill points of damage", Magic);
                                }

                                else { }

                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Archer);//Tells you the result 
                                Archer_Health_Points = Archer_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                            }
                            if (Input == "4" || Input == "Potion")
                            {
                                if (Inventory[17] == null && Inventory[18] == null && Inventory[19] == null)//If you don't have any potions
                                {
                                    Console.WriteLine("You don't have any potions");
                                    Console.ReadLine();
                                }
                                if (Inventory[17] != null || Inventory[18] != null || Inventory[19] != null)//If you have potions
                                {
                                    do
                                    {
                                        Console.WriteLine("Which health potion do you want to use?");
                                        Console.WriteLine("1. Weak Health Potion");
                                        Console.WriteLine("2. Strong Health Potion");
                                        Console.WriteLine("3. Random Health Potion(0-100 hp)");
                                        Input = Console.ReadLine();
                                        if (Input == "1" && Inventory[17] == null)//If you don't have a Weak Potion
                                        {
                                            correct = 0;
                                            Console.WriteLine("You don't have a Weak Health Potion.");
                                            Console.ReadLine();
                                        }
                                        if (Input == "1" && Inventory[17] != null)//If you have a Weak Potion
                                        {
                                            Inventory[17] = null; //We get rid of the item upon use
                                            correct = 1;
                                            Player_Health_Points = Player_Health_Points + Weak_Health_Potion;
                                            Console.WriteLine("You use the Weak Health Potion and gain 5 Health");
                                            Console.ReadLine();
                                        }
                                        if (Input == "2" && Inventory[18] == null)//If you don't have a Strong Potion
                                        {
                                            correct = 0;
                                            Console.WriteLine("You don't have a Strong Health Potion.");
                                            Console.ReadLine();
                                        }
                                        if (Input == "2" && Inventory[18] != null)//If you have a Strong Potion
                                        {
                                            Inventory[18] = null; //We get rid of the item upon use
                                            correct = 1;
                                            Player_Health_Points = Player_Health_Points + Strong_Health_Potion;
                                            Console.WriteLine("You use the Strong Health Potion and gain 20 Health");
                                            Console.ReadLine();
                                        }
                                        if (Input == "3" && Inventory[19] == null)//If you don't have a Random Potion
                                        {
                                            correct = 0;
                                            Console.WriteLine("You don't have a Random Health Potion.");
                                            Console.ReadLine();
                                        }
                                        if (Input == "3" && Inventory[19] != null)//If you do have a Random Potion
                                        {
                                            Inventory[19] = null; //We get rid of the item upon use
                                            correct = 1;
                                            Random Health_Roll = new Random();
                                            Random_Health_Potion = Health_Roll.Next(0, 100);
                                            Player_Health_Points = Player_Health_Points + Random_Health_Potion;
                                            Console.WriteLine("You use the Random Health Potions and you gain {0} Health", Random_Health_Potion);
                                            Console.ReadLine();
                                        }
                                    } while (correct == 0);
                                }
                            }
                            if (Archer_Health_Points > 0 && ((Input == "1" || Input == "Attack") || (Input == "2" || Input == "Ranged") || (Input == "3" || Input == "Magic")))//If enemy is alive and player inputs a proper value
                            {
                                Random Enemy_Damage_Roll = new Random();
                                int Random_Enemy_Damage_Roll = Enemy_Damage_Roll.Next(0, Archer_Maximum_Damage);
                                Console.WriteLine("The {0} Strikes back, and deals {1} Points of Damage", Archer, Random_Enemy_Damage_Roll);//A roll to see if enemy is going to hit
                                Player_Health_Points = Player_Health_Points - Random_Enemy_Damage_Roll;//Subtracting damage with my health
                                Console.ReadLine();
                            }
                            else { }
                        } while (Player_Health_Points > 0 && Archer_Health_Points > 0);

                        if (Archer_Health_Points <= 0) //This is in case enemy's hp goes less than 0
                        {
                            correct = 0;//Restating this so that we can run a successful do - while loop
                            do
                            {
                                Archer_Health_Points = 17; //Resets it to 17
                                Player_Gold += 20;
                                Console.Clear();
                                Console.WriteLine("You have slain the {0}!", Archer);
                                Console.WriteLine("You gained {0} gold", Archer_Gold);
                                Console.WriteLine("You can now upgrade one of your skills. Which skill do you want to upgrade? Select a number.");
                                Console.WriteLine("1. Attack");
                                Console.WriteLine("2. Ranged");
                                Console.WriteLine("3. Magic");
                                Input = Console.ReadLine();
                                if (Input == "1" || Input == "Attack")
                                {
                                    correct = 1; //State it to 1, so that it won't loop again
                                    Attack += 10;//Attack beats Ranged
                                    Console.Clear();
                                    Console.WriteLine("You gained 1 Attack Point!");
                                    Console.WriteLine("Your Attack is now {0}.", Attack);
                                    Console.ReadLine();
                                }
                                if (Input == "2" || Input == "Ranged")
                                {
                                    correct = 1;
                                    Ranged += 5;
                                    Console.Clear();
                                    Console.WriteLine("You gained 1 Ranged Point!");
                                    Console.WriteLine("Your Ranged is now {0}", Ranged);
                                    Console.ReadLine();
                                }
                                if (Input == "3" || Input == "Magic")
                                {
                                    correct = 1;
                                    Magic += 5;
                                    Console.Clear();
                                    Console.WriteLine("You gained 1 Magic Point!");
                                    Console.WriteLine("Your Magic is now {0}", Magic);
                                    Console.ReadLine();
                                }
                                else { }
                            } while (correct == 0);
                            correct = 0; //Restate it to not mess it up in the future
                        }
                        if (Player_Health_Points <= 0)//In case your HP is 0 or less
                        {
                            Player_Health_Points = 0;//Resets it to zero
                            Console.WriteLine("Oh dear, you're dead!");
                            Console.WriteLine("The {0} has slain you, you're at 0 Health Points", Archer);
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("==================================Game Over=====================================");
                            Console.ReadLine();
                            System.Environment.Exit(0);//Closes console
                        }
                    }

                    //Wizard
                    if (Input == "Wizard" || Input == "5")
                    {
                        do
                        {
                            correct = 0; //Set the value to 0 again
                            Console.Clear(); //Clear the screen again
                            Console.WriteLine("Your Health is at {0} Points", Player_Health_Points);
                            Console.WriteLine("The {0}'s Health is at {1} Points", Wizard, Wizard_Health_Points);
                            Console.WriteLine("What do you want to do?");
                            Console.WriteLine("1. Attack");
                            Console.WriteLine("2. Ranged");
                            Console.WriteLine("3. Magic");
                            Console.WriteLine("4. Potion");
                            Input = Console.ReadLine();
                            if (Input == "1" || Input == "Attack")
                            {
                                Random Damage_Roll = new Random(); //Instantiates a new random damage 
                                int Random_Damage_Roll = Damage_Roll.Next(0, Attack); //The new random damage ranges from 0 to the guy's attack damage
                                Console.WriteLine("{0}", Random_Damage_Roll);//It outputs the Random_Damage_Roll
                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Wizard);
                                Random Skill_Point_Roll = new Random();//Setting a skill point roll for Crits
                                int Skill_Point_Outcome = random.Next(0, 11);//A random num between 0 and 10
                                if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)//if the random num is > 0, and your damage > 0, then Crit
                                {
                                    Random_Damage_Roll = Random_Damage_Roll + Attack;
                                    Console.WriteLine("You did a critical hit, with {0} skill points of damage", Attack);
                                }

                                else { }

                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Wizard);//Tells you the result 
                                Wizard_Health_Points = Wizard_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                            }
                            if (Input == "2" || Input == "Ranged")
                            {
                                Random Damage_Roll = new Random();
                                int Random_Damage_Roll = Damage_Roll.Next(0, Ranged);
                                Console.WriteLine("{0}", Random_Damage_Roll);
                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Wizard);
                                Random Skill_Point_Roll = new Random();
                                int Skill_Point_Outcome = random.Next(0, 11);
                                if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                                {
                                    Random_Damage_Roll = Random_Damage_Roll + Ranged;
                                    Console.WriteLine("You did a critical hit, with {0} skill points of damage", Ranged);
                                }

                                else { }

                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Wizard);//Tells you the result 
                                Wizard_Health_Points = Wizard_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                            }
                            if (Input == "3" || Input == "Magic")
                            {
                                Random Damage_Roll = new Random();
                                int Random_Damage_Roll = Damage_Roll.Next(0, Magic);
                                Console.WriteLine("{0}", Random_Damage_Roll);
                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Wizard);
                                Random Skill_Point_Roll = new Random();
                                int Skill_Point_Outcome = random.Next(0, 11);
                                if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                                {
                                    Random_Damage_Roll = Random_Damage_Roll + Magic;
                                    Console.WriteLine("You did a critical hit, with {0} skill points of damage", Magic);
                                }

                                else { }

                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Wizard);//Tells you the result 
                                Wizard_Health_Points = Wizard_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                            }
                            if (Input == "4" || Input == "Potion")
                            {
                                if (Inventory[17] == null && Inventory[18] == null && Inventory[19] == null)//If you don't have any potions
                                {
                                    Console.WriteLine("You don't have any potions");
                                    Console.ReadLine();
                                }
                                if (Inventory[17] != null || Inventory[18] != null || Inventory[19] != null)//If you have potions
                                {
                                    do
                                    {
                                        Console.WriteLine("Which health potion do you want to use?");
                                        Console.WriteLine("1. Weak Health Potion");
                                        Console.WriteLine("2. Strong Health Potion");
                                        Console.WriteLine("3. Random Health Potion(0-100 hp)");
                                        Input = Console.ReadLine();
                                        if (Input == "1" && Inventory[17] == null)//If you don't have a Weak Potion
                                        {
                                            correct = 0;
                                            Console.WriteLine("You don't have a Weak Health Potion.");
                                            Console.ReadLine();
                                        }
                                        if (Input == "1" && Inventory[17] != null)//If you have a Weak Potion
                                        {
                                            Inventory[17] = null; //We get rid of the item upon use
                                            correct = 1;
                                            Player_Health_Points = Player_Health_Points + Weak_Health_Potion;
                                            Console.WriteLine("You use the Weak Health Potion and gain 5 Health");
                                            Console.ReadLine();
                                        }
                                        if (Input == "2" && Inventory[18] == null)//If you don't have a Strong Potion
                                        {
                                            correct = 0;
                                            Console.WriteLine("You don't have a Strong Health Potion.");
                                            Console.ReadLine();
                                        }
                                        if (Input == "2" && Inventory[18] != null)//If you have a Strong Potion
                                        {
                                            Inventory[18] = null; //We get rid of the item upon use
                                            correct = 1;
                                            Player_Health_Points = Player_Health_Points + Strong_Health_Potion;
                                            Console.WriteLine("You use the Strong Health Potion and gain 20 Health");
                                            Console.ReadLine();
                                        }
                                        if (Input == "3" && Inventory[19] == null)//If you don't have a Random Potion
                                        {
                                            correct = 0;
                                            Console.WriteLine("You don't have a Random Health Potion.");
                                            Console.ReadLine();
                                        }
                                        if (Input == "3" && Inventory[19] != null)//If you do have a Random Potion
                                        {
                                            Inventory[19] = null; //We get rid of the item upon use
                                            correct = 1;
                                            Random Health_Roll = new Random();
                                            Random_Health_Potion = Health_Roll.Next(0, 100);
                                            Player_Health_Points = Player_Health_Points + Random_Health_Potion;
                                            Console.WriteLine("You use the Random Health Potions and you gain {0} Health", Random_Health_Potion);
                                            Console.ReadLine();
                                        }
                                    } while (correct == 0);
                                }
                            }
                            if (Wizard_Health_Points > 0 && ((Input == "1" || Input == "Attack") || (Input == "2" || Input == "Ranged") || (Input == "3" || Input == "Magic")))//If enemy is alive and player inputs a proper value
                            {
                                Random Enemy_Damage_Roll = new Random();
                                int Random_Enemy_Damage_Roll = Enemy_Damage_Roll.Next(0, Wizard_Maximum_Damage);
                                Console.WriteLine("The {0} Strikes back, and deals {1} Points of Damage", Wizard, Random_Enemy_Damage_Roll);//A roll to see if enemy is going to hit
                                Player_Health_Points = Player_Health_Points - Random_Enemy_Damage_Roll;//Subtracting damage with my health
                                Console.ReadLine();
                            }
                            else { }
                        } while (Player_Health_Points > 0 && Wizard_Health_Points > 0);

                        if (Wizard_Health_Points <= 0) //This is in case enemy's hp goes less than 0
                        {
                            correct = 0;//Restating this so that we can run a successful do - while loop
                            do
                            {
                                Wizard_Health_Points = 12; //Resets it to 12
                                Player_Gold += 20;
                                Console.Clear();
                                Console.WriteLine("You have slain the {0}!", Wizard);
                                Console.WriteLine("You gained {0} gold", Wizard_Gold);
                                Console.WriteLine("You can now upgrade one of your skills. Which skill do you want to upgrade? Select a number.");
                                Console.WriteLine("1. Attack");
                                Console.WriteLine("2. Ranged");
                                Console.WriteLine("3. Magic");
                                Input = Console.ReadLine();
                                if (Input == "1" || Input == "Attack")
                                {
                                    correct = 1; //State it to 1, so that it won't loop again
                                    Attack += 5;
                                    Console.Clear();
                                    Console.WriteLine("You gained 1 Attack Point!");
                                    Console.WriteLine("Your Attack is now {0}.", Attack);
                                    Console.ReadLine();
                                }
                                if (Input == "2" || Input == "Ranged")
                                {
                                    correct = 1;
                                    Ranged += 10; //Ranged beats Magic
                                    Console.Clear();
                                    Console.WriteLine("You gained 1 Ranged Point!");
                                    Console.WriteLine("Your Ranged is now {0}", Ranged);
                                    Console.ReadLine();
                                }
                                if (Input == "3" || Input == "Magic")
                                {
                                    correct = 1;
                                    Magic += 5;
                                    Console.Clear();
                                    Console.WriteLine("You gained 1 Magic Point!");
                                    Console.WriteLine("Your Magic is now {0}", Magic);
                                    Console.ReadLine();
                                }
                                else { }
                            } while (correct == 0);
                            correct = 0; //Restate it to not mess it up in the future
                        }
                        if (Player_Health_Points <= 0)//In case your HP is 0 or less
                        {
                            Player_Health_Points = 0;//Resets it to zero
                            Console.WriteLine("Oh dear, you're dead!");
                            Console.WriteLine("The {0} has slain you, you're at 0 Health Points", Wizard);
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("==================================Game Over=====================================");
                            Console.ReadLine();
                            System.Environment.Exit(0);//Closes console
                        }
                    }


                    //Dragon
                    if (Input == "Dragon" || Input == "6")
                    {
                        do
                        {
                            correct = 0; //Set the value to 0 again
                            Console.Clear(); //Clear the screen again
                            Console.WriteLine("Your Health is at {0} Points", Player_Health_Points);
                            Console.WriteLine("The {0}'s Health is at {1} Points", Dragon, Dragon_Health_Points);
                            Console.WriteLine("What do you want to do?");
                            Console.WriteLine("1. Attack");
                            Console.WriteLine("2. Ranged");
                            Console.WriteLine("3. Magic");
                            Console.WriteLine("4. Potion");
                            Input = Console.ReadLine();
                            if (Input == "1" || Input == "Attack")
                            {
                                Random Damage_Roll = new Random(); //Instantiates a new random damage 
                                int Random_Damage_Roll = Damage_Roll.Next(0, Attack); //The new random damage ranges from 0 to the guy's attack damage
                                Console.WriteLine("{0}", Random_Damage_Roll);//It outputs the Random_Damage_Roll
                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Dragon);
                                Random Skill_Point_Roll = new Random();//Setting a skill point roll for Crits
                                int Skill_Point_Outcome = random.Next(0, 11);//A random num between 0 and 10
                                if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)//if the random num is > 0, and your damage > 0, then Crit
                                {
                                    Random_Damage_Roll = Random_Damage_Roll + Attack;
                                    Console.WriteLine("You did a critical hit, with {0} skill points of damage", Attack);
                                }

                                else { }

                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Dragon);//Tells you the result 
                                Dragon_Health_Points = Dragon_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                            }
                            if (Input == "2" || Input == "Ranged")
                            {
                                Random Damage_Roll = new Random();
                                int Random_Damage_Roll = Damage_Roll.Next(0, Ranged);
                                Console.WriteLine("{0}", Random_Damage_Roll);
                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Dragon);
                                Random Skill_Point_Roll = new Random();
                                int Skill_Point_Outcome = random.Next(0, 11);
                                if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                                {
                                    Random_Damage_Roll = Random_Damage_Roll + Ranged;
                                    Console.WriteLine("You did a critical hit, with {0} skill points of damage", Ranged);
                                }

                                else { }

                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Dragon);//Tells you the result 
                                Dragon_Health_Points = Dragon_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                            }
                            if (Input == "3" || Input == "Magic")
                            {
                                Random Damage_Roll = new Random();
                                int Random_Damage_Roll = Damage_Roll.Next(0, Magic);
                                Console.WriteLine("{0}", Random_Damage_Roll);
                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Dragon);
                                Random Skill_Point_Roll = new Random();
                                int Skill_Point_Outcome = random.Next(0, 11);
                                if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                                {
                                    Random_Damage_Roll = Random_Damage_Roll + Magic;
                                    Console.WriteLine("You did a critical hit, with {0} skill points of damage", Magic);
                                }

                                else { }

                                Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Dragon);//Tells you the result 
                                Dragon_Health_Points = Dragon_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
                            }
                            if (Input == "4" || Input == "Potion")
                            {
                                if (Inventory[17] == null && Inventory[18] == null && Inventory[19] == null)//If you don't have any potions
                                {
                                    Console.WriteLine("You don't have any potions");
                                    Console.ReadLine();
                                }
                                if (Inventory[17] != null || Inventory[18] != null || Inventory[19] != null)//If you have potions
                                {
                                    do
                                    {
                                        Console.WriteLine("Which health potion do you want to use?");
                                        Console.WriteLine("1. Weak Health Potion");
                                        Console.WriteLine("2. Strong Health Potion");
                                        Console.WriteLine("3. Random Health Potion(0-100 hp)");
                                        Input = Console.ReadLine();
                                        if (Input == "1" && Inventory[17] == null)//If you don't have a Weak Potion
                                        {
                                            correct = 0;
                                            Console.WriteLine("You don't have a Weak Health Potion.");
                                            Console.ReadLine();
                                        }
                                        if (Input == "1" && Inventory[17] != null)//If you have a Weak Potion
                                        {
                                            Inventory[17] = null; //We get rid of the item upon use
                                            correct = 1;
                                            Player_Health_Points = Player_Health_Points + Weak_Health_Potion;
                                            Console.WriteLine("You use the Weak Health Potion and gain 5 Health");
                                            Console.ReadLine();
                                        }
                                        if (Input == "2" && Inventory[18] == null)//If you don't have a Strong Potion
                                        {
                                            correct = 0;
                                            Console.WriteLine("You don't have a Strong Health Potion.");
                                            Console.ReadLine();
                                        }
                                        if (Input == "2" && Inventory[18] != null)//If you have a Strong Potion
                                        {
                                            Inventory[18] = null; //We get rid of the item upon use
                                            correct = 1;
                                            Player_Health_Points = Player_Health_Points + Strong_Health_Potion;
                                            Console.WriteLine("You use the Strong Health Potion and gain 20 Health");
                                            Console.ReadLine();
                                        }
                                        if (Input == "3" && Inventory[19] == null)//If you don't have a Random Potion
                                        {
                                            correct = 0;
                                            Console.WriteLine("You don't have a Random Health Potion.");
                                            Console.ReadLine();
                                        }
                                        if (Input == "3" && Inventory[19] != null)//If you do have a Random Potion
                                        {
                                            Inventory[19] = null; //We get rid of the item upon use
                                            correct = 1;
                                            Random Health_Roll = new Random();
                                            Random_Health_Potion = Health_Roll.Next(0, 100);
                                            Player_Health_Points = Player_Health_Points + Random_Health_Potion;
                                            Console.WriteLine("You use the Random Health Potions and you gain {0} Health", Random_Health_Potion);
                                            Console.ReadLine();
                                        }
                                    } while (correct == 0);
                                }
                            }
                            if (Dragon_Health_Points > 0 && ((Input == "1" || Input == "Attack") || (Input == "2" || Input == "Ranged") || (Input == "3" || Input == "Magic")))//If enemy is alive and player inputs a proper value
                            {
                                Random Enemy_Damage_Roll = new Random();
                                int Random_Enemy_Damage_Roll = Enemy_Damage_Roll.Next(0, Dragon_Maximum_Damage);
                                Console.WriteLine("The {0} Strikes back, and deals {1} Points of Damage", Dragon, Random_Enemy_Damage_Roll);//A roll to see if enemy is going to hit
                                Player_Health_Points = Player_Health_Points - Random_Enemy_Damage_Roll;//Subtracting damage with my health
                                Console.ReadLine();
                            }
                            else { }
                        } while (Player_Health_Points > 0 && Dragon_Health_Points > 0);

                        if (Dragon_Health_Points <= 0) //This is in case enemy's hp goes less than 0
                        {
                            Dragon_Health_Points = 60; //Resets it to 60
                            Player_Gold += 100;
                            Console.Clear();
                            Console.WriteLine("You have finally slain the {0}!", Dragon);
                            Console.WriteLine("You are finally free!");
                            Console.ReadLine();
                            Console.WriteLine("You head towards the city, with the Dragon's head, and drop it in front of the Paladin who improsined you.");
                            Console.ReadLine();
                            Console.WriteLine("Amongst chants, and a huge cash reward, you set off from the town, to continue your adventure elsewhere...");
                            Console.ReadLine();
                            do
                            {
                                correct = 0;
                                Console.Clear();
                                Console.WriteLine("==================================================================================================");
                                Console.WriteLine("==================================================================================================");
                                Console.WriteLine("==================================================================================================");
                                Console.WriteLine("================================   The Transient Prisoner   ======================================");
                                Console.WriteLine("==================================================================================================");
                                Console.WriteLine("==================================================================================================");
                                Console.WriteLine("==================================================================================================");
                                Console.WriteLine("================================        The End :)          ======================================");
                                Console.WriteLine("==================================================================================================");
                                Console.WriteLine("================================          About             ======================================");
                                Console.WriteLine("==================================================================================================");
                                Console.WriteLine("================================     By: Tareq Karimi       ======================================");
                                Console.WriteLine("==================================================================================================");
                                Input = Console.ReadLine();
                                if (Input == "About")
                                {
                                    Console.Clear();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Congratulations no finishing the game!");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Hello, I'm Tareq. Welcome to my game! This is a text based console game, inspired by old console games from the 80s, meaning I did take some lines from other games to make this possible.");
                                    Console.WriteLine("This is my first game of hopefully many, and I hope you enjoyed it :)");
                                    Console.WriteLine("\n");
                                    Console.WriteLine("<Back");
                                    Input = Console.ReadLine();
                                    if (Input == "Back")
                                    {
                                        correct = 0;
                                    }
                                }
                                if (Input != "About")
                                {
                                    correct = 0;
                                }
                                else { }
                            } while (correct == 0);
                            correct = 0; //Restate it to not mess it up in the future
                        }
                        if (Player_Health_Points <= 0)//In case your HP is 0 or less
                        {
                            Player_Health_Points = 0;//Resets it to zero
                            Console.WriteLine("Oh dear, you're dead!");
                            Console.WriteLine("The {0} has slain you, you're at 0 Health Points", Dragon);
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("==================================Game Over=====================================");
                            Console.ReadLine();
                            System.Environment.Exit(0);//Closes console
                        }
                    }
                }
            } while (correct != 3); //The game ends here so it will never go past this.











            ////Inventory
            //// Inventory[0] = "Sword"; Inventory[1] = "Bow"; Inventory[2] = "Staff";

            //Console.Clear();
            //Console.WriteLine("Would you like a weapon? Yes/No.");
            //Input = Console.ReadLine();
            ////Inventory System;
            //if (Input == "Yes")
            //{
            //    Console.Clear();
            //    Console.WriteLine("Your Inventory Contains: ");
            //    for (Arraycount = 0; Arraycount < 20; Arraycount++)//Set arraycount to 0, If array count <20 continue, And add an array each time
            //    {
            //        int inventory_position = Arraycount + 1; //The inventory position is 20, since this loops 20 times.
            //        Console.SetCursorPosition(0, inventory_position);//Sets the blinking vertical line(cursor) to the position 0, 20(since 20 is the end of the array list) This ensures you never write over an item
            //        Console.WriteLine("{0}", Inventory[Arraycount]);
            //        //the {0} posts whats listed after it
            //        //Ex String b = "world.";
            //        //Console.WriteLine("Hello {0}, b);
            //        //Output: Hello world
            //    }
            //    do
            //    {

            //        Console.WriteLine("Which Item would you like to pick? Select a number from the following: ");
            //        Console.WriteLine("1. Sword");
            //        Console.WriteLine("2. Bow");
            //        Console.WriteLine("3. Staff");
            //        Input = Console.ReadLine();
            //        if (Input == "1" || Input == "Sword")
            //        {
            //            Attack += 1;
            //            Console.WriteLine("The Sword has the following bonuses:");
            //            Console.WriteLine("Attack: +1");
            //            Console.WriteLine("Ranged: +0");
            //            Console.WriteLine("Mage: +0");
            //            Console.WriteLine("Is this the weapon you want? Enter Yes/No:");
            //            Input = Console.ReadLine();
            //            if (Input == "Yes")
            //            {
            //                correct = 1;
            //            }
            //            if (Input == "No")
            //            {
            //                correct = 0;
            //            }

            //        }
            //        if (Input == "2" || Input == "Bow")
            //        {
            //            Ranged += 1;
            //            Console.WriteLine("The Bow has the following bonuses:");
            //            Console.WriteLine("Attack: +0");
            //            Console.WriteLine("Ranged: +1");
            //            Console.WriteLine("Mage: +0");
            //            Console.WriteLine("Is this the weapon you want? Enter Yes/No:");
            //            Input = Console.ReadLine();
            //            if (Input == "Yes")
            //            {
            //                correct = 1;
            //            }
            //            if (Input == "No")
            //            {
            //                correct = 0;
            //            }

            //        }
            //        if (Input == "3" || Input == "Staff")
            //        {
            //            Magic += 1;
            //            Console.WriteLine("The Staff has the following bonuses:");
            //            Console.WriteLine("Attack: +0");
            //            Console.WriteLine("Ranged: +0");
            //            Console.WriteLine("Magic: +1");
            //            Console.WriteLine("Is this the class you want? Enter Yes/No:");
            //            Input = Console.ReadLine();
            //            if (Input == "Yes")
            //            {
            //                correct = 1;
            //            }
            //            if (Input == "No")
            //            {
            //                correct = 0;
            //            }

            //        }

            //    } while (correct == 0);
            //}
            //else //If they don't want a weapon, it just goes on.
            //{
            //}








            //Combat System
            //do
            //{
            //    correct = 0; //Set the value to 0 again
            //    Console.Clear(); //Clear the screen again
            //    Console.WriteLine("Your Health is at {0} Points", Player_Health_Points);
            //    Console.WriteLine("The {0}'s Health is at {1} Points", Rat, Rat_Health_Points);
            //    Console.WriteLine("Enter the number for the type of attack you wish to perform");
            //    Console.WriteLine("1. Attack");
            //    Console.WriteLine("2. Ranged");
            //    Console.WriteLine("3. Magic");
            //    Input = Console.ReadLine();
            //    if (Input == "1" || Input == "Attack")
            //    {
            //        Random Damage_Roll = new Random(); //Instantiates a new random damage 
            //        int Random_Damage_Roll = Damage_Roll.Next(0, Attack); //The new random damage ranges from 0 to the guy's attack damage
            //        Console.WriteLine("{0}", Random_Damage_Roll);//It outputs the Random_Damage_Roll
            //        Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Rat);
            //        Random Skill_Point_Roll = new Random();//Setting a skill point roll for Crits
            //        int Skill_Point_Outcome = random.Next(0, 11);//A random num between 0 and 10
            //        if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)//if the random num is > 0, and your damage > 0, then Crit
            //        {
            //            Random_Damage_Roll = Random_Damage_Roll + Attack;
            //            Console.WriteLine("You did a critical hit, with {0} skill points of damage", Attack);
            //        }

            //        else { }

            //        Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Rat);//Tells you the result 
            //        Rat_Health_Points = Rat_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
            //    }
            //    if (Input == "2" || Input == "Ranged")
            //    {
            //        Random Damage_Roll = new Random();
            //        int Random_Damage_Roll = Damage_Roll.Next(0, Ranged);
            //        Console.WriteLine("{0}", Random_Damage_Roll);
            //        Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Rat);
            //        Random Skill_Point_Roll = new Random();
            //        int Skill_Point_Outcome = random.Next(0, 11);
            //        if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
            //        {
            //            Random_Damage_Roll = Random_Damage_Roll + Ranged;
            //            Console.WriteLine("You did a critical hit, with {0} skill points of damage", Ranged);
            //        }

            //        else { }

            //        Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Rat);//Tells you the result 
            //        Rat_Health_Points = Rat_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
            //    }
            //    if (Input == "3" || Input == "Magic")
            //    {
            //        Random Damage_Roll = new Random();
            //        int Random_Damage_Roll = Damage_Roll.Next(0, Magic);
            //        Console.WriteLine("{0}", Random_Damage_Roll);
            //        Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Rat);
            //        Random Skill_Point_Roll = new Random();
            //        int Skill_Point_Outcome = random.Next(0, 11);
            //        if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
            //        {
            //            Random_Damage_Roll = Random_Damage_Roll + Magic;
            //            Console.WriteLine("You did a critical hit, with {0} skill points of damage", Magic);
            //        }

            //        else { }

            //        Console.WriteLine("You did {0} damage to the {1}", Random_Damage_Roll, Rat);//Tells you the result 
            //        Rat_Health_Points = Rat_Health_Points - Random_Damage_Roll; //Brings a new value to the Enemy HP
            //    }
            //    if (Rat_Health_Points > 0 && ((Input == "1" || Input == "Attack") || (Input== "2" || Input == "Ranged") || (Input == "3" || Input == "Magic")))//If enemy is alive and player inputs a proper value
            //    {
            //        Random Enemy_Damage_Roll = new Random();
            //        int Random_Enemy_Damage_Roll = Enemy_Damage_Roll.Next(0, Rat_Maximum_Damage);
            //        Console.WriteLine("The {0} Strikes back, and deals {1} Points of Damage", Rat, Random_Enemy_Damage_Roll);//A roll to see if enemy is going to hit
            //        Player_Health_Points = Player_Health_Points - Random_Enemy_Damage_Roll;//Subtracting damage with my health
            //        Console.ReadLine();
            //    }
            //    else { }
            //} while (Player_Health_Points > 0 && Rat_Health_Points > 0);

            //Console.Clear();
            //if (Rat_Health_Points <= 0) //This is in case enemy's hp goes less than 0
            //{
            //    correct = 0;//Restating this so that we can run a successful do - while loop
            //    do
            //    {
            //        Rat_Health_Points = 0; //Resets it to 0
            //        Console.Clear();
            //        Console.WriteLine("You have slain the {0}!", Rat);
            //        Console.WriteLine("You can now upgrade one of your skills. Which skill do you want to upgrade? Select a number.");
            //        Console.WriteLine("1. Attack");
            //        Console.WriteLine("2. Ranged");
            //        Console.WriteLine("3. Magic");
            //        Input = Console.ReadLine();
            //        if (Input == "1" || Input == "Attack")
            //        {
            //            correct = 1; //State it to 1, so that it won't loop again
            //            Attack += 1;
            //            Console.Clear();
            //            Console.WriteLine("You gained 1 Attack Point!");
            //            Console.WriteLine("Your Attack is now {0}.", Attack);
            //            Console.ReadLine();
            //        }
            //        if (Input == "2" || Input == "Ranged")
            //        {
            //            correct = 1;
            //            Ranged += 1;
            //            Console.Clear();
            //            Console.WriteLine("You gained 1 Ranged Point!");
            //            Console.WriteLine("Your Ranged is now {0}", Ranged);
            //            Console.ReadLine();
            //        }
            //        if (Input == "3" || Input == "Magic")
            //        {
            //            correct = 1;
            //            Magic += 1;
            //            Console.Clear();
            //            Console.WriteLine("You gained 1 Magic Point!");
            //            Console.WriteLine("Your Magic is now {0}", Magic);
            //            Console.ReadLine();
            //        }
            //        else { }
            //    } while (correct == 0);
            //    correct = 0; //Restate it to not mess it up in the future
            //}
            //if (Player_Health_Points <= 0)//In case your HP is 0 or less
            //{
            //    Player_Health_Points = 0;//Resets it to zero
            //    Console.WriteLine("Oh dear, you're dead!");
            //    Console.WriteLine("The {0} has slain you, you're at 0 Health Points", Rat);
            //    Console.ReadLine();
            //    Console.Clear();
            //    Console.WriteLine("==================================Game Over=====================================");
            //    Console.ReadLine();
            //    System.Environment.Exit(0);//Closes console
            //}

            //Console.Clear();
            //Console.WriteLine("You beat the Rat! ");





            //Console.ReadLine();



            Console.ReadLine();
        }
    }
}
