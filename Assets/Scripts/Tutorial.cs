using UnityEngine;
public class Tutorial : SingletonMonoBehaviour<Tutorial>
{
    // Fields
    private UnityEngine.GameObject[] stepTutorial;
    public bool[] Tut_Part;
    
    // Methods
    private void Start()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CurrentLevelRope) != 1)
        {
                return;
        }
        
        R4.CheckStepTutoral(id:  0);
    }
    public void CheckStepTutoral(int id)
    {
        var val_5;
        var val_6;
        if(this <= id)
        {
            goto label_1;
        }
        
        if(this.Tut_Part[id] == true)
        {
                return;
        }
        
        val_5 = 0;
        goto label_4;
        label_9:
        var val_1 = (R4 + 12) + 0;
        (R4 + 12 + 0) + 16.SetActive(value:  (R5 - val_5) >> 5);
        val_5 = 1;
        label_4:
        val_6 = mem[R4 + 12];
        val_6 = R4 + 12;
        if(val_5 < (R4 + 12 + 12))
        {
            goto label_9;
        }
        
        return;
        label_1:
        val_6 = 0;
        goto label_11;
        label_16:
        UnityEngine.GameObject val_5 = this.stepTutorial[val_6];
        val_5.SetActive(value:  false);
        val_6 = 1;
        label_11:
        if(val_6 < val_5)
        {
            goto label_16;
        }
    
    }
    public void SetCompletPart(int id)
    {
        this.Tut_Part[id] = true;
        this.CheckStepTutoral(id:  id + 1);
    }
    public Tutorial()
    {
    
    }

}
