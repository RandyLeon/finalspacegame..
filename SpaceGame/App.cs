using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceGame
{
    public class App
    {
        List<Location> locations = new List<Location>();
        List<Ships> ships = new List<Ships>();

        //Ships Ships1;
        Player Trader;

        public App()
        {
            var bottleWater =     new Item("Bottle of water", 1.0M);
            var droid =           new Item("All purpose droid", 624.99M);
            var megaSeed =        new Item("Mega Seed", 1000.0M);
            var kalaxianCrystal = new Item("Kalaxian Crystal", 10000.0M);
            var gold =            new Item("Gold bar", 350.80M);
            var diamond =         new Item("Uncut diamond", 500.55M);
            var polymer =         new Item("Polymer '1Lb'", 100.0M);
            var kryptonite =      new Item("Kryptonite '1Lb'", 8000.0M);
            var deoderant =       new Item("Deodorant: Men/Women", 2.99M);
            var vibranium =       new Item("Vibranium '1Lb'", 14000.0M);
            var mrmeeseeks =      new Item("Mr. Meeseeks box 'Use with caution'", 999.99M);
            var senzubean =       new Item("Senzu bean", 830.0M);
            var mobilesuit =      new Item("Mobile suit", 1200.0M);
            var shard =           new Item("Mysterious shard", 750.0M);
            var michaelsstuff =   new Item("Michaels secret stuff", 450.0M);
            var ticket =          new Item("Tour of the batcave 'Lead by Alfred Pennyworth'", 15000.0M);
            var scoobysnack =     new Item("Scooby snacks", 50.0M);
            var soul =            new Item("Time stone", 12000.0M);
            var mind =            new Item("Reality stone", 850.0M);
            var rupee =           new Item("Purple rupee", 250.0M);

            locations.Add(
                new Location("Earth",
                             "Your home planet, you should visit your parents.",
                             0, 0,
                             new List<Item>() { polymer, gold, rupee, diamond, deoderant, ticket, vibranium, senzubean, soul
                             }));
            locations.Add(
                new Location("Alpha Centauri 3",
                             "Planet of the Alpha male.",
            0, 4.367,
                             new List<Item>() { droid, bottleWater, polymer, rupee, mind, shard, mobilesuit, scoobysnack, soul},
                             0.9M));
            locations.Add(
                new Location("Gazorpazorp",
                             "The planet of I don't need no man.",
                             5.294, 12.004 ,
                             new List<Item>() { droid, megaSeed, bottleWater, ticket, mind, gold, kalaxianCrystal, mrmeeseeks},
                             1.6M));
            locations.Add(
               new Location("Reach",
                            "Beautiful vacation location and hotspot for glassing.",
                            17.250, 34.103,
                            new List<Item>() { droid, megaSeed, bottleWater, kryptonite, mrmeeseeks, senzubean, shard},
                            2.0M));
            locations.Add(
               new Location("Pandora",
                            "Dangerous crime planet with no rules, Home of the vault hunters.",
                            2.140, 9.726,
                            new List<Item>() { droid, megaSeed, bottleWater, deoderant, diamond, mobilesuit, michaelsstuff},
                            2.3M));
            locations.Add(
               new Location("Krypton",
                            "Shattered planet once belonging to the race known as kryptonians.",
                            111.601, 41.222,
                            new List<Item>() { droid, megaSeed, bottleWater, vibranium, kryptonite, michaelsstuff, scoobysnack},
                            3.0M));

            Trader = new Player(locations[0]);
        }

    //public void App1()
    //{
    //    var spaceCruiser = new Item("Space Cruiser", 3.0);
    //    var speedster =    new Item("Speedster", 4.0);

    //    ships.Add(
    //    new Ships("Cruiser",
    //                   "Standard issue ship with warp speed of 3.0.",
    //                    new List<Item>() {spaceCruiser},
    //                    3.0));
    //    ships.Add(
    //   new Ships("Speedster",
    //                  "Tjis one will get you to were you need to go in a hurry clocking in at 4.0 warp speed.",
    //                   new List<Item>() {speedster},
    //                   4.0));

    //    Ships1 = new Ships(ships[0]);
    //}

    public void Run()
        {
            Story.Intro();

            var quitReason = EventLoop();

            Story.ClosingMessage(quitReason);
        }

        private QuitReason EventLoop()
        {
            QuitReason quitReason;

            do
            {
                Random rnd = new Random();
                string[] secOptions = {" Susan", " Phil", " Asta", " Yusuke", " Alfred", " Yuno", " Midoriya", " Lafter", " Biscuit", " Orga", " Atra",
                        " Chi-Chi", " Bulma", " Ichigo", " Nelliel", " Harley", " Bruce", " Robyn", " Hinata", " Minato", " Jiraiya", " Neji", "Natsu",
                        " Levi", " Aizen", " Rukia", " Motoko", "Rick" , "Morty", "Bender", "Zoidberg", "Fry", "Zapp", "Leela", "Kirk", "Spock", "Hon",
                                                                                                                "Anakin", "Obi wan", "Ahsoka", "Yoda"};
                int randomNumber = rnd.Next(0, 40);
                string secText = secOptions[randomNumber];

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Location: {Trader.location.name}                inventory: {Trader.inventory.Count}                     Name:{secText}                          Twinkies: {Trader.age:f2} boxes                            Schmeckles: {Trader.money:f1}\n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(Trader.location.description);
                Console.ResetColor();

                PrintOptionList();

                var key = UI.UserInput();

                quitReason = ShouldQuit(HandleInput(key));
            } while (quitReason == QuitReason.DontQuit);

            return quitReason;
        }

        private QuitReason ShouldQuit(QuitReason quitReason)
        {
            QuitReason AgeCheck() => Trader.age >= 70 ? QuitReason.Age : QuitReason.DontQuit;
            QuitReason MoneyCheck() => Trader.money < 0 ? QuitReason.OutOfMoney : QuitReason.DontQuit;


            if (quitReason == QuitReason.DontQuit)
            {
                quitReason = AgeCheck();
            }

            if (quitReason == QuitReason.DontQuit)
            {
                quitReason = MoneyCheck();
            }

            return quitReason;
        }

        private void PrintOptionList()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Options");
            Console.ResetColor();
            Console.WriteLine("1. Depart to other worlds");
            Console.WriteLine("2. Buy stuff");
            Console.WriteLine("3. Sell stuff");
            Console.WriteLine("4. Check inventory");
            Console.WriteLine("q. Quit/Back");
        }

        private QuitReason HandleInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.Q:
                    return QuitReason.UserQuit;
                case ConsoleKey.D1:
                    TravelMenu();
                    break;
                case ConsoleKey.D2:
                    BuyMenu();
                    break;
                case ConsoleKey.D3:
                    SellMenu();
                    break;
                case ConsoleKey.D4:
                    PrintItems(Trader.inventory);
                    Console.Write("Press 'Enter' to stop seeing inventory");
                    Console.ReadLine();
                    break;
            }

            return QuitReason.DontQuit;
        }

        private void SellMenu()
        {
            Console.Clear();

            if (Trader.inventory.Any())
            {
                PrintItems(Trader.inventory);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(@" 
                                     o
                                   $""$o
                                  $'  $$
                                   $$$$
                                   o '$o
                                  o'  '$
             oo$$$   oo$ $ooo   o$    '$    ooo'$oo  $$$'o
o o o o    oo'  o'      'o    $$o$'     o o$""  o$      '$  'oo   o o o o
'$o   ''$$$'   $$         $      '   o   ""    o'         $   'o$$'    o$$
  ""o       o  $          $'       $$$$$       o          $  ooo     o""
     'o   $$$$o $o       o$        $$$$$'       $o        ' $$$$   o''
      ""o $$$$o  oo o  o$'         $$$$$'        'o o o o'  '$$$  $
        ""  $      """"'            ""$'            ""'      '"" ''
         'oooooooooooooooooooooooooooooooooooooooooooooooooooooo$
          '$$$$'$$$$' $$$$$$$'$$$$$$ ' '$$$$$'$$$$$$'  $$$""$$$$
           $$$oo$$$$   $$$$$$o$$$$$$o' $$$$$$$$$$$$$$ o$$$$o$$$'
           $             """"""""""""""""""""""""""""""""""""""""""""""""""'            $
           $$                                                 $$
           $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $ $

                                                                    ");
                Console.ResetColor();
                var itemIndex = UI.UsersInput("What do ya have furr me: ", 1, Trader.inventory.Count);

                if (!itemIndex.cancelled)
                {
                    Trader.SellItem(Trader.inventory[itemIndex.input - 1]);
                }
            }
            else
            {
                Console.WriteLine("Ya got nothoing...");
                UI.UserInput("Press any key to continue...");
            }
        }
        
        private void BuyMenu()
        {
            Console.Clear();

            List<Item> items = Trader.location.items;

            PrintItems(items);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
      0_
       \`.     ___
        \ \   / __>0
    /\  /  |/' / 
   /  \/   `  ,`'--.
  / /(___________)_ \
  |/ //.-.   .-.\\ \ \
  0 // :@ ___ @: \\ \/
    ( o ^(___)^ o ) 0
     \ \_______/ /
 /\   '._______.'--.
 \ /|  |<_____>    |
  \ \__|<_____>____/|__
   \____<_____>_______/
       |<_____>    |
       |<_____>    |
       :<_____>____:
      / <_____>   /|
     /  <_____>  / |
    /___________/  |
    |           | _|__
    |           | ---||_
    |   |L\/|/  |  | [__]
    |  \|||\|\  |  /
    |           | /
    |___________|/

                                ");
            Console.ResetColor();
            var itemIndex = UI.UsersInput("What are yurr looking to buy: ", 1, items.Count);

            if (!itemIndex.cancelled)
            {
                Trader.BuyItem(items[itemIndex.input - 1]);
            }
        }

        private void PrintItems(List<Item> items)
        {
            for (int i = 0; i < items.Count; ++i)
            {
                var item = items[i];
                var cost = Trader.location.CostOf(item);

                Console.WriteLine($"{i + 1}. {item.name} - {cost:f2} Smks");
            }
        }

        

        public void TravelMenu()
        {
            var done = false;
            int selector = 0;
            int count = locations.Count;

            do
            {
                Console.Clear();
                Console.WriteLine("Depart to:");

                PrintLocationsAndDistances(selector);

                var key = UI.UserInput("");


                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        selector++;
                        selector %= count;
                        break;
                    case ConsoleKey.UpArrow:
                        selector--;
                        selector = (selector + count) % count;
                        break;
                    case ConsoleKey.Q:
                        done = true;
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.Enter:
                        done = true;
                        var warpSpeed = UI.InputUser("How fast do you need to go on a scale of 1-9?", 0.0, 9.0);
                        Trader.TravelTo(locations[selector], warpSpeed);
                        break;
                }
            } while (!done);
        }

        private void PrintLocationsAndDistances(int selector)
        {
            for (int i = 0; i < locations.Count; ++i)
            {
                Location destination = locations[i];

                var distance = Trader.location.DistanceTo(destination);

                Console.Write($" > ");

                if (i == selector)
                {
                    UI.Highlight();
                }

                Console.WriteLine($"{destination.name}: {distance:f2}Ly");

                UI.ResetColors();
            }
        }
    }
}