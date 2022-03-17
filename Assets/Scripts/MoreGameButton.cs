using UnityEngine;
public class MoreGameButton : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.RawImage[] icons;
    private UnityEngine.UI.Text[] names;
    private UnityEngine.UI.Button[] buttons;
    
    // Methods
    private void Start()
    {
        System.Collections.IEnumerator val_1 = this.GetMoreGame();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  537374896);
    }
    private System.Collections.IEnumerator GetMoreGame()
    {
        536900045 = new MoreGameButton.<GetMoreGame>d__4(<>1__state:  0);
        mem[536900061] = this;
    }
    private void UpdateData(int index, MoreGameInfo info)
    {
        var val_5;
        MoreGameButton.<>c__DisplayClass5_0 val_1 = 536900043;
        val_1 = new MoreGameButton.<>c__DisplayClass5_0();
        if(val_1 != 0)
        {
                mem[536900051] = this;
            val_5 = val_1;
            mem[536900055] = info;
        }
        else
        {
                mem[8] = this;
            val_5 = 12;
            mem[12] = info;
        }
        
        System.Collections.IEnumerator val_2 = this.LoadImage(index:  index, url:  info + 16);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  537689008);
        UnityEngine.UI.Button val_5 = this.buttons[index];
        536896275 = new UnityEngine.Events.UnityAction(object:  536900043, method:  new IntPtr(1610677375));
        this.buttons[index][0].m_OnClick.AddListener(call:  536896275);
        if(this.names[index] == 0)
        {
            
        }
    
    }
    private System.Collections.IEnumerator LoadImage(int index, string url)
    {
        MoreGameButton.<LoadImage>d__6 val_1 = 536900047;
        val_1 = new MoreGameButton.<LoadImage>d__6(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536900067] = this;
            mem[536900071] = index;
        }
        else
        {
                mem[20] = this;
            mem[24] = index;
        }
        
        mem[536900063] = url;
    }
    public void OnPressMoreGameButton(string androidPackage)
    {
        UnityEngine.Debug.Log(message:  androidPackage);
        string val_1 = -1610599315(-1610599315) + androidPackage;
        UnityEngine.Application.OpenURL(url:  -1610599315);
    }
    public MoreGameButton()
    {
    
    }

}
