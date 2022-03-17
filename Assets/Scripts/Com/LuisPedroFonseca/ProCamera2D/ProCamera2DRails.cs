using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DRails : BasePC2D, IPreMover
    {
        // Fields
        public static string ExtensionName;
        public System.Collections.Generic.List<UnityEngine.Vector3> RailNodes;
        public Com.LuisPedroFonseca.ProCamera2D.FollowMode FollowMode;
        public System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.CameraTarget> CameraTargets;
        private System.Collections.Generic.Dictionary<Com.LuisPedroFonseca.ProCamera2D.CameraTarget, UnityEngine.Transform> _cameraTargetsOnRails;
        private System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.CameraTarget> _tempCameraTargets;
        private Com.LuisPedroFonseca.ProCamera2D.KDTree _kdTree;
        private int _prmOrder;
        
        // Properties
        public int PrMOrder { get; set; }
        
        // Methods
        protected override void Awake()
        {
            var val_10;
            var val_11;
            System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.CameraTarget> val_12;
            this.Awake();
            T[] val_1 = this.RailNodes.ToArray();
            Com.LuisPedroFonseca.ProCamera2D.KDTree val_2 = Com.LuisPedroFonseca.ProCamera2D.KDTree.MakeFromPoints(points:  this.RailNodes);
            this._kdTree = this.RailNodes;
            val_10 = 4;
            goto label_2;
            label_18:
            val_12 = this.CameraTargets;
            if(val_12 != 0)
            {
                
            }
            else
            {
                    val_12 = 0;
            }
            
            if(SL >= R6)
            {
                goto label_5;
            }
            
            label_19:
            if(1026918544 <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            string val_3 = static_value_0028000B.name;
            string val_4 = static_value_0028000B + -1610602083(-1610602083);
            UnityEngine.GameObject val_5 = 536887303;
            val_5 = new UnityEngine.GameObject(name:  static_value_0028000B);
            UnityEngine.Transform val_6 = val_5.transform;
            if(val_5 <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this._cameraTargetsOnRails.Add(key:  2621443, value:  536887303);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_7 = this.ProCamera2D;
            Com.LuisPedroFonseca.ProCamera2D.CameraTarget val_8 = this.AddCameraTarget(targetTransform:  536887303, targetInfluenceH:  null, targetInfluenceV:  null, duration:  null, targetOffset:  new UnityEngine.Vector2() {x = 1f, y = 1f});
            if(this <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_11 = 397949923;
            val_10 = 5;
            mem[1152921509928732772] = -1608515359;
            mem[1152921509928732776] = val_11;
            label_2:
            if(this.CameraTargets == 0)
            {
                goto label_18;
            }
            
            if((val_10 - 4) < 0)
            {
                goto label_19;
            }
            
            label_5:
            if(0 == 0)
            {
                    this.enabled = false;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_10 = this.ProCamera2D;
            this.AddPreMover(mover:  1026918480);
            this.Step();
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if((UnityEngine.Object.op_Implicit(exists:  1027055056)) == false)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = R4.ProCamera2D;
            R4.RemovePreMover(mover:  R4);
        }
        public void PreMove(float deltaTime)
        {
            if(this.enabled == false)
            {
                    return;
            }
            
            R4.Step();
        }
        public int get_PrMOrder()
        {
            return (int)this._prmOrder;
        }
        public void set_PrMOrder(int value)
        {
            this._prmOrder = value;
        }
        private void Step()
        {
            float val_2;
            float val_3;
            float val_4;
            var val_26;
            var val_27;
            var val_29;
            float val_30;
            var val_31;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_26 = 0;
            val_27 = val_4;
            goto label_1;
            label_47:
            if(this.FollowMode == 0)
            {
                goto label_2;
            }
            
            if(this.FollowMode == 2)
            {
                goto label_3;
            }
            
            if(this.FollowMode != 1)
            {
                goto label_4;
            }
            
            if(this.FollowMode <= val_26)
            {
                    var val_22 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_22 = val_22 + 0;
            UnityEngine.Vector3 val_5 = TargetPosition;
            float val_6 = val_27.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7});
            if(val_27 <= val_26)
            {
                    var val_23 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_23 = val_23 + 0;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_7 = this.ProCamera2D;
            UnityEngine.Vector3 val_8 = LocalPosition;
            float val_9 = R5.Invoke(arg:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4});
            val_30 = val_27 * ((0 + 0) + 16 + 12);
            val_31 = this.FollowMode;
            goto label_31;
            label_2:
            if(this.FollowMode <= val_26)
            {
                    var val_24 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_24 = val_24 + 0;
            UnityEngine.Vector3 val_10 = TargetPosition;
            float val_11 = val_27.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7});
            if(val_27 <= val_26)
            {
                    var val_25 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_25 = val_25 + 0;
            if(val_25 <= val_26)
            {
                    var val_26 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_26 = val_26 + 0;
            UnityEngine.Vector3 val_12 = TargetPosition;
            float val_13 = this.CameraTargets.Invoke(arg:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4});
            if(this.CameraTargets <= val_26)
            {
                    var val_27 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_27 = val_27 + 0;
            val_30 = val_27 * ((0 + 0) + 16 + 12);
            val_29 = this.CameraTargets * ((0 + 0) + 16 + 16);
            val_31 = this.FollowMode;
            goto label_31;
            label_3:
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_14 = this.ProCamera2D;
            UnityEngine.Vector3 val_15 = LocalPosition;
            float val_16 = val_27.Invoke(arg:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4});
            if(val_27 <= val_26)
            {
                    var val_28 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_28 = val_28 + 0;
            UnityEngine.Vector3 val_17 = TargetPosition;
            float val_18 = this.Invoke(arg:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4});
            if(this <= val_26)
            {
                    var val_29 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_29 = val_29 + 0;
            val_30 = 1027552208 * ((0 + 0) + 16 + 16);
            val_31 = this.FollowMode;
            label_31:
            UnityEngine.Vector3 val_19 = Invoke(arg1:  val_30, arg2:  val_17.y, arg3:  val_17.z);
            val_27 = val_4;
            label_4:
            if(val_3 <= val_26)
            {
                    var val_30 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_30 = val_30 + 0;
            UnityEngine.Transform val_20 = this._cameraTargetsOnRails.Item[(0 + 0) + 16];
            UnityEngine.Vector3 val_21 = GetPositionOnRail(pos:  new UnityEngine.Vector3() {x = 0.04668027f, y = val_2, z = val_3});
            this._cameraTargetsOnRails.position = new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4};
            val_26 = 1;
            label_1:
            if(val_26 < this._cameraTargetsOnRails)
            {
                goto label_47;
            }
        
        }
        public void AddRailsTarget(UnityEngine.Transform targetTransform, float targetInfluenceH = 1, float targetInfluenceV = 1, UnityEngine.Vector2 targetOffset)
        {
            var val_1;
            var val_2;
            Com.LuisPedroFonseca.ProCamera2D.CameraTarget val_3 = this.GetRailsTarget(targetTransform:  targetTransform);
            if(this != 0)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.CameraTarget val_4 = 536884549;
            val_4 = new Com.LuisPedroFonseca.ProCamera2D.CameraTarget();
            if(val_4 != 0)
            {
                    mem[536884557] = targetTransform;
                mem[536884561] = targetOffset.x;
                mem[536884565] = targetOffset.y;
            }
            else
            {
                    mem[8] = targetTransform;
                mem[12] = targetOffset.x;
                mem[16] = targetOffset.y;
            }
            
            mem[536884569] = val_2;
            mem[536884573] = val_1;
            this.CameraTargets.Add(item:  536884549);
            string val_5 = targetTransform.name;
            string val_6 = targetTransform + -1610602083(-1610602083);
            536887303 = new UnityEngine.GameObject(name:  targetTransform);
            UnityEngine.Transform val_8 = val_7.transform;
            this._cameraTargetsOnRails.Add(key:  536884549, value:  536887303);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_9 = this.ProCamera2D;
            Com.LuisPedroFonseca.ProCamera2D.CameraTarget val_10 = this.AddCameraTarget(targetTransform:  536887303, targetInfluenceH:  targetInfluenceH, targetInfluenceV:  targetInfluenceV, duration:  null, targetOffset:  new UnityEngine.Vector2() {x = 1f, y = 1f});
            this.enabled = true;
        }
        public void RemoveRailsTarget(UnityEngine.Transform targetTransform)
        {
            Com.LuisPedroFonseca.ProCamera2D.CameraTarget val_1 = this.GetRailsTarget(targetTransform:  targetTransform);
            if(this == 0)
            {
                    return;
            }
            
            bool val_2 = this.CameraTargets.Remove(item:  1027862224);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this.ProCamera2D;
            UnityEngine.Transform val_4 = this._cameraTargetsOnRails.Item[1027862224];
            this.RemoveCameraTarget(targetTransform:  this._cameraTargetsOnRails, duration:  null);
        }
        public Com.LuisPedroFonseca.ProCamera2D.CameraTarget GetRailsTarget(UnityEngine.Transform targetTransform)
        {
            goto label_1;
            label_9:
            if(true <= 22981880)
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
            if(val_2 > 22981880)
            {
                    return;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        public void DisableTargets(float transitionDuration = 0)
        {
            var val_6;
            if(true != 0)
            {
                    return;
            }
            
            val_6 = 4;
            goto label_3;
            label_23:
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if(this <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.Transform val_2 = this._cameraTargetsOnRails.Item[2621443];
            this.RemoveCameraTarget(targetTransform:  this._cameraTargetsOnRails, duration:  transitionDuration);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this.ProCamera2D;
            if(this <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(0 <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(0 <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            Com.LuisPedroFonseca.ProCamera2D.CameraTarget val_4 = this.AddCameraTarget(targetTransform:  static_value_0028000B, targetInfluenceH:  transitionDuration, targetInfluenceV:  null, duration:  null, targetOffset:  new UnityEngine.Vector2() {x = static_value_0028000F, y = -1.084397E-19f});
            this._tempCameraTargets.Add(item:  1028168144);
            val_6 = 5;
            label_3:
            if((val_6 - 4) < this._cameraTargetsOnRails.Count)
            {
                goto label_23;
            }
        
        }
        public void EnableTargets(float transitionDuration = 0)
        {
            goto label_1;
            label_11:
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if(this <= R8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.RemoveCameraTarget(targetTransform:  static_value_0028000B, duration:  transitionDuration);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.ProCamera2D;
            if(this <= R8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.Transform val_3 = this._cameraTargetsOnRails.Item[2621443];
            Com.LuisPedroFonseca.ProCamera2D.CameraTarget val_4 = this.AddCameraTarget(targetTransform:  this._cameraTargetsOnRails, targetInfluenceH:  transitionDuration, targetInfluenceV:  null, duration:  null, targetOffset:  new UnityEngine.Vector2() {x = 1f, y = 1f});
            4 = 5;
            label_1:
            if((4 - 4) < this)
            {
                goto label_11;
            }
            
            this._tempCameraTargets.Clear();
        }
        private UnityEngine.Vector3 GetPositionOnRail(UnityEngine.Vector3 pos)
        {
            float val_1;
            var val_6;
            float val_7;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DRails val_14;
            float val_15;
            float val_16;
            var val_17;
            var val_18;
            var val_19;
            float val_20;
            float val_21;
            float val_22;
            float val_23;
            float val_24;
            float val_26;
            var val_27;
            var val_28;
            var val_29;
            val_14 = this;
            val_15 = pos.z;
            val_16 = pos.y;
            float val_17 = val_1;
            float val_18 = val_16;
            int val_2 = pos.x + 64.FindNearest(pt:  new UnityEngine.Vector3() {x = val_18, y = val_15, z = val_17});
            var val_16 = pos.x + 44 + 12;
            if(val_2 == 0)
            {
                goto label_3;
            }
            
            val_16 = val_16 - 1;
            if(val_2 != val_16)
            {
                goto label_4;
            }
            
            if((pos.x + 44) == 0)
            {
                goto label_5;
            }
            
            val_17 = mem[pos.x + 44 + 12];
            val_17 = pos.x + 44 + 12;
            val_18 = val_17;
            goto label_6;
            label_3:
            if(val_16 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_19 = mem[pos.x + 44];
            val_19 = pos.x + 44;
            var val_3 = (pos.x + 44 + 8) + 16;
            if((pos.x + 44 + 12) <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_21 = mem[(pos.x + 44 + 8 + 16) + (4)];
            val_22 = mem[pos.x + 44 + 8 + 28];
            val_22 = pos.x + 44 + 8 + 28;
            val_23 = mem[(pos.x + 44 + 8 + 16) + (0)];
            goto label_10;
            label_4:
            val_17 = val_2 - 1;
            if((pos.x + 44 + 12) <= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_19 = pos.x + 44 + 8;
            val_18 = val_17 + (val_17 << 1);
            val_19 = val_19 + (val_18 << 2);
            val_24 = mem[(pos.x + 44 + 8 + (((val_2 - 1) + ((val_2 - 1)) << 1)) << 2) + 20];
            val_24 = (pos.x + 44 + 8 + (((val_2 - 1) + ((val_2 - 1)) << 1)) << 2) + 20;
            if((pos.x + 44) == 0)
            {
                    val_24 = val_24;
            }
            
            if((pos.x + 44 + 12) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_24 = val_24;
            }
            
            int val_4 = val_2 + (val_2 << 1);
            var val_20 = pos.x + 44 + 8;
            val_20 = val_20 + (val_4 << 2);
            UnityEngine.Vector3 val_5 = 0.GetPositionOnRailSegment(node1:  new UnityEngine.Vector3() {x = (pos.x + 44 + 8 + ((val_2 + (val_2) << 1)) << 2) + 16, y = (pos.x + 44 + 8 + (((val_2 - 1) + ((val_2 - 1)) << 1)) << 2) + 16, z = val_24}, node2:  new UnityEngine.Vector3() {x = (pos.x + 44 + 8 + (((val_2 - 1) + ((val_2 - 1)) << 1)) << 2) + 24, y = (pos.x + 44 + 8 + ((val_2 + (val_2) << 1)) << 2) + 16, z = (pos.x + 44 + 8 + ((val_2 + (val_2) << 1)) << 2) + 20}, pos:  new UnityEngine.Vector3() {x = (pos.x + 44 + 8 + ((val_2 + (val_2) << 1)) << 2) + 24, y = val_16, z = val_15});
            int val_8 = val_2 + 1;
            if((pos.x + 44 + 12) <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_21 = pos.x + 44 + 8;
            val_21 = val_21 + ((val_8 + (val_8 << 1)) << 2);
            if((pos.x + 44 + 12) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_22 = pos.x + 44 + 8;
            val_22 = val_22 + (val_4 << 2);
            UnityEngine.Vector3 val_10 = 0.GetPositionOnRailSegment(node1:  new UnityEngine.Vector3() {x = (pos.x + 44 + 8 + ((val_2 + (val_2) << 1)) << 2) + 16, y = (pos.x + 44 + 8 + (((val_2 + 1) + ((val_2 + 1)) << 1)) << 2) + 16, z = (pos.x + 44 + 8 + (((val_2 + 1) + ((val_2 + 1)) << 1)) << 2) + 20}, node2:  new UnityEngine.Vector3() {x = (pos.x + 44 + 8 + (((val_2 + 1) + ((val_2 + 1)) << 1)) << 2) + 24, y = (pos.x + 44 + 8 + ((val_2 + (val_2) << 1)) << 2) + 16, z = (pos.x + 44 + 8 + ((val_2 + (val_2) << 1)) << 2) + 20}, pos:  new UnityEngine.Vector3() {x = (pos.x + 44 + 8 + ((val_2 + (val_2) << 1)) << 2) + 24, y = val_16, z = val_15});
            val_14 = val_6;
            val_15 = 0;
            float val_23 = val_14;
            uint val_24 = 0;
            float val_25 = val_7;
            val_23 = val_15 - val_23;
            val_24 = val_16 - val_24;
            val_25 = val_1 - val_25;
            float val_11 = val_24.sqrMagnitude;
            uint val_26 = 0;
            float val_27 = R7;
            val_26 = val_16 - val_26;
            val_26 = val_15 - R6;
            val_27 = val_1 - val_27;
            float val_12 = val_26.sqrMagnitude;
            val_27 = 1028457888;
            if((pos.x + 44 + 12) > val_2)
            {
                    return new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
            }
            
            mem[1152921509930284248] = val_7;
            return new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
            label_5:
            val_18 = 0;
            val_17 = 0;
            label_6:
            if(val_17 <= (-1))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_28 = pos.x + 44 + 8;
            val_28 = val_28 + (((-1) + 4294967294) << 2);
            val_15 = mem[(pos.x + 44 + 8 + ((-1 + 4294967294)) << 2) + 16];
            val_15 = (pos.x + 44 + 8 + ((-1 + 4294967294)) << 2) + 16;
            val_20 = mem[(pos.x + 44 + 8 + ((-1 + 4294967294)) << 2) + 20];
            val_20 = (pos.x + 44 + 8 + ((-1 + 4294967294)) << 2) + 20;
            if((pos.x + 44) != 0)
            {
                    val_28 = mem[pos.x + 44 + 12];
                val_28 = pos.x + 44 + 12;
                val_29 = val_28;
            }
            else
            {
                    val_29 = 0;
                val_28 = 0;
            }
            
            val_19 = -2;
            if(val_28 <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_29 = pos.x + 44 + 8;
            val_21 = val_20;
            val_29 = val_29 + ((val_19 + 4294967292) << 2);
            val_22 = mem[(pos.x + 44 + 8 + ((val_19 + 4294967292)) << 2) + 16];
            val_22 = (pos.x + 44 + 8 + ((val_19 + 4294967292)) << 2) + 16;
            val_23 = val_15;
            label_10:
            UnityEngine.Vector3 val_15 = val_27.GetPositionOnRailSegment(node1:  new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_21}, node2:  new UnityEngine.Vector3() {x = (pos.x + 44 + 8 + ((-1 + 4294967294)) << 2) + 24, y = val_22, z = (pos.x + 44 + 8 + ((val_19 + 4294967292)) << 2) + 20}, pos:  new UnityEngine.Vector3() {x = (pos.x + 44 + 8 + ((val_19 + 4294967292)) << 2) + 24, y = val_16, z = val_26});
            mem[1152921509930284248] = val_7;
            this = val_27;
            return new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
        }
        private UnityEngine.Vector3 GetPositionOnRailSegment(UnityEngine.Vector3 node1, UnityEngine.Vector3 node2, UnityEngine.Vector3 pos)
        {
            var val_5;
            var val_9;
            float val_12;
            var val_13;
            float val_1 = node2.z - node1.z;
            float val_3 = pos.x - node2.x;
            UnityEngine.Vector3 val_4 = normalized;
            float val_12 = pos.z;
            val_12 = val_12 - node1.z;
            val_12 = pos.y - node1.y;
            val_13 = val_9 - node2.x;
            if(<0)
            {
                    this = node1.y;
                return new UnityEngine.Vector3() {x = (val_12 * val_5) * (val_12 * val_5), y = val_4.y, z = val_12};
            }
            
            float val_10 = node2.y - node1.y.sqrMagnitude;
            val_12 = 1028569916;
            if()
            {
                    this = node2.y;
                mem[1152921509930396244] = node2.z;
                mem[1152921509930396248] = pos.x;
                return new UnityEngine.Vector3() {x = (val_12 * val_5) * (val_12 * val_5), y = val_4.y, z = val_12};
            }
            
            this = node1.y;
            mem[1152921509930396244] = node1.z;
            mem[1152921509930396248] = node2.x;
            return new UnityEngine.Vector3() {x = (val_12 * val_5) * (val_12 * val_5), y = val_4.y, z = val_12};
        }
        public ProCamera2DRails()
        {
            536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this.RailNodes = 536878517;
            System.Collections.Generic.List<Page> val_2 = 536877775;
            val_2 = new System.Collections.Generic.List<Page>();
            this.CameraTargets = val_2;
            536874143 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
            this._cameraTargetsOnRails = 536874143;
            System.Collections.Generic.List<Page> val_4 = 536877775;
            val_4 = new System.Collections.Generic.List<Page>();
            this._tempCameraTargets = val_4;
            this._prmOrder = 1000;
        }
        private static ProCamera2DRails()
        {
            mem2[0] = -1610605101;
        }
    
    }

}
