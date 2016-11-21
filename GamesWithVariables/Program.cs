using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GamesWithVariables
{
    class Program
    {
        static void Main(string[] args) // это точка входа. точка входа есть всегда!
        {

            // Если не выводится русский - зайти в Консоль - Свойства и выбрать шрифт Consolas
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            ////////////////////////////////////////
            /// BLOCK 1. Переменные.
            ////////////////////////////////////////

            // объявим пару переменных... 
            int variableOne; // это декларация первой  
            int variableTwo; // это второй

            // и теперь присвоим им значения!
            variableOne = 5; // это называется инициализация :)
            variableTwo = variableOne + 10; // можно использовать для инициализации как прямое указание, так и операции с переменными

            // можно присваивать переменной значение самой себя или другой переменной...
            variableOne = variableTwo;
            variableTwo = variableOne * 5;

            // чтобы вывести их на экран используется метод WriteLine
            Console.WriteLine("Все команды вывода всегда выводят ТЕКСТ!"); // методы легко узнать - у них есть () в конце
            Console.WriteLine("Если переменная другого типа, она будет приведена в текст."); // в скобках они принимают аргументы (их еще называют параметры)
            Console.WriteLine("Переменная variableOne имеет тип int, но выводится здесь как текст: " + variableOne );
            Console.WriteLine("\n"); // означает "новая строка"

            // для работы со строками используется тип string
            string userInput;
            // его часто используют для обмена информацией между пользователем и программой:
            userInput = Console.ReadLine();
            Console.WriteLine("Ты только что ввел: " + userInput);
            Console.WriteLine("\n");

            //TODO: Спроси у пользователя его имя и после скажи ему "Молодчина, [имя]!"
            // объяви переменную для хранения его имени
            // используй ReadLine чтоб получить имя
            // выведи на экран "Молодчина, " и используй + чтоб собрать строку. Не забудь восклицательный знак в конце :)


            ////////////////////////////////////////
            /// BLOCK2: Ветвления и принятие решений
            /// ////////////////////////////////////
/*            // что делать, если требуется принять решение?
            if (variableOne < variableTwo) // читается так: "если то что написано в круглых скобках правда...
            {
                // то тогда будет выполнено то что написано в фигурных скобках!
                Console.WriteLine("Удивительно, но переменная variableOne < variableTwo: " + variableOne + "<" + variableTwo);
            }
            Console.WriteLine("\n");

            // есть тонкость при проверке равенства.
            // сначала сделаем двойную инициализацию - пусть обе переменных будут равны друг другу и единице
            variableTwo = variableOne = 1;

            if (variableOne == variableTwo) // при сравнении используется не одно =, а == 
            {
                // то тогда будет выполнено то что написано в фигурных скобках!
                Console.WriteLine("Удивительно,  variableOne == variableTwo: " + variableOne + "==" + variableTwo);
                Console.WriteLine("\n");
            }

            // есть еще конструкция "если () то {} a иначе {}
            variableTwo = 1;
            variableTwo = 2;

            if (variableOne == variableTwo) // при сравнении используется не одно =, а == 
            {
                // то тогда будет выполнено то что написано в фигурных скобках!
                Console.WriteLine("Удивительно,  variableOne == variableTwo: " + variableOne + "==" + variableTwo);
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Удивительно,  variableOne != variableTwo: " + variableOne + "!=" + variableTwo);
                Console.WriteLine("\n");
            }

            // и если нужен очень очень умный if, который обрабатывает много случаев:

            string anotherInput;
            Console.WriteLine("Введите число 1, 2 или другое: ");
            anotherInput = Console.ReadLine();

            switch (anotherInput) // какая переменная будет проверяться на разные значения
            {
                case "1": // if (anotherInput == 1) ...
                    Console.WriteLine("Это был один!");
                    break;

                case "2":
                    Console.WriteLine("Это был два!");
                    break;

                default: // если ни один из предыдущих случаев не сработал :)
                    Console.WriteLine("Это был не один и не два!");
                    break;
            }


            Console.ReadKey();
*/ 
            ////////////////////////////////////////
           /// BLOCK 3. Циклы
           /// ////////////////////////////////////
/*            
            // если надо что-то сделать много раз, то используется цикл
            decimal myMoney = 10M;
            decimal schoolPayment = 1M;

            while (myMoney > 0)
            {
                Console.WriteLine("У меня сейчас " + myMoney + "!");
                myMoney = myMoney - schoolPayment;
                Console.WriteLine("Заплатил за школу, осталось " + myMoney + "!");
            }

            // Можно использовать ++ и -- чтоб уменьшить значение переменной:
            myMoney = 10M;
            Console.WriteLine("У меня сейчас " + myMoney + "!");
            myMoney--;
            Console.WriteLine("У меня сейчас " + myMoney + "!");
            Console.WriteLine("\n");

            // TODO: Со следующей строки напиши цикл, который будет делать то же самое, но используя --


            Console.WriteLine("\n");

            // Когда точно известно, сколько раз надо выполнить цикл, можно использовать такую форму:
            for (int numberOfTimes = 0; numberOfTimes < 10; numberOfTimes ++ ) // читается так: начиная с 0, пока количество проходов < 10, на каждом проходе прибавляя к количеству проходов единицу
            {
                Console.WriteLine("Делаю " + numberOfTimes + "раз!");
            }

            // TODO: Сделай новый цикл, и чтоб цифры выводились в обратном порядке - от 9 до 0 :)


            Console.WriteLine("\n");
            // еще один тип переменной - boolean, который принимает значение "правда" или "ложь"

            bool isReach = true;

            while (isReach == true)
            {
                myMoney++;
                Console.WriteLine("У меня сейчас " + myMoney + "!");
            }

            // TODO: Сделай так, чтоб myMoney вначале были 100, и уменьшались по 1 до тех пор, пока их не станет 0. 
            // А когда станет 0 - установи значение isReach в false и напиши "поздравляем, Вы банкрот!"

            while (isReach)
            {
                myMoney++;
                Console.WriteLine("У меня сейчас " + myMoney + "!");
                if (myMoney > 99)
                {
                    isReach = false;
                }
            }

            // Команда Console.ReadKey() заставляет программу ждать нажатия любой клавиши:
            Console.ReadKey(); // программисты часто используют ее чтоб результат вывода не исчезал мгновенно с экрана :)
*/

        }
    }
}
