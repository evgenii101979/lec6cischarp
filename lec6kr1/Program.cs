// задание 1 улучшить код.

// const Double пи = 3.1415;
// int k_BackingField;
// void set_MyProperty(int value)
// {
//     k_BackingField = value;
// }
// int get_MyProperty()
// {
//     return k_BackingField;
// }
// int MyProperty { get; set; }

// const double pi = 3.1415;
// int backingField;
// void SMyProperty(int value)
// {
//     backingField = value;
// }
// int GMyProperty()
// {
//     return backingField;
// }
// int MyProperty { get; set; } // вместо майпропети что то другое

// да и вообще код не работает

// задание 2 что не так в коде

//void DrawText(string text, int left, int top)
// {
//     Console.SetCursorPosition(left, top);
//     System.Console.WriteLine(text);
// }
// DrawText("Intensive C# Demo text", 629, 360);

// надо вот так

// string caption = "Intensive C# Demo text";
// int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
// int screenHightPosition = Console.WindowHeight - caption.Length / 2;
// void DrawText(caption, screenWidthPosition, screenHightPosition);
//   или
//void DrawText(Text: caption, left: screenWidthPosition, top: screenHightPosition);

// задание 3 как лучше?

// string label = "";                   // 111   непонятен
// string address  = String.Empty;      // 222   более правильно

// задание 4 как лучше?
// пример 1
// double a = 1, b = -26, c = 120;
// var d = b * b - 4 * a * c;
// double x1 = (-b + Math.Sqrt(d)) / (2 * a);  // создать метод нужно
// double x2 = (-b - Math.Sqrt(d)) / (2 * a);
// System.Console.WriteLine($"x1={x1}*2={x2}");

// public Roots Solve(double a, double b, double c)
// {
//     var d = b * b - 4 * a * c;
//     double x1 = (-b + Math.Sqrt(d)) / (2 * a);
//     double x2 = (-b - Math.Sqrt(d)) / (2 * a);
//     return new Roots {X1=x1, X2=x2};
// }

// пример 2
// a = 2, b = 1, c = -3;
// d = b * b - 4 * a * c;
// x1 = (-b + Math.Sqrt(d)) / (2 * a);
// x2 = (-b - Math.Sqrt(d)) / (2 * a);
// System.Console.WriteLine($"x1={x1}*2={x2}");

// // пример 3
// a = 1, b = 1, c = -6;
// d = b * b - 4 * a * c;
// x1 = (-b + Math.Sqrt(d)) / (2 * a);
// x2 = (-b - Math.Sqrt(d)) / (2 * a);
// System.Console.WriteLine($"x1={x1}*2={x2}");


// задание 4
// в случайных точках консоли вывести случайные числа
// Random r = new Random();
// Console.CursorVisible = false;
// while (true)
// {
//     Console.SetCursorPosition(left: r.Next(Console.WindowWidth), top: r.Next(Console.WindowHeight));
//     System.Console.Write(r.Next(10));
//     Thread.Sleep(1000);
// }

// задание 5    

using System.Linq;
string text = "(1,2) (2,3) (4,5) (9,7)" // взять текст
                .Replace("(", "")         //заменить ( на пустоту
                .Replace(")", "");        // заменить ) на пусто
System.Console.WriteLine(text);

var data = text.Split(" ")  // возьми текст, разбей пробелом
                .Select(item => item.Split(',')) //сделай выборку таких элементов, для которых разбить с символом разделителя ,
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // сделать выборку из текущего массива, где 1 коорд будет 1 эл. массива с конверт в число и тоже со 2 коорд.
                .Where(e => e.x % 2 == 0) //проверка условия, дать пары у которых 1 коорд. четная
                .Select(point => (point.x * 10, point.y))
                .ToArray(); // превратить в явный массив
for (int i = 0; i < data.Length; i++)
{
    System.Console.WriteLine(data[i]);
    System.Console.WriteLine();
}



