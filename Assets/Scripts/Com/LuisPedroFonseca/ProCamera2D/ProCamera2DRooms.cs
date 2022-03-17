using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DRooms : BasePC2D, IPositionOverrider, ISizeOverrider
    {
        // Fields
        public const string ExtensionName = "Rooms";
        private int _currentRoomIndex;
        private int _previousRoomIndex;
        private float <OriginalSize>k__BackingField;
        public System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.Room> Rooms;
        public float UpdateInterval;
        public bool UseTargetsMidPoint;
        public UnityEngine.Transform TriggerTarget;
        public bool TransitionInstanlyOnStart;
        public bool RestoreOnRoomExit;
        public float RestoreDuration;
        public Com.LuisPedroFonseca.ProCamera2D.EaseType RestoreEaseType;
        public bool AutomaticRoomActivation;
        public bool UseRelativePosition;
        public Com.LuisPedroFonseca.ProCamera2D.RoomEvent OnStartedTransition;
        public Com.LuisPedroFonseca.ProCamera2D.RoomEvent OnFinishedTransition;
        public UnityEngine.Events.UnityEvent OnExitedAllRooms;
        private Com.LuisPedroFonseca.ProCamera2D.ProCamera2DNumericBoundaries _numericBoundaries;
        private Com.LuisPedroFonseca.ProCamera2D.NumericBoundariesSettings _defaultNumericBoundariesSettings;
        private bool _transitioning;
        private UnityEngine.Vector3 _newPos;
        private float _newSize;
        private UnityEngine.Coroutine _transitionRoutine;
        private int _currentRoomID;
        private int _poOrder;
        private int _soOrder;
        
        // Properties
        public int CurrentRoomIndex { get; }
        public int PreviousRoomIndex { get; }
        public Com.LuisPedroFonseca.ProCamera2D.Room CurrentRoom { get; }
        public float OriginalSize { get; set; }
        public int POOrder { get; set; }
        public int SOOrder { get; set; }
        
        // Methods
        public int get_CurrentRoomIndex()
        {
            return (int)this._currentRoomIndex;
        }
        public int get_PreviousRoomIndex()
        {
            return (int)this._previousRoomIndex;
        }
        public Com.LuisPedroFonseca.ProCamera2D.Room get_CurrentRoom()
        {
            var val_1 = 0;
            if(this._currentRoomIndex < 0)
            {
                    return;
            }
            
            if(this._currentRoomIndex >= true)
            {
                    return;
            }
            
            if(true <= this._currentRoomIndex)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (this._currentRoomIndex << 2);
            val_1 = mem[(0 + (this._currentRoomIndex) << 2) + 16];
            val_1 = (0 + (this._currentRoomIndex) << 2) + 16;
        }
        public float get_OriginalSize()
        {
            return (float)S0;
        }
        private void set_OriginalSize(float value)
        {
            this.<OriginalSize>k__BackingField = ;
        }
        protected override void Awake()
        {
            this.Awake();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            UnityEngine.Transform val_2 = this.GetComponent<UnityEngine.Transform>();
            this._numericBoundaries = this;
            bool val_6 = mem[1152921509936750084];
            val_6 = val_6 | (mem[1152921509936750085] << 8);
            mem[1152921509936750148] = mem[1152921509936750100];
            mem[1152921509936750152] = mem[1152921509936750108];
            mem[1152921509936750156] = mem[1152921509936750112];
            mem[1152921509936750160] = mem[1152921509936750120];
            mem[1152921509936750164] = mem[1152921509936750124];
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this.ProCamera2D;
            float val_7 = 0.5f;
            val_7 = this.RestoreDuration * val_7;
            this.<OriginalSize>k__BackingField = val_7;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = this.ProCamera2D;
            this.AddPositionOverrider(overrider:  1034935760);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_5 = this.ProCamera2D;
            this.AddSizeOverrider(overrider:  1034935760);
        }
        private void Start()
        {
            var val_12;
            int val_11 = this.GetInstanceID();
            List.Enumerator<T> val_2 = GetEnumerator();
            val_12 = 22728828;
            goto label_2;
            label_4:
            mem2[0] = val_11;
            val_11 = val_11 + 1;
            label_2:
            if(MoveNext() == true)
            {
                goto label_4;
            }
            
            Dispose();
            System.Collections.IEnumerator val_5 = this.TestRoomRoutine();
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  1035060048);
            if(this.TransitionInstanlyOnStart == false)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_7 = this.ProCamera2D;
            if(this.UseTargetsMidPoint != true)
            {
                    if(this.TriggerTarget != 0)
            {
                    UnityEngine.Vector3 val_9 = position;
            }
            
            }
            
            int val_10 = this.ComputeCurrentRoom(targetPos:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7});
            if(val_10 == 1)
            {
                    return;
            }
            
            this.EnterRoom(roomIndex:  val_10, useTransition:  false, forceEntrance:  false);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if(1035184336 == 0)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = R4.ProCamera2D;
            R4.RemovePositionOverrider(overrider:  R4);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = R4.ProCamera2D;
            R4.RemoveSizeOverrider(overrider:  R4);
        }
        public UnityEngine.Vector3 OverridePosition(float deltaTime, UnityEngine.Vector3 originalPosition)
        {
            var val_2;
            var val_3;
            bool val_1 = originalPosition.x.enabled;
            if(val_1 == true)
            {
                    val_1 = mem[originalPosition.x + 136];
                val_1 = originalPosition.x + 136;
            }
            
            if(val_1 == 0)
            {
                    this = originalPosition.z;
                mem[1152921509937110612] = val_3;
                mem[1152921509937110616] = val_2;
                return new UnityEngine.Vector3() {x = deltaTime};
            }
            
            mem[1152921509937110616] = originalPosition.x + 148;
            this = originalPosition.x + 140;
            return new UnityEngine.Vector3() {x = deltaTime};
        }
        public int get_POOrder()
        {
            return (int)this._poOrder;
        }
        public void set_POOrder(int value)
        {
            this._poOrder = value;
        }
        public float OverrideSize(float deltaTime, float originalSize)
        {
            bool val_1 = this.enabled;
            if(val_1 == true)
            {
                    val_1 = this._transitioning;
                R2 = this._newSize;
            }
            
            return R2;
        }
        public int get_SOOrder()
        {
            return (int)this._soOrder;
        }
        public void set_SOOrder(int value)
        {
            this._soOrder = value;
        }
        public void TestRoom()
        {
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if(this.UseTargetsMidPoint != true)
            {
                    if(this.TriggerTarget != 0)
            {
                    UnityEngine.Vector3 val_3 = position;
            }
            
            }
            
            int val_4 = this.ComputeCurrentRoom(targetPos:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7});
            if(val_4 != 1)
            {
                    if(this._currentRoomIndex == val_4)
            {
                    return;
            }
            
                this.EnterRoom(roomIndex:  val_4, useTransition:  true, forceEntrance:  false);
                return;
            }
            
            if(this._currentRoomIndex != 1)
            {
                    this._currentRoomIndex = this;
                this.ExitRoom();
            }
        
        }
        public int ComputeCurrentRoom(UnityEngine.Vector3 targetPos)
        {
            var val_3;
            var val_6;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DRooms val_13;
            float val_14;
            var val_15;
            var val_16;
            var val_19;
            val_13 = this;
            val_14 = targetPos.y;
            val_15 = 4;
            goto label_1;
            label_21:
            if(0 <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_1 = static_value_0028000F.x;
            val_16 = 0;
            if(this.UseRelativePosition != false)
            {
                    UnityEngine.Vector3 val_2 = position;
                val_16 = val_3;
            }
            
            if(1036105148 <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_4 = static_value_0028000F.y;
            val_19 = 0;
            if(this.UseRelativePosition != false)
            {
                    UnityEngine.Vector3 val_5 = position;
                val_19 = val_6;
            }
            
            if(1036105148 <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_7 = static_value_0028000F.width;
            if(2621455 <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_8 = static_value_0028000F.height;
            val_16 = 2621455 + val_16;
            val_14 = val_14;
            float val_9 = val_14.Invoke(arg:  new UnityEngine.Vector3() {x = targetPos.x, y = val_14, z = targetPos.z});
            float val_10 = this.Invoke(arg:  new UnityEngine.Vector3() {x = targetPos.x, y = val_14, z = targetPos.z});
            if((Com.LuisPedroFonseca.ProCamera2D.Utils.IsInsideRectangle(x:  2621455 + val_19, y:  val_5.y, width:  val_5.z, height:  null, pointX:  null, pointY:  null)) == true)
            {
                    0 = ???;
            }
            
            val_15 = 5;
            val_13 = val_13;
            label_1:
            if((val_15 - 4) < (???))
            {
                goto label_21;
            }
            
            return (int)0;
        }
        public void EnterRoom(int roomIndex, bool useTransition = True, bool forceEntrance = False)
        {
            int val_4;
            System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.Room> val_5;
            val_4 = forceEntrance;
            bool val_4 = true;
            if(roomIndex >= 0)
            {
                    val_4 = val_4 - 1;
                if(val_4 >= roomIndex)
            {
                    if(val_4 != true)
            {
                    val_5 = this.Rooms;
                if(val_4 <= roomIndex)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_5 = val_5 + (roomIndex << 2);
                if(((0 + (roomIndex) << 2) + 16 + 44) == this._currentRoomID)
            {
                    return;
            }
            
            }
            
                this._currentRoomIndex = roomIndex;
                this._previousRoomIndex = this._currentRoomIndex;
                if(this._currentRoomIndex <= roomIndex)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_6 = val_6 + (roomIndex << 2);
                val_5 = this.Rooms;
                val_4 = this._currentRoomIndex;
                this._currentRoomID = (0 + (roomIndex) << 2) + 16 + 44;
                if(((0 + (roomIndex) << 2) + 16 + 44) <= val_4)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_7 = val_7 + (val_4 << 2);
                this.TransitionToRoom(room:  (0 + (this._currentRoomIndex) << 2) + 16, useTransition:  useTransition);
                if(this.OnStartedTransition == 0)
            {
                    return;
            }
            
                this.OnStartedTransition.Invoke(arg0:  roomIndex, arg1:  this._previousRoomIndex);
                return;
            }
            
            }
            
            string val_1 = roomIndex.ToString();
            string val_2 = 22783004 + 1036258124;
            22710780 = new System.Exception(message:  22783004);
        }
        public void EnterRoom(string roomID, bool useTransition = True, bool forceEntrance = False)
        {
            536900603 = new ProCamera2DRooms.<>c__DisplayClass49_0();
            mem[536900611] = roomID;
            536879241 = new System.Predicate<Page>(object:  536900603, method:  new IntPtr(1610684997));
            int val_3 = this.Rooms.FindIndex(match:  536879241);
            if(val_3 > 1)
            {
                    this.EnterRoom(roomIndex:  val_3, useTransition:  useTransition, forceEntrance:  forceEntrance);
                return;
            }
            
            string val_4 = 22783000 + mem[536900611];
            22710780 = new System.Exception(message:  22783000);
        }
        public void ExitRoom()
        {
            int val_3;
            this._currentRoomID = 0;
            this._currentRoomIndex = 0;
            if(this.RestoreOnRoomExit != false)
            {
                    if(this.OnStartedTransition != 0)
            {
                    val_3 = this._previousRoomIndex;
                this.OnStartedTransition.Invoke(arg0:  0, arg1:  val_3);
            }
            
                if(this._transitionRoutine != 0)
            {
                    val_3 = 0;
                this.StopCoroutine(routine:  this._transitionRoutine);
            }
            
                System.Collections.IEnumerator val_1 = this.TransitionRoutine(numericBoundariesSettings:  new Com.LuisPedroFonseca.ProCamera2D.NumericBoundariesSettings() {UseNumericBoundaries = mem[this._defaultNumericBoundariesSettings + (0)]>>0&0xFF, UseTopBoundary = mem[this._defaultNumericBoundariesSettings + (0)]>>8&0xFF, TopBoundary = mem[this._defaultNumericBoundariesSettings + (4)], UseBottomBoundary = mem[this._defaultNumericBoundariesSettings + (8)]>>0&0xFF, BottomBoundary = mem[this._defaultNumericBoundariesSettings + (12)], UseLeftBoundary = false, UseRightBoundary = false}, targetSize:  this.<OriginalSize>k__BackingField, transitionDuration:  null, transitionEaseType:  this.<OriginalSize>k__BackingField);
                UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1036547408);
                this._transitionRoutine = this;
            }
            
            if(this.OnExitedAllRooms == 0)
            {
                    return;
            }
            
            this.OnExitedAllRooms.Invoke();
        }
        public void AddRoom(float roomX, float roomY, float roomWidth, float roomHeight, float transitionDuration = 1, Com.LuisPedroFonseca.ProCamera2D.EaseType transitionEaseType = 0, bool scaleToFit = False, bool zoom = False, float zoomScale = 1.5, string id = "")
        {
            var val_1;
            float val_3;
            float val_4;
            var val_6;
            var val_7;
            var val_8;
            Com.LuisPedroFonseca.ProCamera2D.Room val_2 = 536892987;
            val_2 = new Com.LuisPedroFonseca.ProCamera2D.Room();
            mem[536892995] = val_1;
            UnityEngine.Rect val_5 = new UnityEngine.Rect(x:  roomX, y:  roomY, width:  roomWidth, height:  roomHeight);
            if(val_2 != 0)
            {
                    mem[536893015] = val_4;
                mem[536893019] = val_6;
                mem[536893023] = val_7;
                mem[536893024] = val_8;
                var val_9 = val_2 + 12;
            }
            else
            {
                    var val_10 = val_2 + 12;
                mem[28] = val_4;
                mem[32] = val_6;
                mem[36] = val_7;
                mem[536893024] = val_8;
            }
            
            mem[536893027] = val_3;
            this.Rooms.Add(item:  536892987);
        }
        public void RemoveRoom(string roomName)
        {
            536900605 = new ProCamera2DRooms.<>c__DisplayClass52_0();
            mem[536900613] = roomName;
            536879241 = new System.Predicate<Page>(object:  536900605, method:  new IntPtr(1610685001));
            Com.LuisPedroFonseca.ProCamera2D.Room val_3 = this.Rooms.Find(match:  536879241);
            if(this.Rooms != 0)
            {
                    bool val_4 = this.Rooms.Remove(item:  this.Rooms);
                return;
            }
            
            string val_5 = mem[536900613] + -1610612323(-1610612323);
            UnityEngine.Debug.LogWarning(message:  mem[536900613]);
        }
        public void SetDefaultNumericBoundariesSettings(Com.LuisPedroFonseca.ProCamera2D.NumericBoundariesSettings settings)
        {
            mem[1152921509938763344] = settings.UseRightBoundary;
            mem[1152921509938763348] = settings.RightBoundary;
        }
        public Com.LuisPedroFonseca.ProCamera2D.Room GetRoom(string roomID)
        {
            536900607 = new ProCamera2DRooms.<>c__DisplayClass54_0();
            mem[536900615] = roomID;
            536879241 = new System.Predicate<Page>(object:  536900607, method:  new IntPtr(1610685005));
            if(this.Rooms != 0)
            {
                    return this.Rooms.Find(match:  536879241);
            }
            
            return this.Rooms.Find(match:  536879241);
        }
        public float GetCameraSizeForRoom(UnityEngine.Rect roomRect)
        {
            var val_10;
            float val_1 = roomRect.m_XMin.width;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.ProCamera2D;
            float val_3 = roomRect.m_XMin.height;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = this.ProCamera2D;
            float val_10 = this.RestoreDuration;
            bool val_5 = 1037177288 / this.TransitionInstanlyOnStart;
            val_10 = 1037177288 / val_10;
            if(this < 0)
            {
                    float val_6 = roomRect.m_XMin.width;
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_7 = this.ProCamera2D;
                float val_8 = this.aspect;
                val_10 = 1037177288 / 1037189328;
            }
            else
            {
                    float val_9 = roomRect.m_XMin.height;
                val_10 = 1037177288;
            }
            
            val_10 = val_10 * 0.5f;
            return (float)val_10;
        }
        private System.Collections.IEnumerator TestRoomRoutine()
        {
            536900609 = new ProCamera2DRooms.<TestRoomRoutine>d__56(<>1__state:  0);
            mem[536900625] = this;
        }
        private void TransitionToRoom(Com.LuisPedroFonseca.ProCamera2D.Room room, bool useTransition = True)
        {
            var val_3;
            var val_10;
            var val_20;
            float val_22;
            float val_23;
            float val_24;
            float val_25;
            float val_26;
            bool val_27;
            var val_28;
            var val_29;
            if(this._transitionRoutine != 0)
            {
                    val_20 = 0;
                this.StopCoroutine(routine:  this._transitionRoutine);
            }
            
            float val_1 = room.Dimensions.y;
            if(this.UseRelativePosition != false)
            {
                    val_20 = 0;
                UnityEngine.Vector3 val_2 = position;
                val_22 = val_3;
            }
            else
            {
                    val_22 = 0f;
            }
            
            float val_4 = room.Dimensions.height;
            val_22 = room.Dimensions + val_22;
            float val_5 = room.Dimensions.y;
            if(this.UseRelativePosition != false)
            {
                    val_20 = 0;
                UnityEngine.Vector3 val_6 = position;
                val_23 = val_3;
            }
            else
            {
                    val_23 = 0f;
            }
            
            float val_7 = room.Dimensions.height;
            val_23 = room.Dimensions + val_23;
            float val_8 = room.Dimensions.x;
            if(this.UseRelativePosition != false)
            {
                    val_20 = 0;
                UnityEngine.Vector3 val_9 = position;
                val_24 = val_10;
            }
            else
            {
                    val_24 = 0f;
            }
            
            float val_11 = room.Dimensions.width;
            val_24 = room.Dimensions + val_24;
            float val_12 = room.Dimensions.x;
            if(this.UseRelativePosition != false)
            {
                    val_20 = 0;
                UnityEngine.Vector3 val_13 = position;
                val_25 = val_10;
            }
            else
            {
                    val_25 = 0f;
            }
            
            float val_14 = room.Dimensions.width;
            val_25 = room.Dimensions + val_25;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_15 = this.ProCamera2D;
            float val_16 = this.GetCameraSizeForRoom(roomRect:  new UnityEngine.Rect() {m_XMin = mem[room.Dimensions + (0)], m_YMin = mem[room.Dimensions + (4)], m_Width = mem[room.Dimensions + (8)], m_Height = this});
            if(room.ScaleCameraToFit == false)
            {
                goto label_24;
            }
            
            val_26 = 1037425616;
            val_27 = useTransition;
            val_28 = 1;
            val_29 = 257;
            goto label_27;
            label_24:
            val_28 = 1;
            val_27 = useTransition;
            val_29 = 257;
            if(room.Zoom == false)
            {
                goto label_26;
            }
            
            float val_20 = room.ZoomScale;
            val_20 = (this.<OriginalSize>k__BackingField) * val_20;
            if(room.Zoom <= false)
            {
                goto label_27;
            }
            
            label_26:
            float val_17 = this.RestoreDuration * 0.5f;
            label_27:
            if(val_27 == true)
            {
                    1037425616 = room.TransitionDuration;
            }
            
            if(val_27 == false)
            {
                    1037425616 = 0f;
            }
            
            System.Collections.IEnumerator val_18 = this.TransitionRoutine(numericBoundariesSettings:  new Com.LuisPedroFonseca.ProCamera2D.NumericBoundariesSettings() {UseNumericBoundaries = true, UseTopBoundary = true, TopBoundary = val_22, UseBottomBoundary = true, BottomBoundary = val_23, UseLeftBoundary = true, LeftBoundary = val_24, UseRightBoundary = true, RightBoundary = val_25}, targetSize:  val_26 = 1037425616, transitionDuration:  null, transitionEaseType:  this);
            UnityEngine.Coroutine val_19 = this.StartCoroutine(routine:  1037425616);
            this._transitionRoutine = this;
        }
        private System.Collections.IEnumerator TransitionRoutine(Com.LuisPedroFonseca.ProCamera2D.NumericBoundariesSettings numericBoundariesSettings, float targetSize, float transitionDuration = 1, Com.LuisPedroFonseca.ProCamera2D.EaseType transitionEaseType = 1)
        {
            var val_3;
            float val_4;
            ProCamera2DRooms.<TransitionRoutine>d__58 val_1 = 536900611;
            val_1 = new ProCamera2DRooms.<TransitionRoutine>d__58(<>1__state:  0);
            if(val_1 != 0)
            {
                    mem[536900627] = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            var val_2 = val_1 + 36;
            mem[536900643] = numericBoundariesSettings.UseNumericBoundaries;
            mem[536900644] = numericBoundariesSettings.UseTopBoundary;
            mem[536900663] = numericBoundariesSettings.LeftBoundary;
            mem[536900667] = numericBoundariesSettings.UseRightBoundary;
            mem[536900671] = numericBoundariesSettings.RightBoundary;
            if(val_1 != 0)
            {
                    mem[536900631] = val_4;
                mem[536900635] = transitionEaseType;
            }
            else
            {
                    mem[24] = transitionEaseType;
                mem[20] = val_4;
            }
            
            mem[536900639] = val_3;
        }
        private void LimitToNumericBoundaries(ref float horizontalPos, ref float verticalPos, float halfCameraWidth, float halfCameraHeight, Com.LuisPedroFonseca.ProCamera2D.NumericBoundariesSettings numericBoundaries)
        {
            var val_2;
            var val_3;
            float val_7;
            float val_8;
            if((numericBoundaries.UseRightBoundary & true) != 0)
            {
                goto label_1;
            }
            
            float val_1 = horizontalPos - numericBoundaries.UseNumericBoundaries;
            if(numericBoundaries.UseRightBoundary >= 0)
            {
                goto label_1;
            }
            
            val_7 = numericBoundaries.RightBoundary + numericBoundaries.UseNumericBoundaries;
            goto label_2;
            label_1:
            if((val_2 & 255) != 0)
            {
                goto label_4;
            }
            
            float val_4 = horizontalPos + numericBoundaries.UseNumericBoundaries;
            if(val_2 <= 255)
            {
                goto label_4;
            }
            
            val_7 = val_3 - numericBoundaries.UseNumericBoundaries;
            label_2:
            horizontalPos = val_7;
            label_4:
            if((numericBoundaries.UseLeftBoundary & true) != 0)
            {
                goto label_6;
            }
            
            float val_5 = verticalPos - numericBoundaries.TopBoundary;
            if(numericBoundaries.UseLeftBoundary >= 0)
            {
                goto label_6;
            }
            
            val_8 = numericBoundaries.LeftBoundary + numericBoundaries.TopBoundary;
            goto label_7;
            label_6:
            if((255 & (numericBoundaries.UseBottomBoundary >> 8)) != 0)
            {
                    return;
            }
            
            float val_6 = verticalPos + numericBoundaries.TopBoundary;
            if(255 <= (numericBoundaries.UseBottomBoundary >> 8))
            {
                    return;
            }
            
            val_8 = numericBoundaries.BottomBoundary - numericBoundaries.TopBoundary;
            label_7:
            verticalPos = val_8;
        }
        public ProCamera2DRooms()
        {
            this._currentRoomIndex = 0;
            this._previousRoomIndex = 0;
            536878257 = new System.Collections.Generic.List<Page>();
            this.Rooms = 536878257;
            this.UseTargetsMidPoint = true;
            this.UpdateInterval = 0.1f;
            this.TransitionInstanlyOnStart = true;
            this.RestoreDuration = 1f;
            this.AutomaticRoomActivation = true;
            this._currentRoomID = 0;
            this._poOrder = 1001;
            this._soOrder = 3001;
        }
    
    }

}
