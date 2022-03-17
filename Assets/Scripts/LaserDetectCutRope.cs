using UnityEngine;
public class LaserDetectCutRope : MonoBehaviour
{
    // Fields
    private TwoDLaserPack.SpriteBasedLaser allLasersInScene;
    
    // Methods
    private void Start()
    {
        536901447 = new SpriteBasedLaser.LaserHitTriggerHandler(object:  604806416, method:  new IntPtr(1610678437));
        this.allLasersInScene.add_OnLaserHitTriggered(value:  536901447);
        this.allLasersInScene.SetLaserState(enabledStatus:  true);
    }
    private void LaserOnOnLaserHitTriggered(UnityEngine.RaycastHit2D hitInfo)
    {
        UnityEngine.Collider2D val_1 = hitInfo.m_Centroid.x.collider;
        UnityEngine.GameObject val_2 = hitInfo.m_Centroid.x.gameObject;
        if((hitInfo.m_Centroid.x.CompareTag(tag:  -1610607703)) != false)
        {
                WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266339].Dead();
            WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead(huggyDeadType:  1);
            WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701079.Lose();
        }
        
        UnityEngine.Collider2D val_7 = hitInfo.m_Centroid.x.collider;
        UnityEngine.GameObject val_8 = hitInfo.m_Centroid.x.gameObject;
        if((hitInfo.m_Centroid.x.CompareTag(tag:  -1610605337)) != false)
        {
                WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266339].Dead();
            WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701079.Lose();
        }
        
        UnityEngine.Collider2D val_12 = hitInfo.m_Centroid.x.collider;
        UnityEngine.GameObject val_13 = hitInfo.m_Centroid.x.gameObject;
        if((hitInfo.m_Centroid.x.CompareTag(tag:  -1610608497)) != false)
        {
                UnityEngine.Collider2D val_15 = hitInfo.m_Centroid.x.collider;
            UnityEngine.Transform val_16 = hitInfo.m_Centroid.x.GetComponent<UnityEngine.Transform>();
            hitInfo.m_Centroid.x.Dead(enemyDeadBy:  3);
        }
        
        UnityEngine.Collider2D val_17 = hitInfo.m_Centroid.x.collider;
        if((hitInfo.m_Centroid.x.CompareTag(tag:  -1610609921)) == false)
        {
                return;
        }
        
        UnityEngine.Collider2D val_19 = hitInfo.m_Centroid.x.collider;
        UnityEngine.GameObject val_20 = hitInfo.m_Centroid.x.gameObject;
        Weight val_21 = hitInfo.m_Centroid.x.GetComponent<Weight>();
        hitInfo.m_Centroid.x.Detonate();
    }
    public LaserDetectCutRope()
    {
    
    }

}
