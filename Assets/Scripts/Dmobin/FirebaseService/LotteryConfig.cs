using UnityEngine;

namespace Dmobin.FirebaseService
{
    [Serializable]
    public class LotteryConfig
    {
        // Fields
        public int MaxCountAdsRewardSkin;
        public int CountWinShowLottery;
        public bool FreeLotteryFirstOpen;
        public int[] LevelShowLotteryRopeRescue;
        public int[] LevelShowLotteryPinPull;
        public int[] LevelShowLotteryMixLevel;
        
        // Methods
        public LotteryConfig()
        {
        
        }
    
    }

}
