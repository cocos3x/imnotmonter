using UnityEngine;
public class EffectManager : SingletonMonoBehaviour<EffectManager>
{
    // Fields
    public UnityEngine.GameObject vfx_Bomb;
    
    // Methods
    public void CreateBloodEffect(UnityEngine.Vector3 pos, bool isSaw, int idSkin = 0, bool botHasSkin = False)
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.GameObject val_2 = -1073701087.GetItem(itemType:  -1610609931);
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.GameObject val_4 = -1073701087.GetItem(itemType:  -1610608591);
        Weight val_5 = -1073701087.GetComponent<Weight>();
        if((-1073701087) != 0)
        {
                -1073701087.ChangeForce(isSaw:  false, id:  idSkin, botHasSkin:  botHasSkin);
        }
        else
        {
                -1073701087.ChangeForce(isSaw:  false, id:  idSkin, botHasSkin:  botHasSkin);
        }
        
        UnityEngine.Transform val_6 = -1073701087.transform;
        UnityEngine.Transform val_7 = -1073701087.transform;
        -1073701087.position = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
        -1073701087.position = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
        WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701087.Despaw(go:  -1073701087, delay:  null);
    }
    public EffectManager()
    {
    
    }

}
