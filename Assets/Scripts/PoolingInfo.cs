using UnityEngine;
[Serializable]
public class PoolingInfo
{
    // Fields
    public string name;
    public PrefabPoolType prefabType;
    public NamePrefabPool namePrefab;
    public UnityEngine.GameObject prefab;
    public int countStartSpawn;
    
    // Methods
    public PoolingInfo()
    {
    
    }

}
