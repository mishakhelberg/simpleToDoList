//Instructions
// Timmy & Sarah think they are in love, but around where they live, they will only know once they pick a flower each. If one of the flowers has an even number of petals and the other has an odd number of petals it means they are in love.

// Write a function that will take the number of petals of each flower and return true if they are in love and false if they aren't.

using System;

public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    {
        if (flower1 % 2 == 0
            && flower2 % 2 == 1)
        {
            return true;
        }
        else if (flower1 % 2 == 1
            && flower2 % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }

        //Cleaner way of doing it
        return flower1 % 2 != flower2 % 2 ? true : false;
    }
}
