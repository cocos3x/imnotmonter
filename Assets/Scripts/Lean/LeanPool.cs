using UnityEngine;

namespace Lean
{
    public class LeanPool : MonoBehaviour
    {
        // Fields
        public static System.Collections.Generic.List<Lean.LeanPool> AllPools;
        public static System.Collections.Generic.Dictionary<UnityEngine.GameObject, Lean.LeanPool> AllLinks;
        public UnityEngine.GameObject Prefab;
        public int Preload;
        public int Capacity;
        public Lean.LeanPool.NotificationType Notification;
        private System.Collections.Generic.List<UnityEngine.GameObject> cache;
        private System.Collections.Generic.List<Lean.LeanPool.DelayedDestruction> delayedDestructions;
        private int total;
        
        // Properties
        public int Total { get; }
        public int Cached { get; }
        
        // Methods
        public static T Spawn<T>(T prefab)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
            if((mem[536889704] & true) != 0)
            {
                    return;
            }
            
            if(mem[536889633] != 0)
            {
                    return;
            }
        
        }
        public static T Spawn<T>(T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        {
            float val_1;
            float val_2;
            val_1 = rotation.w;
            val_2 = rotation.z;
            if((mem[536889704] & true) != 0)
            {
                    return;
            }
            
            if(mem[536889633] != 0)
            {
                    return;
            }
            
            val_2 = rotation.z;
            val_1 = rotation.w;
        }
        public static T Spawn<T>(T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        {
            UnityEngine.Object val_7;
            float val_8;
            float val_9;
            float val_10;
            UnityEngine.Transform val_11;
            UnityEngine.GameObject val_12;
            val_7 = prefab;
            val_11 = parent;
            val_12 = 0;
            if(val_7 != 0)
            {
                    UnityEngine.GameObject val_2 = val_7.gameObject;
                val_12 = val_7;
            }
            
            UnityEngine.GameObject val_3 = Lean.LeanPool.Spawn(prefab:  val_12, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = val_8, y = val_9, z = val_10, w = rotation.w}, parent:  val_11);
            if(val_12 != 0)
            {
                    if(val_12 != 0)
            {
                goto __RuntimeMethodHiddenParam + 24 + 4;
            }
            
            }
            else
            {
                    var val_5 = FP - 28;
            }
        
        }
        public static UnityEngine.GameObject Spawn(UnityEngine.GameObject prefab)
        {
            float val_2;
            float val_3;
            float val_4;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
            UnityEngine.GameObject val_6 = Lean.LeanPool.Spawn(prefab:  prefab, position:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4}, rotation:  new UnityEngine.Quaternion(), parent:  0);
        }
        public static UnityEngine.GameObject Spawn(UnityEngine.GameObject prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        {
            if(((mem[536889704] & true) == 0) && (mem[536889633] == 0))
            {
                    rotation.w = rotation.w;
            }
            
            UnityEngine.GameObject val_1 = Lean.LeanPool.Spawn(prefab:  prefab, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w}, parent:  0);
        }
        public static UnityEngine.GameObject Spawn(UnityEngine.GameObject prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        {
            float val_12;
            float val_13;
            UnityEngine.Object val_14;
            var val_15;
            UnityEngine.Object val_16;
            var val_17;
            val_12 = position.y;
            val_13 = position.x;
            LeanPool.<>c__DisplayClass16_0 val_1 = 536899523;
            val_1 = new LeanPool.<>c__DisplayClass16_0();
            if(val_1 != 0)
            {
                    val_14 = val_1;
                mem[536899531] = prefab;
            }
            else
            {
                    val_14 = 8;
                mem[8] = prefab;
            }
            
            if(val_14 == 0)
            {
                goto label_5;
            }
            
            val_15 = 536889517;
            if(((mem[536889704] & true) == 0) && (mem[536889633] == 0))
            {
                    val_15 = 536889517;
            }
            
            536879225 = new System.Predicate<Page>(object:  536899523, method:  new IntPtr(1610686293));
            Page val_4 = mem[536889609].Find(match:  536879225);
            val_16 = mem[536889609];
            if(val_16 != 0)
            {
                goto label_11;
            }
            
            string val_6 = mem[8].name;
            string val_7 = mem[8] + -1610612437(-1610612437);
            UnityEngine.GameObject val_8 = 536887303;
            val_8 = new UnityEngine.GameObject(name:  mem[8]);
            SynchronizationContextBehavoir val_9 = val_8.AddComponent<SynchronizationContextBehavoir>();
            val_16 = val_8;
            val_14 = val_12;
            mem[536887315] = mem[8];
            val_12 = val_16;
            goto label_17;
            label_5:
            UnityEngine.Debug.LogError(message:  -1610610033);
            return;
            label_11:
            if(val_16 != 0)
            {
                    val_12 = val_16;
            }
            else
            {
                    val_12 = 0;
            }
            
            val_14 = val_12;
            label_17:
            val_13 = rotation.x;
            UnityEngine.GameObject val_10 = val_16.FastSpawn(position:  new UnityEngine.Vector3() {x = val_13, y = val_14, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = val_13, y = rotation.y, z = rotation.z, w = rotation.w}, parent:  parent);
            if(val_16 == 0)
            {
                    return;
            }
            
            val_17 = 536889517;
            if(((mem[536889704] & true) == 0) && (mem[536889633] == 0))
            {
                    val_17 = 536889517;
            }
            
            mem[536889609] + 4.Add(key:  val_16, value:  0);
            if(val_16 != 0)
            {
                    return val_16.gameObject;
            }
            
            return val_16.gameObject;
        }
        public static void Despawn(UnityEngine.Component clone, float delay = 0)
        {
            if(clone == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = R4.gameObject;
            Lean.LeanPool.Despawn(clone:  R4, delay:  delay);
        }
        public static void Despawn(UnityEngine.GameObject clone, float delay = 0)
        {
            var val_7;
            var val_8;
            var val_9;
            val_7 = 0;
            if(clone == 0)
            {
                goto label_3;
            }
            
            val_8 = 536889517;
            if(((mem[536889704] & true) == 0) && (mem[536889633] == 0))
            {
                    val_8 = 536889517;
            }
            
            val_7 = mem[mem[536889609] + 4];
            val_7 = mem[536889609] + 4;
            if((val_7.TryGetValue(key:  clone, value: out  MonoCustomAttrs.AttributeInfo val_2 = 1118242700)) == false)
            {
                goto label_7;
            }
            
            val_9 = 536889517;
            if(((mem[536889704] & true) == 0) && (mem[536889633] == 0))
            {
                    val_9 = 536889517;
            }
            
            bool val_4 = mem[536889609] + 4.Remove(key:  clone);
            val_7 = val_7;
            this.FastDespawn(clone:  clone, delay:  delay);
            return;
            label_3:
            UnityEngine.Debug.LogError(message:  -1610610037);
            return;
            label_7:
            string val_5 = clone.name;
            string val_6 = -1610610039(-1610610039) + clone + -1610611867(-1610611867);
            UnityEngine.Debug.LogError(message:  -1610610039);
            UnityEngine.Object.Destroy(obj:  clone);
        }
        public int get_Total()
        {
            return (int)this.total;
        }
        public int get_Cached()
        {
            if(this.cache != 0)
            {
                    return (int)true;
            }
            
            return (int)true;
        }
        public UnityEngine.GameObject FastSpawn(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        {
            float val_7;
            float val_8;
            System.Collections.Generic.List<UnityEngine.GameObject> val_9;
            var val_10;
            float val_11;
            System.Collections.Generic.List<UnityEngine.GameObject> val_12;
            UnityEngine.Object val_13;
            val_7 = position.z;
            val_8 = position.y;
            val_9 = position.x;
            val_10 = 0;
            if(this.Prefab == 0)
            {
                goto label_3;
            }
            
            val_8 = 22736596;
            val_11 = 4.032695E-38f;
            val_7 = 22710356;
            goto label_4;
            label_15:
            val_12 = this.cache;
            if(this.cache != 0)
            {
                goto label_5;
            }
            
            val_12 = this.cache;
            if(val_12 == 0)
            {
                goto label_6;
            }
            
            label_5:
            if(0 <= 1118615551)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = this.cache;
            val_7 = val_7 + 179494908;
            val_13 = mem[(0 + 179494908) + 16];
            val_13 = (0 + 179494908) + 16;
            val_9.RemoveAt(index:  1118615551);
            if(val_13 != 0)
            {
                goto label_11;
            }
            
            string val_3 = this.name;
            val_10 = -1610612303;
            string val_4 = -1610603985(-1610603985) + 1118627600 + -1610612303(-1610612303);
            UnityEngine.Debug.LogError(message:  -1610603985);
            label_4:
            if((-1610603985) > 0)
            {
                goto label_15;
            }
            
            if(this.Capacity >= 1)
            {
                    0 = this.total;
                val_13 = 0;
            }
            
            if(0 >= this.Capacity)
            {
                    return;
            }
            
            UnityEngine.GameObject val_5 = this.FastClone(position:  new UnityEngine.Vector3() {x = val_9, y = val_8, z = val_7}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w}, parent:  parent);
            val_13 = this;
            goto label_17;
            label_3:
            val_13 = 0;
            UnityEngine.Debug.LogError(message:  -1610610031);
            return;
            label_11:
            val_7 = 0;
            UnityEngine.Transform val_6 = val_13.transform;
            val_9 = val_7;
            val_11 = val_13;
            val_8 = val_8;
            if(val_13 != 0)
            {
                    val_11.localPosition = new UnityEngine.Vector3() {x = val_9, y = val_8, z = val_9};
                val_11.localRotation = new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w};
            }
            else
            {
                    0.localPosition = new UnityEngine.Vector3() {x = val_9, y = val_8, z = val_9};
                0.localRotation = new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w};
            }
            
            val_11.SetParent(parent:  parent, worldPositionStays:  false);
            val_13.SetActive(value:  true);
            label_17:
            this.SendNotification(clone:  val_13, messageName:  -1610605633);
            return;
            label_6:
        }
        public void FastDespawn(UnityEngine.GameObject clone, float delay = 0)
        {
            UnityEngine.Object val_9;
            var val_10;
            LeanPool.<>c__DisplayClass24_0 val_1 = 536899525;
            val_1 = new LeanPool.<>c__DisplayClass24_0();
            if(val_1 != 0)
            {
                    val_9 = val_1;
                mem[536899533] = clone;
            }
            else
            {
                    val_9 = 8;
                mem[8] = clone;
            }
            
            bool val_2 = UnityEngine.Object.op_Inequality(x:  val_9, y:  0);
            if(val_2 == false)
            {
                goto label_5;
            }
            
            if(val_2 <= false)
            {
                goto label_6;
            }
            
            536879275 = new System.Predicate<Page>(object:  536899525, method:  new IntPtr(1610686297));
            if((this.delayedDestructions.Exists(match:  536879275)) == false)
            {
                goto label_8;
            }
            
            return;
            label_5:
            UnityEngine.Debug.LogWarning(message:  -1610610037);
            return;
            label_6:
            this.cache.Add(item:  mem[8]);
            if(val_1 == 0)
            {
                goto label_13;
            }
            
            this.SendNotification(clone:  mem[8], messageName:  -1610605745);
            goto label_14;
            label_8:
            DelayedDestruction val_5 = Lean.LeanClassPool<DelayedDestruction>.Spawn();
            val_10 = -1073717583;
            if((-1073717583) == 0)
            {
                    LeanPool.DelayedDestruction val_6 = 536899527;
                val_10 = val_6;
                val_6 = new LeanPool.DelayedDestruction();
            }
            
            if(val_10 == 0)
            {
                goto label_19;
            }
            
            mem[536899535] = mem[8];
            goto label_20;
            label_13:
            this.SendNotification(clone:  mem[8], messageName:  -1610605745);
            label_14:
            mem[8].SetActive(value:  false);
            UnityEngine.Transform val_7 = mem[8].transform;
            UnityEngine.Transform val_8 = this.transform;
            mem[8].SetParent(parent:  1118780560, worldPositionStays:  false);
            return;
            label_19:
            mem[8] = mem[8];
            label_20:
            mem[536899539] = R2;
            this.delayedDestructions.Add(item:  536899527);
        }
        public void FastPreload()
        {
            if(this.Prefab == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            UnityEngine.GameObject val_4 = this.FastClone(position:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7}, rotation:  new UnityEngine.Quaternion(), parent:  0);
            this.cache.Add(item:  1118917136);
            if(this != 0)
            {
                    this.SetActive(value:  false);
            }
            else
            {
                    0.SetActive(value:  false);
            }
            
            UnityEngine.Transform val_5 = this.transform;
            UnityEngine.Transform val_6 = this.transform;
            this.SetParent(parent:  1118917136, worldPositionStays:  false);
        }
        protected virtual void Awake()
        {
            this.UpdatePreload();
        }
        protected virtual void OnEnable()
        {
            if(((mem[536889704] & true) == 0) && (mem[536889633] == 0))
            {
                    536889517 = 536889517;
            }
            
            mem[536889609].Add(item:  1119149328);
        }
        protected virtual void OnDisable()
        {
            if(((mem[536889704] & true) == 0) && (mem[536889633] == 0))
            {
                    536889517 = 536889517;
            }
            
            bool val_1 = mem[536889609].Remove(item:  1119261328);
        }
        protected virtual void Update()
        {
            bool val_7 = true;
            if((val_7 - 1) < 0)
            {
                    return;
            }
            
            val_7 = val_7 + 3;
            label_11:
            int val_2 = val_7 - 4;
            if(val_7 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            bool val_3 = UnityEngine.Object.op_Inequality(x:  0 + ((true + 3)) << 2 + 8, y:  0);
            if(val_3 == false)
            {
                goto label_8;
            }
            
            float val_4 = UnityEngine.Time.deltaTime;
            uint val_8 = 0;
            val_8 = (0 + ((true + 3)) << 2 + 12) - val_8;
            mem2[0] = val_8;
            if(val_3 > false)
            {
                goto label_10;
            }
            
            this.RemoveDelayedDestruction(index:  val_2);
            this.FastDespawn(clone:  0 + ((true + 3)) << 2 + 8, delay:  val_8);
            goto label_10;
            label_8:
            this.RemoveDelayedDestruction(index:  val_2);
            label_10:
            var val_6 = val_7 - 1;
            if((val_7 - 5) > 1)
            {
                goto label_11;
            }
        
        }
        private void RemoveDelayedDestruction(int index)
        {
            if(true <= index)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (index << 2);
            this.delayedDestructions.RemoveAt(index:  index);
            Lean.LeanClassPool<DelayedDestruction>.Despawn(instance:  (0 + (index) << 2) + 16);
        }
        private void UpdatePreload()
        {
            var val_2;
            var val_3;
            if(this.Prefab == 0)
            {
                    return;
            }
            
            val_2 = mem[R4 + 16];
            val_2 = R4 + 16;
            val_3 = mem[R4 + 36];
            val_3 = R4 + 36;
            goto label_3;
            label_4:
            R4.FastPreload();
            val_2 = mem[R4 + 16];
            val_2 = R4 + 16;
            val_3 = val_3 + 1;
            label_3:
            if(val_3 < val_2)
            {
                goto label_4;
            }
        
        }
        private UnityEngine.GameObject FastClone(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        {
            float val_6;
            float val_7;
            val_6 = rotation.w;
            val_7 = rotation.z;
            if(((mem[536891408] & true) == 0) && (mem[536891337] == 0))
            {
                    val_7 = rotation.z;
                val_6 = rotation.w;
            }
            
            object val_1 = UnityEngine.Object.Instantiate<System.Object>(original:  this.Prefab, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = val_7, w = val_6});
            int val_6 = this.total;
            val_6 = val_6 + 1;
            this.total = val_6;
            string val_2 = this.Prefab.name;
            string val_3 = this.total.ToString();
            string val_4 = this.Prefab + -1610612561(-1610612561) + 1119758516;
            if(this.Prefab != 0)
            {
                    this.Prefab.name = this.Prefab;
            }
            else
            {
                    0.name = this.Prefab;
            }
            
            UnityEngine.Transform val_5 = this.Prefab.transform;
            this.Prefab.SetParent(parent:  parent, worldPositionStays:  false);
        }
        private void SendNotification(UnityEngine.GameObject clone, string messageName)
        {
            if(this.Notification != 2)
            {
                    if(this.Notification != 1)
            {
                    return;
            }
            
                R5.SendMessage(methodName:  R4, options:  1);
                return;
            }
            
            clone.BroadcastMessage(methodName:  messageName, options:  1);
        }
        public LeanPool()
        {
            this.Notification = 1;
            536877883 = new System.Collections.Generic.List<Page>();
            this.cache = 536877883;
            536878619 = new System.Collections.Generic.List<Page>();
            this.delayedDestructions = 536878619;
        }
        private static LeanPool()
        {
            536878045 = new System.Collections.Generic.List<Page>();
            mem2[0] = 536878045;
            536874163 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
            mem2[0] = 536874163;
        }
    
    }

}
