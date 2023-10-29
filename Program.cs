//Stefeson

Console.Clear();

double x, y;
string local;

Console.WriteLine("--- Quadrante Cartesiano ---");

Console.WriteLine("Entre com o ponto desejado.");

Console.Write("Cordenada x: ");
x = Convert.ToDouble(Console.ReadLine());

Console.Write("Cordenada y: ");
y = Convert.ToDouble(Console.ReadLine());

if (x == 0 && y ==0 ) local = "a origem";
else if (x == 0) local = "o eixo das ordenadas";
else if (y == 0) local = "o eixo das abcissas";
else if (y > 0)
{
    if (x > 0)
        local = "o quadrante 1";
    else    
        local = "o quadrante 2";
    
}
else 
{
    if (x < 0)
        local = "o quadrante 3";
    else
        local = "o quadrante 4";
}

Console.WriteLine($"O ponto ({x},{y}) fica n{local}");