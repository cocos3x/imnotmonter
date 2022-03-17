using UnityEngine;

namespace TMPro.Examples
{
    public class CameraController : MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform cameraTransform;
        private UnityEngine.Transform dummyTarget;
        public UnityEngine.Transform CameraTarget;
        public float FollowDistance;
        public float MaxFollowDistance;
        public float MinFollowDistance;
        public float ElevationAngle;
        public float MaxElevationAngle;
        public float MinElevationAngle;
        public float OrbitalAngle;
        public TMPro.Examples.CameraController.CameraModes CameraMode;
        public bool MovementSmoothing;
        public bool RotationSmoothing;
        private bool previousSmoothing;
        public float MovementSmoothingValue;
        public float RotationSmoothingValue;
        public float MoveSensitivity;
        private UnityEngine.Vector3 currentVelocity;
        private UnityEngine.Vector3 desiredPosition;
        private float mouseX;
        private float mouseY;
        private UnityEngine.Vector3 moveVector;
        private float mouseWheel;
        private const string event_SmoothingValue = "Slider - Smoothing Value";
        private const string event_FollowDistance = "Slider - Camera Zoom";
        
        // Methods
        private void Awake()
        {
            int val_1 = UnityEngine.QualitySettings.vSyncCount;
            if(val_1 < 1)
            {
                    val_1 = 0;
            }
            
            if(val_1 >= 1)
            {
                    val_1 = 60;
            }
            
            UnityEngine.Application.targetFrameRate = 60;
            UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
            if(0 == 8)
            {
                goto label_0;
            }
            
            UnityEngine.RuntimePlatform val_3 = UnityEngine.Application.platform;
            if(0 != 11)
            {
                goto label_1;
            }
            
            label_0:
            UnityEngine.Input.simulateMouseWithTouches = false;
            label_1:
            UnityEngine.Transform val_4 = this.transform;
            this.cameraTransform = this;
            this.previousSmoothing = this.MovementSmoothing;
        }
        private void Start()
        {
            if(this.CameraTarget != 0)
            {
                    return;
            }
            
            536887303 = new UnityEngine.GameObject(name:  -1610609703);
            UnityEngine.Transform val_3 = 536887303.transform;
            this.dummyTarget = 536887303;
            this.CameraTarget = this.dummyTarget;
        }
        private void LateUpdate()
        {
            float val_3;
            float val_4;
            float val_5;
            float val_7;
            var val_22;
            var val_23;
            var val_24;
            UnityEngine.Transform val_25;
            float val_26;
            float val_27;
            this.GetPlayerInput();
            if(this.CameraTarget == 0)
            {
                    return;
            }
            
            if(this.CameraMode == 0)
            {
                goto label_4;
            }
            
            if(this.CameraMode != 1)
            {
                goto label_5;
            }
            
            UnityEngine.Vector3 val_2 = position;
            val_22 = val_3;
            val_23 = val_4;
            val_24 = val_5;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(x:  val_2.x, y:  val_2.y, z:  val_2.z);
            UnityEngine.Vector3 val_8 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 6.042173E-05f}, point:  new UnityEngine.Vector3() {x = val_7, y = 0f, z = 0f});
            goto label_7;
            label_4:
            UnityEngine.Vector3 val_9 = position;
            val_25 = this.CameraTarget;
            val_22 = val_3;
            val_23 = val_4;
            val_24 = val_5;
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.Euler(x:  val_9.x, y:  val_9.y, z:  val_9.z);
            UnityEngine.Vector3 val_11 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 6.042173E-05f}, point:  new UnityEngine.Vector3() {x = val_7, y = 0f, z = 0f});
            val_26 = val_4;
            UnityEngine.Vector3 val_12 = TransformDirection(direction:  new UnityEngine.Vector3() {x = val_25, y = val_3, z = val_26});
            label_7:
            UnityEngine.Vector3 val_22 = val_3;
            float val_23 = val_4;
            float val_24 = val_5;
            val_22 = val_22 + val_22;
            val_23 = val_23 + val_23;
            val_24 = val_24 + val_24;
            this.desiredPosition = val_22;
            mem[1152921509849570504] = val_23;
            mem[1152921509849570508] = val_24;
            label_5:
            if(this.MovementSmoothing != false)
            {
                    UnityEngine.Vector3 val_13 = position;
                val_27 = val_3;
                float val_14 = UnityEngine.Time.fixedDeltaTime;
                uint val_25 = 0;
                val_25 = this.MovementSmoothingValue * val_25;
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.SmoothDamp(current:  new UnityEngine.Vector3() {x = 6.042173E-05f, y = val_27, z = val_4}, target:  new UnityEngine.Vector3() {x = val_5, y = this.desiredPosition, z = val_25}, currentVelocity: ref  new UnityEngine.Vector3() {x = val_26, y = this.currentVelocity}, smoothTime:  val_25);
            }
            
            this.cameraTransform.position = new UnityEngine.Vector3() {x = mem[this.desiredPosition + (0)], y = mem[this.desiredPosition + (4)], z = mem[this.desiredPosition + (8)]};
            if(this.RotationSmoothing != false)
            {
                    UnityEngine.Quaternion val_16 = rotation;
                UnityEngine.Vector3 val_17 = position;
                UnityEngine.Vector3 val_18 = position;
                float val_26 = val_3;
                float val_27 = val_4;
                var val_28 = val_5;
                val_26 = val_3 - val_26;
                val_27 = val_4 - val_27;
                val_28 = val_5 - val_28;
                UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = 6.042173E-05f, y = val_26, z = val_27});
                float val_20 = UnityEngine.Time.deltaTime;
                uint val_29 = 0;
                val_29 = this.RotationSmoothingValue * val_29;
                UnityEngine.Quaternion val_21 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = 6.042173E-05f, y = val_3, z = val_4, w = val_5}, b:  new UnityEngine.Quaternion() {x = val_7, y = val_3}, t:  val_29);
                this.cameraTransform.rotation = new UnityEngine.Quaternion() {x = R4, y = R6, z = R7, w = val_7};
                return;
            }
            
            this.cameraTransform.LookAt(target:  this.CameraTarget);
        }
        private void GetPlayerInput()
        {
            var val_25 = this;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            float val_2 = UnityEngine.Input.GetAxis(axisName:  -1610606235);
            this.mouseWheel = -1.085042E-19f;
            int val_3 = UnityEngine.Input.touchCount;
            if((UnityEngine.Input.GetKey(key:  304)) != true)
            {
                    if(val_3 <= 0)
            {
                    if((UnityEngine.Input.GetKey(key:  303)) == false)
            {
                goto label_3;
            }
            
            }
            
            }
            
            float val_23 = 10f;
            val_23 = this.mouseWheel * val_23;
            this.mouseWheel = val_23;
            bool val_6 = UnityEngine.Input.GetKeyDown(key:  105);
            if(val_6 == true)
            {
                    val_6 = 1;
            }
            
            if(val_6 == true)
            {
                    this.CameraMode = val_6;
            }
            
            if((UnityEngine.Input.GetKeyDown(key:  102)) == true)
            {
                    this.CameraMode = 0;
            }
            
            bool val_8 = UnityEngine.Input.GetKeyDown(key:  115);
            if(val_8 == true)
            {
                    val_8 = this.MovementSmoothing;
                val_8 = val_8 ^ 1;
                this.MovementSmoothing = val_8;
            }
            
            bool val_9 = UnityEngine.Input.GetMouseButton(button:  1);
            if(val_9 != false)
            {
                    float val_10 = UnityEngine.Input.GetAxis(axisName:  -1610606231);
                this.mouseY = -1.085043E-19f;
                float val_11 = UnityEngine.Input.GetAxis(axisName:  -1610606233);
                this.mouseX = -1.085043E-19f;
                if((val_9 <= false) && (val_9 >= 0))
            {
                
            }
            else
            {
                    this.ElevationAngle = this.ElevationAngle;
                float val_12 = UnityEngine.Mathf.Clamp(value:  this.mouseY, min:  val_1.y, max:  this.ElevationAngle);
                this.ElevationAngle = this.ElevationAngle;
            }
            
                if(val_9 <= false)
            {
                    if(val_9 >= 0)
            {
                goto label_11;
            }
            
            }
            
                float val_25 = 360f;
                float val_24 = -360f;
                this.OrbitalAngle = this.OrbitalAngle;
                val_24 = this.OrbitalAngle + val_24;
                if(val_9 > false)
            {
                    this.OrbitalAngle = val_24;
                goto label_10;
            }
            
                if(val_9 < 0)
            {
                    label_10:
                val_25 = this.OrbitalAngle + val_25;
                if(val_9 < 0)
            {
                    this.OrbitalAngle = val_25;
            }
            
                this.OrbitalAngle = this.OrbitalAngle;
            }
            
            }
            
            label_11:
            if(val_3 != 1)
            {
                goto label_19;
            }
            
            UnityEngine.Touch val_13 = UnityEngine.Input.GetTouch(index:  947896720);
            float val_14 = val_13.m_Pressure - 152;
            if(val_14 != (1.401298E-45f))
            {
                goto label_19;
            }
            
            float val_15 = val_13.m_Radius + 32;
            float val_16 = val_13.m_Pressure - 152;
            float val_17 = val_13.m_Radius + 32;
            if(val_14 <= (1.401298E-45f))
            {
                    if(val_14 >= 0)
            {
                goto label_15;
            }
            
            }
            
            mem2[0] = val_13.m_RawPosition.y + 36;
            mem2[0] = val_13.m_RawPosition.y + 36;
            label_15:
            if(val_14 <= (1.401298E-45f))
            {
                    if(val_14 >= 0)
            {
                goto label_19;
            }
            
            }
            
            float val_27 = 360f;
            float val_26 = -360f;
            mem2[0] = val_13.m_RawPosition.y + 48;
            val_26 = (val_13.m_RawPosition.y + 48) + val_26;
            if(val_14 > (1.401298E-45f))
            {
                    val_13.m_RawPosition.y + 48 = val_26;
                goto label_18;
            }
            
            if(val_14 < 0)
            {
                    label_18:
                val_27 = (val_13.m_RawPosition.y + 48) + val_27;
                if(val_14 < 0)
            {
                    val_13.m_RawPosition.y + 48 = val_27;
            }
            
                mem2[0] = val_13.m_RawPosition.y + 48;
            }
            
            label_19:
            if(0 != 0)
            {
                    float val_18 = val_13.m_Radius + 32;
                float val_19 = val_13.m_Radius + 32;
                float val_20 = val_13.m_Radius + 32;
                mem2[0] = val_13.m_Radius + 52;
                mem2[0] = 1133903872;
                mem2[0] = mem[(val_13.m_Radius + 32) + (16)];
                mem2[0] = val_13.m_Pressure - 200;
                mem2[0] = 23552;
                mem2[0] = 0;
                if((mem[(val_13.m_Radius + 32) + (0)]) != 0)
            {
                    if((val_13.m_Pressure - 200) != 0f)
            {
                    mem2[0] = 0;
            }
            
            }
            
            }
        
        }
        public CameraController()
        {
            this.MaxElevationAngle = 85f;
            this.MovementSmoothing = true;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        }
    
    }

}
