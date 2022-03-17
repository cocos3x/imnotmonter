using UnityEngine;
public class GameData : ManualSingletonMono<GameData>, ISaveData
{
    // Fields
    public int totalSkinCharacter;
    public int totalSkinHuggy;
    public int totalDecor;
    public GameDataSave Data;
    private bool <DataChanged>k__BackingField;
    public int[] ValueAddProgress;
    public static System.Collections.Generic.List<int> ListIDSkinLittleMisser;
    public static System.Collections.Generic.List<int> ListIDSkinHuggy;
    public int DiamondReward;
    public int MoveSpeedHuman;
    public int DiamondCollect;
    public bool FirstPlayLevel;
    
    // Properties
    public bool DataChanged { get; set; }
    public bool MuteAll { get; set; }
    public bool Vibrate { get; set; }
    public bool Music { get; set; }
    public bool SoundFX { get; set; }
    public float MasterVolume { get; set; }
    public float MusicVolume { get; set; }
    public float SoundFXVolume { get; set; }
    public bool FirstOpen { get; set; }
    public bool IsOldUser { get; set; }
    public bool HasSetUserState { get; set; }
    public bool Rated { get; set; }
    public bool ShowCompletedStory { get; set; }
    public int Coin { get; set; }
    public int Diamond { get; set; }
    public int IndexOfDayDaily { get; set; }
    public int DayClamReward { get; set; }
    public float StartAngleSpin { get; set; }
    public string TimeSpineFree { get; set; }
    public string TimeSpin { get; set; }
    public int NumberSpin { get; set; }
    public int SkinSelectedID { get; set; }
    public System.Collections.Generic.List<int> ListSkinProgress { get; set; }
    public System.Collections.Generic.List<int> ListSkinUnlocked { get; set; }
    public System.Collections.Generic.List<int> ListHuggyUnlocked { get; set; }
    public int SkinHuggySelectedID { get; set; }
    public System.Collections.Generic.List<int> ListSkinHuggyProgress { get; set; }
    public float ValueProgressSkinCharater { get; set; }
    public int IndexGetSkinProgress { get; set; }
    public System.Collections.Generic.List<int> ListSkinProgressHasShow { get; set; }
    public int NumberMixLevel { get; set; }
    public int CurrentLevel { get; set; }
    public int CurrentLevelUnlocked { get; set; }
    public int GameMode { get; set; }
    public bool PinPullUnlocked { get; set; }
    public bool RopeRescuelUnlocked { get; set; }
    public bool CutRescuelUnlocked { get; set; }
    public int NumberRopeLevel { get; }
    public int CurrentLevelRope { get; set; }
    public int LevelRopeUnlocked { get; set; }
    public int LevelRopePlayed { get; set; }
    public int RopeCoinReward { get; set; }
    public int RopeCoinBonusReward { get; set; }
    public int RopeTapeBonusReward { get; set; }
    public int NumberPinpullLevel { get; }
    public int CurrentLevelPinPull { get; set; }
    public int LevelPinPullPlayed { get; set; }
    public int LevelPinPullUnlocked { get; set; }
    public int PinPullCoinReward { get; set; }
    public int NumberCutRopeLevel { get; }
    public int CurrentLevelCutRope { get; set; }
    public int LevelCutRopePlayed { get; set; }
    public int LevelCutRopeUnlocked { get; set; }
    public int CutRopeCoinReward { get; set; }
    public int CountRewardLottery { get; set; }
    public int IdSelectDecoWall { get; set; }
    public int IdSelectDecoChair { get; set; }
    public int IdSelectDecoShelf { get; set; }
    public int IdSelectDecoTV { get; set; }
    public int IdSelectDecoLight { get; set; }
    public int IdSelectDecoPicture { get; set; }
    
    // Methods
    private void Start()
    {
        this.LoadData();
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.SetMasterWithVolume(value:  null);
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.SetMusicVolume(value:  null);
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.SetSoundFXVolume(value:  null);
    }
    public object GetData()
    {
    
    }
    public void SaveData()
    {
        this.RegisterSaveData();
        this.Save();
    }
    public void LoadData()
    {
        GameDataSave val_2;
        bool val_3;
        this.RegisterSaveData();
        AFramework.SaveGameManager val_1 = AFramework.Singleton<AFramework.SaveGameManager>.I;
        -1073700763.Load(mandatory:  true, optional:  true, notification:  true);
        if(this.Data.HasSetUserState != false)
        {
                return;
        }
        
        this.Data.HasSetUserState = true;
        this.Save();
        val_2 = this.Data;
        if(this.Data == 0)
        {
                val_2 = this.Data;
        }
        
        if(this.Data.Coin >= 2)
        {
                val_3 = 1;
        }
        else
        {
                val_3 = false;
        }
        
        this.Data.IsOldUser = val_3;
        this.Save();
    }
    public void SetData(string data)
    {
        var val_5;
        string val_6;
        var val_7;
        val_5 = this;
        val_6 = data;
        val_7 = 23000504;
        if((System.String.op_Equality(a:  val_6, b:  mem[536894675])) != false)
        {
                GameDataSave val_2 = 536887295;
            val_2 = new GameDataSave();
            this.Data = val_2;
        }
        
        LoadGameDictionary val_3 = UnityEngine.JsonUtility.FromJson<LoadGameDictionary>(json:  R5);
        mem2[0] = R5;
    }
    public void RegisterSaveData()
    {
        AFramework.SaveGameManager val_1 = AFramework.Singleton<AFramework.SaveGameManager>.I;
        -1073700763.RegisterMandatoryData(name:  -1610607953, data:  547162000);
    }
    public void Save()
    {
        this.<DataChanged>k__BackingField = true;
        AFramework.SaveGameManager val_1 = AFramework.Singleton<AFramework.SaveGameManager>.I;
        -1073700763.Save(mandatory:  true, optional:  true, hasBackup:  true);
    }
    public void OnAllDataLoaded()
    {
        UnityEngine.Debug.Log(message:  -1610610275);
    }
    public bool get_DataChanged()
    {
        return (bool)this.<DataChanged>k__BackingField;
    }
    public void set_DataChanged(bool value)
    {
        this.<DataChanged>k__BackingField = value;
    }
    public bool get_MuteAll()
    {
        if(this.Data != 0)
        {
                return (bool)this.Data.MuteAll;
        }
        
        return (bool)this.Data.MuteAll;
    }
    public void set_MuteAll(bool value)
    {
        this.Data.MuteAll = value;
        this.Save();
    }
    public bool get_Vibrate()
    {
        if(this.Data != 0)
        {
                return (bool)this.Data.Vibrate;
        }
        
        return (bool)this.Data.Vibrate;
    }
    public void set_Vibrate(bool value)
    {
        this.Data.Vibrate = value;
        this.Save();
    }
    public bool get_Music()
    {
        if(this.Data != 0)
        {
                return (bool)this.Data.Music;
        }
        
        return (bool)this.Data.Music;
    }
    public void set_Music(bool value)
    {
        this.Data.Music = value;
        this.Save();
    }
    public bool get_SoundFX()
    {
        if(this.Data != 0)
        {
                return (bool)this.Data.SoundFX;
        }
        
        return (bool)this.Data.SoundFX;
    }
    public void set_SoundFX(bool value)
    {
        this.Data.SoundFX = value;
        this.Save();
    }
    public float get_MasterVolume()
    {
        if(this.Data != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    public void set_MasterVolume(float value)
    {
        this.Data.MasterVolume = R1;
        this.Save();
    }
    public float get_MusicVolume()
    {
        if(this.Data != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    public void set_MusicVolume(float value)
    {
        this.Data.MusicVolume = R1;
        this.Save();
    }
    public float get_SoundFXVolume()
    {
        if(this.Data != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    public void set_SoundFXVolume(float value)
    {
        this.Data.SoundFXVolume = R1;
        this.Save();
    }
    public bool get_FirstOpen()
    {
        if(this.Data != 0)
        {
                return (bool)this.Data.FirstOpen;
        }
        
        return (bool)this.Data.FirstOpen;
    }
    public void set_FirstOpen(bool value)
    {
        this.Data.FirstOpen = value;
        this.Save();
    }
    public bool get_IsOldUser()
    {
        if(this.Data != 0)
        {
                return (bool)this.Data.IsOldUser;
        }
        
        return (bool)this.Data.IsOldUser;
    }
    public void set_IsOldUser(bool value)
    {
        this.Data.IsOldUser = value;
        this.Save();
    }
    public bool get_HasSetUserState()
    {
        if(this.Data != 0)
        {
                return (bool)this.Data.HasSetUserState;
        }
        
        return (bool)this.Data.HasSetUserState;
    }
    public void set_HasSetUserState(bool value)
    {
        this.Data.HasSetUserState = value;
        this.Save();
    }
    public bool get_Rated()
    {
        if(this.Data != 0)
        {
                return (bool)this.Data.Rated;
        }
        
        return (bool)this.Data.Rated;
    }
    public void set_Rated(bool value)
    {
        this.Data.Rated = value;
        this.Save();
    }
    public bool get_ShowCompletedStory()
    {
        if(this.Data != 0)
        {
                return (bool)this.Data.ShowCompletedStory;
        }
        
        return (bool)this.Data.ShowCompletedStory;
    }
    public void set_ShowCompletedStory(bool value)
    {
        this.Data.ShowCompletedStory = value;
        this.Save();
    }
    public int get_Coin()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.Coin;
        }
        
        return (int)this.Data.Coin;
    }
    public void set_Coin(int value)
    {
        this.Data.Coin = value;
        this.Save();
    }
    public int get_Diamond()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.Diamond;
        }
        
        return (int)this.Data.Diamond;
    }
    public void set_Diamond(int value)
    {
        this.Data.Diamond = value;
        this.Save();
    }
    public int get_IndexOfDayDaily()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.indexOfDayDaily;
        }
        
        return (int)this.Data.indexOfDayDaily;
    }
    public void set_IndexOfDayDaily(int value)
    {
        this.Data.indexOfDayDaily = value;
        this.Save();
    }
    public int get_DayClamReward()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.dayClamReward;
        }
        
        return (int)this.Data.dayClamReward;
    }
    public void set_DayClamReward(int value)
    {
        this.Data.dayClamReward = value;
        this.Save();
    }
    public float get_StartAngleSpin()
    {
        if(this.Data != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    public void set_StartAngleSpin(float value)
    {
        this.Data.StartAngleSpin = R1;
        this.Save();
    }
    public string get_TimeSpineFree()
    {
        if(this.Data != 0)
        {
                return;
        }
    
    }
    public void set_TimeSpineFree(string value)
    {
        this.Data.timeSpinFree = value;
        this.Save();
    }
    public string get_TimeSpin()
    {
        if(this.Data != 0)
        {
                return;
        }
    
    }
    public void set_TimeSpin(string value)
    {
        this.Data.TimeSpinNew = value;
        this.Save();
    }
    public int get_NumberSpin()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.numberSpin;
        }
        
        return (int)this.Data.numberSpin;
    }
    public void set_NumberSpin(int value)
    {
        this.Data.numberSpin = value;
        this.Save();
    }
    public int get_SkinSelectedID()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.skinSelectedID;
        }
        
        return (int)this.Data.skinSelectedID;
    }
    public void set_SkinSelectedID(int value)
    {
        this.Data.skinSelectedID = value;
        this.Save();
    }
    public bool CheckSkinSelected(int id)
    {
        int val_1 = this.Data.skinSelectedID;
        val_1 = val_1 - id;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public void UnlockSkin(int id)
    {
        if((this.Data.listSkinUnlocked.Contains(item:  id)) != false)
        {
                return;
        }
        
        this.Data.listSkinUnlocked.Add(item:  id);
        this.Save();
    }
    public void LockSkin(int id)
    {
        if((this.Data.listSkinUnlocked.Contains(item:  id)) == false)
        {
                return;
        }
        
        bool val_2 = this.Data.listSkinUnlocked.Remove(item:  id);
        this.Save();
    }
    public bool CheckSkinUnlock(int id)
    {
        if(this.Data.listSkinUnlocked != 0)
        {
                return this.Data.listSkinUnlocked.Contains(item:  id);
        }
        
        return this.Data.listSkinUnlocked.Contains(item:  id);
    }
    public System.Collections.Generic.List<int> get_ListSkinProgress()
    {
        if(this.Data != 0)
        {
                return;
        }
    
    }
    public void set_ListSkinProgress(System.Collections.Generic.List<int> value)
    {
        this.Data.listSkinProgress = value;
        this.Save();
    }
    public System.Collections.Generic.List<int> get_ListSkinUnlocked()
    {
        if(this.Data != 0)
        {
                return;
        }
    
    }
    public void set_ListSkinUnlocked(System.Collections.Generic.List<int> value)
    {
    
    }
    public System.Collections.Generic.List<int> get_ListHuggyUnlocked()
    {
        if(this.Data != 0)
        {
                return;
        }
    
    }
    public void set_ListHuggyUnlocked(System.Collections.Generic.List<int> value)
    {
    
    }
    public int get_SkinHuggySelectedID()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.skinHuggySelectedID;
        }
        
        return (int)this.Data.skinHuggySelectedID;
    }
    public void set_SkinHuggySelectedID(int value)
    {
        this.Data.skinHuggySelectedID = value;
        this.Save();
    }
    public bool CheckSkinHuggySelected(int id)
    {
        int val_1 = this.Data.skinHuggySelectedID;
        val_1 = val_1 - id;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public void UnlockSkinHuggy(int id)
    {
        if((this.Data.listSkinHuggyUnlocked.Contains(item:  id)) != false)
        {
                return;
        }
        
        this.Data.listSkinHuggyUnlocked.Add(item:  id);
        this.Save();
    }
    public void LockSkinHuggy(int id)
    {
        if((this.Data.listSkinHuggyUnlocked.Contains(item:  id)) == false)
        {
                return;
        }
        
        bool val_2 = this.Data.listSkinHuggyUnlocked.Remove(item:  id);
        this.Save();
    }
    public bool CheckSkinHuggyUnlock(int id)
    {
        if(this.Data.listSkinHuggyUnlocked != 0)
        {
                return this.Data.listSkinHuggyUnlocked.Contains(item:  id);
        }
        
        return this.Data.listSkinHuggyUnlocked.Contains(item:  id);
    }
    public System.Collections.Generic.List<int> get_ListSkinHuggyProgress()
    {
        if(this.Data != 0)
        {
                return;
        }
    
    }
    public void set_ListSkinHuggyProgress(System.Collections.Generic.List<int> value)
    {
        this.Data.listSkinHuggyProgress = value;
        this.Save();
    }
    public float get_ValueProgressSkinCharater()
    {
        if(this.Data != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    public void set_ValueProgressSkinCharater(float value)
    {
        float val_1 = UnityEngine.Mathf.Min(a:  value, b:  null);
        this.Data.valueProgressSkinCharater = R1;
        this.Save();
    }
    public int get_IndexGetSkinProgress()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.indexGetSkinProgress;
        }
        
        return (int)this.Data.indexGetSkinProgress;
    }
    public void set_IndexGetSkinProgress(int value)
    {
        this.Data.indexGetSkinProgress = UnityEngine.Mathf.Min(a:  value, b:  3);
        this.Save();
    }
    public System.Collections.Generic.List<int> get_ListSkinProgressHasShow()
    {
        if(this.Data != 0)
        {
                return;
        }
    
    }
    public void set_ListSkinProgressHasShow(System.Collections.Generic.List<int> value)
    {
        this.Data.listSkinProgressHasShow = value;
        this.Save();
    }
    public int get_NumberMixLevel()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.NumberMixLevel;
        }
        
        return (int)this.Data.NumberMixLevel;
    }
    public void set_NumberMixLevel(int value)
    {
        this.Data.NumberMixLevel = value;
        this.Save();
    }
    public int get_CurrentLevel()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.CurrentLevel;
        }
        
        return (int)this.Data.CurrentLevel;
    }
    public void set_CurrentLevel(int value)
    {
        this.Data.CurrentLevel = value;
        this.Save();
    }
    public int get_CurrentLevelUnlocked()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.LevelUnlocked;
        }
        
        return (int)this.Data.LevelUnlocked;
    }
    public void set_CurrentLevelUnlocked(int value)
    {
        this.Data.LevelUnlocked = value;
        this.Save();
    }
    public int get_GameMode()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.GameModeSelected;
        }
        
        return (int)this.Data.GameModeSelected;
    }
    public void set_GameMode(int value)
    {
        this.Data.GameModeSelected = value;
        this.Save();
    }
    public bool get_PinPullUnlocked()
    {
        if(this.Data != 0)
        {
                return (bool)this.Data.PinPullUnlocked;
        }
        
        return (bool)this.Data.PinPullUnlocked;
    }
    public void set_PinPullUnlocked(bool value)
    {
        this.Data.PinPullUnlocked = value;
        this.Save();
    }
    public bool get_RopeRescuelUnlocked()
    {
        if(this.Data != 0)
        {
                return (bool)this.Data.RopeRescueUnlocked;
        }
        
        return (bool)this.Data.RopeRescueUnlocked;
    }
    public void set_RopeRescuelUnlocked(bool value)
    {
        this.Data.RopeRescueUnlocked = value;
        this.Save();
    }
    public bool get_CutRescuelUnlocked()
    {
        if(this.Data != 0)
        {
                return (bool)this.Data.CutRescueUnlocked;
        }
        
        return (bool)this.Data.CutRescueUnlocked;
    }
    public void set_CutRescuelUnlocked(bool value)
    {
        this.Data.CutRescueUnlocked = value;
        this.Save();
    }
    public int get_NumberRopeLevel()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.NumberRopeLevel;
        }
        
        return (int)this.Data.NumberRopeLevel;
    }
    public int get_CurrentLevelRope()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.CurrentLevelRope;
        }
        
        return (int)this.Data.CurrentLevelRope;
    }
    public void set_CurrentLevelRope(int value)
    {
        this.Data.CurrentLevelRope = value;
        this.Save();
    }
    public int get_LevelRopeUnlocked()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.LevelRopeUnlocked;
        }
        
        return (int)this.Data.LevelRopeUnlocked;
    }
    public void set_LevelRopeUnlocked(int value)
    {
        this.Data.LevelRopeUnlocked = value;
        this.Save();
    }
    public int get_LevelRopePlayed()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.LevelRopePlayed;
        }
        
        return (int)this.Data.LevelRopePlayed;
    }
    public void set_LevelRopePlayed(int value)
    {
        this.Data.LevelRopePlayed = value;
        this.Save();
    }
    public int get_RopeCoinReward()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.RopeCoinReward;
        }
        
        return (int)this.Data.RopeCoinReward;
    }
    public void set_RopeCoinReward(int value)
    {
        this.Data.RopeCoinReward = value;
        this.Save();
    }
    public int get_RopeCoinBonusReward()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.RopeCoinBonusReward;
        }
        
        return (int)this.Data.RopeCoinBonusReward;
    }
    public void set_RopeCoinBonusReward(int value)
    {
        this.Data.RopeCoinBonusReward = value;
        this.Save();
    }
    public int get_RopeTapeBonusReward()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.RopeTapeBonusReward;
        }
        
        return (int)this.Data.RopeTapeBonusReward;
    }
    public void set_RopeTapeBonusReward(int value)
    {
        this.Data.RopeTapeBonusReward = value;
        this.Save();
    }
    public int get_NumberPinpullLevel()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.NumberPinpullLevel;
        }
        
        return (int)this.Data.NumberPinpullLevel;
    }
    public int get_CurrentLevelPinPull()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.CurrentLevelPinPull;
        }
        
        return (int)this.Data.CurrentLevelPinPull;
    }
    public void set_CurrentLevelPinPull(int value)
    {
        this.Data.CurrentLevelPinPull = value;
        this.Save();
    }
    public int get_LevelPinPullPlayed()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.LevelPinPullPlayed;
        }
        
        return (int)this.Data.LevelPinPullPlayed;
    }
    public void set_LevelPinPullPlayed(int value)
    {
        this.Data.LevelPinPullPlayed = value;
        this.Save();
    }
    public int get_LevelPinPullUnlocked()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.LevelPinPullUnlocked;
        }
        
        return (int)this.Data.LevelPinPullUnlocked;
    }
    public void set_LevelPinPullUnlocked(int value)
    {
        this.Data.LevelPinPullUnlocked = value;
        this.Save();
    }
    public int get_PinPullCoinReward()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.PinPullCoinReward;
        }
        
        return (int)this.Data.PinPullCoinReward;
    }
    public void set_PinPullCoinReward(int value)
    {
        this.Data.PinPullCoinReward = value;
        this.Save();
    }
    public int get_NumberCutRopeLevel()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.NumberCutRopeLevel;
        }
        
        return (int)this.Data.NumberCutRopeLevel;
    }
    public int get_CurrentLevelCutRope()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.CurrentLevelCutRope;
        }
        
        return (int)this.Data.CurrentLevelCutRope;
    }
    public void set_CurrentLevelCutRope(int value)
    {
        this.Data.CurrentLevelCutRope = value;
        this.Save();
    }
    public int get_LevelCutRopePlayed()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.LevelCutRopePlayed;
        }
        
        return (int)this.Data.LevelCutRopePlayed;
    }
    public void set_LevelCutRopePlayed(int value)
    {
        this.Data.LevelCutRopePlayed = value;
        this.Save();
    }
    public int get_LevelCutRopeUnlocked()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.LevelCutRopeUnlocked;
        }
        
        return (int)this.Data.LevelCutRopeUnlocked;
    }
    public void set_LevelCutRopeUnlocked(int value)
    {
        this.Data.LevelCutRopeUnlocked = value;
        this.Save();
    }
    public int get_CutRopeCoinReward()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.CutRopeCoinReward;
        }
        
        return (int)this.Data.CutRopeCoinReward;
    }
    public void set_CutRopeCoinReward(int value)
    {
        this.Data.CutRopeCoinReward = value;
        this.Save();
    }
    public int get_CountRewardLottery()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.CountRewardLottery;
        }
        
        return (int)this.Data.CountRewardLottery;
    }
    public void set_CountRewardLottery(int value)
    {
        this.Data.CountRewardLottery = value;
        this.Save();
    }
    public int get_IdSelectDecoWall()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.idSelectDecoWall;
        }
        
        return (int)this.Data.idSelectDecoWall;
    }
    public void set_IdSelectDecoWall(int value)
    {
        this.Data.idSelectDecoWall = value;
        this.Save();
    }
    public int get_IdSelectDecoChair()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.idSelectDecoChair;
        }
        
        return (int)this.Data.idSelectDecoChair;
    }
    public void set_IdSelectDecoChair(int value)
    {
        this.Data.idSelectDecoChair = value;
        this.Save();
    }
    public int get_IdSelectDecoShelf()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.idSelectDecoShelf;
        }
        
        return (int)this.Data.idSelectDecoShelf;
    }
    public void set_IdSelectDecoShelf(int value)
    {
        this.Data.idSelectDecoShelf = value;
        this.Save();
    }
    public int get_IdSelectDecoTV()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.idSelectDecoTV;
        }
        
        return (int)this.Data.idSelectDecoTV;
    }
    public void set_IdSelectDecoTV(int value)
    {
        this.Data.idSelectDecoTV = value;
        this.Save();
    }
    public int get_IdSelectDecoLight()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.idSelectDecoLight;
        }
        
        return (int)this.Data.idSelectDecoLight;
    }
    public void set_IdSelectDecoLight(int value)
    {
        this.Data.idSelectDecoLight = value;
        this.Save();
    }
    public int get_IdSelectDecoPicture()
    {
        if(this.Data != 0)
        {
                return (int)this.Data.idSelectDecoPicture;
        }
        
        return (int)this.Data.idSelectDecoPicture;
    }
    public void set_IdSelectDecoPicture(int value)
    {
        this.Data.idSelectDecoPicture = value;
        this.Save();
    }
    public void UnlockDeco(DecoType type, int id)
    {
        DecoType val_8 = type;
        if(val_8 <= 5)
        {
                var val_1 = 18621076 + (18621076 + (type) << 2);
            if(val_8 == 5)
        {
                18621076 = 18621076 & ((R8) << 18621076);
            18621076 = 18621076 & ((((18621076 & (R8) << 18621076)) << (32-(18621076 & (R8) << 18621076))) | (((18621076 & (R8) << 18621076)) << (18621076 & (R8) << 18621076)));
            18621076 = 18621076 & (((int)R8) >> 1);
            18621076 = 18621076 & (18621076 >> 2);
            18621076 = 18621076 & (((R8) << (32-18621076 + (type) << 2)) | ((R8) << 18621076 + (type) << 2));
        }
        
            val_8 = this.Data.listIdDecoWallUnlock;
            if((val_8.Contains(item:  id)) != true)
        {
                val_8 = this.Data.listIdDecoWallUnlock;
            Add(item:  id);
        }
        
        }
        
        this.Save();
    }
    public bool IsUnlockDeco(DecoType type, int id)
    {
        System.Collections.Generic.List<System.Int32> val_3;
        var val_4;
        System.Collections.Generic.List<System.Int32> val_5;
        var val_6;
        val_3 = type;
        val_4 = 23000515;
        if(val_3 > 5)
        {
                return false;
        }
        
        var val_1 = 18621792 + (18621792 + (type) << 2);
        if(val_3 == 5)
        {
                18621792 = 18621792 & ((R8) << 18621792);
            18621792 = 18621792 & ((R8) << 1);
            18621792 = 18621792 & (18621792 >> 1);
            mem2[0] = (((18621792 & (R8) << 18621792) & (R8) << 1) & (((18621792 & (R8) << 18621792) & (R8) << 1)) >> 1) + R8;
            (((18621792 & (R8) << 18621792) & (R8) << 1) & (((18621792 & (R8) << 18621792) & (R8) << 1)) >> 1) + R8 = ((((18621792 & (R8) << 18621792) & (R8) << 1) & (((18621792 & (R8) << 18621792) & (R8) << 1)) >> 1) + R8) & (((R8) << (32-1)) | ((R8) << 1));
        }
        
        val_3 = this.Data.listIdDecoWallUnlock;
        val_4 = 22737120;
        if((val_3.Contains(item:  id)) == false)
        {
                return false;
        }
        
        val_5 = this.Data.listIdDecoWallUnlock;
        val_6 = -1073714337;
        return Contains(item:  R4);
    }
    public bool IsUnlockAllDeco()
    {
        if(R1 < this.totalDecor)
        {
                return false;
        }
        
        if(R1 < this.totalDecor)
        {
                return false;
        }
        
        if(R1 < this.totalDecor)
        {
                return false;
        }
        
        if(R1 < this.totalDecor)
        {
                return false;
        }
        
        if(R1 < this.totalDecor)
        {
                return false;
        }
        
        if(R2 >= this.totalDecor)
        {
                0 = 1;
        }
        
        return true;
    }
    public TypeBuy TypeBuyDeco(DecoType type, int id, out int price)
    {
        var val_21;
        var val_22;
        var val_23;
        if(type <= 5)
        {
                var val_1 = 18622544 + (18622544 + (type) << 2);
            if(type == 5)
        {
                18622544 = 18622544 & ((R8) << 18622544);
            mem2[0] = (18622544 & (R8) << 18622544) + IP;
            ((18622544 & (R8) << 18622544) + IP) & (((int)(18622544 & (R8) << 18622544) + IP) >> 18622544 + (type) << 2) = (((18622544 & (R8) << 18622544) + IP) & (((int)(18622544 & (R8) << 18622544) + IP) >> 18622544 + (type) << 2)) & (((id) << (32-3)) | ((id) << 3));
            ((18622544 & (R8) << 18622544) + IP) & (((int)(18622544 & (R8) << 18622544) + IP) >> 18622544 + (type) << 2) = (((18622544 & (R8) << 18622544) + IP) & (((int)(18622544 & (R8) << 18622544) + IP) >> 18622544 + (type) << 2)) & (((R8) << (32-id)) | ((R8) << id));
            ((18622544 & (R8) << 18622544) + IP) & (((int)(18622544 & (R8) << 18622544) + IP) >> 18622544 + (type) << 2) = (((18622544 & (R8) << 18622544) + IP) & (((int)(18622544 & (R8) << 18622544) + IP) >> 18622544 + (type) << 2)) & ((IP) << 6);
        }
        
            val_21 = 22742128;
            WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_22 = mem[mem[3221266331] + 8];
            val_22 = mem[3221266331] + 8;
            var val_3 = val_22 + (id << 2);
            price = (mem[3221266331] + 8 + (id) << 2) + 16;
            WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_23 = mem[mem[3221266331] + 12];
            val_23 = mem[3221266331] + 12;
        }
        else
        {
                price = 1000;
            return;
        }
        
        var val_20 =  + ((R4) << 2);
    }
    public bool IsSelectDeco(DecoType type, int id)
    {
        var val_8;
        if(type > 5)
        {
                this = 0;
            return (bool)this;
        }
        
        var val_1 = 18623584 + (18623584 + (type) << 2);
        if(type == 5)
        {
                this = this & ((R8) << this);
            this = this & (this >> this);
            this = this & (((int)R8) >> 32);
            this = this & ((((((this & (R8) << this) & ((this & (R8) << this)) >> (this & (R8) << this)) & ((int)R8) >> 32)) << (32-as. 
            
        
        
        
        
        
           
        )) | (((((this & (R8) << this) & ((this & (R8) << this)) >> (this & (R8) << this)) & ((int)R8) >> 32)) << as. 
            
        
        
        
        
        
           
        ));
            this = this & (((R8) << (32-((((this & (R8) << this) & ((this & (R8) << this)) >> (this & (R8) << this)) & ((int)R8) >> 32) & (((((this & (R8) << this) & ((this & (R8) << this)) >> (this & (R8) << this)) & ((int)R8) >> 32)) << ()) | ((R8) << ((((this & (R8) << this) & ((this & (R8) << this)) >> (this & (R8) << this)) & ((int)R8) >> 32) & (((((this & (R8) << this) & ((this & (R8) << this)) >> (this & (R8) << this)) & ((int)R8) >> 32)) << ());
            this = this * this;
        }
        
        val_8 = (((((((this & (R8) << this) & ((this & (R8) << this)) >> (this & (R8) << this)) & ((int)R8) >> 32) & (((((this & (R8) << this) & ((this & (R8) << this)) >> (this & (R8) << this)) & ((int)R8) >> 32)) << + 24) + 196;
        var val_2 = ;
        val_2 = val_2 - id;
        val_2 = val_2 >> 5;
        return (bool)val_2;
    }
    public bool SetSelectDeco(DecoType type, int id)
    {
        GameDataSave val_2;
        if(type > 5)
        {
                return false;
        }
        
        var val_1 = 18623804 + (18623804 + (type) << 2);
        if(type == 5)
        {
                18623804 = 18623804 & ((R8) << 18623804);
            18623804 = 18623804 & (18623804 >> 18623804);
            18623804 = 18623804 & (((int)R8) >> 32);
            18623804 = 18623804 & ((((((18623804 & (R8) << 18623804) & ((18623804 & (R8) << 18623804)) >> (18623804 & (R8) << 18623804)) & ((int)R8) >> 32)) << (32-as. 
            
        
        
        
        
        
           
        )) | (((((18623804 & (R8) << 18623804) & ((18623804 & (R8) << 18623804)) >> (18623804 & (R8) << 18623804)) & ((int)R8) >> 32)) << as. 
            
        
        
        
        
        
           
        ));
            18623804 = 18623804 & (((R8) << (32-((((18623804 & (R8) << 18623804) & ((18623804 & (R8) << 18623804)) >> (18623804 & (R8) << 18623804)) & ((int)R8) >> 32) & (((((18623804 & (R8) << 18623804) & ((18623804 & (R8) << 18623804)) >> (186238)) | ((R8) << ((((18623804 & (R8) << 18623804) & ((18623804 & (R8) << 18623804)) >> (18623804 & (R8) << 18623804)) & ((int)R8) >> 32) & (((((18623804 & (R8) << 18623804) & ((18623804 & (R8) << 18623804)) >> (186238));
            18623804 = 18623804 * 18623804;
        }
        
        val_2 = this.Data;
        this.Data.idSelectDecoWall = id;
        this.Save();
        return false;
    }
    public GameData()
    {
        this.totalSkinCharacter = 18;
        this.totalSkinHuggy = 9;
        this.totalDecor = 4;
        this.ValueAddProgress = 536882065;
        this.FirstPlayLevel = true;
        this.MoveSpeedHuman = 8;
    }
    private static GameData()
    {
        System.Collections.Generic.List<System.Int32> val_1 = 536877987;
        val_1 = new System.Collections.Generic.List<System.Int32>();
        if(val_1 != 0)
        {
                val_1.Add(item:  1);
            val_1.Add(item:  2);
            val_1.Add(item:  3);
            val_1.Add(item:  4);
            val_1.Add(item:  5);
            val_1.Add(item:  6);
            val_1.Add(item:  7);
            val_1.Add(item:  8);
        }
        else
        {
                val_1.Add(item:  1);
            val_1.Add(item:  2);
            val_1.Add(item:  3);
            val_1.Add(item:  4);
            val_1.Add(item:  5);
            val_1.Add(item:  6);
            val_1.Add(item:  7);
            val_1.Add(item:  8);
        }
        
        val_1.Add(item:  9);
        mem2[0] = val_1;
        System.Collections.Generic.List<System.Int32> val_2 = 536877987;
        val_2 = new System.Collections.Generic.List<System.Int32>();
        if(val_2 != 0)
        {
                val_2.Add(item:  1);
            val_2.Add(item:  2);
            val_2.Add(item:  3);
            val_2.Add(item:  4);
            val_2.Add(item:  5);
            val_2.Add(item:  6);
            val_2.Add(item:  7);
            val_2.Add(item:  8);
        }
        else
        {
                val_2.Add(item:  1);
            val_2.Add(item:  2);
            val_2.Add(item:  3);
            val_2.Add(item:  4);
            val_2.Add(item:  5);
            val_2.Add(item:  6);
            val_2.Add(item:  7);
            val_2.Add(item:  8);
        }
        
        val_2.Add(item:  9);
        mem2[0] = val_2;
    }

}
