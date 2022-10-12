using System;
using System.Reflection.PortableExecutable;

Random rnd = new Random();

void ClearCurrentConsoleLine()
{
    int currentLineCursor = Console.CursorTop;
    Console.SetCursorPosition(0, Console.CursorTop);
    Console.Write(new string(' ', Console.WindowWidth));
    Console.SetCursorPosition(0, currentLineCursor);
}

Console.WriteLine("Hello alien \nWhat is your galaxy name?");
string Name = Console.ReadLine();
Thread.Sleep(1000);
Console.WriteLine($"hahahahahaaa, welcome {Name}, its great to meet you man!");
Thread.Sleep(2000);
Console.WriteLine("Do you want to know what humanbeings have done to this earth?");
Thread.Sleep(2000);
Console.WriteLine("I dont think you can write english, You can Use Arrows To move arround");
Thread.Sleep(2000);
Console.WriteLine("Press upwards arrow ↑ For Yes \nPress Downwards ↓ arrow for no");
string upar = "Press UpArrow ↑";
string downar = "Press Downarrow ↓";
string rightar = "Press Rightarrow →";
string leftar = "Press Leftarrow ←";
if (Console.ReadKey().Key == ConsoleKey.UpArrow)
{
    Console.WriteLine("im glad you wanna listen!");
    Thread.Sleep(500);
    Console.WriteLine("Im just wondering what generation you wanna hear about?\n1.Gen " + upar + " \n2.Gen " + downar + " \n3.Gen "
    + rightar + "\n4.Gen " + leftar);
}
else
{
    Console.Clear();
    Console.WriteLine("bye bye");
    Thread.Sleep(5000);
}




void Move(ConsoleKey direction)
{
    switch (direction)
    {
        case ConsoleKey.UpArrow:
        case ConsoleKey.W:
            Console.WriteLine("Well," + Name + " Welcome to Generation 1");
            Thread.Sleep(500);
            Console.WriteLine("Ur father, fathers, fathers's, fathers'ss was a good man for what he did :) \ni wish that you agree \nYes"
             + upar + "\nNo" + downar);
            if (Console.ReadKey().Key == ConsoleKey.UpArrow)
            {
                Console.WriteLine("Im so glad to hear that buddy");
                Thread.Sleep(1000);
                Console.WriteLine("Give me a minute im crying ;( ");
                string apologizemsg = "ok im sorry for the waiting, Dont go away ";
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.WriteLine(apologizemsg);
                    Thread.Sleep(1300);
                    Console.WriteLine("The Rest of the story");
                    Console.ReadKey();
                }
            }

            break;
        case ConsoleKey.DownArrow:
        case ConsoleKey.S:
            Console.Clear();
            Console.WriteLine("Well " + Name + " Welcome to Gen 2, This is an exciting generation, \nbecause here The  \"Mortal Combat\" Was invented, So get ready to try it out");
            string[] Herosname = new string[] { "Sokolala", "Bomshakalaka", "Tsikolima", "kosko", "morow", "shikololo", "sexy lady" };
            int indx = rnd.Next(Herosname.Length);
            Thread.Sleep(7000);
            Console.WriteLine("Hangon we are finding a hero that fits for you");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine($"Your Hero Name: {Herosname[indx]}" + " one of the best Heros");
            Console.WriteLine("Lets find out who is your enemy");
            Thread.Sleep(7000);
            int tell = 0;
            int speed = 10;
            for (int i = 0; speed < 350; i++)
            {
                tell++;
                if (tell == Herosname.Length)
                {
                    tell = 0;
                }
                int add = 10;
                speed = speed + add;
                Thread.Sleep(speed);
                Console.Clear();
                Console.Write(Herosname[tell]);

            }
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.Write("Its ");
                Thread.Sleep(500);
                Console.Clear();
                Console.Write(Herosname[tell]);
                Thread.Sleep(700);

            }
            string Ally = Herosname[indx];
            string enemy = Herosname[tell];
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("its going to be " + Ally + " Versus " + enemy);
            Thread.Sleep(500);
            Console.WriteLine("Good luck :)");
            Thread.Sleep(6000);
            break;
        case ConsoleKey.RightArrow:
        case ConsoleKey.D:
            Console.Clear();
            Console.WriteLine("Here is the math/algebra game, which was invented by Muhammad al-Khwarizmi, i hope you are good at algebra");
            Console.WriteLine("You can choose \naddition? " + upar + " \nsubtraction? " + downar + " \nmultiplication "
    + rightar + "\ndivision " + leftar);
            var mathchoose = Console.ReadKey().Key;
            int Firstnumber = 0;
            int secondnumber = 0;
            int sum = 0;
            if (mathchoose == ConsoleKey.UpArrow)
            {
                Console.WriteLine("Im glad you want to try addition, write your first number");
                Firstnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Now your second number");
                secondnumber = Convert.ToInt32(Console.ReadLine());
                sum = Firstnumber + secondnumber;
                Console.WriteLine($"Your Sum is {Firstnumber} + {secondnumber} = {sum} ");
                int tim = 10;
                for (int i = 0; i < 10; i++)
                {
                    tim--;

                    Console.Write($"                                                                                 Timer {tim} ");
                    Console.WriteLine("countinuing");
                    Thread.Sleep(500);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();

                }
            }
            else if (mathchoose == ConsoleKey.DownArrow)
            {
                Console.WriteLine("Im glad you want to try subtraction, write your first number");
                Firstnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Now your second number");
                secondnumber = Convert.ToInt32(Console.ReadLine());
                sum = Firstnumber - secondnumber;
                Console.WriteLine($"Your Sum is {Firstnumber} - {secondnumber} = {sum} ");
                int tim = 10;
                for (int i = 0; i < 10; i++)
                {
                    tim--;
                    Console.Write($"                                                                                 Timer {tim} ");
                    Console.WriteLine("countinuing");
                    Thread.Sleep(500);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();

                }

            }
            else if (mathchoose == ConsoleKey.RightArrow)
            {
                Console.WriteLine("Im glad you want to try multiplication, write your first number");
                Firstnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Now your second number");
                secondnumber = Convert.ToInt32(Console.ReadLine());
                sum = Firstnumber * secondnumber;
                Console.WriteLine($"Your Sum is {Firstnumber} * {secondnumber} = {sum} ");
                int tim = 10;
                for (int i = 0; i < 10; i++)
                {
                    tim--;
                    Console.Write($"                                                                                 Timer {tim} ");
                    Console.WriteLine("countinuing");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();

                }
            }
            if (mathchoose == ConsoleKey.LeftArrow)
            {
                Console.WriteLine("Im glad you want to try division, write your first number");
                void divi()
                {
                    Firstnumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Now your second number: ");
                    secondnumber = Convert.ToInt32(Console.ReadLine());
                    while (secondnumber == 0)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Clear();
                            Console.WriteLine("YOU CANT DIVIDE BY 0 !!!!!!!!");
                            Thread.Sleep(300);
                        }
                        Console.WriteLine("TRY AGAIN");
                        secondnumber = Convert.ToInt32(Console.ReadLine());
                    }
                    sum = Firstnumber / secondnumber;
                    Console.WriteLine($"Your Sum is {Firstnumber} / {secondnumber} = {sum} ");
                    int tim = 10;
                    for (int i = 0; i < 10; i++)
                    {
                        tim--;


                        Console.Write($"                                                                                 Timer {tim} ");
                        Console.WriteLine("countinuing");
                        Thread.Sleep(500);
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        ClearCurrentConsoleLine();

                    }
                }
                divi();

            }
            break;
        case ConsoleKey.LeftArrow:
        case ConsoleKey.A:
            
            int time=10;
            for (int i = 0; i < 10; i++)
                    {
                        time--;


                        Console.Write($" Generatino 4 is comming soon after 999 light years                                 Timer {time} ");
                        Console.WriteLine("going on");
                        Thread.Sleep(500);
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        ClearCurrentConsoleLine();

                    }
            break;
        case ConsoleKey.Escape:
            Console.Clear();
            Console.WriteLine("it was great to meet you in earth anyway");
            Console.WriteLine("Bye bye :)");
            Thread.Sleep(3000);
            break;
        default:
            Console.WriteLine("Something is wrong, we are in default case we should be in somewhere else");
            Console.ReadKey();
            break;
    }
}

var _key = Console.ReadKey().Key;
Move(_key);
Console.Clear();
Console.WriteLine("Wanna play again ? \n Yes " + upar + "\n No " + downar);
var userchose = Console.ReadKey().Key;
while (userchose == ConsoleKey.UpArrow)
{
    Console.WriteLine($"im glad you wanna play again {Name}");
    Thread.Sleep(500);
    Console.WriteLine("Im just wondering what generation you wanna hear about this time ?\n1.Gen " + upar + " \n2.Gen " + downar + " \n3.Gen "
    + rightar + "\n4.Gen " + leftar);
    _key = Console.ReadKey().Key;
    Move(_key);
    Console.WriteLine("Wanna play again ? \n Yes " + upar + "\n No " + downar);
    userchose = Console.ReadKey().Key;
}
if (userchose == ConsoleKey.DownArrow)
{
    Console.WriteLine("I hope you had some fun :) ");

}


