using UnityEngine;

namespace FerrPoly2Tri
{
    public abstract class TriangulationContext
    {
        // Fields
        private FerrPoly2Tri.TriangulationDebugContext <DebugContext>k__BackingField;
        public readonly System.Collections.Generic.List<FerrPoly2Tri.DelaunayTriangle> Triangles;
        public readonly System.Collections.Generic.List<FerrPoly2Tri.TriangulationPoint> Points;
        private FerrPoly2Tri.TriangulationMode <TriangulationMode>k__BackingField;
        private FerrPoly2Tri.ITriangulatable <Triangulatable>k__BackingField;
        private int <StepCount>k__BackingField;
        private bool <IsDebugEnabled>k__BackingField;
        
        // Properties
        public FerrPoly2Tri.TriangulationDebugContext DebugContext { get; set; }
        public FerrPoly2Tri.TriangulationMode TriangulationMode { get; set; }
        public FerrPoly2Tri.ITriangulatable Triangulatable { get; set; }
        public int StepCount { get; set; }
        public abstract FerrPoly2Tri.TriangulationAlgorithm Algorithm { get; }
        public virtual bool IsDebugEnabled { get; set; }
        public FerrPoly2Tri.DTSweepDebugContext DTDebugContext { get; }
        
        // Methods
        public FerrPoly2Tri.TriangulationDebugContext get_DebugContext()
        {
        
        }
        protected void set_DebugContext(FerrPoly2Tri.TriangulationDebugContext value)
        {
            this.<DebugContext>k__BackingField = value;
        }
        public FerrPoly2Tri.TriangulationMode get_TriangulationMode()
        {
        
        }
        protected void set_TriangulationMode(FerrPoly2Tri.TriangulationMode value)
        {
            this.<TriangulationMode>k__BackingField = value;
        }
        public FerrPoly2Tri.ITriangulatable get_Triangulatable()
        {
        
        }
        private void set_Triangulatable(FerrPoly2Tri.ITriangulatable value)
        {
            this.<Triangulatable>k__BackingField = value;
        }
        public int get_StepCount()
        {
            return (int)this.<StepCount>k__BackingField;
        }
        private void set_StepCount(int value)
        {
            this.<StepCount>k__BackingField = value;
        }
        public void Done()
        {
            int val_1 = this.<StepCount>k__BackingField;
            val_1 = val_1 + 1;
            this.<StepCount>k__BackingField = val_1;
        }
        public abstract FerrPoly2Tri.TriangulationAlgorithm get_Algorithm(); // 0
        public virtual void PrepareTriangulation(FerrPoly2Tri.ITriangulatable t)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_3 = 22969870;
            this.<Triangulatable>k__BackingField = t;
            val_3 = 0;
            val_4 = 0;
            val_3 = val_3 + 1;
            val_4 = (uint)val_3 & 65535;
            val_5 = t;
            this.<TriangulationMode>k__BackingField = t;
            val_4 = 0;
            val_3 = 0;
            val_4 = val_4 + 1;
            val_3 = (uint)val_4 & 65535;
            val_6 = t;
            goto mem[(1152921504927133696 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public abstract FerrPoly2Tri.TriangulationConstraint NewConstraint(FerrPoly2Tri.TriangulationPoint a, FerrPoly2Tri.TriangulationPoint b); // 0
        public void Update(string message)
        {
        
        }
        public virtual void Clear()
        {
            this.Points.Clear();
            this.<StepCount>k__BackingField = 0;
        }
        public virtual bool get_IsDebugEnabled()
        {
            return (bool)this.<IsDebugEnabled>k__BackingField;
        }
        protected virtual void set_IsDebugEnabled(bool value)
        {
            this.<IsDebugEnabled>k__BackingField = value;
        }
        public FerrPoly2Tri.DTSweepDebugContext get_DTDebugContext()
        {
            if((this.<DebugContext>k__BackingField) == 0)
            {
                    return;
            }
            
            if(((FerrPoly2Tri.TriangulationDebugContext.__il2cppRuntimeField_typeHierarchy + (mem[536885837]) << 2) + -4) != 536885657)
            {
                    this.<DebugContext>k__BackingField = 0;
            }
        
        }
        protected TriangulationContext()
        {
            536877843 = new System.Collections.Generic.List<Page>();
            this.Triangles = 536877843;
            536878451 = new System.Collections.Generic.List<SingleRange>(capacity:  200);
            this.Points = 536878451;
        }
    
    }

}
