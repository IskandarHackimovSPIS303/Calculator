using Subjects;
Subjects.Math classmath = new Subjects.Math();

Console.WriteLine("First number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Mult:");
Console.WriteLine(classmath.mult(num1, num2));
Console.WriteLine("Sum:");
Console.WriteLine(classmath.sum(num1, num2));
Console.WriteLine("Division:");
Console.WriteLine(classmath.division(num1, num2));
Console.WriteLine("Subtraction:");
Console.WriteLine(classmath.subtraction(num1, num2));


