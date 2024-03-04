//----IF Ternário----
int numero = 0;
bool ehPar = false;

Console.WriteLine ("Digite um Número:");
numero = Convert.ToInt32(Console.ReadLine());

ehPar = numero % 2 == 0;

Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));
