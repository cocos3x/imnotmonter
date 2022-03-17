using UnityEngine;

namespace B83.ExpressionParser
{
    public class ExpressionParser
    {
        // Fields
        private System.Collections.Generic.List<string> m_BracketHeap;
        private System.Collections.Generic.Dictionary<string, System.Func<double>> m_Consts;
        private System.Collections.Generic.Dictionary<string, System.Func<double[], double>> m_Funcs;
        private B83.ExpressionParser.Expression m_Context;
        
        // Methods
        public ExpressionParser()
        {
            if(100 == 0)
            {
                
            }
        
        }
        public void AddFunc(string aName, System.Func<double[], double> aMethod)
        {
            if((this.m_Funcs.ContainsKey(key:  aName)) != false)
            {
                    this.m_Funcs.set_Item(key:  aName, value:  aMethod);
                return;
            }
            
            this.m_Funcs.Add(key:  aName, value:  aMethod);
        }
        public void AddConst(string aName, System.Func<double> aMethod)
        {
            if((this.m_Consts.ContainsKey(key:  aName)) != false)
            {
                    this.m_Consts.set_Item(key:  aName, value:  aMethod);
                return;
            }
            
            this.m_Consts.Add(key:  aName, value:  aMethod);
        }
        public void RemoveFunc(string aName)
        {
            if((this.m_Funcs.ContainsKey(key:  aName)) == false)
            {
                    return;
            }
            
            bool val_2 = this.m_Funcs.Remove(key:  aName);
        }
        public void RemoveConst(string aName)
        {
            if((this.m_Consts.ContainsKey(key:  aName)) == false)
            {
                    return;
            }
            
            bool val_2 = this.m_Consts.Remove(key:  aName);
        }
        private int FindClosingBracket(ref string aText, int aStart, char aOpen, char aClose)
        {
            int val_3;
            string val_4;
            val_3 = aStart;
            goto label_0;
            label_5:
            val_4 = aText;
            if(aText.Chars[val_3] == aOpen)
            {
                    0 = 1;
            }
            
            if(val_4.Chars[val_3] == aClose)
            {
                    0 = 0 - 1;
            }
            
            if(0 == 0)
            {
                    return 0;
            }
            
            val_3 = val_3 + 1;
            label_0:
            val_4 = aText;
            if(val_3 < aText.m_stringLength)
            {
                goto label_5;
            }
            
            return 0;
        }
        private void SubstitudeBracket(ref string aExpression, int aIndex)
        {
            int val_12 = aIndex;
            int val_2 = this.FindClosingBracket(aText: ref  string val_1 = 1213368768, aStart:  val_12, aOpen:  '(', aClose:  ')');
            int val_3 = aIndex + 1;
            if(val_2 > val_3)
            {
                    val_12 = val_2 + (~aIndex);
                string val_4 = aExpression.Substring(startIndex:  val_3, length:  val_12);
                System.Collections.Generic.List<System.String> val_13 = this.m_BracketHeap;
                val_13.Add(item:  aExpression);
                val_13 = val_13 - 1;
                string val_5 = val_13.ToString();
                string val_6 = -1610612139(-1610612139) + 1213324732 + -1610610697(-1610610697);
                string val_7 = aExpression.Substring(startIndex:  0, length:  aIndex);
                string val_9 = aExpression.Substring(startIndex:  val_2 + 1);
                string val_10 = aExpression + -1610612139(-1610612139) + aExpression;
                aExpression = aExpression;
                return;
            }
            
            22718068 = new ExpressionParser.ParseException(aMessage:  22782604);
        }
        private B83.ExpressionParser.IValue Parse(string aExpression)
        {
            string val_57;
            string val_58;
            System.Collections.Generic.List<SingleRange> val_59;
            float val_60;
            var val_61;
            System.Collections.Generic.List<SingleRange> val_62;
            var val_63;
            var val_64;
            var val_65;
            val_57 = aExpression;
            string val_1 = val_57.Trim();
            val_58 = val_57;
            int val_2 = val_58.IndexOf(value:  '(');
            if(val_2 >= 0)
            {
                    do
            {
                this.SubstitudeBracket(aExpression: ref  string val_3 = 1213457116, aIndex:  val_2);
                val_57 = val_57;
            }
            while((val_57.IndexOf(value:  '(')) > 1);
            
                val_58 = val_57;
            }
            
            if((System.Linq.Enumerable.Contains<System.Char>(source:  val_58, value:  ',')) != false)
            {
                    mem[536881809] = 44;
                System.String[] val_6 = val_57.Split(separator:  536881793);
                val_59 = 536877971;
                val_59 = new System.Collections.Generic.List<SingleRange>(capacity:  aExpression + 12);
                if((aExpression + 12) >= 1)
            {
                    string val_8 = val_57 + 16;
                var val_61 = 0;
                val_60 = 4.021277E-38f;
                do
            {
                string val_9 = (aExpression + 16) + 0.Trim();
                val_57 = (aExpression + 16) + 0;
                if((System.String.IsNullOrEmpty(value:  (aExpression + 16) + 0)) != true)
            {
                    val_57 = this;
                val_59.Add(item:  1213469168);
            }
            
                val_61 = val_61 + 1;
            }
            while(val_61 < (aExpression + 12));
            
            }
            
                T[] val_11 = val_59.ToArray();
                B83.ExpressionParser.MultiParameterList val_12 = 536890863;
                val_61 = val_12;
                val_12 = new B83.ExpressionParser.MultiParameterList(aValues:  536877971);
                return;
            }
            
            if((System.Linq.Enumerable.Contains<System.Char>(source:  val_57, value:  '+')) == false)
            {
                goto label_20;
            }
            
            mem[536881809] = 43;
            System.String[] val_14 = val_57.Split(separator:  536881793);
            val_59 = val_57;
            val_62 = 536877971;
            val_62 = new System.Collections.Generic.List<SingleRange>(capacity:  aExpression + 12);
            if((aExpression + 12) < 1)
            {
                goto label_45;
            }
            
            string val_16 = val_59 + 16;
            var val_62 = 0;
            val_60 = 4.021277E-38f;
            do
            {
                string val_17 = (aExpression + 16) + 0.Trim();
                val_57 = (aExpression + 16) + 0;
                if((System.String.IsNullOrEmpty(value:  (aExpression + 16) + 0)) != true)
            {
                    val_57 = this;
                val_62.Add(item:  1213469168);
            }
            
                val_62 = val_62 + 1;
            }
            while(val_62 < (aExpression + 12));
            
            goto label_45;
            label_20:
            if((System.Linq.Enumerable.Contains<System.Char>(source:  val_57, value:  '-')) == false)
            {
                goto label_33;
            }
            
            mem[536881809] = 45;
            System.String[] val_20 = val_57.Split(separator:  536881793);
            val_59 = val_57;
            val_62 = 536877971;
            val_62 = new System.Collections.Generic.List<SingleRange>(capacity:  aExpression + 12);
            val_57 = mem[aExpression + 16];
            val_57 = aExpression + 16;
            string val_22 = val_57.Trim();
            if((System.String.IsNullOrEmpty(value:  val_57)) != true)
            {
                    val_57 = this;
                val_62.Add(item:  1213469168);
            }
            
            if((aExpression + 12) >= 2)
            {
                    val_60 = 4.021277E-38f;
                do
            {
                string val_24 = aExpression + 20.Trim();
                val_57 = aExpression + 20;
                if((System.String.IsNullOrEmpty(value:  aExpression + 20)) != true)
            {
                    B83.ExpressionParser.OperationNegate val_26 = 536891359;
                val_57 = val_26;
                val_26 = new B83.ExpressionParser.OperationNegate(aValue:  1213469168);
                val_62.Add(item:  536891359);
            }
            
                var val_27 = 5 + 1;
            }
            while((5 - 3) < (aExpression + 12));
            
            }
            
            label_45:
            if(val_62 == 0)
            {
                goto label_52;
            }
            
            if(mem[536877983] == 1)
            {
                goto label_56;
            }
            
            goto label_55;
            label_52:
            if(0 != 1)
            {
                goto label_55;
            }
            
            if(0 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            label_56:
            label_102:
            val_61 = mem[mem[536877979] + 16];
            val_61 = mem[536877979] + 16;
            return;
            label_55:
            T[] val_29 = val_62.ToArray();
            B83.ExpressionParser.OperationSum val_30 = 536891375;
            val_61 = val_30;
            val_30 = new B83.ExpressionParser.OperationSum(aValues:  536877971);
            return;
            label_33:
            if((System.Linq.Enumerable.Contains<System.Char>(source:  val_57, value:  '*')) == false)
            {
                goto label_59;
            }
            
            val_59 = 536881793;
            mem[536881809] = 42;
            System.String[] val_32 = val_57.Split(separator:  536881793);
            536877971 = new System.Collections.Generic.List<SingleRange>(capacity:  aExpression + 12);
            if((aExpression + 12) >= 1)
            {
                    string val_34 = val_57 + 16;
                val_60 = 4.021277E-38f;
                do
            {
                val_57 = this;
                536877971.Add(item:  1213469168);
                val_59 = 0 + 1;
            }
            while(val_59 < (aExpression + 12));
            
            }
            
            if(536877971 == 0)
            {
                goto label_69;
            }
            
            if(mem[536877983] == 1)
            {
                goto label_102;
            }
            
            goto label_100;
            label_59:
            if((System.Linq.Enumerable.Contains<System.Char>(source:  val_57, value:  '/')) == false)
            {
                goto label_72;
            }
            
            val_59 = 536881793;
            mem[536881809] = 47;
            System.String[] val_36 = val_57.Split(separator:  536881793);
            536877971 = new System.Collections.Generic.List<SingleRange>(capacity:  aExpression + 12);
            val_57 = mem[aExpression + 16];
            val_57 = aExpression + 16;
            string val_38 = val_57.Trim();
            if((System.String.IsNullOrEmpty(value:  val_57)) != true)
            {
                    val_57 = this;
                536877971.Add(item:  1213469168);
            }
            
            if((aExpression + 12) >= 2)
            {
                    val_60 = 4.021277E-38f;
                do
            {
                string val_40 = aExpression + 20.Trim();
                val_57 = aExpression + 20;
                if((System.String.IsNullOrEmpty(value:  aExpression + 20)) != true)
            {
                    val_59 = this;
                B83.ExpressionParser.OperationReciprocal val_42 = 536891371;
                val_57 = val_42;
                val_42 = new B83.ExpressionParser.OperationReciprocal(aValue:  1213469168);
                536877971.Add(item:  536891371);
            }
            
                var val_43 = 5 + 1;
            }
            while((5 - 3) < (aExpression + 12));
            
            }
            
            val_63 = -1073714395;
            val_64 = 536877971;
            goto label_92;
            label_72:
            if((System.Linq.Enumerable.Contains<System.Char>(source:  val_57, value:  '^')) == false)
            {
                goto label_94;
            }
            
            int val_46 = val_57.IndexOf(value:  '^');
            string val_47 = val_57.Substring(startIndex:  0, length:  val_46);
            val_59 = val_57;
            val_57 = this;
            string val_49 = val_59.Substring(startIndex:  val_46 + 1);
            B83.ExpressionParser.OperationPower val_50 = 536891363;
            val_61 = val_50;
            val_50 = new B83.ExpressionParser.OperationPower(aValue:  1213469168, aPower:  1213469168);
            return;
            label_69:
            val_59 = 0;
            if(val_59 != 1)
            {
                goto label_100;
            }
            
            if(0 != 0)
            {
                goto label_102;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            goto label_102;
            label_100:
            val_63 = -1073714395;
            val_64 = 536877971;
            label_92:
            T[] val_51 = val_64.ToArray();
            B83.ExpressionParser.OperationProduct val_52 = 536891367;
            val_61 = val_52;
            val_52 = new B83.ExpressionParser.OperationProduct(aValues:  536877971);
            return;
            label_94:
            int val_53 = val_57.IndexOf(value:  -1610612139);
            if(val_53 < 1)
            {
                goto label_119;
            }
            
            string val_54 = val_57.Substring(startIndex:  0, length:  val_53);
            Dictionary.Enumerator<TKey, TValue> val_55 = GetEnumerator();
            label_107:
            if(0.MoveNext() == false)
            {
                goto label_106;
            }
            
            if((System.String.op_Equality(a:  val_57, b:  null)) == false)
            {
                goto label_107;
            }
            
            string val_59 = val_57.Substring(startIndex:  0);
            mem[536882063] = this;
            val_65 = 1279;
            536885531 = new B83.ExpressionParser.CustomFunction(aName:  null, aDelegate:  R7, aValues:  536882047);
            goto label_118;
            label_106:
            val_65 = 955;
            label_118:
            0.Dispose();
            if(955 != 955)
            {
                    if(955 != 1279)
            {
                goto label_121;
            }
            
            }
        
        }
        private bool ValidIdentifier(string aExpression)
        {
            char val_9 = 22968898;
            string val_1 = aExpression.Trim();
            if((System.String.IsNullOrEmpty(value:  aExpression)) == true)
            {
                    return false;
            }
            
            if(aExpression.m_stringLength < 1)
            {
                    return false;
            }
            
            if((aExpression.Contains(value:  -1610612561)) == true)
            {
                    return false;
            }
            
            val_9 = aExpression.Chars[0];
            if((System.Linq.Enumerable.Contains<System.Char>(source:  -1610601879, value:  System.Char.ToLower(c:  val_9))) == false)
            {
                    return false;
            }
            
            val_9 = this.m_Consts;
            if((val_9.ContainsKey(key:  aExpression)) != false)
            {
                    return false;
            }
            
            bool val_8 = this.m_Funcs.ContainsKey(key:  aExpression);
            val_8 = val_8 ^ 1;
            return (bool)val_8;
        }
        public B83.ExpressionParser.Expression EvaluateExpression(string aExpression)
        {
            B83.ExpressionParser.Expression val_1 = 536886635;
            val_1 = new B83.ExpressionParser.Expression();
            this.m_Context = val_1;
            B83.ExpressionParser.IValue val_2 = this.Parse(aExpression:  aExpression);
            mem[536886647] = this;
            this.m_Context = 0;
            this.m_BracketHeap.Clear();
        }
        public double Evaluate(string aExpression)
        {
            B83.ExpressionParser.Expression val_1 = this.EvaluateExpression(aExpression:  aExpression);
            if(this != 0)
            {
                    return this.Value;
            }
            
            return this.Value;
        }
        public static double Eval(string aExpression)
        {
            B83.ExpressionParser.ExpressionParser val_1 = 536886651;
            val_1 = new B83.ExpressionParser.ExpressionParser();
            if(val_1 != 0)
            {
                    return this.Evaluate(aExpression:  aExpression);
            }
            
            return this.Evaluate(aExpression:  aExpression);
        }
    
    }

}
