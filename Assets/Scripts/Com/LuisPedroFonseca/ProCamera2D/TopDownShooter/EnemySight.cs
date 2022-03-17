using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
    public class EnemySight : MonoBehaviour
    {
        // Fields
        public System.Action<UnityEngine.Transform> OnPlayerInSight;
        public System.Action OnPlayerOutOfSight;
        public float RefreshRate;
        public float fieldOfViewAngle;
        public float ViewDistance;
        public bool playerInSight;
        public UnityEngine.Transform player;
        public UnityEngine.LayerMask LayerMask;
        private UnityEngine.RaycastHit _hit;
        
        // Methods
        private void Awake()
        {
            float val_2 = -0.2f;
            float val_3 = 0.2f;
            val_2 = this.RefreshRate * val_2;
            val_3 = this.RefreshRate * val_3;
            float val_1 = UnityEngine.Random.Range(minInclusive:  val_2, maxInclusive:  null);
            float val_4 = val_2;
            val_4 = this.RefreshRate + val_4;
            this.RefreshRate = val_4;
        }
        private System.Collections.IEnumerator Start()
        {
            536898813 = new EnemySight.<Start>d__10(<>1__state:  0);
            mem[536898829] = this;
        }
        public EnemySight()
        {
            this.RefreshRate = 1f;
            this.fieldOfViewAngle = 110f;
            this.ViewDistance = 30f;
        }
    
    }

}
