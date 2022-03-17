using UnityEngine;

namespace AnimToolUI
{
    [Serializable]
    public class AnimUI
    {
        // Fields
        public UnityEngine.GameObject parentObj;
        public DG.Tweening.Ease easeAnim;
        public float timeDelay;
        public float timeScale;
        public float timeDelayChildren;
        public UnityEngine.GameObject[] childrenObj;
        
        // Methods
        public AnimUI()
        {
            this.easeAnim = 27;
        }
    
    }

}
