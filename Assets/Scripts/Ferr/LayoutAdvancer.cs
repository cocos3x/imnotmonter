using UnityEngine;

namespace Ferr
{
    [Serializable]
    public class LayoutAdvancer
    {
        // Fields
        private UnityEngine.Vector2 mPos;
        private Ferr.LayoutAdvancer.Direction mDirection;
        private UnityEngine.Vector2 mPrevious;
        private UnityEngine.Vector2 mPrevPos;
        
        // Properties
        public float X { get; }
        public float Y { get; }
        public Ferr.LayoutAdvancer.Direction Dir { get; }
        
        // Methods
        public float get_X()
        {
            return (float)S0;
        }
        public float get_Y()
        {
            return (float)S0;
        }
        public Ferr.LayoutAdvancer.Direction get_Dir()
        {
        
        }
        public LayoutAdvancer(UnityEngine.Vector2 aStartLocation, Ferr.LayoutAdvancer.Direction aDirection)
        {
            this.mPos = aStartLocation;
            mem[1152921510128595516] = aStartLocation.y;
            this.mDirection = aDirection;
            this.mPrevPos = aStartLocation;
            mem[1152921510128595536] = aStartLocation.y;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.mPrevious = new UnityEngine.Vector2();
            mem[1152921510128595528] = ???;
        }
        public void Step(UnityEngine.Vector2 aSize)
        {
            UnityEngine.Vector2 val_1;
            UnityEngine.Vector2 val_2;
            var val_3;
            val_1 = this.mPos;
            this.mPrevPos = val_1;
            mem[1152921510128715728] = ;
            if(this.mDirection == 1)
            {
                goto label_0;
            }
            
            if(this.mDirection != 0)
            {
                goto label_1;
            }
            
            val_1 = S2;
            val_2 = 1152921510128715708;
            val_3 = aSize.y;
            goto label_2;
            label_0:
            val_2 = this.mPos;
            val_3 = aSize.x;
            label_2:
            val_1 = val_1 + val_3;
            mem2[0] = val_1;
            label_1:
            this.mPrevious = aSize;
            mem[1152921510128715720] = aSize.y;
        }
        public void Step(float aX, float aY)
        {
            UnityEngine.Vector2 val_2;
            float val_3;
            this.mPrevPos = this.mPos;
            mem[1152921510128835920] = ;
            if(this.mDirection == 0)
            {
                goto label_0;
            }
            
            if(this.mDirection != 1)
            {
                goto label_1;
            }
            
            val_2 = this.mPos;
            val_3 = this.mPos + R1;
            goto label_2;
            label_0:
            val_3 = S6 + R2;
            val_2 = 1152921510128835900;
            label_2:
            mem[1152921510128835900] = val_3;
            label_1:
            this.mPrevious = R1;
            mem[1152921510128835912] = R2;
        }
        public UnityEngine.Rect GetRect()
        {
            val_1 = new UnityEngine.Rect(x:  R1 + 24, y:  null, width:  null, height:  null);
            return new UnityEngine.Rect() {m_XMin = R1 + 24};
        }
        public UnityEngine.Rect GetRect(float aOverrideDir)
        {
            float val_2 = R2;
            if((R1 + 16) != 0)
            {
                    val_2 = mem[R1 + 24];
                val_2 = R1 + 24;
            }
            
            val_1 = new UnityEngine.Rect(x:  val_2 = R2, y:  null, width:  R1 + 32, height:  null);
            return new UnityEngine.Rect() {m_XMin = val_2, m_Width = R1 + 32};
        }
        public UnityEngine.Rect GetRect(float aOverrideWidth, float aOverrideHeight)
        {
            val_1 = new UnityEngine.Rect(x:  aOverrideWidth, y:  aOverrideHeight, width:  null, height:  null);
            return new UnityEngine.Rect() {m_XMin = aOverrideWidth, m_YMin = aOverrideHeight};
        }
        public UnityEngine.Rect GetRectPad(float aPaddingX, float aPaddingY)
        {
            var val_5 = R2;
            float val_1 = val_5 + val_5;
            val_5 = (R1 + 28) + val_5;
            float val_2 = (R1 + 32) + R3;
            val_1 = (R1 + 20) - val_1;
            float val_3 = R3 + R3;
            val_3 = (R1 + 24) - val_3;
            val_4 = new UnityEngine.Rect(x:  val_3, y:  aPaddingY, width:  val_1, height:  null);
            return new UnityEngine.Rect() {m_XMin = val_3, m_YMin = aPaddingY, m_Width = val_1};
        }
        public UnityEngine.Rect GetRectPad(float aPadding)
        {
            var val_5 = R2;
            var val_4 = R1 + 28;
            var val_6 = R1 + 20;
            float val_1 = val_5 + val_5;
            val_4 = val_4 + val_5;
            val_5 = (R1 + 32) + val_5;
            UnityEngine.Rect val_3;
            val_6 = val_6 - val_1;
            float val_2 = (R1 + 24) - val_1;
            val_3 = new UnityEngine.Rect(x:  val_2, y:  null, width:  val_1, height:  null);
            return new UnityEngine.Rect() {m_XMin = val_2, m_Width = val_1};
        }
    
    }

}
