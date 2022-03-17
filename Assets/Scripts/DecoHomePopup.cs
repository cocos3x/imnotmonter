using UnityEngine;
public class DecoHomePopup : BaseUIMenu
{
    // Fields
    private UnityEngine.GameObject contentDeceration;
    private UnityEngine.GameObject contentCollection;
    private System.Collections.Generic.List<ItemDecoUI> listItemDecorations;
    private UnityEngine.Sprite[] iconWalls;
    private UnityEngine.Sprite[] iconShelfs;
    private UnityEngine.Sprite[] iconChairs;
    private UnityEngine.Sprite[] iconTVs;
    private UnityEngine.Sprite[] iconPictures;
    private UnityEngine.Sprite[] iconLights;
    
    // Methods
    private void Start()
    {
        this.SetAciteView(isDeco:  true);
    }
    private void OnEnable()
    {
        WinPopup val_1 = AFramework.SingletonUI<WinPopup>.I;
        mem[3221266581] = 1;
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  805304720, method:  new IntPtr(1610681615));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  805304720, eventID:  36, callback:  536873423);
    }
    private void OnDisable()
    {
        WinPopup val_1 = AFramework.SingletonUI<WinPopup>.I;
        mem[3221266581] = 0;
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  805416720, method:  new IntPtr(1610681617));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  805416720, eventID:  36, callback:  536873423);
    }
    private void SetData(DecoType type)
    {
        var val_2;
        UnityEngine.Sprite[] val_3;
        val_2 = 4;
        goto label_1;
        label_13:
        if(this.iconChairs <= R6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(type <= 5)
        {
                var val_1 = 4421956 + (4421956 + (type) << 2);
            if(type == 5)
        {
                this.iconWalls = this.iconWalls & ((IP) >> this.iconWalls);
            this.iconWalls = this.iconWalls & (this << this.iconWalls);
            this.iconWalls = this.iconWalls & (this.iconWalls >> 32);
            this.iconWalls = this.iconWalls & 805541008;
            this.iconWalls = this.iconWalls & (this.iconWalls >> this.iconWalls);
            this.iconWalls = this.iconWalls & (this >> this.iconWalls);
        }
        
            val_3 = this.iconShelfs;
        }
        else
        {
                val_3 = this.iconChairs;
        }
        
        2621443.InitData(type:  type, id:  R6, spriteIcon:  this.iconLights + 16);
        val_2 = 5;
        label_1:
        if((val_2 - 4) < 2621443)
        {
            goto label_13;
        }
    
    }
    private UnityEngine.Sprite[] GetListIcon(DecoType type)
    {
        UnityEngine.Sprite[] val_2;
        if(type <= 5)
        {
                var val_1 = 4422176 + (4422176 + (type) << 2);
            if(type == 5)
        {
                this = this & ((R8) << this);
            this = this & ((R8) >> 32);
            this = this & (this >> 32);
            this = this & (this >> this);
            this = this & ((R8) >> ((((this & (R8) << this) & (R8) >> 32) & (((this & (R8) << this) & (R8) >> 32)) >> 32) & ((((this & (R8) << this) & (R8) >> 32) & (((this & (R8) << this) & (R8) >> 32)) >> 32)) >> (((this & (R8) << th);
            this = this & (this >> 32);
        }
        
            val_2 = ((((((this & (R8) << this) & (R8) >> 32) & (((this & (R8) << this) & (R8) >> 32)) >> 32) & ((((this & (R8) << this) & (R8) >> 32) & (((this & (R8) << this) & (R8) >> 32)) >> 32)) >> (((this & (R8) << .iconWalls;
            return;
        }
        
        val_2 = this.iconChairs;
    }
    public void SetAciteView(bool isDeco)
    {
        UnityEngine.Debug.Log(message:  -1610602405);
        this.contentDeceration.SetActive(value:  isDeco);
        this.contentCollection.SetActive(value:  isDeco ^ 1);
    }
    public void ClosePopup()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701127.ShowBanner(position:  1, bannerPlaceID:  0);
        WinPopup val_2 = AFramework.SingletonUI<WinPopup>.I;
        -1073700811.ShowButtonPoints(value:  false);
        AFramework.UI.BaseUIMenu val_3 = AFramework.UI.CanvasManager.Push(identifier:  -1610605291, initParams:  null);
        goto typeof(DecoHomePopup).__il2cppRuntimeField_E4;
    }
    public DecoHomePopup()
    {
    
    }
    private void <OnEnable>b__10_0(UnityEngine.Component c, object o)
    {
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        this.SetData(type:  19169280);
    }
    private void <OnDisable>b__11_0(UnityEngine.Component c, object o)
    {
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        this.SetData(type:  19169280);
    }

}
