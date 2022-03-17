using UnityEngine;

namespace AFramework.UI
{
    public class BaseUIMenu : BaseUIComp
    {
        // Fields
        protected AFramework.UI.eUILayer _UILayer;
        protected bool _Unique;
        protected bool _canDestroy;
        protected AnimToolUI.AnimUIManager animUiMgr;
        private string <UIIdentifier>k__BackingField;
        private float <MenuActiveTime>k__BackingField;
        
        // Properties
        public AFramework.UI.eUILayer UILayer { get; }
        public bool IsUnique { get; }
        public bool CanDestroy { get; }
        public string UIIdentifier { get; set; }
        public float MenuActiveTime { get; set; }
        
        // Methods
        public AFramework.UI.eUILayer get_UILayer()
        {
        
        }
        public bool get_IsUnique()
        {
            return (bool)this._Unique;
        }
        public bool get_CanDestroy()
        {
            return (bool)this._canDestroy;
        }
        public string get_UIIdentifier()
        {
        
        }
        public void set_UIIdentifier(string value)
        {
            this.<UIIdentifier>k__BackingField = value;
        }
        public virtual void Init(object[] initParams)
        {
        
        }
        public virtual void Pop()
        {
            bool val_1 = AFramework.UI.CanvasManager.PopSelf(menu:  1177875504, destroy:  false);
        }
        public virtual void HandleSafeChoice()
        {
        
        }
        public float get_MenuActiveTime()
        {
            return (float)S0;
        }
        protected void set_MenuActiveTime(float value)
        {
            this.<MenuActiveTime>k__BackingField = ;
        }
        public void UpdateActiveTime(float delta)
        {
            float val_1 = R1;
            val_1 = (this.<MenuActiveTime>k__BackingField) + val_1;
            this.<MenuActiveTime>k__BackingField = val_1;
        }
        public void ResetActiveTime()
        {
            this.<MenuActiveTime>k__BackingField = 0f;
        }
        public BaseUIMenu()
        {
            this._Unique = true;
            this._UILayer = true;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
