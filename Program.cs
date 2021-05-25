using System;

Main();

void Main()
{
    Console.Clear();
    Init(0, 0);
    int PlayerScore = 0;
    int ComputerScore = 0;
    Turn();
}

void Init(int Player, int Comp)
{
    Console.WriteLine($@"
    ---------------------------------
    |  Player: {Player}   |   Computer: {Comp}  |
    ---------------------------------
    What would you like to throw?
    1) Rock
    2) Paper
    3) Scissors
    ");
    Console.WriteLine();
}

void Turn()
{
    int UserSelection = Throw();
    // Console.WriteLine($"You picked {UserSelection}");

    Random i = new Random();
    int ComputerSelection = i.Next(0, 3);

    RPS(UserSelection);
    Console.WriteLine("   [ VS ]");
    RPS(ComputerSelection);
}

int Throw()
{
    string UserInput = Console.ReadLine();
    if (int.TryParse(UserInput, out int Selection))
    {
        if (Selection <= 3 && Selection > 0)
        {
            return Selection;
        }
        else
        {
            Console.WriteLine("Please Select 1 2 or 3");
        }
    }
    else
    {
        Console.WriteLine("Please Select 1 2 or 3");
        UserInput = Console.ReadLine();
    }
    return Selection;
}


void RPS(int Choice)
{
    if (Choice == 1)
    {
        Console.WriteLine(@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)

        ");
    }
    else if (Choice == 2)
    {
        Console.WriteLine(@"
    ________
---'    ____)____
           ______)
          _______)
         _______)
---.__________)

        ");
    }
    else
    {
        Console.WriteLine(@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)

        ");
    }
}