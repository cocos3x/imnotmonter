using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
    public class PlayerFire : MonoBehaviour
    {
        // Fields
        public Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.Pool BulletPool;
        public UnityEngine.Transform WeaponTip;
        public float FireRate;
        public float FireShakeForce;
        public float FireShakeDuration;
        private UnityEngine.Transform _transform;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.transform;
            this._transform = this;
        }
        private void Update()
        {
            var val_6 = this;
            if((UnityEngine.Input.GetKeyDown(key:  32)) != true)
            {
                    if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
            {
                    return;
            }
            
            }
            
            System.Collections.IEnumerator val_3 = R4.Fire();
            UnityEngine.Coroutine val_4 = R4.StartCoroutine(routine:  R4);
        }
        private System.Collections.IEnumerator Fire()
        {
            536900347 = new PlayerFire.<Fire>d__8(<>1__state:  0);
            mem[536900363] = this;
        }
        public PlayerFire()
        {
            this.FireRate = 0.3f;
            this.FireShakeForce = 0.2f;
            this.FireShakeDuration = 0.05f;
        }
    
    }

}
