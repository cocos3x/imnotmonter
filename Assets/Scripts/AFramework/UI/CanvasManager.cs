using UnityEngine;

namespace AFramework.UI
{
    public class CanvasManager : SingletonMono<AFramework.UI.CanvasManager>
    {
        // Fields
        private static UnityEngine.Canvas _UICanvas;
        private static float <ScreenScale>k__BackingField;
        private static UnityEngine.RectTransform _UIRectTrans;
        private static UnityEngine.RectTransform _AdsRectTrans;
        private static string DefaultDataPath;
        private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Stack<AFramework.UI.BaseUIMenu>> UICached;
        private static System.Collections.Generic.List<System.Collections.Generic.List<AFramework.UI.BaseUIMenu>> OpenedUIStack;
        public static System.Action<AFramework.UI.BaseUIMenu> EventOnMenuPushed;
        public static System.Action<AFramework.UI.BaseUIMenu> EventOnMenuPopped;
        private float mLastBackeyTime;
        public static UnityEngine.GameObject sSystemLoadingPopup;
        
        // Properties
        public static UnityEngine.Canvas UICanvas { get; }
        public static float ScreenScale { get; set; }
        public static UnityEngine.RectTransform UIRectTrans { get; }
        public static UnityEngine.RectTransform AdsRectTrans { get; }
        
        // Methods
        public static UnityEngine.Canvas get_UICanvas()
        {
            if((mem[536884806] & true) != 0)
            {
                    return;
            }
            
            if(mem[536884735] != 0)
            {
                    return;
            }
            
            536884619 = 536884619;
        }
        public static float get_ScreenScale()
        {
            if((mem[536884806] & true) != 0)
            {
                    return (float)S0;
            }
            
            if(mem[536884735] != 0)
            {
                    return (float)S0;
            }
            
            536884619 = 536884619;
            return (float)S0;
        }
        protected static void set_ScreenScale(float value)
        {
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    536884619 = 536884619;
            }
            
            mem2[0] = 0;
        }
        public static UnityEngine.RectTransform get_UIRectTrans()
        {
            if((mem[536884806] & true) != 0)
            {
                    return;
            }
            
            if(mem[536884735] != 0)
            {
                    return;
            }
            
            536884619 = 536884619;
        }
        public static UnityEngine.RectTransform get_AdsRectTrans()
        {
            if((mem[536884806] & true) != 0)
            {
                    return;
            }
            
            if(mem[536884735] != 0)
            {
                    return;
            }
            
            536884619 = 536884619;
        }
        protected virtual void Awake()
        {
            float val_8;
            float val_9;
            float val_10;
            AFramework.UI.CanvasManager val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            val_26 = this;
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            val_27 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_27 = 536884619;
            }
            
            mem2[0] = val_26;
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073763503)});
            mem[536882545] = 1073763503;
            536887303 = new UnityEngine.GameObject(name:  -1610603225, components:  536882529);
            Weight val_4 = 536887303.GetComponent<Weight>();
            mem2[0] = 536887303;
            UnityEngine.Transform val_5 = this.transform;
            mem[536884711] + 8.SetParent(p:  1179708464);
            UnityEngine.Transform val_6 = mem[536884711] + 8.transform;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            mem[536884711] + 8.localPosition = new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10};
            val_28 = 22709744;
            mem[536884711].SetFullScreenRect(target:  mem[536884711] + 8);
            UnityEngine.Transform val_11 = this.transform;
            UnityEngine.RectTransform val_12 = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  mem[536884711] + 8, parent:  1179708464);
            mem2[0] = mem[536884711] + 8;
            mem[536884711] + 12.name = -1610610287;
            System.Type val_13 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073768267)});
            var val_26 = 1073768267;
            System.String[] val_14 = System.Enum.GetNames(enumType:  1073768267);
            val_26 = val_26 + 16;
            val_29 = 0;
            goto label_18;
            label_36:
            System.Type val_15 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073763503)});
            mem[536882545] = 1073763503;
            536887303 = new UnityEngine.GameObject(name:  (1073768267 + 16) + 0, components:  536882529);
            UnityEngine.Transform val_17 = val_16.transform;
            val_30 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_30 = 536884619;
            }
            
            UnityEngine.Transform val_18 = mem[536884711] + 8.transform;
            val_16.SetParent(p:  mem[536884711] + 8);
            UnityEngine.Transform val_19 = val_16.transform;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.zero;
            val_16.localPosition = new UnityEngine.Vector3() {x = R5, y = R6, z = R8};
            Weight val_21 = val_16.GetComponent<Weight>();
            this.SetFullScreenRect(target:  536887303);
            val_28 = 22709744;
            536877767 = new System.Collections.Generic.List<Page>();
            mem[536884711] + 24.Add(item:  536877767);
            val_29 = 1;
            label_18:
            if(val_29 < mem[1073768279])
            {
                goto label_36;
            }
            
            var val_27 = 17040816;
            val_27 = 5929120 + val_27;
            if(val_27 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_31 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_31 = 536884619;
            }
            
            UnityEngine.Rect val_23 = pixelRect;
            UnityEngine.Vector2 val_24 = size;
            float val_28 = val_9;
            if(val_27 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_32 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_32 = 536884619;
            }
            
            float val_25 = mem[536884711].scaleFactor;
            val_28 = val_28 / mem[536884711];
            val_28 = val_28 / 1080f;
            val_33 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_33 = 536884619;
            }
            
            mem2[0] = val_28;
        }
        private void SetFullScreenRect(UnityEngine.RectTransform target)
        {
            UnityEngine.Transform val_1 = target.transform;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            target.localScale = new UnityEngine.Vector3() {x = R6, y = R7, z = R8};
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            target.anchorMin = new UnityEngine.Vector2() {x = R5, y = R6};
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.one;
            target.anchorMax = new UnityEngine.Vector2() {x = R5, y = R6};
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
            target.offsetMin = new UnityEngine.Vector2() {x = R5, y = R6};
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
            target.offsetMax = new UnityEngine.Vector2() {x = R5, y = R6};
        }
        public static void SetAdsBannerSizeByRatio(bool top, float ratioByWidth)
        {
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    536884619 = 536884619;
            }
            
            UnityEngine.Rect val_1 = rect;
            float val_2 = width;
            uint val_4 = 1179928616;
            val_4 = val_4 * R1;
            AFramework.UI.CanvasManager.SetAdsBannerSize(top:  top, height:  UnityEngine.Mathf.CeilToInt(f:  val_4));
        }
        public static void SetAdsBannerSize(bool top, int height)
        {
            float val_2;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_12 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_12 = 536884619;
            }
            
            UnityEngine.Vector2 val_1 = offsetMin;
            if(top == true)
            {
                    (float)height = 0;
            }
            
            mem[536884711] + 8.offsetMin = new UnityEngine.Vector2() {x = val_2, y = 0f};
            val_13 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_13 = 536884619;
            }
            
            UnityEngine.Vector2 val_3 = offsetMin;
            if(top == true)
            {
                    top = (float)0 - height;
            }
            
            mem[536884711] + 8.offsetMax = new UnityEngine.Vector2() {x = val_2, y = top};
            val_14 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_14 = 536884619;
            }
            
            val_15 = 0;
            UnityEngine.Vector2 val_5 = offsetMin;
            if(top != false)
            {
                    val_16 = 536884619;
                if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_16 = 536884619;
            }
            
                UnityEngine.Rect val_6 = rect;
                float val_7 = height;
                val_15 = ;
            }
            
            mem[536884711] + 12.offsetMin = new UnityEngine.Vector2() {x = val_2, y = 13695.4f};
            val_17 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_17 = 536884619;
            }
            
            val_18 = 0;
            UnityEngine.Vector2 val_8 = offsetMin;
            if(top != true)
            {
                    val_19 = 536884619;
                if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_19 = 536884619;
            }
            
                UnityEngine.Rect val_9 = rect;
                float val_10 = height;
                val_18 = 1152921512229338520;
            }
            
            mem[536884711] + 12.offsetMax = new UnityEngine.Vector2() {x = val_2, y = -13695.4f};
        }
        public static void SetAdsBannerSize(bool top, int height, AFramework.UI.eUILayer layer)
        {
            float val_4;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            val_14 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_14 = 536884619;
            }
            
            UnityEngine.Transform val_1 = mem[536884711] + 8.GetChild(index:  layer);
            UnityEngine.Transform val_2 = mem[536884711] + 8.GetComponent<UnityEngine.Transform>();
            UnityEngine.Vector2 val_3 = offsetMin;
            if(top == true)
            {
                    (float)height = 0;
            }
            
            mem[536884711] + 8.offsetMin = new UnityEngine.Vector2() {x = val_4, y = 0f};
            val_15 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_15 = 536884619;
            }
            
            UnityEngine.Vector2 val_5 = offsetMin;
            if(top == true)
            {
                    top = (float)0 - height;
            }
            
            mem[536884711] + 8.offsetMax = new UnityEngine.Vector2() {x = val_4, y = top};
            val_16 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_16 = 536884619;
            }
            
            val_17 = 0;
            UnityEngine.Vector2 val_7 = offsetMin;
            if(top != false)
            {
                    val_18 = 536884619;
                if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_18 = 536884619;
            }
            
                UnityEngine.Rect val_8 = rect;
                float val_9 = height;
                val_17 = ;
            }
            
            mem[536884711] + 12.offsetMin = new UnityEngine.Vector2() {x = val_4, y = 13808.77f};
            val_19 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_19 = 536884619;
            }
            
            val_20 = 0;
            UnityEngine.Vector2 val_10 = offsetMin;
            if(top != true)
            {
                    val_21 = 536884619;
                if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_21 = 536884619;
            }
            
                UnityEngine.Rect val_11 = rect;
                float val_12 = height;
                val_20 = 1152921512229454616;
            }
            
            mem[536884711] + 12.offsetMax = new UnityEngine.Vector2() {x = val_4, y = -13808.77f};
        }
        public static void SetBannerBackgroundColor(UnityEngine.Color input)
        {
            var val_5;
            UnityEngine.Object val_6;
            var val_7;
            val_5 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_5 = 536884619;
            }
            
            UnityEngine.Transform val_1 = mem[536884711] + 12.GetComponent<UnityEngine.Transform>();
            val_6 = mem[536884711] + 12;
            if(val_6 == 0)
            {
                    val_7 = 536884619;
                if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_7 = 536884619;
            }
            
                UnityEngine.GameObject val_3 = mem[536884711] + 12.gameObject;
                SynchronizationContextBehavoir val_4 = mem[536884711] + 12.AddComponent<SynchronizationContextBehavoir>();
                val_6 = mem[536884711] + 12;
            }
            
            if(val_6 != 0)
            {
                    return;
            }
        
        }
        public static void SetBannerBackgroundSprite(UnityEngine.Sprite input)
        {
            var val_5;
            UnityEngine.Object val_6;
            var val_7;
            val_5 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_5 = 536884619;
            }
            
            UnityEngine.Transform val_1 = mem[536884711] + 12.GetComponent<UnityEngine.Transform>();
            val_6 = mem[536884711] + 12;
            if(val_6 == 0)
            {
                    val_7 = 536884619;
                if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_7 = 536884619;
            }
            
                UnityEngine.GameObject val_3 = mem[536884711] + 12.gameObject;
                SynchronizationContextBehavoir val_4 = mem[536884711] + 12.AddComponent<SynchronizationContextBehavoir>();
                val_6 = mem[536884711] + 12;
            }
            
            val_6.sprite = input;
        }
        public static AFramework.UI.BaseUIMenu TryCacheUI(string identifier)
        {
            var val_13;
            var val_14;
            var val_15;
            DG.Tweening.Tween val_16;
            var val_17;
            int val_18;
            var val_19;
            var val_20;
            var val_21;
            val_13 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_13 = 536884619;
            }
            
            val_14 = 536884619;
            var val_13 = mem[536884805];
            val_13 = val_13 & 512;
            if((mem[536884711] + 20.ContainsKey(key:  identifier)) != false)
            {
                    if((val_13 != 0) && (mem[536884735] == 0))
            {
                    val_15 = 536884619;
            }
            
                UnityEngine.Purchasing.IStoreExtension val_2 = mem[536884711] + 20.Item[identifier];
                val_16 = 0;
                if((mem[536884711] + 20 + 12) > 0)
            {
                    return;
            }
            
                val_17 = 536884619;
                if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_17 = 536884619;
            }
            
                string val_3 = mem[536884711] + 16(mem[536884711] + 16) + identifier;
                TMPro.TMP_SpriteAsset val_4 = UnityEngine.Resources.Load<TMPro.TMP_SpriteAsset>(path:  mem[536884711] + 16);
                val_18 = mem[mem[536884711] + 16 + 12];
                val_18 = mem[536884711] + 16 + 12;
                UnityEngine.Transform val_5 = mem[536884711] + 8.GetChild(index:  val_18);
                UnityEngine.RectTransform val_6 = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  mem[536884711] + 16, parent:  mem[536884711] + 8);
                val_16 = mem[536884711] + 16;
                mem2[0] = identifier;
                val_19 = mem[mem[536884711] + 20];
                val_19 = mem[536884711] + 20;
                val_20 = -1073734033;
            }
            else
            {
                    if((val_13 != 0) && (mem[536884735] == 0))
            {
                    val_21 = 536884619;
            }
            
                536879617 = new System.Collections.Generic.Stack<DG.Tweening.Tween>();
                mem[536884711] + 20.set_Item(key:  identifier, value:  536879617);
                string val_8 = mem[536884711] + 16(mem[536884711] + 16) + identifier;
                TMPro.TMP_SpriteAsset val_9 = UnityEngine.Resources.Load<TMPro.TMP_SpriteAsset>(path:  mem[536884711] + 16);
                val_18 = mem[mem[536884711] + 16 + 12];
                val_18 = mem[536884711] + 16 + 12;
                UnityEngine.Transform val_10 = mem[536884711] + 8.GetChild(index:  val_18);
                UnityEngine.RectTransform val_11 = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  mem[536884711] + 16, parent:  mem[536884711] + 8);
                val_16 = mem[536884711] + 16;
                mem2[0] = identifier;
                val_19 = mem[mem[536884711] + 20];
                val_19 = mem[536884711] + 20;
                val_20 = -1073734033;
            }
            
            UnityEngine.Purchasing.IStoreExtension val_12 = val_19.Item[identifier];
            val_19.Push(item:  val_16);
        }
        public static void ClearAllCacheUI()
        {
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    536884619 = 536884619;
            }
            
            mem[536884711] + 20.Clear();
        }
        public static void ClearAllUI()
        {
            AFramework.UI.CanvasManager.PopAllLayer(layer:  2);
            AFramework.UI.CanvasManager.PopAllLayer(layer:  1);
            mem[536884711] + 20.Clear();
        }
        public static AFramework.UI.BaseUIMenu Push(string identifier, object[] initParams)
        {
            var val_6;
            var val_7;
            AFramework.UI.BaseUIMenu val_1 = AFramework.UI.CanvasManager.TryCacheUI(identifier:  identifier);
            UnityEngine.Purchasing.IStoreExtension val_2 = mem[536884711] + 20.Item[identifier];
            DG.Tweening.Tween val_3 = mem[536884711] + 20.Pop();
            if((mem[536884711] + 20 + 12) == 1)
            {
                    val_6 = 536884619;
                if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_6 = 536884619;
            }
            
                if((mem[536884711] + 24 + 12) <= 2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((mem[536884711] + 24 + 8 + 24 + 12) >= 1)
            {
                    AFramework.UI.CanvasManager.PopAllLayer(layer:  2);
            }
            
            }
            
            UnityEngine.GameObject val_4 = mem[536884711] + 20.gameObject;
            mem[536884711] + 20.SetActive(value:  true);
            val_7 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_7 = 536884619;
            }
            
            if((mem[536884711] + 24 + 12) <= (mem[536884711] + 20 + 12))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_6 = mem[536884711] + 24 + 8;
            val_6 = val_6 + ((mem[536884711] + 20 + 12) << 2);
            (mem[536884711] + 24 + 8 + (mem[536884711] + 20 + 12) << 2) + 16.Add(item:  mem[536884711] + 20);
            mem[536884711] + 20.ResetActiveTime();
            UnityEngine.Transform val_5 = mem[536884711] + 20.transform;
            mem[536884711] + 20.SetAsLastSibling();
            if((mem[536884711] + 28) == 0)
            {
                    return;
            }
            
            0.Invoke(obj:  mem[536884711] + 20);
        }
        public static void PopTop(AFramework.UI.eUILayer layer)
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            val_1 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_1 = 536884619;
            }
            
            if((mem[536884711] + 24 + 12) <= layer)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_1 = mem[536884711] + 24 + 8;
            val_1 = val_1 + (layer << 2);
            val_2 = mem[(mem[536884711] + 24 + 8 + (layer) << 2) + 16];
            val_2 = (mem[536884711] + 24 + 8 + (layer) << 2) + 16;
            if(((mem[536884711] + 24 + 8 + (layer) << 2) + 16 + 12) < 1)
            {
                    return;
            }
            
            val_3 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_3 = 536884619;
            }
            
            if((mem[536884711] + 24 + 12) <= layer)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = mem[536884711] + 24 + 8;
            val_2 = val_2 + (layer << 2);
            if(((mem[536884711] + 24 + 8 + (layer) << 2) + 16) != 0)
            {
                    val_4 = mem[(mem[536884711] + 24 + 8 + (layer) << 2) + 16 + 12];
                val_4 = (mem[536884711] + 24 + 8 + (layer) << 2) + 16 + 12;
                val_5 = val_4;
            }
            else
            {
                    val_2 = 12;
                val_5 = 0;
                val_4 = 0;
            }
            
            if(val_4 <= (-1))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = (mem[536884711] + 24 + 8 + (layer) << 2) + 16 + 8;
            val_3 = val_3 + 4294967292;
            if((((mem[536884711] + 24 + 8 + (layer) << 2) + 16 + 8 + 4294967292) + 16) == 0)
            {
                
            }
        
        }
        public static bool PopSelf(AFramework.UI.BaseUIMenu menu, bool destroy = False)
        {
            var val_7;
            var val_8;
            UnityEngine.Object val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            CanvasManager.<>c__DisplayClass30_0 val_1 = 536898223;
            val_7 = val_1;
            val_1 = new CanvasManager.<>c__DisplayClass30_0();
            mem[536898231] = menu;
            val_8 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_8 = 536884619;
            }
            
            val_9 = mem[menu + 12];
            val_9 = menu + 12;
            if((mem[536884711] + 24 + 12) <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = mem[536884711] + 24 + 8;
            val_7 = val_7 + (val_9 << 2);
            val_10 = 1;
            if(((mem[536884711] + 24 + 8 + (menu + 12) << 2) + 16 + 12) < 1)
            {
                    return (bool)val_10;
            }
            
            if(mem[536898231] == 0)
            {
                    return (bool)val_10;
            }
            
            val_11 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_11 = 536884619;
            }
            
            if((mem[536884711] + 24 + 12) <= (menu + 12))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_8 = mem[536884711] + 24 + 8;
            val_8 = val_8 + ((menu + 12) << 2);
            val_9 = mem[(mem[536884711] + 24 + 8 + (menu + 12) << 2) + 16];
            val_9 = (mem[536884711] + 24 + 8 + (menu + 12) << 2) + 16;
            536879215 = new System.Predicate<Page>(object:  536898223, method:  new IntPtr(1610687331));
            int val_4 = val_9.FindIndex(match:  536879215);
            if(val_4 < 0)
            {
                goto label_18;
            }
            
            val_9.RemoveAt(index:  val_4);
            UnityEngine.GameObject val_5 = mem[536898231].gameObject;
            val_9 = mem[536898231];
            if(destroy == false)
            {
                goto label_21;
            }
            
            UnityEngine.Object.Destroy(obj:  val_9);
            val_7 = 22709744;
            goto label_24;
            label_18:
            val_10 = 0;
            return (bool)val_10;
            label_21:
            val_9.SetActive(value:  false);
            val_7 = 22709744;
            val_12 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_12 = 536884619;
            }
            
            UnityEngine.Purchasing.IStoreExtension val_6 = mem[536884711] + 20.Item[menu + 24];
            val_9 = mem[536898231];
            mem[536884711] + 20.Push(item:  val_9);
            label_24:
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_13 = 536884619;
            }
            
            if((mem[536884711] + 32) == 0)
            {
                    return (bool)val_10;
            }
            
            if((mem[536884806] & true) == 0)
            {
                    if(mem[536884735] == 0)
            {
                goto label_36;
            }
            
            }
            
            label_38:
            mem[536884711] + 32.Invoke(obj:  mem[536898231]);
            return (bool)val_10;
            label_36:
            if((mem[536884711] + 32) != 0)
            {
                goto label_38;
            }
            
            goto label_38;
        }
        public static bool Pop(string identifier)
        {
            UnityEngine.Object val_6;
            System.Predicate<Page> val_7;
            var val_8;
            CanvasManager.<>c__DisplayClass31_0 val_1 = 536898225;
            val_6 = 0;
            val_1 = new CanvasManager.<>c__DisplayClass31_0();
            val_7 = val_1;
            mem[536898233] = identifier;
            var val_7 = 4;
            label_11:
            if(0 != 0)
            {
                goto label_4;
            }
            
            val_8 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_8 = 536884619;
            }
            
            var val_3 = val_7 - 4;
            if((mem[536884711] + 24 + 12) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = mem[536898237];
            if(val_7 == 0)
            {
                    val_7 = 536879215;
                val_7 = new System.Predicate<Page>(object:  536898225, method:  new IntPtr(1610687335));
                mem[536898237] = val_7;
            }
            
            Page val_5 = mem[536884711] + 24 + 8 + 16.Find(match:  536879215);
            val_7 = val_7 + 1;
            val_6 = mem[536884711] + 24 + 8 + 16;
            if(val_3 <= 2)
            {
                goto label_11;
            }
            
            label_4:
            if(val_6 == 0)
            {
                    return false;
            }
            
            if((mem[536884806] & true) != 0)
            {
                    return AFramework.UI.CanvasManager.PopSelf(menu:  val_6, destroy:  false);
            }
            
            if(mem[536884735] != 0)
            {
                    return AFramework.UI.CanvasManager.PopSelf(menu:  val_6, destroy:  false);
            }
            
            return AFramework.UI.CanvasManager.PopSelf(menu:  val_6, destroy:  false);
        }
        public static void PopAllLayer(AFramework.UI.eUILayer layer)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_6 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_6 = 536884619;
            }
            
            val_7 = mem[mem[536884711] + 24];
            val_7 = mem[536884711] + 24;
            if((mem[536884711] + 24 + 12) < 1)
            {
                    return;
            }
            
            val_8 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_8 = 536884619;
            }
            
            val_7 = mem[mem[536884711] + 24];
            val_7 = mem[536884711] + 24;
            if((mem[536884711] + 24 + 12) <= layer)
            {
                    return;
            }
            
            val_9 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_9 = 536884619;
            }
            
            if((mem[536884711] + 24 + 12) <= layer)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_5 = mem[536884711] + 24 + 8;
            val_5 = val_5 + (layer << 2);
            T[] val_1 = (mem[536884711] + 24 + 8 + (layer) << 2) + 16.ToArray();
            536877767 = new System.Collections.Generic.List<Point>(collection:  (mem[536884711] + 24 + 8 + (layer) << 2) + 16);
            val_10 = mem[536877779];
            if(val_10 < 1)
            {
                    return;
            }
            
            val_7 = val_10 + 3;
            goto label_16;
            label_19:
            val_10 = mem[536877779];
            val_7 = val_7 - 1;
            label_16:
            if(val_10 <= (val_7 - 4))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((val_7 - 5) >= 0)
            {
                goto label_19;
            }
        
        }
        public static bool IsPopupShown()
        {
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    536884619 = 536884619;
            }
            
            if((mem[536884711] + 24 + 12) <= 2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((mem[536884711] + 24 + 8 + 24 + 12) > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public static AFramework.UI.BaseUIMenu GetCurrentMenu(AFramework.UI.eUILayer topLayer = 3)
        {
            var val_2;
            var val_3;
            AFramework.UI.eUILayer val_2 = topLayer;
            if(val_2 < 0)
            {
                    return;
            }
            
            val_2 = val_2 + 4;
            label_8:
            val_2 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_2 = 536884619;
            }
            
            AFramework.UI.eUILayer val_1 = val_2 - 4;
            if((mem[536884711] + 24 + 12) <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((mem[536884711] + 24 + 8 + ((topLayer + 4)) << 2 + 12) >= 1)
            {
                goto label_7;
            }
            
            val_2 = val_2 - 1;
            if(val_1 > 0)
            {
                goto label_8;
            }
            
            return;
            label_7:
            val_3 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_3 = 536884619;
            }
            
            if((mem[536884711] + 24 + 12) <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((mem[536884711] + 24 + 12) <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = mem[536884711] + 24 + 8 + ((topLayer + 4)) << 2 + 12;
            val_3 = val_3 - 1;
            if((mem[536884711] + 24 + 8 + ((topLayer + 4)) << 2 + 12) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = mem[536884711] + 24 + 8 + ((topLayer + 4)) << 2 + 8;
            val_4 = val_4 + (val_3 << 2);
        }
        public static AFramework.UI.BaseUIMenu GetCurrentMenuByLayer(AFramework.UI.eUILayer layer)
        {
            var val_1;
            var val_2;
            val_1 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_1 = 536884619;
            }
            
            if((mem[536884711] + 24 + 12) <= layer)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_1 = mem[536884711] + 24 + 8;
            val_1 = val_1 + (layer << 2);
            if(((mem[536884711] + 24 + 8 + (layer) << 2) + 16 + 12) < 1)
            {
                    return;
            }
            
            val_2 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_2 = 536884619;
            }
            
            if((mem[536884711] + 24 + 12) <= layer)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = mem[536884711] + 24 + 8;
            val_2 = val_2 + (layer << 2);
            if((mem[536884711] + 24 + 12) <= layer)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = mem[536884711] + 24 + 8;
            val_3 = val_3 + (layer << 2);
            var val_4 = (mem[536884711] + 24 + 8 + (layer) << 2) + 16 + 12;
            val_4 = val_4 - 1;
            if(((mem[536884711] + 24 + 8 + (layer) << 2) + 16 + 12) <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_5 = (mem[536884711] + 24 + 8 + (layer) << 2) + 16 + 8;
            val_5 = val_5 + (val_4 << 2);
        }
        public static AFramework.UI.BaseUIMenu IsSpecificUIShown(string identifier)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = 0;
            goto label_1;
            label_15:
            val_3 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_3 = 536884619;
            }
            
            if((mem[536884711] + 24 + 12) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = mem[536884711] + 24 + 8;
            val_4 = 4;
            val_2 = val_2 + 0;
            goto label_6;
            label_11:
            if(val_2 <= (mem[536884711] + 24))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((System.String.op_Equality(a:  (mem[536884711] + 24 + 8 + 0) + 16 + 8 + 16 + 24, b:  identifier)) == true)
            {
                goto label_9;
            }
            
            val_4 = 5;
            label_6:
            if(1 < ((mem[536884711] + 24 + 8 + 0) + 16 + 12))
            {
                goto label_11;
            }
            
            val_2 = 1;
            label_1:
            val_5 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_5 = 536884619;
            }
            
            if(val_2 < (mem[536884711] + 24 + 12))
            {
                goto label_15;
            }
            
            return;
            label_9:
            if(((mem[536884711] + 24 + 8 + 0) + 16 + 12) > (mem[536884711] + 24))
            {
                    return;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        public static int GetUIStackCount(AFramework.UI.eUILayer layer)
        {
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    536884619 = 536884619;
            }
            
            if((mem[536884711] + 24 + 12) <= layer)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_1 = mem[536884711] + 24 + 8;
            val_1 = val_1 + (layer << 2);
            if(((mem[536884711] + 24 + 8 + (layer) << 2) + 16) != 0)
            {
                    return (int)(mem[536884711] + 24 + 8 + (layer) << 2) + 16 + 12;
            }
            
            return (int)(mem[536884711] + 24 + 8 + (layer) << 2) + 16 + 12;
        }
        public static AFramework.UI.BaseUIMenu GetMenu(string identifier, bool autoCreated = True)
        {
            UnityEngine.Object val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            AFramework.UI.BaseUIMenu val_1 = AFramework.UI.CanvasManager.IsSpecificUIShown(identifier:  identifier);
            val_8 = identifier;
            if(val_8 != 0)
            {
                    return;
            }
            
            val_9 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_9 = 536884619;
            }
            
            val_10 = mem[mem[536884711] + 20];
            val_10 = mem[536884711] + 20;
            if((val_10.ContainsKey(key:  identifier)) == false)
            {
                goto label_14;
            }
            
            val_11 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_11 = 536884619;
            }
            
            UnityEngine.Purchasing.IStoreExtension val_4 = mem[536884711] + 20.Item[identifier];
            val_10 = mem[536884711] + 20;
            if((mem[536884711] + 20 + 12) < 1)
            {
                goto label_14;
            }
            
            val_12 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_12 = 536884619;
            }
            
            val_13 = mem[mem[536884711] + 20];
            val_13 = mem[536884711] + 20;
            val_14 = -1073734033;
            goto label_18;
            label_14:
            if(autoCreated == false)
            {
                    return;
            }
            
            AFramework.UI.BaseUIMenu val_5 = AFramework.UI.CanvasManager.TryCacheUI(identifier:  identifier);
            val_13 = mem[mem[536884711] + 20];
            val_13 = mem[536884711] + 20;
            val_14 = -1073734033;
            label_18:
            UnityEngine.Purchasing.IStoreExtension val_6 = val_13.Item[identifier];
            object val_7 = val_13.Peek();
            val_8 = val_13;
        }
        public static void AddUIToCache(AFramework.UI.BaseUIMenu menu)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            if((menu.<UIIdentifier>k__BackingField) == null)
            {
                    string val_1 = menu.name;
                menu.<UIIdentifier>k__BackingField = menu;
            }
            
            val_6 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_6 = 536884619;
            }
            
            val_7 = mem[mem[536884711] + 20];
            val_7 = mem[536884711] + 20;
            if((val_7.ContainsKey(key:  menu + 24)) != true)
            {
                    val_8 = 536884619;
                if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_8 = 536884619;
            }
            
                val_7 = mem[mem[536884711] + 20];
                val_7 = mem[536884711] + 20;
                536879617 = new System.Collections.Generic.Stack<DG.Tweening.Tween>();
                val_7.set_Item(key:  menu + 24, value:  536879617);
            }
            
            val_9 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_9 = 536884619;
            }
            
            UnityEngine.Purchasing.IStoreExtension val_4 = mem[536884711] + 20.Item[menu + 24];
            mem[536884711] + 20.Push(item:  menu);
            UnityEngine.GameObject val_5 = menu.gameObject;
            menu.SetActive(value:  false);
        }
        public static AFramework.UI.BaseUIMenu Init(string dataPath, string defaultMenuIdentifier)
        {
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    536884619 = 536884619;
            }
            
            mem2[0] = dataPath;
            return AFramework.UI.CanvasManager.Push(identifier:  defaultMenuIdentifier, initParams:  null);
        }
        public static void SetRenderCamera(UnityEngine.Camera newCamera)
        {
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    536884619 = 536884619;
            }
            
            mem[536884711].worldCamera = newCamera;
        }
        private void Update()
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_13 = this;
            val_14 = 22709744;
            AFramework.UI.BaseUIMenu val_1 = AFramework.UI.CanvasManager.GetCurrentMenuByLayer(layer:  1);
            if(1 != 0)
            {
                    val_15 = 0;
                1.UpdateActiveTime(delta:  UnityEngine.Time.unscaledDeltaTime);
            }
            
            val_16 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_16 = 536884619;
            }
            
            if((mem[536884711] + 36) != 0)
            {
                    val_17 = 536884619;
                if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_17 = 536884619;
            }
            
                if((mem[536884711] + 36.activeSelf) == true)
            {
                    return;
            }
            
            }
            
            if(UnityEngine.Application.isFocused == false)
            {
                    return;
            }
            
            bool val_7 = UnityEngine.Input.GetKey(key:  27);
            if(val_7 == false)
            {
                    return;
            }
            
            float val_8 = UnityEngine.Time.unscaledTime;
            if(val_7 >= 0)
            {
                    return;
            }
            
            float val_9 = UnityEngine.Time.unscaledTime;
            float val_12 = 0.15f;
            val_12 = 0 + val_12;
            this.mLastBackeyTime = val_12;
            AFramework.UI.BaseUIMenu val_10 = AFramework.UI.CanvasManager.GetCurrentMenu(topLayer:  3);
            if(3 == 0)
            {
                    return;
            }
        
        }
        public static void ShowSystemLoadingPopup(bool show)
        {
            float val_7;
            float val_8;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_16 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_16 = 536884619;
            }
            
            if((mem[536884711] + 36) == 0)
            {
                    536887303 = new UnityEngine.GameObject(name:  -1610604173);
                val_17 = 536884619;
                if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_17 = 536884619;
            }
            
                mem2[0] = 536887303;
                UnityEngine.Transform val_3 = mem[536884711] + 36.transform;
                val_18 = 536884619;
                if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_18 = 536884619;
            }
            
                UnityEngine.Transform val_4 = mem[536884711].transform;
                mem[536884711] + 36.SetParent(p:  mem[536884711]);
                UnityEngine.Transform val_5 = mem[536884711] + 36.transform;
                UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
                mem[536884711] + 36.localPosition = new UnityEngine.Vector3() {x = val_7, y = val_8, z = 0f};
                UnityEngine.Transform val_9 = mem[536884711] + 36.transform;
                UnityEngine.Vector2 val_10 = UnityEngine.Vector2.one;
                mem[536884711] + 36.localScale = new UnityEngine.Vector3() {x = val_7, y = val_8, z = 0f};
                SynchronizationContextBehavoir val_11 = mem[536884711] + 36.AddComponent<SynchronizationContextBehavoir>();
                UnityEngine.Vector2 val_12 = UnityEngine.Vector2.zero;
                mem[536884711] + 36.anchorMin = new UnityEngine.Vector2() {x = val_7, y = val_8};
                UnityEngine.Vector2 val_13 = UnityEngine.Vector2.one;
                mem[536884711] + 36.anchorMax = new UnityEngine.Vector2() {x = val_7, y = val_8};
                UnityEngine.Vector2 val_14 = UnityEngine.Vector2.zero;
                mem[536884711] + 36.anchoredPosition = new UnityEngine.Vector2() {x = val_7, y = val_8};
                SynchronizationContextBehavoir val_15 = mem[536884711] + 36.AddComponent<SynchronizationContextBehavoir>();
            }
            
            val_19 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_19 = 536884619;
            }
            
            mem[536884711] + 36.SetActive(value:  show);
        }
        public static bool IsSystemLoadingScreenShowing()
        {
            var val_3;
            var val_4;
            val_3 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_3 = 536884619;
            }
            
            if((mem[536884711] + 36) == 0)
            {
                    return false;
            }
            
            val_4 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_4 = 536884619;
            }
            
            UnityEngine.GameObject val_2 = mem[536884711] + 36.gameObject;
            if((mem[536884711] + 36) != 0)
            {
                    return mem[536884711] + 36.activeSelf;
            }
            
            return mem[536884711] + 36.activeSelf;
        }
        public static void DestroyAllUICanDestroy()
        {
            DG.Tweening.Tween val_11;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            536877651 = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Stack<AFramework.UI.BaseUIMenu>>>();
            val_17 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_17 = 536884619;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
            label_28:
            if(0.MoveNext() == false)
            {
                goto label_4;
            }
            
            536877767 = new System.Collections.Generic.List<Page>();
            label_21:
            if(1599295075 < 1)
            {
                goto label_6;
            }
            
            DG.Tweening.Tween val_6 = 65793.Pop();
            val_18 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_18 = 536884619;
            }
            
            if((mem[536884711] + 24 + 12) <= (1.522622E+19f))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_22 = mem[536884711] + 24 + 8;
            val_22 = val_22 + 2102213004;
            bool val_7 = (mem[536884711] + 24 + 8 + 2102213004) + 16.Contains(item:  65793);
            if(((mem[536884711] + 24 + 8 + 2102213004) + 16) == 0)
            {
                goto label_13;
            }
            
            UnityEngine.Debug.Log(message:  1953063282);
            536877767.Add(item:  65793);
            goto label_21;
            label_13:
            536877651.Add(item:  new System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Stack<AFramework.UI.BaseUIMenu>>() {Value = 1179403647});
            UnityEngine.GameObject val_8 = 65793.gameObject;
            UnityEngine.Object.Destroy(obj:  65793);
            goto label_21;
            label_6:
            List.Enumerator<T> val_9 = GetEnumerator();
            label_25:
            if(MoveNext() == false)
            {
                goto label_23;
            }
            
            65793.Push(item:  val_11);
            goto label_25;
            label_23:
            Dispose();
            if(1 == 0)
            {
                goto label_28;
            }
            
            var val_12 = 1 - 1;
            if((1152921510084763992 + ((1 - 1)) << 2) == 205)
            {
                    1 = val_12;
            }
            
            goto label_28;
            label_4:
            var val_13 = val_12 + 1;
            0.Dispose();
            if(val_13 != 0)
            {
                    var val_14 = val_13 - 1;
                if((1152921510084763992 + ((((1 - 1) + 1) - 1)) << 2) == 233)
            {
                    val_19 = val_14;
            }
            
            }
            else
            {
                    val_19 = 0;
            }
            
            List.Enumerator<T> val_15 = 0.GetEnumerator();
            label_41:
            if(0.MoveNext() == false)
            {
                goto label_35;
            }
            
            if((R5 + 12) > 0)
            {
                goto label_41;
            }
            
            val_20 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_20 = 536884619;
            }
            
            bool val_17 = mem[536884711] + 20.Remove(key:  R4);
            goto label_41;
            label_35:
            var val_18 = val_14 + 1;
            0.Dispose();
            if(val_18 == 0)
            {
                    return;
            }
            
            var val_19 = val_18 - 1;
        }
        public static AFramework.UI.BaseUIMenu[] GetAllOpenedUI()
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            536877767 = new System.Collections.Generic.List<Page>();
            val_2 = 0;
            goto label_1;
            label_14:
            val_3 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_3 = 536884619;
            }
            
            if((mem[536884711] + 24 + 12) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = mem[536884711] + 24 + 8;
            val_4 = 0;
            val_2 = val_2 + 0;
            goto label_6;
            label_10:
            if(val_2 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = (mem[536884711] + 24 + 8 + 0) + 16 + 8;
            val_3 = val_3 + 0;
            536877767.Add(item:  ((mem[536884711] + 24 + 8 + 0) + 16 + 8 + 0) + 16);
            val_4 = 1;
            label_6:
            if(val_4 < ((mem[536884711] + 24 + 8 + 0) + 16 + 12))
            {
                goto label_10;
            }
            
            val_2 = 1;
            label_1:
            val_5 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_5 = 536884619;
            }
            
            if(val_2 < (mem[536884711] + 24 + 12))
            {
                goto label_14;
            }
            
            if(536877767 != 0)
            {
                    return 536877767.ToArray();
            }
            
            return 536877767.ToArray();
        }
        public CanvasManager()
        {
            this.mLastBackeyTime = -1f;
        }
        private static CanvasManager()
        {
            536874325 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
            mem2[0] = 536874325;
            536877653 = new System.Collections.Generic.List<Page>();
            mem2[0] = 536877653;
            mem2[0] = 0;
        }
    
    }

}
