using UnityEngine;
public class RopeManager : MonoBehaviour
{
    // Fields
    public static RopeManager Instance;
    public RopeNode[] ropeNode;
    
    // Methods
    private void Awake()
    {
        mem2[0] = this;
    }
    public void UnUseRope(RopeNode _ropeNote)
    {
        _ropeNote.hingeJoin2D.enabled = false;
        goto label_2;
        label_9:
        UnityEngine.Transform val_1 = _ropeNote.gRopeParent.transform;
        UnityEngine.Transform val_2 = _ropeNote.gRopeParent.GetChild(index:  0);
        UnityEngine.GameObject val_3 = _ropeNote.gRopeParent.gameObject;
        _ropeNote.gRopeParent.SetActive(value:  false);
        0 = 1;
        label_2:
        UnityEngine.Transform val_4 = _ropeNote.gRopeParent.transform;
        if(0 < _ropeNote.gRopeParent.childCount)
        {
            goto label_9;
        }
    
    }
    public void UnUseRope(int _ropeIdex)
    {
        UnityEngine.Debug.LogError(message:  -1610603159);
        System.Collections.IEnumerator val_1 = this.HideAllRope(_index:  _ropeIdex);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  649531408);
    }
    private System.Collections.IEnumerator HideAllRope(int _index)
    {
        RopeManager.<HideAllRope>d__5 val_1 = 536900821;
        val_1 = new RopeManager.<HideAllRope>d__5(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536900837] = this;
        }
        else
        {
                mem[16] = this;
        }
        
        mem[536900841] = _index;
    }
    private void Start()
    {
    
    }
    public RopeManager()
    {
    
    }

}
