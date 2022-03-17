using UnityEngine;
[Serializable]
public class PC2DAddOrRemoveCameraTargetBehaviour : PlayableBehaviour
{
    // Fields
    public UnityEngine.Transform cameraTarget;
    public PC2DAddOrRemoveCameraTarget action;
    private UnityEngine.Timeline.TimelineClip <ClipReference>k__BackingField;
    
    // Properties
    public UnityEngine.Timeline.TimelineClip ClipReference { get; set; }
    public float ClipStartTime { get; }
    
    // Methods
    public UnityEngine.Timeline.TimelineClip get_ClipReference()
    {
    
    }
    public void set_ClipReference(UnityEngine.Timeline.TimelineClip value)
    {
        this.<ClipReference>k__BackingField = value;
    }
    public float get_ClipStartTime()
    {
        if((this.<ClipReference>k__BackingField) != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    public override void OnGraphStart(UnityEngine.Playables.Playable playable)
    {
        if(this.action == 0)
        {
                22792384 = 22781712;
        }
        
        this.<ClipReference>k__BackingField.m_DisplayName = -1610610319;
        this.OnGraphStart(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}});
    }
    public PC2DAddOrRemoveCameraTargetBehaviour()
    {
    
    }

}
