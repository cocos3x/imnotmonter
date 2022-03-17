using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DGeometryBoundaries : BasePC2D, IPositionDeltaChanger
    {
        // Fields
        public static string ExtensionName;
        public UnityEngine.LayerMask BoundariesLayerMask;
        public Com.LuisPedroFonseca.ProCamera2D.MoveInColliderBoundaries MoveInColliderBoundaries;
        private int _pdcOrder;
        
        // Properties
        public int PDCOrder { get; set; }
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            Com.LuisPedroFonseca.ProCamera2D.MoveInColliderBoundaries val_2 = 536890835;
            val_2 = new Com.LuisPedroFonseca.ProCamera2D.MoveInColliderBoundaries(proCamera2D:  1015191504);
            this.MoveInColliderBoundaries = val_2;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this.ProCamera2D;
            UnityEngine.Transform val_4 = this.transform;
            this.MoveInColliderBoundaries.CameraTransform = this;
            this.MoveInColliderBoundaries.CameraCollisionMask = this.BoundariesLayerMask;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_5 = this.ProCamera2D;
            this.AddPositionDeltaChanger(changer:  1015191504);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if((UnityEngine.Object.op_Implicit(exists:  1015311696)) == false)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = R4.ProCamera2D;
            R4.RemovePositionDeltaChanger(changer:  R4);
        }
        public UnityEngine.Vector3 AdjustDelta(float deltaTime, UnityEngine.Vector3 originalDelta)
        {
            float val_3;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DGeometryBoundaries val_6;
            var val_7;
            float val_8 = originalDelta.x;
            if(originalDelta.x.enabled != false)
            {
                    Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = val_8.ProCamera2D;
                mem2[0] = originalDelta.x + 72;
                mem2[0] = originalDelta.x + 76;
                val_8 = mem[originalDelta.x + 48];
                val_8 = originalDelta.x + 48;
                UnityEngine.Vector3 val_5 = Move(deltaMovement:  new UnityEngine.Vector3() {x = val_8, y = originalDelta.z, z = val_3});
                mem[1152921509917237976] = val_7;
                this = val_6;
                return new UnityEngine.Vector3() {x = deltaTime};
            }
            
            this = originalDelta.z;
            return new UnityEngine.Vector3() {x = deltaTime};
        }
        public int get_PDCOrder()
        {
            return (int)this._pdcOrder;
        }
        public void set_PDCOrder(int value)
        {
            this._pdcOrder = value;
        }
        public ProCamera2DGeometryBoundaries()
        {
            this._pdcOrder = 3000;
        }
        private static ProCamera2DGeometryBoundaries()
        {
            mem2[0] = -1610607927;
        }
    
    }

}
