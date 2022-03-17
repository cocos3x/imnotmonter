using UnityEngine;

namespace AnimToolUI
{
    public class AnimUIManager : MonoBehaviour
    {
        // Fields
        public AnimToolUI.AnimUIManager.AnimType animTypeOpen;
        public AnimToolUI.AnimUIManager.AnimType animTypeClose;
        public bool useAnimChildren;
        public bool useTimeChildren;
        private float timeScale;
        private float timeDelayOpen;
        private float timeDelayClose;
        private float timeDelayOpenChildren;
        private AnimToolUI.AnimUI[] animObj;
        public System.Action OnClose;
        private UnityEngine.WaitForSecondsRealtime waitForSecondsRealtimeScale;
        private UnityEngine.WaitForSecondsRealtime waitForSecondsRealtimeDelay;
        
        // Methods
        private void OnEnable()
        {
            this.Init();
        }
        public void Init()
        {
            UnityEngine.WaitForSecondsRealtime val_1 = 536896855;
            val_1 = new UnityEngine.WaitForSecondsRealtime(time:  null);
            this.waitForSecondsRealtimeScale = val_1;
            UnityEngine.WaitForSecondsRealtime val_2 = 536896855;
            val_2 = new UnityEngine.WaitForSecondsRealtime(time:  null);
            this.waitForSecondsRealtimeDelay = val_2;
            this.animTypeOpen = 2;
            System.Collections.IEnumerator val_3 = this.AnimPopupCustom();
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  1112959792);
        }
        private System.Collections.IEnumerator AnimPopupSequence()
        {
            536897897 = new AnimUIManager.<AnimPopupSequence>d__14(<>1__state:  0);
            mem[536897913] = this;
        }
        private System.Collections.IEnumerator AnimPopupTogether()
        {
            536897899 = new AnimUIManager.<AnimPopupTogether>d__15(<>1__state:  0);
            mem[536897915] = this;
        }
        private System.Collections.IEnumerator AnimPopupCustom()
        {
            536897895 = new AnimUIManager.<AnimPopupCustom>d__16(<>1__state:  0);
            mem[536897911] = this;
        }
        private System.Collections.IEnumerator AnimChildren(int i)
        {
            AnimUIManager.<AnimChildren>d__17 val_1 = 536897893;
            val_1 = new AnimUIManager.<AnimChildren>d__17(<>1__state:  0);
            if(val_1 != 0)
            {
                    mem[536897909] = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            mem[536897913] = i;
        }
        public void CloseAnim()
        {
            var val_6;
            var val_7;
            val_6 = this;
            GameTool.EventDispatcherExtension.PostEvent(sender:  1113523888, eventID:  19);
            if(this.animTypeClose == 2)
            {
                goto label_0;
            }
            
            if(this.animTypeClose == 1)
            {
                goto label_1;
            }
            
            if(this.animTypeClose != 0)
            {
                    return;
            }
            
            val_7 = R4;
            System.Collections.IEnumerator val_1 = val_7.CloseAnimPopupSequence();
            goto label_3;
            label_0:
            val_7 = val_6;
            System.Collections.IEnumerator val_2 = this.CloseAnimCustom();
            goto label_3;
            label_1:
            val_7 = val_6;
            System.Collections.IEnumerator val_3 = this.CloseAnimTogether();
            label_3:
            UnityEngine.Coroutine val_4 = val_7.StartCoroutine(routine:  1113523888);
        }
        private System.Collections.IEnumerator CloseAnimTogether()
        {
            536897905 = new AnimUIManager.<CloseAnimTogether>d__19(<>1__state:  0);
            mem[536897921] = this;
        }
        private System.Collections.IEnumerator CloseAnimCustom()
        {
            536897901 = new AnimUIManager.<CloseAnimCustom>d__20(<>1__state:  0);
            mem[536897917] = this;
        }
        private System.Collections.IEnumerator CloseAnimPopupSequence()
        {
            536897903 = new AnimUIManager.<CloseAnimPopupSequence>d__21(<>1__state:  0);
            mem[536897919] = this;
        }
        private void AnimChildrenClose(int i)
        {
            var val_6;
            var val_7;
            val_6 = 22998958;
            if(this.useAnimChildren == false)
            {
                    return;
            }
            
            AnimToolUI.AnimUI val_6 = this.animObj[i];
            if(this.animObj[i] == null)
            {
                goto label_6;
            }
            
            val_7 = 0;
            val_6 = 22768632;
            goto label_7;
            label_18:
            AnimToolUI.AnimUI val_7 = this.animObj[i];
            UnityEngine.GameObject val_8 = this.animObj[i][0].childrenObj[val_7];
            UnityEngine.Transform val_1 = val_8.transform;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_8, endValue:  new UnityEngine.Vector3(), duration:  this.timeScale);
            DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  val_8, ease:  26);
            DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  val_8, isIndependentUpdate:  true);
            val_7 = 1;
            label_7:
            AnimToolUI.AnimUI val_9 = this.animObj[i];
            if(val_7 < this.animObj[i])
            {
                goto label_18;
            }
            
            return;
            label_6:
            UnityEngine.Debug.LogError(message:  -1610610505);
        }
        public AnimUIManager()
        {
        
        }
    
    }

}
