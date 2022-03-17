using UnityEngine;

namespace Dmobin.FirebaseService
{
    public class FirebaseMessaging : MonoBehaviour
    {
        // Fields
        public static System.Action<Firebase.Messaging.TokenReceivedEventArgs> EventOnTokenReceived;
        public static System.Action<Firebase.Messaging.MessageReceivedEventArgs> EventOnMessageReceived;
        private static string <FirebaseMessagingToken>k__BackingField;
        
        // Properties
        public static string FirebaseMessagingToken { get; set; }
        
        // Methods
        public static string get_FirebaseMessagingToken()
        {
        
        }
        protected static void set_FirebaseMessagingToken(string value)
        {
            mem2[0] = value;
        }
        private void Start()
        {
            536882991 = new System.Action(object:  1146980464, method:  new IntPtr(1610686743));
            Dmobin.FirebaseService.FirebaseInstance.CheckAndTryInit(callback:  536882991);
        }
        private void Init()
        {
            536874909 = new System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs>(object:  1147092464, method:  new IntPtr(1610686745));
            Firebase.Messaging.FirebaseMessaging.add_TokenReceived(value:  536874909);
            536874901 = new System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs>(object:  1147092464, method:  new IntPtr(1610686747));
            Firebase.Messaging.FirebaseMessaging.add_MessageReceived(value:  536874901);
        }
        private void OnTokenReceived(object sender, Firebase.Messaging.TokenReceivedEventArgs token)
        {
            var val_1 = 4427064;
            val_1 = 18573456 + val_1;
            if(val_1 == 0)
            {
                    mem2[0] = 1;
            }
            
            mem2[0] = token.<Token>k__BackingField;
            if(mem[536887055] == 0)
            {
                    return;
            }
            
            mem[536887055].Invoke(obj:  token);
        }
        private void OnMessageReceived(object sender, Firebase.Messaging.MessageReceivedEventArgs e)
        {
            if((mem[536887055] + 4) == 0)
            {
                    return;
            }
            
            mem[536887055] + 4.Invoke(obj:  e);
        }
        public FirebaseMessaging()
        {
        
        }
    
    }

}
