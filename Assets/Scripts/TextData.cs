using UnityEngine;
public class TextData : MonoBehaviour
{
    // Fields
    private TextData.TextType textType;
    private TMPro.TextMeshProUGUI textmeshText;
    private UnityEngine.UI.Text textNormalText;
    
    // Methods
    private void OnEnable()
    {
        this.UpdateText();
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  583210128, method:  new IntPtr(1610678085));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  583210128, eventID:  8, callback:  536873423);
    }
    private void OnDisable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  583322128, method:  new IntPtr(1610678087));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  583322128, eventID:  8, callback:  536873423);
    }
    private void UpdateText()
    {
        var val_56;
        var val_57;
        UnityEngine.UI.Text val_58;
        var val_60;
        var val_63;
        var val_64;
        if(this.textType <= 7)
        {
                var val_1 = 4931984 + (4931984 + (this.textType) << 2);
            if(this.textType == 7)
        {
                4931984 + (this.textType) << 2 = (4931984 + (this.textType) << 2) & (((4931984 + (this.textType) << 2) << (32-2)) | ((4931984 + (this.textType) << 2) << 2));
            4931984 + (this.textType) << 2 = (4931984 + (this.textType) << 2) & 18232956;
            4931984 + (this.textType) << 2 = (4931984 + (this.textType) << 2) & ((4931984 + (this.textType) << 2) >> 32);
            4931984 + (this.textType) << 2 = (4931984 + (this.textType) << 2) & ((4931984 + (this.textType) << 2) >> 32);
            4931984 + (this.textType) << 2 = (4931984 + (this.textType) << 2) & 583454608;
            4931984 + (this.textType) << 2 = IP * 22969821;
            4931984 + (this.textType) << 2 = (4931984 + (this.textType) << 2) & 3018063872;
            4931984 + (this.textType) << 2 = (4931984 + (this.textType) << 2) & (((int)IP) >> 16);
        }
        
            val_56 = 22713552;
            if((UnityEngine.Object.op_Implicit(exists:  this.textmeshText)) != false)
        {
                object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
            int val_4 = -1073708883.CurrentLevel;
            string val_5 = System.String.Format(format:  -1610606673, arg0:  536888987);
            val_57 = -1610606673;
            this.textmeshText.text = -1610606673;
        }
        
            if((UnityEngine.Object.op_Implicit(exists:  this.textNormalText)) != false)
        {
                val_58 = this.textNormalText;
            object val_7 = AFramework.ManualSingletonMono<System.Object>.I;
            int val_8 = -1073708883.CurrentLevel;
            val_60 = 22712448;
            val_63 = ;
            val_64 = 22788992;
            string val_52 = System.String.Format(format:  -1610597077, arg0:  536888987);
        }
        
        }
        
        var val_53 = FP - 16;
    }
    public TextData()
    {
    
    }
    private void <OnEnable>b__4_0(UnityEngine.Component sender, object param)
    {
        this.UpdateText();
    }
    private void <OnDisable>b__5_0(UnityEngine.Component sender, object param)
    {
        this.UpdateText();
    }

}
