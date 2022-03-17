using UnityEngine;
public class NetworkManager : SingletonMonoBehaviour<NetworkManager>
{
    // Fields
    private UnityEngine.GameObject panel;
    private UnityEngine.UI.Button retryButton;
    private AnimToolUI.AnimUIManager animManager;
    private bool isClosing;
    
    // Methods
    private void Start()
    {
        536896275 = new UnityEngine.Events.UnityAction(object:  510162736, method:  new IntPtr(1610676951));
        this.retryButton.m_OnClick.AddListener(call:  536896275);
    }
    public void ShowPanel()
    {
        this.isClosing = false;
        this.panel.SetActive(value:  true);
    }
    private void RetryButtonClick()
    {
        var val_3;
        if(this.isClosing != false)
        {
                return;
        }
        
        this.isClosing = true;
        536882991 = new System.Action(object:  510415408, method:  new IntPtr(1610676947));
        System.Delegate val_2 = System.Delegate.Combine(a:  this.animManager.OnClose, b:  536882991);
        val_3 = this.animManager.OnClose;
        if(val_3 != 0)
        {
                if(null == 536882991)
        {
            goto label_5;
        }
        
        }
        
        val_3 = 0;
        label_5:
        mem2[0] = val_3;
        this.animManager.CloseAnim();
    }
    private void CloseAnimEvent()
    {
        var val_5;
        536882991 = new System.Action(object:  510551984, method:  new IntPtr(1610676947));
        System.Delegate val_2 = System.Delegate.Remove(source:  this.animManager.OnClose, value:  536882991);
        val_5 = this.animManager.OnClose;
        if(val_5 != 0)
        {
                if(null == 536882991)
        {
            goto label_4;
        }
        
        }
        
        val_5 = 0;
        label_4:
        mem2[0] = val_5;
        this.isClosing = false;
        this.panel.SetActive(value:  false);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700911.CheckRetry();
    }
    public NetworkManager()
    {
    
    }
    private void <Start>b__4_0()
    {
        this.RetryButtonClick();
    }

}
