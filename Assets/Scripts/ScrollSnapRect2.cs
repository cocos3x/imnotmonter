using UnityEngine;
public class ScrollSnapRect2 : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
{
    // Fields
    public int startingPage;
    public float fastSwipeThresholdTime;
    public int fastSwipeThresholdDistance;
    public float decelerationRate;
    public UnityEngine.GameObject prevButton;
    public UnityEngine.GameObject nextButton;
    public UnityEngine.Sprite unselectedPage;
    public UnityEngine.Sprite selectedPage;
    public UnityEngine.Transform pageSelectionIcons;
    private int _fastSwipeThresholdMaxLimit;
    private UnityEngine.UI.ScrollRect _scrollRectComponent;
    private UnityEngine.RectTransform _scrollRectRect;
    private UnityEngine.RectTransform _container;
    private bool _horizontal;
    private int _pageCount;
    private int _currentPage;
    private bool _lerp;
    private UnityEngine.Vector2 _lerpTo;
    private System.Collections.Generic.List<UnityEngine.Vector2> _pagePositions;
    private bool _dragging;
    private float _timeStamp;
    private UnityEngine.Vector2 _startPosition;
    private bool _showPageSelection;
    private int _previousPageSelectionIndex;
    private System.Collections.Generic.List<UnityEngine.UI.Image> _pageSelectionImages;
    private UnityEngine.GameObject[] pageDots;
    private UnityEngine.GameObject skinPopupManager;
    
    // Methods
    private void Start()
    {
        UnityEngine.Events.UnityAction val_10;
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        this._scrollRectComponent = this;
        UnityEngine.Transform val_2 = this.GetComponent<UnityEngine.Transform>();
        this._scrollRectRect = this;
        this._container = this._scrollRectComponent.m_Content;
        this._pageCount = this._container.childCount;
        if(this._scrollRectComponent.m_Horizontal == false)
        {
            goto label_4;
        }
        
        val_10 = mem[this._scrollRectComponent];
        if((mem[this._scrollRectComponent] + 17) == 0)
        {
            goto label_6;
        }
        
        label_4:
        val_10 = mem[this._scrollRectComponent];
        if((mem[this._scrollRectComponent] + 16) == 0)
        {
            goto label_8;
        }
        
        label_25:
        UnityEngine.Debug.LogWarning(message:  -1610609243);
        label_6:
        label_24:
        this._lerp = false;
        this._horizontal = true;
        this.SetPagePositions();
        this.SetPage(aPageIndex:  this.startingPage);
        this.InitPageSelection();
        this.SetPageSelection(aPageIndex:  this.startingPage);
        if((UnityEngine.Object.op_Implicit(exists:  this.nextButton)) != false)
        {
                Weight val_5 = this.nextButton.GetComponent<Weight>();
            val_10 = 536896275;
            val_10 = new UnityEngine.Events.UnityAction(object:  568501904, method:  new IntPtr(1610677877));
            this.nextButton.AddListener(call:  536896275);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.prevButton)) == false)
        {
                return;
        }
        
        Weight val_8 = this.prevButton.GetComponent<Weight>();
        536896275 = new UnityEngine.Events.UnityAction(object:  568501904, method:  new IntPtr(1610677879));
        this.prevButton.AddListener(call:  536896275);
        return;
        label_8:
        if((mem[this._scrollRectComponent] + 17) != 0)
        {
            goto label_24;
        }
        
        goto label_25;
    }
    public void UpdateContent()
    {
        var val_4;
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        this._scrollRectComponent = this;
        UnityEngine.Transform val_2 = this.GetComponent<UnityEngine.Transform>();
        this._scrollRectRect = this;
        this._container = this._scrollRectComponent.m_Content;
        this._pageCount = this._container.childCount;
        if(this._scrollRectComponent.m_Horizontal == false)
        {
            goto label_4;
        }
        
        val_4 = mem[this._scrollRectComponent];
        if((mem[this._scrollRectComponent] + 17) == 0)
        {
            goto label_6;
        }
        
        label_4:
        val_4 = mem[this._scrollRectComponent];
        if((mem[this._scrollRectComponent] + 16) == 0)
        {
            goto label_8;
        }
        
        label_13:
        UnityEngine.Debug.LogWarning(message:  -1610609243);
        label_6:
        label_12:
        this._lerp = false;
        this._horizontal = true;
        this.SetPagePositions();
        this.SetPage(aPageIndex:  this.startingPage);
        this.InitPageSelection();
        this.SetPageSelection(aPageIndex:  this.startingPage);
        return;
        label_8:
        if((mem[this._scrollRectComponent] + 17) != 0)
        {
            goto label_12;
        }
        
        goto label_13;
    }
    private void Update()
    {
        float val_4;
        float val_5;
        float val_13;
        float val_14;
        UnityEngine.Vector2 val_15;
        if(this._lerp == false)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        uint val_13 = 0;
        val_13 = this.decelerationRate * val_13;
        float val_2 = UnityEngine.Mathf.Min(a:  val_13, b:  null);
        UnityEngine.Vector2 val_3 = anchoredPosition;
        float val_6 = UnityEngine.Mathf.Clamp01(value:  val_3.x);
        float val_7 = S22 - val_5;
        UnityEngine.Vector2 val_8 = this._lerpTo - val_4;
        val_13 = val_5;
        val_14 = val_4;
        val_15 = this._lerpTo;
        this._container.anchoredPosition = new UnityEngine.Vector2() {x = val_14, y = val_13};
        UnityEngine.Vector2 val_9 = anchoredPosition;
        float val_14 = val_4;
        float val_15 = val_5;
        val_14 = val_14 - this._lerpTo.x;
        val_15 = val_15 - this._lerpTo.y;
        float val_10 = UnityEngine.Vector2.SqrMagnitude(a:  new UnityEngine.Vector2() {x = val_14, y = val_15});
        if(this._container < 0)
        {
                val_13 = false;
            this._container.anchoredPosition = new UnityEngine.Vector2() {x = mem[this._lerpTo + (0)], y = mem[this._lerpTo + (4)]};
            this._lerp = val_13;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.zero;
            this._scrollRectComponent.m_Velocity = new UnityEngine.Vector2();
            mem2[0] = ???;
        }
        
        if(this._showPageSelection == false)
        {
                return;
        }
        
        this.SetPageSelection(aPageIndex:  this.GetNearestPage());
    }
    private void SetPagePositions()
    {
        int val_19;
        var val_20;
        int val_21;
        int val_22;
        float val_23;
        float val_24;
        float val_25;
        int val_26;
        if(this._horizontal != false)
        {
                UnityEngine.Rect val_1 = rect;
            float val_2 = width;
            val_19 = (int)568944632;
            UnityEngine.Rect val_3 = rect;
            float val_4 = height;
            val_21 = this._pageCount * val_19;
            val_22 = (int)568944632;
        }
        else
        {
                UnityEngine.Rect val_5 = rect;
            float val_6 = height;
            val_19 = (int)568944632;
            UnityEngine.Rect val_7 = rect;
            float val_8 = width;
            val_22 = this._pageCount * val_19;
            int val_9 = val_19 + (val_19 >> 31);
            val_9 = val_9 >> 1;
            val_21 = (int)568944632;
        }
        
        this._fastSwipeThresholdMaxLimit = val_19;
        this._container.sizeDelta = new UnityEngine.Vector2() {x = (float)val_21, y = (float)val_22};
        val_23 = (val_21 + (val_21 >> 31)) >> 1;
        this._container.anchoredPosition = new UnityEngine.Vector2() {x = (float)val_23, y = 0f};
        this._pagePositions.Clear();
        if(this._pageCount < 1)
        {
                return;
        }
        
        int val_15 = val_21;
        var val_17 = 0;
        val_15 = val_15 + (val_15 >> 31);
        val_15 = val_15 >> 1;
        int val_11 = val_15 - val_23;
        val_22 = ((val_22 + (val_22 >> 31)) >> 1) - val_9;
        do
        {
            UnityEngine.Transform val_13 = this._container.GetChild(index:  0);
            UnityEngine.Transform val_14 = this._container.GetComponent<UnityEngine.Transform>();
            val_24 = 0;
            val_25 = 0;
            val_26 = val_11;
            if(this._horizontal != true)
        {
                val_24 = (float)val_22;
            val_26 = val_15;
            val_25 = val_24;
        }
        
            float val_16 = (float)val_26;
            this._container.anchoredPosition = new UnityEngine.Vector2() {x = val_16, y = val_25};
            val_21 = this._pagePositions;
            val_16 = val_16 ^ 2147483648;
            val_23 = val_24 ^ 2147483648;
            val_21.Add(item:  new UnityEngine.Vector2() {x = val_16, y = val_23});
            val_17 = val_17 + 1;
            val_20 = val_11 + val_21;
            val_22 = val_22 - val_19;
        }
        while(val_17 < this._pageCount);
    
    }
    private void SetPage(int aPageIndex)
    {
        float val_5;
        UnityEngine.GameObject val_6;
        if(true <= aPageIndex)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = val_5 + (aPageIndex << 3);
        val_5 = mem[(0 + (aPageIndex) << 3) + 20];
        val_5 = (0 + (aPageIndex) << 3) + 20;
        this._container.anchoredPosition = new UnityEngine.Vector2() {x = (0 + (aPageIndex) << 3) + 16, y = val_5};
        this._currentPage = aPageIndex;
        if((UnityEngine.Object.op_Implicit(exists:  this.nextButton)) != false)
        {
                val_5 = this._pageCount;
            if(this.nextButton != 0)
        {
                (val_5 - 1) - aPageIndex = 1;
        }
        
            this.nextButton.SetActive(value:  true);
        }
        
        val_6 = this.prevButton;
        if((UnityEngine.Object.op_Implicit(exists:  val_6)) != false)
        {
                val_6 = this.prevButton;
            if(aPageIndex != 0)
        {
                aPageIndex = 1;
        }
        
            val_6.SetActive(value:  true);
        }
        
        this.SetDots(index:  aPageIndex);
    }
    private void LerpToPage(int aPageIndex)
    {
        int val_2 = UnityEngine.Mathf.Clamp(value:  aPageIndex, min:  0, max:  this._pageCount - 1);
        if(val_2 <= val_2)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = val_7 + (val_2 << 3);
        this._lerp = true;
        this._lerpTo = (0 + (val_2) << 3) + 16;
        mem[1152921509471097444] = (0 + (val_2) << 3) + 20;
        this._currentPage = val_2;
        if((UnityEngine.Object.op_Implicit(exists:  this.nextButton)) != false)
        {
                if(this.nextButton != 0)
        {
                val_2 - (this._pageCount - 1) = 1;
        }
        
            this.nextButton.SetActive(value:  true);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.prevButton)) == false)
        {
                return;
        }
        
        if(val_2 != 0)
        {
                val_2 = 1;
        }
        
        this.prevButton.SetActive(value:  true);
    }
    private void InitPageSelection()
    {
        UnityEngine.Transform val_12;
        var val_13;
        val_12 = false;
        if(this.unselectedPage == 0)
        {
            goto label_3;
        }
        
        bool val_2 = UnityEngine.Object.op_Inequality(x:  this.selectedPage, y:  0);
        this._showPageSelection = val_2;
        if(val_2 == false)
        {
                return;
        }
        
        if((this.pageSelectionIcons == 0) || (this.pageSelectionIcons.childCount != this._pageCount))
        {
            goto label_11;
        }
        
        this._previousPageSelectionIndex = 0;
        val_13 = 0;
        UnityEngine.Debug.LogWarning(message:  -1610607423);
        536877975 = new System.Collections.Generic.List<Page>();
        this._pageSelectionImages = 536877975;
        goto label_14;
        label_24:
        UnityEngine.Transform val_6 = this.pageSelectionIcons.GetChild(index:  0);
        UnityEngine.Transform val_7 = this.pageSelectionIcons.GetComponent<UnityEngine.Transform>();
        if(this.pageSelectionIcons == 0)
        {
                string val_9 = 0.ToString();
            string val_10 = -1610605467(-1610605467) + 569428104 + -1610612351(-1610612351);
            UnityEngine.Debug.LogWarning(message:  -1610605467);
        }
        
        this._pageSelectionImages.Add(item:  this.pageSelectionIcons);
        val_13 = 1;
        label_14:
        val_12 = this.pageSelectionIcons;
        if(val_13 < val_12.childCount)
        {
            goto label_24;
        }
        
        return;
        label_3:
        this._showPageSelection = val_12;
        return;
        label_11:
        UnityEngine.Debug.LogWarning(message:  -1610608731);
        this._showPageSelection = false;
    }
    private void SetPageSelection(int aPageIndex)
    {
        if(this._previousPageSelectionIndex != aPageIndex)
        {
                true = this._showPageSelection;
        }
        
        if(true != true)
        {
                return;
        }
        
        if(this._previousPageSelectionIndex >= 0)
        {
                if(true <= this._previousPageSelectionIndex)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_1 = val_1 + (this._previousPageSelectionIndex << 2);
            (0 + (this._previousPageSelectionIndex) << 2) + 16.sprite = this.unselectedPage;
            if(((0 + (this._previousPageSelectionIndex) << 2) + 16) <= this._previousPageSelectionIndex)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_2 = val_2 + (this._previousPageSelectionIndex << 2);
        }
        
        if(((0 + (this._previousPageSelectionIndex) << 2) + 16) <= aPageIndex)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + (aPageIndex << 2);
        (0 + (aPageIndex) << 2) + 16.sprite = this.selectedPage;
        if(((0 + (aPageIndex) << 2) + 16) <= aPageIndex)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + (aPageIndex << 2);
        this._previousPageSelectionIndex = aPageIndex;
        this.SetDots(index:  aPageIndex);
    }
    private void NextScreen()
    {
        this.LerpToPage(aPageIndex:  this._currentPage + 1);
        this.SetDots(index:  this._currentPage);
    }
    private void PreviousScreen()
    {
        this.LerpToPage(aPageIndex:  this._currentPage - 1);
        this.SetDots(index:  this._currentPage);
    }
    private int GetNearestPage()
    {
        var val_2;
        var val_3;
        var val_5;
        var val_6;
        int val_7;
        val_5 = 0;
        UnityEngine.Vector2 val_1 = anchoredPosition;
        val_6 = 16;
        val_7 = this._currentPage;
        goto label_2;
        label_6:
        if( <= val_5)
        {
                float val_5 = 0f;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = val_5 + val_6;
        float val_6 = val_5;
        float val_7 = (0 + val_6) + 4;
        val_6 = val_2 - val_6;
        val_7 = val_3 - val_7;
        float val_4 = UnityEngine.Vector2.SqrMagnitude(a:  new UnityEngine.Vector2() {x = val_6, y = val_7});
        val_6 = 24;
        if( < 0)
        {
                3.402823E+38f = val_6;
            val_7 = val_5;
        }
        
        val_5 = 1;
        label_2:
        if(val_5 < val_6)
        {
            goto label_6;
        }
        
        return (int)val_7;
    }
    public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData aEventData)
    {
        this._dragging = false;
        this._lerp = false;
    }
    public void OnEndDrag(UnityEngine.EventSystems.PointerEventData aEventData)
    {
        var val_2;
        var val_4;
        float val_7;
        if(this._horizontal != false)
        {
                UnityEngine.Vector2 val_1 = anchoredPosition;
            val_7 = this._startPosition - val_2;
        }
        else
        {
                UnityEngine.Vector2 val_3 = anchoredPosition;
            var val_7 = val_4;
            val_7 = S16 - val_7;
            val_7 = -val_7;
        }
        
        float val_5 = UnityEngine.Time.unscaledTime;
        float val_8 = this._timeStamp;
        val_8 = 0 - val_8;
        if(this._container >= 0)
        {
            goto label_6;
        }
        
        float val_9 = System.Math.Abs(val_7);
        if((this._container <= 0) || (this._container >= 0))
        {
            goto label_6;
        }
        
        if(this._container > 0)
        {
                this._container = this._currentPage + 1;
        }
        
        this.LerpToPage(aPageIndex:  this._container = this._currentPage - 1);
        this.SetDots(index:  this._currentPage);
        goto label_7;
        label_6:
        this.LerpToPage(aPageIndex:  this.GetNearestPage());
        label_7:
        this._dragging = false;
    }
    public void OnDrag(UnityEngine.EventSystems.PointerEventData aEventData)
    {
        if(this._dragging != false)
        {
                if(this._showPageSelection == false)
        {
                return;
        }
        
            this.SetPageSelection(aPageIndex:  this.GetNearestPage());
            return;
        }
        
        this._dragging = true;
        float val_2 = UnityEngine.Time.unscaledTime;
        this._timeStamp = 0f;
        UnityEngine.Vector2 val_3 = anchoredPosition;
        this._startPosition = new UnityEngine.Vector2();
        mem[1152921509472177784] = ???;
    }
    private void SetDots(int index)
    {
        var val_4 = 0;
        goto label_0;
        label_8:
        UnityEngine.GameObject val_4 = this.pageDots[val_4];
        UnityEngine.Transform val_1 = val_4.transform;
        UnityEngine.Transform val_2 = val_4.GetChild(index:  1);
        UnityEngine.GameObject val_3 = val_4.gameObject;
        if(index != val_4)
        {
                0 = 0;
        }
        
        if(index == val_4)
        {
                0 = 1;
        }
        
        val_4.SetActive(value:  true);
        val_4 = 1;
        label_0:
        if(val_4 < val_4)
        {
            goto label_8;
        }
    
    }
    public ScrollSnapRect2()
    {
        this.fastSwipeThresholdTime = 0.3f;
        this.fastSwipeThresholdDistance = 100;
        this.decelerationRate = 10f;
        536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        this._pagePositions = 536878507;
    }
    private void <Start>b__27_0()
    {
        this.LerpToPage(aPageIndex:  this._currentPage + 1);
        this.SetDots(index:  this._currentPage);
    }
    private void <Start>b__27_1()
    {
        this.LerpToPage(aPageIndex:  this._currentPage - 1);
        this.SetDots(index:  this._currentPage);
    }

}
