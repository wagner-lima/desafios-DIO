int number = int.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{
    var esferas = int.Parse(Console.ReadLine());

    Console.WriteLine(esferas - Math.Floor(Math.Sqrt(esferas)));
}