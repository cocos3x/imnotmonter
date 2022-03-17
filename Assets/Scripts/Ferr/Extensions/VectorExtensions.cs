using UnityEngine;

namespace Ferr.Extensions
{
    public static class VectorExtensions
    {
        // Methods
        public static UnityEngine.Vector2 xz(UnityEngine.Vector3 aVec)
        {
            return new UnityEngine.Vector2();
        }
        public static UnityEngine.Vector2 xy(UnityEngine.Vector3 aVec)
        {
            return new UnityEngine.Vector2();
        }
        public static UnityEngine.Vector2 yz(UnityEngine.Vector3 aVec)
        {
            return new UnityEngine.Vector2();
        }
        public static UnityEngine.Vector3 x0y(UnityEngine.Vector2 aVec)
        {
            mem2[0] = ???;
            return new UnityEngine.Vector3();
        }
        public static UnityEngine.Vector3 xy0(UnityEngine.Vector2 aVec)
        {
            return new UnityEngine.Vector3();
        }
        public static UnityEngine.Vector3 xty(UnityEngine.Vector2 aVec, float t)
        {
            mem2[0] = ???;
            return new UnityEngine.Vector3() {x = t};
        }
        public static UnityEngine.Vector3 xyt(UnityEngine.Vector2 aVec, float t)
        {
            return new UnityEngine.Vector3() {x = t};
        }
        public static UnityEngine.Vector3 xxx(UnityEngine.Vector3 aVec)
        {
            mem2[0] = aVec.y;
            mem2[0] = aVec.y;
            mem2[0] = aVec.y;
            return new UnityEngine.Vector3();
        }
        public static UnityEngine.Vector3 yyy(UnityEngine.Vector3 aVec)
        {
            mem2[0] = aVec.z;
            mem2[0] = aVec.z;
            mem2[0] = aVec.z;
            return new UnityEngine.Vector3();
        }
        public static UnityEngine.Vector3 zzz(UnityEngine.Vector3 aVec)
        {
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            return new UnityEngine.Vector3();
        }
        public static UnityEngine.Vector3 WithX(UnityEngine.Vector3 aVec, float aX)
        {
            float val_1;
            mem2[0] = val_1;
            return new UnityEngine.Vector3() {x = val_1};
        }
        public static UnityEngine.Vector3 WithY(UnityEngine.Vector3 aVec, float aY)
        {
            float val_1;
            mem2[0] = aVec.y;
            mem2[0] = ???;
            mem2[0] = val_1;
            return new UnityEngine.Vector3() {x = val_1};
        }
        public static UnityEngine.Vector3 WithZ(UnityEngine.Vector3 aVec, float aZ)
        {
            float val_1;
            mem2[0] = val_1;
            return new UnityEngine.Vector3() {x = val_1};
        }
        public static void SetX(UnityEngine.Vector3 aVec, float aX)
        {
        
        }
        public static void SetY(UnityEngine.Vector3 aVec, float aY)
        {
        
        }
        public static void SetZ(UnityEngine.Vector3 aVec, float aZ)
        {
        
        }
        public static UnityEngine.Vector2 Rot90CW(UnityEngine.Vector2 aVec)
        {
            aVec.y = aVec.y ^ 2147483648;
            mem2[0] = ???;
            mem2[0] = aVec.y;
            return new UnityEngine.Vector2();
        }
        public static UnityEngine.Vector2 Rot90CCW(UnityEngine.Vector2 aVec)
        {
            mem2[0] = R2 ^ 2147483648;
            mem2[0] = aVec.y;
            return new UnityEngine.Vector2();
        }
    
    }

}
