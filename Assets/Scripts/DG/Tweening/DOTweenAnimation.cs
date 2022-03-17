using UnityEngine;

namespace DG.Tweening
{
    public class DOTweenAnimation : ABSAnimationComponent
    {
        // Fields
        public bool targetIsSelf;
        public UnityEngine.GameObject targetGO;
        public bool tweenTargetIsTargetGO;
        public float delay;
        public float duration;
        public DG.Tweening.Ease easeType;
        public UnityEngine.AnimationCurve easeCurve;
        public DG.Tweening.LoopType loopType;
        public int loops;
        public string id;
        public bool isRelative;
        public bool isFrom;
        public bool isIndependentUpdate;
        public bool autoKill;
        public bool isActive;
        public bool isValid;
        public UnityEngine.Component target;
        public DG.Tweening.Core.DOTweenAnimationType animationType;
        public DG.Tweening.Core.TargetType targetType;
        public DG.Tweening.Core.TargetType forcedTargetType;
        public bool autoPlay;
        public bool useTargetAsV3;
        public float endValueFloat;
        public UnityEngine.Vector3 endValueV3;
        public UnityEngine.Vector2 endValueV2;
        public UnityEngine.Color endValueColor;
        public string endValueString;
        public UnityEngine.Rect endValueRect;
        public UnityEngine.Transform endValueTransform;
        public bool optionalBool0;
        public float optionalFloat0;
        public int optionalInt0;
        public DG.Tweening.RotateMode optionalRotationMode;
        public DG.Tweening.ScrambleMode optionalScrambleMode;
        public string optionalString;
        private bool _tweenCreated;
        private int _playCount;
        
        // Methods
        private void Awake()
        {
            var val_2 = this;
            if(this.isActive == true)
            {
                    this.isActive = this.isValid;
                goto label_0;
            }
            
            return;
            label_0:
            if(this.animationType == 1)
            {
                    if(this.useTargetAsV3 == true)
            {
                    return;
            }
            
            }
            
            R4.CreateTween();
            mem2[0] = 1;
        }
        private void Start()
        {
            if(this._tweenCreated == true)
            {
                    return;
            }
            
            if((R4 + 100) != 0)
            {
                    R4 + 100 = mem[R4 + 101];
                R4 + 100 = R4 + 101;
                goto label_0;
            }
            
            return;
            label_0:
            R4.CreateTween();
            mem2[0] = 1;
        }
        private void OnDestroy()
        {
            if(this != 0)
            {
                    bool val_1 = DG.Tweening.TweenExtensions.IsActive(t:  1423906448);
                if(val_1 != false)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  val_1, complete:  false);
            }
            
            }
            
            mem[1152921510325720772] = 0;
        }
        public void CreateTween()
        {
            UnityEngine.GameObject val_51;
            var val_52;
            var val_53;
            DG.Tweening.Core.TargetType val_54;
            if(this.targetIsSelf != false)
            {
                    UnityEngine.GameObject val_1 = this.gameObject;
                val_51 = this;
            }
            else
            {
                    val_51 = this.targetGO;
            }
            
            if(this.target != 0)
            {
                    if(val_51 != 0)
            {
                goto label_8;
            }
            
            }
            
            if((this.targetIsSelf != false) && (this.target == 0))
            {
                    UnityEngine.GameObject val_5 = this.target.gameObject;
                string val_6 = this.target.name;
                val_52 = this;
                val_53 = 22808220;
            }
            else
            {
                    UnityEngine.GameObject val_7 = this.target.gameObject;
                string val_8 = this.target.name;
                val_52 = this;
                val_53 = 22808224;
            }
            
            string val_9 = System.String.Format(format:  -1610597053, arg0:  1424153616);
            UnityEngine.GameObject val_10 = this.target.gameObject;
            UnityEngine.Debug.LogWarning(message:  -1610597053, context:  1424153616);
            return;
            label_8:
            val_54 = this.forcedTargetType;
            if(val_54 == 0)
            {
                goto label_18;
            }
            
            label_31:
            this.targetType = val_54;
            goto label_19;
            label_18:
            val_54 = this.targetType;
            if(val_54 == 0)
            {
                goto label_20;
            }
            
            label_19:
            DG.Tweening.Core.DOTweenAnimationType val_51 = this.animationType;
            val_51 = val_51 - 1;
            if(val_51 > 20)
            {
                goto label_71;
            }
            
            var val_11 = 7825908 + (7825908 + ((this.animationType - 1)) << 2);
            if(val_51 == 20)
            {
                    val_54 = val_54 & (this >> val_54);
                val_54 = val_54 & 356038404;
                val_54 = val_54 & 178019202;
                val_54 = val_54 & (val_54 >> 4);
                val_54 = val_54 & (val_54 << 5);
                mem2[0] = (((((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202) & ((int)(((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202)) >> 4) & (((((this.targetType &  + this;
                ((((((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202) & ((int)(((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202)) >> 4) & (((((this.targetType &  + this) & (((IP) << (32-R3)) | ((IP) << R3)) = (((((((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202) & ((int)(((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202)) >> 4) & (((((this.targetType &  + this) & (((IP) << (32-R3)) | ((IP) << R3))) & ((R8) << 8);
                ((((((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202) & ((int)(((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202)) >> 4) & (((((this.targetType &  + this) & (((IP) << (32-R3)) | ((IP) << R3)) = IP * this;
                ((((((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202) & ((int)(((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202)) >> 4) & (((((this.targetType &  + this) & (((IP) << (32-R3)) | ((IP) << R3)) = (((((((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202) & ((int)(((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202)) >> 4) & (((((this.targetType &  + this) & (((IP) << (32-R3)) | ((IP) << R3))) & ((((((((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202) & ((int)(((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202)) >> 4) & (((((this.targetType &  + this) & (((IP) << (32-R3)) | ((IP) << R3))) >> val_51);
                ((((((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202) & ((int)(((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202)) >> 4) & (((((this.targetType &  + this) & (((IP) << (32-R3)) | ((IP) << R3)) = R8 * val_51;
                ((((((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202) & ((int)(((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202)) >> 4) & (((((this.targetType &  + this) & (((IP) << (32-R3)) | ((IP) << R3)) = (((((((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202) & ((int)(((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202)) >> 4) & (((((this.targetType &  + this) & (((IP) << (32-R3)) | ((IP) << R3))) & ((((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11));
                ((((((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202) & ((int)(((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202)) >> 4) & (((((this.targetType &  + this) & (((IP) << (32-R3)) | ((IP) << R3)) = (((((((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202) & ((int)(((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202)) >> 4) & (((((this.targetType &  + this) & (((IP) << (32-R3)) | ((IP) << R3))) & ((((((((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202) & ((int)(((this.targetType & ((int)this) >> this.targetType) & 356038404) & 178019202)) >> 4) & (((((this.targetType &  + this) & (((IP) << (32-R3)) | ((IP) << R3))) >> 13);
                mem2[0] = (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13) + (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13);
                ((((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13) + (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13)) & (((int)(((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13) + (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13)) >> 14) = (((((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13) + (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13)) & (((int)(((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13) + (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13)) >> 14)) & ((R8) << 15);
                ((((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13) + (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13)) & (((int)(((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13) + (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13)) >> 14) = (((((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13) + (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13)) & (((int)(((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13) + (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13)) >> 14)) & ((IP) << R8);
                ((((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13) + (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13)) & (((int)(((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13) + (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13)) >> 14) = (((((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13) + (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13)) & (((int)(((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13) + (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> 13)) >> 14)) & (-602909470);
                mem2[0] = (((((((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >>  + (((((((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >> ;
                mem2[0] = (((((((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >>  + (((((((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11)) & (((R8 * this.targetGO) & (((R8 * this.targetGO)) << (32-11)) | (((R8 * this.targetGO)) << 11))) >>  + IP;
            }
            
            if(this.useTargetAsV3 == false)
            {
                goto label_22;
            }
            
            this.isRelative = false;
            if(this.endValueTransform != 0)
            {
                goto label_25;
            }
            
            UnityEngine.GameObject val_13 = this.endValueTransform.gameObject;
            string val_14 = this.target.name;
            string val_15 = System.String.Format(format:  -1610597051, arg0:  1424153616);
            UnityEngine.GameObject val_16 = this.target.gameObject;
            UnityEngine.Debug.LogWarning(message:  -1610597051, context:  1424153616);
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
            goto label_29;
            label_20:
            System.Type val_18 = this.target.GetType();
            DG.Tweening.Core.TargetType val_19 = DG.Tweening.DOTweenAnimation.TypeToDOTargetType(t:  this.target);
            goto label_31;
            label_25:
            if(this.targetType == 5)
            {
                    if(this.endValueTransform != 0)
            {
                    if(null != 536892591)
            {
                    this.endValueTransform = 0;
            }
            
            }
            
            }
        
        }
        public override void DOPlay()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.Play(targetOrId:  1424400784);
        }
        public override void DOPlayBackwards()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.PlayBackwards(targetOrId:  1424512784);
        }
        public override void DOPlayForward()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.PlayForward(targetOrId:  1424624784);
        }
        public override void DOPause()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.Pause(targetOrId:  1424736784);
        }
        public override void DOTogglePause()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.TogglePause(targetOrId:  1424848784);
        }
        public override void DORewind()
        {
            var val_5;
            var val_6;
            this._playCount = 0;
            UnityEngine.GameObject val_1 = this.gameObject;
            T[] val_2 = this.GetComponents<System.Object>();
            if(1152921510326775055 < 0)
            {
                    return;
            }
            
            val_5 = 1152921510326775059;
            goto label_4;
            label_11:
            val_5 = 1152921510326775058;
            label_4:
            val_6 = 1152921510326775054;
            if((R7 + 52) != 0)
            {
                    bool val_3 = DG.Tweening.TweenExtensions.IsInitialized(t:  R7 + 52);
                if(val_3 != false)
            {
                    DG.Tweening.TweenExtensions.Rewind(t:  val_3, includeDelay:  true);
            }
            
            }
            
            if(1152921510326775053 >= 0)
            {
                goto label_11;
            }
        
        }
        public override void DORestart()
        {
            goto typeof(DG.Tweening.DOTweenAnimation).__il2cppRuntimeField_114;
        }
        public override void DORestart(bool fromHere)
        {
            this._playCount = 0;
            if(true != 0)
            {
                    if(fromHere == true)
            {
                    true = this.isRelative;
            }
            
                if(true == true)
            {
                    true = this;
                this.ReEvaluateRelativeTween();
            }
            
                UnityEngine.GameObject val_1 = this.gameObject;
                int val_2 = DG.Tweening.DOTween.Restart(targetOrId:  1425184784, includeDelay:  true, changeDelayTo:  null);
                return;
            }
            
            if(mem[536885865] < 2)
            {
                    return;
            }
            
            DG.Tweening.Core.Debugger.LogNullTween(t:  0);
        }
        public override void DOComplete()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.Complete(targetOrId:  1425296784, withCallbacks:  false);
        }
        public override void DOKill()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.Kill(targetOrId:  1425408784, complete:  false);
            mem[1152921510327223108] = 0;
        }
        public void DOPlayById(string id)
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.Play(target:  1425524880, id:  id);
        }
        public void DOPlayAllById(string id)
        {
            int val_1 = DG.Tweening.DOTween.Play(targetOrId:  id);
        }
        public void DOPauseAllById(string id)
        {
            int val_1 = DG.Tweening.DOTween.Pause(targetOrId:  id);
        }
        public void DOPlayBackwardsById(string id)
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.PlayBackwards(target:  1425885456, id:  id);
        }
        public void DOPlayBackwardsAllById(string id)
        {
            int val_1 = DG.Tweening.DOTween.PlayBackwards(targetOrId:  id);
        }
        public void DOPlayForwardById(string id)
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.PlayForward(target:  1426125840, id:  id);
        }
        public void DOPlayForwardAllById(string id)
        {
            int val_1 = DG.Tweening.DOTween.PlayForward(targetOrId:  id);
        }
        public void DOPlayNext()
        {
            T[] val_1 = this.GetComponents<UnityEngine.PolygonCollider2D>();
            do
            {
                if(this._playCount >= 1152921510328176399)
            {
                    return;
            }
            
                int val_2 = this._playCount + 1;
                this._playCount = val_2;
                DG.Tweening.DOTweenAnimation val_3 = this + (val_2 << 2);
            }
            while((val_2 == 0) || (((this._playCount + 1) + 52) == 0));
            
            if((DG.Tweening.TweenExtensions.IsPlaying(t:  (this._playCount + 1) + 52)) != true)
            {
                    if((DG.Tweening.TweenExtensions.IsComplete(t:  (this._playCount + 1) + 52)) != true)
            {
                    DG.Tweening.Tween val_7 = DG.Tweening.TweenExtensions.Play<DG.Tweening.Tween>(t:  (this._playCount + 1) + 52);
            }
            
            }
        
        }
        public void DORewindAndPlayNext()
        {
            this._playCount = 0;
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.Rewind(targetOrId:  1426474128, includeDelay:  true);
            this.DOPlayNext();
        }
        public void DORewindAllById(string id)
        {
            this._playCount = 0;
            int val_1 = DG.Tweening.DOTween.Rewind(targetOrId:  id, includeDelay:  true);
        }
        public void DORestartById(string id)
        {
            this._playCount = 0;
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.Restart(target:  1426710416, id:  id, includeDelay:  true, changeDelayTo:  null);
        }
        public void DORestartAllById(string id)
        {
            this._playCount = 0;
            int val_1 = DG.Tweening.DOTween.Restart(targetOrId:  id, includeDelay:  true, changeDelayTo:  null);
        }
        public System.Collections.Generic.List<DG.Tweening.Tween> GetTweens()
        {
            var val_3;
            536878457 = new System.Collections.Generic.List<Page>();
            T[] val_2 = this.GetComponents<UnityEngine.PolygonCollider2D>();
            val_3 = 0;
            goto label_1;
            label_6:
            536878457.Add(item:  R6 + 52);
            val_3 = 1;
            label_1:
            if(val_3 < 536878457)
            {
                goto label_6;
            }
        
        }
        public static DG.Tweening.Core.TargetType TypeToDOTargetType(System.Type t)
        {
            string val_12;
            string val_13;
            val_12 = t;
            int val_1 = val_12.LastIndexOf(value:  -1610611787);
            if(val_1 != 1)
            {
                    string val_3 = val_12.Substring(startIndex:  val_1 + 1);
                val_12 = val_12;
            }
            
            if((val_12.IndexOf(value:  -1610604955)) != 1)
            {
                    if((System.String.op_Inequality(a:  val_12, b:  -1610604403)) == false)
            {
                    val_13 = val_12;
            }
            
            }
            else
            {
                    val_13 = val_12;
            }
            
            if((System.String.op_Equality(a:  val_13, b:  -1610604865)) == false)
            {
                    -1610603341 = val_13;
            }
            
            if((System.String.op_Equality(a:  -1610603341, b:  -1610604863)) == false)
            {
                    -1610603341 = -1610603341;
            }
            
            if((System.String.op_Equality(a:  -1610603341, b:  -1610605031)) == false)
            {
                    -1610603341 = -1610603341;
            }
            
            if((System.String.op_Equality(a:  -1610603341, b:  -1610605083)) == false)
            {
                    -1610607479 = -1610603341;
            }
            
            System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073765959)});
            object val_11 = System.Enum.Parse(enumType:  1073765959, value:  -1610607479);
            if((mem[1073765959] + 32) == mem[536895079])
            {
                    Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
                return;
            }
        
        }
        public DG.Tweening.Tween CreateEditorPreview()
        {
            var val_2 = 0;
            if(UnityEngine.Application.isPlaying == true)
            {
                    return;
            }
            
            this.CreateTween();
        }
        private UnityEngine.GameObject GetTweenGO()
        {
            if(this.targetIsSelf == false)
            {
                    this = this.targetGO;
                return;
            }
            
            return this.gameObject;
        }
        private void ReEvaluateRelativeTween()
        {
            float val_9;
            float val_10;
            float val_11;
            UnityEngine.GameObject val_14;
            var val_15;
            if(this.targetIsSelf != false)
            {
                    UnityEngine.GameObject val_1 = this.gameObject;
                val_14 = this;
            }
            else
            {
                    val_14 = this.targetGO;
            }
            
            if(val_14 == 0)
            {
                    UnityEngine.GameObject val_3 = this.gameObject;
                string val_4 = val_14.name;
                string val_5 = System.String.Format(format:  -1610597053, arg0:  1427419280);
                UnityEngine.GameObject val_6 = this.gameObject;
                UnityEngine.Debug.LogWarning(message:  -1610597053, context:  1427419280);
                return;
            }
            
            if(this.animationType != 2)
            {
                    if(this.animationType != 1)
            {
                    return;
            }
            
                UnityEngine.Transform val_7 = val_14.transform;
                val_14 = 0;
                UnityEngine.Vector3 val_8 = position;
                float val_14 = val_9;
                float val_15 = val_10;
                val_14 = val_14 + this.endValueV3;
                float val_16 = val_11;
                val_15 = val_15 + S8;
                val_16 = val_16 + S10;
                val_10 = val_15;
                val_9 = val_14;
                val_11 = val_16;
                val_15 = 536896653;
                if(22974595 == 0)
            {
                    return;
            }
            
                var val_17 = static_value_015E9083 + 100;
                val_17 = val_17 + (mem[536896115] << 2);
                var val_18 = static_value_015E9083 + 100;
                val_18 = val_18 + (mem[536896115] << 2);
                val_14 = 0;
                return;
            }
            
            UnityEngine.Transform val_12 = val_14.transform;
            UnityEngine.Vector3 val_13 = val_9.localPosition;
            float val_19 = val_9;
            float val_20 = val_10;
            val_19 = val_19 + this.endValueV3;
            float val_21 = val_11;
            val_20 = val_20 + S8;
            val_21 = val_21 + S10;
            val_10 = val_20;
            val_9 = val_19;
            val_11 = val_21;
            val_15 = 536896653;
            val_14 = 22716104;
            if(22974595 != 0)
            {
                    var val_22 = static_value_015E9083 + 100;
                val_22 = val_22 + (mem[536896115] << 2);
            }
            
            bool val_23 = mem[536896115];
            val_23 = (static_value_015E9083 + 100) + (val_23 << 2);
        }
        public DOTweenAnimation()
        {
            this.tweenTargetIsTargetGO = true;
            this.targetIsSelf = true;
            this.duration = 1f;
            this.easeType = 6;
            UnityEngine.Keyframe val_1 = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_2 = 536882139 + 16;
            mem[536882171] = val_1.m_WeightedMode;
            mem[536882175] = val_1.m_InWeight;
            mem[536882179] = val_1.m_Time;
            UnityEngine.Keyframe val_3 = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_4 = 536882139 + 44;
            mem[536882199] = val_3.m_WeightedMode;
            mem[536882203] = val_3.m_Time;
            mem[536882207] = val_3.m_Time;
            UnityEngine.AnimationCurve val_5 = 536883291;
            val_5 = new UnityEngine.AnimationCurve(keys:  536882139);
            this.easeCurve = val_5;
            this.loops = 1;
            this.id = -1610612735;
            this.autoPlay = 1;
            this.autoKill = true;
            this.isActive = true;
            UnityEngine.Color val_6 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            this.endValueString = -1610612735;
            UnityEngine.Rect val_7 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            this._playCount = 0;
        }
        private void <CreateTween>b__40_0()
        {
            mem[1152921510329465796] = 0;
        }
    
    }

}
