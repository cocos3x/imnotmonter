using UnityEngine;
public class HuggyPinPullController : MonoBehaviour
{
    // Fields
    protected CharacterAnimationController animationController;
    protected UnityEngine.BoxCollider2D myCollider;
    protected UnityEngine.Rigidbody2D myRigidbody;
    protected UnityEngine.CircleCollider2D groundCollider;
    private UnityEngine.GameObject mainSkeletonObject;
    protected bool facingLeft;
    private float scaleCharacter;
    protected bool canAim;
    protected bool isDead;
    protected bool isUntied;
    private TypeCharacterPinPullDie typeCharacterDie;
    private int countTied;
    
    // Methods
    private void Start()
    {
        this.isUntied = false;
        this.canAim = true;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        this.SetSkin(id:  -1073708883.SkinHuggySelectedID);
        this.Tied();
    }
    private void OnEnable()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        this.SetSkin(id:  -1073708883.SkinHuggySelectedID);
    }
    public void SetOrderLayer(int id)
    {
        this.animationController.SetOrderLayer(value:  id);
    }
    public void SetSortingLayer(string value)
    {
        this.animationController.SetSortingLayer(value:  value);
    }
    private void SetSkin(int id)
    {
        string val_1 = id.ToString();
        this.animationController.SetSkin(skinName:  627285148);
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
    public void Tied()
    {
        this.myRigidbody.bodyType = 1;
        this.RandomTied();
    }
    public void Untie()
    {
        System.Collections.IEnumerator val_1 = this.WaitForUntie();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  627653648);
    }
    private System.Collections.IEnumerator WaitForUntie()
    {
        536899343 = new HuggyPinPullController.<WaitForUntie>d__20(<>1__state:  0);
        mem[536899359] = this;
    }
    public void Win()
    {
        this.canAim = false;
        this.myRigidbody.constraints = 5;
    }
    public void Dead()
    {
        CharacterAnimationController val_14;
        var val_15;
        string val_16;
        if(this.canAim == false)
        {
                return;
        }
        
        if(this.isDead != true)
        {
                return;
        }
        
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.Vibrate) != false)
        {
                MoreMountains.NiceVibrations.MMVibrationManager.Haptic(type:  5, defaultToRegularVibrate:  false, alsoRumble:  false, coroutineSupport:  0, controllerID:  0);
        }
        
        this.canAim = true;
        this.isDead = true;
        UnityEngine.GameObject val_3 = this.groundCollider.gameObject;
        this.groundCollider.layer = 14;
        this.myCollider.enabled = false;
        UnityEngine.Transform val_4 = this.transform;
        UnityEngine.Transform val_5 = this.parent;
        UnityEngine.Transform val_6 = this.GetComponent<UnityEngine.Transform>();
        if((UnityEngine.Object.op_Implicit(exists:  628026512)) != false)
        {
                UnityEngine.Transform val_8 = this.GetComponent<UnityEngine.Transform>();
            this.Untie();
        }
        
        UnityEngine.Transform val_9 = this.transform;
        UnityEngine.Transform val_10 = this.transform;
        UnityEngine.Transform val_11 = this.parent;
        UnityEngine.Transform val_12 = this.parent;
        this.parent = 628026512;
        this.myRigidbody.bodyType = 0;
        this.myRigidbody.constraints = 5;
        if(this.typeCharacterDie > 3)
        {
                return;
        }
        
        var val_13 = 18109420 + (18109420 + (this.typeCharacterDie) << 2);
        if(this.typeCharacterDie == 3)
        {
                18109420 + (this.typeCharacterDie) << 2 = (18109420 + (this.typeCharacterDie) << 2) & ((18109420 + (this.typeCharacterDie) << 2) << (18109420 + (this.typeCharacterDie) << 2));
            18109420 + (this.typeCharacterDie) << 2 = (18109420 + (this.typeCharacterDie) << 2) & (((int)IP) >> 32);
            18109420 + (this.typeCharacterDie) << 2 = (18109420 + (this.typeCharacterDie) << 2) & ((18109420 + (this.typeCharacterDie) << 2) << (18109420 + (this.typeCharacterDie) << 2));
            18109420 + (this.typeCharacterDie) << 2 = (18109420 + (this.typeCharacterDie) << 2) & ((R8) << 1);
        }
        
        val_14 = this.animationController;
        val_15 = 536887951;
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_15 = 536887951;
        }
        
        val_16 = mem[mem[536888043] + 44];
        val_16 = mem[536888043] + 44;
        SetAnimation(name:  null, loop:  false, timeScale:  null, _callBack:  1065353216);
    }
    public void SetTypeDie(TypeCharacterPinPullDie typeDie)
    {
        this.typeCharacterDie = typeDie;
    }
    private void RandomTied()
    {
        var val_3;
        if(this.isDead == true)
        {
                return;
        }
        
        this.countTied = UnityEngine.Random.Range(minInclusive:  3, maxExclusive:  5);
        val_3 = 536887951;
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_3 = 536887951;
        }
        
        536882991 = new System.Action(object:  628291472, method:  new IntPtr(1610678813));
        this.animationController.SetAnimation(name:  mem[536888043] + 64 + 16, loop:  true, timeScale:  null, _callBack:  1065353216);
    }
    public HuggyPinPullController()
    {
        this.scaleCharacter = 0.25f;
    }
    private void <WaitForUntie>b__20_0()
    {
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                536887951 = 536887951;
        }
        
        this.animationController.SetAnimation(name:  mem[536888043] + 32, loop:  false, timeScale:  null, _callBack:  1065353216);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609949, volume:  null);
    }
    private void <RandomTied>b__24_0()
    {
        var val_2;
        int val_2 = this.countTied;
        val_2 = val_2 - 1;
        this.countTied = val_2;
        if(val_2 > 0)
        {
                return;
        }
        
        if(this.isDead == false)
        {
                this.isDead = this.isUntied;
            goto label_2;
        }
        
        return;
        label_2:
        val_2 = 536887951;
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_2 = 536887951;
        }
        
        536882991 = new System.Action(object:  628643856, method:  new IntPtr(1610678815));
        this.animationController.SetAnimation(name:  mem[536888043] + 64 + 20, loop:  false, timeScale:  null, _callBack:  1065353216);
    }
    private void <RandomTied>b__24_1()
    {
        this.RandomTied();
    }

}
