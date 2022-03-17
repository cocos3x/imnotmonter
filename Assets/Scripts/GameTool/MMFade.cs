using UnityEngine;

namespace GameTool
{
    public static class MMFade
    {
        // Methods
        public static System.Collections.IEnumerator FadeImage(UnityEngine.UI.Image target, float duration, UnityEngine.Color color)
        {
            var val_1;
            MMFade.<FadeImage>d__0 val_2 = 536899705;
            val_2 = new MMFade.<FadeImage>d__0(<>1__state:  0);
            if(val_2 != 0)
            {
                    mem[536899721] = target;
                mem[536899741] = color.r;
            }
            else
            {
                    mem[16] = target;
                mem[36] = color.r;
            }
            
            var val_3 = val_2 + 20;
            mem[536899737] = val_1;
        }
        public static System.Collections.IEnumerator FadeText(UnityEngine.UI.Text target, float duration, UnityEngine.Color color)
        {
            var val_1;
            MMFade.<FadeText>d__1 val_2 = 536899709;
            val_2 = new MMFade.<FadeText>d__1(<>1__state:  0);
            if(val_2 != 0)
            {
                    mem[536899725] = target;
                mem[536899745] = color.r;
            }
            else
            {
                    mem[16] = target;
                mem[36] = color.r;
            }
            
            var val_3 = val_2 + 20;
            mem[536899741] = val_1;
        }
        public static System.Collections.IEnumerator FadeSprite(UnityEngine.SpriteRenderer target, float duration, UnityEngine.Color color)
        {
            var val_1;
            MMFade.<FadeSprite>d__2 val_2 = 536899707;
            val_2 = new MMFade.<FadeSprite>d__2(<>1__state:  0);
            if(val_2 != 0)
            {
                    mem[536899723] = target;
                mem[536899743] = color.r;
            }
            else
            {
                    mem[16] = target;
                mem[36] = color.r;
            }
            
            var val_3 = val_2 + 20;
            mem[536899739] = val_1;
        }
        public static System.Collections.IEnumerator FadeCanvasGroup(UnityEngine.CanvasGroup target, float duration, float targetAlpha, bool unscaled = True)
        {
            float val_2 = R2;
            MMFade.<FadeCanvasGroup>d__3 val_1 = 536899703;
            val_1 = new MMFade.<FadeCanvasGroup>d__3(<>1__state:  0);
            if(val_1 != 0)
            {
                    val_2 = val_1;
                mem[536899719] = target;
                mem[536899723] = val_2;
                mem[536899731] = unscaled;
            }
            else
            {
                    mem[16] = target;
                mem[28] = unscaled;
                mem[20] = val_2;
            }
            
            mem[536899727] = R3;
        }
    
    }

}
