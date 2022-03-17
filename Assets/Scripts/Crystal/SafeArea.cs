using UnityEngine;

namespace Crystal
{
    public class SafeArea : MonoBehaviour
    {
        // Fields
        public static Crystal.SafeArea.SimDevice Sim;
        private UnityEngine.Rect[] NSA_iPhoneX;
        private UnityEngine.Rect[] NSA_iPhoneXsMax;
        private UnityEngine.Rect[] NSA_Pixel3XL_LSL;
        private UnityEngine.Rect[] NSA_Pixel3XL_LSR;
        private UnityEngine.RectTransform Panel;
        private UnityEngine.Rect LastSafeArea;
        private UnityEngine.Vector2Int LastScreenSize;
        private UnityEngine.ScreenOrientation LastOrientation;
        private bool ConformX;
        private bool ConformY;
        private bool Logging;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            this.Panel = this;
            if(this.Panel == 0)
            {
                    string val_3 = this.name;
                string val_4 = -1610609603(-1610609603) + 1429526672;
                UnityEngine.Debug.LogError(message:  -1610609603);
                UnityEngine.GameObject val_5 = this.gameObject;
                UnityEngine.Object.Destroy(obj:  1429526672);
            }
            
            this.Refresh();
        }
        private void Update()
        {
            this.Refresh();
        }
        private void Refresh()
        {
            float val_2;
            float val_3;
            float val_4;
            float val_5;
            UnityEngine.Rect val_1 = GetSafeArea();
            if(((UnityEngine.Rect.op_Inequality(lhs:  new UnityEngine.Rect() {m_XMin = val_2, m_YMin = val_3, m_Width = val_4, m_Height = val_5}, rhs:  new UnityEngine.Rect() {m_XMin = mem[this.LastSafeArea + (0)], m_YMin = mem[this.LastSafeArea + (4)], m_Width = mem[this.LastSafeArea + (8)], m_Height = mem[this.LastSafeArea + (12)]})) != true) && (UnityEngine.Screen.width == this.LastScreenSize))
            {
                    if(UnityEngine.Screen.height == this.LastScreenSize)
            {
                    UnityEngine.ScreenOrientation val_9 = UnityEngine.Screen.orientation;
                if(0 == this.LastOrientation)
            {
                    return;
            }
            
            }
            
            }
            
            this.LastScreenSize = UnityEngine.Screen.width;
            mem[1152921510331573188] = UnityEngine.Screen.height;
            UnityEngine.ScreenOrientation val_12 = UnityEngine.Screen.orientation;
            this.LastOrientation = 0;
            this.ApplySafeArea(r:  new UnityEngine.Rect() {m_XMin = val_2, m_YMin = val_3, m_Width = val_4, m_Height = val_5});
        }
        private UnityEngine.Rect GetSafeArea()
        {
            var val_26;
            float val_27;
            float val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            val_26 = R1;
            UnityEngine.Rect val_1 = UnityEngine.Screen.safeArea;
            if(UnityEngine.Application.isEditor == false)
            {
                    return new UnityEngine.Rect() {m_XMin = val_27, m_YMin = val_1.m_YMin, m_Width = val_28, m_Height = val_1.m_Height};
            }
            
            val_29 = 536893231;
            if(((mem[536893418] & true) == 0) && (mem[536893347] == 0))
            {
                    val_29 = 536893231;
            }
            
            if(mem[536893323] == 0)
            {
                    return new UnityEngine.Rect() {m_XMin = val_27, m_YMin = val_1.m_YMin, m_Width = val_28, m_Height = val_1.m_Height};
            }
            
            int val_3 = UnityEngine.Screen.width;
            UnityEngine.Rect val_5 = new UnityEngine.Rect(x:  (float)UnityEngine.Screen.height, y:  val_1.m_YMin, width:  val_1.m_Width, height:  val_1.m_Height);
            val_30 = 536893231;
            if(((mem[536893418] & true) == 0) && (mem[536893347] == 0))
            {
                    val_30 = 536893231;
            }
            
            var val_26 = mem[536893323];
            val_26 = val_26 - 1;
            if(val_26 <= 3)
            {
                    var val_6 = 8469404 + (8469404 + ((mem[536893323] - 1)) << 2);
                if(val_26 == 3)
            {
                    8469404 + ((mem[536893323] - 1)) << 2 = (8469404 + ((mem[536893323] - 1)) << 2) & ((8469404 + ((mem[536893323] - 1)) << 2) << (8469404 + ((mem[536893323] - 1)) << 2));
                8469404 + ((mem[536893323] - 1)) << 2 = (8469404 + ((mem[536893323] - 1)) << 2) & ((8469404 + ((mem[536893323] - 1)) << 2) >> (8469404 + ((mem[536893323] - 1)) << 2));
                8469404 + ((mem[536893323] - 1)) << 2 = (8469404 + ((mem[536893323] - 1)) << 2) & ((8469404 + ((mem[536893323] - 1)) << 2) >> (8469404 + ((mem[536893323] - 1)) << 2));
                8469404 + ((mem[536893323] - 1)) << 2 = (8469404 + ((mem[536893323] - 1)) << 2) & ((((((8469404 + ((mem[536893323] - 1)) << 2 & (8469404 + ((mem[536893323] - 1)) << 2) << 8469404 + ((mem[536893323] - 1)) << 2) & ((8469404 + ((mem[536893323] - 1)) << 2 & (8469404 + ((mem[536893323] - 1) << (32-(((8469404 + ((mem[536893323] - 1)) << 2 & (8469404 + ((mem[536893323] - 1)) << 2) << 8469404 + ((mem[536893323] - 1)) << 2) & ((8469404 + ((mem[536893323] - 1)) << 2 & (8469404 + ((mem[536893323] - 1)) | (((((8469404 + ((mem[536893323] - 1)) << 2 & (8469404 + ((mem[536893323] - 1)) << 2) << 8469404 + ((mem[536893323] - 1)) << 2) & ((8469404 + ((mem[536893323] - 1)) << 2 & (8469404 + ((mem[536893323] - 1) << (((8469404 + ((mem[536893323] - 1)) << 2 & (8469404 + ((mem[536893323] - 1)) << 2) << 8469404 + ((mem[536893323] - 1)) << 2) & ((8469404 + ((mem[536893323] - 1)) << 2 & (8469404 + ((mem[536893323] - 1));
            }
            
                val_31 = UnityEngine.Screen.height;
                val_32 = mem[R1 + 12];
                val_32 = R1 + 12;
                val_33 = UnityEngine.Screen.width;
                if( > )
            {
                    var val_15 =  + 16;
            }
            else
            {
                    var val_16 =  + 32;
            }
            
            }
            
            float val_18 = val_5.m_XMin.x;
            float val_20 = val_5.m_XMin.y;
            float val_22 = val_5.m_XMin.width;
            val_26 = UnityEngine.Screen.height;
            float val_24 = val_5.m_XMin.height;
            float val_27 = (float)UnityEngine.Screen.width;
            float val_28 = (float)UnityEngine.Screen.height;
            float val_29 = (float)UnityEngine.Screen.width;
            val_27 = 1429862888 * val_27;
            val_28 = 1429862888 * val_28;
            val_29 = 1429862888 * val_29;
            val_28 = 1429862888;
            val_27 = val_28 * (float)val_26;
            UnityEngine.Rect val_25 = new UnityEngine.Rect(x:  val_27, y:  val_1.m_YMin, width:  val_28, height:  val_1.m_Height);
            return new UnityEngine.Rect() {m_XMin = val_27, m_YMin = val_1.m_YMin, m_Width = val_28, m_Height = val_1.m_Height};
        }
        private void ApplySafeArea(UnityEngine.Rect r)
        {
            var val_6;
            float val_7;
            float val_26;
            float val_27;
            float val_28;
            float val_29;
            val_26 = r.m_Height;
            val_27 = 22975281;
            val_28 = r.m_YMin;
            val_29 = r.m_XMin;
            this.LastSafeArea = r;
            mem[1152921510331809460] = val_28;
            mem[1152921510331809464] = r.m_Width;
            mem[1152921510331809468] = val_26;
            if(this.ConformX != true)
            {
                    r.m_XMin.x = null;
                r.m_XMin.width = (float)UnityEngine.Screen.width;
            }
            
            if(this.ConformY != true)
            {
                    r.m_XMin.y = (float)UnityEngine.Screen.width;
                r.m_XMin.height = (float)UnityEngine.Screen.height;
            }
            
            if(UnityEngine.Screen.width >= 1)
            {
                    int val_4 = UnityEngine.Screen.height;
                if(val_4 >= 1)
            {
                    UnityEngine.Vector2 val_5 = position;
                UnityEngine.Vector2 val_8 = position;
                float val_26 = val_7;
                UnityEngine.Vector2 val_9 = size;
                if(((val_4 >= 1) && (val_4 >= 1)) && (val_4 >= 1))
            {
                    val_26 = (val_26 + val_7) / (float)UnityEngine.Screen.height;
                if(val_4 >= 1)
            {
                    val_29 = val_6 / (float)UnityEngine.Screen.width;
                val_28 = this.Panel;
                val_26 = (val_6 + val_6) / (float)UnityEngine.Screen.width;
                val_27 = val_26;
                val_28.anchorMin = new UnityEngine.Vector2() {x = val_29, y = val_7 / (float)UnityEngine.Screen.height};
                this.Panel.anchorMax = new UnityEngine.Vector2() {x = val_26, y = val_27};
            }
            
            }
            
            }
            
            }
            
            if(this.Logging == false)
            {
                    return;
            }
            
            string val_19 = this.name;
            mem[536882227] = this;
            float val_20 = r.m_XMin.x;
            val_6 = r.m_XMin;
            mem[536882231] = 536893745;
            float val_21 = r.m_XMin.y;
            mem[536882235] = 536893745;
            float val_22 = r.m_XMin.width;
            mem[536882239] = 536893745;
            float val_23 = r.m_XMin.height;
            mem[536882243] = 536893745;
            int val_24 = UnityEngine.Screen.width;
            val_28 = 22712448;
            mem[536882247] = 536888987;
            int val_25 = UnityEngine.Screen.height;
            mem[536882251] = 536888987;
            UnityEngine.Debug.LogFormat(format:  -1610606111, args:  536882211);
        }
        public SafeArea()
        {
            UnityEngine.Rect val_1 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            var val_2 = 536882297 + 16;
            UnityEngine.Rect val_3 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            var val_4 = 536882297 + 32;
            this.NSA_iPhoneX = 536882297;
            UnityEngine.Rect val_5 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            var val_6 = 536882297 + 16;
            UnityEngine.Rect val_7 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            var val_8 = 536882297 + 32;
            this.NSA_iPhoneXsMax = 536882297;
            UnityEngine.Rect val_9 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            var val_10 = 536882297 + 16;
            UnityEngine.Rect val_11 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            var val_12 = 536882297 + 32;
            this.NSA_Pixel3XL_LSL = 536882297;
            UnityEngine.Rect val_13 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            var val_14 = 536882297 + 16;
            UnityEngine.Rect val_15 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            var val_16 = 536882297 + 32;
            this.NSA_Pixel3XL_LSR = 536882297;
            UnityEngine.Rect val_17 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            this.LastScreenSize = 0;
            mem[1152921510331929668] = 0;
            this.LastOrientation = 5;
            this.ConformX = true;
            this.ConformY = true;
        }
        private static SafeArea()
        {
        
        }
    
    }

}
