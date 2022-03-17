using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DTriggerRails : BaseTrigger
    {
        // Fields
        public static string TriggerName;
        public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DRails ProCamera2DRails;
        public Com.LuisPedroFonseca.ProCamera2D.TriggerRailsMode Mode;
        public float TransitionDuration;
        
        // Methods
        private void Start()
        {
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if(1061282896 == 0)
            {
                    return;
            }
            
            if(this.ProCamera2DRails == 0)
            {
                    CutTheRope.Script.RopeCutter val_4 = UnityEngine.Object.FindObjectOfType<CutTheRope.Script.RopeCutter>();
                this.ProCamera2DRails = -1073688265;
            }
            
            if((-1073688265) != 0)
            {
                    return;
            }
            
            UnityEngine.Debug.LogWarning(message:  -1610605097);
        }
        protected override void EnteredTrigger()
        {
            this.EnteredTrigger();
            if(this.Mode == 1)
            {
                    this.ProCamera2DRails.EnableTargets(transitionDuration:  null);
                return;
            }
            
            this.ProCamera2DRails.DisableTargets(transitionDuration:  null);
        }
        public ProCamera2DTriggerRails()
        {
            this.TransitionDuration = 1f;
        }
        private static ProCamera2DTriggerRails()
        {
            mem2[0] = -1610605099;
        }
    
    }

}
