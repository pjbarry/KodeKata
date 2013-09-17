using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KodeKata
{
    class BinarySearchOne
    {

        public int chop(int searchval, int[] searchdomain)
        {
            int pivot = (searchdomain.Length-1)/2;
            int currentMin = 0;
            int currentMax = searchdomain.Length-1;
            while ( ( currentMin != currentMax) &&( pivot != currentMax) && ( pivot != currentMin) && (searchdomain[pivot] != searchval))
            {
                if (searchdomain[pivot] > searchval)
                {
                    currentMax = pivot;
                    pivot -= (pivot+1)/2;
                }
                else
                {
                    currentMin = pivot;
                    pivot += (searchdomain.Length - pivot)/2;
                }
            }
            if (searchdomain.Length> 0)
            {
                if (searchdomain[currentMin] == searchval)
                    return currentMin;
                if (searchdomain[currentMax] == searchval)
                    return currentMax;
                if (searchdomain[pivot] == searchval)
                    return pivot;
            }
            return -1;
        }

        
    }
    
}
