using UnityEngine;

namespace GameTool
{
    public static class EventDispatcher
    {
        // Fields
        private static System.Collections.Generic.Dictionary<EventID, System.Collections.Generic.List<System.Action<UnityEngine.Component, object>>> _listenersDict;
        
        // Methods
        public static void RegisterListener(EventID eventID, System.Action<UnityEngine.Component, object> callback)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_5 = 536886481;
            if(((mem[536886668] & true) == 0) && (mem[536886597] == 0))
            {
                    val_5 = 536886481;
            }
            
            val_6 = 536886481;
            var val_5 = mem[536886667];
            val_5 = val_5 & 512;
            if((mem[536886573].ContainsKey(key:  eventID)) != false)
            {
                    if((val_5 != 0) && (mem[536886597] == 0))
            {
                    val_7 = 536886481;
            }
            
                object val_2 = mem[536886573].Item[eventID];
                mem[536886573].Add(item:  callback);
                return;
            }
            
            if((val_5 != 0) && (mem[536886597] == 0))
            {
                    val_8 = 536886481;
            }
            
            if((mem[536886573].ContainsKey(key:  eventID)) != false)
            {
                    return;
            }
            
            536877637 = new System.Collections.Generic.List<Page>();
            536877637.Add(item:  callback);
            val_9 = 536886481;
            if(((mem[536886668] & true) == 0) && (mem[536886597] == 0))
            {
                    val_9 = 536886481;
            }
            
            mem[536886573].Add(key:  eventID, value:  536877637);
        }
        public static void PostEvent(EventID eventID, UnityEngine.Component sender, object param)
        {
            var val_6;
            var val_7;
            var val_8;
            float val_9;
            var val_10;
            val_6 = 536886481;
            if(((mem[536886668] & true) == 0) && (mem[536886597] == 0))
            {
                    val_6 = 536886481;
            }
            
            val_7 = mem[mem[536886573]];
            val_7 = mem[536886573];
            if((val_7.TryGetValue(key:  eventID, value: out  object val_1 = 1134099844)) != false)
            {
                    val_8 = 0;
                val_9 = 0f;
                if(val_9 < 1)
            {
                    return;
            }
            
                val_10 = 0;
                val_8 = 22721800;
            }
            else
            {
                    val_8 = 536886497;
                Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
                mem[536882227] = val_8;
                UnityEngine.Debug.LogWarningFormat(context:  0, format:  -1610605263, args:  536882211);
            }
        
        }
        public static void RemoveListener(EventID eventID, System.Action<UnityEngine.Component, object> callback)
        {
            var val_6;
            var val_7;
            var val_8;
            val_6 = 536886481;
            if(((mem[536886668] & true) == 0) && (mem[536886597] == 0))
            {
                    val_6 = 536886481;
            }
            
            val_7 = mem[mem[536886573]];
            val_7 = mem[536886573];
            if((val_7.TryGetValue(key:  eventID, value: out  object val_1 = 1134232336)) != false)
            {
                    if((0.Contains(item:  callback)) == false)
            {
                    return;
            }
            
                bool val_4 = 0.Remove(item:  callback);
                if(0 != 0)
            {
                    return;
            }
            
                val_8 = 536886481;
                if(((mem[536886668] & true) == 0) && (mem[536886597] == 0))
            {
                    val_8 = 536886481;
            }
            
                bool val_5 = mem[536886573].Remove(key:  eventID);
                return;
            }
            
            val_7 = 536886497;
            Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
            mem[536882227] = val_7;
            UnityEngine.Debug.LogWarningFormat(context:  0, format:  -1610604975, args:  536882211);
        }
        public static void RemoveRedundancies()
        {
            var val_6;
            var val_8;
            int val_9;
            var val_10;
            var val_11;
            val_6 = 536886481;
            if(((mem[536886668] & true) == 0) && (mem[536886597] == 0))
            {
                    val_6 = 536886481;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_1 = GetEnumerator();
            goto label_6;
            label_19:
            val_8 = mem[R6 + 12];
            val_8 = R6 + 12;
            val_9 = val_8 - 1;
            val_10 = val_8;
            if(val_9 < 0)
            {
                goto label_6;
            }
            
            goto label_7;
            label_18:
            val_8 = mem[R6 + 12];
            val_8 = R6 + 12;
            label_7:
            if(val_8 <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_5 = R6 + 8;
            val_5 = val_5 + (val_9 << 2);
            if(((R6 + 8 + ((R6 + 12 - 1)) << 2) + 16) != 0)
            {
                    if(((R6 + 8 + ((R6 + 12 - 1)) << 2) + 16 + 16) == 0)
            {
                goto label_11;
            }
            
            }
            
            R6.RemoveAt(index:  val_9);
            if((R6 + 12) == 0)
            {
                    val_11 = 536886481;
                if(((mem[536886668] & true) == 0) && (mem[536886597] == 0))
            {
                    val_11 = 536886481;
            }
            
                bool val_3 = mem[536886573].Remove(key:  0);
            }
            
            val_10 = val_10 - 2;
            goto label_17;
            label_11:
            val_10 = val_9;
            label_17:
            val_9 = val_10 - 1;
            if(val_9 >= 0)
            {
                goto label_18;
            }
            
            label_6:
            if(0.MoveNext() == true)
            {
                goto label_19;
            }
            
            0.Dispose();
        }
        public static void ClearAllListener()
        {
            if(((mem[536886668] & true) == 0) && (mem[536886597] == 0))
            {
                    536886481 = 536886481;
            }
            
            mem[536886573].Clear();
        }
        private static EventDispatcher()
        {
            536874155 = new System.Collections.Generic.Dictionary<System.Int32Enum, System.Object>();
            mem2[0] = 536874155;
        }
    
    }

}
