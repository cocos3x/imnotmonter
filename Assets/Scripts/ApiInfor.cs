using UnityEngine;
[Serializable]
public class ApiInfor
{
    // Fields
    public bool IsEnableDebug;
    public bool IsUseBanner;
    public bool IsUseInterstitial;
    public bool IsUseReward;
    public bool IsMuteMaxAds;
    public int InterstitialInterval;
    public float TimeLoading;
    
    // Methods
    public ApiInfor()
    {
        this.InterstitialInterval = 60;
        this.TimeLoading = 1f;
    }

}
