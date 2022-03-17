using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
    public class EnemyFSM : MonoBehaviour
    {
        // Fields
        public int Health;
        public UnityEngine.Color AttackColor;
        public Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.DoorKey Key;
        private Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.EnemySight _sight;
        private Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.EnemyAttack _attack;
        private Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.EnemyWander _wander;
        private UnityEngine.Renderer[] _renderers;
        private UnityEngine.Color _originalColor;
        private UnityEngine.Color _currentColor;
        
        // Methods
        private void Awake()
        {
            var val_13;
            var val_14;
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            this._sight = this;
            UnityEngine.Transform val_2 = this.GetComponent<UnityEngine.Transform>();
            this._attack = this;
            UnityEngine.Transform val_3 = this.GetComponent<UnityEngine.Transform>();
            this._wander = this;
            T[] val_4 = this.GetComponentsInChildren<UnityEngine.TrailRenderer>();
            this._renderers = this;
            UnityEngine.Material val_5 = this._renderers[0].material;
            UnityEngine.Color val_6 = color;
            536873355 = new System.Action<SdkConfiguration>(object:  1088084016, method:  new IntPtr(1610685829));
            System.Delegate val_8 = System.Delegate.Combine(a:  this._sight.OnPlayerInSight, b:  536873355);
            val_13 = this._sight.OnPlayerInSight;
            if(val_13 != 0)
            {
                    if(null == 536873355)
            {
                goto label_8;
            }
            
            }
            
            val_13 = 0;
            label_8:
            mem2[0] = val_13;
            536882991 = new System.Action(object:  1088084016, method:  new IntPtr(1610685831));
            System.Delegate val_10 = System.Delegate.Combine(a:  mem[this._sight] + 16, b:  536882991);
            val_14 = mem[this._sight] + 16;
            if(val_14 != 0)
            {
                    if(val_14 == 536882991)
            {
                goto label_12;
            }
            
            }
            
            val_14 = 0;
            label_12:
            mem2[0] = val_14;
            if(this.Key == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_12 = this.Key.gameObject;
            this.Key.SetActive(value:  false);
        }
        private void Start()
        {
            this._wander.StartWandering();
        }
        private void OnDestroy()
        {
            var val_5;
            var val_6;
            536873355 = new System.Action<SdkConfiguration>(object:  1088389936, method:  new IntPtr(1610685829));
            System.Delegate val_2 = System.Delegate.Remove(source:  this._sight.OnPlayerInSight, value:  536873355);
            val_5 = this._sight.OnPlayerInSight;
            if(val_5 != 0)
            {
                    if(null == 536873355)
            {
                goto label_4;
            }
            
            }
            
            val_5 = 0;
            label_4:
            mem2[0] = val_5;
            536882991 = new System.Action(object:  1088389936, method:  new IntPtr(1610685831));
            System.Delegate val_4 = System.Delegate.Remove(source:  this._sight.OnPlayerOutOfSight, value:  536882991);
            val_6 = this._sight.OnPlayerOutOfSight;
            if(val_6 != 0)
            {
                    if(null == 536882991)
            {
                goto label_8;
            }
            
            }
            
            val_6 = 0;
            label_8:
            mem2[0] = val_6;
        }
        private void Hit(int damage)
        {
            int val_3 = this.Health;
            if(val_3 < 1)
            {
                    return;
            }
            
            val_3 = val_3 - damage;
            this.Health = val_3;
            System.Collections.IEnumerator val_1 = this.HitAnim();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1088518320);
            if(this.Health > 0)
            {
                    return;
            }
            
            R4.Die();
        }
        private System.Collections.IEnumerator HitAnim()
        {
            536898809 = new EnemyFSM.<HitAnim>d__13(<>1__state:  0);
            mem[536898825] = this;
        }
        private void OnPlayerInSight(UnityEngine.Transform obj)
        {
            this._wander.StopAllCoroutines();
            this._attack.Attack(target:  obj);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2D.Instance;
            UnityEngine.Transform val_2 = this.transform;
            Com.LuisPedroFonseca.ProCamera2D.CameraTarget val_3 = 0.AddCameraTarget(targetTransform:  1088754608, targetInfluenceH:  null, targetInfluenceV:  null, duration:  null, targetOffset:  new UnityEngine.Vector2() {x = 1f, y = 1f});
            mem[1152921509990568960] = 0f;
            this.Colorize(color:  new UnityEngine.Color() {r = mem[this.AttackColor + (0)], g = mem[this.AttackColor + (4)], b = mem[this.AttackColor + (8)], a = 0f});
        }
        private void OnPlayerOutOfSight()
        {
            this._wander.StartWandering();
            this._attack.StopAttack();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2D.Instance;
            UnityEngine.Transform val_2 = this.transform;
            0.RemoveCameraTarget(targetTransform:  1088887088, duration:  null);
            mem[1152921509990701440] = 0f;
            this.Colorize(color:  new UnityEngine.Color() {r = mem[this._originalColor + (0)], g = mem[this._originalColor + (4)], b = mem[this._originalColor + (8)], a = 0f});
        }
        private void Colorize(UnityEngine.Color color)
        {
            var val_2 = 0;
            goto label_0;
            label_6:
            UnityEngine.Renderer val_2 = this._renderers[val_2];
            UnityEngine.Material val_1 = val_2.material;
            val_2.color = new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a};
            val_2 = 1;
            label_0:
            if(val_2 < val_2)
            {
                goto label_6;
            }
        
        }
        private void DropLoot()
        {
            var val_6;
            float val_7;
            var val_8;
            if(this.Key == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = this.Key.gameObject;
            this.Key.SetActive(value:  true);
            UnityEngine.Transform val_3 = this.Key.transform;
            UnityEngine.Transform val_4 = this.transform;
            UnityEngine.Vector3 val_5 = position;
            float val_11 = 3f;
            float val_10 = 0f;
            float val_9 = val_7;
            val_9 = val_9 + val_10;
            val_10 = val_8 + val_10;
            val_11 = val_6 + val_11;
            this.Key.position = new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_9};
        }
        private void Die()
        {
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake val_1 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake.Instance;
            0.Shake(presetName:  -1610604489);
            this.OnPlayerOutOfSight();
            this.DropLoot();
            UnityEngine.GameObject val_2 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  1089411504, t:  null);
        }
        public EnemyFSM()
        {
            this.Health = 100;
            UnityEngine.Color val_1 = UnityEngine.Color.red;
        }
    
    }

}
