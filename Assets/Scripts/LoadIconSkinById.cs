using UnityEngine;
public class LoadIconSkinById : SingletonMonoBehaviour<LoadIconSkinById>
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.Sprite> listIconSkin;
    private System.Collections.Generic.List<UnityEngine.Sprite> listIconSkinHuggy;
    public UnityEngine.Sprite spriteCoin;
    public UnityEngine.Sprite spriteTape;
    
    // Methods
    public UnityEngine.Sprite LoadIcon(int id)
    {
        int val_1 = id;
        val_1 = val_1 - 1;
        if(true <= val_1)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + (val_1 << 2);
    }
    public UnityEngine.Sprite LoadHuggy(int id)
    {
        int val_1 = id;
        val_1 = val_1 - 1;
        if(true <= val_1)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + (val_1 << 2);
    }
    public LoadIconSkinById()
    {
        System.Collections.Generic.List<Page> val_1 = 536878331;
        val_1 = new System.Collections.Generic.List<Page>();
        this.listIconSkin = val_1;
        System.Collections.Generic.List<Page> val_2 = 536878331;
        val_2 = new System.Collections.Generic.List<Page>();
        this.listIconSkinHuggy = val_2;
    }

}
