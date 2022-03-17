using UnityEngine;

namespace Ferr
{
    public static class GizmoUtil
    {
        // Methods
        public static void DrawWireCircle(UnityEngine.Vector3 aPos, float aRadius)
        {
            Ferr.GizmoUtil.DrawWireArc(aPos:  new UnityEngine.Vector3() {x = aPos.x, y = aPos.y, z = aPos.z}, aRadius:  aRadius, aAngle:  null, aAngleWidth:  null);
        }
        public static void DrawWireArc(UnityEngine.Vector3 aPos, float aRadius, float aAngle, float aAngleWidth)
        {
            var val_1;
            var val_4;
            float val_6 = 360f;
            float val_7 = 6.283185f;
            val_6 = val_1 / val_6;
            val_7 = R3 * val_7;
            val_6 = val_7 * val_6;
            val_6 = val_6 / 0.4f;
            var val_8 = (int)val_6;
            if(val_8 < 1)
            {
                    return;
            }
            
            float val_5 = val_4 * 0.01745329f;
            do
            {
                val_5 = ((val_1 * 0.01745329f) / (float)(int)val_6) + val_5;
                UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = aPos.x, y = aPos.y, z = aPos.z}, to:  new UnityEngine.Vector3() {x = aPos.x, y = aPos.y, z = aPos.z});
                val_8 = val_8 - 1;
            }
            while(val_8 != 1);
        
        }
    
    }

}
