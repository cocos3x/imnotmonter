using UnityEngine;
public class MistressCutRopeController : MonoBehaviour
{
    // Fields
    private readonly float scaleCharacter;
    protected CharacterAnimationController animationController;
    protected bool canAim;
    protected bool facingLeft;
    protected UnityEngine.CircleCollider2D groundCollider;
    protected bool isDead;
    private UnityEngine.GameObject mainSkeletonObject;
    protected UnityEngine.BoxCollider2D myCollider;
    protected UnityEngine.Rigidbody2D myRigidbody;
    private TextEffect textEff;
    
    // Methods
    private void Start()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        this.SetSkin(id:  -1073708883.SkinSelectedID);
        this.canAim = true;
        this.SetScale();
    }
    private void OnEnable()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        this.SetSkin(id:  -1073708883.SkinSelectedID);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  610379024, method:  new IntPtr(1610678551));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  610379024, eventID:  10, callback:  536873423);
    }
    private void OnDisable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  610491024, method:  new IntPtr(1610678553));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  610491024, eventID:  10, callback:  536873423);
    }
    public void SetSortingLayer(string value)
    {
        this.animationController.SetSortingLayer(value:  value);
    }
    private void SetScale()
    {
        bool val_3;
        var val_4;
        float val_5;
        val_3 = this.facingLeft;
        UnityEngine.Transform val_1 = this.mainSkeletonObject.transform;
        if(val_3 != false)
        {
                val_3 = this.scaleCharacter ^ 2147483648;
            val_4 = 0;
            val_5 = val_3;
        }
        else
        {
                val_4 = 0;
            val_5 = this.scaleCharacter;
        }
        
        this.mainSkeletonObject.localScale = new UnityEngine.Vector3() {x = val_5, y = this.scaleCharacter, z = this.scaleCharacter};
    }
    private void SetSkin(int id)
    {
        string val_1 = id.ToString();
        this.animationController.SetSkin(skinName:  610843676);
    }
    public void Win()
    {
        this.canAim = false;
        this.myRigidbody.constraints = 5;
        this.textEff.ShowEffect();
        this.WaitWin();
    }
    private void WaitWin()
    {
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                536884781 = 536884781;
        }
        
        string val_1 = Berry.Utils.Utils.GetRandom<System.String>(collection:  mem[536884873] + 20);
        string val_2 = mem[536884873] + 28(mem[536884873] + 28) + mem[536884873] + 20(mem[536884873] + 20);
        this.animationController.SetAnimation(name:  mem[536884873] + 28, loop:  true, timeScale:  null, _callBack:  1065353216);
    }
    public void Dead()
    {
        var val_8;
        if(this.canAim == false)
        {
                return;
        }
        
        if(this.isDead == true)
        {
                return;
        }
        
        this.canAim = false;
        this.isDead = true;
        UnityEngine.GameObject val_1 = this.groundCollider.gameObject;
        this.groundCollider.layer = 14;
        this.myCollider.enabled = false;
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Transform val_3 = this.transform;
        UnityEngine.Transform val_4 = this.parent;
        UnityEngine.Transform val_5 = this.parent;
        this.parent = 611240848;
        this.myRigidbody.bodyType = 0;
        this.myRigidbody.constraints = 5;
        val_8 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_8 = 536884781;
        }
        
        string val_6 = mem[536884873] + 28(mem[536884873] + 28) + mem[536884873] + 12 + 20(mem[536884873] + 12 + 20);
        536882991 = new System.Action(object:  611240848, method:  new IntPtr(1610678555));
        this.animationController.SetAnimation(name:  mem[536884873] + 28, loop:  false, timeScale:  null, _callBack:  1065353216);
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if((collision.CompareTag(tag:  -1610607703)) == false)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = collision.transform;
        UnityEngine.Vector3 val_3 = position;
        UnityEngine.Transform val_5 = collision.transform;
        UnityEngine.Vector3 val_6 = position;
        if(collision > 0)
        {
                22999272 = 1;
        }
        
        this.facingLeft = true;
        this.SetScale();
    }
    public MistressCutRopeController()
    {
        this.scaleCharacter = 0.25f;
    }
    private void <OnEnable>b__11_0(UnityEngine.Component sender, object param)
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        this.SetSkin(id:  -1073708883.SkinSelectedID);
    }
    private void <OnDisable>b__12_0(UnityEngine.Component sender, object param)
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        this.SetSkin(id:  -1073708883.SkinSelectedID);
    }
    private void <Dead>b__18_0()
    {
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                536884781 = 536884781;
        }
        
        string val_1 = mem[536884873] + 28(mem[536884873] + 28) + mem[536884873] + 16 + 20(mem[536884873] + 16 + 20);
        this.animationController.SetAnimation(name:  mem[536884873] + 28, loop:  true, timeScale:  null, _callBack:  1065353216);
    }

}
