// See https://aka.ms/new-console-template for more information

using PipeGame;

Console.WriteLine("Hello, World!");
Console.OutputEncoding = System.Text.Encoding.UTF8;
var board = new Brett();
while (true)
{
    Console.WriteLine("skriv index");
    var input = Console.ReadLine();
    Console.WriteLine("skriv rettning");
    var input1 = Console.ReadLine();
    board.brukerInput(input, input1);





}