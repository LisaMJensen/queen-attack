using System;
using System.Collections.Generic;

class QueenAttack
{
  static void Main()
  {
    Dictionary<string, int> xCoordinates = new Dictionary<string, int>() { {"A",1}, {"B",2}, {"C",3}, {"D",4}, {"E", 5}, {"F",6}, {"G",7}, {"H",8} };

    Console.WriteLine("Enter the horizontal coordinate for the Queen (A-H): ");
    string input = Console.ReadLine(); // input = "B"
    int xCoordInputQueen = xCoordinates[input];  // xCoordInputQueen = 2

    Console.WriteLine("Enter the vertical coordinate for the Queen (1-8): ");
    int yCoordInputQueen = int.Parse(Console.ReadLine()); // yCoordInputQueen = 7

    Console.WriteLine("Enter the horizontal coordinate for another piece (A-H): ");
    input = Console.ReadLine();
    int xCoordInputOtherPiece = xCoordinates[input];

    Console.WriteLine("Enter the vertical coordinate for this piece (1-8): ");
    int yCoordInputOtherPiece = int.Parse(Console.ReadLine());

    bool result = determineAttack(xCoordInputQueen, yCoordInputQueen, xCoordInputOtherPiece, yCoordInputOtherPiece);

    if (result == true)
    {
      Console.WriteLine("The queen attacked!");
    }
    else
    {
      Console.WriteLine("The queen cannot attack.");
    }
  }

  static bool determineAttack(int xQueen, int yQueen, int xOther, int yOther)
  {
    // Queen can attack pieces in the same row or column
    if (xQueen == xOther || yQueen == yOther)
    {
      return true;
    }
    // Queen can attack pieces that are diagonal from it
    else if (Math.Abs(xQueen - xOther) == Math.Abs(yQueen - yOther))
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}
