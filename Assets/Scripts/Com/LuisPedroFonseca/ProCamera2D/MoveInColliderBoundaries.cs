using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class MoveInColliderBoundaries
    {
        // Fields
        private System.Func<UnityEngine.Vector3, float> Vector3H;
        private System.Func<UnityEngine.Vector3, float> Vector3V;
        private System.Func<float, float, UnityEngine.Vector3> VectorHV;
        private const float Offset = 0.2;
        private const float RaySizeCompensation = 0.2;
        public UnityEngine.Transform CameraTransform;
        public UnityEngine.Vector2 CameraSize;
        public UnityEngine.LayerMask CameraCollisionMask;
        public int TotalHorizontalRays;
        public int TotalVerticalRays;
        private Com.LuisPedroFonseca.ProCamera2D.RaycastOrigins _raycastOrigins;
        private Com.LuisPedroFonseca.ProCamera2D.CameraCollisionState _cameraCollisionState;
        private UnityEngine.RaycastHit _raycastHit;
        private float _verticalDistanceBetweenRays;
        private float _horizontalDistanceBetweenRays;
        private Com.LuisPedroFonseca.ProCamera2D.ProCamera2D _proCamera2D;
        
        // Properties
        public Com.LuisPedroFonseca.ProCamera2D.RaycastOrigins RaycastOrigins { get; }
        public Com.LuisPedroFonseca.ProCamera2D.CameraCollisionState CameraCollisionState { get; }
        
        // Methods
        public Com.LuisPedroFonseca.ProCamera2D.RaycastOrigins get_RaycastOrigins()
        {
            var val_1 = R1 + 44;
            return new Com.LuisPedroFonseca.ProCamera2D.RaycastOrigins() {TopRight = new UnityEngine.Vector3() {x = 0.001791754f, y = (R1 + 44) + (24), z = mem[(R1 + 44) + (24) + (0)]}, TopLeft = new UnityEngine.Vector3() {x = mem[(R1 + 44) + (24) + (4)]}, BottomRight = new UnityEngine.Vector3(), BottomLeft = new UnityEngine.Vector3()};
        }
        public Com.LuisPedroFonseca.ProCamera2D.CameraCollisionState get_CameraCollisionState()
        {
            mem[1152921509890395828] = R1 + 96;
            this = R1 + 92;
            return new Com.LuisPedroFonseca.ProCamera2D.CameraCollisionState() {VTopLeft = true, HTopLeft = true, VTopRight = true, HTopRight = true, VBottomLeft = R1 + 96, HBottomLeft = R1 + 96, VBottomRight = R1 + 96, HBottomRight = R1 + 96};
        }
        public MoveInColliderBoundaries(Com.LuisPedroFonseca.ProCamera2D.ProCamera2D proCamera2D)
        {
            var val_11;
            var val_12;
            var val_13;
            object val_14;
            System.Func<UnityEngine.Vector3, System.Single> val_15;
            object val_16;
            var val_17;
            object val_18;
            System.Func<UnityEngine.Vector3, System.Single> val_19;
            var val_20;
            object val_21;
            System.Func<System.Single, System.Single, UnityEngine.Vector3> val_22;
            var val_23;
            object val_24;
            System.Func<UnityEngine.Vector3, System.Single> val_25;
            var val_26;
            object val_27;
            System.Func<UnityEngine.Vector3, System.Single> val_28;
            var val_29;
            object val_30;
            var val_31;
            object val_32;
            System.Func<UnityEngine.Vector3, System.Single> val_33;
            var val_34;
            object val_35;
            System.Func<UnityEngine.Vector3, System.Single> val_36;
            var val_37;
            object val_38;
            this.TotalHorizontalRays = 3;
            this.TotalVerticalRays = 3;
            val_11 = this;
            this._proCamera2D = proCamera2D;
            if(proCamera2D.Axis == 2)
            {
                goto label_2;
            }
            
            if(proCamera2D.Axis == 1)
            {
                goto label_3;
            }
            
            if(proCamera2D.Axis != 0)
            {
                    return;
            }
            
            val_12 = 22718876;
            val_13 = 536900071;
            if(((mem[536900258] & true) == 0) && (mem[536900187] == 0))
            {
                    val_13 = 536900071;
            }
            
            val_14 = mem[536900163];
            val_15 = mem[mem[536900163] + 4];
            val_15 = mem[536900163] + 4;
            if(val_15 == 0)
            {
                    if(((mem[536900258] & true) == 0) && (mem[536900187] == 0))
            {
                    val_14 = mem[536900163];
            }
            
                val_16 = mem[mem[536900163]];
                val_16 = val_14;
                val_15 = 536875575;
                val_15 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_16, method:  new IntPtr(1610684251));
                mem2[0] = val_15;
            }
            
            this.Vector3H = val_15;
            val_17 = 536900071;
            if(((mem[536900258] & true) == 0) && (mem[536900187] == 0))
            {
                    val_17 = 536900071;
            }
            
            val_18 = mem[536900163];
            val_19 = mem[mem[536900163] + 8];
            val_19 = mem[536900163] + 8;
            if(val_19 == 0)
            {
                    if(((mem[536900258] & true) == 0) && (mem[536900187] == 0))
            {
                    val_18 = mem[536900163];
            }
            
                val_16 = mem[mem[536900163]];
                val_16 = val_18;
                val_19 = 536875575;
                val_19 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_16, method:  new IntPtr(1610684253));
                mem2[0] = val_19;
            }
            
            this.Vector3V = val_19;
            val_20 = 536900071;
            if(((mem[536900258] & true) == 0) && (mem[536900187] == 0))
            {
                    val_20 = 536900071;
            }
            
            val_21 = mem[536900163];
            val_22 = mem[mem[536900163] + 12];
            val_22 = mem[536900163] + 12;
            if(val_22 != 0)
            {
                goto label_49;
            }
            
            if(((mem[536900258] & true) == 0) && (mem[536900187] == 0))
            {
                    val_21 = mem[536900163];
            }
            
            val_16 = mem[mem[536900163]];
            val_16 = val_21;
            val_22 = 536875643;
            val_22 = new System.Func<System.Single, System.Single, UnityEngine.Vector3>(object:  val_16, method:  new IntPtr(1610684255));
            mem2[0] = val_22;
            goto label_36;
            label_2:
            val_12 = 22718876;
            val_23 = 536900071;
            if(((mem[536900258] & true) == 0) && (mem[536900187] == 0))
            {
                    val_23 = 536900071;
            }
            
            val_24 = mem[536900163];
            val_25 = mem[mem[536900163] + 28];
            val_25 = mem[536900163] + 28;
            if(val_25 == 0)
            {
                    if(((mem[536900258] & true) == 0) && (mem[536900187] == 0))
            {
                    val_24 = mem[536900163];
            }
            
                val_16 = mem[mem[536900163]];
                val_16 = val_24;
                val_25 = 536875575;
                val_25 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_16, method:  new IntPtr(1610684263));
                mem2[0] = val_25;
            }
            
            this.Vector3H = val_25;
            val_26 = 536900071;
            if(((mem[536900258] & true) == 0) && (mem[536900187] == 0))
            {
                    val_26 = 536900071;
            }
            
            val_27 = mem[536900163];
            val_28 = mem[mem[536900163] + 32];
            val_28 = mem[536900163] + 32;
            if(val_28 == 0)
            {
                    if(((mem[536900258] & true) == 0) && (mem[536900187] == 0))
            {
                    val_27 = mem[536900163];
            }
            
                val_16 = mem[mem[536900163]];
                val_16 = val_27;
                val_28 = 536875575;
                val_28 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_16, method:  new IntPtr(1610684265));
                mem2[0] = val_28;
            }
            
            this.Vector3V = val_28;
            val_29 = 536900071;
            if(((mem[536900258] & true) == 0) && (mem[536900187] == 0))
            {
                    val_29 = 536900071;
            }
            
            val_30 = mem[536900163];
            val_22 = mem[mem[536900163] + 36];
            val_22 = mem[536900163] + 36;
            if(val_22 != 0)
            {
                goto label_49;
            }
            
            if(((mem[536900258] & true) == 0) && (mem[536900187] == 0))
            {
                    val_30 = mem[536900163];
            }
            
            val_16 = mem[mem[536900163]];
            val_16 = val_30;
            val_22 = 536875643;
            val_22 = new System.Func<System.Single, System.Single, UnityEngine.Vector3>(object:  val_16, method:  new IntPtr(1610684267));
            mem2[0] = val_22;
            goto label_36;
            label_3:
            val_12 = 22718876;
            val_31 = 536900071;
            if(((mem[536900258] & true) == 0) && (mem[536900187] == 0))
            {
                    val_31 = 536900071;
            }
            
            val_32 = mem[536900163];
            val_33 = mem[mem[536900163] + 16];
            val_33 = mem[536900163] + 16;
            if(val_33 == 0)
            {
                    if(((mem[536900258] & true) == 0) && (mem[536900187] == 0))
            {
                    val_32 = mem[536900163];
            }
            
                val_16 = mem[mem[536900163]];
                val_16 = val_32;
                val_33 = 536875575;
                val_33 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_16, method:  new IntPtr(1610684257));
                mem2[0] = val_33;
            }
            
            this.Vector3H = val_33;
            val_34 = 536900071;
            if(((mem[536900258] & true) == 0) && (mem[536900187] == 0))
            {
                    val_34 = 536900071;
            }
            
            val_35 = mem[536900163];
            val_36 = mem[mem[536900163] + 20];
            val_36 = mem[536900163] + 20;
            if(val_36 == 0)
            {
                    if(((mem[536900258] & true) == 0) && (mem[536900187] == 0))
            {
                    val_35 = mem[536900163];
            }
            
                val_16 = mem[mem[536900163]];
                val_16 = val_35;
                val_36 = 536875575;
                val_36 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_16, method:  new IntPtr(1610684259));
                mem2[0] = val_36;
            }
            
            this.Vector3V = val_36;
            val_37 = 536900071;
            if(((mem[536900258] & true) == 0) && (mem[536900187] == 0))
            {
                    val_37 = 536900071;
            }
            
            val_38 = mem[536900163];
            val_22 = mem[mem[536900163] + 24];
            val_22 = mem[536900163] + 24;
            if(val_22 != 0)
            {
                goto label_49;
            }
            
            if(((mem[536900258] & true) == 0) && (mem[536900187] == 0))
            {
                    val_38 = mem[536900163];
            }
            
            val_16 = mem[mem[536900163]];
            val_16 = val_38;
            val_22 = 536875643;
            val_22 = new System.Func<System.Single, System.Single, UnityEngine.Vector3>(object:  val_16, method:  new IntPtr(1610684261));
            mem2[0] = val_22;
            label_36:
            label_49:
            this.VectorHV = val_22;
        }
        public UnityEngine.Vector3 Move(UnityEngine.Vector3 deltaMovement)
        {
            float val_1;
            Com.LuisPedroFonseca.ProCamera2D.MoveInColliderBoundaries val_29;
            System.Func<UnityEngine.Vector3, System.Single> val_30;
            float val_31;
            float val_33;
            deltaMovement.x.UpdateRaycastOrigins();
            float val_2 = deltaMovement.x + 80;
            bool val_15 = true;
            deltaMovement.x.GetOffsetAndForceMovement(rayTargetPos:  new UnityEngine.Vector3() {x = mem[(deltaMovement.x + 80) + (0)], y = mem[(deltaMovement.x + 80) + (4)], z = mem[(deltaMovement.x + 80) + (8)]}, deltaMovement: ref  new UnityEngine.Vector3() {x = deltaMovement.y, y = deltaMovement.x + 97, z = deltaMovement.x + 96}, horizontalCheck: ref  val_15, verticalCheck: ref  val_15, hSign:  null, vSign:  null);
            float val_7 = deltaMovement.x + 68;
            bool val_16 = true;
            deltaMovement.x.GetOffsetAndForceMovement(rayTargetPos:  new UnityEngine.Vector3() {x = mem[(deltaMovement.x + 68) + (0)], y = mem[(deltaMovement.x + 68) + (4)], z = mem[(deltaMovement.x + 68) + (8)]}, deltaMovement: ref  new UnityEngine.Vector3() {x = deltaMovement.y, y = deltaMovement.x + 99, z = deltaMovement.x + 98}, horizontalCheck: ref  val_16, verticalCheck: ref  val_15, hSign:  null, vSign:  null);
            float val_12 = deltaMovement.x + 56;
            deltaMovement.x.GetOffsetAndForceMovement(rayTargetPos:  new UnityEngine.Vector3() {x = mem[(deltaMovement.x + 56) + (0)], y = mem[(deltaMovement.x + 56) + (4)], z = mem[(deltaMovement.x + 56) + (8)]}, deltaMovement: ref  new UnityEngine.Vector3() {x = deltaMovement.y, y = deltaMovement.x + 93, z = deltaMovement.x + 92}, horizontalCheck: ref  val_15, verticalCheck: ref  val_16, hSign:  null, vSign:  null);
            float val_17 = deltaMovement.x + 44;
            deltaMovement.x.GetOffsetAndForceMovement(rayTargetPos:  new UnityEngine.Vector3() {x = mem[(deltaMovement.x + 44) + (0)], y = mem[(deltaMovement.x + 44) + (4)], z = mem[(deltaMovement.x + 44) + (8)]}, deltaMovement: ref  new UnityEngine.Vector3() {x = deltaMovement.y, y = deltaMovement.x + 95, z = deltaMovement.x + 94}, horizontalCheck: ref  val_16, verticalCheck: ref  val_16, hSign:  null, vSign:  null);
            float val_22 = deltaMovement.x + 8.Invoke(arg:  new UnityEngine.Vector3() {x = deltaMovement.y, y = deltaMovement.z, z = val_1});
            if((deltaMovement.x + 8) == 0)
            {
                    val_31 = 0f;
            }
            else
            {
                    float val_24 = deltaMovement.x.MoveInAxis(deltaMovement:  deltaMovement.x + 8.Invoke(arg:  new UnityEngine.Vector3() {x = deltaMovement.y, y = deltaMovement.z, z = val_1}), isHorizontal:  deltaMovement.x + 8);
                val_31 = deltaMovement.x;
            }
            
            float val_25 = deltaMovement.x + 12.Invoke(arg:  new UnityEngine.Vector3() {x = deltaMovement.y, y = deltaMovement.z, z = val_1});
            if((deltaMovement.x + 12) == 0)
            {
                    val_33 = 0f;
            }
            else
            {
                    val_33 = deltaMovement.x;
            }
            
            UnityEngine.Vector3 val_28 = Invoke(arg1:  deltaMovement.x.MoveInAxis(deltaMovement:  deltaMovement.x + 12.Invoke(arg:  new UnityEngine.Vector3() {x = deltaMovement.y, y = deltaMovement.z, z = val_1}), isHorizontal:  deltaMovement.x + 12), arg2:  null);
            this.Vector3H = val_30;
            this = val_29;
            return new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z};
        }
        private void UpdateRaycastOrigins()
        {
            float val_2;
            float val_3;
            float val_4;
            UnityEngine.Vector3 val_1 = localPosition;
            float val_5 = this.Vector3H.Invoke(arg:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4});
            UnityEngine.Vector3 val_6 = localPosition;
            UnityEngine.Vector3 val_8 = Invoke(arg1:  this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R7, z = SL}), arg2:  val_6.y);
            UnityEngine.Vector3 val_9 = localPosition;
            float val_10 = this.Vector3H.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R7, z = val_4});
            UnityEngine.Vector3 val_11 = localPosition;
            UnityEngine.Vector3 val_13 = Invoke(arg1:  this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R7, z = SL}), arg2:  val_11.y);
            UnityEngine.Vector3 val_14 = localPosition;
            float val_15 = this.Vector3H.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R7, z = val_4});
            UnityEngine.Vector3 val_16 = localPosition;
            UnityEngine.Vector3 val_18 = Invoke(arg1:  this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R7, z = SL}), arg2:  val_16.y);
            UnityEngine.Vector3 val_19 = localPosition;
            float val_20 = this.Vector3H.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R7, z = val_4});
            UnityEngine.Vector3 val_21 = localPosition;
            UnityEngine.Vector3 val_23 = Invoke(arg1:  this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R7, z = SL}), arg2:  val_21.y);
            int val_25 = this.TotalVerticalRays;
            val_25 = val_25 - 1;
            float val_27 = (float)val_25;
            int val_26 = this.TotalHorizontalRays;
            val_26 = val_26 - 1;
            val_27 = this.CameraSize / val_27;
            this._verticalDistanceBetweenRays = S4 / (float)val_26;
            this._horizontalDistanceBetweenRays = val_27;
        }
        private void GetOffsetAndForceMovement(UnityEngine.Vector3 rayTargetPos, ref UnityEngine.Vector3 deltaMovement, ref bool horizontalCheck, ref bool verticalCheck, float hSign, float vSign)
        {
            float val_2;
            float val_3;
            float val_25;
            float val_36;
            var val_37;
            float val_38;
            float val_39;
            float val_40;
            float val_41;
            var val_44;
            var val_45;
            UnityEngine.Vector3 val_1 = 0.localPosition;
            float val_4 = this.Vector3H.Invoke(arg:  new UnityEngine.Vector3() {x = 0f, y = val_2, z = val_3});
            UnityEngine.Vector3 val_5 = 0.localPosition;
            UnityEngine.Vector3 val_7 = 0.Invoke(arg1:  this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = 0f, y = R6, z = SL}), arg2:  val_5.y);
            val_38 = 0f;
            val_39 = val_2;
            float val_8 = rayTargetPos.x - 0;
            float val_9 = rayTargetPos.y - val_39;
            float val_10 = rayTargetPos.z - val_3;
            UnityEngine.Vector3 val_11 = val_10.normalized;
            val_40 = val_2;
            val_41 = val_3;
            float val_12 = val_8.magnitude;
            UnityEngine.Color val_13 = UnityEngine.Color.yellow;
            uint val_38 = 989230384;
            val_38 = val_38 + 0.01f;
            float val_40 = val_40;
            float val_14 = val_38 + 0.5f;
            float val_41 = val_10;
            float val_39 = val_41;
            val_39 = val_14 * val_39;
            val_40 = val_14 * val_40;
            val_41 = val_14 * val_41;
            val_10.DrawRay(start:  new UnityEngine.Vector3() {x = 0f, y = val_39, z = val_3}, dir:  new UnityEngine.Vector3() {x = val_41, y = val_40, z = val_39}, color:  new UnityEngine.Color() {r = val_10, g = ???, b = ???, a = ???}, duration:  val_39);
            if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = 0f, y = val_39, z = val_3}, direction:  new UnityEngine.Vector3() {x = val_10, y = val_40, z = val_41}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 1152921509891056836, y = val_14, z = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = mem[1152921509891056768]})}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = ???, z = 0f}, m_UV = new UnityEngine.Vector2() {x = rayTargetPos.y, y = rayTargetPos.x}, m_Collider = val_10}, maxDistance:  val_39, layerMask:  this)) == false)
            {
                goto label_6;
            }
            
            UnityEngine.Vector3 val_17 = val_10.normal;
            val_39 = 4.01997E-38f;
            float val_18 = this.Vector3H.Invoke(arg:  new UnityEngine.Vector3() {x = val_10, y = R7, z = SB});
            UnityEngine.Vector3 val_19 = val_10.normal;
            System.Func<UnityEngine.Vector3, System.Single> val_20 = this.Vector3H & (~2147483648);
            System.Func<UnityEngine.Vector3, System.Single> val_42 = this.Vector3V;
            float val_21 = val_42.Invoke(arg:  new UnityEngine.Vector3() {x = val_10, y = R6, z = R7});
            val_42 = val_42 & (~2147483648);
            if(this.Vector3V <= 0)
            {
                goto label_9;
            }
            
            float val_43 = deltaMovement.z;
            val_43 = val_43 >> 5;
            deltaMovement.y = val_43;
            val_40 = this.Vector3H;
            float val_22 = val_40.Invoke(arg:  new UnityEngine.Vector3() {x = deltaMovement.x, y = R5, z = R6});
            if(val_40 != 0)
            {
                    return;
            }
            
            float val_44 = horizontalCheck;
            val_44 = val_44 * 0.1f;
            UnityEngine.Vector3 val_24 = Invoke(arg1:  this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = deltaMovement.x, y = R6, z = R7}), arg2:  val_19.y);
            val_3 = val_8;
            deltaMovement.x = val_25;
            mem[1152921509891088744] = val_3;
            float val_27 = this.MoveInAxis(deltaMovement:  this.Vector3H.Invoke(arg:  new UnityEngine.Vector3() {x = deltaMovement.x, y = R6, z = val_3}), isHorizontal:  this.Vector3H);
            float val_28 = this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = deltaMovement.x, y = R7, z = val_39});
            val_41 = this.Vector3V;
            val_44 = this.VectorHV;
            val_45 = 22732400;
            goto label_17;
            label_6:
            deltaMovement.y = 0f;
            deltaMovement.z = 0f;
            return;
            label_9:
            deltaMovement.z = 0f;
            val_40 = this.Vector3V;
            float val_29 = val_40.Invoke(arg:  new UnityEngine.Vector3() {x = deltaMovement.x, y = R5, z = val_41});
            if(val_40 != 0)
            {
                    return;
            }
            
            float val_45 = verticalCheck;
            val_45 = val_45 * 0.1f;
            UnityEngine.Vector3 val_31 = Invoke(arg1:  this.Vector3H.Invoke(arg:  new UnityEngine.Vector3() {x = deltaMovement.x, y = R6, z = mem[1152921509891088744]}), arg2:  val_19.y);
            val_3 = val_8;
            deltaMovement.x = val_25;
            mem[1152921509891088744] = val_3;
            float val_33 = this.MoveInAxis(deltaMovement:  this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = deltaMovement.x, y = R6, z = val_3}), isHorizontal:  this.Vector3V);
            val_44 = this.VectorHV;
            val_45 = 22732400;
            label_17:
            UnityEngine.Vector3 val_35 = Invoke(arg1:  this.Vector3H.Invoke(arg:  new UnityEngine.Vector3() {x = val_41, y = R7, z = val_39}), arg2:  val_31.y);
            val_25 = val_36;
            mem[1152921509891088744] = val_37;
            deltaMovement.x = val_25;
        }
        private float MoveInAxis(float deltaMovement, bool isHorizontal)
        {
            float val_2;
            float val_3;
            float val_4;
            Com.LuisPedroFonseca.ProCamera2D.MoveInColliderBoundaries val_26;
            float val_27;
            float val_28;
            float val_29;
            var val_30;
            var val_31;
            var val_32;
            Com.LuisPedroFonseca.ProCamera2D.MoveInColliderBoundaries val_33;
            var val_34;
            var val_35;
            float val_36;
            bool val_37;
            bool val_38;
            float val_39;
            if((???) == 0)
            {
                goto label_2;
            }
            
            if((???) <= 0)
            {
                goto label_3;
            }
            
            UnityEngine.Vector3 val_1 = right;
            val_26 = 1152921509891209692;
            val_27 = val_2;
            val_28 = val_3;
            val_29 = val_4;
            val_30 = 1152921509891209688;
            val_31 = 1152921509891209684;
            goto label_4;
            label_2:
            if((???) <= 0)
            {
                goto label_5;
            }
            
            UnityEngine.Vector3 val_5 = up;
            val_26 = 1152921509891209680;
            val_27 = val_2;
            val_28 = val_3;
            val_29 = val_4;
            val_30 = 1152921509891209676;
            val_31 = 1152921509891209672;
            goto label_6;
            label_3:
            UnityEngine.Vector3 val_6 = right;
            val_30 = 1152921509891209700;
            val_31 = 1152921509891209696;
            val_29 = -val_4;
            val_28 = -val_3;
            val_27 = -val_2;
            val_26 = 1152921509891209704;
            label_4:
            val_32 = 1152921509891209652;
            goto label_7;
            label_5:
            UnityEngine.Vector3 val_7 = up;
            val_30 = 1152921509891209700;
            val_31 = 1152921509891209696;
            val_29 = -val_4;
            val_28 = -val_3;
            val_27 = -val_2;
            val_26 = 1152921509891209704;
            label_6:
            val_32 = 1152921509891209656;
            label_7:
            if(this.TotalVerticalRays < 1)
            {
                goto label_8;
            }
            
            bool val_9 = System.Math.Abs(isHorizontal) + 0.2f;
            val_33 = this;
            val_29 = val_9 * val_29;
            val_28 = val_9 * val_28;
            val_27 = val_9 * val_27;
            if(this.TotalVerticalRays > 1)
            {
                    18015316 = 18015320;
            }
            
            if(this.TotalVerticalRays <= 1)
            {
                    0 = 1;
            }
            
            if((???) == 0)
            {
                    mem[1152921509891209624].Invoke(arg:  new UnityEngine.Vector3() {x = 0.001899538f, y = R5, z = mem[1152921509891209636]}) = 0;
                mem[1152921509891209624].Invoke(arg:  new UnityEngine.Vector3() {x = 0.001899538f, y = R5, z = mem[1152921509891209636]}) = 0f;
                val_28 = mem[1152921509891209764];
            }
            
            int val_11 = (0 - this.TotalVerticalRays) + 0;
            float val_12 = mem[1152921509891209628].Invoke(arg:  new UnityEngine.Vector3() {x = 0.001899538f, y = R5, z = mem[1152921509891209636]});
            val_35 = mem[1152921509891209628];
            if((???) == 0)
            {
                goto label_11;
            }
            
            if((???) <= 0)
            {
                goto label_12;
            }
            
            val_36 = val_35 + 0.2f;
            if(mem[1152921509891209714] == true)
            {
                    val_35 = val_36;
            }
            
            if(0 == 0)
            {
                    val_35 = val_35;
            }
            
            if(val_11 != 1)
            {
                goto label_20;
            }
            
            val_37 = mem[1152921509891209710];
            goto label_14;
            label_11:
            if((???) <= 0)
            {
                goto label_15;
            }
            
            val_36 = mem[1152921509891209624] + 0.2f;
            if(mem[1152921509891209709] == true)
            {
                    mem[1152921509891209624] = val_36;
            }
            
            if(0 == 0)
            {
                    val_34 = mem[1152921509891209624];
            }
            
            if(val_11 != 1)
            {
                goto label_20;
            }
            
            val_38 = mem[1152921509891209711];
            goto label_17;
            label_12:
            val_36 = val_35 + 0.2f;
            if(mem[1152921509891209712] == true)
            {
                    val_35 = val_36;
            }
            
            if(0 == 0)
            {
                    val_35 = val_35;
            }
            
            if(val_11 != 1)
            {
                goto label_20;
            }
            
            val_37 = mem[1152921509891209708];
            label_14:
            val_39 = 0;
            if(val_37 == true)
            {
                    val_35 = val_35 + (-0.2f);
            }
            
            goto label_21;
            label_15:
            val_36 = mem[1152921509891209624] + 0.2f;
            if(mem[1152921509891209713] == true)
            {
                    mem[1152921509891209624] = val_36;
            }
            
            if(0 == 0)
            {
                    val_34 = mem[1152921509891209624];
            }
            
            if(val_11 != 1)
            {
                goto label_20;
            }
            
            val_38 = mem[1152921509891209715];
            label_17:
            val_39 = 0;
            if(val_38 == true)
            {
                    val_34 = val_34 + (-0.2f);
            }
            
            goto label_21;
            label_20:
            val_39 = 0f;
            label_21:
            UnityEngine.Vector3 val_13 = Invoke(arg1:  val_36, arg2:  val_7.y);
            bool val_15 = UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4}, direction:  new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 1152921509891209716, y = val_9, z = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = mem[1152921509891209648]})}, m_Normal = new UnityEngine.Vector3() {x = val_39}, m_UV = new UnityEngine.Vector2() {x = 1.401298E-45f, y = 0f}, m_Collider = this}, maxDistance:  val_13.x, layerMask:  val_27);
            if(val_15 == false)
            {
                goto label_23;
            }
            
            UnityEngine.Color val_16 = UnityEngine.Color.red;
            DrawRay(start:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4}, dir:  new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29}, color:  new UnityEngine.Color(), duration:  val_16.r);
            float val_22 = 0f;
            val_22 = val_22 & (???);
            val_22 = val_22 ^ 1;
            if(val_15 == true)
            {
                goto label_24;
            }
            
            UnityEngine.Vector3 val_17 = point;
            float val_18 = mem[1152921509891209624].Invoke(arg:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4});
            val_33 = this;
            if(mem[1152921509891209624] <= 0)
            {
                goto label_31;
            }
            
            label_24:
            if(mem[1152921509891209624] > 0)
            {
                    if(1 == 1)
            {
                    UnityEngine.Vector3 val_19 = point;
                float val_20 = mem[1152921509891209628].Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R5, z = R6});
                if(mem[1152921509891209628] <= 0)
            {
                
            }
            
            }
            
            }
        
        }
        private void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir, UnityEngine.Color color, float duration = 0)
        {
            float val_2;
            float val_3;
            float val_4;
            float val_5;
            float val_6;
            float val_7;
            val_2 = color.a;
            val_3 = dir.y;
            var val_2 = mem[536885943];
            val_4 = dir.x;
            val_2 = val_2 & 512;
            if((val_2 != 0) && (mem[536885873] == 0))
            {
                    val_5 = dir.y;
                val_6 = color.a;
                val_7 = dir.x;
            }
            
            UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z}, dir:  new UnityEngine.Vector3() {x = val_7, y = val_5, z = dir.z}, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = val_6}, duration:  duration);
        }
    
    }

}
