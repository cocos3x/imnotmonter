using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
    public class Goal : MonoBehaviour
    {
        // Fields
        public Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.GameOver GameOverScreen;
        
        // Methods
        private void OnTriggerEnter(UnityEngine.Collider other)
        {
            this.GameOverScreen.ShowScreen();
        }
        public Goal()
        {
        
        }
    
    }

}
