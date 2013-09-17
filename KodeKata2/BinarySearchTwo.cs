using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodeKata
{
    class BinarySearchTwo :BinarySearch
    { 
        //Recursive solution
        public int chop(int searchval, int[] searchdomain)
        {
            if (searchdomain.Length > 0)
            {
                if (searchdomain.Length > 1)
                {
                    int pivot = (searchdomain.Length - 1)/2;

                    if (searchdomain[pivot] == searchval)
                    {
                        return pivot;
                    }
                    else if (searchdomain[pivot] > searchval)
                    {
                        var slice = new int[pivot];
                        Array.Copy(searchdomain, slice, pivot);
                        return chop(searchval, slice);
                    }
                    else
                    {
                        var slice = new int[(searchdomain.Length - 1) - pivot];
                        Array.Copy(searchdomain, pivot + 1, slice, 0, (searchdomain.Length - 1) - pivot);
                        int subsliceval = chop(searchval, slice);
                        if (subsliceval >= 0)
                        {
                            return pivot + subsliceval + 1;
                        }
                        return -1;
                    }
                }
                else
                {
                    if (searchdomain[0] == searchval)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
