using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
    public class PlayerHealth : MonoBehaviour
    {
        // Fields
        public int Health;
        private UnityEngine.Renderer[] _renderers;
        private UnityEngine.Color _originalColor;
        
        // Methods
        private void Awake()
        {
            T[] val_1 = this.GetComponentsInChildren<UnityEngine.TrailRenderer>();
            this._renderers = this;
            UnityEngine.Material val_2 = this._renderers[0].material;
            UnityEngine.Color val_3 = color;
        }
        private void Hit(int damage)
        {
            int val_3 = this.Health;
            val_3 = val_3 - damage;
            this.Health = val_3;
            System.Collections.IEnumerator val_1 = this.HitAnim();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1096844208);
        }
        private System.Collections.IEnumerator HitAnim()
        {
            536900349 = new PlayerHealth.<HitAnim>d__5(<>1__state:  0);
            mem[536900365] = this;
        }
        public PlayerHealth()
        {
            this.Health = 100;
        }
    
    }

}
