using UnityEngine;

namespace Ferr
{
    public class LambdaComparer<T> : IComparer<T>
    {
        // Fields
        private readonly System.Func<T, T, int> func;
        
        // Methods
        public LambdaComparer<T>(System.Func<T, T, int> comparerFunc)
        {
            mem[1152921510127683128] = comparerFunc;
        }
        public int Compare(T x, T y)
        {
            if(R6 == 0)
            {
                
            }
        
        }
    
    }

}
