using UnityEngine;

namespace B83.ExpressionParser
{
    public class OperationSum : IValue
    {
        // Fields
        private B83.ExpressionParser.IValue[] m_Values;
        
        // Properties
        public double Value { get; }
        
        // Methods
        public double get_Value()
        {
            var val_3;
            object val_4;
            System.Func<System.Object, System.Double> val_5;
            val_3 = 536900157;
            if(((mem[536900344] & true) == 0) && (mem[536900273] == 0))
            {
                    val_3 = 536900157;
            }
            
            val_4 = mem[536900249];
            val_5 = mem[mem[536900249] + 4];
            val_5 = mem[536900249] + 4;
            if(val_5 == 0)
            {
                    if(((mem[536900344] & true) == 0) && (mem[536900273] == 0))
            {
                    val_4 = mem[536900249];
            }
            
                val_5 = 536875443;
                val_5 = new System.Func<System.Object, System.Double>(object:  val_4, method:  new IntPtr(1610687573));
                mem2[0] = val_5;
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_2 = System.Linq.Enumerable.Select<System.Object, System.Double>(source:  this.m_Values, selector:  536875443);
            return System.Linq.Enumerable.Sum(source:  this.m_Values);
        }
        public OperationSum(B83.ExpressionParser.IValue[] aValues)
        {
            System.Collections.Generic.IEnumerable<T> val_3;
            536877971 = new System.Collections.Generic.List<SingleRange>(capacity:  0);
            if(536877971 < 1)
            {
                goto label_2;
            }
            
            var val_4 = 0;
            goto label_11;
            label_9:
            val_3 = mem[R7 + 8];
            val_3 = R7 + 8;
            536877971.AddRange(collection:  val_3);
            goto label_5;
            label_11:
            if((null == null) || ((mem[null + 180]) < mem[536891555]))
            {
                goto label_8;
            }
            
            var val_3 = mem[null + 100];
            val_3 = val_3 + (mem[536891555] << 2);
            if(((mem[null + 100] + (mem[536891555]) << 2) + -4) == 536891375)
            {
                goto label_9;
            }
            
            label_8:
            536877971.Add(item:  -1923046848);
            label_5:
            val_4 = val_4 + 1;
            if(val_4 < 536877971)
            {
                goto label_11;
            }
            
            label_2:
            T[] val_2 = 536877971.ToArray();
            mem[1152921510101169048] = 536877971;
        }
        public override string ToString()
        {
            var val_5;
            object val_6;
            System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>> val_7;
            val_5 = 536900157;
            if(((mem[536900344] & true) == 0) && (mem[536900273] == 0))
            {
                    val_5 = 536900157;
            }
            
            val_6 = mem[536900249];
            val_7 = mem[mem[536900249] + 8];
            val_7 = mem[536900249] + 8;
            if(val_7 == 0)
            {
                    if(((mem[536900344] & true) == 0) && (mem[536900273] == 0))
            {
                    val_6 = mem[536900249];
            }
            
                val_7 = 536875447;
                val_7 = new System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>>(object:  val_6, method:  new IntPtr(1610687575));
                mem2[0] = val_7;
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_2 = System.Linq.Enumerable.Select<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Default.WinProductDescription>(source:  this.m_Values, selector:  536875447);
            TSource[] val_3 = System.Linq.Enumerable.ToArray<System.Type>(source:  this.m_Values);
            string val_4 = System.String.Join(separator:  -1610612501, value:  this.m_Values);
            return -1610612031(-1610612031) + -1610612501(-1610612501) + -1610612507(-1610612507);
        }
    
    }

}
