using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenModuleUtils
    {
        // Fields
        private static bool _initialized;
        
        // Methods
        public static void Init()
        {
            if(mem[536885697] != 0)
            {
                    return;
            }
            
            mem2[0] = 1;
            536873505 = new System.Action<DG.Tweening.Plugins.Options.PathOptions, DG.Tweening.Tween, UnityEngine.Quaternion, UnityEngine.Transform>(object:  0, method:  new IntPtr(1610691243));
            DG.Tweening.Core.DOTweenExternalCommand.add_SetOrientationOnPath(value:  536873505);
        }
        private static void Preserver()
        {
            System.AppDomain val_1 = System.AppDomain.CurrentDomain;
            System.Reflection.Assembly[] val_2 = 0.GetAssemblies();
            System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073761571)});
            System.Reflection.MethodInfo val_4 = 1073761571.GetMethod(name:  -1610604287);
        }
    
    }

}
