using UnityEngine;
public class BreakObject : MonoBehaviour
{
    // Methods
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        UnityEngine.GameObject val_1 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610607725)) == false)
        {
                return;
        }
        
        this.DestroyObject();
    }
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        UnityEngine.GameObject val_1 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610607725)) == false)
        {
                return;
        }
        
        this.DestroyObject();
    }
    private void DestroyObject()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    public BreakObject()
    {
    
    }

}
