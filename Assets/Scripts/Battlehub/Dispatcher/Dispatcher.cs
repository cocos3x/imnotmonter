using UnityEngine;

namespace Battlehub.Dispatcher
{
    public class Dispatcher : MonoBehaviour
    {
        // Fields
        private Battlehub.Dispatcher.Dispatcher m_current;
        private static Battlehub.Dispatcher.Dispatcher <Current>k__BackingField;
        private int m_lock;
        private bool m_run;
        private System.Collections.Generic.Queue<System.Action> m_wait;
        
        // Properties
        public static Battlehub.Dispatcher.Dispatcher Current { get; set; }
        
        // Methods
        public static Battlehub.Dispatcher.Dispatcher get_Current()
        {
        
        }
        private static void set_Current(Battlehub.Dispatcher.Dispatcher value)
        {
            mem2[0] = value;
        }
        public void BeginInvoke(System.Action action)
        {
            do
            {
            
            }
            while((System.Threading.Interlocked.Exchange(location1: ref  this.m_lock, value:  1)) != 0);
            
            this.m_wait.Enqueue(item:  action);
            this.m_run = true;
            int val_4 = System.Threading.Interlocked.Exchange(location1: ref  this.m_lock, value:  0);
        }
        private void Awake()
        {
            var val_3 = 18537243;
            val_3 = 4432312 + val_3;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            if(mem[536886099] != 0)
            {
                    if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
                UnityEngine.Object.Destroy(obj:  mem[536886099]);
            }
            
            var val_4 = 18537032;
            val_4 = 4432524 + val_4;
            if(val_4 == 0)
            {
                    mem2[0] = 1;
            }
            
            mem2[0] = this;
            536879309 = new System.Collections.Generic.Queue<CFNetwork.GetProxyData>();
            this.m_wait = 536879309;
        }
        private void Update()
        {
            if(this.m_run == false)
            {
                    return;
            }
            
            if((System.Threading.Interlocked.Exchange(location1: ref  this.m_lock, value:  1)) != 0)
            {
                    return;
            }
            
            536879309 = new System.Collections.Generic.Queue<UnityEngine.Transform>(capacity:  R7);
            goto label_4;
            label_8:
            System.Action val_4 = this.m_wait.Dequeue();
            536879309.Enqueue(item:  this.m_wait);
            label_4:
            if(536879309 != 0)
            {
                goto label_8;
            }
            
            this.m_run = false;
            int val_6 = System.Threading.Interlocked.Exchange(location1: ref  this.m_lock, value:  0);
            if(536879309 != 0)
            {
                goto label_9;
            }
            
            return;
            label_12:
            CFNetwork.GetProxyData val_7 = 536879309.Dequeue();
            536879309.Invoke();
            label_9:
            if(mem[536879329] != 0)
            {
                goto label_12;
            }
        
        }
        public Dispatcher()
        {
        
        }
    
    }

}
