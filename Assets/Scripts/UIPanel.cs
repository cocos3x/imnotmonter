using UnityEngine;
public class UIPanel : MonoBehaviour
{
    // Fields
    public static int uiAnimation;
    public bool freez;
    private bool _isPlaying;
    public string hide;
    public string show;
    private string currentClip;
    private UnityEngine.Animation anim;
    
    // Properties
    public bool isPlaying { get; set; }
    
    // Methods
    public bool get_isPlaying()
    {
        return (bool)this._isPlaying;
    }
    public void set_isPlaying(bool value)
    {
        bool val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_4 = value;
        val_5 = 22969926;
        if(this._isPlaying == true)
        {
                this._isPlaying = 1;
        }
        
        bool val_1 = 1 ^ val_4;
        if(val_1 != true)
        {
                return;
        }
        
        this._isPlaying = val_4;
        val_5 = 22716212;
        val_6 = 536896127;
        val_7 = 0;
        if(val_1 != true)
        {
                if(mem[536896243] != 0)
        {
                val_7 = mem[536896313] & 512;
        }
        else
        {
                val_6 = 536896127;
            val_4 = this._isPlaying;
            val_7 = mem[536896313] & 512;
        }
        
        }
        
        val_8 = mem[536896219];
        if(val_4 == false)
        {
                1 = 0;
        }
        
        if((val_7 != 0) && (mem[536896243] == 0))
        {
                val_8 = mem[536896219];
        }
        
        mem2[0] = 1 + val_8;
    }
    private void Awake()
    {
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        this.anim = this;
    }
    private void OnEnable()
    {
        this.freez = false;
    }
    public void SetVisible(bool visible, bool immediate = False)
    {
        var val_13;
        var val_14;
        string val_15;
        val_13 = visible;
        UnityEngine.GameObject val_1 = this.gameObject;
        val_14 = this;
        bool val_2 = this.activeSelf;
        val_2 = val_2 ^ val_13;
        if(val_2 != true)
        {
                return;
        }
        
        val_14 = this;
        this.currentClip = -1610612735;
        if(val_13 == false)
        {
            goto label_3;
        }
        
        UnityEngine.GameObject val_3 = this.gameObject;
        val_13 = this;
        this.SetActive(value:  true);
        if((System.String.op_Inequality(a:  this.show, b:  -1610612735)) == false)
        {
                return;
        }
        
        val_15 = this.show;
        goto label_6;
        label_3:
        if((System.String.op_Inequality(a:  this.hide, b:  -1610612735)) == false)
        {
            goto label_7;
        }
        
        val_15 = this.hide;
        label_6:
        this.currentClip = val_15;
        if((System.String.op_Equality(a:  this.currentClip, b:  -1610612735)) == false)
        {
            goto label_8;
        }
        
        return;
        label_7:
        UnityEngine.GameObject val_7 = this.gameObject;
        this.SetActive(value:  false);
        return;
        label_8:
        if(immediate != false)
        {
                UnityEngine.AnimationState val_8 = this.anim.Item[this.currentClip];
            UnityEngine.AnimationState val_9 = this.anim.Item[this.currentClip];
            this.anim.time = this.anim.length;
            return;
        }
        
        System.Collections.IEnumerator val_11 = this.PlayClipRoutine(clip:  this.currentClip);
        UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  585276560);
    }
    private void Play(string clip)
    {
        System.Collections.IEnumerator val_1 = this.PlayClipRoutine(clip:  clip);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  585429520);
    }
    public void PlayClip(string clip)
    {
        if(this._isPlaying == true)
        {
                return;
        }
        
        System.Collections.IEnumerator val_1 = R4.PlayClipRoutine(clip:  clip);
        UnityEngine.Coroutine val_2 = R4.StartCoroutine(routine:  R4);
    }
    private System.Collections.IEnumerator PlayClipRoutine(string clip)
    {
        UIPanel.<PlayClipRoutine>d__15 val_1 = 536902123;
        val_1 = new UIPanel.<PlayClipRoutine>d__15(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536902139] = this;
        }
        else
        {
                mem[16] = this;
        }
        
        mem[536902143] = clip;
    }
    private void DeActive()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    public UIPanel()
    {
        this.currentClip = -1610612735;
    }
    private static UIPanel()
    {
    
    }

}
