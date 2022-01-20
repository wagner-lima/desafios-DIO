double S = 0;
double temp = 0;

for (double i = 1;i <= 100;i++)
{
    temp = 1/i;
    S += temp;
}

S = Math.Round(S, 2);

Console.WriteLine(S);