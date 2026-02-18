// See https://aka.ms/new-console-template for more information

polindromos.isPolindromos polidromo = new polindromos.isPolindromos();

int a = 0;
bool validation = false;
try
{
    a = (int)Convert.ToDouble(Console.ReadLine());

    validation = polidromo.checker(a);

    if (validation == false)
    {
        Console.WriteLine("No es Polindromos");
    }
    else
    {
        Console.WriteLine("Es Polindromos");
    }
}catch
{
    Console.WriteLine("No es numerico"); 
}



