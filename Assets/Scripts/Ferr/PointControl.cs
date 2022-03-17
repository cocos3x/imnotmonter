using UnityEngine;

namespace Ferr
{
    [Serializable]
    public class PointControl
    {
        // Fields
        public float radius;
        public UnityEngine.Vector2 controlNext;
        public UnityEngine.Vector2 controlPrev;
        public Ferr.PointType type;
        
        // Methods
        public PointControl(Ferr.PointType aType, float aRadius, UnityEngine.Vector2 aControlPrev, UnityEngine.Vector2 aControlNext)
        {
            var val_1;
            this.radius = 1f;
            this.radius = aControlPrev.x;
            this.controlNext = aControlNext.y;
            mem[1152921510143181472] = val_1;
            this.controlPrev = aControlPrev.y;
            mem[1152921510143181480] = aControlNext.x;
            this.type = aType;
        }
        public PointControl(Ferr.PointControl aCopy)
        {
            this.radius = 1f;
            if(aCopy != 0)
            {
                    this.type = aCopy.type;
                this.radius = aCopy.radius;
            }
            else
            {
                    this.type = 52;
                this.radius = 0f;
            }
            
            this.controlNext = aCopy.controlNext;
            mem[1152921510143305760] = 0;
            this.controlPrev = aCopy.controlPrev;
            mem[1152921510143305768] = 0;
        }
        public override string ToString()
        {
            if(this.type == 4)
            {
                    Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
                this.type = mem[536891905];
                return;
            }
            
            Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
            this.type = mem[536891905];
            if(this.type == 5)
            {
                    string val_1 = this.radius.ToString();
                return System.String.Format(format:  -1610596999, arg0:  536891905, arg1:  this.radius);
            }
            
            string val_2 = this.controlPrev.ToString();
            string val_3 = this.controlNext.ToString();
            string val_4 = System.String.Format(format:  -1610596997, arg0:  536891905, arg1:  this.controlPrev, arg2:  this.controlNext);
        }
    
    }

}
