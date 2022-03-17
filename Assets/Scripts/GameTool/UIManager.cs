using UnityEngine;

namespace GameTool
{
    public class UIManager : SingletonMonoBehaviour<GameTool.UIManager>
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.Transform> UImodules;
        public static System.Action<string> onShowPage;
        public System.Collections.Generic.List<UIPanel> panels;
        public System.Collections.Generic.List<GameTool.UIManager.Page> pages;
        private string currentPage;
        private string previousPage;
        private string url;
        
        // Properties
        public bool isRate { get; set; }
        
        // Methods
        private void Start()
        {
            this.ArraysConvertation();
            Page val_1 = this.GetDefaultPage();
            if(this == 0)
            {
                    return;
            }
            
            this.ShowPage(page:  1137153552, immediate:  true);
        }
        public bool get_isRate()
        {
            int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -1610605089, defaultValue:  0);
            val_1 = val_1 - 1;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public void set_isRate(bool value)
        {
            UnityEngine.PlayerPrefs.SetInt(key:  -1610605089, value:  value);
        }
        public void OpenStore()
        {
            bool val_1 = System.String.IsNullOrEmpty(value:  this.url);
            if(val_1 != false)
            {
                    UnityEngine.Debug.LogWarning(message:  -1610603117);
                return;
            }
            
            val_1.isRate = true;
            UnityEngine.Application.OpenURL(url:  this.url);
        }
        public void ArraysConvertation()
        {
            UnityEngine.Object val_5;
            System.Collections.Generic.List<UnityEngine.Transform> val_11;
            var val_12;
            var val_13;
            object val_14;
            System.Comparison<AdjustmentRule> val_15;
            536878489 = new System.Collections.Generic.List<Page>();
            this.panels = 536878489;
            T[] val_2 = this.GetComponentsInChildren<UIPanel>(includeInactive:  true);
            this.panels.AddRange(collection:  1137622032);
            val_11 = this.UImodules;
            List.Enumerator<T> val_3 = GetEnumerator();
            label_11:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            if(val_5 == 0)
            {
                goto label_11;
            }
            
            T[] val_7 = val_5.GetComponentsInChildren<UIPanel>(includeInactive:  true);
            if(val_5 == 0)
            {
                goto label_11;
            }
            
            T[] val_8 = val_5.GetComponentsInChildren<UIPanel>(includeInactive:  true);
            this.panels.AddRange(collection:  val_5);
            goto label_11;
            label_3:
            Dispose();
            if(UnityEngine.Application.isEditor == false)
            {
                    return;
            }
            
            val_12 = 22720656;
            val_13 = 536902109;
            if(((mem[536902296] & true) == 0) && (mem[536902225] == 0))
            {
                    val_13 = 536902109;
            }
            
            val_14 = mem[536902201];
            val_15 = mem[mem[536902201] + 4];
            val_15 = mem[536902201] + 4;
            if(val_15 == 0)
            {
                    if(((mem[536902296] & true) == 0) && (mem[536902225] == 0))
            {
                    val_14 = mem[536902201];
            }
            
                val_11 = mem[mem[536902201]];
                val_11 = val_14;
                val_15 = 536873801;
                val_15 = new System.Comparison<AdjustmentRule>(object:  val_11, method:  new IntPtr(1610686597));
                mem2[0] = val_15;
            }
            
            this.panels.Sort(comparison:  536873801);
        }
        public void ShowPage(GameTool.UIManager.Page page, bool immediate = False)
        {
            UIPanel val_4;
            string val_8;
            var val_9;
            val_8 = this.currentPage;
            if((System.String.op_Equality(a:  val_8, b:  page.name)) == true)
            {
                    return;
            }
            
            if(this.pages == 0)
            {
                    return;
            }
            
            this.previousPage = this.currentPage;
            this.currentPage = page.name;
            List.Enumerator<T> val_2 = GetEnumerator();
            val_8 = 22739584;
            label_14:
            if(MoveNext() == false)
            {
                goto label_5;
            }
            
            if((page.panels.Contains(item:  val_4)) == false)
            {
                goto label_7;
            }
            
            val_4.SetVisible(visible:  true, immediate:  immediate);
            goto label_14;
            label_7:
            if(((page.ignoring_panels.Contains(item:  val_4)) == true) || ((val_4 + 12) != 0))
            {
                goto label_14;
            }
            
            val_4.SetVisible(visible:  false, immediate:  immediate);
            goto label_14;
            label_5:
            Dispose();
            val_9 = 536896125;
            if(((mem[536896312] & true) == 0) && (mem[536896241] == 0))
            {
                    val_9 = 536896125;
            }
            
            mem[536896217].Invoke(obj:  page.name);
        }
        public void ShowPage(string page_name)
        {
            this.ShowPage(page_name:  page_name, immediate:  false);
        }
        public void ShowPage(string page_name, bool immediate)
        {
            536902113 = new UIManager.<>c__DisplayClass16_0();
            mem[536902121] = page_name;
            536879281 = new System.Predicate<Page>(object:  536902113, method:  new IntPtr(1610686605));
            Page val_3 = this.pages.Find(match:  536879281);
            if(this.pages == 0)
            {
                    return;
            }
            
            this.ShowPage(page:  this.pages, immediate:  immediate);
        }
        public void FreezPanel(string panel_name, bool value = True)
        {
            536902115 = new UIManager.<>c__DisplayClass17_0();
            mem[536902123] = panel_name;
            536879265 = new System.Predicate<Page>(object:  536902115, method:  new IntPtr(1610686609));
            UIPanel val_3 = this.panels.Find(match:  536879265);
            if(this.panels == 0)
            {
                    return;
            }
            
            mem2[0] = value;
        }
        public void SetPanelVisible(string panel_name, bool visible, bool immediate = False)
        {
            536902117 = new UIManager.<>c__DisplayClass18_0();
            mem[536902125] = panel_name;
            536879265 = new System.Predicate<Page>(object:  536902117, method:  new IntPtr(1610686613));
            UIPanel val_3 = this.panels.Find(match:  536879265);
            if((UnityEngine.Object.op_Implicit(exists:  this.panels)) == false)
            {
                    return;
            }
            
            if(immediate == true)
            {
                    -1073711759 = 1;
            }
            
            if(immediate == false)
            {
                    -1073711759 = 0;
            }
            
            this.panels.SetVisible(visible:  visible, immediate:  false);
        }
        public void HideAll()
        {
            var val_3;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_4:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            val_3.SetVisible(visible:  false, immediate:  false);
            goto label_4;
            label_2:
            Dispose();
        }
        public void ShowPreviousPage()
        {
            WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610601535, volume:  null);
            this.ShowPage(page_name:  this.previousPage, immediate:  false);
        }
        public void ShowDefaultPage()
        {
            Page val_1 = this.GetDefaultPage();
            this.ShowPage(page:  1138677776, immediate:  false);
        }
        public string GetCurrentPage()
        {
        
        }
        public GameTool.UIManager.Page GetDefaultPage()
        {
            var val_2;
            object val_3;
            System.Predicate<Page> val_4;
            val_2 = 536902109;
            if(((mem[536902296] & true) == 0) && (mem[536902225] == 0))
            {
                    val_2 = 536902109;
            }
            
            val_3 = mem[536902201];
            val_4 = mem[mem[536902201] + 8];
            val_4 = mem[536902201] + 8;
            if(val_4 == 0)
            {
                    if(((mem[536902296] & true) == 0) && (mem[536902225] == 0))
            {
                    val_3 = mem[536902201];
            }
            
                val_4 = 536879281;
                val_4 = new System.Predicate<Page>(object:  val_3, method:  new IntPtr(1610686599));
                mem2[0] = val_4;
            }
            
            if(this.pages != 0)
            {
                    return this.pages.Find(match:  536879281);
            }
            
            return this.pages.Find(match:  536879281);
        }
        public UIManager()
        {
            536878437 = new System.Collections.Generic.List<Page>();
            this.UImodules = 536878437;
            536878489 = new System.Collections.Generic.List<Page>();
            this.panels = 536878489;
            536878743 = new System.Collections.Generic.List<Page>();
            this.pages = 536878743;
        }
        private static UIManager()
        {
            if(((mem[536902296] & true) == 0) && (mem[536902225] == 0))
            {
                    536902109 = 536902109;
            }
            
            536873327 = new System.Action<SdkConfiguration>(object:  mem[536902201], method:  new IntPtr(1610686601));
            mem2[0] = 536873327;
        }
    
    }

}
