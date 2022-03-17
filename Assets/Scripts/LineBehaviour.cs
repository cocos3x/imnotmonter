using UnityEngine;
public class LineBehaviour : MonoBehaviour
{
    // Fields
    public float speed;
    public System.Collections.Generic.List<UnityEngine.Vector2> points;
    public UnityEngine.EdgeCollider2D lineCollider;
    
    // Methods
    public void updateLine(UnityEngine.Vector2 mousePosition)
    {
        float val_4;
        float val_5;
        float val_6;
        System.Collections.Generic.List<UnityEngine.Vector2> val_12;
        var val_13;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Vector3 val_3 = position;
        float val_7 = UnityEngine.Time.deltaTime;
        uint val_13 = 0;
        val_13 = this.speed * val_13;
        float val_8 = UnityEngine.Mathf.Clamp01(value:  val_13);
        float val_14 = 0f;
        float val_15 = mousePosition.y;
        float val_16 = mousePosition.x;
        val_14 = val_14 - val_6;
        val_15 = val_15 - val_5;
        val_16 = val_16 - val_4;
        this.position = new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6};
        val_12 = this;
        if(this <= 0)
        {
            goto label_4;
        }
        
        UnityEngine.Vector2 val_9 = System.Linq.Enumerable.Last<UnityEngine.Vector2>(source:  609417724);
        float val_10 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2(), b:  new UnityEngine.Vector2() {x = mousePosition.x, y = mousePosition.y});
        if(this <= 0)
        {
                return;
        }
        
        if(R0 < 16)
        {
            goto label_10;
        }
        
        val_12 = this.points;
        if(val_12 == 0)
        {
            goto label_8;
        }
        
        goto label_9;
        label_4:
        536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        this.points = 536878507;
        goto label_10;
        label_8:
        val_13 = 0;
        label_9:
        val_12.RemoveRange(index:  0, count:  val_13 - 5);
        label_10:
        this.SetPoint(mousePosition:  new UnityEngine.Vector2() {x = mousePosition.x, y = mousePosition.y});
    }
    private void OnTriggerStay2D(UnityEngine.Collider2D other)
    {
        var val_18;
        UnityEngine.GameObject val_1 = other.gameObject;
        if((other.CompareTag(tag:  -1610606635)) == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_3 = other.gameObject;
        Weight val_4 = other.GetComponent<Weight>();
        if((mem[22999912] != false) && (mem[22999913] != false))
        {
                if(mem[22999914] != false)
        {
                WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            if(mem[3221266319] >= 1)
        {
                mem[3221266319] = mem[3221266319] - 1;
            mem[3221266319] = mem[3221266319];
        }
        
            if(mem[3221266319] <= 0)
        {
                mem[3221266312] = 1;
        }
        
            WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            if(mem[3221266312] != 0)
        {
                WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            if((mem[3221266327] + 41) == 0)
        {
                WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Fall();
        }
        
        }
        
        }
        
            WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            if(mem[3221266315] >= 1)
        {
                mem[3221266315] = mem[3221266315] - 1;
            mem[3221266315] = mem[3221266315];
        }
        
            if(mem[3221266315] <= 0)
        {
                mem[3221266311] = 1;
        }
        
        }
        
        val_18 = 0;
        goto label_26;
        label_33:
        if(val_18 == (R7 + 32))
        {
                Spine.Timeline val_10 = mem[3221266333].Item[0];
            mem[3221266333].enabled = false;
        }
        
        val_18 = 1;
        label_26:
        if(val_18 < mem[3221266333].Count)
        {
            goto label_33;
        }
        
        WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610604851, volume:  null);
        UnityEngine.Transform val_13 = other.transform;
        UnityEngine.Transform val_14 = other.parent;
        UnityEngine.Transform val_15 = other.GetComponent<UnityEngine.Transform>();
        if(other != 0)
        {
                UnityEngine.Transform val_16 = other.transform;
            other.CutLink(_transform:  other);
        }
        
        UnityEngine.GameObject val_17 = other.gameObject;
        UnityEngine.Object.Destroy(obj:  other);
    }
    private void SetPoint(UnityEngine.Vector2 mousePosition)
    {
        var val_3;
        var val_6;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = position;
        UnityEngine.Transform val_4 = this.transform;
        UnityEngine.Vector3 val_5 = position;
        float val_8 = mousePosition.x;
        float val_9 = mousePosition.y;
        val_8 = val_8 - val_3;
        val_9 = val_9 - val_6;
        this.points.Add(item:  new UnityEngine.Vector2() {x = val_8, y = val_9});
        if(this.points < 2)
        {
                return;
        }
        
        T[] val_7 = this.points.ToArray();
        this.lineCollider.points = this.points;
    }
    public LineBehaviour()
    {
    
    }

}
