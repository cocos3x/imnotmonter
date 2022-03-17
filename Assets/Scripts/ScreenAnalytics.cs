using UnityEngine;
public class ScreenAnalytics : MonoBehaviour
{
    // Fields
    private AnalyticID.ScreenID screenID;
    private AnalyticID.ButtonID buttonID;
    private ScreenAnalytics.TrackingType trackingType;
    
    // Methods
    private void Start()
    {
        ScreenAnalytics.TrackingType val_5 = this.trackingType;
        if(val_5 == 0)
        {
                WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
            Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
            mem2[0] = mem[536897859];
            536874379.Add(key:  -1610598523, value:  536897859);
            -1073700879.TrackEvent(eventName:  -1610598521, parameters:  536874379);
            val_5 = this.trackingType;
        }
        
        if(val_5 != 1)
        {
                return;
        }
        
        UnityEngine.Transform val_3 = this.GetComponent<UnityEngine.Transform>();
        536896275 = new UnityEngine.Events.UnityAction(object:  512285232, method:  new IntPtr(1610676981));
        this.AddListener(call:  536896275);
    }
    public ScreenAnalytics()
    {
        this.trackingType = 1;
    }
    private void <Start>b__3_0()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        this.screenID = mem[536897859];
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536897841];
        536874379.Add(key:  536897859, value:  536897841);
        -1073700879.TrackEvent(eventName:  -1610598519, parameters:  536874379);
    }

}
