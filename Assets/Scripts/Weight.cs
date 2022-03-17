using UnityEngine;
public class Weight : MonoBehaviour
{
    // Fields
    public float distanceFromChainEnd;
    private System.Collections.Generic.List<UnityEngine.Transform> listWeightPoint;
    public System.Collections.Generic.Dictionary<int, UnityEngine.HingeJoint2D> listJoint;
    
    // Methods
    private void OnEnable()
    {
        this.listJoint.Clear();
    }
    public void ConnectRopeEnd(UnityEngine.Rigidbody2D endRB, int point = 0, int order = 0, bool useLimitAngle = False, float lowerAngle = 0, float upperAngle = 0)
    {
        float val_5;
        float val_6;
        var val_10;
        bool val_12;
        UnityEngine.GameObject val_1 = this.gameObject;
        SynchronizationContextBehavoir val_2 = this.AddComponent<SynchronizationContextBehavoir>();
        this.listJoint.Add(key:  order, value:  631387792);
        if(this != 0)
        {
                this.autoConfigureConnectedAnchor = false;
            val_10 = this;
        }
        else
        {
                val_10 = 0;
            0.autoConfigureConnectedAnchor = false;
        }
        
        this.connectedBody = endRB;
        if(this != 0)
        {
                if(this <= point)
        {
                var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_10 = val_10 + (point << 2);
            UnityEngine.Vector3 val_3 = localPosition;
        }
        else
        {
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        }
        
        val_10.anchor = new UnityEngine.Vector2() {x = val_5, y = val_6};
        val_12 = useLimitAngle;
        val_10.connectedAnchor = new UnityEngine.Vector2() {x = 0f, y = this.distanceFromChainEnd ^ 2147483648};
        if(val_12 == false)
        {
                return;
        }
        
        this.useLimits = true;
        0.min = val_4.x;
        0.max = val_4.x;
        val_12 = 0;
        this.limits = new UnityEngine.JointAngleLimits2D() {m_LowerAngle = 0f, m_UpperAngle = 0f};
    }
    public void DestroyRope()
    {
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        this.connectedBody = 0;
    }
    public Weight()
    {
        this.distanceFromChainEnd = 0.6f;
        536878437 = new System.Collections.Generic.List<Page>();
        this.listWeightPoint = 536878437;
        536874205 = new System.Collections.Generic.Dictionary<System.Int32, LayoutCache>();
        this.listJoint = 536874205;
    }

}
