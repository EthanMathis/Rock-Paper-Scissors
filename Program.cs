using System;

Main();

void Main()
{
    Console.WriteLine(@"
    ---------------------------------
    |  Player: 0   |   Computer: 0  |
    ---------------------------------
    What would you like to throw?
    1) Rock
    2) Paper
    3) Scissors
    ");
    Console.WriteLine();


}

void Throw()
{
    string UserInput = Console.ReadLine().ToLower();
}