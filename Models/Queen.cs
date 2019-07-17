using System;

namespace QueenAttack.Models
{
  class Queen
  {
    public static bool determineAttack(int xQueen, int yQueen, int xOther, int yOther)
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
}
