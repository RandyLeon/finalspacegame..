using System;

namespace SpaceGame
{
    public static class Story
    {
        public static void Intro()
        {
            string prompt = "Press any key to continue...";

            Console.Clear();
            Title.title();

            Console.Clear();
            Title.IntroText();

            Title.IntroText2();
            UI.UserInput(prompt);
        }

        public static void ClosingMessage(QuitReason quitReason)
        {
            Console.Clear();

            switch (quitReason)
            {
                case QuitReason.UserQuit:
                    Console.WriteLine(@"Bye! Felicia...
          _.----.                          
       .-'       \-.                       
      /           ; \                      
     :           /:  \                     
     ;         .'  ;  ;                    
     ;      .-'    :  :                    
    :   _.+(   .-- :  :                    
    ;  ;   ' :  :                    
    ;  :           ;  ;                    
    :   ;    -    :  :                     
     )  '   .-.   '  :                     
    (    '. `'' .'   ;                     
     '-._.:`---':-'-.'+'                   
          ;     ;    '                     
   _..__.-. -. (:                          
 ,'   .:(o);     '-._                      
 :    _: 0 ;        \`.                    
 ;  .'/.\-/-.        `:                    
:  : :  -U--:'-.  \    ;                   
;  ; :  ----;   '-.L.-' \                  
'. '  \ ---(      ;O:    ;                 
  \ '. '-;-'      :-:    :                 
   `. ""/         ; :    ;                 
     ""T      .-':  :`. /                  
       :  --""   :   ; Y                   
        ;        ;   : :                   
        :       :     ; ;                  
         ;      :   ; : :                  
         :      ;   :  ; \                 
          ;    :    ;  :  \_               
          :    :        \  \'-.            
          ;    ;         \  `. '-.         
         :    :     c     \   `./'-._      
         ;    :            \    \    '-.   
        :     ;             `.    -.  -.`. 
        :    :       __..--"" \     `.\.`.\
        ;    :_..--"";  ;  _.-'\      ')))T
       :     ;      _L.-'""     ;      '-='
");
                    Console.ReadLine();
                    break;
                case QuitReason.Age:
                    Console.WriteLine(@"You're 70 years old... The time has come for you to retire.
                                             ,
            ,:' `..;
            `. ,;;'%
            +;;'%%%%%
             /- %,)%%
             `   \ %%
              =  )/ \
              `-'/ / \
                /\/.-.\
               |  (    |
               |  |   ||
               |  |   ||
           _.-----'   ||
          / \________,'|
         (((/  |       |
         //    |       |
        //     |\      |
       //      | \     |
      //       |  \    |
     //        |   \   |
    //         |    \  |
   //          |    |\ |
  //           |    | \|
 //            \    \
c'             |\    \
               | \    \
               |  \    \
               |.' \    \
              _\    \.-' \ 
             (___.-(__.'\/

");
                    Console.ReadLine();
                    break;
                case QuitReason.OutOfMoney:
                    Console.WriteLine(@"You're broke, have fun dying in space.
  ___  _____    
 .'/,-Y'     '~-.  
 l.Y             ^.           
 /\               _\_      'Doh!'   
i            ___/'   '\ 
|          /'   '\   o !   
l         ]     o !__./   
 \ _  _    \.___./    '~\  
  X \/ \            ___./  
 ( \ ___.   _..--~~'   ~`-.  
  ` Z,--   /               \    
    \__.  (   /       ______) 
      \   l  /-----~~' /      
       Y   \          / 
       |    'x______.^ 
       |           \    
       j            Y

");
                    Console.ReadLine();
                    break;
                case QuitReason.DontQuit:
                    throw new NotImplementedException("Shouldn't be quitting with DontQuit reason");
            }
        }
    }
}