using UnityEngine;
public class LotterySlotController : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Button openNormalButton;
    public UnityEngine.UI.Button openWithAdsButton;
    private DG.Tweening.DOTweenAnimation mainDoAnim;
    private bool isOpen;
    private Spine.Unity.SkeletonGraphic boxSkeleton;
    private Spine.Unity.SkeletonGraphic characterSkeleton;
    private UnityEngine.GameObject rewardCoin;
    private TMPro.TextMeshProUGUI rewardCoinValueText;
    private UnityEngine.GameObject rewardTape;
    private TMPro.TextMeshProUGUI rewardTapeValueText;
    private UnityEngine.GameObject rewardSkin;
    private TMPro.TextMeshProUGUI textQuestionMark;
    private LotteryPopup.TypeItemLottery typeItemLottery;
    
    // Methods
    private void OnDisable()
    {
        this.StopAllCoroutines();
        UnityEngine.Transform val_1 = this.openWithAdsButton.transform;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.openWithAdsButton.localScale = new UnityEngine.Vector3() {x = R6, y = R7, z = R8};
        UnityEngine.Transform val_3 = this.openNormalButton.transform;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        this.openNormalButton.localScale = new UnityEngine.Vector3() {x = R5, y = R6, z = R7};
    }
    public void EnableAnimation()
    {
        System.Collections.IEnumerator val_1 = this.WaitPlayAudioEnableAnim();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  772303888);
    }
    private System.Collections.IEnumerator WaitPlayAudioEnableAnim()
    {
        536899659 = new LotterySlotController.<WaitPlayAudioEnableAnim>d__15(<>1__state:  0);
        mem[536899675] = this;
    }
    public void CloseBox()
    {
        this.StopAllCoroutines();
        this.SetBoxAnimation(name:  -1610600013, loop:  true, time:  null);
        this.rewardCoin.SetActive(value:  false);
        this.rewardTape.SetActive(value:  false);
        this.rewardSkin.SetActive(value:  false);
        UnityEngine.GameObject val_1 = this.textQuestionMark.gameObject;
        this.textQuestionMark.SetActive(value:  true);
        this.openNormalButton.enabled = true;
        this.openWithAdsButton.enabled = true;
        int val_2 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.openNormalButton, complete:  false);
        int val_3 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.openWithAdsButton, complete:  false);
        UnityEngine.GameObject val_4 = this.openNormalButton.gameObject;
        this.openNormalButton.SetActive(value:  true);
        UnityEngine.GameObject val_5 = this.openWithAdsButton.gameObject;
        this.openWithAdsButton.SetActive(value:  true);
        this.isOpen = false;
    }
    public void ShowNomal()
    {
        float val_4;
        UnityEngine.GameObject val_1 = this.openNormalButton.gameObject;
        this.openNormalButton.SetActive(value:  true);
        UnityEngine.Transform val_2 = this.openNormalButton.transform;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        this.openNormalButton.localScale = new UnityEngine.Vector3() {x = R6, y = R7, z = val_4};
        UnityEngine.GameObject val_5 = this.openWithAdsButton.gameObject;
        this.openWithAdsButton.SetActive(value:  false);
        UnityEngine.Transform val_6 = this.openWithAdsButton.transform;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        this.openWithAdsButton.localScale = new UnityEngine.Vector3() {x = R5, y = R6, z = R7};
    }
    public void ShowAdsIfOpenFree()
    {
        this.openNormalButton.enabled = false;
        this.openWithAdsButton.enabled = false;
        UnityEngine.Transform val_1 = this.openNormalButton.transform;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.openNormalButton, endValue:  new UnityEngine.Vector3(), duration:  val_2.x);
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.openNormalButton, ease:  26);
        536895905 = new DG.Tweening.TweenCallback(object:  772882960, method:  new IntPtr(1610681111));
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  this.openNormalButton, action:  536895905);
    }
    public void ShowOnlyAds()
    {
        float val_4;
        UnityEngine.GameObject val_1 = this.openWithAdsButton.gameObject;
        this.openWithAdsButton.SetActive(value:  true);
        UnityEngine.Transform val_2 = this.openWithAdsButton.transform;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        this.openWithAdsButton.localScale = new UnityEngine.Vector3() {x = R6, y = R7, z = val_4};
        UnityEngine.GameObject val_5 = this.openNormalButton.gameObject;
        this.openNormalButton.SetActive(value:  false);
        UnityEngine.Transform val_6 = this.openNormalButton.transform;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        this.openNormalButton.localScale = new UnityEngine.Vector3() {x = R5, y = R6, z = R7};
    }
    public void OpenBox(LotteryPopup.TypeItemLottery type, int value)
    {
        if(this.isOpen != false)
        {
                return;
        }
        
        this.isOpen = true;
        UnityEngine.GameObject val_1 = this.openNormalButton.gameObject;
        this.openNormalButton.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.openWithAdsButton.gameObject;
        this.openWithAdsButton.SetActive(value:  false);
        this.SetBoxAnimation(name:  -1610598931, loop:  false, time:  null);
        this.typeItemLottery = type;
        System.Collections.IEnumerator val_3 = this.WaitRewardToMove(value:  value);
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  773164304);
    }
    public void CheckWithAnotherBoxOpen(int turn = 1)
    {
        if(turn == 1)
        {
                turn = this.isOpen;
        }
        
        if(turn == true)
        {
                return;
        }
        
        this.ShowAdsIfOpenFree();
    }
    private System.Collections.IEnumerator WaitRewardToMove(int value)
    {
        LotterySlotController.<WaitRewardToMove>d__22 val_1 = 536899661;
        val_1 = new LotterySlotController.<WaitRewardToMove>d__22(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536899677] = this;
        }
        else
        {
                mem[16] = this;
        }
        
        mem[536899681] = value;
    }
    public void SetBoxAnimation(string name, bool loop, float time = 1)
    {
        Spine.AnimationState val_1 = this.boxSkeleton.AnimationState;
        Spine.TrackEntry val_2 = this.boxSkeleton.SetAnimation(trackIndex:  0, animationName:  name, loop:  loop);
        Spine.AnimationState val_3 = this.boxSkeleton.AnimationState;
        mem2[0] = R3;
    }
    public float GetTimeDurationBoxAnimation(string name)
    {
        Spine.Skeleton val_1 = this.boxSkeleton.Skeleton;
        Spine.Animation val_2 = this.boxSkeleton.FindAnimation(animationName:  name);
        if(this.boxSkeleton != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private System.Collections.IEnumerator SetSkinRewardAnimation(int skinId)
    {
        LotterySlotController.<SetSkinRewardAnimation>d__25 val_1 = 536899657;
        val_1 = new LotterySlotController.<SetSkinRewardAnimation>d__25(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536899673] = this;
        }
        else
        {
                mem[16] = this;
        }
        
        mem[536899677] = skinId;
    }
    private void SetStartAnimation()
    {
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                536884781 = 536884781;
        }
        
        MixSkinManager.SetAnimation(ske:  this.characterSkeleton, name:  mem[536884873], loop:  true, timeScale:  null, _callBack:  1065353216);
    }
    public LotterySlotController()
    {
    
    }
    private void <ShowAdsIfOpenFree>b__18_0()
    {
        UnityEngine.GameObject val_1 = this.openNormalButton.gameObject;
        this.openNormalButton.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.openWithAdsButton.gameObject;
        this.openWithAdsButton.SetActive(value:  true);
        UnityEngine.Transform val_3 = this.openWithAdsButton.transform;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.openWithAdsButton, endValue:  new UnityEngine.Vector3(), duration:  val_4.x);
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.openWithAdsButton, ease:  27);
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  this.openWithAdsButton, delay:  val_4.x);
        536895905 = new DG.Tweening.TweenCallback(object:  774134032, method:  new IntPtr(1610681113));
        DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  this.openWithAdsButton, action:  536895905);
    }
    private void <ShowAdsIfOpenFree>b__18_1()
    {
        this.openWithAdsButton.enabled = true;
    }
    private bool <SetSkinRewardAnimation>b__25_0()
    {
        if((mem[536891408] & true) != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.characterSkeleton);
        }
        
        if(mem[536891337] != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.characterSkeleton);
        }
        
        return UnityEngine.Object.op_Implicit(exists:  this.characterSkeleton);
    }

}
