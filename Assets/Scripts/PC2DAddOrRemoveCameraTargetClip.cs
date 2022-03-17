using UnityEngine;
[Serializable]
public class PC2DAddOrRemoveCameraTargetClip : PlayableAsset, ITimelineClipAsset
{
    // Fields
    public PC2DAddOrRemoveCameraTargetBehaviour template;
    public UnityEngine.ExposedReference<UnityEngine.Transform> cameraTarget;
    private UnityEngine.Timeline.TimelineClip <ClipReference>k__BackingField;
    
    // Properties
    public UnityEngine.Timeline.TimelineClip ClipReference { get; set; }
    public UnityEngine.Timeline.ClipCaps clipCaps { get; }
    
    // Methods
    public UnityEngine.Timeline.TimelineClip get_ClipReference()
    {
    
    }
    public void set_ClipReference(UnityEngine.Timeline.TimelineClip value)
    {
        this.<ClipReference>k__BackingField = value;
    }
    public UnityEngine.Timeline.ClipCaps get_clipCaps()
    {
    
    }
    public override UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
    {
        uint val_7;
        IntPtr val_8;
        UnityEngine.Playables.ScriptPlayable<T> val_1 = UnityEngine.Playables.ScriptPlayable<PC2DAddOrRemoveCameraTargetBehaviour>.Create(graph:  new UnityEngine.Playables.PlayableGraph() {m_Handle = new IntPtr(857837184), m_Version = graph.m_Version}, template:  owner, inputCount:  graph.m_Handle + 12);
        UnityEngine.Timeline.TimelinePlayable val_2 = 0.GetBehaviour();
        UnityEngine.IExposedPropertyTable val_3 = graph.m_Version.GetResolver();
        UnityEngine.Transform val_5 = graph.m_Handle + 16.Resolve(resolver:  857837192);
        UnityEngine.Playables.Playable val_6 = UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimelinePlayable>.op_Implicit(playable:  new UnityEngine.Playables.ScriptPlayable<T>() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = new IntPtr(857837176)}});
        return new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = val_8, m_Version = val_7}};
    }
    public PC2DAddOrRemoveCameraTargetClip()
    {
        UnityEngine.Playables.PlayableBehaviour val_1 = 536891437;
        val_1 = new UnityEngine.Playables.PlayableBehaviour();
        this.template = val_1;
    }

}
