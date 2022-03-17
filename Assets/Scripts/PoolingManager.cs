using UnityEngine;
public class PoolingManager : SingletonMonoBehaviour<PoolingManager>
{
    // Fields
    public PoolingInfo[] vfxPoolingInfo;
    private System.Collections.Generic.List<UnityEngine.GameObject> listVFXPool;
    public PoolingInfo[] gameObjectPoolingInfo;
    private System.Collections.Generic.List<UnityEngine.GameObject> listObjectPool;
    
    // Methods
    private void Start()
    {
        this.StartSpawnObject();
    }
    private void OnValidate()
    {
        var val_3;
        PoolingInfo[] val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        if(true == 0)
        {
            goto label_2;
        }
        
        val_3 = 0;
        val_4 = this.vfxPoolingInfo;
        val_6 = 22713404;
        goto label_3;
        label_10:
        val_7 = 536890899;
        val_8 = val_7;
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        typeof(PoolingInfo[]).__il2cppRuntimeField_10 = mem[536890899];
        typeof(PoolingInfo[]).__il2cppRuntimeField_8 = val_8;
        val_3 = 1;
        label_3:
        if(val_3 < 1152921506700751848)
        {
            goto label_10;
        }
        
        label_2:
        if((mem[1152921509467164580] + 12) == 0)
        {
                return;
        }
        
        val_5 = mem[1152921509467164580];
        val_8 = 0;
        val_6 = val_5 + 16;
        val_4 = 4.014663E-38f;
        goto label_13;
        label_20:
        var val_1 = ((mem[1152921509467164580] + 16) + 0) + 16;
        val_7 = 536890899;
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536890899];
        mem2[0] = val_7;
        val_8 = 1;
        label_13:
        if(val_8 < (mem[1152921509467164580] + 12))
        {
            goto label_20;
        }
    
    }
    public void StartSpawnObject()
    {
        PoolingInfo[] val_5;
        var val_6;
        PoolingInfo val_7;
        UnityEngine.GameObject val_8;
        var val_9;
        var val_10;
        PoolingInfo[] val_11;
        var val_12;
        val_5 = this.vfxPoolingInfo;
        val_6 = 0;
        goto label_1;
        label_15:
        val_7 = val_5[val_6];
        if((this.vfxPoolingInfo[0x0][0].prefabType == 0) && (this.vfxPoolingInfo[0x0][0].countStartSpawn >= 1))
        {
                do
        {
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.RectTransform val_2 = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  this.vfxPoolingInfo[0x0][0].prefab, parent:  565605648);
            val_8 = this.vfxPoolingInfo[0x0][0].prefab;
            val_9 = 536890899;
            Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
            mem2[0] = mem[536890899];
            if(val_8 != 0)
        {
                val_8.name = 536890899;
        }
        else
        {
                0.name = 536890899;
        }
        
            val_8.SetActive(value:  false);
            this.listVFXPool.Add(item:  val_8);
            val_10 = 0 + 1;
        }
        while(val_10 < this.vfxPoolingInfo[0x0][0].countStartSpawn);
        
        }
        
        val_5 = val_5;
        val_6 = val_6 + 1;
        label_1:
        if(val_6 < (this.vfxPoolingInfo + 12))
        {
            goto label_15;
        }
        
        val_11 = this.gameObjectPoolingInfo;
        val_12 = 0;
        goto label_16;
        label_30:
        PoolingInfo val_5 = val_11[val_12];
        if((this.gameObjectPoolingInfo[0x0][0].prefabType == 1) && (this.gameObjectPoolingInfo[0x0][0].countStartSpawn >= 1))
        {
                val_7 = this.gameObjectPoolingInfo[0x0][0].namePrefab;
            do
        {
            UnityEngine.Transform val_3 = this.transform;
            UnityEngine.RectTransform val_4 = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  this.gameObjectPoolingInfo[0x0][0].prefab, parent:  565605648);
            val_8 = this.gameObjectPoolingInfo[0x0][0].prefab;
            val_9 = 536890899;
            Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
            mem2[0] = mem[536890899];
            if(val_8 != 0)
        {
                val_8.name = 536890899;
        }
        else
        {
                0.name = 536890899;
        }
        
            val_8.SetActive(value:  false);
            this.listObjectPool.Add(item:  val_8);
            val_10 = 0 + 1;
        }
        while(val_10 < this.gameObjectPoolingInfo[0x0][0].countStartSpawn);
        
        }
        
        val_11 = val_11;
        val_12 = val_12 + 1;
        label_16:
        if(val_12 < (this.gameObjectPoolingInfo + 12))
        {
            goto label_30;
        }
    
    }
    public UnityEngine.GameObject GetVFX(NamePrefabPool name)
    {
        string val_3;
        string val_10;
        string val_11;
        PoolingInfo[] val_12;
        var val_13;
        var val_14;
        var val_15;
        PoolingInfo val_16;
        if(true <= 0)
        {
            goto label_2;
        }
        
        List.Enumerator<T> val_1 = GetEnumerator();
        label_9:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        val_10 = val_3;
        if(val_10.activeSelf == true)
        {
            goto label_9;
        }
        
        string val_5 = val_10.name;
        val_11 = val_10;
        val_12 = 536890899;
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        if((System.String.op_Equality(a:  val_11, b:  536890899)) == false)
        {
            goto label_9;
        }
        
        val_13 = 316;
        val_10.SetActive(value:  true);
        goto label_11;
        label_4:
        val_10 = 0;
        val_13 = 112;
        label_11:
        Dispose();
        if(val_13 == 316)
        {
                return;
        }
        
        val_14 = 4;
        goto label_13;
        label_19:
        val_11 = this.vfxPoolingInfo[0];
        if(mem[536890899] == this.vfxPoolingInfo[0].namePrefab)
        {
            goto label_17;
        }
        
        val_14 = 5;
        label_13:
        val_12 = this.vfxPoolingInfo;
        if((val_14 - 4) < this.vfxPoolingInfo[0].namePrefab)
        {
            goto label_19;
        }
        
        goto label_20;
        label_2:
        val_15 = 4;
        goto label_21;
        label_27:
        val_11 = this.vfxPoolingInfo[0];
        if(this.vfxPoolingInfo[0].namePrefab == name)
        {
            goto label_25;
        }
        
        val_15 = 5;
        label_21:
        val_11 = this.vfxPoolingInfo;
        val_12 = val_15 - 4;
        if(val_12 < this.vfxPoolingInfo[0].namePrefab)
        {
            goto label_27;
        }
        
        label_20:
        val_10 = 0;
        return;
        label_25:
        val_16 = this.vfxPoolingInfo[0];
        goto label_31;
        label_17:
        val_16 = this.vfxPoolingInfo[0];
        label_31:
        UnityEngine.Transform val_8 = this.transform;
        UnityEngine.RectTransform val_9 = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  this.vfxPoolingInfo[0].prefab, parent:  566090384);
        val_10 = this.vfxPoolingInfo[0].prefab;
        val_12 = 536890899;
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        val_10.name = 536890899;
        this.listVFXPool.Add(item:  val_10);
    }
    public UnityEngine.GameObject GetVFX(NamePrefabPool name, UnityEngine.Vector3 position, UnityEngine.Transform parent)
    {
        string val_3;
        PoolingManager val_18;
        System.Collections.Generic.List<UnityEngine.GameObject> val_19;
        string val_20;
        var val_21;
        var val_22;
        var val_23;
        UnityEngine.Transform val_24;
        val_18 = this;
        if(true <= 0)
        {
            goto label_2;
        }
        
        val_19 = this.listVFXPool;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_9:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        val_20 = val_3;
        if(val_20.activeSelf == true)
        {
            goto label_9;
        }
        
        string val_5 = val_20.name;
        val_19 = 536890899;
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        if((System.String.op_Equality(a:  val_20, b:  536890899)) == false)
        {
            goto label_9;
        }
        
        val_18 = val_18;
        if(parent != 0)
        {
            goto label_12;
        }
        
        UnityEngine.Transform val_8 = val_20.transform;
        UnityEngine.Transform val_9 = parent.transform;
        val_19 = val_18;
        val_20.SetParent(p:  566624272);
        goto label_15;
        label_4:
        val_18 = val_18;
        val_20 = 0;
        val_21 = 164;
        goto label_16;
        label_2:
        val_22 = 4;
        goto label_17;
        label_23:
        PoolingInfo val_20 = this.vfxPoolingInfo[0];
        if(this.vfxPoolingInfo[0].namePrefab == name)
        {
            goto label_35;
        }
        
        val_22 = 5;
        label_17:
        val_19 = this.vfxPoolingInfo;
        if((val_22 - 4) < this.vfxPoolingInfo[0].namePrefab)
        {
            goto label_23;
        }
        
        goto label_24;
        label_12:
        UnityEngine.Transform val_11 = val_20.transform;
        val_20.SetParent(p:  parent);
        label_15:
        UnityEngine.Transform val_12 = val_20.transform;
        val_20.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
        val_20.SetActive(value:  true);
        val_21 = 493;
        label_16:
        Dispose();
        if(493 == 493)
        {
                return;
        }
        
        val_23 = 4;
        goto label_31;
        label_37:
        PoolingInfo val_21 = this.vfxPoolingInfo[0];
        if(mem[536890899] == this.vfxPoolingInfo[0].namePrefab)
        {
            goto label_35;
        }
        
        val_23 = 5;
        label_31:
        val_19 = this.vfxPoolingInfo;
        if((val_23 - 4) < this.vfxPoolingInfo[0].namePrefab)
        {
            goto label_37;
        }
        
        label_24:
        val_20 = 0;
        return;
        label_35:
        PoolingInfo val_22 = this.vfxPoolingInfo[0];
        UnityEngine.Transform val_14 = this.transform;
        UnityEngine.RectTransform val_15 = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  this.vfxPoolingInfo[0].prefab, parent:  566624272);
        val_20 = this.vfxPoolingInfo[0].prefab;
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        val_20.name = 536890899;
        val_19 = UnityEngine.Object.op_Equality(x:  parent, y:  0);
        UnityEngine.Transform val_17 = val_20.transform;
        if(val_19 != false)
        {
                UnityEngine.Transform val_18 = parent.transform;
            val_19 = val_18;
            val_24 = val_19;
        }
        else
        {
                val_24 = parent;
        }
        
        val_20.SetParent(p:  val_24);
        UnityEngine.Transform val_19 = val_20.transform;
        val_20.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
        this.listVFXPool.Add(item:  val_20);
    }
    public UnityEngine.GameObject GetObject(NamePrefabPool name, UnityEngine.Vector3 position, UnityEngine.Transform parent)
    {
        string val_3;
        PoolingManager val_18;
        System.Collections.Generic.List<UnityEngine.GameObject> val_19;
        string val_20;
        var val_21;
        var val_22;
        var val_23;
        UnityEngine.Transform val_24;
        val_18 = this;
        if(true <= 0)
        {
            goto label_2;
        }
        
        val_19 = this.listObjectPool;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_9:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        val_20 = val_3;
        if(val_20.activeSelf == true)
        {
            goto label_9;
        }
        
        string val_5 = val_20.name;
        val_19 = 536890899;
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        if((System.String.op_Equality(a:  val_20, b:  536890899)) == false)
        {
            goto label_9;
        }
        
        val_18 = val_18;
        if(parent != 0)
        {
            goto label_12;
        }
        
        UnityEngine.Transform val_8 = val_20.transform;
        UnityEngine.Transform val_9 = parent.transform;
        val_19 = val_18;
        val_20.SetParent(p:  567047568);
        goto label_15;
        label_4:
        val_18 = val_18;
        val_20 = 0;
        val_21 = 164;
        goto label_16;
        label_2:
        val_22 = 4;
        goto label_17;
        label_23:
        PoolingInfo val_20 = this.gameObjectPoolingInfo[0];
        if(this.gameObjectPoolingInfo[0].namePrefab == name)
        {
            goto label_35;
        }
        
        val_22 = 5;
        label_17:
        val_19 = this.gameObjectPoolingInfo;
        if((val_22 - 4) < this.gameObjectPoolingInfo[0].namePrefab)
        {
            goto label_23;
        }
        
        goto label_24;
        label_12:
        UnityEngine.Transform val_11 = val_20.transform;
        val_20.SetParent(p:  parent);
        label_15:
        UnityEngine.Transform val_12 = val_20.transform;
        val_20.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
        val_20.SetActive(value:  true);
        val_21 = 493;
        label_16:
        Dispose();
        if(493 == 493)
        {
                return;
        }
        
        val_23 = 4;
        goto label_31;
        label_37:
        PoolingInfo val_21 = this.gameObjectPoolingInfo[0];
        if(mem[536890899] == this.gameObjectPoolingInfo[0].namePrefab)
        {
            goto label_35;
        }
        
        val_23 = 5;
        label_31:
        val_19 = this.gameObjectPoolingInfo;
        if((val_23 - 4) < this.gameObjectPoolingInfo[0].namePrefab)
        {
            goto label_37;
        }
        
        label_24:
        val_20 = 0;
        return;
        label_35:
        PoolingInfo val_22 = this.gameObjectPoolingInfo[0];
        UnityEngine.Transform val_14 = this.transform;
        UnityEngine.RectTransform val_15 = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  this.gameObjectPoolingInfo[0].prefab, parent:  567047568);
        val_20 = this.gameObjectPoolingInfo[0].prefab;
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        val_20.name = 536890899;
        val_19 = UnityEngine.Object.op_Equality(x:  parent, y:  0);
        UnityEngine.Transform val_17 = val_20.transform;
        if(val_19 != false)
        {
                UnityEngine.Transform val_18 = parent.transform;
            val_19 = val_18;
            val_24 = val_19;
        }
        else
        {
                val_24 = parent;
        }
        
        val_20.SetParent(p:  val_24);
        UnityEngine.Transform val_19 = val_20.transform;
        val_20.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
        this.listObjectPool.Add(item:  val_20);
    }
    public UnityEngine.GameObject GetObject(NamePrefabPool name)
    {
        string val_3;
        string val_10;
        string val_11;
        PoolingInfo[] val_12;
        var val_13;
        var val_14;
        var val_15;
        PoolingInfo val_16;
        if(true <= 0)
        {
            goto label_2;
        }
        
        List.Enumerator<T> val_1 = GetEnumerator();
        label_9:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        val_10 = val_3;
        if(val_10.activeSelf == true)
        {
            goto label_9;
        }
        
        string val_5 = val_10.name;
        val_11 = val_10;
        val_12 = 536890899;
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        if((System.String.op_Equality(a:  val_11, b:  536890899)) == false)
        {
            goto label_9;
        }
        
        val_13 = 316;
        val_10.SetActive(value:  true);
        goto label_11;
        label_4:
        val_10 = 0;
        val_13 = 112;
        label_11:
        Dispose();
        if(val_13 == 316)
        {
                return;
        }
        
        val_14 = 4;
        goto label_13;
        label_19:
        val_11 = this.gameObjectPoolingInfo[0];
        if(mem[536890899] == this.gameObjectPoolingInfo[0].namePrefab)
        {
            goto label_17;
        }
        
        val_14 = 5;
        label_13:
        val_12 = this.gameObjectPoolingInfo;
        if((val_14 - 4) < this.gameObjectPoolingInfo[0].namePrefab)
        {
            goto label_19;
        }
        
        goto label_20;
        label_2:
        val_15 = 4;
        goto label_21;
        label_27:
        val_11 = this.gameObjectPoolingInfo[0];
        if(this.gameObjectPoolingInfo[0].namePrefab == name)
        {
            goto label_25;
        }
        
        val_15 = 5;
        label_21:
        val_11 = this.gameObjectPoolingInfo;
        val_12 = val_15 - 4;
        if(val_12 < this.gameObjectPoolingInfo[0].namePrefab)
        {
            goto label_27;
        }
        
        label_20:
        val_10 = 0;
        return;
        label_25:
        val_16 = this.gameObjectPoolingInfo[0];
        goto label_31;
        label_17:
        val_16 = this.gameObjectPoolingInfo[0];
        label_31:
        UnityEngine.Transform val_8 = this.transform;
        UnityEngine.RectTransform val_9 = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  this.gameObjectPoolingInfo[0].prefab, parent:  567581456);
        val_10 = this.gameObjectPoolingInfo[0].prefab;
        val_12 = 536890899;
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        val_10.name = 536890899;
        this.listObjectPool.Add(item:  val_10);
    }
    public void DisableAllObject()
    {
        var val_8;
        float val_9;
        var val_10;
        var val_11;
        this.StopAllCoroutines();
        if(1152921509469798543 >= 0)
        {
                val_8 = 22713552;
            val_9 = 4.021163E-38f;
            do
        {
            if(this <= 1152921509469798543)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(this.listObjectPool == 0)
        {
                this.listObjectPool.RemoveAt(index:  567984271);
        }
        
            val_10 = 1152921509469798546;
        }
        while(1152921509469798542 > 1);
        
        }
        
        if(1152921509469798545 >= 0)
        {
                val_8 = 22713552;
            val_9 = 4.021163E-38f;
            do
        {
            if(1152921509469798546 <= 1152921509469798545)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(this.listVFXPool == 0)
        {
                this.listVFXPool.RemoveAt(index:  567984273);
        }
        
            val_10 = 1152921509469798548;
        }
        while(1152921509469798544 > 1);
        
        }
        
        val_11 = 0;
        goto label_19;
        label_24:
        UnityEngine.Transform val_3 = this.transform;
        UnityEngine.Transform val_4 = this.GetChild(index:  0);
        UnityEngine.GameObject val_5 = this.gameObject;
        this.SetActive(value:  false);
        val_11 = 1;
        label_19:
        UnityEngine.Transform val_6 = this.transform;
        if(val_11 < this.childCount)
        {
            goto label_24;
        }
    
    }
    public void DisableObjectWithTime(UnityEngine.GameObject obj, float time)
    {
        System.Collections.IEnumerator val_1 = this.TimeDisableObject(obj:  obj, time:  time);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  568124944);
    }
    private System.Collections.IEnumerator TimeDisableObject(UnityEngine.GameObject obj, float time)
    {
        PoolingManager.<TimeDisableObject>d__13 val_1 = 536900405;
        val_1 = new PoolingManager.<TimeDisableObject>d__13(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536900425] = obj;
        }
        else
        {
                mem[20] = obj;
        }
        
        mem[536900421] = R2;
    }
    public PoolingManager()
    {
        System.Collections.Generic.List<Page> val_1 = 536877883;
        val_1 = new System.Collections.Generic.List<Page>();
        this.listVFXPool = val_1;
        System.Collections.Generic.List<Page> val_2 = 536877883;
        val_2 = new System.Collections.Generic.List<Page>();
        this.listObjectPool = val_2;
    }

}
