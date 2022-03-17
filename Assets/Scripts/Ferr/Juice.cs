using UnityEngine;

namespace Ferr
{
    public class Juice : MonoBehaviour
    {
        // Fields
        private static Ferr.Juice instance;
        public System.Collections.Generic.List<Ferr.JuiceData> list;
        public System.Collections.Generic.List<Ferr.JuiceDataColor> listColor;
        private float savedTimescale;
        private float sleepTimer;
        private bool sleep;
        
        // Properties
        private static Ferr.Juice Instance { get; }
        public static UnityEngine.AnimationCurve SproingIn { get; }
        public static UnityEngine.AnimationCurve FastFalloff { get; }
        public static UnityEngine.AnimationCurve LateFalloff { get; }
        public static UnityEngine.AnimationCurve Wobble { get; }
        public static UnityEngine.AnimationCurve Linear { get; }
        public static UnityEngine.AnimationCurve Hop { get; }
        public static UnityEngine.AnimationCurve SharpHop { get; }
        
        // Methods
        private static Ferr.Juice get_Instance()
        {
            var val_3;
            var val_4;
            val_3 = 536889399;
            if(((mem[536889586] & true) == 0) && (mem[536889515] == 0))
            {
                    val_3 = 536889399;
            }
            
            if(mem[536889491] == 0)
            {
                    Ferr.Juice val_2 = Ferr.Juice.Create();
                mem2[0] = 536889399;
            }
            
            val_4 = 536889399;
            if((mem[536889586] & true) != 0)
            {
                    return;
            }
            
            if(mem[536889515] != 0)
            {
                    return;
            }
            
            val_4 = 536889399;
        }
        private Juice()
        {
            536878029 = new System.Collections.Generic.List<Page>();
            this.list = 536878029;
            536878033 = new System.Collections.Generic.List<Page>();
            this.listColor = 536878033;
        }
        private static Ferr.Juice Create()
        {
            536887303 = new UnityEngine.GameObject(name:  -1610606797);
            if(536887303 != 0)
            {
                    return 536887303.AddComponent<SynchronizationContextBehavoir>();
            }
            
            return 536887303.AddComponent<SynchronizationContextBehavoir>();
        }
        public static UnityEngine.AnimationCurve get_SproingIn()
        {
            UnityEngine.Keyframe val_1 = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_2 = 536882139 + 16;
            mem[536882171] = val_1.m_WeightedMode;
            mem[536882175] = val_1.m_InWeight;
            mem[536882179] = val_1.m_Time;
            UnityEngine.Keyframe val_3 = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_4 = 536882139 + 44;
            mem[536882199] = val_3.m_WeightedMode;
            mem[536882203] = val_3.m_Time;
            mem[536882207] = val_3.m_Time;
            UnityEngine.Keyframe val_5 = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_6 = 536882139 + 72;
            mem[536882227] = val_5.m_WeightedMode;
            mem[536882231] = val_5.m_Time;
            mem[536882235] = val_5.m_Time;
             = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_8 = 536882139 + 100;
            mem[536882255] = val_7.m_WeightedMode;
            mem[536882259] = val_7.m_Time;
            mem[536882263] = val_7.m_Time;
            536883291 = new UnityEngine.AnimationCurve(keys:  536882139);
        }
        public static UnityEngine.AnimationCurve get_FastFalloff()
        {
            UnityEngine.Keyframe val_1 = new UnityEngine.Keyframe(time:  null, value:  null, inTangent:  null, outTangent:  null);
            var val_2 = 536882139 + 16;
            mem[536882171] = val_1.m_WeightedMode;
            mem[536882175] = val_1.m_InWeight;
            mem[536882179] = val_1.m_Time;
            UnityEngine.Keyframe val_3 = new UnityEngine.Keyframe(time:  null, value:  null, inTangent:  null, outTangent:  null);
            var val_4 = 536882139 + 44;
            mem[536882199] = val_3.m_WeightedMode;
            mem[536882203] = val_3.m_Time;
            mem[536882207] = val_3.m_Time;
            UnityEngine.Keyframe val_5 = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_6 = 536882139 + 72;
            mem[536882227] = val_5.m_WeightedMode;
            mem[536882231] = val_5.m_Time;
            mem[536882235] = val_5.m_Time;
            536883291 = new UnityEngine.AnimationCurve(keys:  536882139);
        }
        public static UnityEngine.AnimationCurve get_LateFalloff()
        {
            UnityEngine.Keyframe val_1 = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_2 = 536882139 + 16;
            mem[536882171] = val_1.m_WeightedMode;
            mem[536882175] = val_1.m_InWeight;
            mem[536882179] = val_1.m_Time;
            UnityEngine.Keyframe val_3 = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_4 = 536882139 + 44;
            mem[536882199] = val_3.m_WeightedMode;
            mem[536882203] = val_3.m_Time;
            mem[536882207] = val_3.m_Time;
             = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_6 = 536882139 + 72;
            mem[536882227] = val_5.m_WeightedMode;
            mem[536882231] = val_5.m_Time;
            mem[536882235] = val_5.m_Time;
            536883291 = new UnityEngine.AnimationCurve(keys:  536882139);
        }
        public static UnityEngine.AnimationCurve get_Wobble()
        {
            UnityEngine.Keyframe val_1 = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_2 = 536882139 + 16;
            mem[536882171] = val_1.m_WeightedMode;
            mem[536882175] = val_1.m_InWeight;
            mem[536882179] = val_1.m_Time;
            UnityEngine.Keyframe val_3 = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_4 = 536882139 + 44;
            mem[536882199] = val_3.m_WeightedMode;
            mem[536882203] = val_3.m_Time;
            mem[536882207] = val_3.m_Time;
            UnityEngine.Keyframe val_5 = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_6 = 536882139 + 72;
            mem[536882227] = val_5.m_WeightedMode;
            mem[536882231] = val_5.m_Time;
            mem[536882235] = val_5.m_Time;
             = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_8 = 536882139 + 100;
            mem[536882255] = val_7.m_WeightedMode;
            mem[536882259] = val_7.m_Time;
            mem[536882263] = val_7.m_Time;
            536883291 = new UnityEngine.AnimationCurve(keys:  536882139);
        }
        public static UnityEngine.AnimationCurve get_Linear()
        {
            UnityEngine.Keyframe val_1 = new UnityEngine.Keyframe(time:  null, value:  null, inTangent:  null, outTangent:  null);
            var val_2 = 536882139 + 16;
            mem[536882171] = val_1.m_WeightedMode;
            mem[536882175] = val_1.m_InWeight;
            mem[536882179] = val_1.m_Time;
            UnityEngine.Keyframe val_3 = new UnityEngine.Keyframe(time:  null, value:  null, inTangent:  null, outTangent:  null);
            var val_4 = 536882139 + 44;
            mem[536882199] = val_3.m_WeightedMode;
            mem[536882203] = val_3.m_Time;
            mem[536882207] = val_3.m_Time;
            536883291 = new UnityEngine.AnimationCurve(keys:  536882139);
        }
        public static UnityEngine.AnimationCurve get_Hop()
        {
            UnityEngine.Keyframe val_1 = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_2 = 536882139 + 16;
            mem[536882171] = val_1.m_WeightedMode;
            mem[536882175] = val_1.m_InWeight;
            mem[536882179] = val_1.m_Time;
            UnityEngine.Keyframe val_3 = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_4 = 536882139 + 44;
            mem[536882199] = val_3.m_WeightedMode;
            mem[536882203] = val_3.m_Time;
            mem[536882207] = val_3.m_Time;
             = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_6 = 536882139 + 72;
            mem[536882227] = val_5.m_WeightedMode;
            mem[536882231] = val_5.m_Time;
            mem[536882235] = val_5.m_Time;
            536883291 = new UnityEngine.AnimationCurve(keys:  536882139);
        }
        public static UnityEngine.AnimationCurve get_SharpHop()
        {
            UnityEngine.Keyframe val_1 = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_2 = 536882139 + 16;
            mem[536882171] = val_1.m_WeightedMode;
            mem[536882175] = val_1.m_InWeight;
            mem[536882179] = val_1.m_Time;
             = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_4 = 536882139 + 44;
            mem[536882199] = val_3.m_WeightedMode;
            mem[536882203] = val_3.m_Time;
            mem[536882207] = val_3.m_Time;
            536883291 = new UnityEngine.AnimationCurve(keys:  536882139);
        }
        private void Update()
        {
            var val_4;
            var val_5;
            val_4 = 0;
            goto label_1;
            label_16:
            if(true <= val_4)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            bool val_1 = (0 + 0) + 16.Update();
            if(val_1 != false)
            {
                    if(val_1 <= val_4)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_5 = val_5 + 0;
                if(((0 + 0) + 16 + 40) != 0)
            {
                    if(((0 + 0) + 16 + 40) <= val_4)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_6 = val_6 + 0;
                (0 + 0) + 16 + 40.Invoke();
            }
            
                this.list.RemoveAt(index:  0);
            }
            
            val_4 = 0;
            label_1:
            if(val_4 < this.list)
            {
                goto label_16;
            }
            
            val_5 = 0;
            goto label_17;
            label_32:
            if(this.list <= val_5)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + 0;
            bool val_2 = (0 + 0) + 16.Update();
            if(val_2 != false)
            {
                    if(val_2 <= val_5)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_8 = val_8 + 0;
                if(((0 + 0) + 16 + 56) != 0)
            {
                    if(((0 + 0) + 16 + 56) <= val_5)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_9 = val_9 + 0;
                (0 + 0) + 16 + 56.Invoke();
            }
            
                this.listColor.RemoveAt(index:  0);
            }
            
            val_5 = 0;
            label_17:
            if(val_5 < this.listColor)
            {
                goto label_32;
            }
            
            if(this.sleep == false)
            {
                    return;
            }
            
            float val_3 = UnityEngine.Time.realtimeSinceStartup;
            if(this.sleep <= false)
            {
                    return;
            }
            
            this.sleep = false;
            UnityEngine.Time.timeScale = this.sleepTimer;
        }
        public static void Add(UnityEngine.Transform aTransform, Ferr.JuiceType aType, UnityEngine.AnimationCurve aCurve, float aStart = 0, float aEnd = 1, float aDuration = 1, bool aRelative = False, System.Action aCallback)
        {
            var val_1;
            var val_2;
            float val_3;
            object val_4 = 536889403;
            val_4 = new System.Object();
            if(val_4 != 0)
            {
                    mem[536889415] = aTransform;
                mem[536889439] = aCurve;
                mem[536889411] = aType;
                mem[536889427] = val_3;
                mem[536889419] = aRelative;
                float val_5 = UnityEngine.Time.time;
                mem[536889431] = 0;
                mem[536889423] = aCallback;
                mem[536889435] = val_2;
            }
            else
            {
                    mem[12] = aTransform;
                mem[8] = aType;
                mem[36] = aCurve;
                mem[16] = aRelative;
                mem[24] = val_3;
                float val_6 = UnityEngine.Time.time;
                mem[28] = 0;
                mem[20] = aCallback;
                mem[32] = val_2;
            }
            
            mem[536889443] = val_1;
            Ferr.Juice val_7 = Ferr.Juice.Instance;
            mem[536889411].Add(item:  536889403);
            bool val_8 = val_4.Update();
        }
        public static void Scale(UnityEngine.Transform aTransform, UnityEngine.AnimationCurve aCurve, float aStart = 0, float aEnd = 1, float aDuration = 1, bool aRelative = False, System.Action aCallback)
        {
            Ferr.Juice.Add(aTransform:  aTransform, aType:  7, aCurve:  aCurve, aStart:  aStart, aEnd:  aEnd, aDuration:  aDuration, aRelative:  aRelative, aCallback:  aCallback);
        }
        public static void Scale(UnityEngine.Transform aTransform, UnityEngine.AnimationCurve aCurve, UnityEngine.Vector3 aStart, UnityEngine.Vector3 aEnd, float aDuration = 1, bool aRelative = False, System.Action aCallback)
        {
            Ferr.Juice.Add(aTransform:  aTransform, aType:  1, aCurve:  aCurve, aStart:  aDuration, aEnd:  null, aDuration:  null, aRelative:  aStart.x, aCallback:  aEnd.x);
            Ferr.Juice.Add(aTransform:  aTransform, aType:  2, aCurve:  aCurve, aStart:  aDuration, aEnd:  null, aDuration:  null, aRelative:  aStart.y, aCallback:  aEnd.y);
            Ferr.Juice.Add(aTransform:  aTransform, aType:  4, aCurve:  aCurve, aStart:  aDuration, aEnd:  null, aDuration:  null, aRelative:  aStart.z, aCallback:  aEnd.z);
        }
        public static void Rotate(UnityEngine.Transform aTransform, UnityEngine.AnimationCurve aCurve, UnityEngine.Vector3 aStart, UnityEngine.Vector3 aEnd, float aDuration = 1, bool aRelative = False, System.Action aCallback)
        {
            Ferr.Juice.Add(aTransform:  aTransform, aType:  64, aCurve:  aCurve, aStart:  aDuration, aEnd:  null, aDuration:  null, aRelative:  aStart.x, aCallback:  aEnd.x);
            Ferr.Juice.Add(aTransform:  aTransform, aType:  128, aCurve:  aCurve, aStart:  aDuration, aEnd:  null, aDuration:  null, aRelative:  aStart.y, aCallback:  aEnd.y);
            Ferr.Juice.Add(aTransform:  aTransform, aType:  256, aCurve:  aCurve, aStart:  aDuration, aEnd:  null, aDuration:  null, aRelative:  aStart.z, aCallback:  aEnd.z);
        }
        public static void Translate(UnityEngine.Transform aTransform, UnityEngine.AnimationCurve aCurve, UnityEngine.Vector3 aStart, UnityEngine.Vector3 aEnd, float aDuration, bool aRelative = False, System.Action aCallback)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_14;
            var val_15;
            var val_16;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_14 = val_2;
            val_15 = val_3;
            val_16 = val_4;
            UnityEngine.Transform val_5 = aTransform.parent;
            if(aTransform != 0)
            {
                    UnityEngine.Transform val_7 = aTransform.parent;
                UnityEngine.Vector3 val_8 = position;
                val_14 = val_2;
                val_15 = val_3;
                val_16 = val_4;
            }
            
            float val_10 = aEnd.x - val_14;
            Ferr.Juice.Add(aTransform:  aTransform, aType:  8, aCurve:  aCurve, aStart:  val_10, aEnd:  val_8.y, aDuration:  val_8.z, aRelative:  aStart.x - val_14, aCallback:  val_10);
            float val_12 = aStart.y;
            val_12 = val_12 - val_15;
            float val_13 = aEnd.y;
            val_13 = val_13 - val_15;
            Ferr.Juice.Add(aTransform:  aTransform, aType:  16, aCurve:  aCurve, aStart:  val_13, aEnd:  val_8.y, aDuration:  val_8.z, aRelative:  val_12, aCallback:  val_13);
            float val_14 = aStart.z;
            val_14 = val_14 - val_16;
            float val_15 = aEnd.z;
            val_15 = val_15 - val_16;
            Ferr.Juice.Add(aTransform:  aTransform, aType:  32, aCurve:  aCurve, aStart:  val_15, aEnd:  val_8.y, aDuration:  val_8.z, aRelative:  val_14, aCallback:  val_15);
        }
        public static void TranslateLocal(UnityEngine.Transform aTransform, UnityEngine.AnimationCurve aCurve, UnityEngine.Vector3 aStart, UnityEngine.Vector3 aEnd, float aDuration, bool aRelative = False, System.Action aCallback)
        {
            Ferr.Juice.Add(aTransform:  aTransform, aType:  8, aCurve:  aCurve, aStart:  aDuration, aEnd:  null, aDuration:  null, aRelative:  aStart.x, aCallback:  aEnd.x);
            Ferr.Juice.Add(aTransform:  aTransform, aType:  16, aCurve:  aCurve, aStart:  aDuration, aEnd:  null, aDuration:  null, aRelative:  aStart.y, aCallback:  aEnd.y);
            Ferr.Juice.Add(aTransform:  aTransform, aType:  32, aCurve:  aCurve, aStart:  aDuration, aEnd:  null, aDuration:  null, aRelative:  aStart.z, aCallback:  aEnd.z);
        }
        public static void Color(UnityEngine.Material aRenderer, UnityEngine.AnimationCurve aCurve, UnityEngine.Color aStart, UnityEngine.Color aEnd, float aDuration, System.Action aCallback)
        {
            var val_1;
            UnityEngine.AnimationCurve val_7 = aCurve;
            object val_2 = 536889405;
            val_2 = new System.Object();
            if(val_2 != 0)
            {
                    mem[536889413] = aRenderer;
                mem[536889457] = val_7;
            }
            else
            {
                    mem[8] = aRenderer;
                mem[52] = val_7;
            }
            
            var val_3 = val_2 + 16;
            mem[536889417] = aStart.r;
            if(val_2 != 0)
            {
                    mem[536889449] = aCallback;
                float val_4 = UnityEngine.Time.time;
                mem[536889453] = 0;
            }
            else
            {
                    mem[44] = aCallback;
                float val_5 = UnityEngine.Time.time;
                val_7 = 0;
                mem[48] = val_7;
            }
            
            mem[536889433] = aEnd.r;
            mem[536889437] = aEnd.g;
            mem[536889441] = aEnd.b;
            mem[536889445] = aEnd.a;
            mem[536889461] = val_1;
            Ferr.Juice val_6 = Ferr.Juice.Instance;
            mem[536889413].Add(item:  536889405);
            bool val_7 = val_2.Update();
        }
        public static void Cancel(UnityEngine.Transform aTransform, bool aFinishEffect = True)
        {
            var val_7 = 0;
            goto label_1;
            label_26:
            Ferr.Juice val_1 = Ferr.Juice.Instance;
            if((mem[536889411] + 12) <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = mem[536889411] + 8;
            val_7 = val_7 + 0;
            if(((mem[536889411] + 8 + 0) + 16 + 12) == aTransform)
            {
                    if(aFinishEffect != false)
            {
                    Ferr.Juice val_3 = Ferr.Juice.Instance;
                if((mem[536889411] + 12) <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_8 = mem[536889411] + 8;
                val_8 = val_8 + 0;
                mem2[0] = 3323740160;
                bool val_4 = (mem[536889411] + 8 + 0) + 16.Update();
            }
            
                Ferr.Juice val_5 = Ferr.Juice.Instance;
                mem[536889411].RemoveAt(index:  0);
            }
            
            val_7 = 0;
            label_1:
            Ferr.Juice val_6 = Ferr.Juice.Instance;
            if(val_7 < (mem[536889411] + 12))
            {
                goto label_26;
            }
        
        }
        public static void Cancel(UnityEngine.Renderer aRenderer, bool aFinishEffect = True)
        {
            var val_7 = 0;
            goto label_1;
            label_26:
            Ferr.Juice val_1 = Ferr.Juice.Instance;
            if((mem[536889415] + 12) <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = mem[536889415] + 8;
            val_7 = val_7 + 0;
            if(((mem[536889415] + 8 + 0) + 16 + 8) == aRenderer)
            {
                    if(aFinishEffect != false)
            {
                    Ferr.Juice val_3 = Ferr.Juice.Instance;
                if((mem[536889415] + 12) <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_8 = mem[536889415] + 8;
                val_8 = val_8 + 0;
                mem2[0] = 3323740160;
                bool val_4 = (mem[536889415] + 8 + 0) + 16.Update();
            }
            
                Ferr.Juice val_5 = Ferr.Juice.Instance;
                mem[536889415].RemoveAt(index:  0);
            }
            
            val_7 = 0;
            label_1:
            Ferr.Juice val_6 = Ferr.Juice.Instance;
            if(val_7 < (mem[536889415] + 12))
            {
                goto label_26;
            }
        
        }
        public static void SlowMo(float aSpeed)
        {
            UnityEngine.Time.timeScale = aSpeed;
            float val_1 = UnityEngine.Time.timeScale;
            float val_2 = 0.02f;
            val_2 = 0 * val_2;
            UnityEngine.Time.fixedDeltaTime = val_2;
        }
        public static void Sleep(float aDuration)
        {
            float val_10;
            Ferr.Juice val_1 = Ferr.Juice.Instance;
            float val_2 = UnityEngine.Time.timeScale;
            if(mem[536889515] == 0)
            {
                    Ferr.Juice val_3 = Ferr.Juice.Instance;
                val_10 = mem[536889419];
            }
            else
            {
                    val_10 = 0;
            }
            
            mem[536889419] = val_10;
            UnityEngine.Time.timeScale = UnityEngine.Time.timeScale;
            Ferr.Juice val_5 = Ferr.Juice.Instance;
            mem[536889427] = 1;
            Ferr.Juice val_6 = Ferr.Juice.Instance;
            float val_7 = UnityEngine.Time.realtimeSinceStartup;
            mem[25] = 0 + 0;
        }
        public static void SleepMS(int aMilliseconds)
        {
            float val_1 = (float)aMilliseconds;
            val_1 = val_1 * 0.001f;
            Ferr.Juice.Sleep(aDuration:  val_1);
        }
        private static Juice()
        {
        
        }
    
    }

}
