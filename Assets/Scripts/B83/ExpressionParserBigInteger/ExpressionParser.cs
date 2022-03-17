using UnityEngine;

namespace B83.ExpressionParserBigInteger
{
    public class ExpressionParser
    {
        // Fields
        private System.Collections.Generic.List<string> m_BracketHeap;
        private System.Collections.Generic.Dictionary<string, System.Func<AFramework.BigInteger>> m_Consts;
        private System.Collections.Generic.Dictionary<string, System.Func<AFramework.BigInteger[], AFramework.BigInteger>> m_Funcs;
        private B83.ExpressionParserBigInteger.Expression m_Context;
        
        // Methods
        public ExpressionParser()
        {
            var val_9;
            object val_10;
            System.Func<ContingentProperties> val_11;
            object val_12;
            var val_13;
            object val_14;
            System.Func<ContingentProperties> val_15;
            var val_16;
            object val_17;
            System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>> val_18;
            var val_19;
            object val_20;
            System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>> val_21;
            var val_22;
            object val_23;
            System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>> val_24;
            536878341 = new System.Collections.Generic.List<Page>();
            this.m_BracketHeap = 536878341;
            536874305 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
            this.m_Consts = 536874305;
            536874313 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
            this.m_Funcs = 536874313;
            val_9 = 536898945;
            if(((mem[536899132] & true) == 0) && (mem[536899061] == 0))
            {
                    val_9 = 536898945;
            }
            
            val_10 = mem[536899037];
            val_11 = mem[mem[536899037] + 4];
            val_11 = mem[536899037] + 4;
            val_12 = -1610605511;
            if(val_11 == 0)
            {
                    if(((mem[536899132] & true) == 0) && (mem[536899061] == 0))
            {
                    val_10 = mem[536899037];
            }
            
                val_11 = 536875155;
                val_11 = new System.Func<ContingentProperties>(object:  val_10, method:  new IntPtr(1610687539));
                mem2[0] = val_11;
            }
            
            this.m_Consts.Add(key:  -1610605511, value:  536875155);
            val_13 = 536898945;
            if(((mem[536899132] & true) == 0) && (mem[536899061] == 0))
            {
                    val_13 = 536898945;
            }
            
            val_14 = mem[536899037];
            val_15 = mem[mem[536899037] + 8];
            val_15 = mem[536899037] + 8;
            if(val_15 == 0)
            {
                    if(((mem[536899132] & true) == 0) && (mem[536899061] == 0))
            {
                    val_14 = mem[536899037];
            }
            
                val_12 = mem[mem[536899037]];
                val_12 = val_14;
                val_15 = 536875155;
                val_15 = new System.Func<ContingentProperties>(object:  val_12, method:  new IntPtr(1610687541));
                mem2[0] = val_15;
            }
            
            this.m_Consts.SyncRoot.Add(key:  -1610600751, value:  536875155);
            val_16 = 536898945;
            if(((mem[536899132] & true) == 0) && (mem[536899061] == 0))
            {
                    val_16 = 536898945;
            }
            
            val_17 = mem[536899037];
            val_18 = mem[mem[536899037] + 12];
            val_18 = mem[536899037] + 12;
            if(val_18 == 0)
            {
                    if(((mem[536899132] & true) == 0) && (mem[536899061] == 0))
            {
                    val_17 = mem[536899037];
            }
            
                val_12 = mem[mem[536899037]];
                val_12 = val_17;
                val_18 = 536875355;
                val_18 = new System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>>(object:  val_12, method:  new IntPtr(1610687543));
                mem2[0] = val_18;
            }
            
            this.m_Funcs.SyncRoot.Add(key:  -1610601877, value:  536875355);
            val_19 = 536898945;
            if(((mem[536899132] & true) == 0) && (mem[536899061] == 0))
            {
                    val_19 = 536898945;
            }
            
            val_20 = mem[536899037];
            val_21 = mem[mem[536899037] + 16];
            val_21 = mem[536899037] + 16;
            if(val_21 == 0)
            {
                    if(((mem[536899132] & true) == 0) && (mem[536899061] == 0))
            {
                    val_20 = mem[536899037];
            }
            
                val_12 = mem[mem[536899037]];
                val_12 = val_20;
                val_21 = 536875355;
                val_21 = new System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>>(object:  val_12, method:  new IntPtr(1610687545));
                mem2[0] = val_21;
            }
            
            this.m_Funcs.SyncRoot.Add(key:  -1610599233, value:  536875355);
            val_22 = 536898945;
            if(((mem[536899132] & true) == 0) && (mem[536899061] == 0))
            {
                    val_22 = 536898945;
            }
            
            val_23 = mem[536899037];
            val_24 = mem[mem[536899037] + 20];
            val_24 = mem[536899037] + 20;
            if(val_24 == 0)
            {
                    if(((mem[536899132] & true) == 0) && (mem[536899061] == 0))
            {
                    val_23 = mem[536899037];
            }
            
                val_12 = mem[mem[536899037]];
                val_12 = val_23;
                val_24 = 536875355;
                val_24 = new System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>>(object:  val_12, method:  new IntPtr(1610687547));
                mem2[0] = val_24;
            }
            
            this.m_Funcs.SyncRoot.Add(key:  -1610599305, value:  536875355);
        }
        public void AddFunc(string aName, System.Func<AFramework.BigInteger[], AFramework.BigInteger> aMethod)
        {
            if((this.m_Funcs.ContainsKey(key:  aName)) != false)
            {
                    this.m_Funcs.set_Item(key:  aName, value:  aMethod);
                return;
            }
            
            this.m_Funcs.Add(key:  aName, value:  aMethod);
        }
        public void AddConst(string aName, System.Func<AFramework.BigInteger> aMethod)
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
            int val_2 = this.FindClosingBracket(aText: ref  string val_1 = 1197493856, aStart:  val_12, aOpen:  '(', aClose:  ')');
            int val_3 = aIndex + 1;
            if(val_2 > val_3)
            {
                    val_12 = val_2 + (~aIndex);
                string val_4 = aExpression.Substring(startIndex:  val_3, length:  val_12);
                System.Collections.Generic.List<System.String> val_13 = this.m_BracketHeap;
                val_13.Add(item:  aExpression);
                val_13 = val_13 - 1;
                string val_5 = val_13.ToString();
                string val_6 = -1610612139(-1610612139) + 1197449820 + -1610610697(-1610610697);
                string val_7 = aExpression.Substring(startIndex:  0, length:  aIndex);
                string val_9 = aExpression.Substring(startIndex:  val_2 + 1);
                string val_10 = aExpression + -1610612139(-1610612139) + aExpression;
                aExpression = aExpression;
                return;
            }
            
            22718080 = new ExpressionParser.ParseException(aMessage:  22782604);
        }
        private B83.ExpressionParserBigInteger.IValue Parse(string aExpression)
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
                this.SubstitudeBracket(aExpression: ref  string val_3 = 1197582204, aIndex:  val_2);
                val_57 = val_57;
            }
            while((val_57.IndexOf(value:  '(')) > 1);
            
                val_58 = val_57;
            }
            
            if((System.Linq.Enumerable.Contains<System.Char>(source:  val_58, value:  ',')) != false)
            {
                    mem[536881809] = 44;
                System.String[] val_6 = val_57.Split(separator:  536881793);
                val_59 = 536877973;
                val_59 = new System.Collections.Generic.List<SingleRange>(capacity:  aExpression + 12);
                if((aExpression + 12) >= 1)
            {
                    string val_8 = val_57 + 16;
                var val_61 = 0;
                val_60 = 4.021284E-38f;
                do
            {
                string val_9 = (aExpression + 16) + 0.Trim();
                val_57 = (aExpression + 16) + 0;
                if((System.String.IsNullOrEmpty(value:  (aExpression + 16) + 0)) != true)
            {
                    val_57 = this;
                val_59.Add(item:  1197594256);
            }
            
                val_61 = val_61 + 1;
            }
            while(val_61 < (aExpression + 12));
            
            }
            
                T[] val_11 = val_59.ToArray();
                B83.ExpressionParserBigInteger.MultiParameterList val_12 = 536890865;
                val_61 = val_12;
                val_12 = new B83.ExpressionParserBigInteger.MultiParameterList(aValues:  536877973);
                return;
            }
            
            if((System.Linq.Enumerable.Contains<System.Char>(source:  val_57, value:  '+')) == false)
            {
                goto label_20;
            }
            
            mem[536881809] = 43;
            System.String[] val_14 = val_57.Split(separator:  536881793);
            val_59 = val_57;
            val_62 = 536877973;
            val_62 = new System.Collections.Generic.List<SingleRange>(capacity:  aExpression + 12);
            if((aExpression + 12) < 1)
            {
                goto label_45;
            }
            
            string val_16 = val_59 + 16;
            var val_62 = 0;
            val_60 = 4.021284E-38f;
            do
            {
                string val_17 = (aExpression + 16) + 0.Trim();
                val_57 = (aExpression + 16) + 0;
                if((System.String.IsNullOrEmpty(value:  (aExpression + 16) + 0)) != true)
            {
                    val_57 = this;
                val_62.Add(item:  1197594256);
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
            val_62 = 536877973;
            val_62 = new System.Collections.Generic.List<SingleRange>(capacity:  aExpression + 12);
            val_57 = mem[aExpression + 16];
            val_57 = aExpression + 16;
            string val_22 = val_57.Trim();
            if((System.String.IsNullOrEmpty(value:  val_57)) != true)
            {
                    val_57 = this;
                val_62.Add(item:  1197594256);
            }
            
            if((aExpression + 12) >= 2)
            {
                    val_60 = 4.021284E-38f;
                do
            {
                string val_24 = aExpression + 20.Trim();
                val_57 = aExpression + 20;
                if((System.String.IsNullOrEmpty(value:  aExpression + 20)) != true)
            {
                    B83.ExpressionParserBigInteger.OperationNegate val_26 = 536891361;
                val_57 = val_26;
                val_26 = new B83.ExpressionParserBigInteger.OperationNegate(aValue:  1197594256);
                val_62.Add(item:  536891361);
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
            
            if(mem[536877985] == 1)
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
            val_61 = mem[mem[536877981] + 16];
            val_61 = mem[536877981] + 16;
            return;
            label_55:
            T[] val_29 = val_62.ToArray();
            B83.ExpressionParserBigInteger.OperationSum val_30 = 536891377;
            val_61 = val_30;
            val_30 = new B83.ExpressionParserBigInteger.OperationSum(aValues:  536877973);
            return;
            label_33:
            if((System.Linq.Enumerable.Contains<System.Char>(source:  val_57, value:  '*')) == false)
            {
                goto label_59;
            }
            
            val_59 = 536881793;
            mem[536881809] = 42;
            System.String[] val_32 = val_57.Split(separator:  536881793);
            536877973 = new System.Collections.Generic.List<SingleRange>(capacity:  aExpression + 12);
            if((aExpression + 12) >= 1)
            {
                    string val_34 = val_57 + 16;
                val_60 = 4.021284E-38f;
                do
            {
                val_57 = this;
                536877973.Add(item:  1197594256);
                val_59 = 0 + 1;
            }
            while(val_59 < (aExpression + 12));
            
            }
            
            if(536877973 == 0)
            {
                goto label_69;
            }
            
            if(mem[536877985] == 1)
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
            536877973 = new System.Collections.Generic.List<SingleRange>(capacity:  aExpression + 12);
            val_57 = mem[aExpression + 16];
            val_57 = aExpression + 16;
            string val_38 = val_57.Trim();
            if((System.String.IsNullOrEmpty(value:  val_57)) != true)
            {
                    val_57 = this;
                536877973.Add(item:  1197594256);
            }
            
            if((aExpression + 12) >= 2)
            {
                    val_60 = 4.021284E-38f;
                do
            {
                string val_40 = aExpression + 20.Trim();
                val_57 = aExpression + 20;
                if((System.String.IsNullOrEmpty(value:  aExpression + 20)) != true)
            {
                    val_59 = this;
                B83.ExpressionParserBigInteger.OperationReciprocal val_42 = 536891373;
                val_57 = val_42;
                val_42 = new B83.ExpressionParserBigInteger.OperationReciprocal(aValue:  1197594256);
                536877973.Add(item:  536891373);
            }
            
                var val_43 = 5 + 1;
            }
            while((5 - 3) < (aExpression + 12));
            
            }
            
            val_63 = -1073714383;
            val_64 = 536877973;
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
            B83.ExpressionParserBigInteger.OperationPower val_50 = 536891365;
            val_61 = val_50;
            val_50 = new B83.ExpressionParserBigInteger.OperationPower(aValue:  1197594256, aPower:  1197594256);
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
            val_63 = -1073714383;
            val_64 = 536877973;
            label_92:
            T[] val_51 = val_64.ToArray();
            B83.ExpressionParserBigInteger.OperationProduct val_52 = 536891369;
            val_61 = val_52;
            val_52 = new B83.ExpressionParserBigInteger.OperationProduct(aValues:  536877973);
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
            mem[536882067] = this;
            val_65 = 1284;
            536885533 = new B83.ExpressionParserBigInteger.CustomFunction(aName:  null, aDelegate:  R7, aValues:  536882051);
            goto label_118;
            label_106:
            val_65 = 955;
            label_118:
            0.Dispose();
            if(955 != 955)
            {
                    if(955 != 1284)
            {
                goto label_121;
            }
            
            }
        
        }
        private bool ValidIdentifier(string aExpression)
        {
            char val_9 = 22968908;
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
        public B83.ExpressionParserBigInteger.Expression EvaluateExpression(string aExpression)
        {
            B83.ExpressionParserBigInteger.Expression val_1 = 536886641;
            val_1 = new B83.ExpressionParserBigInteger.Expression();
            this.m_Context = val_1;
            B83.ExpressionParserBigInteger.IValue val_2 = this.Parse(aExpression:  aExpression);
            mem[536886653] = this;
            this.m_Context = 0;
            this.m_BracketHeap.Clear();
        }
        public AFramework.BigInteger Evaluate(string aExpression)
        {
            B83.ExpressionParserBigInteger.Expression val_1 = this.EvaluateExpression(aExpression:  aExpression);
            if(this != 0)
            {
                    return this.Value;
            }
            
            return this.Value;
        }
        public static AFramework.BigInteger Eval(string aExpression)
        {
            B83.ExpressionParserBigInteger.ExpressionParser val_1 = 536886653;
            val_1 = new B83.ExpressionParserBigInteger.ExpressionParser();
            if(val_1 != 0)
            {
                    return this.Evaluate(aExpression:  aExpression);
            }
            
            return this.Evaluate(aExpression:  aExpression);
        }
    
    }

}
