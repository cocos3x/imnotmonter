using UnityEngine;

namespace B83.ExpressionParserBigInteger
{
    public class Expression : IValue
    {
        // Fields
        public System.Collections.Generic.Dictionary<string, B83.ExpressionParserBigInteger.Parameter> Parameters;
        private B83.ExpressionParserBigInteger.IValue <ExpressionTree>k__BackingField;
        
        // Properties
        public B83.ExpressionParserBigInteger.IValue ExpressionTree { get; set; }
        public AFramework.BigInteger Value { get; }
        public AFramework.BigInteger[] MultiValue { get; }
        
        // Methods
        public B83.ExpressionParserBigInteger.IValue get_ExpressionTree()
        {
        
        }
        public void set_ExpressionTree(B83.ExpressionParserBigInteger.IValue value)
        {
            this.<ExpressionTree>k__BackingField = value;
        }
        public AFramework.BigInteger get_Value()
        {
            var val_1;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = this.<ExpressionTree>k__BackingField;
            goto mem[(1152921504920104960 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public AFramework.BigInteger[] get_MultiValue()
        {
            B83.ExpressionParserBigInteger.IValue val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_2 = this.<ExpressionTree>k__BackingField;
            val_3 = 0;
            if(val_2 == 0)
            {
                    return;
            }
            
            val_3 = 0;
            if(((B83.ExpressionParserBigInteger.IValue.__il2cppRuntimeField_typeHierarchy + (mem[536891045]) << 2) + -4) != 536890865)
            {
                    val_2 = val_3;
            }
            
            val_3 = 536881717;
            val_4 = 0;
            goto label_6;
            label_20:
            var val_1 = 0 + 0;
            var val_3 = (0 + 0) + 16;
            if(((0 + 0) + 16 + 178) == 0)
            {
                goto label_11;
            }
            
            val_5 = 0;
            label_13:
            if(((0 + 0) + 16 + 88 + 0) == 536888835)
            {
                goto label_12;
            }
            
            val_5 = val_5 + 1;
            if(((uint)val_5 & 65535) < ((0 + 0) + 16 + 178))
            {
                goto label_13;
            }
            
            label_11:
            val_6 = (0 + 0) + 16;
            goto label_14;
            label_12:
            var val_2 = ((0 + 0) + 16 + 88) + 0;
            val_3 = val_3 + ((((0 + 0) + 16 + 88 + 0) + 4) << 3);
            val_6 = val_3 + 188;
            label_14:
            mem[536881733] = (0 + 0) + 16;
            val_4 = 1;
            label_6:
            if(val_4 < mem[536881729])
            {
                goto label_20;
            }
        
        }
        public B83.ExpressionParserBigInteger.ExpressionDelegate ToDelegate(string[] aParamOrder)
        {
            System.Collections.Generic.Dictionary<System.String, B83.ExpressionParserBigInteger.Parameter> val_6;
            var val_7;
            var val_8;
            Expression.<>c__DisplayClass9_0 val_1 = 536898931;
            val_1 = new Expression.<>c__DisplayClass9_0();
            mem[536898939] = this;
            536878127 = new System.Collections.Generic.List<SingleRange>(capacity:  1192856880);
            if(536878127 >= 1)
            {
                    var val_6 = 0;
                do
            {
                val_6 = this.Parameters;
                if((val_6.ContainsKey(key:  334878800)) != false)
            {
                    B83.ExpressionParserBigInteger.Parameter val_4 = this.Parameters.Item[334878800];
                val_6 = this.Parameters;
                val_7 = val_6;
                val_8 = 22737772;
            }
            else
            {
                    val_7 = 0;
                val_8 = 22737772;
            }
            
                536878127.Add(item:  0);
                val_6 = val_6 + 1;
            }
            while(val_6 < 536878127);
            
            }
            
            T[] val_5 = 536878127.ToArray();
            mem[536898943] = 536878127;
            mem[536886669] = 1610687487;
            mem[536886657] = mem[1610687487];
            mem[536886665] = val_1;
        }
        public B83.ExpressionParserBigInteger.MultiResultDelegate ToMultiResultDelegate(string[] aParamOrder)
        {
            System.Collections.Generic.Dictionary<System.String, B83.ExpressionParserBigInteger.Parameter> val_7;
            var val_8;
            var val_9;
            536898929 = new Expression.<>c__DisplayClass10_0();
            mem[536898937] = this;
            536878127 = new System.Collections.Generic.List<SingleRange>(capacity:  1193058992);
            if(536878127 >= 1)
            {
                    var val_7 = 0;
                do
            {
                val_7 = this.Parameters;
                if((val_7.ContainsKey(key:  334878800)) != false)
            {
                    B83.ExpressionParserBigInteger.Parameter val_4 = this.Parameters.Item[334878800];
                val_7 = this.Parameters;
                val_8 = val_7;
                val_9 = 22737772;
            }
            else
            {
                    val_8 = 0;
                val_9 = 22737772;
            }
            
                536878127.Add(item:  0);
                val_7 = val_7 + 1;
            }
            while(val_7 < 536878127);
            
            }
            
            T[] val_5 = 536878127.ToArray();
            mem[536898941] = 536878127;
            536890869 = new B83.ExpressionParserBigInteger.MultiResultDelegate(object:  536898929, method:  new IntPtr(1610687491));
        }
        private AFramework.BigInteger Invoke(AFramework.BigInteger[] aParams, B83.ExpressionParserBigInteger.Parameter[] aParamList)
        {
            var val_2 = 0;
            int val_1 = System.Math.Min(val1:  536890295, val2:  mem[536890411]);
            if(val_1 < 1)
            {
                    return this.Value;
            }
            
            AFramework.BigInteger[] val_2 = aParams[16];
            do
            {
                if(null != null)
            {
                    typeof(B83.ExpressionParserBigInteger.Parameter[]).__il2cppRuntimeField_8 = aParams[0x10] + 0;
            }
            
                val_2 = val_2 + 1;
            }
            while(val_1 != val_2);
            
            return this.Value;
        }
        private AFramework.BigInteger[] InvokeMultiResult(AFramework.BigInteger[] aParams, B83.ExpressionParserBigInteger.Parameter[] aParamList)
        {
            var val_2 = 0;
            int val_1 = System.Math.Min(val1:  536890295, val2:  mem[536890411]);
            if(val_1 < 1)
            {
                    return this.MultiValue;
            }
            
            AFramework.BigInteger[] val_2 = aParams[16];
            do
            {
                if(null != null)
            {
                    typeof(B83.ExpressionParserBigInteger.Parameter[]).__il2cppRuntimeField_8 = aParams[0x10] + 0;
            }
            
                val_2 = val_2 + 1;
            }
            while(val_1 != val_2);
            
            return this.MultiValue;
        }
        public static B83.ExpressionParserBigInteger.Expression Parse(string aExpression)
        {
            B83.ExpressionParserBigInteger.ExpressionParser val_1 = 536886653;
            val_1 = new B83.ExpressionParserBigInteger.ExpressionParser();
            if(val_1 != 0)
            {
                    return val_1.EvaluateExpression(aExpression:  aExpression);
            }
            
            return val_1.EvaluateExpression(aExpression:  aExpression);
        }
        public Expression()
        {
            536874389 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
            this.Parameters = 536874389;
        }
    
    }

}
