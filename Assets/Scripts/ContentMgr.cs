using UnityEngine;
public class ContentMgr : SingletonMonoBehaviour<ContentMgr>
{
    // Fields
    private UnityEngine.GameObject zObj;
    public System.Collections.Generic.List<ContentMgr.ContentType> contents;
    
    // Methods
    public T GetItem<T>(string key)
    {
        var val_4;
        var val_5;
        val_4 = this;
        val_5 = 22969041;
        UnityEngine.GameObject val_1 = this.GetItem(itemType:  key);
        if((UnityEngine.Object.op_Implicit(exists:  528531376)) == false)
        {
                return;
        }
        
        if(val_4 == 0)
        {
            
        }
    
    }
    public T GetItem<T>(string key, UnityEngine.Vector3 position)
    {
        UnityEngine.GameObject val_1 = this.GetItem(itemType:  key);
        this.zObj = this;
        UnityEngine.Transform val_2 = this.zObj.transform;
        this.zObj.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
        if(mem[this.zObj] == 0)
        {
            
        }
    
    }
    public T GetItem<T>(string key, UnityEngine.Transform parent, UnityEngine.Vector3 position)
    {
        UnityEngine.GameObject val_1 = this.GetItem(itemType:  key);
        this.zObj = this;
        UnityEngine.Transform val_2 = this.zObj.transform;
        this.zObj.SetParent(p:  parent);
        UnityEngine.Transform val_3 = mem[this.zObj].transform;
        mem[this.zObj].position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
        if(mem[this.zObj] == 0)
        {
            
        }
    
    }
    public UnityEngine.GameObject GetItem(string key, UnityEngine.Vector3 position)
    {
        UnityEngine.GameObject val_1 = this.GetItem(itemType:  key);
        this.zObj = this;
        UnityEngine.Transform val_2 = this.zObj.transform;
        this.zObj.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
    }
    public UnityEngine.GameObject GetItem(string key, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
    {
        UnityEngine.GameObject val_1 = this.GetItem(key:  key, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        this.zObj = this;
        UnityEngine.Transform val_2 = this.zObj.transform;
        this.zObj.rotation = new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w};
    }
    public UnityEngine.GameObject GetItem(string itemType)
    {
        536898335 = new ContentMgr.<>c__DisplayClass8_0();
        mem[536898343] = itemType;
        536879271 = new System.Predicate<Page>(object:  536898335, method:  new IntPtr(1610677249));
        ContentType val_3 = this.contents.Find(match:  536879271);
        if(this.contents == 0)
        {
                return;
        }
        
        536879271 = new System.Predicate<Page>(object:  536898335, method:  new IntPtr(1610677251));
        ContentType val_5 = this.contents.Find(match:  536879271);
        if((mem[536889704] & true) != 0)
        {
                return Lean.LeanPool.Spawn(prefab:  this.contents);
        }
        
        if(mem[536889633] != 0)
        {
                return Lean.LeanPool.Spawn(prefab:  this.contents);
        }
        
        return Lean.LeanPool.Spawn(prefab:  this.contents);
    }
    public void Despaw(UnityEngine.GameObject go, float delay = 0)
    {
        Lean.LeanPool.Despawn(clone:  go, delay:  delay);
    }
    public ContentMgr()
    {
        536878585 = new System.Collections.Generic.List<Page>();
        this.contents = 536878585;
    }

}
