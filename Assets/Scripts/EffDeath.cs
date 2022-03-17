using UnityEngine;
public class EffDeath : MonoBehaviour
{
    // Fields
    public UnityEngine.Rigidbody2D rigidbody2;
    public Spine.Unity.SkeletonAnimation skeleton;
    private float timeFly;
    private float force;
    private bool _isSaw;
    private bool stopFly;
    private float[] valueAddFore;
    
    // Methods
    public void ChangeForce(bool isSaw = False, int id = 1, bool botHasSkin = False)
    {
        var val_6;
        var val_7;
        float val_13;
        float val_14;
        float val_15;
        val_13 = UnityEngine.Random.Range(minInclusive:  600, maxExclusive:  900);
        if((UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  2)) == 0)
        {
                val_13 = -val_13;
        }
        
        this.rigidbody2.AddTorque(torque:  val_13, mode:  val_13);
        this.rigidbody2.gravityScale = val_13;
        int val_3 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  3);
        if(val_3 == 0)
        {
            goto label_2;
        }
        
        if(val_3 == 1)
        {
            goto label_3;
        }
        
        if(val_3 != 2)
        {
            goto label_4;
        }
        
        val_14 = 1f;
        val_15 = -1f;
        goto label_7;
        label_2:
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.one;
        goto label_6;
        label_3:
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.up;
        label_6:
        val_15 = val_6;
        val_14 = val_7;
        goto label_7;
        label_4:
        val_15 = 0f;
        val_14 = 0;
        label_7:
        float val_9 = UnityEngine.Random.Range(minInclusive:  UnityEngine.Random.Range(minInclusive:  val_13, maxInclusive:  null), maxInclusive:  null);
        uint val_13 = 1077936128;
        val_13 = val_14 * val_13;
        this.rigidbody2.AddForce(force:  new UnityEngine.Vector2() {x = val_15 * 1077936128, y = val_13}, mode:  1);
        this.timeFly = 1f;
        this.DelayHide();
        System.Collections.IEnumerator val_11 = this.SetSkin(id:  id, botHasSkin:  botHasSkin);
        UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  658533520);
    }
    private System.Collections.IEnumerator SetSkin(int id, bool botHasSkin = False)
    {
        EffDeath.<SetSkin>d__6 val_1 = 536898773;
        val_1 = new EffDeath.<SetSkin>d__6(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536898789] = this;
            mem[536898797] = id;
        }
        else
        {
                mem[16] = this;
            mem[24] = id;
        }
        
        mem[536898793] = botHasSkin;
    }
    private void ScaleEff()
    {
        float val_1 = UnityEngine.Random.Range(minInclusive:  null, maxInclusive:  null);
        if(>=0)
        {
                if()
        {
            goto label_1;
        }
        
        }
        
        this.timeFly = 1.5f;
        label_1:
        UnityEngine.Transform val_3 = this.transform;
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOScale(target:  658769808, endValue:  new UnityEngine.Vector3() {x = 0.1f, y = 0.1f, z = 0.1f}, duration:  UnityEngine.Random.Range(minInclusive:  UnityEngine.Random.Range(minInclusive:  1036831949, maxInclusive:  null), maxInclusive:  null));
    }
    private void FixedUpdate()
    {
        float val_1 = this.rigidbody2.angularVelocity;
        if(this.rigidbody2 > 0)
        {
                this.rigidbody2.angularVelocity = 100f;
        }
        
        float val_2 = this.rigidbody2.angularVelocity;
        if(this.rigidbody2 >= 0)
        {
                return;
        }
        
        R4 + 12.angularVelocity = -100f;
    }
    private void DelayHide()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.GameObject val_2 = this.gameObject;
        -1073701087.Despaw(go:  659018384, delay:  null);
    }
    private void ReloadLevel()
    {
        float val_3;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        this.localScale = new UnityEngine.Vector3() {x = R6, y = R7, z = val_3};
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.GameObject val_5 = this.gameObject;
        -1073701087.Despaw(go:  659130384, delay:  val_2.x);
    }
    public EffDeath()
    {
        this.force = 3f;
        this.valueAddFore = 536882357;
    }
    private bool <SetSkin>b__6_0()
    {
        if((mem[536891408] & true) != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.skeleton);
        }
        
        if(mem[536891337] != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.skeleton);
        }
        
        return UnityEngine.Object.op_Implicit(exists:  this.skeleton);
    }

}
