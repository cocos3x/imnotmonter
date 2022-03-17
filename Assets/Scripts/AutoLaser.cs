using UnityEngine;
public class AutoLaser : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject Laser;
    private float time1;
    private float time2;
    private float timeDelay;
    private ItemAudio audio;
    
    // Methods
    private void Start()
    {
        DropdownItem val_1 = this.Laser.GetComponentInChildren<DropdownItem>();
        this.Laser.SetLaserState(enabledStatus:  false);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(methodName:  -1610608799);
    }
    private System.Collections.IEnumerator DelayAuto()
    {
        536898073 = new AutoLaser.<DelayAuto>d__6(<>1__state:  0);
        mem[536898089] = this;
    }
    private System.Collections.IEnumerator Auto()
    {
        536898071 = new AutoLaser.<Auto>d__7(<>1__state:  0);
        mem[536898087] = this;
    }
    public void StopAuto()
    {
        this.StopCoroutine(methodName:  -1610608799);
        this.StopCoroutine(methodName:  -1610610013);
        DropdownItem val_1 = this.Laser.GetComponentInChildren<DropdownItem>();
        this.Laser.SetLaserState(enabledStatus:  false);
    }
    public void PlayAuto()
    {
        this.StopCoroutine(methodName:  -1610608799);
        this.StopCoroutine(methodName:  -1610610013);
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  -1610610013);
    }
    public AutoLaser()
    {
    
    }

}
