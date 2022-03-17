using UnityEngine;
public class ChangeDirectionCharacter : MonoBehaviour
{
    // Fields
    private bool isLeft;
    
    // Methods
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if((collision.CompareTag(tag:  -1610605337)) == false)
        {
                return;
        }
        
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem2[0] = this.isLeft;
        mem[3221266323].SetScale();
        UnityEngine.GameObject val_3 = this.gameObject;
        this.SetActive(value:  false);
    }
    public ChangeDirectionCharacter()
    {
    
    }

}
