using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_Life
{
    public class MainMenu
    {
        public void MenuOutput()
        {
            Console.WriteLine("Welcome to the Game of Life");
            Console.WriteLine("Enter 1 to start Game of Life");
            Console.WriteLine("Enter 2 to exit Game of Life");
  
            var userinput = Console.ReadLine();
            Console.Clear();

            switch (userinput)
            {
                case "1":
                    {
                        Console.WriteLine("Let's play!");
                        Console.Clear();

                        GameLogic game = new GameLogic();
                        game.InitializeField();

                        var userinput2 = Console.ReadLine();
                     switch (userinput2)
                        {
                       // case "play":
                               // {
                                 //   .Tick();
                                  //  game.DrawField();
                                
                              //  }
                                break;

                  
                    }
            }
                        //Вызвать надо отсюда
                        break;
                case "2":
                    System.Environment.Exit(2);
                    break;

                default:
                    Console.WriteLine("Try again");

                    break;
            }
            //switch case - будет проверять, что пользователь нажал
            // case 1, case 2, case3 
            // defolt - стандарт, если нажал то, что ты хочешь , а это неправильно, и нужно сделать return в loop 
            //выйдет только при одном условии case1

            // вынести из метода InitializeField(); скопировать код , который рисует поле и код, который меняет позицию 
            //

            /// задачи : 
            /// 0*. нужно чтобы я понимала, что у меня написано в кодовой базе ВСЕ ПУНКТЫ!
            /// 1. Репозиторий на гитхабе с гейм оф лайф новый 
            /// 2. новый проэкт с тем кодом, который я могу объяснить !!!!!!!!!!!!!!!!!!!!!
            /// 
          


        }
    }
}
