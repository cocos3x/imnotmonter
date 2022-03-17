using UnityEngine;

namespace Ferr
{
    public class LogoLock : MonoBehaviour
    {
        // Fields
        private UnityEngine.Camera mCamera;
        private Ferr.LogoLock.LockPosition mLockHorizontal;
        private Ferr.LogoLock.LockPosition mLockVertical;
        private float mPadding;
        private float mScale;
        
        // Methods
        private void Awake()
        {
            float val_13;
            float val_14;
            float val_15;
            float val_16;
            if(this.mCamera == 0)
            {
                    UnityEngine.Camera val_2 = UnityEngine.Camera.main;
                this.mCamera = 0;
            }
            
            UnityEngine.Transform val_3 = this.mCamera.transform;
            UnityEngine.Transform val_4 = this.mCamera.transform;
            this.parent = this.mCamera;
            UnityEngine.Transform val_5 = this.mCamera.transform;
            UnityEngine.Vector3 val_6 = Ferr.LogoLock.GetLockPosition(aCam:  1227697952, aHLock:  mem[this.mCamera + (0)], aVLock:  mem[this.mCamera + (4)], aPadding:  this.mPadding);
            this.localPosition = new UnityEngine.Vector3() {x = R6, y = R7, z = R8};
            UnityEngine.Transform val_7 = this.mCamera.GetComponent<UnityEngine.Transform>();
            UnityEngine.Sprite val_8 = this.sprite;
            float val_9 = Ferr.LogoLock.GetPixelScale(aCam:  this.mCamera, aSprite:  1227710000);
            UnityEngine.Transform val_10 = this.mCamera.transform;
            float val_17 = this.mScale;
            val_17 = this.mCamera * val_17;
            this.localScale = new UnityEngine.Vector3() {x = val_17, y = val_17, z = val_17};
            UnityEngine.Transform val_11 = val_17.transform;
            UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.identity;
            this.localRotation = new UnityEngine.Quaternion() {x = val_13, y = val_14, z = val_15, w = val_16};
        }
        private static float GetPixelScale(UnityEngine.Camera aCam, UnityEngine.Sprite aSprite)
        {
            float val_2;
            UnityEngine.Vector2 val_1 = Ferr.LogoLock.GetViewSizeAtDistance(aDist:  null, aCamera:  1227830392);
            UnityEngine.Rect val_3 = textureRect;
            float val_4 = width;
            UnityEngine.Bounds val_7 = bounds;
            mem2[0] = val_2;
            UnityEngine.Vector3 val_8 = extents;
            var val_10 = val_2;
            val_10 = val_10 + val_10;
            val_10 = (val_2 * (1227830440 / (float)UnityEngine.Screen.width)) / val_10;
            return (float)val_10;
        }
        private static UnityEngine.Vector3 GetLockPosition(UnityEngine.Camera aCam, Ferr.LogoLock.LockPosition aHLock, Ferr.LogoLock.LockPosition aVLock, float aPadding)
        {
            var val_2;
            var val_3;
            float val_6;
            float val_7;
            float val_8;
            float val_9;
            float val_10;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_7 = val_2;
            val_8 = val_3;
            UnityEngine.Vector2 val_4 = Ferr.LogoLock.GetViewSizeAtDistance(aDist:  val_1.x, aCamera:  1227962912);
            float val_7 = 1f;
            val_7 = val_7 / (float)UnityEngine.Screen.width;
            val_7 = val_2 * val_7;
            val_9 = val_6;
            val_10 = val_7 * val_9;
            if(aVLock == 2)
            {
                goto label_0;
            }
            
            if(aVLock == 1)
            {
                goto label_1;
            }
            
            if(aVLock != 0)
            {
                goto label_4;
            }
            
            val_9 = -0.5f;
            goto label_4;
            label_0:
            val_9 = 0.5f;
            goto label_4;
            label_1:
            val_7 = 0f;
            label_4:
            if(R3 == 2)
            {
                goto label_5;
            }
            
            if(R3 == 1)
            {
                goto label_6;
            }
            
            if(R3 != 0)
            {
                goto label_9;
            }
            
            val_9 = 0.5f;
            goto label_8;
            label_5:
            val_9 = -0.5f;
            label_8:
            val_8 = val_10;
            goto label_9;
            label_6:
            val_8 = 0f;
            label_9:
            mem2[0] = val_7;
            mem2[0] = val_8;
            mem2[0] = 1065353216;
            return new UnityEngine.Vector3() {x = val_10, y = val_4.y, z = val_9};
        }
        private static UnityEngine.Vector2 GetViewSizeAtDistance(float aDist, UnityEngine.Camera aCamera)
        {
            UnityEngine.Object val_13;
            var val_14;
            var val_15;
            var val_16;
            float val_17;
            float val_18;
            val_13 = R2;
            val_14 = R1;
            val_15 = 22999904;
            if(val_13 == 0)
            {
                    UnityEngine.Camera val_2 = UnityEngine.Camera.main;
                val_13 = 0;
            }
            
            if(val_13.orthographic == false)
            {
                goto label_5;
            }
            
            val_14 = UnityEngine.Screen.width;
            val_15 = UnityEngine.Screen.height;
            if(val_13 == 0)
            {
                goto label_6;
            }
            
            float val_6 = val_13.orthographicSize;
            val_16 = 0;
            goto label_7;
            label_5:
            float val_7 = val_13.fieldOfView;
            float val_12 = 0.5f;
            val_12 = 0 * val_12;
            val_12 = val_12 * 0.01745329f;
            val_17 = (val_14 + val_14) * val_12;
            float val_9 = val_13.aspect;
            val_18 = val_17 * 0;
            goto label_10;
            label_6:
            float val_10 = 0.orthographicSize;
            val_16 = 0;
            label_7:
            float val_11 = val_13.orthographicSize;
            float val_13 = (float)val_15;
            val_13 = (float)val_14 / val_13;
            val_13 = val_13 * val_16;
            val_17 = 0 + 0;
            val_18 = val_13 + val_13;
            label_10:
            mem2[0] = val_18;
            mem2[0] = val_17;
            return new UnityEngine.Vector2() {x = val_18};
        }
        public LogoLock()
        {
            this.mScale = 1f;
        }
    
    }

}
