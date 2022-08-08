// See https://aka.ms/new-console-template for more information
int a = 8;
try
{

    Console.WriteLine( a / 0 ); 
    
}
catch (Exception n)
{
    Console.WriteLine($"exception-{n}");
}
