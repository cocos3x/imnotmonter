using UnityEngine;

namespace Ferr.Example
{
    public class InfiniteTerrain : MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform _trackObject;
        private Ferr.Example.InfiniteTerrainChunk[] _terrainPrefabs;
        private float[] _terrainPrefabWeights;
        private float _generateDistanceRight;
        private float _generateDistanceLeft;
        private float _weightSum;
        private System.Collections.Generic.List<Ferr.Example.InfiniteTerrainChunk> _activeInstances;
        private System.Collections.Generic.Dictionary<Ferr.Example.InfiniteTerrainChunk, System.Collections.Generic.List<Ferr.Example.InfiniteTerrainChunk>> _terrainPool;
        
        // Methods
        private void Awake()
        {
            var val_3;
            float val_1 = this.GetWeightSum();
            this._weightSum = this;
            val_3 = 0;
            goto label_0;
            label_4:
            Ferr.Example.InfiniteTerrainChunk val_2 = this.GetFreePrefabInstance(aPrefab:  this._terrainPrefabs[val_3]);
            val_3 = 1;
            label_0:
            if(val_3 < this)
            {
                goto label_4;
            }
        
        }
        private void Start()
        {
            this.AddInstances();
            this.ClipInstances();
        }
        private void Update()
        {
            this.AddInstances();
            this.ClipInstances();
        }
        private void AddInstances()
        {
            var val_3;
            var val_6;
            var val_8;
            var val_12;
            Ferr.Example.Side val_13;
            var val_14;
            var val_15;
            UnityEngine.Transform val_16;
            UnityEngine.Vector3 val_1 = GetLeftmost();
            val_13 = 0;
            UnityEngine.Vector3 val_2 = position;
            float val_4 = val_3 - this._generateDistanceLeft;
            if(this._trackObject >= 0)
            {
                goto label_2;
            }
            
            label_3:
            this.AddNewChunk(aTo:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7}, aSide:  val_13);
            UnityEngine.Vector3 val_5 = GetLeftmost();
            if(this._trackObject >= 0)
            {
                goto label_2;
            }
            
            val_12 = val_6;
            var val_7 = 0 + 1;
            if(0 != 0)
            {
                goto label_3;
            }
            
            label_2:
            UnityEngine.Vector3 val_9 = GetRightmost();
            val_16 = this._trackObject;
            UnityEngine.Vector3 val_10 = position;
            float val_11 = val_3 + this._generateDistanceRight;
            if(val_16 <= 0)
            {
                    return;
            }
            
            val_13 = 1;
            do
            {
                this.AddNewChunk(aTo:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7}, aSide:  val_13);
                UnityEngine.Vector3 val_12 = GetRightmost();
                if(val_16 <= 0)
            {
                    return;
            }
            
                val_14 = val_6;
                var val_13 = 0 + 1;
                val_15 = val_8;
            }
            while(0 != 0);
        
        }
        private UnityEngine.Vector3 GetLeftmost()
        {
            var val_2;
            var val_3;
            Ferr.Example.InfiniteTerrain val_4;
            var val_10;
            var val_11;
            Ferr.Example.InfiniteTerrain val_12;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_10 = 4;
            val_11 = val_3;
            val_12 = val_4;
            goto label_1;
            label_10:
            if((R1 + 36 + 12) <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.Vector3 val_5 = LeftHook;
            if((R1 + 36 + 8 + 16) < 0)
            {
                    if((R1 + 36 + 12) <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.Vector3 val_6 = LeftHook;
                val_11 = val_3;
                val_12 = val_4;
            }
            
            val_10 = 5;
            label_1:
            if((val_10 - 4) < (R1 + 36 + 12))
            {
                goto label_10;
            }
            
            this = val_12;
            mem[1152921510174737492] = val_11;
            mem[1152921510174737496] = val_2;
            return new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        private UnityEngine.Vector3 GetRightmost()
        {
            var val_2;
            var val_3;
            Ferr.Example.InfiniteTerrain val_4;
            var val_10;
            var val_11;
            Ferr.Example.InfiniteTerrain val_12;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_10 = 4;
            val_11 = val_3;
            val_12 = val_4;
            goto label_1;
            label_10:
            if((R1 + 36 + 12) <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.Vector3 val_5 = RightHook;
            if((R1 + 36 + 8 + 16) > 0)
            {
                    if((R1 + 36 + 12) <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.Vector3 val_6 = RightHook;
                val_11 = val_3;
                val_12 = val_4;
            }
            
            val_10 = 5;
            label_1:
            if((val_10 - 4) < (R1 + 36 + 12))
            {
                goto label_10;
            }
            
            this = val_12;
            mem[1152921510174849492] = val_11;
            mem[1152921510174849496] = val_2;
            return new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        private void ClipInstances()
        {
            var val_2;
            System.Collections.Generic.List<Ferr.Example.InfiniteTerrainChunk> val_8;
            UnityEngine.Vector3 val_1 = position;
            var val_8 = val_2;
            UnityEngine.Vector3 val_3 = position;
            if(1273163843 < 0)
            {
                    return;
            }
            
            val_8 = val_8 - this._generateDistanceLeft;
            float val_4 = val_2 + this._generateDistanceRight;
            label_18:
            if(1273163844 <= 1273163843)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.Vector3 val_5 = RightHook;
            if(mem[797688092] < 0)
            {
                goto label_8;
            }
            
            if( <= 1273163843)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = mem[797688092];
            UnityEngine.Vector3 val_6 = LeftHook;
            if(val_8 <= 0)
            {
                goto label_12;
            }
            
            label_8:
            if( <= 1273163843)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.GameObject val_7 = mem[797688092].gameObject;
            mem[797688092].SetActive(value:  false);
            val_8 = this._activeInstances;
            val_8.RemoveAt(index:  1273163843);
            label_12:
            if(1273163842 > 1)
            {
                goto label_18;
            }
        
        }
        private void AddNewChunk(UnityEngine.Vector3 aTo, Ferr.Example.Side aSide)
        {
            Ferr.Example.InfiniteTerrainChunk val_1 = this.GetRandomPrefab();
            Ferr.Example.InfiniteTerrainChunk val_2 = this.GetFreePrefabInstance(aPrefab:  1273324752);
            if(this != 0)
            {
                    this.ConnectTo(aToHook:  new UnityEngine.Vector3() {x = aTo.x, y = aTo.y, z = aTo.z}, aToHookSide:  aSide);
            }
            else
            {
                    0.ConnectTo(aToHook:  new UnityEngine.Vector3() {x = aTo.x, y = aTo.y, z = aTo.z}, aToHookSide:  aSide);
            }
            
            UnityEngine.GameObject val_3 = this.gameObject;
            this.SetActive(value:  true);
            this._activeInstances.Add(item:  1273324752);
        }
        private Ferr.Example.InfiniteTerrainChunk GetFreePrefabInstance(Ferr.Example.InfiniteTerrainChunk aPrefab)
        {
            var val_10;
            AdjustmentRule val_11;
            if((this._terrainPool.TryGetValue(key:  aPrefab, value: out  System.Collections.Generic.List<Ferr.Example.InfiniteTerrainChunk> val_1 = 1273445204)) != true)
            {
                    536877983 = new System.Collections.Generic.List<Page>();
                this._terrainPool.Add(key:  aPrefab, value:  536877983);
            }
            
            val_10 = 4;
            goto label_4;
            label_11:
            if(mem[536877995] <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.GameObject val_4 = mem[536877991] + 16.gameObject;
            if((mem[536877991] + 16.activeSelf) == false)
            {
                goto label_9;
            }
            
            val_10 = 5;
            label_4:
            if((val_10 - 4) < mem[536877995])
            {
                goto label_11;
            }
            
            UnityEngine.GameObject val_7 = aPrefab.gameObject;
            DropdownItem val_8 = UnityEngine.Object.Instantiate<DropdownItem>(original:  aPrefab);
            if(aPrefab == 0)
            {
                goto label_15;
            }
            
            Weight val_9 = aPrefab.GetComponent<Weight>();
            val_11 = aPrefab;
            goto label_16;
            label_9:
            if(mem[536877995] <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_11 = mem[mem[536877991] + 16];
            val_11 = mem[536877991] + 16;
            return;
            label_15:
            Weight val_10 = aPrefab.GetComponent<Weight>();
            val_11 = aPrefab;
            label_16:
            aPrefab.SetActive(value:  false);
            536877983.Add(item:  val_11);
        }
        private Ferr.Example.InfiniteTerrainChunk GetRandomPrefab()
        {
            var val_3;
            System.Single[] val_4;
            val_3 = 0;
            float val_1 = UnityEngine.Random.value;
            float val_3 = 0f;
            float val_2 = 0 * this._weightSum;
            goto label_0;
            label_5:
            val_4 = this._terrainPrefabWeights;
            val_3 = val_3 + 1152921505398370160;
            if(0 <= val_3)
            {
                goto label_3;
            }
            
            val_3 = 1;
            label_0:
            val_4 = this._terrainPrefabWeights;
            if(val_3 < val_4[16])
            {
                goto label_5;
            }
            
            return;
            label_3:
            Ferr.Example.InfiniteTerrainChunk val_4 = this._terrainPrefabs[0];
        }
        private float GetWeightSum()
        {
            float val_1;
            var val_2;
            var val_3;
            val_1 = 0f;
            val_2 = 0;
            val_3 = 16;
            goto label_0;
            label_4:
            val_3 = 20;
            val_2 = 1;
            val_1 = val_1 + 1152921505398370160;
            label_0:
            if(val_2 < this._terrainPrefabWeights[val_3])
            {
                goto label_4;
            }
            
            return (float)null;
        }
        private void OnValidate()
        {
            if(R1 != true)
            {
                    this._terrainPrefabWeights = this._terrainPrefabs;
                System.Array.Resize<System.Single>(array: ref  T[] val_1 = 1274292964, newSize:  0);
            }
            
            float val_2 = this.GetWeightSum();
            this._weightSum = this;
        }
        public InfiniteTerrain()
        {
            this._generateDistanceRight = 10f;
            this._generateDistanceLeft = 10f;
            536877983 = new System.Collections.Generic.List<Page>();
            this._activeInstances = 536877983;
            536874181 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
            this._terrainPool = 536874181;
        }
    
    }

}
