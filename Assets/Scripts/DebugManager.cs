using UnityEngine;
public class DebugManager : SingletonMonoBehaviour<DebugManager>
{
    // Fields
    public bool DEBUG;
    
    // Methods
    public void Log(object message)
    {
        if(this.DEBUG == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  message);
    }
    public void LogError(object message)
    {
        if(this.DEBUG == false)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  message);
    }
    public DebugManager()
    {
        this.DEBUG = true;
    }

}
