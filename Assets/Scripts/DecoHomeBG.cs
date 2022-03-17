using UnityEngine;
public class DecoHomeBG : SingletonUI<DecoHomeBG>
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.GameObject> walls;
    private System.Collections.Generic.List<UnityEngine.GameObject> shelfs;
    private System.Collections.Generic.List<UnityEngine.GameObject> chairs;
    private System.Collections.Generic.List<UnityEngine.GameObject> TVs;
    private System.Collections.Generic.List<UnityEngine.GameObject> pictures;
    private System.Collections.Generic.List<UnityEngine.GameObject> lights;
    private System.Collections.Generic.List<UnityEngine.GameObject> buttonPoints;
    private UnityEngine.UI.Button btn_Wall;
    private UnityEngine.UI.Button btn_Shelf;
    private UnityEngine.UI.Button btn_Chair;
    private UnityEngine.UI.Button btn_TV;
    private UnityEngine.UI.Button btn_Picture;
    private UnityEngine.UI.Button btn_Light;
    private UnityEngine.GameObject decos;
    private Spine.Unity.SkeletonGraphic skeleton_curtain;
    private UnityEngine.GameObject VFX_BombUI;
    public bool decoHomePopupDisplayed;
    
    // Methods
    public override void Init(object[] initParams)
    {
        if(initParams != null)
        {
                object val_1 = initParams[0];
            Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
            this.decos.SetActive(value:  true);
            this.ShowDeco(value:  true);
            return;
        }
        
        this.decos.SetActive(value:  true);
        this.ShowDeco(value:  true);
    }
    private void Start()
    {
        536896275 = new UnityEngine.Events.UnityAction(object:  803089424, method:  new IntPtr(1610681573));
        this.btn_Wall.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  803089424, method:  new IntPtr(1610681575));
        this.btn_Shelf.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  803089424, method:  new IntPtr(1610681577));
        this.btn_Chair.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  803089424, method:  new IntPtr(1610681579));
        this.btn_TV.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  803089424, method:  new IntPtr(1610681581));
        this.btn_Picture.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  803089424, method:  new IntPtr(1610681583));
        this.btn_Light.m_OnClick.AddListener(call:  536896275);
        this.ShowButtonPoints(value:  false);
    }
    private void ButtonDecorClick(DecoType currentDecor)
    {
        if(this.decoHomePopupDisplayed != true)
        {
                WinPopup val_1 = AFramework.SingletonUI<WinPopup>.I;
            this.ShowButtonPoints(value:  true);
            if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073700903.HideHome();
        }
        
            AFramework.UI.BaseUIMenu val_4 = AFramework.UI.CanvasManager.Push(identifier:  -1610605295, initParams:  null);
            WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            22969443 = -1073701127;
            val_6.HideBanner();
        }
        
        GameTool.EventDispatcherExtension.PostEvent(sender:  803254672, eventID:  36, param:  536885819);
    }
    public void ShowDeco(bool value)
    {
        this.decos.SetActive(value:  value);
        if(value == false)
        {
                return;
        }
        
        this.InitShowDeco();
    }
    public void ShowButtonPoints(bool value)
    {
        var val_3;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        val_3.SetActive(value:  value);
        goto label_4;
        label_2:
        Dispose();
        this.VFX_BombUI.SetActive(value:  value);
    }
    public void InitShowDeco()
    {
        var val_27;
        var val_28;
        int val_29;
        val_27 = 0;
        goto label_1;
        label_27:
        if(true <= val_27)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_1 = R1 + 0;
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_3 = -1073708883.IdSelectDecoWall;
        val_3 = val_27 - val_3;
        int val_4 = val_3 >> 5;
        (R1 + 0) + 16.SetActive(value:  val_4);
        if(((R1 + 0) + 16) <= val_27)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + 0;
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_6 = -1073708883.IdSelectDecoShelf;
        val_6 = val_27 - val_6;
        int val_7 = val_6 >> 5;
        (((val_27 - val_3) >> 5) + 0) + 16.SetActive(value:  val_7);
        if(((((val_27 - val_3) >> 5) + 0) + 16) <= val_27)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = val_7 + 0;
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_9 = -1073708883.IdSelectDecoChair;
        val_9 = val_27 - val_9;
        int val_10 = val_9 >> 5;
        (((val_27 - val_6) >> 5) + 0) + 16.SetActive(value:  val_10);
        if(((((val_27 - val_6) >> 5) + 0) + 16) <= val_27)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = val_10 + 0;
        object val_11 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_12 = -1073708883.IdSelectDecoTV;
        val_12 = val_27 - val_12;
        int val_13 = val_12 >> 5;
        (((val_27 - val_9) >> 5) + 0) + 16.SetActive(value:  val_13);
        if(((((val_27 - val_9) >> 5) + 0) + 16) <= val_27)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_13 = val_13 + 0;
        object val_14 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_15 = -1073708883.IdSelectDecoPicture;
        val_15 = val_27 - val_15;
        int val_16 = val_15 >> 5;
        (((val_27 - val_12) >> 5) + 0) + 16.SetActive(value:  val_16);
        if(((((val_27 - val_12) >> 5) + 0) + 16) <= val_27)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_16 = val_16 + 0;
        object val_17 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_18 = -1073708883.IdSelectDecoLight;
        val_28 = val_18;
        val_18 = val_27 - val_28;
        (((val_27 - val_15) >> 5) + 0) + 16.SetActive(value:  val_18 >> 5);
        val_27 = 1;
        label_1:
        if(val_27 < ((((val_27 - val_15) >> 5) + 0) + 16))
        {
            goto label_27;
        }
        
        object val_20 = AFramework.ManualSingletonMono<System.Object>.I;
        val_29 = 3;
        if((-1073708883.IdSelectDecoWall) <= 2)
        {
                object val_22 = AFramework.ManualSingletonMono<System.Object>.I;
            val_28 = -1073708883;
            val_29 = val_28.IdSelectDecoWall + 1;
        }
        
        string val_24 = val_29.ToString();
        string val_25 = -1610600969(-1610600969) + 803635980;
        this.SetSkinSkeletonCurtain(nameSkin:  -1610600969);
    }
    public void ChangeDeco(DecoType decoType, int idDeco)
    {
        System.Collections.Generic.List<UnityEngine.GameObject> val_16;
        var val_17;
        val_16 = decoType;
        val_17 = 22969446;
        if(val_16 > 5)
        {
                return;
        }
        
        var val_1 = 4419712 + (4419712 + (decoType) << 2);
        if(val_16 == 5)
        {
                4419712 = 4419712 & ((R8) << 4419712);
            4419712 = 4419712 & (((IP) << (32-1)) | ((IP) << 1));
            4419712 = 4419712 & (((IP) << (32-2)) | ((IP) << 2));
            4419712 = 4419712 & (((IP) << (32-3)) | ((IP) << 3));
            4419712 = 4419712 & (((IP) << (32-4)) | ((IP) << 4));
            4419712 = 4419712 & (((IP) << (32-5)) | ((IP) << 5));
        }
        
        val_17 = 0;
        if(idDeco < 3)
        {
                3 = idDeco + 1;
        }
        
        string val_2 = 3.ToString();
        string val_3 = -1610600969(-1610600969) + 803829908;
        this.SetSkinSkeletonCurtain(nameSkin:  -1610600969);
        goto label_3;
        label_8:
        if(this <= val_17)
        {
                var val_16 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_16 = val_16 + 0;
        (0 + 0) + 16.SetActive(value:  (idDeco - val_17) >> 5);
        val_17 = 1;
        label_3:
        val_16 = this.walls;
        if(val_17 < ((0 + 0) + 16))
        {
            goto label_8;
        }
    
    }
    private void SetSkinSkeletonCurtain(string nameSkin)
    {
        if(this.skeleton_curtain != 0)
        {
                Spine.Skeleton val_2 = this.skeleton_curtain.Skeleton;
            this.skeleton_curtain.SetSkin(skinName:  nameSkin);
            Spine.Skeleton val_3 = this.skeleton_curtain.Skeleton;
            this.skeleton_curtain.SetSlotsToSetupPose();
            Spine.AnimationState val_4 = this.skeleton_curtain.AnimationState;
            Spine.Skeleton val_5 = this.skeleton_curtain.Skeleton;
            bool val_6 = this.skeleton_curtain.Apply(skeleton:  this.skeleton_curtain);
            return;
        }
        
        UnityEngine.Coroutine val_7 = this.StartCoroutine(methodName:  -1610608787, value:  nameSkin);
    }
    private System.Collections.IEnumerator DelaySetSkinCurtain(string nameSkin)
    {
        DecoHomeBG.<DelaySetSkinCurtain>d__25 val_1 = 536898607;
        val_1 = new DecoHomeBG.<DelaySetSkinCurtain>d__25(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536898623] = this;
        }
        else
        {
                mem[16] = this;
        }
        
        mem[536898627] = nameSkin;
    }
    public DecoHomeBG()
    {
    
    }
    private void <Start>b__18_0()
    {
        this.ButtonDecorClick(currentDecor:  0);
    }
    private void <Start>b__18_1()
    {
        this.ButtonDecorClick(currentDecor:  1);
    }
    private void <Start>b__18_2()
    {
        this.ButtonDecorClick(currentDecor:  2);
    }
    private void <Start>b__18_3()
    {
        this.ButtonDecorClick(currentDecor:  3);
    }
    private void <Start>b__18_4()
    {
        this.ButtonDecorClick(currentDecor:  4);
    }
    private void <Start>b__18_5()
    {
        this.ButtonDecorClick(currentDecor:  5);
    }
    private bool <DelaySetSkinCurtain>b__25_0()
    {
        if((mem[536891408] & true) != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.skeleton_curtain);
        }
        
        if(mem[536891337] != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.skeleton_curtain);
        }
        
        return UnityEngine.Object.op_Implicit(exists:  this.skeleton_curtain);
    }

}
