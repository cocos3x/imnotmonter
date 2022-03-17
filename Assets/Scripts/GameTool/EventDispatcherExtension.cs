using UnityEngine;

namespace GameTool
{
    public static class EventDispatcherExtension
    {
        // Methods
        public static void RegisterListener(UnityEngine.MonoBehaviour sender, EventID eventID, System.Action<UnityEngine.Component, object> callback)
        {
            GameTool.EventDispatcher.RegisterListener(eventID:  eventID, callback:  callback);
        }
        public static void RemoveListener(UnityEngine.MonoBehaviour sender, EventID eventID, System.Action<UnityEngine.Component, object> callback)
        {
            GameTool.EventDispatcher.RemoveListener(eventID:  eventID, callback:  callback);
        }
        public static void PostEvent(UnityEngine.MonoBehaviour sender, EventID eventID, object param)
        {
            GameTool.EventDispatcher.PostEvent(eventID:  eventID, sender:  sender, param:  param);
        }
        public static void PostEvent(UnityEngine.MonoBehaviour sender, EventID eventID)
        {
            GameTool.EventDispatcher.PostEvent(eventID:  eventID, sender:  sender, param:  0);
        }
    
    }

}
