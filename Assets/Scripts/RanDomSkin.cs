using UnityEngine;
public class RanDomSkin : MonoBehaviour
{
    // Fields
    private Spine.Unity.SkeletonGraphic ske1;
    private Spine.Unity.SkeletonGraphic ske2;
    private readonly System.Collections.Generic.List<int> listId;
    
    // Methods
    private void OnEnable()
    {
        this.RandomSkin();
    }
    private void RandomSkin()
    {
        var val_8;
        int val_1 = Berry.Utils.Utils.GetRandom<System.Int32>(collection:  this.listId);
        bool val_2 = this.listId.Remove(item:  val_1);
        val_8 = 536884779;
        if(((mem[536884966] & true) == 0) && (mem[536884895] == 0))
        {
                val_8 = 536884779;
        }
        
        string val_4 = val_1.ToString();
        string val_5 = mem[536884871] + 836982156;
        MixSkinManager.SetSkinSkeletonGraphic(ske:  this.ske1, nameSkin:  mem[536884871]);
        string val_6 = Berry.Utils.Utils.GetRandom<System.Int32>(collection:  this.listId).ToString();
        string val_7 = mem[536884871] + 836982152;
        MixSkinManager.SetSkinSkeletonGraphic(ske:  this.ske2, nameSkin:  mem[536884871]);
        this.SetAnimation(ske:  this.ske1, name:  -1610603215, loop:  true, timeScale:  null, _callBack:  1065353216);
        this.SetAnimation(ske:  this.ske2, name:  -1610603217, loop:  true, timeScale:  null, _callBack:  1065353216);
    }
    private void SetAnimation(Spine.Unity.SkeletonGraphic ske, string name, bool loop, float timeScale = 1, System.Action _callBack)
    {
        var val_1;
        536900687 = new RanDomSkin.<>c__DisplayClass5_0();
        mem[536900695] = val_1;
        Spine.AnimationState val_3 = ske.AnimationState;
        Spine.TrackEntry val_4 = ske.SetAnimation(trackIndex:  0, animationName:  name, loop:  loop);
        mem2[0] = _callBack;
        if(mem[536900695] == 0)
        {
                return;
        }
        
        536897929 = new AnimationState.TrackEntryDelegate(object:  536900687, method:  new IntPtr(1610682057));
        ske.add_Complete(value:  536897929);
    }
    public RanDomSkin()
    {
        var val_2;
        536877987 = new System.Collections.Generic.List<System.Int32>();
        if(536877987 != 0)
        {
                val_2 = 22737108;
            536877987.Add(item:  0);
            536877987.Add(item:  1);
            536877987.Add(item:  2);
            536877987.Add(item:  3);
            536877987.Add(item:  4);
            536877987.Add(item:  5);
            536877987.Add(item:  6);
            536877987.Add(item:  7);
            536877987.Add(item:  8);
            536877987.Add(item:  9);
            536877987.Add(item:  10);
            536877987.Add(item:  11);
            536877987.Add(item:  12);
            536877987.Add(item:  13);
            536877987.Add(item:  14);
            536877987.Add(item:  15);
            536877987.Add(item:  16);
            536877987.Add(item:  17);
            536877987.Add(item:  18);
            536877987.Add(item:  19);
            536877987.Add(item:  20);
            536877987.Add(item:  21);
            536877987.Add(item:  22);
        }
        else
        {
                val_2 = 22737108;
            536877987.Add(item:  0);
            536877987.Add(item:  1);
            536877987.Add(item:  2);
            536877987.Add(item:  3);
            536877987.Add(item:  4);
            536877987.Add(item:  5);
            536877987.Add(item:  6);
            536877987.Add(item:  7);
            536877987.Add(item:  8);
            536877987.Add(item:  9);
            536877987.Add(item:  10);
            536877987.Add(item:  11);
            536877987.Add(item:  12);
            536877987.Add(item:  13);
            536877987.Add(item:  14);
            536877987.Add(item:  15);
            536877987.Add(item:  16);
            536877987.Add(item:  17);
            536877987.Add(item:  18);
            536877987.Add(item:  19);
            536877987.Add(item:  20);
            536877987.Add(item:  21);
            536877987.Add(item:  22);
        }
        
        536877987.Add(item:  23);
        this.listId = 536877987;
    }

}
