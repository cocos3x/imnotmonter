using UnityEngine;
public class LeaderBoardMgr : SingletonMonoBehaviour<LeaderBoardMgr>
{
    // Methods
    private void Start()
    {
        bool val_1 = Utilities.IsInternetAvailable();
        if(val_1 == false)
        {
                return;
        }
        
        val_1.Login();
    }
    private void Login()
    {
        object val_6;
        var val_7;
        var val_8;
        var val_9;
        object val_10;
        System.Action<System.Boolean> val_11;
        var val_12;
        UnityEngine.SocialPlatforms.ILocalUser val_1 = UnityEngine.Social.localUser;
        var val_6 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        val_6 = 0;
        label_4:
        val_7 = mem[mem[1179403735] + 0];
        val_7 = mem[1179403735] + 0;
        if(val_7 == 536888407)
        {
            goto label_3;
        }
        
        val_6 = val_6 + 1;
        if(((uint)val_6 & 65535) < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_8 = 0;
        goto label_5;
        label_3:
        var val_2 = mem[1179403735] + 0;
        val_6 = val_6 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_6 + 196;
        label_5:
        if(0 != 0)
        {
                return;
        }
        
        UnityEngine.SocialPlatforms.ILocalUser val_3 = UnityEngine.Social.localUser;
        val_9 = 536899519;
        if(((mem[536899706] & true) == 0) && (mem[536899635] == 0))
        {
                val_9 = 536899519;
        }
        
        val_10 = mem[536899611];
        val_11 = mem[mem[536899611] + 4];
        val_11 = mem[536899611] + 4;
        if(val_11 == 0)
        {
                if(((mem[536899706] & true) == 0) && (mem[536899635] == 0))
        {
                val_10 = mem[536899611];
        }
        
            val_6 = mem[mem[536899611]];
            val_6 = val_10;
            val_11 = 536873261;
            val_11 = new System.Action<System.Boolean>(object:  val_6, method:  new IntPtr(1610677303));
            mem2[0] = val_11;
        }
        
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_13;
        }
        
        val_7 = 0;
        label_15:
        val_6 = 0;
        if((mem[1179403735] + 0) == 536888407)
        {
            goto label_14;
        }
        
        val_7 = val_7 + 1;
        val_6 = (uint)val_7 & 65535;
        if(val_6 < mem[1179403825])
        {
            goto label_15;
        }
        
        label_13:
        val_12 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 188);
        label_14:
        var val_5 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_12 = val_7 + 188;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 188);
    }
    private void PostHighScoreToLeaderBoardAndroid(int hiScore, int star)
    {
        System.Action<System.Boolean> val_7;
        System.Action<System.Boolean> val_8;
        var val_9;
        var val_10;
        var val_11;
        object val_12;
        var val_13;
        object val_14;
        UnityEngine.SocialPlatforms.ILocalUser val_1 = UnityEngine.Social.localUser;
        val_7 = 0;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        val_8 = 0;
        label_4:
        if((mem[1179403735] + 0) == 536888407)
        {
            goto label_3;
        }
        
        val_8 = val_8 + 1;
        if(((uint)val_8 & 65535) < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_9 = val_7;
        goto label_5;
        label_3:
        var val_2 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_7 + 196;
        label_5:
        if(val_7 == 0)
        {
                return;
        }
        
        val_10 = 22718516;
        val_11 = 536899519;
        if(((mem[536899706] & true) == 0) && (mem[536899635] == 0))
        {
                val_11 = 536899519;
        }
        
        val_12 = mem[536899611];
        val_8 = mem[mem[536899611] + 8];
        val_8 = mem[536899611] + 8;
        if(val_8 == 0)
        {
                if(((mem[536899706] & true) == 0) && (mem[536899635] == 0))
        {
                val_12 = mem[536899611];
        }
        
            val_8 = 536873261;
            val_10 = val_10;
            val_8 = new System.Action<System.Boolean>(object:  val_12, method:  new IntPtr(1610677305));
            mem2[0] = val_8;
        }
        
        int val_4 = hiScore >> 31;
        UnityEngine.Social.ReportScore(score:  hiScore, board:  -1610612735, callback:  536873261);
        UnityEngine.Debug.Log(message:  -1610611809);
        if(((mem[536899706] & true) == 0) && (mem[536899635] == 0))
        {
                val_13 = 536899519;
        }
        
        val_14 = mem[536899611];
        val_7 = mem[mem[536899611] + 12];
        val_7 = mem[536899611] + 12;
        if(val_7 == 0)
        {
                if(((mem[536899706] & true) == 0) && (mem[536899635] == 0))
        {
                val_14 = mem[536899611];
        }
        
            val_8 = val_10;
            val_7 = 536873261;
            val_7 = new System.Action<System.Boolean>(object:  val_14, method:  new IntPtr(1610677307));
            mem2[0] = val_7;
        }
        
        int val_6 = star >> 31;
        UnityEngine.Social.ReportScore(score:  star, board:  -1610612735, callback:  536873261);
    }
    private void ShowLeaderBoardAndroid()
    {
        System.Action val_7;
        System.Action val_8;
        var val_9;
        if(Utilities.IsInternetAvailable() == false)
        {
            goto label_1;
        }
        
        UnityEngine.SocialPlatforms.ILocalUser val_2 = UnityEngine.Social.localUser;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_3;
        }
        
        val_7 = 0;
        label_5:
        val_8 = 0;
        if((mem[1179403735] + 0) == 536888407)
        {
            goto label_4;
        }
        
        val_7 = val_7 + 1;
        val_8 = (uint)val_7 & 65535;
        if(val_8 < mem[1179403825])
        {
            goto label_5;
        }
        
        label_3:
        val_9 = 0;
        goto label_6;
        label_1:
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701069.OpenDialog(title:  -1610607881, message:  -1610606097, okAction:  0);
        return;
        label_4:
        var val_4 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_7 + 196;
        label_6:
        if(0 != 0)
        {
                return;
        }
        
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_8 = 536882991;
        val_7 = 0;
        val_8 = new System.Action(object:  532143920, method:  new IntPtr(1610677279));
        -1073701069.OpenDialog(title:  -1610607881, message:  -1610605967, no:  -1610609633, yes:  -1610603307, okAction:  val_8, cancelAction:  val_7);
    }
    private void ReportProgresstAchievement_Android(string AchivementID, int step)
    {
        object val_2;
        var val_3;
        var val_4;
        System.Action<System.Boolean> val_5;
        object val_6;
        var val_7;
        val_2 = 22999787;
        if(step != 100)
        {
                return;
        }
        
        val_3 = 536899519;
        if(((mem[536899706] & true) == 0) && (mem[536899635] == 0))
        {
                val_3 = 536899519;
        }
        
        val_4 = mem[536899611];
        val_5 = mem[mem[536899611] + 16];
        val_5 = mem[536899611] + 16;
        if(val_5 == 0)
        {
                if(((mem[536899706] & true) == 0) && (mem[536899635] == 0))
        {
                val_6 = mem[536899611];
        }
        
            val_2 = mem[mem[536899611]];
            val_2 = val_6;
            val_5 = 536873261;
            val_5 = new System.Action<System.Boolean>(object:  val_2, method:  new IntPtr(1610677309));
            val_7 = val_5;
            mem2[0] = val_5;
        }
        
        UnityEngine.Social.ReportProgress(achievementID:  AchivementID, progress:  null, callback:  536873261);
    }
    private void ShowAchievementsUIAndroid()
    {
        var val_7;
        var val_8;
        var val_9;
        if(Utilities.IsInternetAvailable() == false)
        {
            goto label_1;
        }
        
        UnityEngine.SocialPlatforms.ILocalUser val_2 = UnityEngine.Social.localUser;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_3;
        }
        
        val_7 = 0;
        label_5:
        val_8 = 0;
        if((mem[1179403735] + 0) == 536888407)
        {
            goto label_4;
        }
        
        val_7 = val_7 + 1;
        val_8 = (uint)val_7 & 65535;
        if(val_8 < mem[1179403825])
        {
            goto label_5;
        }
        
        label_3:
        val_9 = 0;
        goto label_6;
        label_1:
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701069.OpenDialog(title:  -1610607881, message:  -1610606097, okAction:  0);
        return;
        label_4:
        var val_4 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_7 + 196;
        label_6:
        if(0 != 0)
        {
                UnityEngine.Social.ShowAchievementsUI();
            return;
        }
        
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536882991 = new System.Action(object:  532376112, method:  new IntPtr(1610677279));
        -1073701069.OpenDialog(title:  -1610607881, message:  -1610605967, no:  -1610609633, yes:  -1610603307, okAction:  536882991, cancelAction:  0);
    }
    public void PostHighScoreToLeaderBoard(int hiScore, int star)
    {
        this.PostHighScoreToLeaderBoardAndroid(hiScore:  hiScore, star:  star);
    }
    public void ShowLeaderBoard()
    {
        this.ShowLeaderBoardAndroid();
    }
    public void ReportProgresstAchievement(string achivementID, int step)
    {
        this.ReportProgresstAchievement_Android(AchivementID:  achivementID, step:  step);
    }
    public void ShowAchievement()
    {
        this.ShowAchievementsUIAndroid();
    }
    public LeaderBoardMgr()
    {
    
    }

}
