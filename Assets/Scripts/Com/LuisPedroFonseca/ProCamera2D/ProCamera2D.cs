using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2D : MonoBehaviour, ISerializationCallbackReceiver
    {
        // Fields
        public const string Title = "Pro Camera 2D";
        public static readonly System.Version Version;
        public System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.CameraTarget> CameraTargets;
        public bool CenterTargetOnStart;
        public Com.LuisPedroFonseca.ProCamera2D.MovementAxis Axis;
        public Com.LuisPedroFonseca.ProCamera2D.UpdateType UpdateType;
        public bool FollowHorizontal;
        public float HorizontalFollowSmoothness;
        public bool FollowVertical;
        public float VerticalFollowSmoothness;
        public float OffsetX;
        public float OffsetY;
        public bool IsRelativeOffset;
        public bool ZoomWithFOV;
        public bool IgnoreTimeScale;
        private static Com.LuisPedroFonseca.ProCamera2D.ProCamera2D _instance;
        private float _cameraTargetHorizontalPositionSmoothed;
        private float _cameraTargetVerticalPositionSmoothed;
        private UnityEngine.Vector2 <StartScreenSizeInWorldCoordinates>k__BackingField;
        private UnityEngine.Vector2 <ScreenSizeInWorldCoordinates>k__BackingField;
        private UnityEngine.Vector3 <PreviousTargetsMidPoint>k__BackingField;
        private UnityEngine.Vector3 <TargetsMidPoint>k__BackingField;
        private UnityEngine.Vector3 <CameraTargetPosition>k__BackingField;
        private float <DeltaTime>k__BackingField;
        private UnityEngine.Vector3 <ParentPosition>k__BackingField;
        private UnityEngine.Vector3 _influencesSum;
        public System.Action<float> PreMoveUpdate;
        public System.Action<float> PostMoveUpdate;
        public System.Action<UnityEngine.Vector2> OnCameraResize;
        public System.Action<float> OnUpdateScreenSizeFinished;
        public System.Action<float> OnDollyZoomFinished;
        public System.Action OnReset;
        public System.Nullable<UnityEngine.Vector3> ExclusiveTargetPosition;
        public int CurrentZoomTriggerID;
        public bool IsCameraPositionLeftBounded;
        public bool IsCameraPositionRightBounded;
        public bool IsCameraPositionTopBounded;
        public bool IsCameraPositionBottomBounded;
        public UnityEngine.Camera GameCamera;
        private System.Func<UnityEngine.Vector3, float> Vector3H;
        private System.Func<UnityEngine.Vector3, float> Vector3V;
        private System.Func<UnityEngine.Vector3, float> Vector3D;
        private System.Func<float, float, UnityEngine.Vector3> VectorHV;
        private System.Func<float, float, float, UnityEngine.Vector3> VectorHVD;
        private UnityEngine.Coroutine _updateScreenSizeCoroutine;
        private UnityEngine.Coroutine _dollyZoomRoutine;
        private System.Collections.Generic.List<UnityEngine.Vector3> _influences;
        private float _originalCameraDepthSign;
        private float _previousCameraTargetHorizontalPositionSmoothed;
        private float _previousCameraTargetVerticalPositionSmoothed;
        private int _previousScreenWidth;
        private int _previousScreenHeight;
        private UnityEngine.Vector3 _previousCameraPosition;
        private UnityEngine.WaitForFixedUpdate _waitForFixedUpdate;
        private UnityEngine.Transform _transform;
        private System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.IPreMover> _preMovers;
        private System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.IPositionDeltaChanger> _positionDeltaChangers;
        private System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.IPositionOverrider> _positionOverriders;
        private System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.ISizeDeltaChanger> _sizeDeltaChangers;
        private System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.ISizeOverrider> _sizeOverriders;
        private System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.IPostMover> _postMovers;
        
        // Properties
        public static Com.LuisPedroFonseca.ProCamera2D.ProCamera2D Instance { get; }
        public static bool Exists { get; }
        public bool IsMoving { get; }
        public UnityEngine.Rect Rect { get; set; }
        public UnityEngine.Vector2 CameraTargetPositionSmoothed { get; set; }
        public UnityEngine.Vector3 LocalPosition { get; set; }
        public UnityEngine.Vector2 StartScreenSizeInWorldCoordinates { get; set; }
        public UnityEngine.Vector2 ScreenSizeInWorldCoordinates { get; set; }
        public UnityEngine.Vector3 PreviousTargetsMidPoint { get; set; }
        public UnityEngine.Vector3 TargetsMidPoint { get; set; }
        public UnityEngine.Vector3 CameraTargetPosition { get; set; }
        public float DeltaTime { get; set; }
        public UnityEngine.Vector3 ParentPosition { get; set; }
        public UnityEngine.Vector3 InfluencesSum { get; }
        
        // Methods
        public static Com.LuisPedroFonseca.ProCamera2D.ProCamera2D get_Instance()
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = 536892083;
            if(((mem[536892270] & true) == 0) && (mem[536892199] == 0))
            {
                    val_6 = 536892083;
            }
            
            if((System.Object.Equals(objA:  mem[536892175] + 4, objB:  0)) == false)
            {
                goto label_3;
            }
            
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073762995)});
            val_7 = 0;
            UnityEngine.Object val_3 = UnityEngine.Object.FindObjectOfType(type:  1073762995);
            val_8 = 536892083;
            if(((mem[536892270] & true) == 0) && (mem[536892199] == 0))
            {
                    val_8 = 536892083;
            }
            
            if((1073762995 != 0) && ((mem[1073762995] + 180) >= mem[536892263]))
            {
                    var val_6 = mem[1073762995] + 100;
                val_6 = val_6 + (mem[536892263] << 2);
                if(((mem[1073762995] + 100 + (mem[536892263]) << 2) + -4) != val_8)
            {
                    1073762995 = 0;
            }
            
                val_7 = 1073762995;
            }
            
            mem2[0] = val_7;
            if((System.Object.Equals(objA:  mem[536892175] + 4, objB:  0)) == true)
            {
                goto label_12;
            }
            
            label_3:
            val_9 = 536892083;
            if((mem[536892270] & true) != 0)
            {
                    return;
            }
            
            if(mem[536892199] != 0)
            {
                    return;
            }
            
            val_9 = 536892083;
            return;
            label_12:
            22716300 = new UnityEngine.UnityException(message:  22791876);
        }
        public static bool get_Exists()
        {
            if(((mem[536892270] & true) == 0) && (mem[536892199] == 0))
            {
                    536892083 = 536892083;
            }
            
            if((mem[536891408] & true) != 0)
            {
                    return UnityEngine.Object.op_Inequality(x:  mem[536892175] + 4, y:  0);
            }
            
            if(mem[536891337] != 0)
            {
                    return UnityEngine.Object.op_Inequality(x:  mem[536892175] + 4, y:  0);
            }
            
            return UnityEngine.Object.op_Inequality(x:  mem[536892175] + 4, y:  0);
        }
        public bool get_IsMoving()
        {
            UnityEngine.Vector3 val_7;
            var val_10;
            UnityEngine.Vector3 val_1 = localPosition;
            float val_2 = this.Vector3H.Invoke(arg:  new UnityEngine.Vector3() {x = R6, y = R7, z = R8});
            float val_3 = this.Vector3H.Invoke(arg:  new UnityEngine.Vector3() {x = mem[this._previousCameraPosition + (0)], y = mem[this._previousCameraPosition + (4)], z = mem[this._previousCameraPosition + (8)]});
            if(this.Vector3H == 0)
            {
                    UnityEngine.Vector3 val_4 = localPosition;
                float val_5 = this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = R6, y = R7, z = R8});
                val_7 = this._previousCameraPosition;
                float val_6 = this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = val_7, y = R7, z = 1.694727f});
                if(this.Vector3V != 0)
            {
                    val_10 = 1;
            }
            
                return (bool)val_10;
            }
            
            val_10 = 1;
            return (bool)val_10;
        }
        public UnityEngine.Rect get_Rect()
        {
            UnityEngine.Rect val_1 = rect;
            return new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_1.m_YMin, m_Width = val_1.m_Width, m_Height = val_1.m_Height};
        }
        public void set_Rect(UnityEngine.Rect value)
        {
            var val_3;
            this.GameCamera.rect = new UnityEngine.Rect() {m_XMin = value.m_XMin, m_YMin = value.m_YMin, m_Width = value.m_Width, m_Height = value.m_Height};
            UnityEngine.UI.Toggle val_1 = this.GameCamera.GetComponentInChildren<UnityEngine.UI.Toggle>();
            if(1071433680 == 0)
            {
                    return;
            }
            
            val_3 = 0;
            goto label_5;
            label_12:
            if((this.OffsetX + 12) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = this.OffsetX + 8;
            val_3 = val_3 + 0;
            (this.OffsetX + 8 + 0) + 16 + 8.rect = new UnityEngine.Rect() {m_XMin = value.m_XMin, m_YMin = value.m_YMin, m_Width = value.m_Width, m_Height = value.m_Height};
            val_3 = 1;
            label_5:
            if(val_3 < (this.OffsetX + 12))
            {
                goto label_12;
            }
        
        }
        public UnityEngine.Vector2 get_CameraTargetPositionSmoothed()
        {
            this = R1 + 56;
            mem[1152921509973364052] = R1 + 60;
            return new UnityEngine.Vector2();
        }
        public void set_CameraTargetPositionSmoothed(UnityEngine.Vector2 value)
        {
            this._cameraTargetHorizontalPositionSmoothed = value.x;
            this._cameraTargetVerticalPositionSmoothed = value.y;
        }
        public UnityEngine.Vector3 get_LocalPosition()
        {
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2;
            var val_3;
            UnityEngine.Vector3 val_1 = localPosition;
            mem[1152921509973588056] = val_3;
            this = val_2;
            return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        public void set_LocalPosition(UnityEngine.Vector3 value)
        {
            this._transform.localPosition = new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z};
        }
        public UnityEngine.Vector2 get_StartScreenSizeInWorldCoordinates()
        {
            this = R1 + 64;
            mem[1152921509973820244] = R1 + 68;
            return new UnityEngine.Vector2();
        }
        private void set_StartScreenSizeInWorldCoordinates(UnityEngine.Vector2 value)
        {
            this.<StartScreenSizeInWorldCoordinates>k__BackingField = value;
            mem[1152921509973932308] = value.y;
        }
        public UnityEngine.Vector2 get_ScreenSizeInWorldCoordinates()
        {
            this = R1 + 72;
            mem[1152921509974044244] = R1 + 76;
            return new UnityEngine.Vector2();
        }
        private void set_ScreenSizeInWorldCoordinates(UnityEngine.Vector2 value)
        {
            this.<ScreenSizeInWorldCoordinates>k__BackingField = value;
            mem[1152921509974156316] = value.y;
        }
        public UnityEngine.Vector3 get_PreviousTargetsMidPoint()
        {
            mem[1152921509974268248] = R1 + 88;
            this = R1 + 80;
            return new UnityEngine.Vector3();
        }
        private void set_PreviousTargetsMidPoint(UnityEngine.Vector3 value)
        {
        
        }
        public UnityEngine.Vector3 get_TargetsMidPoint()
        {
            mem[1152921509974492248] = R1 + 100;
            this = R1 + 92;
            return new UnityEngine.Vector3();
        }
        private void set_TargetsMidPoint(UnityEngine.Vector3 value)
        {
        
        }
        public UnityEngine.Vector3 get_CameraTargetPosition()
        {
            mem[1152921509974716248] = R1 + 112;
            this = R1 + 104;
            return new UnityEngine.Vector3();
        }
        private void set_CameraTargetPosition(UnityEngine.Vector3 value)
        {
        
        }
        public float get_DeltaTime()
        {
            return (float)S0;
        }
        private void set_DeltaTime(float value)
        {
            this.<DeltaTime>k__BackingField = ;
        }
        public UnityEngine.Vector3 get_ParentPosition()
        {
            mem[1152921509975164248] = R1 + 128;
            this = R1 + 120;
            return new UnityEngine.Vector3();
        }
        private void set_ParentPosition(UnityEngine.Vector3 value)
        {
        
        }
        public UnityEngine.Vector3 get_InfluencesSum()
        {
            mem[1152921509975388248] = R1 + 140;
            this = R1 + 132;
            return new UnityEngine.Vector3();
        }
        private void Awake()
        {
            var val_17;
            var val_18;
            val_17 = 536892083;
            if(((mem[536892270] & true) == 0) && (mem[536892199] == 0))
            {
                    val_17 = 536892083;
            }
            
            mem2[0] = this;
            UnityEngine.Transform val_1 = this.transform;
            this._transform = this;
            UnityEngine.Transform val_2 = this._transform.parent;
            if(this._transform != 0)
            {
                    UnityEngine.Transform val_4 = mem[this._transform].parent;
                UnityEngine.Vector3 val_5 = position;
            }
            
            if(this.GameCamera == 0)
            {
                    UnityEngine.Transform val_7 = this.GameCamera.GetComponent<UnityEngine.Transform>();
                this.GameCamera = this;
            }
            
            val_18 = 0;
            if(1073714640 == 0)
            {
                    UnityEngine.GameObject val_9 = this.gameObject;
                string val_10 = this.name;
                string val_11 = -1610603053(-1610603053) + 1073714640;
                UnityEngine.Debug.LogError(message:  -1610603053);
            }
            
            this.ResetAxisFunctions();
            goto label_18;
            label_27:
            if(this <= val_18)
            {
                    var val_16 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_16 = val_16 + 0;
            if(((0 + 0) + 16 + 8) == 0)
            {
                    this.CameraTargets.RemoveAt(index:  0);
            }
            
            val_18 = 1;
            label_18:
            if(val_18 < this.CameraTargets)
            {
                goto label_27;
            }
            
            this.CalculateScreenSize();
            this.ResetStartSize(newSize:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Vector3 val_13 = localPosition;
            float val_15 = UnityEngine.Mathf.Sign(f:  this.Vector3D.Invoke(arg:  new UnityEngine.Vector3() {x = R6, y = R7, z = R8}));
            this._originalCameraDepthSign = this.Vector3D;
        }
        private void Start()
        {
            UnityEngine.Vector3 val_3;
            float val_4;
            float val_5;
            UnityEngine.Vector3 val_22;
            float val_23;
            float val_24;
            float val_25;
            float val_26;
            var val_27;
            float val_28;
            float val_29;
            UnityEngine.Vector3 val_30;
            this.SortPreMovers();
            this.SortPositionDeltaChangers();
            this.SortPositionOverriders();
            this.SortSizeDeltaChangers();
            this.SortSizeOverriders();
            this.SortPostMovers();
            UnityEngine.Vector3 val_2 = GetTargetsWeightedMidPoint(targets: ref  System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.CameraTarget> val_1 = 1073900368);
            this.<TargetsMidPoint>k__BackingField = val_3;
            mem[1152921509975714736] = val_4;
            mem[1152921509975714740] = val_5;
            float val_6 = this.Vector3H.Invoke(arg:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_5});
            val_22 = this.<TargetsMidPoint>k__BackingField;
            this._cameraTargetHorizontalPositionSmoothed = this.Vector3H;
            float val_7 = this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = val_22, y = val_5, z = val_3});
            this._cameraTargetVerticalPositionSmoothed = this.Vector3V;
            if(this.IgnoreTimeScale != false)
            {
                    float val_8 = UnityEngine.Time.unscaledDeltaTime;
            }
            else
            {
                    float val_9 = UnityEngine.Time.deltaTime;
            }
            
            this.<DeltaTime>k__BackingField = 0;
            if((this.CenterTargetOnStart == false) || ((mem[this.CameraTargets.SyncRoot + 12]) < 1))
            {
                goto label_7;
            }
            
            UnityEngine.Vector3 val_11 = GetTargetsWeightedMidPoint(targets: ref  System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.CameraTarget> val_10 = 1073900368);
            val_23 = val_3;
            val_24 = val_4;
            val_25 = val_5;
            if(this.FollowHorizontal == false)
            {
                goto label_8;
            }
            
            val_26 = val_23;
            val_27 = this.Vector3H;
            val_28 = val_24;
            val_29 = val_25;
            goto label_10;
            label_7:
            UnityEngine.Vector3 val_12 = position;
            UnityEngine.Vector3 val_22 = val_3;
            float val_23 = val_4;
            val_22 = val_22 - (this.<ParentPosition>k__BackingField);
            float val_24 = val_5;
            val_23 = val_23 - S8;
            val_24 = val_24 - S10;
            this.<CameraTargetPosition>k__BackingField = val_22;
            mem[1152921509975714748] = val_23;
            mem[1152921509975714752] = val_24;
            float val_13 = this.Vector3H.Invoke(arg:  new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_24});
            val_30 = this.<CameraTargetPosition>k__BackingField;
            this._cameraTargetHorizontalPositionSmoothed = this.Vector3H;
            this._previousCameraTargetHorizontalPositionSmoothed = this.Vector3H;
            float val_14 = this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = val_30, y = val_24, z = val_22});
            this._cameraTargetVerticalPositionSmoothed = this.Vector3V;
            this._previousCameraTargetVerticalPositionSmoothed = this.Vector3V;
            return;
            label_8:
            UnityEngine.Vector3 val_15 = localPosition;
            val_28 = val_4;
            val_29 = val_5;
            if(this.Vector3H == 0)
            {
                    val_29 = val_29;
                val_28 = val_28;
            }
            
            val_26 = val_3;
            val_27 = this.Vector3H;
            label_10:
            float val_16 = val_27.Invoke(arg:  new UnityEngine.Vector3() {x = val_26, y = val_28, z = val_29});
            if(this.FollowVertical != true)
            {
                    UnityEngine.Vector3 val_17 = localPosition;
                val_23 = val_3;
                val_24 = val_4;
                val_25 = val_5;
            }
            
            if(this.IsRelativeOffset == true)
            {
                    this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25}) = this.<ScreenSizeInWorldCoordinates>k__BackingField;
                val_17.z = 0.5f;
            }
            
            if(this.IsRelativeOffset == true)
            {
                    this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25}) = this.OffsetX * (this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25}));
            }
            
            if(this.IsRelativeOffset == true)
            {
                    this.OffsetX = (this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25})) * val_17.z;
            }
            
            float val_19 = this.Vector3H.Invoke(arg:  new UnityEngine.Vector3() {x = mem[this.<ParentPosition>k__BackingField + (0)], y = mem[this.<ParentPosition>k__BackingField + (4)], z = mem[this.<ParentPosition>k__BackingField + (8)]});
            val_30 = this.<ParentPosition>k__BackingField;
            if(this.IsRelativeOffset == true)
            {
                    val_19 = this.OffsetY * val_19;
            }
            
            if(this.IsRelativeOffset == true)
            {
                    this.OffsetY = val_19 * val_17.z;
            }
            
            float val_20 = this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = val_30, y = mem[this.<ParentPosition>k__BackingField + (0)], z = mem[this.<ParentPosition>k__BackingField + (4)]});
            System.Func<UnityEngine.Vector3, System.Single> val_25 = this.Vector3V;
            float val_21 = this.OffsetX - this.Vector3H;
            val_25 = this.OffsetY - val_25;
            val_21 = val_27 + val_21;
            val_25 = this.Vector3V + val_25;
            this.MoveCameraInstantlyToPosition(cameraPos:  new UnityEngine.Vector2() {x = val_21, y = val_25});
        }
        private void LateUpdate()
        {
            var val_3;
            if(this.UpdateType != 0)
            {
                    return;
            }
            
            if((R4 + 54) != 0)
            {
                    val_3 = 0;
                float val_1 = UnityEngine.Time.unscaledDeltaTime;
            }
            else
            {
                    val_3 = 0;
            }
            
            R4.Move(deltaTime:  UnityEngine.Time.deltaTime);
        }
        private void FixedUpdate()
        {
            var val_3;
            if(this.UpdateType != 1)
            {
                    return;
            }
            
            if((R4 + 54) != 0)
            {
                    val_3 = 0;
                float val_1 = UnityEngine.Time.fixedUnscaledDeltaTime;
            }
            else
            {
                    val_3 = 0;
            }
            
            R4.Move(deltaTime:  UnityEngine.Time.fixedDeltaTime);
        }
        private void OnApplicationQuit()
        {
            if(((mem[536892270] & true) == 0) && (mem[536892199] == 0))
            {
                    536892083 = 536892083;
            }
            
            mem2[0] = 0;
        }
        public float GetOffsetX()
        {
            return (float)this.OffsetX;
        }
        public float GetOffsetY()
        {
            return (float)this.OffsetY;
        }
        public void ApplyInfluence(UnityEngine.Vector2 influence)
        {
            System.Collections.Generic.List<UnityEngine.Vector3> val_5;
            var val_6;
            val_5 = this;
            val_6 = 23000834;
            float val_1 = UnityEngine.Time.deltaTime;
            if((System.Single.IsNaN(f:  0.0001f)) == true)
            {
                    return;
            }
            
            if((System.Single.IsNaN(f:  0.0001f)) == true)
            {
                    return;
            }
            
            val_5 = this._influences;
            UnityEngine.Vector3 val_4 = Invoke(arg1:  0.0001f, arg2:  null);
            val_5.Add(item:  new UnityEngine.Vector3() {x = R4, y = R5, z = R7});
        }
        public UnityEngine.Coroutine ApplyInfluencesTimed(UnityEngine.Vector2[] influences, float[] durations)
        {
            System.Collections.IEnumerator val_1 = this.ApplyInfluencesTimedRoutine(influences:  influences, durations:  durations);
            return this.StartCoroutine(routine:  1074835920);
        }
        public Com.LuisPedroFonseca.ProCamera2D.CameraTarget AddCameraTarget(UnityEngine.Transform targetTransform, float targetInfluenceH = 1, float targetInfluenceV = 1, float duration = 0, UnityEngine.Vector2 targetOffset)
        {
            var val_1;
            var val_2;
            var val_7 = val_1;
            Com.LuisPedroFonseca.ProCamera2D.CameraTarget val_3 = 536884549;
            val_3 = new Com.LuisPedroFonseca.ProCamera2D.CameraTarget();
            if(val_3 != 0)
            {
                    mem[536884557] = targetTransform;
                mem[536884561] = targetOffset.x;
                mem[536884565] = targetOffset.y;
                val_7 = val_7;
            }
            else
            {
                    mem[8] = targetTransform;
                mem[12] = targetOffset.x;
                mem[16] = targetOffset.y;
            }
            
            mem[536884569] = val_2;
            mem[536884573] = val_7;
            this.CameraTargets.Add(item:  536884549);
            if(this.CameraTargets <= 0)
            {
                    return;
            }
            
            val_3.TargetInfluence = targetInfluenceH;
            System.Collections.IEnumerator val_5 = this.AdjustTargetInfluenceRoutine(cameraTarget:  536884549, influenceH:  targetInfluenceH, influenceV:  targetInfluenceV, duration:  duration, removeIfZeroInfluence:  targetOffset.x);
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  1075029840);
        }
        public void AddCameraTargets(System.Collections.Generic.IList<UnityEngine.Transform> targetsTransforms, float targetsInfluenceH = 1, float targetsInfluenceV = 1, float duration = 0, UnityEngine.Vector2 targetOffset)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_7 = 0;
            goto label_1;
            label_12:
            var val_7 = 0;
            val_8 = 0;
            val_7 = val_7 + 1;
            val_8 = (uint)val_7 & 65535;
            val_9 = targetsTransforms;
            Com.LuisPedroFonseca.ProCamera2D.CameraTarget val_5 = this.AddCameraTarget(targetTransform:  targetsTransforms, targetInfluenceH:  targetsInfluenceH, targetInfluenceV:  targetsInfluenceV, duration:  duration, targetOffset:  new UnityEngine.Vector2() {x = targetOffset.x, y = targetOffset.y});
            val_7 = 1;
            label_1:
            var val_8 = 0;
            val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = (uint)val_8 & 65535;
            val_10 = targetsTransforms;
            if(val_7 < targetsTransforms)
            {
                goto label_12;
            }
        
        }
        public void AddCameraTargets(System.Collections.Generic.IList<Com.LuisPedroFonseca.ProCamera2D.CameraTarget> cameraTargets)
        {
            this.CameraTargets.AddRange(collection:  cameraTargets);
        }
        public Com.LuisPedroFonseca.ProCamera2D.CameraTarget GetCameraTarget(UnityEngine.Transform targetTransform)
        {
            goto label_1;
            label_9:
            if(true <= 23000838)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            int val_2 = targetTransform.GetInstanceID();
            if(static_value_0028000B.GetInstanceID() == val_2)
            {
                goto label_7;
            }
            
            4 = 5;
            label_1:
            if((4 - 4) < val_2)
            {
                goto label_9;
            }
            
            return;
            label_7:
            if(val_2 > 23000838)
            {
                    return;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        public void RemoveCameraTarget(UnityEngine.Transform targetTransform, float duration = 0)
        {
            goto label_1;
            label_15:
            if(true <= 23000839)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            int val_1 = static_value_0028000B.GetInstanceID();
            int val_2 = targetTransform.GetInstanceID();
            if(val_1 == val_2)
            {
                    if(val_1 > val_2)
            {
                    if(val_2 <= 23000839)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                System.Collections.IEnumerator val_3 = this.AdjustTargetInfluenceRoutine(cameraTarget:  2621443, influenceH:  duration, influenceV:  null, duration:  null, removeIfZeroInfluence:  false);
                UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  1075559760);
            }
            else
            {
                    if(val_2 <= 23000839)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            }
            
            }
            
            4 = 5;
            label_1:
            if((4 - 4) < (this.CameraTargets.Remove(item:  2621443)))
            {
                goto label_15;
            }
        
        }
        public void RemoveAllCameraTargets(float duration = 0)
        {
            this.CameraTargets.Clear();
        }
        public UnityEngine.Coroutine AdjustCameraTargetInfluence(Com.LuisPedroFonseca.ProCamera2D.CameraTarget cameraTarget, float targetInfluenceH, float targetInfluenceV, float duration = 0)
        {
            float val_1;
            if()
            {
                    System.Collections.IEnumerator val_2 = this.AdjustTargetInfluenceRoutine(cameraTarget:  cameraTarget, influenceH:  val_1, influenceV:  targetInfluenceV, duration:  duration, removeIfZeroInfluence:  false);
                return this.StartCoroutine(routine:  1075828816);
            }
            
            if(cameraTarget != 0)
            {
                    cameraTarget.TargetInfluenceH = R2;
            }
            else
            {
                    mem[12] = R2;
            }
            
            cameraTarget.TargetInfluenceV = R3;
        }
        public UnityEngine.Coroutine AdjustCameraTargetInfluence(UnityEngine.Transform cameraTargetTransf, float targetInfluenceH, float targetInfluenceV, float duration = 0)
        {
            float val_2;
            Com.LuisPedroFonseca.ProCamera2D.CameraTarget val_1 = this.GetCameraTarget(targetTransform:  cameraTargetTransf);
            if(this == 0)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_3 = this.AdjustCameraTargetInfluence(cameraTarget:  1075949008, targetInfluenceH:  val_2, targetInfluenceV:  targetInfluenceV, duration:  duration);
        }
        public void MoveCameraInstantlyToPosition(UnityEngine.Vector2 cameraPos)
        {
            float val_4;
            float val_5;
            float val_6;
            UnityEngine.Vector3 val_1 = localPosition;
            UnityEngine.Vector3 val_3 = Invoke(arg1:  this.Vector3D.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R8, z = SB}), arg2:  val_1.y, arg3:  val_1.z);
            this._transform.localPosition = new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6};
            this.ResetMovement();
        }
        public void Reset(bool centerOnTargets = True, bool resetSize = True, bool resetExtensions = True)
        {
            if(centerOnTargets != false)
            {
                    this.CenterOnTargets();
            }
            else
            {
                    this.ResetMovement();
            }
            
            if(resetSize != false)
            {
                    float val_1 = 0.5f;
                val_1 = S2 * val_1;
                this.SetScreenSize(newSize:  val_1);
            }
            
            if(resetExtensions == true)
            {
                    this = this.OnReset;
            }
            
            if(this == 0)
            {
                    return;
            }
            
            this.Invoke();
        }
        public void ResetMovement()
        {
            UnityEngine.Vector3 val_1 = localPosition;
            float val_2 = this.Vector3H.Invoke(arg:  new UnityEngine.Vector3() {x = R6, y = R7, z = R8});
            this._cameraTargetHorizontalPositionSmoothed = this.Vector3H;
            float val_3 = this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = this.<CameraTargetPosition>k__BackingField, y = R6, z = R7});
            this._cameraTargetVerticalPositionSmoothed = this.Vector3V;
            this._previousCameraTargetHorizontalPositionSmoothed = this._cameraTargetHorizontalPositionSmoothed;
            this._previousCameraTargetVerticalPositionSmoothed = this.Vector3V;
        }
        public void ResetSize()
        {
            float val_1 = 0.5f;
            val_1 = S2 * val_1;
            this.SetScreenSize(newSize:  val_1);
        }
        public void ResetStartSize(UnityEngine.Vector2 newSize)
        {
            float val_2;
            float val_3;
            float val_4;
            var val_8;
            UnityEngine.Vector2 val_9;
            float val_10;
            val_8 = newSize.y;
            val_9 = newSize.x;
            val_10 = 23000843;
            var val_8 = val_8;
            val_8 = val_8 * val_8;
            UnityEngine.Vector3 val_1 = localPosition;
            val_10 = val_2;
            System.Func<UnityEngine.Vector3, System.Single> val_6 = this.Vector3D & (~2147483648);
            UnityEngine.Vector2 val_7 = Com.LuisPedroFonseca.ProCamera2D.Utils.GetScreenSizeInWorldCoords(gameCamera:  1076570692, distance:  this.Vector3D.Invoke(arg:  new UnityEngine.Vector3() {x = val_10, y = val_3, z = val_4}));
            val_9 = val_2;
            val_8 = val_3;
            this.<StartScreenSizeInWorldCoordinates>k__BackingField = val_9;
            mem[1152921509978397076] = val_8;
        }
        public void ResetExtensions()
        {
            if(this.OnReset == 0)
            {
                    return;
            }
            
            this.OnReset.Invoke();
        }
        public void CenterOnTargets()
        {
            float val_3;
            float val_6;
            float val_7;
            UnityEngine.Vector3 val_2 = GetTargetsWeightedMidPoint(targets: ref  System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.CameraTarget> val_1 = 1076835408);
            float val_4 = this.Vector3H.Invoke(arg:  new UnityEngine.Vector3() {x = R8, y = SB, z = val_3});
            float val_5 = this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = R8, y = SB, z = val_3});
            System.Func<UnityEngine.Vector3, System.Single> val_7 = this.Vector3V;
            val_6 = this.OffsetX;
            if(this.IsRelativeOffset != false)
            {
                    float val_6 = this.OffsetY;
                val_6 = val_6 * (this.<ScreenSizeInWorldCoordinates>k__BackingField);
                val_6 = val_6 * S8;
                val_6 = val_6 * 0.5f;
                val_7 = val_6 * 0.5f;
            }
            else
            {
                    val_7 = this.OffsetY;
            }
            
            val_6 = this.Vector3H + val_6;
            val_7 = val_7 + val_7;
            this.MoveCameraInstantlyToPosition(cameraPos:  new UnityEngine.Vector2() {x = val_6, y = val_7});
        }
        public void UpdateScreenSize(float newSize, float duration = 0, Com.LuisPedroFonseca.ProCamera2D.EaseType easeType = 0)
        {
            Com.LuisPedroFonseca.ProCamera2D.EaseType val_6;
            var val_7;
            var val_8;
            val_6 = easeType;
            val_7 = R3;
            val_8 = R2;
            if(this.enabled == false)
            {
                goto label_0;
            }
            
            if(this._updateScreenSizeCoroutine != 0)
            {
                    this.StopCoroutine(routine:  this._updateScreenSizeCoroutine);
            }
            
            if(this._updateScreenSizeCoroutine <= 0)
            {
                goto label_2;
            }
            
            System.Collections.IEnumerator val_2 = this.UpdateScreenSizeRoutine(finalSize:  newSize, duration:  duration, easeType:  val_6);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  1076963792);
            this._updateScreenSizeCoroutine = this;
            label_0:
            var val_4 = FP - 32;
            return;
            label_2:
            this.SetScreenSize(newSize:  newSize);
        }
        public void CalculateScreenSize()
        {
            float val_2;
            float val_3;
            float val_4;
            this.GameCamera.ResetAspect();
            UnityEngine.Vector3 val_1 = localPosition;
            System.Func<UnityEngine.Vector3, System.Single> val_6 = this.Vector3D & (~2147483648);
            UnityEngine.Vector2 val_7 = Com.LuisPedroFonseca.ProCamera2D.Utils.GetScreenSizeInWorldCoords(gameCamera:  1077088324, distance:  this.Vector3D.Invoke(arg:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4}));
            this.<ScreenSizeInWorldCoordinates>k__BackingField = new UnityEngine.Vector2();
            mem[1152921509978914716] = ???;
            this._previousScreenWidth = UnityEngine.Screen.width;
            this._previousScreenHeight = UnityEngine.Screen.height;
        }
        public void Zoom(float zoomAmount, float duration = 0, Com.LuisPedroFonseca.ProCamera2D.EaseType easeType = 0)
        {
            this.UpdateScreenSize(newSize:  0.5f, duration:  duration, easeType:  easeType);
        }
        public void DollyZoom(float targetFOV, float duration = 1, Com.LuisPedroFonseca.ProCamera2D.EaseType easeType = 0)
        {
            float val_7;
            float val_8;
            float val_9;
            var val_15;
            var val_16;
            Com.LuisPedroFonseca.ProCamera2D.EaseType val_17;
            val_15 = R3;
            val_16 = R2;
            val_17 = easeType;
            if(this.enabled == false)
            {
                    return;
            }
            
            if(this.GameCamera.orthographic != false)
            {
                    UnityEngine.Debug.LogWarning(message:  -1610608681);
                return;
            }
            
            var val_17 = val_16;
            if(this._dollyZoomRoutine != 0)
            {
                    this.StopCoroutine(routine:  this._dollyZoomRoutine);
            }
            
            float val_3 = UnityEngine.Mathf.Clamp(value:  targetFOV, min:  duration, max:  null);
            if(this._dollyZoomRoutine > 0)
            {
                    System.Collections.IEnumerator val_4 = this.DollyZoomRoutine(finalFOV:  val_3, duration:  duration, easeType:  val_17);
                UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  1077389904);
                return;
            }
            
            this.GameCamera.fieldOfView = val_3;
            UnityEngine.Vector3 val_6 = localPosition;
            float val_10 = this.Vector3H.Invoke(arg:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9});
            UnityEngine.Vector3 val_11 = localPosition;
            float val_12 = this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R6, z = R8});
            val_17 = this.Vector3V;
            float val_13 = this.GameCamera.fieldOfView;
            float val_15 = 0.5f;
            val_15 = this.GameCamera * val_15;
            val_15 = val_15 * 0.01745329f;
            float val_16 = val_15;
            val_16 = val_16 + val_16;
            val_17 = val_17 / val_16;
            val_16 = this._originalCameraDepthSign * val_17;
            UnityEngine.Vector3 val_14 = Invoke(arg1:  val_16, arg2:  val_11.y, arg3:  0.01745329f);
            this._transform.localPosition = new UnityEngine.Vector3() {x = R4, y = R5, z = R6};
        }
        public void Move(float deltaTime)
        {
            float val_13;
            float val_14;
            float val_15;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_52;
            int val_53;
            var val_54;
            var val_55;
            var val_56;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_57;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_59;
            float val_60;
            float val_61;
            float val_62;
            var val_63;
            float val_65;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_69;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_70;
            var val_71;
            float val_72;
            var val_73;
            var val_74;
            var val_75;
            var val_76;
            var val_77;
            var val_78;
            var val_79;
            var val_80;
            float val_81;
            float val_82;
            float val_83;
            var val_84;
            var val_85;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_86;
            var val_87;
            var val_88;
            var val_89;
            val_52 = this;
            UnityEngine.Vector3 val_1 = localPosition;
            val_53 = this._previousScreenWidth;
            if(UnityEngine.Screen.width != val_53)
            {
                goto label_2;
            }
            
            int val_3 = UnityEngine.Screen.height;
            val_53 = this._previousScreenHeight;
            if(val_3 == val_53)
            {
                goto label_3;
            }
            
            label_2:
            this.CalculateScreenSize();
            label_3:
            this.<DeltaTime>k__BackingField = ???;
            if(val_3 < 0)
            {
                    return;
            }
            
            if(this.PreMoveUpdate != 0)
            {
                    val_53 = ???;
                this.PreMoveUpdate.Invoke(obj:  0.0001f);
            }
            
            val_54 = 0;
            goto label_6;
            label_15:
            if(this.PreMoveUpdate <= val_54)
            {
                    var val_52 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_52 = val_52 + 0;
            var val_54 = (0 + 0) + 16;
            if(((0 + 0) + 16 + 178) == 0)
            {
                goto label_10;
            }
            
            var val_53 = 0;
            label_12:
            val_55 = 0;
            if(((0 + 0) + 16 + 88 + 0) == 536888611)
            {
                goto label_11;
            }
            
            val_53 = val_53 + 1;
            val_55 = (uint)val_53 & 65535;
            if(val_55 < ((0 + 0) + 16 + 178))
            {
                goto label_12;
            }
            
            label_10:
            val_56 = (0 + 0) + 16;
            goto label_13;
            label_11:
            var val_4 = ((0 + 0) + 16 + 88) + 0;
            val_54 = val_54 + ((((0 + 0) + 16 + 88 + 0) + 4) << 3);
            val_56 = val_54 + 188;
            label_13:
            val_53 = ???;
            val_57 = val_52;
            val_54 = 1;
            label_6:
            if(val_54 < ((0 + 0) + 16))
            {
                goto label_15;
            }
            
            UnityEngine.Vector3 val_6 = GetTargetsWeightedMidPoint(targets: ref  System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.CameraTarget> val_5 = 1077555152);
            UnityEngine.Vector3 val_7 = Com.LuisPedroFonseca.ProCamera2D.Utils.GetVectorsSum(input:  1077543100);
            float val_55 = R0;
            val_55 = mem[1152921509979369528] + val_55;
            mem[1152921509979369528] = val_55;
            mem[1152921509979369532] = mem[1152921509979369532] + R1;
            mem[1152921509979369536] = mem[1152921509979369536] + R2;
            mem[1152921509979369648].Clear();
            if(mem[1152921509979369452] != false)
            {
                
            }
            else
            {
                    UnityEngine.Vector3 val_10 = localPosition;
            }
            
            float val_11 = mem[1152921509979369620].Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R6, z = R7});
            val_59 = val_52;
            if(mem[1152921509979369460] != false)
            {
                    val_60 = mem[1152921509979369528];
                val_61 = mem[1152921509979369532];
                val_62 = mem[1152921509979369536];
            }
            else
            {
                    UnityEngine.Vector3 val_12 = localPosition;
                val_60 = val_13;
                val_61 = val_14;
                val_62 = val_15;
            }
            
            float val_16 = mem[1152921509979369624].Invoke(arg:  new UnityEngine.Vector3() {x = val_60, y = val_61, z = val_62});
            float val_17 = mem[1152921509979369620].Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R7, z = R8});
            float val_18 = mem[1152921509979369624].Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R7, z = SB});
            float val_20 = mem[1152921509979369624] - mem[1152921509979369624];
            val_63 = 22732400;
            UnityEngine.Vector3 val_21 = Invoke(arg1:  mem[1152921509979369620] - mem[1152921509979369620], arg2:  val_12.y);
            val_65 = 4.01997E-38f;
            val_69 = val_52;
            if(mem[1152921509979369604] != false)
            {
                    UnityEngine.Vector3 val_22 = Value;
                float val_23 = mem[1152921509979369620].Invoke(arg:  new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15});
                float val_24 = mem[1152921509979369620].Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R6, z = SB});
                UnityEngine.Vector3 val_25 = Value;
                float val_26 = mem[1152921509979369624].Invoke(arg:  new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15});
                float val_27 = mem[1152921509979369624].Invoke(arg:  new UnityEngine.Vector3() {x = mem[1152921509979369544], y = mem[1152921509979369548], z = mem[1152921509979369552]});
                float val_29 = mem[1152921509979369624] - mem[1152921509979369624];
                val_63 = 22732400;
                UnityEngine.Vector3 val_30 = Invoke(arg1:  mem[1152921509979369620] - mem[1152921509979369620], arg2:  val_25.y);
                val_69 = val_52;
                val_65 = 4.01997E-38f;
            }
            
            if(mem[1152921509979369452] == true)
            {
                    mem[1152921509979369452] = mem[1152921509979369476];
            }
            
            if(mem[1152921509979369452] == true)
            {
                    0 = mem[1152921509979369468];
            }
            
            if(mem[1152921509979369452] == true)
            {
                    val_30.x = mem[1152921509979369496];
                val_30.z = 0.5f;
                val_30.x = 0 * val_30.x;
                0 = val_30.x * val_30.z;
            }
            
            if(mem[1152921509979369460] == true)
            {
                    mem[1152921509979369460] = mem[1152921509979369476];
                0f = mem[1152921509979369472];
                val_30.x = mem[1152921509979369500];
                val_30.z = 0.5f;
                0f = val_30.x * val_30.z;
            }
            
            UnityEngine.Vector3 val_31 = Invoke(arg1:  val_30.x = 0f * val_30.x, arg2:  val_30.y);
            float val_56 = val_13;
            float val_57 = val_14;
            float val_58 = val_15;
            val_56 = val_56 + R0;
            val_57 = val_57 + R1;
            val_58 = val_58 + R2;
            mem[1152921509979369528] = val_56;
            mem[1152921509979369532] = val_57;
            mem[1152921509979369536] = val_58;
            float val_32 = mem[1152921509979369620].Invoke(arg:  new UnityEngine.Vector3() {x = val_56, y = val_57, z = val_58});
            float val_59 = mem[1152921509979369456];
            val_59 = 1f / val_59;
            float val_33 = Com.LuisPedroFonseca.ProCamera2D.Utils.SmoothApproach(pastPosition:  val_59, pastTargetPosition:  val_31.y, targetPosition:  this.<DeltaTime>k__BackingField, speed:  null, deltaTime:  val_58);
            mem[1152921509979369480] = mem[1152921509979369480];
            mem[1152921509979369656] = mem[1152921509979369480];
            float val_34 = mem[1152921509979369624].Invoke(arg:  new UnityEngine.Vector3() {x = mem[1152921509979369528], y = mem[1152921509979369532], z = mem[1152921509979369536]});
            float val_60 = mem[1152921509979369464];
            val_60 = 1f / val_60;
            float val_35 = Com.LuisPedroFonseca.ProCamera2D.Utils.SmoothApproach(pastPosition:  val_60, pastTargetPosition:  val_31.y, targetPosition:  this.<DeltaTime>k__BackingField, speed:  null, deltaTime:  val_58);
            float val_61 = mem[1152921509979369480];
            mem[1152921509979369484] = mem[1152921509979369484];
            mem[1152921509979369660] = mem[1152921509979369484];
            UnityEngine.Vector3 val_36 = localPosition;
            float val_37 = mem[1152921509979369620].Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7});
            float val_62 = mem[1152921509979369484];
            UnityEngine.Vector3 val_38 = localPosition;
            val_61 = val_61 - mem[1152921509979369620];
            float val_39 = mem[1152921509979369624].Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7});
            val_70 = val_52;
            val_62 = val_62 - mem[1152921509979369624];
            UnityEngine.Vector3 val_40 = Invoke(arg1:  mem[1152921509979369624], arg2:  val_38.y);
            val_71 = 0;
            val_72 = val_14;
            val_73 = val_15;
            goto label_42;
            label_51:
            if((mem[1152921509979369704] + 12) <= val_71)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_63 = mem[1152921509979369704] + 8;
            val_63 = val_63 + 0;
            var val_65 = (mem[1152921509979369704] + 8 + 0) + 16;
            if(((mem[1152921509979369704] + 8 + 0) + 16 + 178) == 0)
            {
                goto label_46;
            }
            
            var val_64 = 0;
            label_48:
            if(((mem[1152921509979369704] + 8 + 0) + 16 + 88 + 0) == 536888707)
            {
                goto label_47;
            }
            
            val_64 = val_64 + 1;
            if(((uint)val_64 & 65535) < ((mem[1152921509979369704] + 8 + 0) + 16 + 178))
            {
                goto label_48;
            }
            
            label_46:
            val_74 = (mem[1152921509979369704] + 8 + 0) + 16;
            goto label_49;
            label_47:
            var val_41 = ((mem[1152921509979369704] + 8 + 0) + 16 + 88) + 0;
            val_65 = val_65 + ((((mem[1152921509979369704] + 8 + 0) + 16 + 88 + 0) + 4) << 3);
            val_74 = val_65 + 188;
            label_49:
            val_70 = val_52;
            val_71 = 1;
            label_42:
            if(val_71 < (mem[1152921509979369704] + 12))
            {
                goto label_51;
            }
            
            float val_69 = mem[1152921509979369500];
            val_75 = 0;
            goto label_52;
            label_61:
            if((mem[1152921509979369708] + 12) <= val_75)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_66 = mem[1152921509979369708] + 8;
            val_66 = val_66 + 0;
            var val_68 = (mem[1152921509979369708] + 8 + 0) + 16;
            if(((mem[1152921509979369708] + 8 + 0) + 16 + 178) == 0)
            {
                goto label_56;
            }
            
            var val_67 = 0;
            label_58:
            if(((mem[1152921509979369708] + 8 + 0) + 16 + 88 + 0) == 536888709)
            {
                goto label_57;
            }
            
            val_67 = val_67 + 1;
            if(((uint)val_67 & 65535) < ((mem[1152921509979369708] + 8 + 0) + 16 + 178))
            {
                goto label_58;
            }
            
            label_56:
            val_76 = (mem[1152921509979369708] + 8 + 0) + 16;
            goto label_59;
            label_57:
            var val_42 = ((mem[1152921509979369708] + 8 + 0) + 16 + 88) + 0;
            val_68 = val_68 + ((((mem[1152921509979369708] + 8 + 0) + 16 + 88 + 0) + 4) << 3);
            val_76 = val_68 + 188;
            label_59:
            val_70 = val_52;
            val_75 = 1;
            label_52:
            if(val_75 < (mem[1152921509979369708] + 12))
            {
                goto label_61;
            }
            
            val_69 = val_69 * 0.5f;
            if(val_75 != (mem[1152921509979369708] + 12))
            {
                    this.SetScreenSize(newSize:  val_69);
            }
            
            val_77 = 0;
            val_78 = val_13;
            goto label_63;
            label_72:
            if((mem[1152921509979369696] + 12) <= val_77)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_70 = mem[1152921509979369696] + 8;
            val_70 = val_70 + 0;
            var val_72 = (mem[1152921509979369696] + 8 + 0) + 16;
            if(((mem[1152921509979369696] + 8 + 0) + 16 + 178) == 0)
            {
                goto label_67;
            }
            
            var val_71 = 0;
            label_69:
            if(((mem[1152921509979369696] + 8 + 0) + 16 + 88 + 0) == 536888605)
            {
                goto label_68;
            }
            
            val_71 = val_71 + 1;
            if(((uint)val_71 & 65535) < ((mem[1152921509979369696] + 8 + 0) + 16 + 178))
            {
                goto label_69;
            }
            
            label_67:
            val_79 = (mem[1152921509979369696] + 8 + 0) + 16;
            goto label_70;
            label_68:
            var val_43 = ((mem[1152921509979369696] + 8 + 0) + 16 + 88) + 0;
            val_72 = val_72 + ((((mem[1152921509979369696] + 8 + 0) + 16 + 88 + 0) + 4) << 3);
            val_79 = val_72 + 188;
            label_70:
            val_78 = val_13;
            val_77 = 1;
            val_72 = val_14;
            val_73 = val_15;
            val_70 = val_52;
            label_63:
            if(val_77 < (mem[1152921509979369696] + 12))
            {
                goto label_72;
            }
            
            UnityEngine.Vector3 val_44 = LocalPosition;
            var val_73 = val_73;
            float val_74 = val_72;
            var val_75 = val_13;
            val_73 = val_15 + val_73;
            val_80 = 0;
            val_74 = val_14 + val_74;
            val_75 = val_75 + val_78;
            val_81 = val_73;
            val_82 = val_74;
            val_83 = val_75;
            goto label_73;
            label_82:
            if((mem[1152921509979369700] + 12) <= val_80)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_76 = mem[1152921509979369700] + 8;
            val_76 = val_76 + 0;
            var val_78 = (mem[1152921509979369700] + 8 + 0) + 16;
            if(((mem[1152921509979369700] + 8 + 0) + 16 + 178) == 0)
            {
                goto label_77;
            }
            
            var val_77 = 0;
            label_79:
            if(((mem[1152921509979369700] + 8 + 0) + 16 + 88 + 0) == 536888607)
            {
                goto label_78;
            }
            
            val_77 = val_77 + 1;
            if(((uint)val_77 & 65535) < ((mem[1152921509979369700] + 8 + 0) + 16 + 178))
            {
                goto label_79;
            }
            
            label_77:
            val_84 = (mem[1152921509979369700] + 8 + 0) + 16;
            goto label_80;
            label_78:
            var val_45 = ((mem[1152921509979369700] + 8 + 0) + 16 + 88) + 0;
            val_78 = val_78 + ((((mem[1152921509979369700] + 8 + 0) + 16 + 88 + 0) + 4) << 3);
            val_84 = val_78 + 188;
            label_80:
            val_83 = val_13;
            val_80 = 1;
            val_82 = val_14;
            val_81 = val_15;
            val_70 = val_52;
            label_73:
            if(val_80 < (mem[1152921509979369700] + 12))
            {
                goto label_82;
            }
            
            float val_46 = mem[1152921509979369620].Invoke(arg:  new UnityEngine.Vector3() {x = val_83, y = val_82, z = val_81});
            float val_47 = mem[1152921509979369624].Invoke(arg:  new UnityEngine.Vector3() {x = val_83, y = val_82, z = val_81});
            UnityEngine.Vector3 val_48 = localPosition;
            UnityEngine.Vector3 val_50 = Invoke(arg1:  mem[1152921509979369628].Invoke(arg:  new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15}), arg2:  val_48.y, arg3:  val_48.z);
            val_86 = val_52;
            val_87 = 0;
            this._transform.localPosition = new UnityEngine.Vector3() {x = R4, y = R5, z = R6};
            goto label_89;
            label_98:
            if((mem[1152921509979369712] + 12) <= val_87)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_79 = mem[1152921509979369712] + 8;
            val_79 = val_79 + 0;
            val_88 = mem[(mem[1152921509979369712] + 8 + 0) + 16];
            val_88 = (mem[1152921509979369712] + 8 + 0) + 16;
            var val_80 = val_88;
            if(((mem[1152921509979369712] + 8 + 0) + 16 + 178) == 0)
            {
                goto label_93;
            }
            
            val_85 = 0;
            label_95:
            if(((mem[1152921509979369712] + 8 + 0) + 16 + 88 + 0) == 536888609)
            {
                goto label_94;
            }
            
            val_85 = val_85 + 1;
            if(((uint)val_85 & 65535) < ((mem[1152921509979369712] + 8 + 0) + 16 + 178))
            {
                goto label_95;
            }
            
            label_93:
            val_89 = val_88;
            goto label_96;
            label_94:
            var val_51 = ((mem[1152921509979369712] + 8 + 0) + 16 + 88) + 0;
            val_80 = val_80 + ((((mem[1152921509979369712] + 8 + 0) + 16 + 88 + 0) + 4) << 3);
            val_89 = val_80 + 188;
            label_96:
            val_86 = val_52;
            val_87 = 1;
            label_89:
            if(val_87 < (mem[1152921509979369712] + 12))
            {
                goto label_98;
            }
            
            if(mem[1152921509979369572] == 0)
            {
                    return;
            }
            
            mem[1152921509979369572].Invoke(obj:  val_50.x);
        }
        public UnityEngine.YieldInstruction GetYield()
        {
            if(this.UpdateType == 1)
            {
                    0 = this._waitForFixedUpdate;
            }
        
        }
        private void ResetAxisFunctions()
        {
            var val_17;
            var val_18;
            object val_19;
            System.Func<UnityEngine.Vector3, System.Single> val_20;
            object val_21;
            var val_22;
            object val_23;
            System.Func<UnityEngine.Vector3, System.Single> val_24;
            var val_25;
            object val_26;
            System.Func<UnityEngine.Vector3, System.Single> val_27;
            var val_28;
            object val_29;
            System.Func<System.Single, System.Single, UnityEngine.Vector3> val_30;
            var val_31;
            object val_32;
            System.Func<System.Single, System.Single, System.Single, UnityEngine.Vector3> val_33;
            var val_34;
            object val_35;
            System.Func<UnityEngine.Vector3, System.Single> val_36;
            var val_37;
            object val_38;
            System.Func<UnityEngine.Vector3, System.Single> val_39;
            var val_40;
            object val_41;
            System.Func<UnityEngine.Vector3, System.Single> val_42;
            var val_43;
            object val_44;
            System.Func<System.Single, System.Single, UnityEngine.Vector3> val_45;
            var val_46;
            object val_47;
            var val_48;
            object val_49;
            System.Func<UnityEngine.Vector3, System.Single> val_50;
            var val_51;
            object val_52;
            System.Func<UnityEngine.Vector3, System.Single> val_53;
            var val_54;
            object val_55;
            System.Func<UnityEngine.Vector3, System.Single> val_56;
            var val_57;
            object val_58;
            System.Func<System.Single, System.Single, UnityEngine.Vector3> val_59;
            var val_60;
            object val_61;
            if(this.Axis == 2)
            {
                goto label_1;
            }
            
            if(this.Axis == 1)
            {
                goto label_2;
            }
            
            if(this.Axis != 0)
            {
                    return;
            }
            
            val_17 = 22719180;
            val_18 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_18 = 536900561;
            }
            
            val_19 = mem[536900653];
            val_20 = mem[mem[536900653] + 4];
            val_20 = mem[536900653] + 4;
            if(val_20 == 0)
            {
                    if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_19 = mem[536900653];
            }
            
                val_21 = mem[mem[536900653]];
                val_21 = val_19;
                val_20 = 536875575;
                val_20 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_21, method:  new IntPtr(1610685623));
                mem2[0] = val_20;
            }
            
            this.Vector3H = val_20;
            val_22 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_22 = 536900561;
            }
            
            val_23 = mem[536900653];
            val_24 = mem[mem[536900653] + 8];
            val_24 = mem[536900653] + 8;
            if(val_24 == 0)
            {
                    if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_23 = mem[536900653];
            }
            
                val_21 = mem[mem[536900653]];
                val_21 = val_23;
                val_24 = 536875575;
                val_24 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_21, method:  new IntPtr(1610685625));
                mem2[0] = val_24;
            }
            
            this.Vector3V = val_24;
            val_25 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_25 = 536900561;
            }
            
            val_26 = mem[536900653];
            val_27 = mem[mem[536900653] + 12];
            val_27 = mem[536900653] + 12;
            if(val_27 == 0)
            {
                    if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_26 = mem[536900653];
            }
            
                val_21 = mem[mem[536900653]];
                val_21 = val_26;
                val_27 = 536875575;
                val_27 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_21, method:  new IntPtr(1610685627));
                mem2[0] = val_27;
            }
            
            this.Vector3D = val_27;
            val_28 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_28 = 536900561;
            }
            
            val_29 = mem[536900653];
            val_30 = mem[mem[536900653] + 16];
            val_30 = mem[536900653] + 16;
            if(val_30 == 0)
            {
                    if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_29 = mem[536900653];
            }
            
                val_21 = mem[mem[536900653]];
                val_21 = val_29;
                val_30 = 536875643;
                val_30 = new System.Func<System.Single, System.Single, UnityEngine.Vector3>(object:  val_21, method:  new IntPtr(1610685629));
                mem2[0] = val_30;
            }
            
            this.VectorHV = val_30;
            val_31 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_31 = 536900561;
            }
            
            val_32 = mem[536900653];
            val_33 = mem[mem[536900653] + 20];
            val_33 = mem[536900653] + 20;
            if(val_33 != 0)
            {
                goto label_78;
            }
            
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_32 = mem[536900653];
            }
            
            val_21 = mem[mem[536900653]];
            val_21 = val_32;
            val_33 = 536875681;
            val_33 = new System.Func<System.Single, System.Single, System.Single, UnityEngine.Vector3>(object:  val_21, method:  new IntPtr(1610685631));
            mem2[0] = val_33;
            goto label_55;
            label_1:
            val_17 = 22719180;
            val_34 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_34 = 536900561;
            }
            
            val_35 = mem[536900653];
            val_36 = mem[mem[536900653] + 44];
            val_36 = mem[536900653] + 44;
            if(val_36 == 0)
            {
                    if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_35 = mem[536900653];
            }
            
                val_21 = mem[mem[536900653]];
                val_21 = val_35;
                val_36 = 536875575;
                val_36 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_21, method:  new IntPtr(1610685643));
                mem2[0] = val_36;
            }
            
            this.Vector3H = val_36;
            val_37 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_37 = 536900561;
            }
            
            val_38 = mem[536900653];
            val_39 = mem[mem[536900653] + 48];
            val_39 = mem[536900653] + 48;
            if(val_39 == 0)
            {
                    if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_38 = mem[536900653];
            }
            
                val_21 = mem[mem[536900653]];
                val_21 = val_38;
                val_39 = 536875575;
                val_39 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_21, method:  new IntPtr(1610685645));
                mem2[0] = val_39;
            }
            
            this.Vector3V = val_39;
            val_40 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_40 = 536900561;
            }
            
            val_41 = mem[536900653];
            val_42 = mem[mem[536900653] + 52];
            val_42 = mem[536900653] + 52;
            if(val_42 == 0)
            {
                    if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_41 = mem[536900653];
            }
            
                val_21 = mem[mem[536900653]];
                val_21 = val_41;
                val_42 = 536875575;
                val_42 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_21, method:  new IntPtr(1610685647));
                mem2[0] = val_42;
            }
            
            this.Vector3D = val_42;
            val_43 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_43 = 536900561;
            }
            
            val_44 = mem[536900653];
            val_45 = mem[mem[536900653] + 56];
            val_45 = mem[536900653] + 56;
            if(val_45 == 0)
            {
                    if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_44 = mem[536900653];
            }
            
                val_21 = mem[mem[536900653]];
                val_21 = val_44;
                val_45 = 536875643;
                val_45 = new System.Func<System.Single, System.Single, UnityEngine.Vector3>(object:  val_21, method:  new IntPtr(1610685649));
                mem2[0] = val_45;
            }
            
            this.VectorHV = val_45;
            val_46 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_46 = 536900561;
            }
            
            val_47 = mem[536900653];
            val_33 = mem[mem[536900653] + 60];
            val_33 = mem[536900653] + 60;
            if(val_33 != 0)
            {
                goto label_78;
            }
            
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_47 = mem[536900653];
            }
            
            val_21 = mem[mem[536900653]];
            val_21 = val_47;
            val_33 = 536875681;
            val_33 = new System.Func<System.Single, System.Single, System.Single, UnityEngine.Vector3>(object:  val_21, method:  new IntPtr(1610685651));
            mem2[0] = val_33;
            goto label_55;
            label_2:
            val_17 = 22719180;
            val_48 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_48 = 536900561;
            }
            
            val_49 = mem[536900653];
            val_50 = mem[mem[536900653] + 24];
            val_50 = mem[536900653] + 24;
            if(val_50 == 0)
            {
                    if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_49 = mem[536900653];
            }
            
                val_21 = mem[mem[536900653]];
                val_21 = val_49;
                val_50 = 536875575;
                val_50 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_21, method:  new IntPtr(1610685633));
                mem2[0] = val_50;
            }
            
            this.Vector3H = val_50;
            val_51 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_51 = 536900561;
            }
            
            val_52 = mem[536900653];
            val_53 = mem[mem[536900653] + 28];
            val_53 = mem[536900653] + 28;
            if(val_53 == 0)
            {
                    if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_52 = mem[536900653];
            }
            
                val_21 = mem[mem[536900653]];
                val_21 = val_52;
                val_53 = 536875575;
                val_53 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_21, method:  new IntPtr(1610685635));
                mem2[0] = val_53;
            }
            
            this.Vector3V = val_53;
            val_54 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_54 = 536900561;
            }
            
            val_55 = mem[536900653];
            val_56 = mem[mem[536900653] + 32];
            val_56 = mem[536900653] + 32;
            if(val_56 == 0)
            {
                    if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_55 = mem[536900653];
            }
            
                val_21 = mem[mem[536900653]];
                val_21 = val_55;
                val_56 = 536875575;
                val_56 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_21, method:  new IntPtr(1610685637));
                mem2[0] = val_56;
            }
            
            this.Vector3D = val_56;
            val_57 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_57 = 536900561;
            }
            
            val_58 = mem[536900653];
            val_59 = mem[mem[536900653] + 36];
            val_59 = mem[536900653] + 36;
            if(val_59 == 0)
            {
                    if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_58 = mem[536900653];
            }
            
                val_21 = mem[mem[536900653]];
                val_21 = val_58;
                val_59 = 536875643;
                val_59 = new System.Func<System.Single, System.Single, UnityEngine.Vector3>(object:  val_21, method:  new IntPtr(1610685639));
                mem2[0] = val_59;
            }
            
            this.VectorHV = val_59;
            val_60 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_60 = 536900561;
            }
            
            val_61 = mem[536900653];
            val_33 = mem[mem[536900653] + 40];
            val_33 = mem[536900653] + 40;
            if(val_33 != 0)
            {
                goto label_78;
            }
            
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_61 = mem[536900653];
            }
            
            val_21 = mem[mem[536900653]];
            val_21 = val_61;
            val_33 = 536875681;
            val_33 = new System.Func<System.Single, System.Single, System.Single, UnityEngine.Vector3>(object:  val_21, method:  new IntPtr(1610685641));
            mem2[0] = val_33;
            label_55:
            label_78:
            this.VectorHVD = val_33;
        }
        private UnityEngine.Vector3 GetTargetsWeightedMidPoint(ref System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.CameraTarget> targets)
        {
            float val_5;
            float val_6;
            float val_7;
            var val_17;
            var val_18;
            float val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            val_17 = 1152921509979778304;
            if((R2 + 12) == 0)
            {
                goto label_2;
            }
            
            val_18 = 0;
            val_19 = 0f;
            val_20 = 0;
            uint val_30 = 0;
            val_21 = 0;
            val_22 = 0;
            val_23 = 22713552;
            goto label_3;
            label_48:
            if((R2 + 12) <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_17 = R2 + 8;
            val_17 = val_17 + 0;
            if(((R2 + 8 + 0) + 16) == 0)
            {
                goto label_6;
            }
            
            if((R2 + 12) <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_18 = R2 + 8;
            val_18 = val_18 + 0;
            if(((R2 + 8 + 0) + 16 + 8) != 0)
            {
                goto label_12;
            }
            
            label_6:
            R2.RemoveAt(index:  0);
            goto label_14;
            label_12:
            if((R2 + 12) <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_19 = R2 + 8;
            val_19 = val_19 + 0;
            UnityEngine.Vector3 val_2 = TargetPosition;
            float val_3 = mem[1152921509979778500].Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R8, z = SB});
            if((R2 + 12) <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_20 = R2 + 8;
            val_20 = val_20 + 0;
            if((R2 + 12) <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_21 = R2 + 8;
            val_21 = val_21 + 0;
            if((R2 + 12) <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_22 = R2 + 8;
            val_17 = val_17;
            val_22 = val_22 + 0;
            UnityEngine.Vector3 val_4 = TargetPosition;
            float val_8 = mem[1152921509979778504].Invoke(arg:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_7});
            if((R2 + 12) <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_23 = R2 + 8;
            val_23 = val_23 + 0;
            val_23 = 22713552;
            if((R2 + 12) <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_24 = R2 + 8;
            val_24 = val_24 + 0;
            if((R2 + 12) <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_25 = R2 + 8;
            val_25 = val_25 + 0;
            if((R2 + 12) <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_26 = R2 + 8;
            val_26 = val_26 + 0;
            if((R2 + 12) <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_27 = R2 + 8;
            val_27 = val_27 + 0;
            if(((R2 + 8 + 0) + 16) > 0)
            {
                    val_20 = val_20 + 1;
            }
            
            var val_28 = mem[1152921509979778500];
            if((R2 + 12) <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_29 = R2 + 8;
            val_28 = val_28 + ((R2 + 8 + 0) + 16 + 20);
            float val_9 = mem[1152921509979778504] + ((R2 + 8 + 0) + 16 + 24);
            val_29 = val_29 + 0;
            val_30 = val_30 + ((R2 + 8 + 0) + 16 + 12);
            val_19 = val_19 + ((R2 + 8 + 0) + 16 + 16);
            if(((R2 + 8 + 0) + 16) > 0)
            {
                    val_29 = 0;
                val_29 = 1;
            }
            
            label_14:
            val_18 = 1;
            label_3:
            if(val_18 < (R2 + 12))
            {
                goto label_48;
            }
            
            float val_10 = 1f - val_19;
            val_10 = val_19 + val_10;
            if(val_18 < 0)
            {
                    val_19 = val_10;
            }
            
            float val_12 = val_30 + (1f - val_30);
            if(val_29 == 1)
            {
                    val_19 = val_19;
            }
            
            if(val_29 < 0)
            {
                    val_30 = val_12;
            }
            
            if(val_20 == 1)
            {
                    val_30 = val_30;
            }
            
            float val_13 = val_21 / val_19;
            if(val_20 > 1)
            {
                    val_21 = val_13;
            }
            
            val_12 = val_22 / val_30;
            if(val_20 > 1)
            {
                    val_22 = val_12;
            }
            
            UnityEngine.Vector3 val_14 = Invoke(arg1:  val_13, arg2:  val_4.y);
            mem[1152921509979746312] = val_7;
            this = val_5;
            return new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            label_2:
            UnityEngine.Transform val_15 = targets.transform;
            UnityEngine.Vector3 val_16 = localPosition;
            mem[1152921509979746312] = val_7;
            this = val_5;
            return new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        }
        private System.Collections.IEnumerator ApplyInfluencesTimedRoutine(System.Collections.Generic.IList<UnityEngine.Vector2> influences, float[] durations)
        {
            ProCamera2D.<ApplyInfluencesTimedRoutine>d__131 val_1 = 536900569;
            val_1 = new ProCamera2D.<ApplyInfluencesTimedRoutine>d__131(<>1__state:  0);
            if(val_1 != 0)
            {
                    mem[536900589] = this;
                mem[536900593] = influences;
            }
            else
            {
                    mem[20] = this;
                mem[24] = influences;
            }
            
            mem[536900585] = durations;
        }
        private System.Collections.IEnumerator ApplyInfluenceTimedRoutine(UnityEngine.Vector2 influence, float duration)
        {
            float val_2 = R3;
            ProCamera2D.<ApplyInfluenceTimedRoutine>d__132 val_1 = 536900567;
            val_1 = new ProCamera2D.<ApplyInfluenceTimedRoutine>d__132(<>1__state:  0);
            if(val_1 != 0)
            {
                    val_2 = val_1;
                mem[536900587] = this;
            }
            else
            {
                    mem[20] = this;
                mem[24] = influence.x;
                mem[28] = influence.y;
            }
            
            mem[536900583] = val_2;
        }
        private System.Collections.IEnumerator AdjustTargetInfluenceRoutine(Com.LuisPedroFonseca.ProCamera2D.CameraTarget cameraTarget, float influenceH, float influenceV, float duration, bool removeIfZeroInfluence = False)
        {
            var val_1;
            float val_2;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = this;
            ProCamera2D.<AdjustTargetInfluenceRoutine>d__133 val_3 = 536900565;
            val_3 = new ProCamera2D.<AdjustTargetInfluenceRoutine>d__133(<>1__state:  0);
            if(val_3 != 0)
            {
                    mem[536900585] = val_4;
                val_4 = val_3;
                mem[536900581] = cameraTarget;
                mem[536900589] = val_2;
                mem[536900593] = removeIfZeroInfluence;
                mem[536900597] = R3;
            }
            else
            {
                    mem[20] = val_4;
                mem[16] = cameraTarget;
                mem[28] = removeIfZeroInfluence;
                mem[32] = R3;
                mem[24] = val_2;
            }
            
            mem[536900601] = val_1;
        }
        private System.Collections.IEnumerator UpdateScreenSizeRoutine(float finalSize, float duration, Com.LuisPedroFonseca.ProCamera2D.EaseType easeType)
        {
            float val_2 = R2;
            ProCamera2D.<UpdateScreenSizeRoutine>d__134 val_1 = 536900573;
            val_1 = new ProCamera2D.<UpdateScreenSizeRoutine>d__134(<>1__state:  0);
            if(val_1 != 0)
            {
                    val_2 = val_1;
                mem[536900589] = this;
                mem[536900593] = val_2;
                mem[536900597] = easeType;
            }
            else
            {
                    mem[16] = this;
                mem[24] = easeType;
                mem[20] = val_2;
            }
            
            mem[536900601] = R3;
        }
        private System.Collections.IEnumerator DollyZoomRoutine(float finalFOV, float duration, Com.LuisPedroFonseca.ProCamera2D.EaseType easeType)
        {
            float val_2 = R2;
            ProCamera2D.<DollyZoomRoutine>d__135 val_1 = 536900571;
            val_1 = new ProCamera2D.<DollyZoomRoutine>d__135(<>1__state:  0);
            if(val_1 != 0)
            {
                    val_2 = val_1;
                mem[536900587] = this;
                mem[536900591] = val_2;
                mem[536900595] = easeType;
            }
            else
            {
                    mem[16] = this;
                mem[24] = easeType;
                mem[20] = val_2;
            }
            
            mem[536900599] = R3;
        }
        private void SetScreenSize(float newSize)
        {
            float val_7;
            float val_8;
            float val_9;
            var val_17;
            UnityEngine.Camera val_18;
            val_17 = R1;
            if(this.GameCamera.orthographic != false)
            {
                    val_18 = this.GameCamera;
                val_17 = R1;
                val_18.orthographicSize = UnityEngine.Mathf.Max(a:  newSize, b:  null);
            }
            else
            {
                    if(this.ZoomWithFOV != false)
            {
                    UnityEngine.Vector3 val_3 = localPosition;
                System.Func<UnityEngine.Vector3, System.Single> val_17 = this.Vector3D;
                float val_4 = val_17.Invoke(arg:  new UnityEngine.Vector3() {x = R6, y = R7, z = R8});
                val_17 = val_17 & (~2147483648);
                float val_18 = val_17;
                val_18 = val_17 / val_18;
                float val_19 = val_18;
                val_19 = val_19 + val_19;
                val_19 = val_19 * 57.29578f;
                val_18 = val_19;
                this.GameCamera.fieldOfView = UnityEngine.Mathf.Clamp(value:  val_19, min:  val_3.y, max:  57.29578f);
            }
            else
            {
                    UnityEngine.Vector3 val_6 = localPosition;
                float val_10 = this.Vector3H.Invoke(arg:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9});
                UnityEngine.Vector3 val_11 = localPosition;
                float val_12 = this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R6, z = R8});
                float val_13 = this.GameCamera.fieldOfView;
                float val_20 = 0.5f;
                val_20 = this.GameCamera * val_20;
                val_20 = val_20 * 0.01745329f;
                val_20 = val_17 / val_20;
                val_20 = val_20 * this._originalCameraDepthSign;
                UnityEngine.Vector3 val_14 = Invoke(arg1:  val_20, arg2:  val_11.y, arg3:  0.01745329f);
                this._transform.localPosition = new UnityEngine.Vector3() {x = R5, y = R6, z = R7};
            }
            
            }
            
            float val_15 = this.GameCamera.aspect;
            float val_16 = val_17 + val_17;
            UnityEngine.Camera val_21 = this.GameCamera;
            val_21 = val_16 * val_21;
            this.<ScreenSizeInWorldCoordinates>k__BackingField = val_21;
            mem[1152921509980582140] = val_16;
            if(this.OnCameraResize == 0)
            {
                    return;
            }
            
            this.OnCameraResize.Invoke(obj:  new UnityEngine.Vector2() {x = mem[this.<ScreenSizeInWorldCoordinates>k__BackingField + (0)], y = mem[this.<ScreenSizeInWorldCoordinates>k__BackingField + (4)]});
        }
        private float GetCameraDistanceForFOV(float fov, float cameraHeight)
        {
            float val_1 = 0.5f;
            val_1 = R1 * val_1;
            val_1 = val_1 * 0.01745329f;
            var val_2 = val_1;
            val_2 = val_2 + val_2;
            val_2 = R2 / val_2;
            return (float)val_2;
        }
        public void AddPreMover(Com.LuisPedroFonseca.ProCamera2D.IPreMover mover)
        {
            this._preMovers.Add(item:  mover);
        }
        public void RemovePreMover(Com.LuisPedroFonseca.ProCamera2D.IPreMover mover)
        {
            bool val_1 = this._preMovers.Remove(item:  mover);
        }
        public void SortPreMovers()
        {
            var val_4;
            object val_5;
            System.Func<System.String, System.Int32> val_6;
            val_4 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_4 = 536900561;
            }
            
            val_5 = mem[536900653];
            val_6 = mem[mem[536900653] + 64];
            val_6 = mem[536900653] + 64;
            if(val_6 == 0)
            {
                    if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_5 = mem[536900653];
            }
            
                val_6 = 536875431;
                val_6 = new System.Func<System.String, System.Int32>(object:  val_5, method:  new IntPtr(1610685653));
                mem2[0] = val_6;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_2 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  this._preMovers, keySelector:  536875431);
            System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<UnityEngine.Purchasing.Default.WinProductDescription>(source:  this._preMovers);
            this._preMovers = this._preMovers;
        }
        public void AddPositionDeltaChanger(Com.LuisPedroFonseca.ProCamera2D.IPositionDeltaChanger changer)
        {
            this._positionDeltaChangers.Add(item:  changer);
        }
        public void RemovePositionDeltaChanger(Com.LuisPedroFonseca.ProCamera2D.IPositionDeltaChanger changer)
        {
            bool val_1 = this._positionDeltaChangers.Remove(item:  changer);
        }
        public void SortPositionDeltaChangers()
        {
            var val_4;
            object val_5;
            System.Func<System.String, System.Int32> val_6;
            val_4 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_4 = 536900561;
            }
            
            val_5 = mem[536900653];
            val_6 = mem[mem[536900653] + 68];
            val_6 = mem[536900653] + 68;
            if(val_6 == 0)
            {
                    if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_5 = mem[536900653];
            }
            
                val_6 = 536875419;
                val_6 = new System.Func<System.String, System.Int32>(object:  val_5, method:  new IntPtr(1610685655));
                mem2[0] = val_6;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_2 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  this._positionDeltaChangers, keySelector:  536875419);
            System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<UnityEngine.Purchasing.Default.WinProductDescription>(source:  this._positionDeltaChangers);
            this._positionDeltaChangers = this._positionDeltaChangers;
        }
        public void AddPositionOverrider(Com.LuisPedroFonseca.ProCamera2D.IPositionOverrider overrider)
        {
            this._positionOverriders.Add(item:  overrider);
        }
        public void RemovePositionOverrider(Com.LuisPedroFonseca.ProCamera2D.IPositionOverrider overrider)
        {
            bool val_1 = this._positionOverriders.Remove(item:  overrider);
        }
        public void SortPositionOverriders()
        {
            var val_4;
            object val_5;
            System.Func<System.String, System.Int32> val_6;
            val_4 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_4 = 536900561;
            }
            
            val_5 = mem[536900653];
            val_6 = mem[mem[536900653] + 72];
            val_6 = mem[536900653] + 72;
            if(val_6 == 0)
            {
                    if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_5 = mem[536900653];
            }
            
                val_6 = 536875423;
                val_6 = new System.Func<System.String, System.Int32>(object:  val_5, method:  new IntPtr(1610685657));
                mem2[0] = val_6;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_2 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  this._positionOverriders, keySelector:  536875423);
            System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<UnityEngine.Purchasing.Default.WinProductDescription>(source:  this._positionOverriders);
            this._positionOverriders = this._positionOverriders;
        }
        public void AddSizeDeltaChanger(Com.LuisPedroFonseca.ProCamera2D.ISizeDeltaChanger changer)
        {
            this._sizeDeltaChangers.Add(item:  changer);
        }
        public void RemoveSizeDeltaChanger(Com.LuisPedroFonseca.ProCamera2D.ISizeDeltaChanger changer)
        {
            bool val_1 = this._sizeDeltaChangers.Remove(item:  changer);
        }
        public void SortSizeDeltaChangers()
        {
            var val_4;
            object val_5;
            System.Func<System.String, System.Int32> val_6;
            val_4 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_4 = 536900561;
            }
            
            val_5 = mem[536900653];
            val_6 = mem[mem[536900653] + 76];
            val_6 = mem[536900653] + 76;
            if(val_6 == 0)
            {
                    if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_5 = mem[536900653];
            }
            
                val_6 = 536875435;
                val_6 = new System.Func<System.String, System.Int32>(object:  val_5, method:  new IntPtr(1610685659));
                mem2[0] = val_6;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_2 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  this._sizeDeltaChangers, keySelector:  536875435);
            System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<UnityEngine.Purchasing.Default.WinProductDescription>(source:  this._sizeDeltaChangers);
            this._sizeDeltaChangers = this._sizeDeltaChangers;
        }
        public void AddSizeOverrider(Com.LuisPedroFonseca.ProCamera2D.ISizeOverrider overrider)
        {
            this._sizeOverriders.Add(item:  overrider);
        }
        public void RemoveSizeOverrider(Com.LuisPedroFonseca.ProCamera2D.ISizeOverrider overrider)
        {
            bool val_1 = this._sizeOverriders.Remove(item:  overrider);
        }
        public void SortSizeOverriders()
        {
            var val_4;
            object val_5;
            System.Func<System.String, System.Int32> val_6;
            val_4 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_4 = 536900561;
            }
            
            val_5 = mem[536900653];
            val_6 = mem[mem[536900653] + 80];
            val_6 = mem[536900653] + 80;
            if(val_6 == 0)
            {
                    if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_5 = mem[536900653];
            }
            
                val_6 = 536875439;
                val_6 = new System.Func<System.String, System.Int32>(object:  val_5, method:  new IntPtr(1610685661));
                mem2[0] = val_6;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_2 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  this._sizeOverriders, keySelector:  536875439);
            System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<UnityEngine.Purchasing.Default.WinProductDescription>(source:  this._sizeOverriders);
            this._sizeOverriders = this._sizeOverriders;
        }
        public void AddPostMover(Com.LuisPedroFonseca.ProCamera2D.IPostMover mover)
        {
            this._postMovers.Add(item:  mover);
        }
        public void RemovePostMover(Com.LuisPedroFonseca.ProCamera2D.IPostMover mover)
        {
            bool val_1 = this._postMovers.Remove(item:  mover);
        }
        public void SortPostMovers()
        {
            var val_4;
            object val_5;
            System.Func<System.String, System.Int32> val_6;
            val_4 = 536900561;
            if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_4 = 536900561;
            }
            
            val_5 = mem[536900653];
            val_6 = mem[mem[536900653] + 84];
            val_6 = mem[536900653] + 84;
            if(val_6 == 0)
            {
                    if(((mem[536900748] & true) == 0) && (mem[536900677] == 0))
            {
                    val_5 = mem[536900653];
            }
            
                val_6 = 536875427;
                val_6 = new System.Func<System.String, System.Int32>(object:  val_5, method:  new IntPtr(1610685663));
                mem2[0] = val_6;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_2 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  this._postMovers, keySelector:  536875427);
            System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<UnityEngine.Purchasing.Default.WinProductDescription>(source:  this._postMovers);
            this._postMovers = this._postMovers;
        }
        public void OnBeforeSerialize()
        {
        
        }
        public void OnAfterDeserialize()
        {
            this.ResetAxisFunctions();
        }
        public ProCamera2D()
        {
            536877775 = new System.Collections.Generic.List<Page>();
            this.CameraTargets = 536877775;
            this.HorizontalFollowSmoothness = 0.15f;
            this.FollowHorizontal = true;
            this.FollowVertical = true;
            this.VerticalFollowSmoothness = 0.15f;
            this.IsRelativeOffset = true;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this._influences = 536878517;
            UnityEngine.WaitForFixedUpdate val_4 = 536896845;
            val_4 = new UnityEngine.WaitForFixedUpdate();
            this._waitForFixedUpdate = val_4;
            536877953 = new System.Collections.Generic.List<Page>();
            this._preMovers = 536877953;
            536877941 = new System.Collections.Generic.List<Page>();
            this._positionDeltaChangers = 536877941;
            536877945 = new System.Collections.Generic.List<Page>();
            this._positionOverriders = 536877945;
            536877959 = new System.Collections.Generic.List<Page>();
            this._sizeDeltaChangers = 536877959;
            536877963 = new System.Collections.Generic.List<Page>();
            this._sizeOverriders = 536877963;
            536877949 = new System.Collections.Generic.List<Page>();
            this._postMovers = 536877949;
        }
        private static ProCamera2D()
        {
            536896711 = new System.Version(version:  -1610611175);
            mem2[0] = 536896711;
        }
    
    }

}
