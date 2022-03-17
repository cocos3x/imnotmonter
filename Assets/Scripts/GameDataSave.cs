using UnityEngine;
[Serializable]
public class GameDataSave
{
    // Fields
    public bool FirstOpen;
    public bool IsOldUser;
    public bool HasSetUserState;
    public bool Rated;
    public bool ShowCompletedStory;
    public int Coin;
    public int Diamond;
    public int CurrentLevel;
    public int LevelUnlocked;
    public int GameModeSelected;
    public int NumberMixLevel;
    public bool PinPullUnlocked;
    public bool RopeRescueUnlocked;
    public bool CutRescueUnlocked;
    public bool MuteAll;
    public bool Music;
    public bool SoundFX;
    public bool Vibrate;
    public float MasterVolume;
    public float MusicVolume;
    public float SoundFXVolume;
    public int indexOfDayDaily;
    public int dayClamReward;
    public float StartAngleSpin;
    public string timeSpinFree;
    public string TimeSpinNew;
    public int numberSpin;
    public int skinSelectedID;
    public System.Collections.Generic.List<int> listSkinUnlocked;
    public System.Collections.Generic.List<int> listSkinProgress;
    public int skinHuggySelectedID;
    public System.Collections.Generic.List<int> listSkinHuggyUnlocked;
    public System.Collections.Generic.List<int> listSkinHuggyProgress;
    public float valueProgressSkinCharater;
    public int indexGetSkinProgress;
    public System.Collections.Generic.List<int> listSkinProgressHasShow;
    public int NumberRopeLevel;
    public int CurrentLevelRope;
    public int LevelRopeUnlocked;
    public int LevelRopePlayed;
    public int RopeCoinReward;
    public int RopeCoinBonusReward;
    public int RopeTapeBonusReward;
    public int NumberPinpullLevel;
    public int CurrentLevelPinPull;
    public int LevelPinPullUnlocked;
    public int LevelPinPullPlayed;
    public int PinPullCoinReward;
    public int NumberCutRopeLevel;
    public int CurrentLevelCutRope;
    public int LevelCutRopeUnlocked;
    public int LevelCutRopePlayed;
    public int CutRopeCoinReward;
    public int CountRewardLottery;
    public int CountWinShowLottery;
    public int idSelectDecoWall;
    public int idSelectDecoShelf;
    public int idSelectDecoChair;
    public int idSelectDecoTV;
    public int idSelectDecoPicture;
    public int idSelectDecoLight;
    public System.Collections.Generic.List<int> listIdDecoWallUnlock;
    public System.Collections.Generic.List<int> listIdDecoShelfUnlock;
    public System.Collections.Generic.List<int> listIdDecoChairUnlock;
    public System.Collections.Generic.List<int> listIdDecoTVUnlock;
    public System.Collections.Generic.List<int> listIdDecoPictureUnlock;
    public System.Collections.Generic.List<int> listIdDecoLightUnlock;
    
    // Methods
    public GameDataSave()
    {
        this.RopeRescueUnlocked = true;
        this.NumberMixLevel = 200;
        this.Music = true;
        this.SoundFX = true;
        this.Vibrate = true;
        this.MasterVolume = 1f;
        this.MusicVolume = 1f;
        this.SoundFXVolume = 1f;
        System.DateTime val_1 = new System.DateTime(year:  2021, month:  1, day:  1, hour:  true, minute:  true, second:  true);
        string val_2 = DataSystem.Globalization.StringFormat.DateTimeToString(dateTime:  new System.DateTime() {dateData = val_1.dateData}, dateTimeFormat:  2);
        this.timeSpinFree = val_1.dateData;
        this.TimeSpinNew = -1610612735;
        this.skinSelectedID = true;
        System.Collections.Generic.List<System.Int32> val_3 = 536877987;
        val_3 = new System.Collections.Generic.List<System.Int32>();
        val_3.Add(item:  1);
        this.listSkinUnlocked = val_3;
        System.Collections.Generic.List<System.Int32> val_4 = 536877987;
        val_4 = new System.Collections.Generic.List<System.Int32>();
        if(val_4 != 0)
        {
                val_4.Add(item:  1);
            val_4.Add(item:  2);
            val_4.Add(item:  3);
            val_4.Add(item:  4);
            val_4.Add(item:  5);
            val_4.Add(item:  6);
            val_4.Add(item:  7);
            val_4.Add(item:  8);
        }
        else
        {
                val_4.Add(item:  1);
            val_4.Add(item:  2);
            val_4.Add(item:  3);
            val_4.Add(item:  4);
            val_4.Add(item:  5);
            val_4.Add(item:  6);
            val_4.Add(item:  7);
            val_4.Add(item:  8);
        }
        
        val_4.Add(item:  9);
        this.listSkinProgress = val_4;
        mem[1152921509466095216] = 1;
        System.Collections.Generic.List<System.Int32> val_5 = 536877987;
        val_5 = new System.Collections.Generic.List<System.Int32>();
        val_5.Add(item:  1);
        this.listSkinHuggyUnlocked = val_5;
        System.Collections.Generic.List<System.Int32> val_6 = 536877987;
        val_6 = new System.Collections.Generic.List<System.Int32>();
        if(val_6 != 0)
        {
                val_6.Add(item:  1);
            val_6.Add(item:  2);
            val_6.Add(item:  3);
            val_6.Add(item:  4);
            val_6.Add(item:  5);
            val_6.Add(item:  6);
            val_6.Add(item:  7);
            val_6.Add(item:  8);
        }
        else
        {
                val_6.Add(item:  1);
            val_6.Add(item:  2);
            val_6.Add(item:  3);
            val_6.Add(item:  4);
            val_6.Add(item:  5);
            val_6.Add(item:  6);
            val_6.Add(item:  7);
            val_6.Add(item:  8);
        }
        
        val_6.Add(item:  9);
        this.listSkinHuggyProgress = val_6;
        System.Collections.Generic.List<System.Int32> val_7 = 536877987;
        val_7 = new System.Collections.Generic.List<System.Int32>();
        mem[1152921509466095236] = val_7;
        mem[1152921509466095240] = 70;
        mem[1152921509466095244] = 1;
        mem[1152921509466095256] = 100;
        mem[1152921509466095268] = 140;
        mem[1152921509466095272] = 1;
        mem[1152921509466095284] = 100;
        mem[1152921509466095288] = 60;
        mem[1152921509466095292] = 1;
        mem[1152921509466095304] = 100;
        System.Collections.Generic.List<System.Int32> val_8 = 536877987;
        val_8 = new System.Collections.Generic.List<System.Int32>();
        val_8.Add(item:  0);
        this.listIdDecoWallUnlock = val_8;
        System.Collections.Generic.List<System.Int32> val_9 = 536877987;
        val_9 = new System.Collections.Generic.List<System.Int32>();
        val_9.Add(item:  0);
        this.listIdDecoShelfUnlock = val_9;
        System.Collections.Generic.List<System.Int32> val_10 = 536877987;
        val_10 = new System.Collections.Generic.List<System.Int32>();
        val_10.Add(item:  0);
        this.listIdDecoChairUnlock = val_10;
        System.Collections.Generic.List<System.Int32> val_11 = 536877987;
        val_11 = new System.Collections.Generic.List<System.Int32>();
        val_11.Add(item:  0);
        this.listIdDecoTVUnlock = val_11;
        System.Collections.Generic.List<System.Int32> val_12 = 536877987;
        val_12 = new System.Collections.Generic.List<System.Int32>();
        val_12.Add(item:  0);
        this.listIdDecoPictureUnlock = val_12;
        System.Collections.Generic.List<System.Int32> val_13 = 536877987;
        val_13 = new System.Collections.Generic.List<System.Int32>();
        val_13.Add(item:  0);
        this.listIdDecoLightUnlock = val_13;
    }

}
