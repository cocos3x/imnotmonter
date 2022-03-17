using UnityEngine;
public class ATTPopup : SingletonMonoBehaviour<ATTPopup>
{
    // Fields
    private UnityEngine.GameObject attPreObject;
    private System.Action nextAction;
    
    // Properties
    public static bool ShowedATT { get; set; }
    
    // Methods
    public static bool get_ShowedATT()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -1610604563, defaultValue:  0);
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public static void set_ShowedATT(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1610604563, value:  value);
    }
    public void NextClick()
    {
        UnityEngine.GameObject val_1 = this.attPreObject.gameObject;
        this.attPreObject.SetActive(value:  false);
        if(this.nextAction == 0)
        {
                return;
        }
        
        this.nextAction.Invoke();
    }
    public bool CheckATTReadly(System.Action callBack)
    {
        var val_5;
        System.Action val_6;
        val_5 = 0;
        if(ATT.IsOSReady() == false)
        {
                return (bool)val_5;
        }
        
        if(ATTPopup.ShowedATT == true)
        {
                return (bool)val_5;
        }
        
        System.Delegate val_3 = System.Delegate.Combine(a:  this.nextAction, b:  callBack);
        if(this.nextAction == 0)
        {
            goto label_5;
        }
        
        val_6 = this.nextAction;
        if(null == 536882991)
        {
            goto label_6;
        }
        
        label_5:
        val_6 = 0;
        label_6:
        this.nextAction = val_6;
        UnityEngine.GameObject val_4 = this.attPreObject.gameObject;
        val_5 = 1;
        this.attPreObject.SetActive(value:  true);
        return (bool)val_5;
    }
    public ATTPopup()
    {
    
    }

}
