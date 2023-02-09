// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Informe o primeiro lado do Triangulo:");
double lado1 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira o segundo lado do Triangulo:");
double lado2 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira o terceiro lado do Triangulo:");
double lado3 = double.Parse(Console.ReadLine());

if ((lado1 + lado2) > lado3 && (lado2 + lado3)> lado1 && (lado1 + lado3) > lado2){
    Console.WriteLine("Os valores correspondem a um Triangulo.");
    if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3){
Console.WriteLine("Este é um triangulo Equilátero: com os 3 lados iguais");
    }
    else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3){
    Console.WriteLine("Este é um triangulo Isósceles: com dois lados iguais");
    }
    else 
    Console.WriteLine("Este é um triangulo Escaleno: com 3 lados diferentes");
    }

else { 
    Console.WriteLine("Os valores não correspondem a um Triangulo.");
};




