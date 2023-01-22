// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Вне кода приводим формулы в вид, пригодный для решения.
// Что куда вставлять, значения не имеет, т.к. само сбалансируется, поэтому можно использовать один из вариантов наxождения x:

// k1 * x + b1 = k2 * x + b2
//k1*x - k2*x = b2 - b1
//(k1-k2) * x = b2 - b1
// x = (b2 - b1) / (k1-k2)


// k2 * x + b2 = k1 * x + b1
// k2 * x - k1 *x = b1 - b2
//(k2 - k1) * x = b1 - b2
// x = (b1 - b2) / (k2 - k1)

// После этого нам останется только внести полученное в любую из формул y

Console.Clear();

Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Clear();

double x = (b2 - b1) / (k1-k2);

double y = k1 * x + b1;

Console.Write($"b1 = {b1}, k1 = {k2}, b2 = {b2}, k2 = {k2} -> ({Math.Round(x, 1)}; {Math.Round(y, 1)})");