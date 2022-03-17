using UnityEngine;

namespace Dmobin
{
    public static class Utility
    {
        // Fields
        private static int sVersionNumber;
        private static string sDeviceUDID;
        private static string sSavePath;
        private static bool sLastInternetState;
        private static float sLastInternetCheckTime;
        
        // Methods
        public static string TimeFormat(float time)
        {
            int val_1 = UnityEngine.Mathf.CeilToInt(f:  time);
            var val_2 = R6 + 3758096340;
            string val_3 = System.String.Format(format:  -1610597101, arg0:  536888987, arg1:  536888987, arg2:  536888987);
        }
        public static System.DateTime GetCurrentTime()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            mem2[0] = ???;
            return new System.DateTime();
        }
        public static System.DateTime GetCurrentDate()
        {
            System.DateTime val_1 = Dmobin.Utility.GetCurrentTime();
            System.DateTime val_2 = Date;
            mem2[0] = ???;
            return new System.DateTime();
        }
        public static double GetCurrentTimeMillisecond()
        {
            var val_2;
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.TimeSpan val_4 = Subtract(value:  new System.DateTime() {dateData = 1152921510042088984});
            return (double)val_2.TotalMilliseconds;
        }
        public static double GetCurrentTimeSecond()
        {
            var val_2;
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.TimeSpan val_4 = Subtract(value:  new System.DateTime() {dateData = 1152921510042200984});
            return (double)val_2.TotalSeconds;
        }
        public static float Lerp(float value1, float value2, float amount)
        {
            var val_1 = R1;
            val_1 = val_1 - 0;
            return (float)0;
        }
        public static int GetVersionNumber()
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_4 = 536896541;
            if(((mem[536896728] & true) == 0) && (mem[536896657] == 0))
            {
                    val_4 = 536896541;
            }
            
            if(mem[536896633] <= 1)
            {
                    string val_1 = UnityEngine.Application.version;
                mem[536881809] = 46;
                val_5 = 0;
                System.String[] val_2 = 0.Split(separator:  536881793);
                val_6 = 536896541;
                if(((mem[536896728] & true) == 0) && (mem[536896657] == 0))
            {
                    val_6 = 536896541;
            }
            
                mem2[0] = val_5;
                if((0 - 1) >= 0)
            {
                    var val_4 = 0 + 3;
                do
            {
                val_7 = 536896541;
                var val_5 = val_4 - 4;
                if(((mem[536896728] & true) == 0) && (mem[536896657] == 0))
            {
                    val_7 = 536896541;
            }
            
                mem2[0] = System.Int32.Parse(s:  0 + ((0 + 3)) << 2);
                var val_8 = val_4 - 1;
                val_5 = (1 + 4) << 1;
            }
            while((val_4 - 5) > 1);
            
            }
            
            }
            
            val_8 = 536896541;
            if((mem[536896728] & true) != 0)
            {
                    return (int)mem[536896633];
            }
            
            if(mem[536896657] != 0)
            {
                    return (int)mem[536896633];
            }
            
            val_8 = 536896541;
            return (int)mem[536896633];
        }
        public static string GetUDID()
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = 536896541;
            if(((mem[536896728] & true) == 0) && (mem[536896657] == 0))
            {
                    val_2 = 536896541;
            }
            
            if((mem[536896633] + 4 + 8) <= 0)
            {
                    string val_1 = UnityEngine.SystemInfo.deviceUniqueIdentifier;
                val_3 = 536896541;
                if(((mem[536896728] & true) == 0) && (mem[536896657] == 0))
            {
                    val_3 = 536896541;
            }
            
                mem2[0] = 0;
            }
            
            val_4 = 536896541;
            if((mem[536896728] & true) != 0)
            {
                    return;
            }
            
            if(mem[536896657] != 0)
            {
                    return;
            }
            
            val_4 = 536896541;
        }
        public static string GetSavePath()
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = 536896541;
            if(((mem[536896728] & true) == 0) && (mem[536896657] == 0))
            {
                    val_3 = 536896541;
            }
            
            if((mem[536896633] + 8 + 8) <= 0)
            {
                    string val_1 = UnityEngine.Application.persistentDataPath;
                string val_2 = null + -1610611739(-1610611739);
                val_4 = 536896541;
                if(((mem[536896728] & true) == 0) && (mem[536896657] == 0))
            {
                    val_4 = 536896541;
            }
            
                mem2[0] = 0;
            }
            
            val_5 = 536896541;
            if((mem[536896728] & true) != 0)
            {
                    return;
            }
            
            if(mem[536896657] != 0)
            {
                    return;
            }
            
            val_5 = 536896541;
        }
        public static string GetUrlFilename(string url)
        {
            var val_5;
            var val_6;
            if(url == null)
            {
                    return;
            }
            
            val_5 = url;
            val_6 = 0;
            int val_1 = url.IndexOf(value:  '?');
            if(val_1 >= 0)
            {
                    val_6 = 0;
                string val_2 = val_5.Remove(startIndex:  val_1);
                val_5 = val_5;
                if(val_5 == null)
            {
                    val_5 = 0;
                val_6 = 1;
            }
            
            }
            
            int val_3 = val_5.LastIndexOf(value:  '/');
            if(val_3 < 0)
            {
                    return;
            }
            
            return val_5.Substring(startIndex:  val_3 + 1);
        }
        public static TValue GetValueOrDefault<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)
        {
            var val_2;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = dictionary;
            if(dictionary != 0)
            {
                    defaultValue = 0;
            }
        
        }
        public static bool IsAndroid()
        {
            return true;
        }
        public static bool IsIOS()
        {
            return false;
        }
        public static bool IsAppInstalled(string bundleID)
        {
            var val_10;
            var val_11;
            val_10 = 0;
            UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
            if(0 != 11)
            {
                    return (bool)val_10;
            }
            
            536883199 = new UnityEngine.AndroidJavaClass(className:  -1610601241);
            string val_3 = 536883199.GetStatic<System.String>(fieldName:  -1610600971);
            val_11 = mem[mem[3221271783] + 186];
            val_11 = mem[3221271783] + 186;
            if(val_11 == 1)
            {
                    val_11 = mem[mem[3221271783] + 186];
                val_11 = mem[3221271783] + 186;
            }
            
            string val_4 = 536883199.Call<System.String>(methodName:  -1610600357, args:  mem[3221271783] + 92);
            string val_5 = -1610612503(-1610612503) + bundleID;
            UnityEngine.Debug.Log(message:  -1610612503);
            mem[536882227] = bundleID;
            string val_6 = 536883199.Call<System.String>(methodName:  -1610600377, args:  536882211);
            if(536883199 != 0)
            {
                    string val_7 = -1610611921(-1610611921) + bundleID;
                UnityEngine.Debug.Log(message:  -1610611921);
                val_10 = 1;
                return (bool)val_10;
            }
            
            val_10 = 0;
            string val_9 = -1610611919(-1610611919) + -1610611921(-1610611921);
            UnityEngine.Debug.Log(message:  -1610611919);
            return (bool)val_10;
        }
        public static bool HasInternet()
        {
            UnityEngine.NetworkReachability val_1 = UnityEngine.Application.internetReachability;
            if(0 != 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public static bool DelayHasInternet()
        {
            var val_4;
            var val_5;
            float val_1 = UnityEngine.Time.fixedUnscaledTime;
            val_4 = 536896541;
            if(((mem[536896728] & true) == 0) && (mem[536896657] == 0))
            {
                    val_4 = 536896541;
            }
            
            var val_4 = mem[536896633] + 16;
            val_4 = 0 - val_4;
            float val_5 = System.Math.Abs(val_4);
            if(mem[536896657] >= 0)
            {
                    float val_2 = UnityEngine.Time.fixedUnscaledTime;
                val_5 = 536896541;
                if(((mem[536896728] & true) == 0) && (mem[536896657] == 0))
            {
                    val_5 = 536896541;
            }
            
                mem2[0] = 0;
                UnityEngine.NetworkReachability val_3 = UnityEngine.Application.internetReachability;
                val_4 = 536896541;
                if(0 != 0)
            {
                    0 = 1;
            }
            
                mem2[0] = 1;
            }
            
            if((mem[536896728] & true) != 0)
            {
                    return (bool)mem[536896633] + 12;
            }
            
            if(mem[536896657] != 0)
            {
                    return (bool)mem[536896633] + 12;
            }
            
            val_4 = 536896541;
            return (bool)mem[536896633] + 12;
        }
        public static string GetLocalIPAddress()
        {
            var val_4;
            var val_5;
            var val_3 = 0;
            string val_1 = System.Net.Dns.GetHostName();
            System.Net.IPHostEntry val_2 = System.Net.Dns.GetHostEntry(hostNameOrAddress:  null);
            val_4 = 2621443;
            val_5 = val_4 + 16;
            do
            {
                val_3 = val_3 + 1;
            }
            while(((val_4 + 16) + 0 + 20) != 2);
            
            goto (val_4 + 16) + 0 + 212;
        }
        public static string CorrectString(string input)
        {
            if((System.String.IsNullOrEmpty(value:  input)) != false)
            {
                    return;
            }
            
            if(input != null)
            {
                    return input.Replace(oldValue:  -1610612583, newValue:  mem[536894675]);
            }
            
            return input.Replace(oldValue:  -1610612583, newValue:  mem[536894675]);
        }
        public static void Shuffle<T>(System.Collections.Generic.IList<T> list)
        {
            var val_8;
            var val_9;
            System.Collections.Generic.IList<T> val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_8 = __RuntimeMethodHiddenParam;
            var val_8 = 0;
            val_9 = 0;
            val_8 = val_8 + 1;
            val_9 = (uint)val_8 & 65535;
            val_11 = list;
            if(list < 2)
            {
                    return;
            }
            
            do
            {
                System.Collections.Generic.IList<T> val_2 = list - 1;
                int val_3 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  val_2);
                var val_9 = 0;
                val_9 = val_9 + 1;
                val_12 = list;
                var val_10 = 0;
                val_10 = val_10 + 1;
                val_13 = list;
                var val_11 = 0;
                val_11 = val_11 + 1;
                val_14 = list;
                val_8 = val_8;
                var val_12 = 0;
                val_12 = val_12 + 1;
                val_15 = list;
                val_10 = val_2;
            }
            while(list > 2);
        
        }
        public static float NormalizeFloat(float value, int fractNum)
        {
            int val_2 = fractNum;
            val_2 = 1092616192 * val_2;
            float val_3 = (float)UnityEngine.Mathf.RoundToInt(f:  val_2);
            val_3 = val_3 / 1092616192;
            return (float)val_3;
        }
        public static T CopyComponent<T>(T original, UnityEngine.GameObject destination)
        {
            var val_11;
            var val_12;
            string val_13;
            var val_14;
            var val_15;
            System.Type val_1 = original.GetType();
            UnityEngine.Component val_2 = destination.GetComponent(type:  original);
            val_11 = 0;
            if(destination != 0)
            {
                    val_11 = destination;
                if(destination == 0)
            {
                    val_11 = 0;
            }
            
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) != true)
            {
                    UnityEngine.Component val_4 = destination.AddComponent(componentType:  original);
                val_11 = 0;
                if(destination != 0)
            {
                    val_11 = destination;
                if(destination == 0)
            {
                    val_11 = 0;
            }
            
            }
            
            }
            
            val_12 = 0;
            System.Reflection.FieldInfo[] val_5 = original.GetFields();
            val_13 = original;
            object val_6 = original + 16;
            goto label_16;
            label_23:
            if(((original + 16) + 0.IsStatic) != true)
            {
                    (original + 16) + 0.SetValue(obj:  0, value:  (original + 16) + 0);
            }
            
            val_12 = 1;
            label_16:
            if(val_12 < (original + 12))
            {
                goto label_23;
            }
            
            val_14 = 0;
            System.Reflection.PropertyInfo[] val_8 = original.GetProperties();
            object val_9 = original + 16;
            val_15 = 22804036;
            goto label_25;
            label_32:
            val_13 = mem[(original + 16) + 0];
            val_13 = (original + 16) + 0;
            if((val_13 != 0) && (val_13 != 0))
            {
                    if((System.String.op_Equality(a:  val_13, b:  -1610599147)) != true)
            {
                    val_15 = 22804036;
            }
            
            }
            
            val_14 = 1;
            label_25:
            if(val_14 < (original + 12))
            {
                goto label_32;
            }
        
        }
        public static float AngleInDeg(UnityEngine.Vector3 vec1, UnityEngine.Vector3 vec2)
        {
            var val_4;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 604.3904f}, rhs:  new UnityEngine.Vector3() {y = vec1.x, z = vec1.y});
            float val_6 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = vec2.x, y = vec2.y, z = vec2.z}, to:  new UnityEngine.Vector3() {x = vec1.x, y = vec1.y, z = vec1.z});
            float val_8 = vec2.y;
            val_8 = val_4 * val_8;
            float val_7 = UnityEngine.Mathf.Sign(f:  val_8);
            var val_9 = val_8;
            val_9 = vec2.x * val_9;
            return (float)val_9;
        }
        public static float SignedAngleBetween(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 n)
        {
            var val_3;
            float val_1 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z}, to:  new UnityEngine.Vector3() {x = b.x, y = b.y, z = b.z});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 611.2263f, y = a.x, z = a.y}, rhs:  new UnityEngine.Vector3() {x = a.z, y = b.x, z = b.y});
            float val_7 = n.y;
            val_7 = val_3 * val_7;
            float val_6 = UnityEngine.Mathf.Sign(f:  val_7);
            var val_8 = val_7;
            val_8 = a.x * val_8;
            return (float)val_8;
        }
        public static UnityEngine.Vector2 WorldToScreenPointProjected(UnityEngine.Camera camera, UnityEngine.Vector3 worldPos)
        {
            var val_3;
            float val_4;
            var val_5;
            var val_6;
            float val_18;
            float val_19;
            float val_20;
            val_18 = worldPos.z;
            val_19 = worldPos.y;
            UnityEngine.Transform val_1 = worldPos.x.transform;
            UnityEngine.Vector3 val_2 = forward;
            var val_20 = val_3;
            var val_19 = val_4;
            var val_18 = val_5;
            val_20 = val_6;
            UnityEngine.Transform val_7 = worldPos.x.transform;
            UnityEngine.Vector3 val_8 = position;
            float val_21 = val_4;
            float val_9 = val_18 - val_21;
            float val_12 = val_19 * val_9;
            if(worldPos.x <= 0f)
            {
                    val_18 = val_18 * val_12;
                val_19 = val_19 * val_12;
                val_20 = val_20 * val_12;
                val_18 = val_18 * 1.01f;
                val_19 = val_19 * 1.01f;
                val_20 = val_20 * 1.01f;
                UnityEngine.Transform val_13 = worldPos.x.transform;
                UnityEngine.Vector3 val_14 = position;
                float val_15 = (val_20 - val_5) - val_18;
                float val_16 = val_9 - val_19;
                val_21 = (val_19 - val_3) - val_20;
                val_15 = val_15 + val_5;
                val_16 = val_16 + val_4;
                val_21 = val_21 + val_3;
                val_20 = val_15;
                val_18 = val_16;
                val_19 = val_21;
            }
            
            UnityEngine.Vector2 val_17 = UnityEngine.RectTransformUtility.WorldToScreenPoint(cam:  1142592512, worldPoint:  new UnityEngine.Vector3() {x = worldPos.x, y = val_19, z = val_18});
            return new UnityEngine.Vector2() {x = val_17.x, y = val_17.y};
        }
        public static bool IsPrefab(UnityEngine.GameObject obj)
        {
            UnityEngine.SceneManagement.Scene val_1 = obj.scene;
            int val_2 = val_1.m_Handle.rootCount;
            val_2 = val_2 >> 5;
            return (bool)val_2;
        }
        public static void ShuffleList<T>(System.Collections.Generic.IList<T> ts)
        {
            float val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_7 = __RuntimeMethodHiddenParam;
            val_8 = mem[__RuntimeMethodHiddenParam + 24];
            val_8 = __RuntimeMethodHiddenParam + 24;
            var val_7 = 0;
            val_9 = 0;
            val_7 = val_7 + 1;
            val_9 = (uint)val_7 & 65535;
            val_10 = ts;
            System.Collections.Generic.IList<T> val_8 = ts;
            val_8 = val_8 - 1;
            if(val_8 < 1)
            {
                    return;
            }
            
            var val_13 = 0;
            do
            {
                int val_2 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  val_8);
                var val_9 = 0;
                val_9 = val_9 + 1;
                val_11 = ts;
                var val_10 = 0;
                val_10 = val_10 + 1;
                val_12 = ts;
                var val_11 = 0;
                val_11 = val_11 + 1;
                val_13 = ts;
                val_7 = val_7;
                val_8 = mem[__RuntimeMethodHiddenParam + 24 + 4];
                val_8 = __RuntimeMethodHiddenParam + 24 + 4;
                var val_12 = 0;
                val_12 = val_12 + 1;
                val_14 = ts;
                val_13 = val_13 + 1;
            }
            while(val_13 != val_8);
        
        }
        public static T[] ResizeArray<T>(T[] input, int length, T defaultValue)
        {
            var val_2;
            var val_3;
            val_2 = (__RuntimeMethodHiddenParam + 24) + 16;
            val_3 = 0;
            if( >= length)
            {
                    return;
            }
            
            do
            {
                mem2[0] = defaultValue;
                 =  + 1;
                val_2 = (__RuntimeMethodHiddenParam + 24 + 16) + 4 + 4;
            }
            while(length != );
        
        }
        public static bool CompareArray<T>(T[] arrayA, T[] arrayB)
        {
            var val_1;
            var val_3;
            var val_4;
            if(arrayA == null)
            {
                goto label_0;
            }
            
            if(arrayB != null)
            {
                goto label_1;
            }
            
            goto label_2;
            label_0:
            val_1 = 0;
            if(arrayB != null)
            {
                    return (bool)val_1;
            }
            
            label_1:
            val_1 = 0;
            if(arrayA != arrayB)
            {
                    return (bool)val_1;
            }
            
            val_1 = 1;
            if(arrayA < 1)
            {
                    return (bool)val_1;
            }
            
            val_3 = 0;
            val_4 = arrayA;
            goto label_6;
            label_12:
            val_3 = 1;
            if(val_3 >= arrayA)
            {
                    return (bool)val_1;
            }
            
            label_6:
            if(arrayA != null)
            {
                goto label_12;
            }
            
            label_2:
            val_1 = 0;
            return (bool)val_1;
        }
        public static string GetParameterNameSlow<T>(T item)
        {
            if(item == 0)
            {
                    return;
            }
            
            mem[536881809] = 123;
            string val_1 = item.TrimStart(trimChars:  536881793);
            mem[536881809] = 125;
            string val_2 = item.TrimEnd(trimChars:  536881793);
            mem[536881809] = 61;
            System.String[] val_3 = item.Split(separator:  536881793);
            if(item != 0)
            {
                    return item.Trim();
            }
            
            return item.Trim();
        }
        public static string GetParameterNameFast<T>(T item)
        {
            var val_4 = 22985750;
            if(item == 0)
            {
                    return;
            }
            
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 4});
            System.Reflection.PropertyInfo[] val_2 = __RuntimeMethodHiddenParam + 24 + 4.GetProperties();
            if((__RuntimeMethodHiddenParam + 24 + 4 + 16) == 0)
            {
                
            }
        
        }
        public static void CopyRectTransform(UnityEngine.RectTransform from, UnityEngine.RectTransform to)
        {
            UnityEngine.Vector2 val_1 = anchorMin;
            to.anchorMin = new UnityEngine.Vector2() {x = R6, y = R7};
            UnityEngine.Vector2 val_2 = anchorMax;
            to.anchorMax = new UnityEngine.Vector2() {x = R6, y = R7};
            UnityEngine.Vector2 val_3 = anchoredPosition;
            to.anchoredPosition = new UnityEngine.Vector2() {x = R6, y = R7};
            UnityEngine.Vector2 val_4 = sizeDelta;
            to.sizeDelta = new UnityEngine.Vector2() {x = R5, y = R6};
        }
        public static System.Collections.IEnumerator CRDelayFunction(float time, System.Action callback)
        {
            Utility.<CRDelayFunction>d__36 val_1 = 536902313;
            val_1 = new Utility.<CRDelayFunction>d__36(<>1__state:  0);
            if(val_1 != 0)
            {
                    mem[536902329] = callback;
            }
            else
            {
                    mem[16] = callback;
            }
            
            mem[536902333] = R1;
        }
        public static UnityEngine.Mesh CreateCube(UnityEngine.Vector3 size, bool save = False)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            float val_16 = 0.5f;
            float val_15 = -0.5f;
            float val_14 = size.x;
            float val_1 = size.z * val_16;
            float val_2 = size.y * val_15;
            float val_3 = val_14 * val_15;
            val_14 = val_14 * val_16;
            mem[536882613] = val_3;
            mem[536882617] = val_2;
            mem[536882621] = val_1;
            val_15 = size.z * val_15;
            mem[536882625] = val_14;
            mem[536882629] = val_2;
            mem[536882633] = val_1;
            mem[536882637] = val_14;
            mem[536882641] = val_2;
            mem[536882645] = val_15;
            val_16 = size.y * val_16;
            mem[536882649] = val_3;
            mem[536882653] = val_2;
            mem[536882657] = val_15;
            mem[536882661] = val_3;
            mem[536882665] = val_16;
            mem[536882669] = val_1;
            mem[536882673] = val_14;
            mem[536882677] = val_16;
            mem[536882681] = val_1;
            mem[536882685] = val_14;
            mem[536882689] = val_16;
            mem[536882693] = val_15;
            mem[536882697] = val_3;
            mem[536882701] = val_16;
            mem[536882705] = val_15;
            mem[536882613] = mem[536882613];
            mem[536882617] = mem[536882617];
            mem[536882621] = mem[536882621];
            mem[536882889] = mem[536882697];
            mem[536882893] = mem[536882701];
            mem[536882897] = mem[536882705];
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.back;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.right;
            val_17 = mem[536882609];
            val_21 = val_7;
            val_22 = val_5;
            val_23 = val_6;
            val_24 = val_7;
            if(val_17 == 0)
            {
                    val_24 = val_7;
                val_23 = val_6;
                val_22 = val_5;
                val_21 = val_7;
                val_17 = mem[536882609];
            }
            
            val_25 = val_6;
            mem[536882613] = val_5;
            mem[536882617] = val_25;
            mem[536882621] = val_7;
            if(val_17 <= 1)
            {
                    val_22 = val_5;
                val_21 = val_7;
                val_17 = mem[536882609];
            }
            
            mem[536882625] = val_5;
            mem[536882629] = val_25;
            mem[536882633] = val_7;
            if(val_17 <= 2)
            {
                    val_22 = val_5;
                val_21 = val_7;
                val_17 = mem[536882609];
            }
            
            mem[536882637] = val_5;
            mem[536882641] = val_25;
            mem[536882645] = val_7;
            if(val_17 <= 3)
            {
                    val_22 = val_5;
                val_21 = val_7;
                val_17 = mem[536882609];
            }
            
            mem[536882649] = val_5;
            mem[536882653] = val_25;
            mem[536882657] = val_7;
            if(val_17 <= 4)
            {
                    val_24 = val_7;
                val_23 = val_6;
                val_22 = val_5;
                val_21 = val_7;
                val_17 = mem[536882609];
            }
            
            mem[536882661] = val_22;
            mem[536882665] = val_23;
            mem[536882669] = val_24;
            if(val_17 <= 5)
            {
                    val_24 = val_7;
                val_23 = val_6;
                val_22 = val_5;
                val_21 = val_7;
                val_17 = mem[536882609];
            }
            
            mem[536882673] = val_22;
            mem[536882677] = val_23;
            mem[536882681] = val_24;
            if(val_17 <= 6)
            {
                    val_24 = val_7;
                val_23 = val_6;
                val_22 = val_5;
                val_21 = val_7;
                val_17 = mem[536882609];
            }
            
            mem[536882685] = val_22;
            mem[536882689] = val_23;
            mem[536882693] = val_24;
            if(val_17 <= 7)
            {
                    val_24 = val_7;
                val_23 = val_6;
                val_22 = val_5;
                val_21 = val_7;
                val_17 = mem[536882609];
            }
            
            mem[536882697] = val_22;
            mem[536882701] = val_23;
            mem[536882705] = val_24;
            if(val_17 <= 8)
            {
                    val_21 = val_7;
                val_17 = mem[536882609];
            }
            
            mem[536882709] = val_5;
            mem[536882713] = val_19;
            mem[536882717] = val_21;
            if(val_17 <= 9)
            {
                    val_21 = val_7;
                val_17 = mem[536882609];
            }
            
            mem[536882721] = val_5;
            mem[536882725] = val_19;
            mem[536882729] = val_21;
            if(val_17 <= 10)
            {
                    val_21 = val_7;
                val_17 = mem[536882609];
            }
            
            mem[536882733] = val_5;
            mem[536882737] = val_19;
            mem[536882741] = val_21;
            if(val_17 <= 11)
            {
                    val_21 = val_7;
                val_17 = mem[536882609];
            }
            
            mem[536882745] = val_5;
            mem[536882749] = val_19;
            mem[536882753] = val_21;
            if(val_17 <= 12)
            {
                    val_18 = val_7;
                val_20 = val_5;
                val_17 = mem[536882609];
            }
            
            mem[536882757] = val_20;
            mem[536882761] = val_6;
            mem[536882765] = val_18;
            if(val_17 <= 13)
            {
                    val_18 = val_7;
                val_20 = val_5;
                val_17 = mem[536882609];
            }
            
            mem[536882769] = val_20;
            mem[536882773] = val_6;
            mem[536882777] = val_18;
            if(val_17 <= 14)
            {
                    val_18 = val_7;
                val_20 = val_5;
                val_17 = mem[536882609];
            }
            
            mem[536882781] = val_20;
            mem[536882785] = val_6;
            mem[536882789] = val_18;
            if(val_17 <= 15)
            {
                    val_18 = val_7;
                val_20 = val_5;
                val_17 = mem[536882609];
            }
            
            mem[536882793] = val_20;
            mem[536882797] = val_6;
            mem[536882801] = val_18;
            if(val_17 <= 16)
            {
                    val_17 = mem[536882609];
            }
            
            mem[536882805] = val_5;
            mem[536882809] = val_6;
            mem[536882813] = val_7;
            if(val_17 <= 17)
            {
                    val_17 = mem[536882609];
            }
            
            mem[536882817] = val_5;
            mem[536882821] = val_6;
            mem[536882825] = val_7;
            if(val_17 <= 18)
            {
                    val_17 = mem[536882609];
            }
            
            mem[536882829] = val_5;
            mem[536882833] = val_6;
            mem[536882837] = val_7;
            if(val_17 <= 19)
            {
                    val_17 = mem[536882609];
            }
            
            mem[536882841] = val_5;
            mem[536882845] = val_6;
            mem[536882849] = val_7;
            if(val_17 <= 20)
            {
                    val_17 = mem[536882609];
            }
            
            mem[536882853] = val_5;
            mem[536882857] = val_6;
            mem[536882861] = val_7;
            if(val_17 <= 21)
            {
                    val_17 = mem[536882609];
            }
            
            mem[536882865] = val_5;
            mem[536882869] = val_6;
            mem[536882873] = val_7;
            if(val_17 <= 22)
            {
                    val_17 = mem[536882609];
            }
            
            mem[536882877] = val_5;
            mem[536882881] = val_6;
            mem[536882885] = val_7;
            mem[536882889] = val_5;
            mem[536882893] = val_6;
            mem[536882897] = val_7;
            val_26 = mem[536882597];
            if(val_26 == 0)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882601] = 1065353216;
            mem[536882605] = 1065353216;
            if(val_26 <= 1)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882609] = 0;
            mem[536882613] = 1065353216;
            if(val_26 <= 2)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882617] = 0;
            mem[536882621] = 0;
            if(val_26 <= 3)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882625] = 1065353216;
            mem[536882629] = 0;
            if(val_26 <= 4)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882633] = 1065353216;
            mem[536882637] = 1065353216;
            if(val_26 <= 5)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882641] = 0;
            mem[536882645] = 1065353216;
            if(val_26 <= 6)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882649] = 0;
            mem[536882653] = 0;
            if(val_26 <= 7)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882657] = 1065353216;
            mem[536882661] = 0;
            if(val_26 <= 8)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882665] = 1065353216;
            mem[536882669] = 1065353216;
            if(val_26 <= 9)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882673] = 0;
            mem[536882677] = 1065353216;
            if(val_26 <= 10)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882681] = 0;
            mem[536882685] = 0;
            if(val_26 <= 11)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882689] = 1065353216;
            mem[536882693] = 0;
            if(val_26 <= 12)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882697] = 1065353216;
            mem[536882701] = 1065353216;
            if(val_26 <= 13)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882705] = 0;
            mem[536882709] = 1065353216;
            if(val_26 <= 14)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882713] = 0;
            mem[536882717] = 0;
            if(val_26 <= 15)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882721] = 1065353216;
            mem[536882725] = 0;
            if(val_26 <= 16)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882729] = 1065353216;
            mem[536882733] = 1065353216;
            if(val_26 <= 17)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882737] = 0;
            mem[536882741] = 1065353216;
            if(val_26 <= 18)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882745] = 0;
            mem[536882749] = 0;
            if(val_26 <= 19)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882753] = 1065353216;
            mem[536882757] = 0;
            if(val_26 <= 20)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882761] = 1065353216;
            mem[536882765] = 1065353216;
            if(val_26 <= 21)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882769] = 0;
            mem[536882773] = 1065353216;
            if(val_26 <= 22)
            {
                    val_26 = mem[536882597];
            }
            
            mem[536882777] = 0;
            mem[536882781] = 0;
            mem[536882785] = 1065353216;
            UnityEngine.Mesh val_13 = 536890419;
            val_13 = new UnityEngine.Mesh();
            if(val_13 != 0)
            {
                    val_13.Clear();
                val_13.vertices = 536882597;
                val_13.triangles = 536882065;
                val_13.normals = 536882597;
            }
            else
            {
                    val_13.Clear();
                val_13.vertices = 536882597;
                val_13.triangles = 536882065;
                val_13.normals = 536882597;
            }
            
            val_13.uv = 536882585;
        }
        public static string GetGoogleSheetCSVData(string fileId, string sheetId)
        {
            536887819 = new System.Net.Http.HttpClient();
            string val_2 = System.String.Format(format:  -1610600089, arg0:  fileId, arg1:  sheetId);
            System.Uri val_3 = 536896465;
            val_3 = new System.Uri(uriString:  -1610600089);
            mem[536887835] = val_3;
            System.Net.Http.Headers.HttpRequestHeaders val_4 = val_1.DefaultRequestHeaders;
            System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.MediaTypeWithQualityHeaderValue> val_5 = val_1.Accept;
            val_1.Clear();
            System.Net.Http.Headers.HttpRequestHeaders val_6 = val_1.DefaultRequestHeaders;
            System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.MediaTypeWithQualityHeaderValue> val_7 = val_1.Accept;
            536890371 = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(mediaType:  -1610597801);
            val_1.Add(item:  536890371);
            System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> val_9 = val_1.GetAsync(requestUri:  -1610612735);
            Result val_10 = val_1.Result;
            if(mem[536887835] != 200)
            {
                    return;
            }
            
            System.Threading.Tasks.Task<System.String> val_11 = mem[536887847].ReadAsStringAsync();
            Result val_12 = mem[536887847].Result;
        }
        private static Utility()
        {
            mem2[0] = 0;
            mem2[0] = -1610612735;
            mem2[0] = -1610612735;
            mem2[0] = 1;
            mem2[0] = 3296313344;
        }
    
    }

}
