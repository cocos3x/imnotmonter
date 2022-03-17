using UnityEngine;

namespace Dmobin.FirebaseService
{
    public static class FirebaseInstance
    {
        // Fields
        private static Firebase.FirebaseApp sInstance;
        private static System.Action EventOnInitSuccess;
        private static bool sIsInitializing;
        
        // Properties
        public static bool HasInstance { get; }
        
        // Methods
        public static bool get_HasInstance()
        {
            if(((mem[536887142] & true) == 0) && (mem[536887071] == 0))
            {
                    536886955 = 536886955;
            }
            
            if(mem[536887047] != 0)
            {
                    mem[536887047] = 1;
            }
            
            return true;
        }
        public static void CheckAndTryInit(System.Action callback)
        {
            System.Delegate val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            object val_17;
            var val_18;
            var val_19;
            object val_20;
            System.Action<SdkConfiguration> val_21;
            val_10 = callback;
            val_11 = 22711044;
            bool val_1 = Dmobin.FirebaseService.FirebaseInstance.HasInstance;
            if(val_1 != false)
            {
                    val_10.Invoke();
                return;
            }
            
            val_12 = 536886955;
            val_13 = 0;
            var val_7 = mem[536887141];
            val_7 = val_7 & 512;
            if(val_1 != false)
            {
                    if(mem[536887071] != 0)
            {
                    val_13 = val_7;
            }
            else
            {
                    val_12 = 536886955;
                val_13 = mem[536887141] & 512;
            }
            
            }
            
            val_14 = val_12;
            val_15 = mem[536887047];
            val_16 = val_15;
            val_17 = mem[mem[536887047] + 8];
            val_17 = mem[536887047] + 8;
            if(val_17 == 0)
            {
                goto label_8;
            }
            
            if((val_13 != 0) && (mem[536887071] == 0))
            {
                    val_15 = mem[536887047];
            }
            
            System.Delegate val_2 = System.Delegate.Combine(a:  mem[536887047] + 4, b:  val_10);
            val_16 = mem[536887047] + 4;
            if(val_16 != 0)
            {
                    if(val_16 == 536882991)
            {
                goto label_12;
            }
            
            }
            
            val_16 = 0;
            label_12:
            mem2[0] = val_16;
            val_14 = val_16;
            val_12 = mem[536887047] + 4;
            label_8:
            if((val_13 != 0) && ((mem[536887047] + 4 + 116) == 0))
            {
                    val_14 = mem[R5];
                val_14 = R5;
                val_16 = (R5 + 92) + 8;
            }
            
            mem2[0] = 1;
            System.Delegate val_3 = System.Delegate.Combine(a:  R5 + 92 + 4, b:  R4);
            val_18 = R5 + 92 + 4;
            if(val_18 != 0)
            {
                    if(val_18 == 536882991)
            {
                goto label_16;
            }
            
            }
            
            val_18 = 0;
            label_16:
            mem2[0] = val_18;
            System.Threading.Tasks.Task<Firebase.DependencyStatus> val_4 = Firebase.FirebaseApp.CheckAndFixDependenciesAsync();
            val_19 = 536899019;
            if(((mem[536899206] & true) == 0) && (mem[536899135] == 0))
            {
                    val_19 = 536899019;
            }
            
            val_20 = mem[536899111];
            val_21 = mem[mem[536899111] + 4];
            val_21 = mem[536899111] + 4;
            if(val_21 == 0)
            {
                    if(((mem[536899206] & true) == 0) && (mem[536899135] == 0))
            {
                    val_20 = mem[536899111];
            }
            
                val_17 = mem[mem[536899111]];
                val_17 = val_20;
                val_21 = 536873217;
                val_21 = new System.Action<SdkConfiguration>(object:  val_17, method:  new IntPtr(1610686735));
                mem2[0] = val_21;
            }
            
            System.Threading.Tasks.Task val_6 = Firebase.Extensions.TaskExtension.ContinueWithOnMainThread<System.Int32Enum>(task:  0, continuation:  536873217);
        }
        private static FirebaseInstance()
        {
        
        }
    
    }

}
