using System;

namespace KodeKata
{
    public class BinarySearchThree : BinarySearch
    {
        //Solution using the built-in BinarySearch method for an array
        public int chop(int searchval, int[] searchdomain)
        {
            var pos = Array.BinarySearch(searchdomain, searchval);
            if (pos < 0)
            {
                pos = -1;
            }
            return pos;
        }
    }
}