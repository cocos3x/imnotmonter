using UnityEngine;

namespace Ferr
{
    public class DataStringWriterUtil
    {
        // Fields
        private Ferr.DataStringType _type;
        private System.Text.StringBuilder _builder;
        private System.Collections.Generic.HashSet<string> _names;
        
        // Methods
        public DataStringWriterUtil(Ferr.DataStringType aType)
        {
            536875743 = new System.Collections.Generic.HashSet<UnityEngine.UI.Text>();
            this._names = 536875743;
            this._type = aType;
            System.Text.StringBuilder val_2 = 536894635;
            val_2 = new System.Text.StringBuilder();
            this._builder = val_2;
            System.Text.StringBuilder val_3 = this._builder.Append(value:  '{');
        }
        public void Int(int aData)
        {
            string val_1 = aData.ToString();
            this.Entry(aData:  1215981180);
        }
        public void Int(string aName, int aData)
        {
            string val_1 = aData.ToString();
            this.Entry(aName:  aName, aData:  1216097276);
        }
        public void Long(long aData)
        {
            string val_1 = ToString();
            this.Entry(aData:  1216213368);
        }
        public void Long(string aName, long aData)
        {
            string val_1 = aData.ToString();
            this.Entry(aName:  aName, aData:  1216329464);
        }
        public void Bool(bool aData)
        {
            string val_1 = aData.ToString();
            this.Entry(aData:  1216445567);
        }
        public void Bool(string aName, bool aData)
        {
            string val_1 = aData.ToString();
            this.Entry(aName:  aName, aData:  1216561663);
        }
        public void Float(float aData)
        {
            string val_1 = ???.ToString();
            this.Entry(aData:  1216677756);
        }
        public void Float(string aName, float aData)
        {
            string val_1 = ???.ToString();
            this.Entry(aName:  aName, aData:  1216793852);
        }
        public void Data(Ferr.IToFromDataString aData)
        {
            string val_4;
            var val_5;
            var val_6;
            string val_7;
            val_4 = 22969431;
            if(aData == 0)
            {
                goto label_1;
            }
            
            System.Type val_1 = aData.GetType();
            val_4 = aData;
            var val_4 = 0;
            val_5 = 0;
            val_4 = val_4 + 1;
            val_5 = (uint)val_4 & 65535;
            val_6 = aData;
            goto label_6;
            label_1:
            val_7 = -1610599037;
            goto label_7;
            label_6:
            string val_3 = val_4 + -1610610515(-1610610515) + aData;
            val_7 = val_4;
            label_7:
            this.Entry(aData:  val_7);
        }
        public void Data(string aName, Ferr.IToFromDataString aData)
        {
            string val_4;
            var val_5;
            string val_6;
            val_4 = 22969432;
            if(aData == 0)
            {
                goto label_1;
            }
            
            System.Type val_1 = aData.GetType();
            val_4 = aData;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_5 = aData;
            goto label_6;
            label_1:
            val_6 = -1610599037;
            goto label_7;
            label_6:
            string val_3 = val_4 + -1610610515(-1610610515) + aData;
            val_6 = val_4;
            label_7:
            this.Entry(aName:  aName, aData:  val_6);
        }
        public void String(string aData)
        {
            var val_5;
            char val_1 = this.GetQuoteType(aData:  aData);
            if(val_1 == ' ')
            {
                    val_5 = aData;
            }
            else
            {
                    string val_2 = val_1.ToString();
                string val_3 = val_1.ToString();
                string val_4 = 1217162614 + aData + 1217162614;
                val_5 = ;
            }
            
            this.Entry(aData:  1217162614);
        }
        public void String(string aName, string aData)
        {
            string val_5;
            var val_6;
            char val_1 = this.GetQuoteType(aData:  aData);
            if(val_1 == ' ')
            {
                    val_5 = aName;
                val_6 = aData;
            }
            else
            {
                    string val_2 = val_1.ToString();
                string val_3 = val_1.ToString();
                string val_4 = 1217286894 + aData + 1217286894;
                val_6 = ;
                val_5 = aName;
            }
            
            this.Entry(aName:  val_5, aData:  1217286894);
        }
        protected char GetQuoteType(string aData)
        {
            var val_8;
            var val_9;
            val_8 = 32;
            if((aData.StartsWith(value:  -1610597137)) == true)
            {
                    return 34;
            }
            
            if((aData.StartsWith(value:  -1610612241)) == true)
            {
                    return 34;
            }
            
            val_9 = 22778100;
            if((aData.StartsWith(value:  -1610612125)) == true)
            {
                    return 34;
            }
            
            if(aData != null)
            {
                    val_9 = aData.Contains(value:  -1610612125);
            }
            else
            {
                    val_9 = 0.Contains(value:  -1610612125);
            }
            
            if((aData.Contains(value:  -1610612241)) != true)
            {
                    if(val_9 == true)
            {
                    val_8 = 34;
            }
            
                return 34;
            }
            
            22709196 = new System.ArgumentException(message:  22793736);
        }
        protected void Entry(string aData)
        {
            System.Text.StringBuilder val_5;
            if(this._type != 1)
            {
                    val_5 = this._builder;
                if(val_5.Length >= 2)
            {
                    val_5 = this._builder;
                System.Text.StringBuilder val_2 = val_5.Append(value:  ',');
            }
            
                System.Text.StringBuilder val_3 = this._builder.Append(value:  aData);
                return;
            }
            
            22710780 = new System.Exception(message:  22790060);
        }
        protected void Entry(string aName, string aData)
        {
            var val_13;
            if(this._type == 0)
            {
                goto label_1;
            }
            
            if(((aName.Contains(value:  -1610610741)) == true) || ((aName.Contains(value:  -1610611911)) == true))
            {
                goto label_5;
            }
            
            if((this._names.Contains(item:  aName)) == true)
            {
                goto label_7;
            }
            
            bool val_4 = this._names.Add(item:  aName);
            if(this._builder.Length >= 2)
            {
                    System.Text.StringBuilder val_6 = this._builder.Append(value:  ',');
            }
            
            System.Text.StringBuilder val_7 = this._builder.Append(value:  aName);
            System.Text.StringBuilder val_8 = this._builder.Append(value:  -1610610741);
            System.Text.StringBuilder val_9 = this._builder.Append(value:  aData);
            return;
            label_5:
            val_13 = 22790020;
            goto label_15;
            label_1:
            22710780 = new System.Exception(message:  22790012);
            label_7:
            val_13 = 22796564;
            label_15:
            string val_11 = 22796564 + aName;
            22710780 = new System.Exception(message:  22796564);
        }
        public override string ToString()
        {
            if(this._builder != 0)
            {
                    return this._builder + -1610596933(-1610596933);
            }
            
            return this._builder + -1610596933(-1610596933);
        }
    
    }

}
