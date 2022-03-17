using UnityEngine;
public class PickerWheel : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject linePrefab;
    private UnityEngine.Transform linesParent;
    private UnityEngine.Transform wheelCircle;
    private UnityEngine.GameObject wheelPiecePrefab;
    private UnityEngine.Transform wheelPiecesParent;
    private TMPro.TextMeshProUGUI notifText;
    private UnityEngine.GameObject wheelSpawn;
    private SpinInfo itemSpinDataInfo;
    private UnityEngine.AudioSource audioSource;
    private UnityEngine.AudioClip tickAudioClip;
    private float volume;
    private float pitch;
    public int spinDuration;
    public WheelPiece[] wheelPieces;
    private System.Collections.Generic.List<PieceController> listPieceController;
    private float maxAngle;
    private float angleCorrect;
    private UnityEngine.Events.UnityAction onSpinStartEvent;
    private UnityEngine.Events.UnityAction<WheelPiece> onSpinEndEvent;
    private bool _isSpinning;
    private UnityEngine.Vector2 pieceMinSize;
    private UnityEngine.Vector2 pieceMaxSize;
    private int piecesMin;
    private int piecesMax;
    private float pieceAngle;
    private float halfPieceAngle;
    private float halfPieceAngleWithPaddings;
    private double accumulatedWeight;
    private System.Random rand;
    private System.Collections.Generic.List<int> nonZeroChancesIndices;
    
    // Properties
    public bool IsSpinning { get; }
    
    // Methods
    public bool get_IsSpinning()
    {
        return (bool)this._isSpinning;
    }
    private void Start()
    {
        this.SetupAudio();
    }
    private void SetStartAngle()
    {
        if((AFramework.ManualSingletonMono<System.Object>.IsInstanceValid()) == false)
        {
                return;
        }
        
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        float val_3 = -1073708883.StartAngleSpin;
        UnityEngine.Transform val_4 = this.wheelCircle.transform;
        this.wheelCircle.eulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = -2.007854f};
    }
    public void SetData(SpinInfo itemInfo)
    {
        var val_2;
        var val_3;
        this.itemSpinDataInfo = itemInfo;
        val_2 = this;
        this.wheelPieces = 536882633;
        val_3 = 4;
        goto label_3;
        label_13:
        WheelPiece val_1 = 536897023;
        val_1 = new WheelPiece();
        mem[536897031] = itemInfo + 8 + 16 + 20;
        val_2 = 1152921509677136592;
        var val_3 = 16;
        mem[536882649] = val_1;
        val_3 = val_3 + 4;
        val_3 = 5;
        label_3:
        if((val_3 - 4) < mem[536882645])
        {
            goto label_13;
        }
        
        this.SpawnPiece();
    }
    public void SpawnPiece()
    {
        float val_1 = (float)S0;
        val_1 = 360f / val_1;
        float val_2 = 0.5f;
        this.pieceAngle = val_1;
        val_2 = val_1 * val_2;
        this.halfPieceAngle = val_2;
        this.halfPieceAngleWithPaddings = val_2;
        this.Generate();
        this.CalculateWeightsAndIndices();
        if(this == 0)
        {
                UnityEngine.Debug.LogError(message:  -1610602439);
        }
        
        this.SetStartAngle();
    }
    public void UpdateDisplay()
    {
        var val_3;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        val_3.UpdateDisplay();
        goto label_4;
        label_2:
        Dispose();
    }
    public void UpdateDisplay(int index)
    {
        if(true <= index)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + (index << 2);
        (0 + (index) << 2) + 16.UpdateDisplay();
    }
    public void SetNotifText(string value)
    {
        this.notifText.text = value;
    }
    private void SetupAudio()
    {
        this.audioSource.clip = this.tickAudioClip;
        this.audioSource.volume = null;
        this.audioSource.pitch = null;
    }
    private void Generate()
    {
        var val_9;
        this.listPieceController.Clear();
        UnityEngine.GameObject val_1 = this.InstantiatePiece();
        this.wheelSpawn = this;
        UnityEngine.Transform val_2 = this.wheelPiecePrefab.transform;
        UnityEngine.Transform val_3 = this.wheelPiecePrefab.GetChild(index:  1);
        UnityEngine.Transform val_4 = this.wheelPiecePrefab.GetComponent<UnityEngine.Transform>();
        float val_5 = UnityEngine.Mathf.InverseLerp(a:  (float)this.piecesMin, b:  null, value:  (float)S2);
        float val_9 = (float)this.piecesMin;
        val_9 = 1f - val_9;
        float val_6 = UnityEngine.Mathf.Lerp(a:  val_9, b:  null, t:  (float)S2);
        float val_7 = UnityEngine.Mathf.InverseLerp(a:  (float)this.piecesMin, b:  null, value:  (float)(float)S2);
        float val_10 = (float)this.piecesMin;
        val_10 = 1f - val_10;
        float val_8 = UnityEngine.Mathf.Lerp(a:  val_10, b:  null, t:  (float)(float)S2);
        if(this.wheelPiecePrefab != 0)
        {
                this.wheelPiecePrefab.SetSizeWithCurrentAnchors(axis:  0, size:  val_8);
        }
        else
        {
                this.wheelPiecePrefab.SetSizeWithCurrentAnchors(axis:  0, size:  val_8);
        }
        
        val_9 = 0;
        this.wheelPiecePrefab.SetSizeWithCurrentAnchors(axis:  1, size:  val_8);
        goto label_9;
        label_11:
        this.DrawPiece(index:  0);
        val_9 = 1;
        label_9:
        if(val_9 < this)
        {
            goto label_11;
        }
        
        UnityEngine.Object.Destroy(obj:  mem[this.wheelSpawn]);
    }
    private void DrawPiece(int index)
    {
        float val_4;
        float val_5;
        float val_6;
        float val_8;
        UnityEngine.GameObject val_1 = this.InstantiatePiece();
        Weight val_2 = this.GetComponent<Weight>();
        this.audioSource = this.itemSpinDataInfo.listItemSpin[index];
        this.UpdateDisplay();
        UnityEngine.Vector3 val_3 = position;
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.identity;
        object val_9 = UnityEngine.Object.Instantiate<System.Object>(original:  this.linePrefab, position:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6}, rotation:  new UnityEngine.Quaternion() {w = val_8}, parent:  this.linesParent);
        UnityEngine.Transform val_10 = this.linePrefab.transform;
        UnityEngine.Vector3 val_11 = position;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.back;
        this.linePrefab.RotateAround(point:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6}, axis:  new UnityEngine.Vector3(), angle:  index);
        UnityEngine.Transform val_13 = this.transform;
        UnityEngine.Vector3 val_14 = position;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.back;
        this.RotateAround(point:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6}, axis:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6}, angle:  this.pieceAngle * (float)index);
        this.listPieceController.Add(item:  776601872);
    }
    private UnityEngine.GameObject InstantiatePiece()
    {
        float val_2;
        float val_3;
        float val_4;
        float val_6;
        UnityEngine.Vector3 val_1 = position;
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
        object val_7 = UnityEngine.Object.Instantiate<System.Object>(original:  this.wheelPiecePrefab, position:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_2}, rotation:  new UnityEngine.Quaternion() {w = val_6}, parent:  this.wheelPiecesParent);
    }
    public void Spin()
    {
        float val_7;
        float val_8;
        float val_9;
        var val_17;
        var val_18;
        var val_19;
        536900287 = new PickerWheel.<>c__DisplayClass43_0();
        mem[536900295] = this;
        if(this._isSpinning == true)
        {
                return;
        }
        
        this._isSpinning = true;
        if(this.onSpinStartEvent != 0)
        {
                this.onSpinStartEvent.Invoke();
        }
        
        this.CalculateWeightsAndIndices();
        if(this == 0)
        {
                UnityEngine.Debug.LogError(message:  -1610602439);
        }
        
        val_17 = this.GetRandomPieceIndex();
        WheelPiece val_17 = this.wheelPieces[val_17];
        mem[536900311] = val_17;
        if((mem[536900311] == 0) && (536900311 != 0))
        {
                if(this.nonZeroChancesIndices != 0)
        {
                val_18 = this.nonZeroChancesIndices;
            val_19 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  val_17);
        }
        else
        {
                val_18 = 12;
            val_19 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  0);
        }
        
            if(val_18 <= val_19)
        {
                var val_18 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_18 = val_18 + (val_19 << 2);
            val_17 = mem[(0 + (val_4) << 2) + 16];
            val_17 = (0 + (val_4) << 2) + 16;
            mem[536900311] = this.wheelPieces[val_17];
        }
        
        float val_20 = -this.angleCorrect;
        val_20 = val_20 - this.halfPieceAngleWithPaddings;
        float val_21 = this.halfPieceAngleWithPaddings;
        val_21 = val_21 - this.angleCorrect;
        float val_5 = UnityEngine.Random.Range(minInclusive:  val_21, maxInclusive:  null);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.back;
        float val_22 = this.maxAngle;
        float val_25 = val_7;
        val_22 = val_22 + val_22;
        float val_24 = val_8;
        float val_23 = val_9;
        val_23 = val_23 * val_21;
        val_24 = val_24 * val_21;
        val_25 = val_25 * val_21;
        UnityEngine.Vector3 val_10 = eulerAngles;
        mem[536900299] = val_9;
        mem[536900303] = val_9;
        mem[536900307] = 0;
        DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions.DORotate(target:  this.wheelCircle, endValue:  new UnityEngine.Vector3() {x = val_25, y = val_24, z = val_23}, duration:  (float)this.spinDuration, mode:  (float)this.spinDuration);
        DG.Tweening.Tweener val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.wheelCircle, ease:  13);
        536895905 = new DG.Tweening.TweenCallback(object:  536900287, method:  new IntPtr(1610681191));
        DG.Tweening.Tweener val_14 = DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Tweener>(t:  this.wheelCircle, action:  536895905);
        536895905 = new DG.Tweening.TweenCallback(object:  536900287, method:  new IntPtr(1610681193));
        DG.Tweening.Tweener val_16 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  this.wheelCircle, action:  536895905);
    }
    public void OnSpinStart(UnityEngine.Events.UnityAction action)
    {
        this.onSpinStartEvent = action;
    }
    public void OnSpinEnd(UnityEngine.Events.UnityAction<WheelPiece> action)
    {
        this.onSpinEndEvent = action;
    }
    private int GetRandomPieceIndex()
    {
        var val_2;
        WheelPiece val_3;
        val_2 = 0;
        System.Random val_1 = this.rand * this.accumulatedWeight;
        goto label_1;
        label_7:
        val_3 = this.wheelPieces[val_2];
        if(val_3 >= 0)
        {
                return 0;
        }
        
        val_2 = 1;
        label_1:
        val_3 = this.wheelPieces;
        if(val_2 < this.wheelPieces[val_2])
        {
            goto label_7;
        }
        
        return 0;
    }
    private void CalculateWeightsAndIndices()
    {
        double val_2;
        float val_3;
        val_2 = 0;
        this.accumulatedWeight = val_2;
        mem[1152921509679698580] = val_2;
        this.nonZeroChancesIndices.Clear();
        goto label_2;
        label_10:
        double val_3 = this.accumulatedWeight;
        WheelPiece val_2 = this.wheelPieces[val_2];
        if(val_2 != 0)
        {
                val_3 = this.wheelPieces[0x0][0].Chance;
            double val_1 = val_3 + D16;
            this.accumulatedWeight = val_1;
            this.wheelPieces[0x0][0].Index = val_2;
            this.wheelPieces[0x0][0]._weight = val_1;
        }
        else
        {
                val_3 = 8;
            val_3 = val_3 + D16;
            this.accumulatedWeight = val_3;
            mem[16] = val_3;
            mem[12] = val_2;
        }
        
        if(val_2 > 0)
        {
                this.nonZeroChancesIndices.Add(item:  0);
        }
        
        val_2 = 1;
        label_2:
        if(val_2 < this.nonZeroChancesIndices)
        {
            goto label_10;
        }
    
    }
    public PickerWheel()
    {
        this.volume = 0.5f;
        this.pitch = 1f;
        this.spinDuration = 8;
        536878151 = new System.Collections.Generic.List<Page>();
        this.listPieceController = 536878151;
        this.maxAngle = 360f;
        this.piecesMin = 2;
        this.piecesMax = 12;
        System.Random val_2 = 536892443;
        val_2 = new System.Random();
        this.rand = val_2;
        536877987 = new System.Collections.Generic.List<System.Int32>();
        this.nonZeroChancesIndices = 536877987;
    }

}
