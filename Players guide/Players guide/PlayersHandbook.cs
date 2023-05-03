//ConsolasDefense
namespace PlayersHandbook

{
    using System.Reflection.PortableExecutable;
    using System.Transactions;
    using static System.Console;
    using PlayersGuideClasses;
    static class Exercise
    {
        public static int Consolasdefense()
        {



            string pointUpper;
            string pointRight;
            string pointLower;
            string pointLeft;

            int targetRow;
            int targetColumn;

            string targetRowInput;
            string targetColumnInput;



            Console.Title = "Consolas Defense";
            Console.Write("Target Row: ");
            targetRowInput = Console.ReadLine();
            targetRow = Convert.ToInt32(targetRowInput);
            Console.Write("\n");
            Console.Write("Target Column: ");
            targetColumnInput = Console.ReadLine();
            targetColumn = Convert.ToInt32(targetColumnInput);


            pointUpper = "(" + Convert.ToString(targetRow + 1) + "," + Convert.ToString(targetColumn) + ")";
            pointRight = "(" + Convert.ToString(targetRow) + "," + Convert.ToString(targetColumn + 1) + ")";
            pointLower = "(" + Convert.ToString(targetRow - 1) + "," + Convert.ToString(targetColumn) + ")";
            pointLeft = "(" + Convert.ToString(targetRow) + "," + Convert.ToString(targetColumn - 1) + ")";
            Console.WriteLine("Deploy to:");

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(pointUpper);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(pointRight);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(pointLower);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(pointLeft);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Beep();
            return 0;
        }

        public static int RepairingTheClockTower()
        {
            int inputTime;

            do
            {
                Console.WriteLine("New Iteration, write a number !");
                inputTime = Convert.ToInt32(Console.ReadLine());

                if (inputTime % 2 == 0)
                {
                    Console.WriteLine("Tick");
                }
                else
                {
                    Console.WriteLine("Tock");
                }
                Console.WriteLine("Press Enter To Repeat, Other keys to Exit");
            } while (Console.ReadKey().KeyChar == (char)13);


            return 0;
        }

        public static int WatchTower()
        {
            int x;
            int y;
            string enemyLocation = "";
            string enemyLocationHorizontal = "";
            string enemyLocationVertical = "";

            Console.Write("Give the value of x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nGive the value of y: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x < 0)
            {
                enemyLocationHorizontal = "West";
            }
            else if (x > 0)
            {
                enemyLocationHorizontal = "East";
            }

            if (y < 0)
            {
                enemyLocationVertical = "South";
            }
            else if (y > 0)
            {
                enemyLocationVertical = "North";
            }

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Enemy is here");
            }
            else
            {
                Console.WriteLine("Enemy is " + enemyLocationVertical + enemyLocationHorizontal);
            }


            return 0;
        }

        public static int BuyingInventory()
        {
            char PressedKey = (char)13;
            string rope = "Rope";
            string torches = "Torches";
            string climbingEquipment = "Climbing Equipment";
            string cleanWater = "Clean Water";
            string machete = "Machete";
            string canoe = "Canoe";
            string foodSupplies = "Food Supplies";

            int WantedItem = 0;
            int ropePrice = 10;
            int torchesPrice = 15;
            int climbingEquipmentPrice = 25;
            int cleanWaterPrice = 1;
            int machetePrice = 20;
            int canoePrice = 200;
            int foodSuppliesPrice = 1;
            do
            {
                Console.Clear();
                Console.Beep();

                Console.WriteLine("The following items are avaliable:");
                Console.WriteLine($"1 - {rope,20}");
                Console.WriteLine($"2 - {torches,20}");
                Console.WriteLine($"3 - {climbingEquipment,20}");
                Console.WriteLine($"4 - {cleanWater,20}");
                Console.WriteLine($"5 - {machete,20}");
                Console.WriteLine($"6 - {canoe,20}");
                Console.WriteLine($"7 - {foodSupplies,20}");
                Console.WriteLine("What number do you want to see the price of?");


                WantedItem = Convert.ToInt16(Console.ReadLine());

                switch (WantedItem)
                {
                    case 1:
                        Console.WriteLine($"Price of the item is: {Convert.ToString(ropePrice)}");
                        break;
                    case 2:
                        Console.WriteLine($"Price of the item is: {Convert.ToString(torchesPrice)}");
                        break;
                    case 3:
                        Console.WriteLine($"Price of the item is: {Convert.ToString(climbingEquipmentPrice)}");
                        break;
                    case 4:
                        Console.WriteLine($"Price of the item is: {Convert.ToString(cleanWaterPrice)}");
                        break;
                    case 5:
                        Console.WriteLine($"Price of the item is: {Convert.ToString(machetePrice)}");
                        break;
                    case 6:
                        Console.WriteLine($"Price of the item is: {Convert.ToString(canoePrice)}");
                        break;
                    case 7:
                        Console.WriteLine($"Price of the item is: {Convert.ToString(foodSuppliesPrice)}");
                        break;
                    default:
                        Console.WriteLine("Unavailable Item Number!");
                        break;

                }
                Console.WriteLine("Press Enter to ask Again");
            } while (Console.ReadKey().KeyChar == (char)13);


            return 0;
        }


        public static int DiscountedInventory()
        {
            char PressedKey = (char)13;
            string rope = "Rope";
            string torches = "Torches";
            string climbingEquipment = "Climbing Equipment";
            string cleanWater = "Clean Water";
            string machete = "Machete";
            string canoe = "Canoe";
            string foodSupplies = "Food Supplies";

            int wantedItem = 0;
            string buyersName = "";
            string buyerWithDiscount = "Marko";
            double discountFactor = 0.5;

            int ropePrice = 10;
            int torchesPrice = 15;
            int climbingEquipmentPrice = 25;
            int cleanWaterPrice = 1;
            int machetePrice = 20;
            int canoePrice = 200;
            int foodSuppliesPrice = 1;
            do
            {
                Console.Clear();
                Console.Beep();

                Console.WriteLine("The following items are avaliable:");
                Console.WriteLine($"1 - {rope,20}");
                Console.WriteLine($"2 - {torches,20}");
                Console.WriteLine($"3 - {climbingEquipment,20}");
                Console.WriteLine($"4 - {cleanWater,20}");
                Console.WriteLine($"5 - {machete,20}");
                Console.WriteLine($"6 - {canoe,20}");
                Console.WriteLine($"7 - {foodSupplies,20}");

                Console.Write("What is your name: ");
                buyersName = Console.ReadLine();

                if (buyersName == buyerWithDiscount)
                {
                    discountFactor = 0.5;
                }
                else
                {
                    discountFactor = 1;
                }

                Console.WriteLine($"Glad to meet you {buyersName}, What number do you want to see the price of?");

                wantedItem = Convert.ToInt16(Console.ReadLine());

                switch (wantedItem)
                {
                    case 1:
                        Console.WriteLine($"Price of the item is: {Convert.ToString(ropePrice * discountFactor)}");
                        break;
                    case 2:
                        Console.WriteLine($"Price of the item is: {Convert.ToString(torchesPrice * discountFactor)}");
                        break;
                    case 3:
                        Console.WriteLine($"Price of the item is: {Convert.ToString(climbingEquipmentPrice * discountFactor)}");
                        break;
                    case 4:
                        Console.WriteLine($"Price of the item is: {Convert.ToString(cleanWaterPrice * discountFactor)}");
                        break;
                    case 5:
                        Console.WriteLine($"Price of the item is: {Convert.ToString(machetePrice * discountFactor)}");
                        break;
                    case 6:
                        Console.WriteLine($"Price of the item is: {Convert.ToString(canoePrice * discountFactor)}");
                        break;
                    case 7:
                        Console.WriteLine($"Price of the item is: {Convert.ToString(foodSuppliesPrice * discountFactor)}");
                        break;
                    default:
                        Console.WriteLine("Unavailable Item Number!");
                        break;

                }
                Console.WriteLine("Press Enter to ask Again");
            } while (Console.ReadKey().KeyChar == (char)13);


            return 0;
        }

        public static int ThePrototype()
        {
            string Pilot = "Pilot";
            string Hunter = "Hunter";

            int PilotNumber;
            int HunterNumber;

            int Iteration = 0;

            WriteLine("Pilot enters  the number: ");
            PilotNumber = Convert.ToInt32(ReadLine());

            do
            {
                Iteration++;
                WriteLine($"Hunters {Convert.ToString(Iteration)}st Guess: ");
                HunterNumber = Convert.ToInt32(ReadLine());

                if (HunterNumber > PilotNumber)
                {
                    WriteLine($"Hunter overshoots!");
                }
                else if (HunterNumber < PilotNumber)
                {
                    WriteLine($"Hunter undershoots!");
                }
                WriteLine();
            } while (PilotNumber != HunterNumber);

            return 0;
        }

        public static int TheMagicCannon()
        {
            string CannonBall = "Normal";

            WriteLine("Order of Cannonballs is:");
            WriteLine();
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 != 0))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    CannonBall = "Fire";
                }
                else if (i % 5 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    CannonBall = "Electric";
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    CannonBall = "Normal";
                }
                WriteLine($"#{i}: {CannonBall,20}");
            }
            return 0;
        }
        public static int TheReplicatorOfTdo()
        {
            int[] firstArray = new int[5];
            int[] secondArray = new int[5];

            Console.BackgroundColor = ConsoleColor.Black;
            WriteLine("Fill the array:");

            Console.BackgroundColor = ConsoleColor.Blue;
            for (int i = 0; i < firstArray.Length; i++)
            {

                firstArray[i] = Convert.ToInt32(ReadLine());
            }

            Console.BackgroundColor = ConsoleColor.Black;
            WriteLine("Array Filled");

            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i < firstArray.Length; i++)
            {
                secondArray[i] = firstArray[i];
            }
            Console.BackgroundColor = ConsoleColor.Magenta;
            WriteLine($"Original Values:{firstArray[0]},{firstArray[1]},{firstArray[2]},{firstArray[3]},{firstArray[4]}");
            WriteLine($"New Values:{secondArray[0]},{secondArray[1]},{secondArray[2]},{secondArray[3]},{secondArray[4]}");

            Console.BackgroundColor = ConsoleColor.Black;
            return 0;
        }



        public static int TheLawsofFreach()
        {
            int[] firstArray = new int[5];
            int[] secondArray = new int[5];
            int i = 0;
            Console.BackgroundColor = ConsoleColor.Black;
            WriteLine("Fill the array:");

            Console.BackgroundColor = ConsoleColor.Blue;
            foreach (int Number in firstArray)
            {

                firstArray[i] = Convert.ToInt32(ReadLine());
                i++;
            }

            Console.BackgroundColor = ConsoleColor.Black;
            WriteLine("Array Filled");

            Console.BackgroundColor = ConsoleColor.Red;

            //i = 0;
            foreach (int Number in firstArray)
            {
                secondArray[i] = Number;
            }
            Console.BackgroundColor = ConsoleColor.Magenta;
            WriteLine($"Original Values:{firstArray[0]},{firstArray[1]},{firstArray[2]},{firstArray[3]},{firstArray[4]}");
            WriteLine($"New Values:{secondArray[0]},{secondArray[1]},{secondArray[2]},{secondArray[3]},{secondArray[4]}");

            Console.BackgroundColor = ConsoleColor.Black;
            return 0;
        }

        public static int askfornumberinrange(string text, int min, int max)
        {
            int intnum = Convert.ToInt32(text);
            if (intnum > min && intnum < max)
            {
                WriteLine($"number is:{text}");
            }
            return 0;
        }
        public static int Countdown(int Number)
        {
            WriteLine($"Current Number is {Convert.ToString(Number)}");
            if (Number > 0)
            {
                Number--;
                Countdown(Number);
            }
            return 0;
        }

        public static int huntingTheManticore()
        {


            int manticoreDistance = 0;
            int manticoreMaxHealth = 10;
            int manticoreHealth = manticoreMaxHealth;

            int consolasMaxHealth = 15;
            int consolasHealth = consolasMaxHealth;
            int consolasDistance = 0;

            int turnNumber = 0;
            int cannonDamage = 1;
            WriteLine("Player 1, how fat away from the city do you want to station the Manticore?");
            manticoreDistance = Convert.ToInt32(ReadLine());
            Console.Clear();
            WriteLine("Player 2, it is your turn.");
            while (manticoreHealth > 0 && consolasHealth > 0)
            {
                cannonDamage = turnNumber++;
                cannonDamage = cannonDamageCalculator(turnNumber);


                Console.BackgroundColor = ConsoleColor.Magenta;
                WriteLine("-----------------------------------------------------------");
                Console.BackgroundColor = ConsoleColor.Red;
                Write($"STATUS: Round: {turnNumber}  City: {consolasHealth}/{consolasMaxHealth}  Manticore: {manticoreHealth}/{manticoreMaxHealth}\n" +
                      $"The cannon is expected to deal {cannonDamage} damage this turn.\n" +
                      $"Enter desired cannon range: ");
                Console.BackgroundColor = ConsoleColor.Black;
                consolasDistance = Convert.ToInt32(ReadLine());


                Console.BackgroundColor = ConsoleColor.Yellow;
                if (consolasDistance > manticoreDistance)
                {
                    WriteLine("That round OVERSHOT the target.");
                }
                else if (consolasDistance < manticoreDistance)
                {
                    WriteLine("That round FELLSHORT of the target.");
                }
                else
                {
                    WriteLine("That round was a DIRECT HIT!");
                    manticoreHealth = manticoreHealth - cannonDamage;
                }
                Console.BackgroundColor = ConsoleColor.Black;

                consolasHealth--;

            }

            if (consolasHealth <= 0)
            {
                WriteLine("CITY OF CONSOLAS is DESTROYED");
            }
            if (manticoreHealth <= 0)
            {
                WriteLine("MANTICORE is DESTROYED");
            }
            Console.BackgroundColor = ConsoleColor.Black;


            static int cannonDamageCalculator(int parTurnNumber)
            {
                int normalDamage = 1;
                int fireDamage = 3;
                int electricDamage = 5;
                int fireElectricDamage = 10;

                if (parTurnNumber % 3 == 0 && parTurnNumber % 5 == 0)
                {

                    //fire electric blast
                    return (fireElectricDamage);
                }
                else if (parTurnNumber % 3 == 0)
                {
                    //fire blast
                    return (fireDamage);
                }
                else if (parTurnNumber % 5 == 0)
                {
                    //electric blast
                    return (electricDamage);
                }
                else
                {
                    return (normalDamage);
                }

            }
            return (0);
        }
        public static int simulasTest()
        {
            chestState currectState = chestState.Open;
            chestState wantedState;
            while (true)
            {


                switch (currectState)
                {
                    case chestState.Lock:
                        WriteLine("Chest is Locked, What do you want to do?");
                        wantedState = (chestState)Enum.Parse(typeof(chestState), ReadLine());
                        if (wantedState == chestState.Unlock)
                        {
                            currectState = chestState.Close;
                        }
                        break;

                    case chestState.Close:
                        WriteLine("Chest is Closed, What do you want to do?");
                        wantedState = (chestState)Enum.Parse(typeof(chestState), ReadLine());
                        if (wantedState == chestState.Lock)
                        {
                            currectState = chestState.Lock;
                        }
                        else if (wantedState == chestState.Open)
                        {
                            currectState = chestState.Open;
                        }
                        break;
                    case chestState.Open:
                        WriteLine("Chest is Open, What do you want to do?");
                        wantedState = (chestState)Enum.Parse(typeof(chestState), ReadLine());
                        if (wantedState == chestState.Close)
                        {
                            currectState = chestState.Close;
                        }
                        break;
                }

            }
            return (0);
        }
        public static int simulasSoup()
        {
            (foodType FoodType, mainIngredient MainIngredient, seasoning Seasoning) Soup;

            string[] foodTypeNames = Enum.GetNames(typeof(foodType));
            string[] mainIngredientNames = Enum.GetNames(typeof(mainIngredient));
            string[] seasoningNames = Enum.GetNames(typeof(seasoning));

            int userInput;

            WriteLine("Food Types to choose from are:");
            for (int i = 0; i < foodTypeNames.Length; i++)
            {
                WriteLine($"{i + 1}.{foodTypeNames[i],10}");
            }
            WriteLine("\nMain ingredient to choose from are:");
            for (int i = 0; i < mainIngredientNames.Length; i++)
            {
                WriteLine($"{i + 1}.{mainIngredientNames[i],10}");
            }
            WriteLine("\nSeasonings to choose from are:");
            for (int i = 0; i < seasoningNames.Length; i++)
            {
                WriteLine($"{i + 1}.{seasoningNames[i],10}");
            }

            WriteLine();
            WriteLine("Choose Food Type by Number:");
            userInput =(Convert.ToInt32(ReadLine()) - 1);
            if (userInput < Enum.GetNames(typeof(foodType)).Length && userInput >= 0)
            {
                Soup.FoodType = (foodType)userInput;
            }
            else
            {
                WriteLine("Invalid Food Type Number, setting to number 1 on menu");
                Soup.FoodType = (foodType)(0);
            }
            

            WriteLine("Choose Main ingredient:");
            userInput = (Convert.ToInt32(ReadLine()) - 1);
            if (userInput < Enum.GetNames(typeof(mainIngredient)).Length && userInput >= 0)
            {
                Soup.MainIngredient = (mainIngredient)userInput;
            }
            else
            {
                WriteLine("Invalid Food Type Number, setting to number 1 on menu");
                Soup.MainIngredient = (mainIngredient)(0);
            }

            WriteLine("Choose Seasoning:");
            userInput = (Convert.ToInt32(ReadLine()) - 1);
            if (userInput < Enum.GetNames(typeof(seasoning)).Length && userInput>=0)
            {
                Soup.Seasoning = (seasoning)userInput;
            }
            else
            {
                WriteLine("Invalid Food Type Number, setting to number 1 on menu");
                Soup.Seasoning = (seasoning)(0);
            }


            WriteLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            WriteLine($"You have choosen: {Soup.Seasoning} {Soup.MainIngredient} {Soup.FoodType}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            return (0);
        }
        public static int VinFletchersArrowsCall()
         {
            Arrowhead WantedArrowHead;

           
            VinFletchersArrows Arrow2 = new(Arrowhead.steel, Fletching.turkeyfeather, 70);
            
            WriteLine($"Cost of an Arrow is {Arrow2.GetCost()}");
            return (0);
         }


}




}