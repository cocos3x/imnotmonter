using UnityEngine;

namespace AFramework
{
    public class UnityMainThreadDispatcher : SingletonMono<AFramework.UnityMainThreadDispatcher>
    {
        // Fields
        private static readonly System.Collections.Generic.Queue<System.Action> _executionQueue;
        
        // Methods
        public void Update()
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = 536896335;
            if(((mem[536896522] & true) == 0) && (mem[536896451] == 0))
            {
                    val_3 = 536896335;
            }
            
            System.Threading.Monitor.Enter(obj:  mem[536896427], lockTaken: ref  bool val_1 = true);
            label_11:
            val_4 = 536896335;
            if(((mem[536896522] & true) == 0) && (mem[536896451] == 0))
            {
                    val_4 = 536896335;
            }
            
            if((mem[536896427] + 20) < 1)
            {
                goto label_6;
            }
            
            val_5 = 536896335;
            if(((mem[536896522] & true) == 0) && (mem[536896451] == 0))
            {
                    val_5 = 536896335;
            }
            
            CFNetwork.GetProxyData val_2 = mem[536896427].Dequeue();
            mem[536896427].Invoke();
            goto label_11;
            label_6:
            if(0 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  mem[536896427]);
            }
            
            if(1 == 0)
            {
                    return;
            }
            
            var val_3 = 1 - 1;
        }
        public void Enqueue(System.Collections.IEnumerator action)
        {
            var val_4;
            var val_5;
            UnityMainThreadDispatcher.<>c__DisplayClass2_0 val_1 = 536902151;
            val_1 = new UnityMainThreadDispatcher.<>c__DisplayClass2_0();
            if(val_1 != 0)
            {
                    mem[536902159] = this;
            }
            else
            {
                    mem[8] = this;
            }
            
            mem[536902163] = action;
            val_4 = 536896335;
            if(((mem[536896522] & true) == 0) && (mem[536896451] == 0))
            {
                    val_4 = 536896335;
            }
            
            System.Threading.Monitor.Enter(obj:  mem[536896427], lockTaken: ref  bool val_2 = true);
            val_5 = 536896335;
            if(((mem[536896522] & true) == 0) && (mem[536896451] == 0))
            {
                    val_5 = 536896335;
            }
            
            536882991 = new System.Action(object:  536902151, method:  new IntPtr(1610687003));
            mem[536896427].Enqueue(item:  536882991);
            if(0 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  mem[536896427]);
            }
            
            if(1 == 0)
            {
                    return;
            }
            
            var val_4 = 1 - 1;
        }
        public void Enqueue(System.Action action)
        {
            System.Collections.IEnumerator val_1 = this.ActionWrapper(a:  action);
            this.Enqueue(action:  1164269680);
        }
        private System.Collections.IEnumerator ActionWrapper(System.Action a)
        {
            536902153 = new UnityMainThreadDispatcher.<ActionWrapper>d__4(<>1__state:  0);
            mem[536902169] = a;
        }
        public UnityMainThreadDispatcher()
        {
        
        }
        private static UnityMainThreadDispatcher()
        {
            536879309 = new System.Collections.Generic.Queue<CFNetwork.GetProxyData>();
            mem2[0] = 536879309;
        }
    
    }

}
