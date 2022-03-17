using UnityEngine;
public class LaserAutoShoot : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject Laser;
    
    // Methods
    private void Start()
    {
        DropdownItem val_1 = this.Laser.GetComponentInChildren<DropdownItem>();
        this.Laser.SetLaserState(enabledStatus:  false);
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        UnityEngine.GameObject val_1 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610607725)) == false)
        {
                return;
        }
        
        DropdownItem val_3 = this.Laser.GetComponentInChildren<DropdownItem>();
        this.Laser.SetLaserState(enabledStatus:  true);
    }
    public LaserAutoShoot()
    {
    
    }

}
