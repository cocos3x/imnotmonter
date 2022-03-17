using UnityEngine;
public class LaserDetect : MonoBehaviour
{
    // Fields
    private TwoDLaserPack.SpriteBasedLaser allLasersInScene;
    private bool bossDamaged;
    
    // Methods
    private void Start()
    {
        536901447 = new SpriteBasedLaser.LaserHitTriggerHandler(object:  695296656, method:  new IntPtr(1610679913));
        this.allLasersInScene.add_OnLaserHitTriggered(value:  536901447);
        this.allLasersInScene.SetLaserState(enabledStatus:  true);
    }
    private void LaserOnOnLaserHitTriggered(UnityEngine.RaycastHit2D hitInfo)
    {
        UnityEngine.Collider2D val_1 = hitInfo.m_Centroid.x.collider;
        UnityEngine.GameObject val_2 = hitInfo.m_Centroid.x.gameObject;
        if((hitInfo.m_Centroid.x.CompareTag(tag:  -1610607703)) != false)
        {
                UnityEngine.Collider2D val_4 = hitInfo.m_Centroid.x.collider;
            UnityEngine.GameObject val_5 = hitInfo.m_Centroid.x.gameObject;
            Weight val_6 = hitInfo.m_Centroid.x.GetComponent<Weight>();
            if((UnityEngine.Object.op_Implicit(exists:  695404780)) != false)
        {
                hitInfo.m_Centroid.x.Dead();
        }
        
        }
        
        UnityEngine.Collider2D val_8 = hitInfo.m_Centroid.x.collider;
        UnityEngine.GameObject val_9 = hitInfo.m_Centroid.x.gameObject;
        if(((hitInfo.m_Centroid.x.CompareTag(tag:  -1610609907)) != false) && (this.bossDamaged != true))
        {
                UnityEngine.Collider2D val_11 = hitInfo.m_Centroid.x.collider;
            UnityEngine.Transform val_12 = hitInfo.m_Centroid.x.transform;
            UnityEngine.Transform val_13 = hitInfo.m_Centroid.x.parent;
            UnityEngine.Transform val_14 = hitInfo.m_Centroid.x.GetComponent<UnityEngine.Transform>();
            if((UnityEngine.Object.op_Implicit(exists:  695404780)) != false)
        {
                this.bossDamaged = true;
            hitInfo.m_Centroid.x.SetDesplayHeath(valueHeath:  1);
        }
        
        }
        
        UnityEngine.Collider2D val_16 = hitInfo.m_Centroid.x.collider;
        if((hitInfo.m_Centroid.x.CompareTag(tag:  -1610609921)) == false)
        {
                return;
        }
        
        UnityEngine.Collider2D val_18 = hitInfo.m_Centroid.x.collider;
        UnityEngine.Transform val_19 = hitInfo.m_Centroid.x.GetComponent<UnityEngine.Transform>();
        if(695404780 == 0)
        {
                return;
        }
        
        UnityEngine.Collider2D val_21 = hitInfo.m_Centroid.x.collider;
        UnityEngine.Transform val_22 = hitInfo.m_Centroid.x.GetComponent<UnityEngine.Transform>();
        hitInfo.m_Centroid.x.Explosion();
    }
    public LaserDetect()
    {
    
    }

}
