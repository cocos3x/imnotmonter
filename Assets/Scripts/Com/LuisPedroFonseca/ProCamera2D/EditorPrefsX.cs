using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public static class EditorPrefsX
    {
        // Fields
        private static int endianDiff1;
        private static int endianDiff2;
        private static int idx;
        private static byte[] byteBlock;
        
        // Methods
        public static bool SetBool(string name, bool value)
        {
            return true;
        }
        public static bool GetBool(string name)
        {
            return true;
        }
        public static bool GetBool(string name, bool defaultValue)
        {
            return true;
        }
        public static long GetLong(string key, long defaultValue)
        {
            return 0;
        }
        public static long GetLong(string key)
        {
            return 0;
        }
        private static void SplitLong(long input, out int lowBits, out int highBits)
        {
            lowBits = input;
            highBits = ;
        }
        public static void SetLong(string key, long value)
        {
        
        }
        public static bool SetVector2(string key, UnityEngine.Vector2 vector)
        {
            var val_1 = mem[536882369];
            if(val_1 == 0)
            {
                    val_1 = mem[536882369];
            }
            
            mem[536882373] = vector.x;
            mem[536882377] = vector.y;
            return Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.SetFloatArray(key:  key, floatArray:  536882357);
        }
        private static UnityEngine.Vector2 GetVector2(string key)
        {
            var val_3;
            var val_4;
            System.Single[] val_1 = Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.GetFloatArray(key:  R1);
            if((R1 + 12) > 1)
            {
                    val_3 = mem[R1 + 16];
                val_3 = R1 + 16;
                val_4 = mem[R1 + 20];
                val_4 = R1 + 20;
            }
            else
            {
                    UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            }
            
            mem2[0] = ???;
            mem2[0] = ???;
            return new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        }
        public static UnityEngine.Vector2 GetVector2(string key, UnityEngine.Vector2 defaultValue)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        public static bool SetVector3(string key, UnityEngine.Vector3 vector)
        {
            var val_1 = mem[536882369];
            if(val_1 == 0)
            {
                    val_1 = mem[536882369];
            }
            
            mem[536882373] = vector.x;
            if(val_1 <= 1)
            {
                    val_1 = mem[536882369];
            }
            
            mem[536882377] = vector.y;
            mem[536882381] = vector.z;
            return Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.SetFloatArray(key:  key, floatArray:  536882357);
        }
        public static UnityEngine.Vector3 GetVector3(string key)
        {
            float val_4;
            int val_5;
            System.Single[] val_1 = Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.GetFloatArray(key:  R1);
            if((R1 + 12) > 2)
            {
                    var val_2 = R1 + 16;
                return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            key.m_stringLength = val_5;
            mem2[0] = val_4;
            return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        public static UnityEngine.Vector3 GetVector3(string key, UnityEngine.Vector3 defaultValue)
        {
            float val_2;
            int val_3;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            key.m_stringLength = val_3;
            mem2[0] = val_2;
            return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        public static bool SetQuaternion(string key, UnityEngine.Quaternion vector)
        {
            var val_1 = mem[536882369];
            if(val_1 == 0)
            {
                    val_1 = mem[536882369];
            }
            
            mem[536882373] = vector.x;
            if(val_1 <= 1)
            {
                    val_1 = mem[536882369];
            }
            
            mem[536882377] = vector.y;
            if(val_1 <= 2)
            {
                    val_1 = mem[536882369];
            }
            
            mem[536882381] = vector.z;
            mem[536882385] = vector.w;
            return Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.SetFloatArray(key:  key, floatArray:  536882357);
        }
        public static UnityEngine.Quaternion GetQuaternion(string key)
        {
            System.Single[] val_1 = Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.GetFloatArray(key:  R1);
            if((R1 + 12) > 3)
            {
                    var val_2 = R1 + 16;
                key = new UnityEngine.Quaternion(x:  R1 + 28, y:  null, z:  null, w:  null);
                return new UnityEngine.Quaternion() {x = R1 + 28};
            }
            
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
            return new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
        }
        public static UnityEngine.Quaternion GetQuaternion(string key, UnityEngine.Quaternion defaultValue)
        {
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            return new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w};
        }
        public static bool SetColor(string key, UnityEngine.Color color)
        {
            var val_1 = mem[536882369];
            if(val_1 == 0)
            {
                    val_1 = mem[536882369];
            }
            
            mem[536882373] = color.r;
            if(val_1 <= 1)
            {
                    val_1 = mem[536882369];
            }
            
            mem[536882377] = color.g;
            if(val_1 <= 2)
            {
                    val_1 = mem[536882369];
            }
            
            mem[536882381] = color.b;
            mem[536882385] = color.a;
            return Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.SetFloatArray(key:  key, floatArray:  536882357);
        }
        public static UnityEngine.Color GetColor(string key)
        {
            System.Single[] val_1 = Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.GetFloatArray(key:  R1);
            if((R1 + 12) > 3)
            {
                    var val_2 = R1 + 16;
            }
            
            key = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            return new UnityEngine.Color();
        }
        public static UnityEngine.Color GetColor(string key, UnityEngine.Color defaultValue)
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            return new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        }
        public static bool SetBoolArray(string key, bool[] boolArray)
        {
            byte val_3;
            boolArray[7][(boolArray[7] >> 31) >> 29] = 5 + ((boolArray[7][(boolArray[7] >> 31) >> 29]) >> 3);
            val_3 = System.Convert.ToByte(value:  536898769);
            mem[536881757] = val_3;
            if(mem[536881753] >= 1)
            {
                    var val_5 = 0;
                var val_6 = 5;
                do
            {
                if(null != null)
            {
                    var val_3 = 536881741 + val_6;
                var val_4 = (536881741 + 5) + 16;
                val_4 = val_4 | 1;
                mem2[0] = val_4;
            }
            
                val_5 = val_5 + 1;
                if(0 < 129)
            {
                    1 = 0;
            }
            
                val_3 = 1;
                if(0 > 128)
            {
                    0 = 1;
            }
            
                val_6 = val_6 + 1;
            }
            while(val_5 < 1);
            
            }
            
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.Initialize();
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertInt32ToBytes(i:  1, bytes:  536881741);
            return true;
        }
        public static bool[] GetBoolArray(string key)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            string val_11;
            string val_7 = key;
            if((UnityEngine.PlayerPrefs.HasKey(key:  val_7)) == false)
            {
                goto label_1;
            }
            
            string val_2 = UnityEngine.PlayerPrefs.GetString(key:  val_7);
            System.Byte[] val_3 = System.Convert.FromBase64String(s:  val_7);
            if(key.m_firstChar <= '')
            {
                goto label_5;
            }
            
            if(key.m_firstChar != '')
            {
                goto label_6;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.Initialize();
            int val_4 = Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertBytesToInt32(bytes:  val_7);
            val_7 = 536881727;
            val_8 = 5;
            val_9 = 0;
            goto label_7;
            label_11:
            val_7 = 1 & (val_7 + val_8);
            if(key.m_firstChar != val_8)
            {
                    val_7 = 1;
            }
            
            mem[536881743] = 1;
            if(0 < 129)
            {
                    1 = 0;
            }
            
            if(0 > 128)
            {
                    0 = 1;
            }
            
            val_8 = 6;
            val_9 = 1;
            label_7:
            if(val_9 < mem[536881739])
            {
                goto label_11;
            }
            
            return;
            label_5:
            val_10 = val_7;
            val_11 = -1610609151;
            goto label_13;
            label_6:
            val_10 = -1610612345;
            val_11 = val_7;
            label_13:
            string val_6 = val_11 + -1610612345(-1610612345);
            UnityEngine.Debug.LogError(message:  val_11);
            label_1:
            val_7 = 536881727;
        }
        public static bool[] GetBoolArray(string key, bool defaultValue, int defaultSize)
        {
        
        }
        public static bool SetStringArray(string key, string[] stringArray)
        {
            return true;
        }
        public static string[] GetStringArray(string key)
        {
        
        }
        public static string[] GetStringArray(string key, string defaultValue, int defaultSize)
        {
        
        }
        public static bool SetIntArray(string key, int[] intArray)
        {
            536873469 = new System.Action<System.Object, System.Object, System.Int32>(object:  0, method:  new IntPtr(1610684335));
            return (bool)Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.SetValue<System.Object>(key:  key, array:  intArray, arrayType:  1, vectorNumber:  1, convert:  536873469);
        }
        public static bool SetFloatArray(string key, float[] floatArray)
        {
            536873473 = new System.Action<System.Object, System.Object, System.Int32>(object:  0, method:  new IntPtr(1610684337));
            return (bool)Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.SetValue<System.Object>(key:  key, array:  floatArray, arrayType:  0, vectorNumber:  1, convert:  536873473);
        }
        public static bool SetVector2Array(string key, UnityEngine.Vector2[] vector2Array)
        {
            536873475 = new System.Action<System.Object, System.Object, System.Int32>(object:  0, method:  new IntPtr(1610684339));
            return (bool)Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.SetValue<System.Object>(key:  key, array:  vector2Array, arrayType:  4, vectorNumber:  2, convert:  536873475);
        }
        public static bool SetVector3Array(string key, UnityEngine.Vector3[] vector3Array)
        {
            536873477 = new System.Action<System.Object, System.Object, System.Int32>(object:  0, method:  new IntPtr(1610684341));
            return (bool)Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.SetValue<System.Object>(key:  key, array:  vector3Array, arrayType:  5, vectorNumber:  3, convert:  536873477);
        }
        public static bool SetQuaternionArray(string key, UnityEngine.Quaternion[] quaternionArray)
        {
            536873471 = new System.Action<System.Object, System.Object, System.Int32>(object:  0, method:  new IntPtr(1610684343));
            return (bool)Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.SetValue<System.Object>(key:  key, array:  quaternionArray, arrayType:  6, vectorNumber:  4, convert:  536873471);
        }
        public static bool SetColorArray(string key, UnityEngine.Color[] colorArray)
        {
            536873467 = new System.Action<System.Object, System.Object, System.Int32>(object:  0, method:  new IntPtr(1610684345));
            return (bool)Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.SetValue<System.Object>(key:  key, array:  colorArray, arrayType:  7, vectorNumber:  4, convert:  536873467);
        }
        private static bool SetValue<T>(string key, T array, Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ArrayType arrayType, int vectorNumber, System.Action<T, byte[], int> convert)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_8 = 0;
            val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = (uint)val_8 & 65535;
            val_10 = array;
            int val_3 = vectorNumber * array;
            val_3 = 1 | (val_3 << 2);
            mem[536881757] = System.Convert.ToByte(value:  536898769);
            val_11 = 0;
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.Initialize();
            goto label_10;
            label_17:
            val_11 = 1;
            label_10:
            val_9 = 0;
            val_8 = 0;
            val_9 = val_9 + 1;
            val_8 = (uint)val_9 & 65535;
            val_12 = array;
            if(val_11 < array)
            {
                goto label_17;
            }
            
            return (bool)Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.SaveBytes(key:  key, bytes:  536881741);
        }
        private static void ConvertFromInt(int[] array, byte[] bytes, int i)
        {
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertInt32ToBytes(i:  array[i], bytes:  bytes);
        }
        private static void ConvertFromFloat(float[] array, byte[] bytes, int i)
        {
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i]);
        }
        private static void ConvertFromVector2(UnityEngine.Vector2[] array, byte[] bytes, int i)
        {
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 3]);
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 3]);
        }
        private static void ConvertFromVector3(UnityEngine.Vector3[] array, byte[] bytes, int i)
        {
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i + (i << 1)]);
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i + (i << 1)]);
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i + (i << 1)]);
        }
        private static void ConvertFromQuaternion(UnityEngine.Quaternion[] array, byte[] bytes, int i)
        {
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
        }
        private static void ConvertFromColor(UnityEngine.Color[] array, byte[] bytes, int i)
        {
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
        }
        public static int[] GetIntArray(string key)
        {
            536877987 = new System.Collections.Generic.List<System.Int32>();
            536873387 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(1610684373));
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.GetValue<System.Object>(key:  key, list:  536877987, arrayType:  1, vectorNumber:  1, convert:  536873387);
            if(536877987 != 0)
            {
                    return 536877987.ToArray();
            }
            
            return 536877987.ToArray();
        }
        public static int[] GetIntArray(string key, int defaultValue, int defaultSize)
        {
        
        }
        public static float[] GetFloatArray(string key)
        {
            536878291 = new System.Collections.Generic.List<System.Single>();
            536873391 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(1610684375));
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.GetValue<System.Object>(key:  key, list:  536878291, arrayType:  0, vectorNumber:  1, convert:  536873391);
            if(536878291 != 0)
            {
                    return 536878291.ToArray();
            }
            
            return 536878291.ToArray();
        }
        public static float[] GetFloatArray(string key, float defaultValue, int defaultSize)
        {
        
        }
        public static UnityEngine.Vector2[] GetVector2Array(string key)
        {
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            536873393 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(1610684377));
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.GetValue<System.Object>(key:  key, list:  536878507, arrayType:  4, vectorNumber:  2, convert:  536873393);
            if(536878507 != 0)
            {
                    return 536878507.ToArray();
            }
            
            return 536878507.ToArray();
        }
        public static UnityEngine.Vector2[] GetVector2Array(string key, UnityEngine.Vector2 defaultValue, int defaultSize)
        {
        
        }
        public static UnityEngine.Vector3[] GetVector3Array(string key)
        {
            536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            536873395 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(1610684379));
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.GetValue<System.Object>(key:  key, list:  536878517, arrayType:  5, vectorNumber:  3, convert:  536873395);
            if(536878517 != 0)
            {
                    return 536878517.ToArray();
            }
            
            return 536878517.ToArray();
        }
        public static UnityEngine.Vector3[] GetVector3Array(string key, UnityEngine.Vector3 defaultValue, int defaultSize)
        {
        
        }
        public static UnityEngine.Quaternion[] GetQuaternionArray(string key)
        {
            536878207 = new System.Collections.Generic.List<UnityEngine.Quaternion>();
            536873389 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(1610684381));
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.GetValue<System.Object>(key:  key, list:  536878207, arrayType:  6, vectorNumber:  4, convert:  536873389);
            if(536878207 != 0)
            {
                    return 536878207.ToArray();
            }
            
            return 536878207.ToArray();
        }
        public static UnityEngine.Quaternion[] GetQuaternionArray(string key, UnityEngine.Quaternion defaultValue, int defaultSize)
        {
        
        }
        public static UnityEngine.Color[] GetColorArray(string key)
        {
            536877805 = new System.Collections.Generic.List<UnityEngine.Color>();
            536873385 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(1610684383));
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.GetValue<System.Object>(key:  key, list:  536877805, arrayType:  7, vectorNumber:  4, convert:  536873385);
            if(536877805 != 0)
            {
                    return 536877805.ToArray();
            }
            
            return 536877805.ToArray();
        }
        public static UnityEngine.Color[] GetColorArray(string key, UnityEngine.Color defaultValue, int defaultSize)
        {
        
        }
        private static void GetValue<T>(string key, T list, Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ArrayType arrayType, int vectorNumber, System.Action<T, byte[]> convert)
        {
        
        }
        private static void ConvertToInt(System.Collections.Generic.List<int> list, byte[] bytes)
        {
            list.Add(item:  Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertBytesToInt32(bytes:  bytes));
        }
        private static void ConvertToFloat(System.Collections.Generic.List<float> list, byte[] bytes)
        {
            list.Add(item:  Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertBytesToFloat(bytes:  bytes));
        }
        private static void ConvertToVector2(System.Collections.Generic.List<UnityEngine.Vector2> list, byte[] bytes)
        {
            float val_1 = Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertBytesToFloat(bytes:  bytes);
            float val_2 = Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertBytesToFloat(bytes:  bytes);
            list.Add(item:  new UnityEngine.Vector2() {x = bytes, y = bytes});
        }
        private static void ConvertToVector3(System.Collections.Generic.List<UnityEngine.Vector3> list, byte[] bytes)
        {
            float val_1 = Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertBytesToFloat(bytes:  bytes);
            float val_2 = Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertBytesToFloat(bytes:  bytes);
            float val_3 = Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertBytesToFloat(bytes:  bytes);
            list.Add(item:  new UnityEngine.Vector3() {x = bytes, y = bytes, z = bytes});
        }
        private static void ConvertToQuaternion(System.Collections.Generic.List<UnityEngine.Quaternion> list, byte[] bytes)
        {
            float val_1 = Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertBytesToFloat(bytes:  bytes);
            float val_2 = Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertBytesToFloat(bytes:  bytes);
            float val_3 = Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertBytesToFloat(bytes:  bytes);
            UnityEngine.Quaternion val_5 = new UnityEngine.Quaternion(x:  Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertBytesToFloat(bytes:  bytes), y:  null, z:  null, w:  null);
            list.Add(item:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w});
        }
        private static void ConvertToColor(System.Collections.Generic.List<UnityEngine.Color> list, byte[] bytes)
        {
            float val_1 = Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertBytesToFloat(bytes:  bytes);
            float val_2 = Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertBytesToFloat(bytes:  bytes);
            float val_3 = Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertBytesToFloat(bytes:  bytes);
            UnityEngine.Color val_5 = new UnityEngine.Color(r:  Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertBytesToFloat(bytes:  bytes), g:  null, b:  null, a:  null);
            list.Add(item:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
        }
        public static void ShowArrayType(string key)
        {
        
        }
        private static void Initialize()
        {
            var val_1;
            var val_2;
            val_1 = 536884165;
            if(((mem[536884352] & true) == 0) && (mem[536884281] == 0))
            {
                    val_1 = 536884165;
            }
            
            var val_1 = mem[536884257];
            if(val_1 == 0)
            {
                    0 = 3;
            }
            
            val_1 = val_1 ^ 1;
            mem2[0] = 3;
            mem2[0] = val_1;
            val_2 = mem[536886317];
            if((mem[536886317] + 12) == 0)
            {
                    mem2[0] = 536881741;
                val_2 = mem[536886317];
            }
            
            mem2[0] = 1;
        }
        private static bool SaveBytes(string key, byte[] bytes)
        {
            return true;
        }
        private static void ConvertFloatToBytes(float f, byte[] bytes)
        {
            System.Byte[] val_1 = System.BitConverter.GetBytes(value:  f);
            mem2[0] = bytes;
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertTo4Bytes(bytes:  R1);
        }
        private static float ConvertBytesToFloat(byte[] bytes)
        {
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertFrom4Bytes(bytes:  bytes);
            if((mem[536884352] & true) != 0)
            {
                    return System.BitConverter.ToSingle(value:  mem[536886317] + 12, startIndex:  0);
            }
            
            if(mem[536884281] != 0)
            {
                    return System.BitConverter.ToSingle(value:  mem[536886317] + 12, startIndex:  0);
            }
            
            return System.BitConverter.ToSingle(value:  mem[536886317] + 12, startIndex:  0);
        }
        private static void ConvertInt32ToBytes(int i, byte[] bytes)
        {
            System.Byte[] val_1 = System.BitConverter.GetBytes(value:  i);
            mem2[0] = i;
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertTo4Bytes(bytes:  bytes);
        }
        private static int ConvertBytesToInt32(byte[] bytes)
        {
            Com.LuisPedroFonseca.ProCamera2D.EditorPrefsX.ConvertFrom4Bytes(bytes:  bytes);
            if((mem[536884352] & true) != 0)
            {
                    return System.BitConverter.ToInt32(value:  mem[536886317] + 12, startIndex:  0);
            }
            
            if(mem[536884281] != 0)
            {
                    return System.BitConverter.ToInt32(value:  mem[536886317] + 12, startIndex:  0);
            }
            
            return System.BitConverter.ToInt32(value:  mem[536886317] + 12, startIndex:  0);
        }
        private static void ConvertTo4Bytes(byte[] bytes)
        {
            var val_1 = (mem[536886317] + 12) + mem[536886317];
            bytes[mem[536886317] + 8] = (mem[536886317] + 12 + mem[536886317]) + 16;
            var val_3 = (mem[mem[536886317] + (12)]) + ((mem[mem[536886317] + (4)]) + 1);
            bytes[(mem[mem[536886317] + (8)]) + 1] = (mem[mem[536886317] + (12)] + (mem[mem[536886317] + (4)] + 1)) + 16;
            var val_6 = (mem[mem[536886317] + (12)]) + (2 - (mem[mem[536886317] + (4)]));
            bytes[(mem[mem[536886317] + (8)]) + 2] = (mem[mem[536886317] + (12)] + (2 - mem[mem[536886317] + (4)])) + 16;
            var val_9 = mem[536886317];
            var val_10 = mem[536886317] + 8;
            val_9 = 3 - val_9;
            var val_8 = (mem[536886317] + 12) + val_9;
            val_10 = val_10 + 3;
            bytes[val_10] = (mem[536886317] + 12 + (3 - mem[536886317])) + 16;
            var val_11 = mem[536886317] + 8;
            val_11 = val_11 + 4;
            mem2[0] = val_11;
        }
        private static void ConvertFrom4Bytes(byte[] bytes)
        {
            var val_1 = (mem[536886317] + 12) + mem[536886317];
            mem2[0] = bytes[mem[536886317] + 8];
            var val_11 = mem[536886317] + 4;
            val_11 = val_11 + 1;
            var val_3 = (mem[536886317] + 12) + val_11;
            mem2[0] = bytes[(mem[536886317] + 8) + 1];
            var val_13 = mem[536886317] + 4;
            val_13 = 2 - val_13;
            var val_5 = (mem[536886317] + 12) + val_13;
            mem2[0] = bytes[(mem[536886317] + 8) + 2];
            var val_8 = (mem[536886317] + 12) + (3 - mem[536886317]);
            mem2[0] = bytes[(mem[536886317] + 8) + 3];
            var val_15 = mem[536886317] + 8;
            val_15 = val_15 + 4;
            mem2[0] = val_15;
        }
    
    }

}
