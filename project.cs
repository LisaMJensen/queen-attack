using System;
using System.Collections.Generic;

class QueenAttack
{
  public static int xCoordInputQueen;
  public static int yCoordInputQueen;
  public static int xCoordInputOtherPiece;
  public static int yCoordInputOtherPiece;

  static void Main()
  {
    Dictionary<string, int> xCoordinates = new Dictionary<string, int>() { {"A",1}, {"B",2}, {"C",3}, {"D",4}, {"E", 5}, {"F",6}, {"G",7}, {"H",8} };

    Console.WriteLine("Enter the horizontal coordinate for the Queen (A-H): ");
    string input = Console.ReadLine(); // input = "B"
    xCoordInputQueen = xCoordinates[input];  // xCoordInputQueen = 2

    Console.WriteLine("Enter the vertical coordinate for the Queen (1-8): ");
    yCoordInputQueen = int.Parse(Console.ReadLine()); // yCoordInputQueen = 7

    Console.WriteLine("Enter the horizontal coordinate for another piece (A-H): ");
    input = Console.ReadLine();
    xCoordInputOtherPiece = xCoordinates[input];

    Console.WriteLine("Enter the vertical coordinate for this piece (1-8): ");
    yCoordInputOtherPiece = int.Parse(Console.ReadLine());

    determineAttack();

    if (determineAttack() == true)
    {
      Console.WriteLine("The queen attacked!");
    }
    else
    {
      Console.WriteLine("The queen cannot attack.");
    }
  }

  static bool determineAttack()
  {
    // Queen can attack pieces in the same row or column
    if (xCoordInputQueen == xCoordInputOtherPiece || yCoordInputQueen == yCoordInputOtherPiece)
    {
      return true;
    }
    // Queen can attack pieces that are diagonal from it
    else if (Math.Abs(xCoordInputQueen - xCoordInputOtherPiece) == Math.Abs(yCoordInputQueen - yCoordInputOtherPiece))
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}
