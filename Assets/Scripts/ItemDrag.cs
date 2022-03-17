using UnityEngine;
public class ItemDrag : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform controllItem;
    private UnityEngine.Transform targetItem;
    private UnityEngine.Vector3 dir;
    
    // Methods
    private void Start()
    {
        UnityEngine.Vector3 val_2;
        float val_3;
        float val_4;
        UnityEngine.Vector3 val_1 = position;
        UnityEngine.Vector3 val_5 = position;
        UnityEngine.Vector3 val_6 = val_2;
        float val_7 = val_3;
        float val_8 = val_4;
        val_6 = val_2 - val_6;
        val_7 = val_3 - val_7;
        val_8 = val_4 - val_8;
        this.dir = val_6;
        mem[1152921509653406120] = val_7;
        mem[1152921509653406124] = val_8;
    }
    private void Update()
    {
        float val_2;
        float val_3;
        float val_4;
        float val_7;
        float val_8;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = mem[this.dir + (0)], y = mem[this.dir + (4)], z = mem[this.dir + (8)]}, rhs:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_2})) == false)
        {
                return;
        }
        
        0 = 0;
        UnityEngine.Vector3 val_6 = position;
        float val_7 = val_3;
        float val_8 = val_4;
        val_7 = val_7 + this.dir;
        float val_9 = val_2;
        val_8 = val_8 + S8;
        val_9 = val_9 + S10;
        val_8 = val_7;
        val_7 = val_8;
        this.targetItem.position = new UnityEngine.Vector3() {x = val_8, y = val_7, z = val_9};
    }
    public ItemDrag()
    {
        this.dir = 0;
        mem[1152921509653654696] = 0;
        mem[1152921509653654700] = 0;
    }

}
