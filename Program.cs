using CalculadoraSimples.Models;

Calculadora c = new Calculadora();

c.Somar(2,7);
c.Subtrair(3,9);
c.Multiplicar(10,2);
c.Dividir(10,2);
c.Potencia(3,9);

c.Conseno(30);
c.Seno(30);
c.Tangente(30);

c.RaziQuadrada(9);

// Incremento e decremento
int numero = 10;

Console.WriteLine("Incrementando o 10");
numero++;

Console.WriteLine(numero);

int decremento = 20;

Console.WriteLine("Decrementando 20");

decremento--;

Console.WriteLine(decremento);