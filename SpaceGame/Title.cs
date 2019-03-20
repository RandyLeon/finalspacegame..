using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Title
    {
        public static void title()
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"


      ███████╗ ██████╗ ██╗         ████████╗██████╗  █████╗ ██████╗ ███████╗██████╗                     
      ██╔════╝██╔═══██╗██║         ╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔══██╗              
      ███████╗██║   ██║██║            ██║   ██████╔╝███████║██║  ██║█████╗  ██████╔╝             
      ╚════██║██║   ██║██║            ██║   ██╔══██╗██╔══██║██║  ██║██╔══╝  ██╔══██╗            
      ███████║╚██████╔╝███████╗       ██║   ██║  ██║██║  ██║██████╔╝███████╗██║  ██║                   
      ╚══════╝ ╚═════╝ ╚══════╝       ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ╚══════╝╚═╝  ╚═╝            
                           ____                                                    
                          /___/\_                                __
                         _\   \/_/\__                          _|  |_
                       __\       \/_/\                       _|      |_
                       \   __    __ \ \                     |  _    _  |
                      __\  \_\   \_\ \ \   __               | |_|  |_| |
                     /_/\\   __   __  \ \_/_/\           _  |  _    _  |  _
                     \_\/_\__\/\__\/\__\/_\_\/          |_|_|_| |__| |_|_|_|
                        \_\/_/\       /_\_\/              |_|_        _|_|
                           \_\/       \_\/                  |_|      |_|                            
                                                                                               
                                                                                                ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Press 'Enter' to begin your adventure\n");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;

        }

        public static void IntroText()
        {
            string myText = "Welcome to SOL TRADER brave adventurer!\n\n" +
                "The year is 2147. Exploring the stars has become a hobby for many as space travel ha become commonplace.\n" +
                "You have just graduated from the stellar business academy with a degree in intergalactic finance! Well done.\n" +
                "While in school unfortunately your wife left you and took the kids, also your father got sick and died.\n" +
                "This is great news, now that your only family has left you you're free to roam the stars whenever you want.\n" +
                "Your deceased father left you his most prized possesion, The Millenium Space Rat! Its not much but it\n" +
                "will get the job done for now, once you get going you can buy yourself a new ship. Unless you end up\n" +
                "dying alone in the infinite abyss of space... Well anyways, GOOD LUCK in your travels.\n\n" +
                "Press 'Enter' to continue";

            for (int i = 0; i < myText.Length; i++)
            {
                Console.Write(myText[i]);
                System.Threading.
                Thread.Sleep(5);
            }
            Console.ReadLine();
            Console.Clear();
        }

        public static void IntroText2()
        {
            Console.WriteLine(@"you have about 50 years to do your thing, so get to it!
  .      .      .      .      .      .      .      .      .      .      .
.                               .       .       .       .       .       .
   .        .        .        .        .        .        .        .        .
     .         .         .        _......____._        .         .
   .          .          . ..--'"" .           """"""---...          .
                   _...--""        ................       `-.              .
                .-'        ...:'::::;:::%:.::::::_;;:...     `-.
             .-'       ..::::'''''   _...---'"""":::+;_::.      `.      .
  .        .' .    ..::::'      _.-""               :::)::.       `.
         .      ..;:::'     _.-'         .             f::'::    o  _
        /     .:::%'  .  .-'                        .-.  ::;;:.   /' 'x
  .   .'  ""::.::'    .-'     _.--'""'-.           (   )  ::.::  |_.-' |
     .'    ::;:'    .'     .-' .d@@b.   \    .    . `-'   ::%::   \_ _/    .
    .'    :,::'    /   . _'    8@@@@8   j      .-'       :::::      ' o
    | .  :.%:' .  j     (_)    `@@@P'  .'   .-'         ::.::    .  f
    |    ::::     (        -..____...-'  .-'          .::::'       /
.   |    `:`::    `.                ..--'        .  .::'::   .    /
    j     `:::::    `-._____...---""             .::%:::'       .'  .
     \      ::.:%..             .       .    ...:,::::'       .'
 .    \       `:::`:..                ....::::.::::'       .-'          .
       \    .   ``:::%::`::.......:::::%::.::::''       .-'
      . `.        . ``::::::%::::.::;;:::::'''      _.-'          .
  .       `-..     .    .   ````'''''         . _.-'     .          .
         .    ""--...____    .   ______......--' .         .         .
  .        .        .    """"""""     .        .        .        .        .
 .       .       .       .       .       .       .       .       .
     .      .      .      .      .      .      .      .      .      .      .
                                             ");
        }
    }
}
