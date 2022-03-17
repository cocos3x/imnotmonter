using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
    public class EnemyPatrol : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform PathContainer;
        public float WaypointOffset;
        public bool Loop;
        public bool IsPaused;
        private UnityEngine.AI.NavMeshAgent _navMeshAgent;
        private System.Collections.Generic.List<UnityEngine.Transform> _path;
        private int _currentWaypoint;
        private bool _hasReachedDestination;
        private float _stopTime;
        
        // Methods
        private void Awake()
        {
            System.Collections.Generic.List<UnityEngine.Transform> val_8;
            UnityEngine.Transform val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            UnityEngine.UI.Toggle val_1 = this.GetComponentInChildren<UnityEngine.UI.Toggle>();
            this._navMeshAgent = this;
            536878437 = new System.Collections.Generic.List<Page>();
            val_8 = this._path;
            this._path = 536878437;
            val_9 = this.PathContainer;
            if(val_9 == 0)
            {
                goto label_29;
            }
            
            System.Collections.IEnumerator val_4 = this.PathContainer.GetEnumerator();
            label_20:
            var val_9 = 0;
            val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = (uint)val_9 & 65535;
            val_10 = this.PathContainer;
            if(this.PathContainer == 0)
            {
                goto label_10;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_11 = this.PathContainer;
            this._path.SyncRoot.Add(item:  0);
            goto label_20;
            label_10:
            val_8 = 0;
            val_12 = 22711796;
            if(this.PathContainer != 0)
            {
                    val_12 = 0;
                val_12 = val_12 + 1;
                val_13 = this.PathContainer;
            }
            
            if(1 != 0)
            {
                    var val_8 = 1 - 1;
                if((1152921509991445924 + ((1 - 1)) << 2) == 112)
            {
                    return;
            }
            
            }
            
            label_29:
            UnityEngine.Debug.LogWarning(message:  -1610606047);
        }
        private void Update()
        {
            int val_8;
            float val_9;
            float val_10;
            float val_11;
            float val_12;
            if(this.IsPaused != false)
            {
                    return;
            }
            
            float val_1 = this._navMeshAgent.remainingDistance;
            if(this._navMeshAgent > 0)
            {
                goto label_14;
            }
            
            if(this._hasReachedDestination == true)
            {
                goto label_4;
            }
            
            val_8 = this._currentWaypoint;
            this._hasReachedDestination = true;
            if(true <= val_8)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + (val_8 << 2);
            UnityEngine.Transform val_2 = (0 + (this._currentWaypoint) << 2) + 16.GetComponent<UnityEngine.Transform>();
            if(((0 + (this._currentWaypoint) << 2) + 16) == 0)
            {
                goto label_10;
            }
            
            if(((0 + (this._currentWaypoint) << 2) + 16) != 0)
            {
                    val_9 = mem[(0 + (this._currentWaypoint) << 2) + 16 + 16];
                val_9 = (0 + (this._currentWaypoint) << 2) + 16 + 16;
                val_10 = mem[(0 + (this._currentWaypoint) << 2) + 16 + 20];
                val_10 = (0 + (this._currentWaypoint) << 2) + 16 + 20;
                val_11 = val_9;
                val_12 = val_10;
            }
            else
            {
                    val_8 = 16;
                val_11 = 3.673424E-39f;
                val_12 = 1.401298E-45f;
                val_9 = 3.673424E-39f;
                val_10 = 1.401298E-45f;
            }
            
            val_10 = val_9 + val_10;
            float val_5 = UnityEngine.Random.Range(minInclusive:  val_10, maxInclusive:  null);
            this._stopTime = val_11 - val_12;
            float val_6 = UnityEngine.Random.value;
            if(((0 + (this._currentWaypoint) << 2) + 16) < 0)
            {
                goto label_14;
            }
            
            label_10:
            this.GoToNextWaypoint();
            label_14:
            if(this._hasReachedDestination == false)
            {
                    return;
            }
            
            label_4:
            float val_7 = UnityEngine.Time.deltaTime;
            uint val_9 = 0;
            val_9 = this._stopTime - val_9;
            this._stopTime = val_9;
            if(this._hasReachedDestination > false)
            {
                    return;
            }
            
            this.GoToNextWaypoint();
        }
        public void StartPatrol()
        {
            this.GoToWaypoint(waypoint:  0);
        }
        public void PausePatrol()
        {
            this.IsPaused = true;
            this._navMeshAgent.isStopped = true;
        }
        public void ResumePatrol()
        {
            this.GoToWaypoint(waypoint:  this._currentWaypoint);
        }
        private void GoToNextWaypoint()
        {
            int val_2;
            bool val_1 = true;
            val_1 = val_1 - 1;
            if(this._currentWaypoint >= val_1)
            {
                goto label_2;
            }
            
            val_2 = this._currentWaypoint + 1;
            goto label_3;
            label_2:
            if(this.Loop == false)
            {
                goto label_4;
            }
            
            val_2 = 0;
            label_3:
            this._currentWaypoint = val_2;
            label_7:
            this.GoToWaypoint(waypoint:  0);
            return;
            label_4:
            UnityEngine.Debug.Log(message:  -1610605411);
            goto label_7;
        }
        private void GoToWaypoint(int waypoint)
        {
            float val_2;
            float val_5;
            float val_7;
            this._hasReachedDestination = false;
            this.IsPaused = false;
            this._currentWaypoint = waypoint;
            if(false <= waypoint)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + (waypoint << 2);
            UnityEngine.Vector3 val_1 = position;
            UnityEngine.Transform val_3 = this._navMeshAgent.transform;
            UnityEngine.Vector3 val_4 = position;
            if(1090360996 <= this._currentWaypoint)
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_10 + (this._currentWaypoint << 2);
            UnityEngine.Vector3 val_6 = position;
            bool val_8 = this._navMeshAgent.SetDestination(target:  new UnityEngine.Vector3() {x = val_2, y = val_5, z = val_7});
        }
        public EnemyPatrol()
        {
            this.Loop = true;
            this.WaypointOffset = 0.1f;
        }
    
    }

}
