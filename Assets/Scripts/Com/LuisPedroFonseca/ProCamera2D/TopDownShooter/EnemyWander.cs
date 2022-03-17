using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
    public class EnemyWander : MonoBehaviour
    {
        // Fields
        public float WanderDuration;
        public float WaypointOffset;
        public float WanderRadius;
        private UnityEngine.AI.NavMeshAgent _navMeshAgent;
        private bool _hasReachedDestination;
        private UnityEngine.Vector3 _startingPos;
        private float _startingTime;
        
        // Methods
        private void Awake()
        {
            UnityEngine.UI.Toggle val_1 = this.GetComponentInChildren<UnityEngine.UI.Toggle>();
            this._navMeshAgent = this;
            UnityEngine.Transform val_2 = this._navMeshAgent.transform;
            UnityEngine.Vector3 val_3 = position;
        }
        public void StartWandering()
        {
            float val_1 = UnityEngine.Time.time;
            this._startingTime = 0f;
            this.GoToWaypoint();
            System.Collections.IEnumerator val_2 = this.CheckAgentPosition();
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  1092503728);
        }
        public void StopWandering()
        {
            this.StopAllCoroutines();
        }
        private System.Collections.IEnumerator CheckAgentPosition()
        {
            536898815 = new EnemyWander.<CheckAgentPosition>d__10(<>1__state:  0);
            mem[536898831] = this;
        }
        private void GoToWaypoint()
        {
            var val_3;
            var val_4;
            var val_5;
            float val_12;
            float val_13;
            float val_14;
            UnityEngine.AI.NavMeshPath val_1 = 536890993;
            val_1 = new UnityEngine.AI.NavMeshPath();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            val_12 = val_3;
            val_13 = val_4;
            val_14 = val_5;
            goto label_1;
            label_6:
            UnityEngine.Vector3 val_6 = UnityEngine.Random.insideUnitSphere;
            val_12 = this._startingPos;
            val_14 = S10;
            val_13 = S8 + S8;
            bool val_8 = this._navMeshAgent.CalculatePath(targetPosition:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14}, path:  val_1);
            label_1:
            UnityEngine.AI.NavMeshPathStatus val_9 = val_1.status;
            if(val_1 == 1)
            {
                goto label_6;
            }
            
            UnityEngine.AI.NavMeshPathStatus val_10 = val_1.status;
            if(val_1 == 2)
            {
                goto label_6;
            }
            
            bool val_11 = this._navMeshAgent.SetDestination(target:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14});
            this._hasReachedDestination = false;
        }
        public EnemyWander()
        {
            this.WanderDuration = 10f;
            this.WaypointOffset = 0.1f;
            this.WanderRadius = 10f;
        }
    
    }

}
