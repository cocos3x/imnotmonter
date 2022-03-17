using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
    public class EnemyAttack : MonoBehaviour
    {
        // Fields
        public float RotationSpeed;
        public Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.Pool BulletPool;
        public UnityEngine.Transform WeaponTip;
        public float FireRate;
        public float FireAngleRandomness;
        private bool _hasTarget;
        private UnityEngine.Transform _target;
        private UnityEngine.AI.NavMeshAgent _navMeshAgent;
        private UnityEngine.Transform _transform;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.transform;
            this._transform = this;
            UnityEngine.UI.Toggle val_2 = this.GetComponentInChildren<UnityEngine.UI.Toggle>();
            this._navMeshAgent = this;
        }
        public void Attack(UnityEngine.Transform target)
        {
            this._navMeshAgent.updateRotation = false;
            this._target = target;
            this._hasTarget = true;
            System.Collections.IEnumerator val_1 = this.LookAtTarget();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1086529712);
            System.Collections.IEnumerator val_3 = this.FollowTarget();
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  1086529712);
            System.Collections.IEnumerator val_5 = this.Fire();
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  1086529712);
        }
        public void StopAttack()
        {
            this._navMeshAgent.updateRotation = true;
            this._hasTarget = false;
        }
        private System.Collections.IEnumerator LookAtTarget()
        {
            536898805 = new EnemyAttack.<LookAtTarget>d__12(<>1__state:  0);
            mem[536898821] = this;
        }
        private System.Collections.IEnumerator FollowTarget()
        {
            536898803 = new EnemyAttack.<FollowTarget>d__13(<>1__state:  0);
            mem[536898819] = this;
        }
        private System.Collections.IEnumerator Fire()
        {
            536898801 = new EnemyAttack.<Fire>d__14(<>1__state:  0);
            mem[536898817] = this;
        }
        public static UnityEngine.Vector2 RandomOnUnitCircle2(float radius)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Random.insideUnitCircle;
            0.Normalize();
            float val_3 = R1;
            float val_2 = 0f;
            val_2 = val_2 * val_3;
            val_3 = 0 * val_3;
            mem[4] = val_2;
            mem2[0] = val_3;
            return new UnityEngine.Vector2() {x = val_3, y = val_1.y};
        }
        public EnemyAttack()
        {
            this.RotationSpeed = 2f;
            this.FireRate = 0.3f;
            this.FireAngleRandomness = 10f;
        }
    
    }

}
