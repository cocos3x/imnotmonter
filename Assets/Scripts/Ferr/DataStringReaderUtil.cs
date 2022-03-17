using UnityEngine;

namespace Ferr
{
    public class DataStringReaderUtil
    {
        // Fields
        private Ferr.DataStringType _type;
        private string[] _words;
        private string[] _names;
        private int _curr;
        
        // Properties
        public int NameCount { get; }
        public bool HasNext { get; }
        
        // Methods
        public int get_NameCount()
        {
            if(this._names != null)
            {
                    return (int)this;
            }
            
            return (int)this;
        }
        public bool get_HasNext()
        {
            if(this._curr < R1)
            {
                    0 = 1;
            }
            
            return true;
        }
        public DataStringReaderUtil(string aData, Ferr.DataStringType aType)
        {
            Ferr.DataStringType val_9;
            System.String[] val_10;
            System.String[] val_11;
            var val_12;
            val_9 = aType;
            System.Collections.Generic.List<System.String> val_1 = Ferr.DataStringUtil.SplitSmart(aData:  aData, aSeparator:  ',');
            if(aData == null)
            {
                goto label_3;
            }
            
            val_10 = aData;
            this._type = val_9;
            if((System.String.IsNullOrEmpty(value:  aData)) != false)
            {
                    val_11 = 536882401;
            }
            else
            {
                    val_11 = val_10;
                T[] val_3 = val_11.ToArray();
            }
            
            this._words = val_11;
            if(this._type != 1)
            {
                    return;
            }
            
            this._names = 536882401;
            val_12 = 0;
            goto label_8;
            label_27:
            int val_4 = mem[aData + 12] + 16.IndexOf(value:  ':');
            string val_5 = mem[aData + 12] + 16.Substring(startIndex:  0, length:  val_4);
            val_9 = mem[aData + 12] + 16;
            string val_7 = mem[aData + 12] + 16.Substring(startIndex:  val_4 + 1);
            val_10 = mem[aData + 12] + 16;
            mem2[0] = val_10;
            mem2[0] = val_9;
            val_12 = 1;
            label_8:
            if(val_12 < (mem[aData + 12]))
            {
                goto label_27;
            }
            
            return;
            label_3:
            22709196 = new System.ArgumentException(message:  22791740);
        }
        public string GetName(int aIndex)
        {
            string val_1 = this._names[aIndex];
        }
        public int Int()
        {
            string val_1 = this.Read();
            return System.Int32.Parse(s:  1218700144);
        }
        public int Int(string aName)
        {
            string val_1 = this.Read(aName:  aName);
            return System.Int32.Parse(s:  1218816240);
        }
        public long Long()
        {
            string val_1 = this.Read();
            return System.Int64.Parse(s:  1218932336);
        }
        public long Long(string aName)
        {
            string val_1 = this.Read(aName:  aName);
            return System.Int64.Parse(s:  1219048432);
        }
        public bool Bool()
        {
            string val_1 = this.Read();
            if((mem[536884400] & true) != 0)
            {
                    return System.Boolean.Parse(value:  1219164528);
            }
            
            if(mem[536884329] != 0)
            {
                    return System.Boolean.Parse(value:  1219164528);
            }
            
            return System.Boolean.Parse(value:  1219164528);
        }
        public bool Bool(string aName)
        {
            string val_1 = this.Read(aName:  aName);
            if((mem[536884400] & true) != 0)
            {
                    return System.Boolean.Parse(value:  1219280624);
            }
            
            if(mem[536884329] != 0)
            {
                    return System.Boolean.Parse(value:  1219280624);
            }
            
            return System.Boolean.Parse(value:  1219280624);
        }
        public float Float()
        {
            string val_1 = this.Read();
            return System.Single.Parse(s:  1219396720);
        }
        public float Float(string aName)
        {
            string val_1 = this.Read(aName:  aName);
            return System.Single.Parse(s:  1219512816);
        }
        public string String()
        {
            return this.Read();
        }
        public string String(string aName)
        {
            return this.Read(aName:  aName);
        }
        public object Data()
        {
            string val_1 = this.Read();
            return this.CreateObject(aDataString:  1219861104);
        }
        public object Data(string aName)
        {
            string val_1 = this.Read(aName:  aName);
            return this.CreateObject(aDataString:  1219977200);
        }
        public void Data(ref Ferr.IToFromDataString aBaseObject)
        {
            var val_7;
            var val_8;
            string val_1 = this.Read();
            if(this != 0)
            {
                    val_7 = this.IndexOf(value:  '=');
            }
            else
            {
                    val_7 = 0.IndexOf(value:  '=');
            }
            
            string val_5 = this.Substring(startIndex:  val_7 + 1);
            var val_7 = mem[aBaseObject];
            if((mem[aBaseObject] + 178) == 0)
            {
                goto label_4;
            }
            
            val_7 = 0;
            label_6:
            if((mem[aBaseObject] + 88 + 0) == 536888789)
            {
                goto label_5;
            }
            
            val_7 = val_7 + 1;
            if(((uint)val_7 & 65535) < (mem[aBaseObject] + 178))
            {
                goto label_6;
            }
            
            label_4:
            val_8 = aBaseObject;
            goto ((mem[aBaseObject] + ((mem[aBaseObject] + 88 + 0) + 4) << 3) + 196);
            label_5:
            var val_6 = (mem[aBaseObject] + 88) + 0;
            val_7 = val_7 + (((mem[aBaseObject] + 88 + 0) + 4) << 3);
            val_8 = val_7 + 196;
            goto ((mem[aBaseObject] + ((mem[aBaseObject] + 88 + 0) + 4) << 3) + 196);
        }
        public void Data(string aName, ref Ferr.IToFromDataString aBaseObject)
        {
            var val_7;
            var val_8;
            var val_9;
            val_7 = 22969423;
            string val_1 = this.Read(aName:  aName);
            if(this != 0)
            {
                    val_8 = this.IndexOf(value:  '=');
            }
            else
            {
                    val_8 = 0.IndexOf(value:  '=');
            }
            
            string val_5 = this.Substring(startIndex:  val_8 + 1);
            var val_7 = mem[aBaseObject];
            if((mem[aBaseObject] + 178) == 0)
            {
                goto label_4;
            }
            
            val_8 = 0;
            label_6:
            val_7 = 0;
            if((mem[aBaseObject] + 88 + 0) == 536888789)
            {
                goto label_5;
            }
            
            val_8 = val_8 + 1;
            val_7 = (uint)val_8 & 65535;
            if(val_7 < (mem[aBaseObject] + 178))
            {
                goto label_6;
            }
            
            label_4:
            val_9 = aBaseObject;
            goto ((mem[aBaseObject] + ((mem[aBaseObject] + 88 + 0) + 4) << 3) + 196);
            label_5:
            var val_6 = (mem[aBaseObject] + 88) + 0;
            val_7 = val_7 + (((mem[aBaseObject] + 88 + 0) + 4) << 3);
            val_9 = val_7 + 196;
            goto ((mem[aBaseObject] + ((mem[aBaseObject] + 88 + 0) + 4) << 3) + 196);
        }
        private string Read(string aName)
        {
            string val_5 = aName;
            if(this._type == 0)
            {
                goto label_1;
            }
            
            int val_1 = System.Array.IndexOf<System.String>(array:  this._names, value:  val_5 = aName);
            if(val_1 == 1)
            {
                goto label_2;
            }
            
            string val_5 = this._words[val_1];
            return;
            label_1:
            val_5 = 22710780;
            val_5 = new System.Exception(message:  22782988);
            label_2:
            string val_3 = 22782996 + 22710780;
            22710780 = new System.Exception(message:  22782996);
        }
        private string Read()
        {
            System.Exception val_2;
            var val_3;
            if(this._type == 1)
            {
                goto label_0;
            }
            
            if(this._curr >= this._type)
            {
                goto label_2;
            }
            
            int val_3 = this._curr;
            string val_2 = this._words[this._curr];
            val_3 = val_3 + 1;
            this._curr = val_3;
            return;
            label_0:
            val_2 = 22710780;
            val_3 = 22782992;
            goto label_5;
            label_2:
            val_2 = 22710780;
            val_3 = 22792236;
            label_5:
            val_2 = new System.Exception(message:  22792236);
        }
        private object CreateObject(string aDataString)
        {
            var val_14;
            int val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            val_14 = 0;
            if((System.String.IsNullOrEmpty(value:  aDataString)) == true)
            {
                    return;
            }
            
            val_14 = 0;
            if((System.String.op_Equality(a:  aDataString, b:  -1610599037)) == true)
            {
                    return;
            }
            
            if(aDataString != null)
            {
                    val_15 = aDataString.IndexOf(value:  '=');
                string val_4 = aDataString.Substring(startIndex:  0, length:  val_15);
                val_16 = aDataString;
            }
            else
            {
                    val_15 = 0.IndexOf(value:  '=');
                string val_6 = 0.Substring(startIndex:  0, length:  val_15);
                val_16 = 0;
            }
            
            string val_8 = aDataString.Substring(startIndex:  val_15 + 1);
            val_17 = 1610619069;
            val_14 = 0;
            System.Type val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073759701)});
            val_18 = 1073759701;
            if(val_18 == 0)
            {
                    return;
            }
            
            System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073764275)});
            if(1073764275 != 0)
            {
                    val_19 = val_17;
                UnityEngine.ScriptableObject val_11 = UnityEngine.ScriptableObject.CreateInstance(type:  1610619069);
            }
            else
            {
                    val_19 = val_17;
                object val_12 = System.Activator.CreateInstance(type:  1610619069);
            }
            
            val_14 = val_19;
            if(val_19 != 0)
            {
                    if(val_14 != 0)
            {
                goto label_15;
            }
            
            }
            
            label_15:
            val_18 = 536888789;
            if(val_14 == 0)
            {
                goto label_16;
            }
            
            val_17 = val_14;
            if((mem[1610619069] + 178) == 0)
            {
                goto label_17;
            }
            
            var val_14 = 0;
            label_19:
            if((mem[1610619069] + 88 + 0) == val_18)
            {
                goto label_18;
            }
            
            val_14 = val_14 + 1;
            if(((uint)val_14 & 65535) < (mem[1610619069] + 178))
            {
                goto label_19;
            }
            
            label_17:
            val_20 = val_17;
            return;
            label_18:
            var val_13 = (mem[1610619069] + 88) + 0;
            var val_15 = (mem[1610619069] + 88 + 0) + 4;
            val_15 = mem[1610619069] + (val_15 << 3);
            val_20 = val_15 + 196;
            return;
            label_16:
        }
    
    }

}
