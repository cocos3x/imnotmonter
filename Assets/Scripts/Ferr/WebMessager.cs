using UnityEngine;

namespace Ferr
{
    public class WebMessager : MonoBehaviour
    {
        // Fields
        private static Ferr.WebMessager mInstance;
        private int activeMessages;
        private System.Action OnAllMessagesComplete;
        
        // Properties
        public static Ferr.WebMessager Instance { get; }
        
        // Methods
        public static Ferr.WebMessager get_Instance()
        {
            var val_4;
            var val_5;
            var val_6;
            val_4 = 536896955;
            if(((mem[536897142] & true) == 0) && (mem[536897071] == 0))
            {
                    val_4 = 536896955;
            }
            
            if(mem[536897047] == 0)
            {
                    536887303 = new UnityEngine.GameObject(name:  -1610601977);
                SynchronizationContextBehavoir val_3 = 536887303.AddComponent<SynchronizationContextBehavoir>();
                val_5 = 536896955;
                if(((mem[536897142] & true) == 0) && (mem[536897071] == 0))
            {
                    val_5 = 536896955;
            }
            
                mem2[0] = 536887303;
            }
            
            val_6 = 536896955;
            if((mem[536897142] & true) != 0)
            {
                    return;
            }
            
            if(mem[536897071] != 0)
            {
                    return;
            }
            
            val_6 = 536896955;
        }
        public void add_OnAllMessagesComplete(System.Action value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.OnAllMessagesComplete, b:  value);
            if(this.OnAllMessagesComplete == 0)
            {
                goto label_1;
            }
            
            val_2 = this.OnAllMessagesComplete;
            if(null == 536882991)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.OnAllMessagesComplete != 1152921510140574240)
            {
                goto label_3;
            }
        
        }
        public void remove_OnAllMessagesComplete(System.Action value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.OnAllMessagesComplete, value:  value);
            if(this.OnAllMessagesComplete == 0)
            {
                goto label_1;
            }
            
            val_2 = this.OnAllMessagesComplete;
            if(null == 536882991)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.OnAllMessagesComplete != 1152921510140702624)
            {
                goto label_3;
            }
        
        }
        private void Start()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  1239008528);
        }
        public void Post(string aTo, byte[] aData, System.Action<UnityEngine.WWW> aCallback, System.Action<UnityEngine.WWW> aOnError)
        {
            536896825 = new UnityEngine.WWWForm();
            val_1.AddBinaryData(fieldName:  -1610601591, contents:  aData);
            System.Collections.IEnumerator val_2 = this.Send(aTo:  aTo, aForm:  536896825, aCallback:  aCallback, aOnError:  aOnError);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  1239169680);
        }
        public void Post(string aTo, string aData, System.Action<UnityEngine.WWW> aCallback, System.Action<UnityEngine.WWW> aOnError)
        {
            goto label_2;
            label_6:
            mem[536881757] = aData.Chars[0];
            0 = 1;
            label_2:
            if(0 < mem[536881753])
            {
                goto label_6;
            }
            
            this.Post(aTo:  aTo, aData:  536881741, aCallback:  aCallback, aOnError:  aOnError);
        }
        public void PostForm(string aTo, UnityEngine.WWWForm aForm, System.Action<UnityEngine.WWW> aCallback, System.Action<UnityEngine.WWW> aOnError)
        {
            System.Collections.IEnumerator val_1 = this.Send(aTo:  aTo, aForm:  aForm, aCallback:  aCallback, aOnError:  aOnError);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1239491984);
        }
        public void GetText(string aTo, System.Action<string> aCallback, System.Action<UnityEngine.WWW> aOnError)
        {
            System.Collections.IEnumerator val_1 = this.Send(aTo:  aTo, aCallback:  aCallback, aOnError:  aOnError);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1239632656);
        }
        public void GetRaw(string aTo, System.Action<UnityEngine.WWW> aCallback, System.Action<UnityEngine.WWW> aOnError)
        {
            System.Collections.IEnumerator val_1 = this.Send(aTo:  aTo, aCallback:  aCallback, aOnError:  aOnError);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1239769232);
        }
        public void GetImage(string aTo, System.Action<UnityEngine.Texture> aCallback, System.Action<UnityEngine.WWW> aOnError)
        {
            System.Collections.IEnumerator val_1 = this.Send(aTo:  aTo, aCallback:  aCallback, aOnError:  aOnError);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1239905808);
        }
        private System.Collections.IEnumerator Send(string aTo, System.Action<UnityEngine.WWW> aCallback, System.Action<UnityEngine.WWW> aOnError)
        {
            WebMessager.<Send>d__14 val_1 = 536902415;
            val_1 = new WebMessager.<Send>d__14(<>1__state:  0);
            if(val_1 != 0)
            {
                    mem[536902431] = this;
                mem[536902435] = aTo;
                mem[536902439] = aCallback;
            }
            else
            {
                    mem[16] = this;
                mem[20] = aTo;
                mem[24] = aCallback;
            }
            
            mem[536902443] = aOnError;
        }
        private System.Collections.IEnumerator Send(string aTo, System.Action<string> aCallback, System.Action<UnityEngine.WWW> aOnError)
        {
            WebMessager.<Send>d__15 val_1 = 536902417;
            val_1 = new WebMessager.<Send>d__15(<>1__state:  0);
            if(val_1 != 0)
            {
                    mem[536902433] = this;
                mem[536902437] = aTo;
                mem[536902441] = aCallback;
            }
            else
            {
                    mem[16] = this;
                mem[20] = aTo;
                mem[24] = aCallback;
            }
            
            mem[536902445] = aOnError;
        }
        private System.Collections.IEnumerator Send(string aTo, System.Action<UnityEngine.Texture> aCallback, System.Action<UnityEngine.WWW> aOnError)
        {
            WebMessager.<Send>d__16 val_1 = 536902419;
            val_1 = new WebMessager.<Send>d__16(<>1__state:  0);
            if(val_1 != 0)
            {
                    mem[536902435] = this;
                mem[536902439] = aTo;
                mem[536902443] = aCallback;
            }
            else
            {
                    mem[16] = this;
                mem[20] = aTo;
                mem[24] = aCallback;
            }
            
            mem[536902447] = aOnError;
        }
        private System.Collections.IEnumerator Send(string aTo, UnityEngine.WWWForm aForm, System.Action<UnityEngine.WWW> aCallback, System.Action<UnityEngine.WWW> aOnError)
        {
            WebMessager.<Send>d__17 val_1 = 536902421;
            val_1 = new WebMessager.<Send>d__17(<>1__state:  0);
            if(val_1 != 0)
            {
                    mem[536902437] = this;
                mem[536902441] = aTo;
                mem[536902445] = aForm;
                mem[536902449] = aCallback;
            }
            else
            {
                    mem[16] = this;
                mem[20] = aTo;
                mem[24] = aForm;
                mem[28] = aCallback;
            }
            
            mem[536902453] = aOnError;
        }
        private System.Collections.IEnumerator Send(string aTo, byte[] aData, System.Action<UnityEngine.WWW> aCallback, System.Action<UnityEngine.WWW> aOnError)
        {
            WebMessager.<Send>d__18 val_1 = 536902423;
            val_1 = new WebMessager.<Send>d__18(<>1__state:  0);
            if(val_1 != 0)
            {
                    mem[536902439] = this;
                mem[536902443] = aTo;
                mem[536902447] = aData;
                mem[536902451] = aCallback;
            }
            else
            {
                    mem[16] = this;
                mem[20] = aTo;
                mem[24] = aData;
                mem[28] = aCallback;
            }
            
            mem[536902455] = aOnError;
        }
        public int GetActive()
        {
            return (int)this.activeMessages;
        }
        private void BeginMessage()
        {
            int val_1 = this.activeMessages;
            val_1 = val_1 + 1;
            this.activeMessages = val_1;
        }
        private void FinishMessage()
        {
            int val_1 = this.activeMessages;
            val_1 = val_1 - 1;
            this.activeMessages = val_1;
            if()
            {
                    return;
            }
            
            if(this.OnAllMessagesComplete == 0)
            {
                    return;
            }
            
            this.OnAllMessagesComplete.Invoke();
        }
        public WebMessager()
        {
        
        }
        private static WebMessager()
        {
        
        }
    
    }

}
