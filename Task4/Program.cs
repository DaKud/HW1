
Console.WriteLine("Insert number: ");
 int N = int.Parse(Console.ReadLine());
 int d = 1;

 while (d <= N)
 {
     if (d % 2 == 0)
     {
         Console.WriteLine($" {d} "); // печать числа
         d++;
     }

     else
     {
         d++;
     }
 }