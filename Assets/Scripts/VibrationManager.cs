using UnityEngine;
public class VibrationManager : SingletonMonoBehaviour<VibrationManager>
{
    // Methods
    public void Vibrate(VibrationManager.HapticType type)
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.Vibrate) == false)
        {
                return;
        }
        
        if(type >= 9)
        {
                type = 9;
        }
        
        MoreMountains.NiceVibrations.MMVibrationManager.Haptic(type:  9, defaultToRegularVibrate:  false, alsoRumble:  false, coroutineSupport:  0, controllerID:  0);
    }
    private MoreMountains.NiceVibrations.HapticTypes GetHapticType(VibrationManager.HapticType hapticType)
    {
        if(hapticType >= 9)
        {
                hapticType = 9;
        }
    
    }
    public VibrationManager()
    {
    
    }

}
