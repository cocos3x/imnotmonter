using UnityEngine;

namespace Dmobin.Analytics
{
    public interface IAnalytic
    {
        // Properties
        public abstract bool InitSuccess { get; set; }
        
        // Methods
        public abstract bool get_InitSuccess(); // 0
        public abstract void set_InitSuccess(bool value); // 0
        public abstract void Init(string[] args); // 0
        public abstract void TrackEvent(string eventName); // 0
        public abstract void TrackEvent(string eventName, System.Collections.Generic.Dictionary<string, object> parameters); // 0
        public abstract void ApplicationOnPause(bool Paused); // 0
    
    }

}
