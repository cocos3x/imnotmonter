using UnityEngine;

namespace AFramework
{
    public interface ISaveData
    {
        // Properties
        public abstract bool DataChanged { get; set; }
        
        // Methods
        public abstract object GetData(); // 0
        public abstract void SetData(string data); // 0
        public abstract void OnAllDataLoaded(); // 0
        public abstract void RegisterSaveData(); // 0
        public abstract bool get_DataChanged(); // 0
        public abstract void set_DataChanged(bool value); // 0
    
    }

}
