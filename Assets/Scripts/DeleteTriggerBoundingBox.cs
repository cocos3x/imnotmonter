using UnityEngine;
public class DeleteTriggerBoundingBox : MonoBehaviour
{
    // Fields
    public UnityEngine.ParticleSystem[] SteamPS;
    private UnityEngine.Color c;
    
    // Methods
    private void Start()
    {
        goto label_1;
        label_10:
        UnityEngine.ParticleSystem val_2 = this.SteamPS[0];
        DropdownItem val_1 = UnityEngine.Object.Instantiate<DropdownItem>(original:  val_2);
        this.SteamPS[1] = val_2;
        1 = 2;
        label_1:
        if(1 < (this.SteamPS + 20))
        {
            goto label_10;
        }
    
    }
    public void DeleteOnCollide(UnityEngine.GameObject drop, UnityEngine.GameObject other)
    {
        this.Delete(drop:  drop, another:  other);
    }
    private void Delete(UnityEngine.GameObject drop, UnityEngine.GameObject another)
    {
        float val_10;
        float val_11;
        float val_12;
        float val_12;
        UnityEngine.ParticleSystem[] val_13;
        var val_14;
        val_12 = drop;
        val_13 = another.GetInstanceID();
        UnityEngine.GameObject val_2 = this.gameObject;
        val_14 = this;
        if(val_13 != another.GetInstanceID())
        {
                return;
        }
        
        Weight val_4 = val_12.GetComponent<Weight>();
        val_12.Active = false;
        val_14 = 4;
        goto label_6;
        label_12:
        bool val_5 = this.SteamPS[0].isPlaying;
        if(val_5 == false)
        {
            goto label_10;
        }
        
        val_14 = 5;
        label_6:
        val_13 = this.SteamPS;
        if((val_14 - 4) < val_5)
        {
            goto label_12;
        }
        
        return;
        label_10:
        UnityEngine.ParticleSystem val_14 = this.SteamPS[0];
        UnityEngine.Transform val_7 = val_14.transform;
        UnityEngine.Transform val_8 = val_12.transform;
        UnityEngine.Vector3 val_9 = position;
        val_12 = val_11;
        val_13 = val_12;
        val_14.position = new UnityEngine.Vector3() {x = val_10, y = val_12, z = val_13};
        this.SteamPS[0].Play();
    }
    public DeleteTriggerBoundingBox()
    {
        UnityEngine.Color val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
    }

}
