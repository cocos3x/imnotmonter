using UnityEngine;
public class StoryPopup : BaseUIMenu
{
    // Fields
    private UnityEngine.Animator animator;
    private UnityEngine.UI.Button btn_Skip;
    
    // Methods
    private System.Collections.IEnumerator Start()
    {
        536901509 = new StoryPopup.<Start>d__2(<>1__state:  0);
        mem[536901525] = this;
    }
    private void PlayAnimStory()
    {
        this.animator.Play(stateName:  -1610604341, layer:  0, normalizedTime:  null);
    }
    public void CompletedStory()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.ShowCompletedStory) != false)
        {
                return;
        }
        
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.ShowCompletedStory = true;
        this.LoadLevel();
    }
    private void LoadLevel()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536882991 = new System.Action(object:  855547792, method:  new IntPtr(1610682309));
        -1073700871.StartFade(action:  536882991);
    }
    private void ShowPic()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610604581, volume:  null);
    }
    private void BieuCam1()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609953, volume:  null);
    }
    private void BieuCam2()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609951, volume:  null);
    }
    private void BieuCam3()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609949, volume:  null);
    }
    public StoryPopup()
    {
    
    }
    private void <Start>b__2_0()
    {
        this.CompletedStory();
    }
    private void <LoadLevel>b__5_0()
    {
        var val_5;
        object val_6;
        System.Action val_7;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701127.ShowBanner(position:  1, bannerPlaceID:  0);
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700957.SpawLevelStart();
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_5 = 536901505;
        if(((mem[536901692] & true) == 0) && (mem[536901621] == 0))
        {
                val_5 = 536901505;
        }
        
        val_6 = mem[536901597];
        val_7 = mem[mem[536901597] + 4];
        val_7 = mem[536901597] + 4;
        if(val_7 == 0)
        {
                if(((mem[536901692] & true) == 0) && (mem[536901621] == 0))
        {
                val_6 = mem[536901597];
        }
        
            val_7 = 536882991;
            val_7 = new System.Action(object:  val_6, method:  new IntPtr(1610682327));
            mem2[0] = val_7;
        }
        
        -1073700871.EndFade(action:  536882991);
    }

}
