using System.Diagnostics;

namespace ConsoleApp8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            START();
        }


        static void START()
        {
            Thread th = new Thread(x =>
            {
                int time = 1;
                while (time != 61)
                {
                    Console.SetCursorPosition(0, 15);
                    Console.WriteLine("  ");
                    Console.WriteLine(time);
                    Thread.Sleep(1000);
                    time++;
                }
            });

            Thread th2 = new Thread(x =>
            {
                Stopwatch stopW = new Stopwatch();
                stopW.Start();
                Thread.Sleep(60000);
                stopW.Stop();
            });

            Console.WriteLine("Введите ваше имя");

            Inform user = new Inform();

            user.Name = Console.ReadLine();

            string nam = user.Name;

            Console.Clear();

            Console.WriteLine("Когда будете готовы, нажмите Enter и начните печатать текст на 2 строке");

            ConsoleKeyInfo clavisha = Console.ReadKey();


            if (clavisha.Key == ConsoleKey.Enter)
            {

                th.Start();
                th2.Start();
                Console.SetCursorPosition(0, 1);
                string text = ("Конечно же, эта невозможность происходит не от того, что философы не обладают достаточными талантами и навыками, " +
                    "а от того, что в неразрешимости и состоит специфика философских вопросов и проблем. " +
                    "Если на какой-то вопрос в принципе нельзя найти ответ, он признается философским.");
                Console.WriteLine(text);

                int i = 0;


                while (th2.IsAlive)
                {
                    char a = Console.ReadKey(true).KeyChar;
                    if (a == text[i])
                    {
                        Console.SetCursorPosition(i, 1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(a);
                        Console.ResetColor();
                        i++;
                    }
                }


                user.minute = i;
                user.sec = i / 60;
                Console.SetCursorPosition(0, 13);
                Console.WriteLine($"Было введено символов - {i}, введено символов в минуту - {user.minute}, введено символов в секунду - {user.sec}");
                Console.ReadKey();

                Tablitsa menun = new Tablitsa();
                menun.Sohr(user);
                Console.ReadKey();
                Console.Clear();
                START();
            }


            else
            {
                Console.Clear();
                Console.WriteLine("Программа завершена");
            }
        }
    }
}