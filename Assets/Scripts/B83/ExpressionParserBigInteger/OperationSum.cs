using UnityEngine;

namespace B83.ExpressionParserBigInteger
{
    public class OperationSum : IValue
    {
        // Fields
        private B83.ExpressionParserBigInteger.IValue[] m_Values;
        
        // Properties
        public AFramework.BigInteger Value { get; }
        
        // Methods
        public AFramework.BigInteger get_Value()
        {
            var val_4;
            object val_5;
            System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>> val_6;
            object val_7;
            var val_8;
            object val_9;
            System.Func<System.String, System.String, System.String> val_10;
            val_4 = 536900161;
            if(((mem[536900348] & true) == 0) && (mem[536900277] == 0))
            {
                    val_4 = 536900161;
            }
            
            val_5 = mem[536900253];
            val_6 = mem[mem[536900253] + 4];
            val_6 = mem[536900253] + 4;
            if(val_6 == 0)
            {
                    if(((mem[536900348] & true) == 0) && (mem[536900277] == 0))
            {
                    val_5 = mem[536900253];
            }
            
                val_7 = mem[mem[536900253]];
                val_7 = val_5;
                val_6 = 536875451;
                val_6 = new System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>>(object:  val_7, method:  new IntPtr(1610687407));
                mem2[0] = val_6;
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_2 = System.Linq.Enumerable.Select<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Default.WinProductDescription>(source:  this.m_Values, selector:  536875451);
            val_8 = 536900161;
            if(((mem[536900348] & true) == 0) && (mem[536900277] == 0))
            {
                    val_8 = 536900161;
            }
            
            val_9 = mem[536900253];
            val_10 = mem[mem[536900253] + 8];
            val_10 = mem[536900253] + 8;
            if(val_10 != 0)
            {
                    return System.Linq.Enumerable.Aggregate<System.String>(source:  this.m_Values, func:  536875619);
            }
            
            if(((mem[536900348] & true) == 0) && (mem[536900277] == 0))
            {
                    val_9 = mem[536900253];
            }
            
            val_7 = mem[mem[536900253]];
            val_7 = val_9;
            val_10 = 536875619;
            val_10 = new System.Func<System.String, System.String, System.String>(object:  val_7, method:  new IntPtr(1610687409));
            mem2[0] = val_10;
            return System.Linq.Enumerable.Aggregate<System.String>(source:  this.m_Values, func:  536875619);
        }
        public OperationSum(B83.ExpressionParserBigInteger.IValue[] aValues)
        {
            var val_3;
            System.Collections.Generic.IEnumerable<T> val_4;
            val_3 = -1073714389;
            536877973 = new System.Collections.Generic.List<SingleRange>(capacity:  0);
            if(536877973 < 1)
            {
                goto label_2;
            }
            
            var val_4 = 0;
            goto label_11;
            label_9:
            val_4 = mem[R7 + 8];
            val_4 = R7 + 8;
            val_3 = -1073714385;
            536877973.AddRange(collection:  val_4);
            goto label_5;
            label_11:
            if((null == null) || ((mem[null + 180]) < mem[536891557]))
            {
                goto label_8;
            }
            
            var val_3 = mem[null + 100];
            val_3 = val_3 + (mem[536891557] << 2);
            if(((mem[null + 100] + (mem[536891557]) << 2) + -4) == 536891377)
            {
                goto label_9;
            }
            
            label_8:
            val_3 = -1073714387;
            536877973.Add(item:  -1927795952);
            label_5:
            val_4 = val_4 + 1;
            if(val_4 < 536877973)
            {
                goto label_11;
            }
            
            label_2:
            T[] val_2 = 536877973.ToArray();
            mem[1152921510089533240] = 536877973;
        }
    
    }

}
