using UnityEngine;
public class PC2DAddOrRemoveCameraTargetTrack : TrackAsset
{
    // Methods
    public override UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount)
    {
        uint val_10;
        uint val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TimelineClip> val_1 = graph.m_Handle.GetClips();
        IntPtr val_14 = graph.m_Handle;
        if((graph.m_Handle + 178) == 0)
        {
            goto label_2;
        }
        
        var val_13 = 0;
        label_4:
        val_12 = 0;
        if((graph.m_Handle + 88 + 0) == 536876421)
        {
            goto label_3;
        }
        
        val_13 = val_13 + 1;
        val_12 = (uint)val_13 & 65535;
        if(val_12 < (graph.m_Handle + 178))
        {
            goto label_4;
        }
        
        label_2:
        val_13 = graph.m_Handle;
        goto label_5;
        label_3:
        var val_2 = (graph.m_Handle + 88) + 0;
        val_14 = val_14 + (((graph.m_Handle + 88 + 0) + 4) << 3);
        val_13 = val_14 + 188;
        label_5:
        label_24:
        IntPtr val_15 = graph.m_Handle;
        if((graph.m_Handle + 178) == 0)
        {
            goto label_7;
        }
        
        val_12 = 0;
        label_9:
        if((graph.m_Handle + 88 + 0) == 536888219)
        {
            goto label_8;
        }
        
        val_12 = val_12 + 1;
        if(((uint)val_12 & 65535) < (graph.m_Handle + 178))
        {
            goto label_9;
        }
        
        label_7:
        val_14 = graph.m_Handle;
        goto label_10;
        label_8:
        var val_3 = (graph.m_Handle + 88) + 0;
        val_15 = val_15 + (((graph.m_Handle + 88 + 0) + 4) << 3);
        val_14 = val_15 + 188;
        label_10:
        if(graph.m_Handle == new IntPtr(0))
        {
            goto label_11;
        }
        
        IntPtr val_17 = graph.m_Handle;
        if((graph.m_Handle + 178) == 0)
        {
            goto label_13;
        }
        
        var val_16 = 0;
        label_15:
        if((graph.m_Handle + 88 + 0) == 536876693)
        {
            goto label_14;
        }
        
        val_16 = val_16 + 1;
        if(((uint)val_16 & 65535) < (graph.m_Handle + 178))
        {
            goto label_15;
        }
        
        label_13:
        val_15 = graph.m_Handle;
        goto label_16;
        label_14:
        var val_4 = (graph.m_Handle + 88) + 0;
        val_17 = val_17 + (((graph.m_Handle + 88 + 0) + 4) << 3);
        val_15 = val_17 + 188;
        label_16:
        val_16 = 0;
        if(((graph.m_Handle + 32) != 0) && ((graph.m_Handle + 32 + 180) >= mem[536891621]))
        {
                var val_18 = graph.m_Handle + 32 + 100;
            val_18 = val_18 + (mem[536891621] << 2);
            if(((graph.m_Handle + 32 + 100 + (mem[536891621]) << 2) + -4) != 536891441)
        {
                graph.m_Handle + 32 = 0;
        }
        
            val_16 = graph.m_Handle + 32;
        }
        
        if(0 == 0)
        {
            goto label_24;
        }
        
        mem[24] = graph.m_Handle;
        goto label_24;
        label_11:
        if(graph.m_Handle == new IntPtr(0))
        {
            goto label_25;
        }
        
        IntPtr val_19 = graph.m_Handle;
        if((graph.m_Handle + 178) == 0)
        {
            goto label_26;
        }
        
        val_12 = 0;
        label_28:
        if((graph.m_Handle + 88 + 0) == 536888187)
        {
            goto label_27;
        }
        
        val_12 = val_12 + 1;
        if(((uint)val_12 & 65535) < (graph.m_Handle + 178))
        {
            goto label_28;
        }
        
        label_26:
        val_17 = graph.m_Handle;
        goto label_29;
        label_27:
        var val_6 = (graph.m_Handle + 88) + 0;
        val_19 = val_19 + (((graph.m_Handle + 88 + 0) + 4) << 3);
        val_17 = val_19 + 188;
        label_29:
        label_25:
        if(1 != 0)
        {
                var val_7 = 1 - 1;
        }
        
        UnityEngine.Playables.ScriptPlayable<T> val_9 = UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimelinePlayable>.Create(graph:  new UnityEngine.Playables.PlayableGraph() {m_Handle = new IntPtr(858301560), m_Version = graph.m_Version}, inputCount:  go);
        UnityEngine.Playables.Playable val_12 = UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimelinePlayable>.op_Implicit(playable:  new UnityEngine.Playables.ScriptPlayable<T>() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = new IntPtr(858301560), m_Version = val_10}});
        return new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = val_10, m_Version = val_11}};
    }
    public PC2DAddOrRemoveCameraTargetTrack()
    {
        if((mem[536895854] & true) != 0)
        {
                return;
        }
        
        if(mem[536895783] != 0)
        {
                return;
        }
    
    }

}
