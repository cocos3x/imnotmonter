using UnityEngine;

namespace B83.ExpressionParser
{
    public class CustomFunction : IValue
    {
        // Fields
        private B83.ExpressionParser.IValue[] m_Params;
        private System.Func<double[], double> m_Delegate;
        private string m_Name;
        
        // Properties
        public double Value { get; }
        
        // Methods
        public double get_Value()
        {
            var val_4;
            object val_5;
            System.Func<System.Object, System.Double> val_6;
            if(this.m_Params != null)
            {
                    val_4 = 536898387;
                if(((mem[536898574] & true) == 0) && (mem[536898503] == 0))
            {
                    val_4 = 536898387;
            }
            
                val_5 = mem[536898479];
                val_6 = mem[mem[536898479] + 4];
                val_6 = mem[536898479] + 4;
                if(val_6 == 0)
            {
                    if(((mem[536898574] & true) == 0) && (mem[536898503] == 0))
            {
                    val_5 = mem[536898479];
            }
            
                val_6 = 536875443;
                val_6 = new System.Func<System.Object, System.Double>(object:  val_5, method:  new IntPtr(1610687637));
                mem2[0] = val_6;
            }
            
                System.Collections.Generic.IEnumerable<TResult> val_2 = System.Linq.Enumerable.Select<System.Object, System.Double>(source:  this.m_Params, selector:  536875443);
                TSource[] val_3 = System.Linq.Enumerable.ToArray<System.Double>(source:  this.m_Params);
                if(this.m_Delegate != 0)
            {
                    return this.m_Delegate.Invoke(arg:  this.m_Params);
            }
            
                return this.m_Delegate.Invoke(arg:  this.m_Params);
            }
            
            if(this.m_Delegate != 0)
            {
                    return this.m_Delegate.Invoke(arg:  null);
            }
            
            return this.m_Delegate.Invoke(arg:  null);
        }
        public CustomFunction(string aName, System.Func<double[], double> aDelegate, B83.ExpressionParser.IValue[] aValues)
        {
            string val_1 = aName;
            val_1 = new System.Object();
            this.m_Delegate = aDelegate;
            this.m_Params = aValues;
            this.m_Name = val_1;
        }
        public override string ToString()
        {
            var val_6;
            object val_7;
            System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>> val_8;
            if(this.m_Params == null)
            {
                    return;
            }
            
            val_6 = 536898387;
            if(((mem[536898574] & true) == 0) && (mem[536898503] == 0))
            {
                    val_6 = 536898387;
            }
            
            val_7 = mem[536898479];
            val_8 = mem[mem[536898479] + 8];
            val_8 = mem[536898479] + 8;
            if(val_8 == 0)
            {
                    if(((mem[536898574] & true) == 0) && (mem[536898503] == 0))
            {
                    val_7 = mem[536898479];
            }
            
                val_8 = 536875447;
                val_8 = new System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>>(object:  val_7, method:  new IntPtr(1610687639));
                mem2[0] = val_8;
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_2 = System.Linq.Enumerable.Select<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Default.WinProductDescription>(source:  this.m_Params, selector:  536875447);
            TSource[] val_3 = System.Linq.Enumerable.ToArray<System.Type>(source:  this.m_Params);
            string val_4 = System.String.Join(separator:  -1610611907, value:  this.m_Params);
            string val_5 = this.m_Name + -1610612031(-1610612031) + -1610611907(-1610611907) + -1610612507(-1610612507);
        }
    
    }

}
