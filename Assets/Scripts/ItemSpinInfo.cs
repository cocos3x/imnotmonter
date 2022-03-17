using UnityEngine;
[Serializable]
public class ItemSpinInfo
{
    // Fields
    public string name;
    public ItemResourceType itemType;
    public int rewardValue;
    public float probability;
    
    // Methods
    public ItemSpinInfo()
    {
        this.itemType = 1;
    }

}
