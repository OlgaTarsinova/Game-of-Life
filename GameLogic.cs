using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_Life
{
    public class GameLogic
    {
        public const char cellIcon = 'o';
        public const int maxX = 6;
        public const int maxY = 4;
        public static int[,] field = new int[maxX, maxY];
        public void DrawField()
        {

            Console.CursorLeft = 0;
            Console.CursorTop = 0;

            for (int y = 0; y < maxY; y++)
            {
                for (int x = 0; x < maxX; x++)
                {
                    Console.Write(field[x, y] == 1 ? cellIcon : ' ');
                }
                Console.WriteLine();
            }
        }
        public void InitializeField()
        {
            // Initialize
            ///  Console.SetWindowSize(maxX + 10, maxY + 10);
            ///   Console.SetWindowPosition(0, 0);
            // Random initial positions
            Random r = new Random((int)DateTime.Now.Ticks);
            for (int x = 0; x < maxX; x++)
            {
                for (int y = 0; y < maxY; y++)
                {
                    field[x, y] = r.Next(0, 1 + 1);
                    // r.Next возвращает случайное значение
                    // мы смотрим на координату и меняем её значение в поле
                }
                
            }
            
            // Instantiate the desired concrete RuleSet in this Strategy pattern.
            RuleSet ruleSet = new ConwaysGameOfLife(field, maxX, maxY);
           /// for (int i = 0; i < 5000; i++)
           
                DrawField();
                ///ruleSet.Tick();

                // надо знать что делает ruleSet.Tick(); !!!!!!!!! или удалить и написать заново
                //..!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                // надо прочитать как работает алгоритм игра жизни! 
                // !!!!!! 

                // задать скорость тиканью , чтобы после каждого нажатия энтер менялась позиция 
                // как сделать паузу в приложении??????????? несколько ресурсов !!!

                // чтобы задать одну конкрентную фигуру, нужно убрать рендом и прописать код своей фигуры
            
        } /// ты создаешь обьект класса ConwaysGameOfLife и вызываешь функцию Tick
          /// Что бы было ясно, надо открыть функцию тик
          /// функция тик вызывает функцию тикалгоритм
          ///в функции тикалгоритм описывается выживает ли клетка или умирает, или воскрешает
          /// ConwaysGameOfLife.TickAlgorithm и возвращает новое поле
          /// ruleSet.Tick(); вызывает функцию TickAlgorithm()
          /// в которой считается что будет с клеткой будет жить, умрет или воскреснет
          /// это зависит от количества соседей
          ///соседи считаются в ыункции GetNumberOfNeighbors
          ///В задании iteration 3 пункт 4 некорректно поставлена задача, непонятно что там надо
          ///

    }
}

    
   

