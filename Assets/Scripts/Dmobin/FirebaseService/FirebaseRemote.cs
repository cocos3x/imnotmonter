using UnityEngine;

namespace Dmobin.FirebaseService
{
    public class FirebaseRemote : SingletonMonoBehaviour<Dmobin.FirebaseService.FirebaseRemote>
    {
        // Fields
        public Dmobin.FirebaseService.RemoteRow[] remoteRows;
        public System.Collections.Generic.List<object> commonClass;
        public static System.Action OnSetDataCompleted;
        public static System.Action<System.Collections.Generic.Dictionary<string, object>> OnSetDefault;
        public bool IsFirebaseFetchCompleted;
        public Dmobin.FirebaseService.GameConfig gameConfig;
        public Dmobin.FirebaseService.GameConfig gameConfigDF;
        public Dmobin.FirebaseService.DailyRewardConfig dailyRewardConfig;
        public Dmobin.FirebaseService.DailyRewardConfig dailyRewardConfigDF;
        public Dmobin.FirebaseService.SpinConfig spinConfig;
        public Dmobin.FirebaseService.SpinConfig spinConfigDF;
        public Dmobin.FirebaseService.SkinShopConfigNew skinshopConfigNew;
        public Dmobin.FirebaseService.SkinShopConfigNew skinshopConfigNewDF;
        public Dmobin.FirebaseService.SelectModeConfig selectModeConfig;
        public Dmobin.FirebaseService.SelectModeConfig selectModeConfigDF;
        public Dmobin.FirebaseService.ProgressSkinConfig progressSkinConfig;
        public Dmobin.FirebaseService.ProgressSkinConfig progressSkinConfigDF;
        public Dmobin.FirebaseService.LotteryConfig lotteryConfig;
        public Dmobin.FirebaseService.LotteryConfig lotteryConfigDF;
        public Dmobin.FirebaseService.iAPConfig iAPConfig;
        public Dmobin.FirebaseService.iAPConfig iAPConfigDF;
        public Dmobin.FirebaseService.DecoConfig decoConfig;
        public Dmobin.FirebaseService.DecoConfig decoConfigDF;
        public Dmobin.FirebaseService.LevelConfig2 levelConfig2;
        public Dmobin.FirebaseService.LevelConfig2 levelConfig2DF;
        
        // Methods
        private void Awake()
        {
            536882991 = new System.Action(object:  1147581424, method:  new IntPtr(1610686753));
            Dmobin.FirebaseService.FirebaseInstance.CheckAndTryInit(callback:  536882991);
            this.InitDefault();
        }
        private void Init()
        {
            System.Threading.Tasks.Task val_1 = this.FetchDataAsync();
            this.SetupDefaultConfig();
        }
        public System.Threading.Tasks.Task FetchDataAsync()
        {
            var val_4;
            bool val_5;
            Firebase.RemoteConfig.FirebaseRemoteConfig val_1 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance;
            val_4 = 536895473;
            val_5 = mem[536895660];
            if((val_5 & true) == 0)
            {
                    val_5 = mem[536895589];
                if(val_5 == 0)
            {
                    val_4 = 536895473;
            }
            
            }
            
            System.Threading.Tasks.Task val_2 = 0.FetchAsync(cacheExpiration:  new System.TimeSpan() {_ticks = val_5});
            536873345 = new System.Action<SdkConfiguration>(object:  1147805424, method:  new IntPtr(1610686757));
            if(0 != 0)
            {
                    return 0.ContinueWith(continuationAction:  536873345);
            }
            
            return 0.ContinueWith(continuationAction:  536873345);
        }
        private void FetchComplete(System.Threading.Tasks.Task fetchTask)
        {
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            if(fetchTask.IsCanceled == false)
            {
                goto label_2;
            }
            
            val_15 = 22785964;
            goto label_6;
            label_2:
            if(fetchTask.IsFaulted == false)
            {
                goto label_5;
            }
            
            val_15 = 22785972;
            goto label_6;
            label_5:
            if(fetchTask.IsCompleted == false)
            {
                goto label_8;
            }
            
            val_15 = 22785968;
            label_6:
            this.ApiDebug(content:  -1610608189);
            label_8:
            val_16 = 22711072;
            Firebase.RemoteConfig.FirebaseRemoteConfig val_4 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance;
            Firebase.RemoteConfig.ConfigInfo val_5 = 0.Info;
            Firebase.RemoteConfig.LastFetchStatus val_6 = 0.LastFetchStatus;
            if(0 == 2)
            {
                goto label_13;
            }
            
            if(0 == 1)
            {
                goto label_14;
            }
            
            if(0 != 0)
            {
                    return;
            }
            
            Firebase.RemoteConfig.FirebaseRemoteConfig val_7 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance;
            val_16 = 0;
            System.Threading.Tasks.Task<System.Boolean> val_8 = val_16.ActivateAsync();
            this.GetRemoteData();
            System.DateTime val_9 = FetchTime;
            val_17 = -1610604989;
            string val_10 = System.String.Format(format:  -1610604989, arg0:  536885689);
            goto label_20;
            label_13:
            val_18 = 22788924;
            goto label_25;
            label_14:
            Firebase.RemoteConfig.FetchFailureReason val_11 = 0.LastFetchFailureReason;
            if(0 == 1)
            {
                goto label_23;
            }
            
            if(0 != 2)
            {
                    return;
            }
            
            val_18 = 22785976;
            goto label_25;
            label_23:
            System.DateTime val_12 = ThrottledEndTime;
            string val_13 = ???.ToString();
            val_17 = -1610608183;
            string val_14 = -1610608183(-1610608183) + 1147909488;
            label_20:
            val_19 = val_17;
            label_25:
            this.ApiDebug(content:  -1610608183);
        }
        private void SetupDefaultConfig()
        {
            536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
            string val_2 = UnityEngine.JsonUtility.ToJson(obj:  this.gameConfigDF);
            536874379.Add(key:  -1610607957, value:  this.gameConfigDF);
            string val_3 = UnityEngine.JsonUtility.ToJson(obj:  this.dailyRewardConfigDF);
            536874379.Add(key:  -1610608899, value:  this.dailyRewardConfigDF);
            string val_4 = UnityEngine.JsonUtility.ToJson(obj:  this.spinConfigDF);
            536874379.Add(key:  -1610604425, value:  this.spinConfigDF);
            string val_5 = UnityEngine.JsonUtility.ToJson(obj:  this.skinshopConfigNewDF);
            536874379.Add(key:  -1610604513, value:  this.skinshopConfigNewDF);
            string val_6 = UnityEngine.JsonUtility.ToJson(obj:  this.selectModeConfigDF);
            536874379.Add(key:  -1610604707, value:  this.selectModeConfigDF);
            string val_7 = UnityEngine.JsonUtility.ToJson(obj:  this.progressSkinConfigDF);
            536874379.Add(key:  -1610605211, value:  this.progressSkinConfigDF);
            string val_8 = UnityEngine.JsonUtility.ToJson(obj:  this.lotteryConfigDF);
            536874379.Add(key:  -1610606565, value:  this.lotteryConfigDF);
            string val_9 = UnityEngine.JsonUtility.ToJson(obj:  this.iAPConfigDF);
            536874379.Add(key:  -1610600067, value:  this.iAPConfigDF);
            string val_10 = UnityEngine.JsonUtility.ToJson(obj:  this.decoConfigDF);
            536874379.Add(key:  -1610608821, value:  this.decoConfigDF);
            string val_11 = UnityEngine.JsonUtility.ToJson(obj:  this.levelConfig2DF);
            536874379.Add(key:  -1610606669, value:  this.levelConfig2DF);
            if((mem[536887065] + 4) != 0)
            {
                    mem[536887065] + 4.Invoke(obj:  536874379);
            }
            
            Firebase.RemoteConfig.FirebaseRemoteConfig val_12 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance;
            System.Threading.Tasks.Task val_13 = 0.SetDefaultsAsync(defaults:  536874379);
        }
        private void GetRemoteData()
        {
            Firebase.RemoteConfig.FirebaseRemoteConfig val_1 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance;
            Firebase.RemoteConfig.ConfigValue val_2 = GetValue(key:  null);
            string val_3 = ???.StringValue;
            string val_4 = System.String.Format(format:  -1610612459, arg0:  -1610607957, arg1:  1148219504);
            this.ApiDebug(content:  -1610612459);
            LoadGameDictionary val_5 = UnityEngine.JsonUtility.FromJson<LoadGameDictionary>(json:  1148219504);
            this.gameConfig = ;
            Firebase.RemoteConfig.FirebaseRemoteConfig val_6 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance;
            Firebase.RemoteConfig.ConfigValue val_7 = GetValue(key:  null);
            string val_8 = ???.StringValue;
            string val_9 = System.String.Format(format:  -1610612459, arg0:  -1610608899, arg1:  1148219504);
            this.ApiDebug(content:  -1610612459);
            LoadGameDictionary val_10 = UnityEngine.JsonUtility.FromJson<LoadGameDictionary>(json:  1148219504);
            this.dailyRewardConfig = ;
            Firebase.RemoteConfig.FirebaseRemoteConfig val_11 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance;
            Firebase.RemoteConfig.ConfigValue val_12 = GetValue(key:  null);
            string val_13 = ???.StringValue;
            string val_14 = System.String.Format(format:  -1610612459, arg0:  -1610604425, arg1:  1148219504);
            this.ApiDebug(content:  -1610612459);
            LoadGameDictionary val_15 = UnityEngine.JsonUtility.FromJson<LoadGameDictionary>(json:  1148219504);
            this.spinConfig = ;
            Firebase.RemoteConfig.FirebaseRemoteConfig val_16 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance;
            Firebase.RemoteConfig.ConfigValue val_17 = GetValue(key:  null);
            string val_18 = ???.StringValue;
            string val_19 = System.String.Format(format:  -1610612459, arg0:  -1610604513, arg1:  1148219504);
            this.ApiDebug(content:  -1610612459);
            LoadGameDictionary val_20 = UnityEngine.JsonUtility.FromJson<LoadGameDictionary>(json:  1148219504);
            this.skinshopConfigNew = ;
            Firebase.RemoteConfig.FirebaseRemoteConfig val_21 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance;
            Firebase.RemoteConfig.ConfigValue val_22 = GetValue(key:  null);
            string val_23 = ???.StringValue;
            string val_24 = System.String.Format(format:  -1610612459, arg0:  -1610604707, arg1:  1148219504);
            this.ApiDebug(content:  -1610612459);
            LoadGameDictionary val_25 = UnityEngine.JsonUtility.FromJson<LoadGameDictionary>(json:  1148219504);
            this.selectModeConfig = ;
            Firebase.RemoteConfig.FirebaseRemoteConfig val_26 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance;
            Firebase.RemoteConfig.ConfigValue val_27 = GetValue(key:  null);
            string val_28 = ???.StringValue;
            string val_29 = System.String.Format(format:  -1610612459, arg0:  -1610605211, arg1:  1148219504);
            this.ApiDebug(content:  -1610612459);
            LoadGameDictionary val_30 = UnityEngine.JsonUtility.FromJson<LoadGameDictionary>(json:  1148219504);
            this.progressSkinConfig = ;
            Firebase.RemoteConfig.FirebaseRemoteConfig val_31 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance;
            Firebase.RemoteConfig.ConfigValue val_32 = GetValue(key:  null);
            string val_33 = ???.StringValue;
            string val_34 = System.String.Format(format:  -1610612459, arg0:  -1610606565, arg1:  1148219504);
            this.ApiDebug(content:  -1610612459);
            LoadGameDictionary val_35 = UnityEngine.JsonUtility.FromJson<LoadGameDictionary>(json:  1148219504);
            this.lotteryConfig = ;
            Firebase.RemoteConfig.FirebaseRemoteConfig val_36 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance;
            Firebase.RemoteConfig.ConfigValue val_37 = GetValue(key:  null);
            string val_38 = ???.StringValue;
            string val_39 = System.String.Format(format:  -1610612459, arg0:  -1610600067, arg1:  1148219504);
            this.ApiDebug(content:  -1610612459);
            LoadGameDictionary val_40 = UnityEngine.JsonUtility.FromJson<LoadGameDictionary>(json:  1148219504);
            this.iAPConfig = ;
            Firebase.RemoteConfig.FirebaseRemoteConfig val_41 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance;
            Firebase.RemoteConfig.ConfigValue val_42 = GetValue(key:  null);
            string val_43 = ???.StringValue;
            string val_44 = System.String.Format(format:  -1610612459, arg0:  -1610608821, arg1:  1148219504);
            this.ApiDebug(content:  -1610612459);
            LoadGameDictionary val_45 = UnityEngine.JsonUtility.FromJson<LoadGameDictionary>(json:  1148219504);
            this.decoConfig = ;
            Firebase.RemoteConfig.FirebaseRemoteConfig val_46 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance;
            Firebase.RemoteConfig.ConfigValue val_47 = GetValue(key:  null);
            string val_48 = ???.StringValue;
            string val_49 = System.String.Format(format:  -1610612459, arg0:  -1610606669, arg1:  1148219504);
            this.ApiDebug(content:  -1610612459);
            LoadGameDictionary val_50 = UnityEngine.JsonUtility.FromJson<LoadGameDictionary>(json:  1148219504);
            this.levelConfig2 = ;
            mem[536887065].Invoke();
            this.IsFirebaseFetchCompleted = true;
        }
        public void ApiDebug(string content)
        {
            mem[536882227] = content;
            UnityEngine.Debug.LogFormat(format:  -1610604059, args:  536882211);
        }
        public string CopyDefaultValue(int index)
        {
            if(true <= index)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (index << 2);
            return UnityEngine.JsonUtility.ToJson(obj:  (0 + (index) << 2) + 16);
        }
        private void InitDefault()
        {
            object val_1 = 536887289;
            val_1 = new System.Object();
            this.gameConfig = val_1;
            mem[1152921510050439176] = this.gameConfigDF;
            Dmobin.FirebaseService.DailyRewardConfig val_2 = 536885667;
            val_2 = new Dmobin.FirebaseService.DailyRewardConfig();
            mem[1152921510050439184] = val_2;
            mem[1152921510050439184] = this.dailyRewardConfigDF;
            Dmobin.FirebaseService.SpinConfig val_3 = 536894151;
            val_3 = new Dmobin.FirebaseService.SpinConfig();
            mem[1152921510050439192] = val_3;
            mem[1152921510050439192] = this.spinConfigDF;
            Dmobin.FirebaseService.SkinShopConfigNew val_4 = 536893977;
            val_4 = new Dmobin.FirebaseService.SkinShopConfigNew();
            mem[1152921510050439200] = val_4;
            mem[1152921510050439200] = this.skinshopConfigNewDF;
            Dmobin.FirebaseService.SelectModeConfig val_5 = 536893473;
            val_5 = new Dmobin.FirebaseService.SelectModeConfig();
            mem[1152921510050439208] = val_5;
            mem[1152921510050439208] = this.selectModeConfigDF;
            Dmobin.FirebaseService.ProgressSkinConfig val_6 = 536892267;
            val_6 = new Dmobin.FirebaseService.ProgressSkinConfig();
            mem[1152921510050439216] = val_6;
            mem[1152921510050439216] = this.progressSkinConfigDF;
            Dmobin.FirebaseService.LotteryConfig val_7 = 536889909;
            val_7 = new Dmobin.FirebaseService.LotteryConfig();
            mem[1152921510050439224] = val_7;
            mem[1152921510050439224] = this.lotteryConfigDF;
            Dmobin.FirebaseService.iAPConfig val_8 = 536897383;
            val_8 = new Dmobin.FirebaseService.iAPConfig();
            mem[1152921510050439232] = val_8;
            mem[1152921510050439232] = this.iAPConfigDF;
            Dmobin.FirebaseService.DecoConfig val_9 = 536885809;
            val_9 = new Dmobin.FirebaseService.DecoConfig();
            mem[1152921510050439240] = val_9;
            mem[1152921510050439240] = this.decoConfigDF;
            Dmobin.FirebaseService.LevelConfig2 val_10 = 536889541;
            val_10 = new Dmobin.FirebaseService.LevelConfig2();
            mem[1152921510050439248] = val_10;
            mem[1152921510050439248] = this.levelConfig2DF;
        }
        private void OnValidate()
        {
            this.commonClass.Clear();
            this.commonClass.Add(item:  this.gameConfigDF);
            this.commonClass.Add(item:  this.dailyRewardConfigDF);
            this.commonClass.Add(item:  this.spinConfigDF);
            this.commonClass.Add(item:  this.skinshopConfigNewDF);
            this.commonClass.Add(item:  this.selectModeConfigDF);
            this.commonClass.Add(item:  this.progressSkinConfigDF);
            this.commonClass.Add(item:  this.lotteryConfigDF);
            this.commonClass.Add(item:  this.iAPConfigDF);
            this.commonClass.Add(item:  this.decoConfigDF);
            this.commonClass.Add(item:  this.levelConfig2DF);
        }
        private string CreateClassString()
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = 0;
            val_7 = -1610612735;
            goto label_1;
            label_25:
            Dmobin.FirebaseService.RemoteRow val_7 = this.remoteRows[val_6];
            string val_1 = -1610602307(-1610602307) + this.remoteRows[0x0][0].remoteKey + -1610612545(-1610612545);
            val_8 = -1610602307;
            val_9 = 4;
            goto label_6;
            label_23:
            Dmobin.FirebaseService.RemoteRow val_8 = this.remoteRows[val_6];
            Dmobin.FirebaseService.RemoteParam val_9 = this.remoteRows[0x0][0].param[0];
            string val_2 = val_9.GetvariableType();
            Dmobin.FirebaseService.RemoteRow val_10 = this.remoteRows[val_6];
            Dmobin.FirebaseService.RemoteParam val_11 = this.remoteRows[0x0][0].param[0];
            string val_3 = System.String.Format(format:  -1610612657, arg0:  val_9, arg1:  this.remoteRows[0x0][0].param[0].paramName);
            string val_4 = -1610602307(-1610602307) + -1610612657(-1610612657);
            val_9 = 5;
            val_8 = val_8;
            label_6:
            Dmobin.FirebaseService.RemoteRow val_12 = this.remoteRows[val_6];
            if((val_9 - 4) < this.remoteRows[val_6])
            {
                goto label_23;
            }
            
            string val_6 = -1610612735(-1610612735) + -1610612685(-1610612685) + -1610602307(-1610602307) + -1610612655(-1610612655);
            val_6 = 1;
            val_7 = val_7;
            label_1:
            if(val_6 < val_7)
            {
                goto label_25;
            }
        
        }
        private string CreateSetDefaultString()
        {
            char val_7;
            var val_13;
            var val_14;
            val_13 = 4;
            val_14 = -1610597431;
            goto label_1;
            label_34:
            Dmobin.FirebaseService.RemoteRow val_14 = this.remoteRows[0];
            char val_1 = this.remoteRows[0].remoteKey.Chars[0];
            string val_2 = val_1.ToString();
            string val_3 = val_1.ToLower();
            System.Char[] val_4 = val_1.ToCharArray();
            string val_8 = this.remoteRows[0].remoteKey.Replace(oldChar:  this.remoteRows[0].remoteKey.Chars[0], newChar:  val_7);
            string val_9 = this.remoteRows[0].remoteKey + -1610608947(-1610608947);
            mem[536882417] = -1610612551;
            Dmobin.FirebaseService.RemoteRow val_15 = this.remoteRows[0];
            mem[536882421] = this.remoteRows[0].remoteKey;
            mem[536882425] = -1610612197;
            mem[536882429] = this.remoteRows[0].remoteKey;
            mem[536882433] = -1610611935;
            string val_10 = +536882401;
            string val_11 = -1610597431(-1610597431) + 536882401;
            val_13 = 5;
            val_14 = val_14;
            label_1:
            if((val_13 - 4) < val_14)
            {
                goto label_34;
            }
            
            string val_13 = -1610597431(-1610597431) + -1610612549(-1610612549);
        }
        private string CreateInitDefaultString()
        {
            char val_7;
            Dmobin.FirebaseService.FirebaseRemote val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            val_17 = this;
            val_18 = 0;
            val_19 = -1610597433;
            val_20 = 22708560;
            goto label_1;
            label_50:
            Dmobin.FirebaseService.RemoteRow val_17 = this.remoteRows[val_18];
            char val_1 = this.remoteRows[0x0][0].remoteKey.Chars[0];
            string val_2 = val_1.ToString();
            string val_3 = val_1.ToLower();
            System.Char[] val_4 = val_1.ToCharArray();
            char val_5 = this.remoteRows[0x0][0].remoteKey.Chars[0];
            if(this.remoteRows[0x0][0].remoteKey != null)
            {
                    string val_8 = this.remoteRows[0x0][0].remoteKey.Replace(oldChar:  val_5, newChar:  val_7);
                val_21 = this.remoteRows[0x0][0].remoteKey;
            }
            else
            {
                    string val_9 = 0.Replace(oldChar:  val_5, newChar:  val_7);
                val_21 = 0;
            }
            
            string val_11 = this.remoteRows[0x0][0].remoteKey.Replace(oldChar:  this.remoteRows[0x0][0].remoteKey.Chars[0], newChar:  val_7);
            string val_12 = this.remoteRows[0x0][0].remoteKey + -1610608947(-1610608947);
            mem[536882417] = -1610612555;
            val_20 = val_20;
            mem[536882421] = val_21;
            mem[536882425] = -1610610511;
            mem[536882429] = this.remoteRows[0x0][0].remoteKey;
            mem[536882433] = -1610612021;
            string val_13 = +536882401;
            mem[536882417] = -1610612555;
            mem[536882421] = val_21;
            mem[536882425] = -1610610515;
            mem[536882429] = this.remoteRows[0x0][0].remoteKey;
            mem[536882433] = -1610610697;
            string val_14 = +536882401;
            string val_15 = -1610597433(-1610597433) + 536882401 + 536882401;
            val_17 = val_17;
            val_18 = 1;
            val_19 = val_19;
            label_1:
            if(val_18 < val_19)
            {
                goto label_50;
            }
            
            string val_16 = -1610597433(-1610597433) + -1610612543(-1610612543);
        }
        private string CreatePubicString()
        {
            char val_7;
            var val_11;
            var val_12;
            val_11 = 0;
            val_12 = -1610612735;
            goto label_1;
            label_52:
            Dmobin.FirebaseService.RemoteRow val_11 = this.remoteRows[val_11];
            char val_1 = this.remoteRows[0x0][0].remoteKey.Chars[0];
            string val_2 = val_1.ToString();
            string val_3 = val_1.ToLower();
            System.Char[] val_4 = val_1.ToCharArray();
            string val_8 = this.remoteRows[0x0][0].remoteKey.Replace(oldChar:  this.remoteRows[0x0][0].remoteKey.Chars[0], newChar:  val_7);
            mem[536882417] = val_12;
            mem[536882421] = -1610612553;
            mem[536882425] = this.remoteRows[0x0][0].remoteKey;
            mem[536882429] = -1610612561;
            mem[536882433] = this.remoteRows[0x0][0].remoteKey;
            mem[536882437] = -1610610695;
            string val_9 = +536882401;
            mem[536882417] = 536882401;
            mem[536882421] = -1610612547;
            mem[536882425] = this.remoteRows[0x0][0].remoteKey;
            mem[536882429] = -1610612561;
            mem[536882433] = this.remoteRows[0x0][0].remoteKey;
            mem[536882437] = -1610608943;
            string val_10 = +536882401;
            val_11 = 1;
            val_12 = 536882401;
            label_1:
            if(val_11 < 536882401)
            {
                goto label_52;
            }
        
        }
        private string GetRemoteDataPair(string key, string className, string publicName)
        {
            mem[536882417] = -1610612287;
            mem[536882421] = key;
            mem[536882425] = -1610610513;
            mem[536882429] = key;
            mem[536882433] = -1610612185;
            mem[536882437] = key;
            mem[536882441] = -1610612477;
            mem[536882445] = key;
            mem[536882449] = -1610611931;
            mem[536882453] = key;
            mem[536882457] = -1610611863;
            mem[536882461] = key;
            mem[536882465] = -1610611937;
            mem[536882469] = publicName;
            mem[536882473] = -1610612475;
            mem[536882477] = className;
            mem[536882481] = -1610610497;
            mem[536882485] = key;
            mem[536882489] = -1610611929;
            return +536882401;
        }
        private string CreateGetDataString()
        {
            char val_7;
            var val_12;
            float val_13;
            val_12 = 4;
            val_13 = -1.08618E-19f;
            goto label_1;
            label_20:
            Dmobin.FirebaseService.RemoteRow val_13 = this.remoteRows[0];
            char val_1 = this.remoteRows[0].remoteKey.Chars[0];
            string val_2 = val_1.ToString();
            string val_3 = val_1.ToLower();
            System.Char[] val_4 = val_1.ToCharArray();
            string val_8 = this.remoteRows[0].remoteKey.Replace(oldChar:  this.remoteRows[0].remoteKey.Chars[0], newChar:  val_7);
            Dmobin.FirebaseService.RemoteRow val_14 = this.remoteRows[0];
            Dmobin.FirebaseService.RemoteRow val_15 = this.remoteRows[0];
            string val_9 = this.remoteRows[0].remoteKey.GetRemoteDataPair(key:  this.remoteRows[0].remoteKey, className:  this.remoteRows[0].remoteKey, publicName:  this.remoteRows[0].remoteKey);
            string val_10 = -1610597435(-1610597435) + -1610612685(-1610612685) + this.remoteRows[0].remoteKey;
            val_12 = 5;
            val_13 = val_13;
            label_1:
            if((val_12 - 4) < val_13)
            {
                goto label_20;
            }
            
            string val_12 = -1610597435(-1610597435) + -1610612439(-1610612439);
        }
        private string UpdateCommonClass()
        {
            char val_7;
            var val_11;
            var val_12;
            val_11 = 0;
            val_12 = -1610598795;
            goto label_1;
            label_14:
            Dmobin.FirebaseService.RemoteRow val_11 = this.remoteRows[val_11];
            char val_1 = this.remoteRows[0x0][0].remoteKey.Chars[0];
            string val_2 = val_1.ToString();
            string val_3 = val_1.ToLower();
            System.Char[] val_4 = val_1.ToCharArray();
            string val_8 = this.remoteRows[0x0][0].remoteKey.Replace(oldChar:  this.remoteRows[0x0][0].remoteKey.Chars[0], newChar:  val_7);
            string val_9 = -1610598795(-1610598795) + -1610601235(-1610601235) + this.remoteRows[0x0][0].remoteKey + -1610608945(-1610608945);
            val_11 = 1;
            val_12 = val_12;
            label_1:
            if(val_11 < val_12)
            {
                goto label_14;
            }
            
            string val_10 = -1610598795(-1610598795) + -1610596931(-1610596931);
        }
        public void ReadandWriteFile()
        {
            string val_1 = UnityEngine.Application.dataPath;
            string val_2 = null + -1610611697(-1610611697);
            string val_3 = this.CreateClassString();
            string val_4 = -1610612681(-1610612681) + 1151541616;
            string val_5 = this.CreatePubicString();
            string val_6 = this.CreateSetDefaultString();
            string val_7 = this.CreateGetDataString();
            string val_8 = this.UpdateCommonClass();
            string val_9 = this.CreateInitDefaultString();
            Dmobin.FirebaseService.FileChanger.WriteFile(filePath:  null, _createClass:  -1610612681, _createPublicValue:  1151541616, _createSetDefaultString:  1151541616, _createGetDataString:  this, _createValidateString:  this, _initDefaultValue:  this);
        }
        public void GetKey(string key)
        {
        
        }
        public FirebaseRemote()
        {
            536878111 = new System.Collections.Generic.List<Page>();
            this.commonClass = 536878111;
        }
    
    }

}
