/*
Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
S = 1 + 1/2 + 1/3 + … + 1/100
Entrada
Não há nenhuma entrada neste problema.
Saída
A saída contém um valor correspondente ao valor de S.
O valor deve ser impresso com dois dígitos após o ponto decimal.
*/


double S = 0;
double temp = 0;

for (double i = 1;i <= 100;i++)
{
    temp = 1/i;
    S += temp;
}

S = Math.Round(S, 2);

Console.WriteLine(S);