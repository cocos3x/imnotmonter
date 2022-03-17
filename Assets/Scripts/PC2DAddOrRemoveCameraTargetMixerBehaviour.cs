using UnityEngine;
public class PC2DAddOrRemoveCameraTargetMixerBehaviour : PlayableBehaviour
{
    // Fields
    private float _currentTime;
    
    // Methods
    public override void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData)
    {
        IntPtr val_4;
        uint val_5;
        var val_11;
        var val_15;
        uint val_16;
        IntPtr val_17;
        float val_18;
        val_15 = this;
        val_16 = playable.m_Handle.m_Version;
        val_17 = playable.m_Handle.m_Handle;
        int val_1 = UnityEngine.Playables.PlayableExtensions.GetInputCount<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = val_17, m_Version = val_16}});
        UnityEngine.Playables.PlayableGraph val_2 = UnityEngine.Playables.PlayableExtensions.GetGraph<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = new IntPtr(858069376), m_Version = val_17}});
        UnityEngine.Playables.Playable val_3 = GetRootPlayable(index:  858069376);
        double val_6 = UnityEngine.Playables.PlayableExtensions.GetTime<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = val_4, m_Version = val_5}});
        if(val_1 > 0)
        {
                var val_16 = 0;
            do
        {
            UnityEngine.Playables.Playable val_7 = UnityEngine.Playables.PlayableExtensions.GetInput<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = new IntPtr(858069360), m_Version = val_17}}, inputPort:  val_16);
            val_15 = val_5;
            UnityEngine.Playables.ScriptPlayable<T> val_8 = UnityEngine.Playables.ScriptPlayable<PC2DAddOrRemoveCameraTargetBehaviour>.op_Explicit(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = new IntPtr(858069360), m_Version = val_4}});
            UnityEngine.Timeline.TimelinePlayable val_9 = val_4.GetBehaviour();
            if(UnityEngine.Application.isPlaying != false)
        {
                val_16 = val_16;
            if(val_11 <= 0)
        {
                val_16 = val_16;
            if(val_11 < 0)
        {
                var val_15 = mem[536892269];
            val_15 = val_15 & 512;
            if(0 != 0)
        {
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_12 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2D.Instance;
            0.RemoveCameraTarget(targetTransform:  0, duration:  null);
            val_16 = val_16;
        }
        else
        {
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_13 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2D.Instance;
            val_15 = 0;
            Com.LuisPedroFonseca.ProCamera2D.CameraTarget val_14 = val_15.AddCameraTarget(targetTransform:  0, targetInfluenceH:  null, targetInfluenceV:  null, duration:  null, targetOffset:  new UnityEngine.Vector2() {x = 1f, y = 1f});
        }
        
        }
        
        }
        
        }
        
            val_16 = val_16 + 1;
            val_17 = val_17;
        }
        while(val_1 != val_16);
        
            val_18 = this._currentTime;
        }
        else
        {
                val_18 = this._currentTime;
        }
        
        mem2[0] = ;
    }
    public PC2DAddOrRemoveCameraTargetMixerBehaviour()
    {
    
    }

}
