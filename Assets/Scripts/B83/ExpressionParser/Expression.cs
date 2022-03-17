using UnityEngine;

namespace B83.ExpressionParser
{
    public class Expression : IValue
    {
        // Fields
        public System.Collections.Generic.Dictionary<string, B83.ExpressionParser.Parameter> Parameters;
        private B83.ExpressionParser.IValue <ExpressionTree>k__BackingField;
        
        // Properties
        public B83.ExpressionParser.IValue ExpressionTree { get; set; }
        public double Value { get; }
        public double[] MultiValue { get; }
        
        // Methods
        public B83.ExpressionParser.IValue get_ExpressionTree()
        {
        
        }
        public void set_ExpressionTree(B83.ExpressionParser.IValue value)
        {
            this.<ExpressionTree>k__BackingField = value;
        }
        public double get_Value()
        {
            var val_1;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = this.<ExpressionTree>k__BackingField;
            goto mem[(1152921504921382912 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public double[] get_MultiValue()
        {
            B83.ExpressionParser.IValue val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = this.<ExpressionTree>k__BackingField;
            val_3 = 0;
            if(val_2 == 0)
            {
                    return;
            }
            
            val_3 = 0;
            if(((B83.ExpressionParser.IValue.__il2cppRuntimeField_typeHierarchy + (mem[536891043]) << 2) + -4) != 536890863)
            {
                    val_2 = val_3;
            }
            
            val_3 = 536881891;
            val_4 = 0;
            goto label_6;
            label_18:
            var val_1 = 0 + 0;
            var val_4 = (0 + 0) + 16;
            if(((0 + 0) + 16 + 178) == 0)
            {
                goto label_11;
            }
            
            var val_3 = 0;
            label_13:
            if(((0 + 0) + 16 + 88 + 0) == 536888831)
            {
                goto label_12;
            }
            
            val_3 = val_3 + 1;
            if(((uint)val_3 & 65535) < ((0 + 0) + 16 + 178))
            {
                goto label_13;
            }
            
            label_11:
            val_5 = (0 + 0) + 16;
            goto label_14;
            label_12:
            var val_2 = ((0 + 0) + 16 + 88) + 0;
            val_4 = val_4 + ((((0 + 0) + 16 + 88 + 0) + 4) << 3);
            val_5 = val_4 + 188;
            label_14:
            val_4 = 1;
            mem[536881907] = (0 + 0) + 16;
            label_6:
            if(val_4 < mem[536881903])
            {
                goto label_18;
            }
        
        }
        public override string ToString()
        {
            if((this.<ExpressionTree>k__BackingField) == 0)
            {
                
            }
        
        }
        public B83.ExpressionParser.ExpressionDelegate ToDelegate(string[] aParamOrder)
        {
            System.Collections.Generic.Dictionary<System.String, B83.ExpressionParser.Parameter> val_6;
            var val_7;
            var val_8;
            Expression.<>c__DisplayClass10_0 val_1 = 536898923;
            val_1 = new Expression.<>c__DisplayClass10_0();
            mem[536898931] = this;
            536878125 = new System.Collections.Generic.List<SingleRange>(capacity:  1206197136);
            if(536878125 >= 1)
            {
                    var val_6 = 0;
                do
            {
                val_6 = this.Parameters;
                if((val_6.ContainsKey(key:  334878800)) != false)
            {
                    B83.ExpressionParser.Parameter val_4 = this.Parameters.Item[334878800];
                val_6 = this.Parameters;
                val_7 = val_6;
                val_8 = 22737760;
            }
            else
            {
                    val_7 = 0;
                val_8 = 22737760;
            }
            
                536878125.Add(item:  0);
                val_6 = val_6 + 1;
            }
            while(val_6 < 536878125);
            
            }
            
            T[] val_5 = 536878125.ToArray();
            mem[536898935] = 536878125;
            mem[536886667] = 1610687675;
            mem[536886655] = mem[1610687675];
            mem[536886663] = val_1;
        }
        public B83.ExpressionParser.MultiResultDelegate ToMultiResultDelegate(string[] aParamOrder)
        {
            System.Collections.Generic.Dictionary<System.String, B83.ExpressionParser.Parameter> val_7;
            var val_8;
            var val_9;
            536898925 = new Expression.<>c__DisplayClass11_0();
            mem[536898933] = this;
            536878125 = new System.Collections.Generic.List<SingleRange>(capacity:  1206399248);
            if(536878125 >= 1)
            {
                    var val_7 = 0;
                do
            {
                val_7 = this.Parameters;
                if((val_7.ContainsKey(key:  334878800)) != false)
            {
                    B83.ExpressionParser.Parameter val_4 = this.Parameters.Item[334878800];
                val_7 = this.Parameters;
                val_8 = val_7;
                val_9 = 22737760;
            }
            else
            {
                    val_8 = 0;
                val_9 = 22737760;
            }
            
                536878125.Add(item:  0);
                val_7 = val_7 + 1;
            }
            while(val_7 < 536878125);
            
            }
            
            T[] val_5 = 536878125.ToArray();
            mem[536898937] = 536878125;
            536890867 = new B83.ExpressionParser.MultiResultDelegate(object:  536898925, method:  new IntPtr(1610687679));
        }
        private double Invoke(double[] aParams, B83.ExpressionParser.Parameter[] aParamList)
        {
            var val_2 = 0;
            int val_1 = System.Math.Min(val1:  536890295, val2:  mem[536890411]);
            if(val_1 < 1)
            {
                    return this.Value;
            }
            
            do
            {
                if(null != null)
            {
                    typeof(B83.ExpressionParser.Parameter[]).__il2cppRuntimeField_8 = null;
                typeof(B83.ExpressionParser.Parameter[]).__il2cppRuntimeField_C = 2.524355E-29f;
            }
            
                val_2 = val_2 + 1;
            }
            while(val_1 != val_2);
            
            return this.Value;
        }
        private double[] InvokeMultiResult(double[] aParams, B83.ExpressionParser.Parameter[] aParamList)
        {
            var val_2 = 0;
            int val_1 = System.Math.Min(val1:  536890295, val2:  mem[536890411]);
            if(val_1 < 1)
            {
                    return this.MultiValue;
            }
            
            do
            {
                if(null != null)
            {
                    typeof(B83.ExpressionParser.Parameter[]).__il2cppRuntimeField_8 = null;
                typeof(B83.ExpressionParser.Parameter[]).__il2cppRuntimeField_C = 2.524355E-29f;
            }
            
                val_2 = val_2 + 1;
            }
            while(val_1 != val_2);
            
            return this.MultiValue;
        }
        public static B83.ExpressionParser.Expression Parse(string aExpression)
        {
            B83.ExpressionParser.ExpressionParser val_1 = 536886651;
            val_1 = new B83.ExpressionParser.ExpressionParser();
            if(val_1 != 0)
            {
                    return val_1.EvaluateExpression(aExpression:  aExpression);
            }
            
            return val_1.EvaluateExpression(aExpression:  aExpression);
        }
        public Expression()
        {
            536874385 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
            this.Parameters = 536874385;
        }
    
    }

}
