using UnityEngine;
[Serializable]
public class UIManager.Page
{
    // Fields
    public string name;
    public System.Collections.Generic.List<UIPanel> panels;
    public System.Collections.Generic.List<UIPanel> ignoring_panels;
    public bool show_ads;
    public bool default_page;
    public bool setTimeScale;
    public float timeScale;
    public string soundtrack;
    
    // Methods
    public UIManager.Page()
    {
        System.Collections.Generic.List<Page> val_1 = 536878489;
        val_1 = new System.Collections.Generic.List<Page>();
        this.panels = val_1;
        System.Collections.Generic.List<Page> val_2 = 536878489;
        val_2 = new System.Collections.Generic.List<Page>();
        this.ignoring_panels = val_2;
        this.setTimeScale = true;
        this.timeScale = 1f;
        this.soundtrack = -1610611829;
    }

}
