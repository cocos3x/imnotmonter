using UnityEngine;
public class ScrollViewAdapter : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.ScrollRect m_scrollRect;
    public UnityEngine.RectTransform m_prefabCell;
    public int m_columnCount;
    public ScrollViewAdapter.Padding m_padding;
    public UnityEngine.Vector2 m_cellSize;
    public UnityEngine.Vector2 m_spacing;
    public bool m_updateCellValueAllRowAsync;
    public bool m_updateSiblingIndex;
    public ScrollViewAdapter.SetCellValueEvent m_SetCellValue;
    private System.Collections.Generic.LinkedList<UnityEngine.RectTransform> m_Rows;
    private UnityEngine.Vector2 m_rowSize;
    private bool m_inited;
    private int m_totalCell;
    private UnityEngine.RectTransform m_rectSyncer;
    private DG.Tweening.Tweener m_tweenerDOVerticalNormalizedPos;
    private UnityEngine.Vector2 t_tempAnchoredPosition;
    
    // Properties
    public UnityEngine.UI.ScrollRect ScrollRectAttached { get; }
    
    // Methods
    private void Start()
    {
        this.Init();
    }
    private void Init()
    {
        if(this.m_inited == true)
        {
                return;
        }
        
        R4.InitContentRectTransform();
        var val_2 = R4 + 36;
        float val_3 = R4 + 40;
        val_2 = val_2 + (R4 + 44);
        val_3 = val_3 + (R4 + 48);
        mem2[0] = R4 + 44;
        mem2[0] = val_3;
        R4.CreateRectSyncer();
        R4.InitRow();
        536880161 = new UnityEngine.Events.UnityAction<UnityEngine.Vector2>(object:  R4, method:  new IntPtr(1610678067));
        R4 + 12 + 68.AddListener(call:  536880161);
        mem2[0] = 1;
        R4.UpdateCellValueAllRow();
    }
    private void InitIfNeed()
    {
        if(this.m_inited == true)
        {
                return;
        }
        
        this.Init();
    }
    private void InitContentRectTransform()
    {
        float val_2;
        this.m_scrollRect.m_Content.anchorMin = new UnityEngine.Vector2() {x = 0f, y = 1f};
        this.m_scrollRect.m_Content.anchorMax = new UnityEngine.Vector2() {x = 0f, y = 1f};
        this.m_scrollRect.m_Content.pivot = new UnityEngine.Vector2() {x = 0f, y = 1f};
        UnityEngine.Vector2 val_1 = anchoredPosition;
        this.m_scrollRect.m_Content.anchoredPosition = new UnityEngine.Vector2() {x = 0f, y = val_2};
    }
    private void CalculateRowSize()
    {
        UnityEngine.Vector2 val_2 = this.m_cellSize;
        val_2 = val_2 + this.m_spacing;
        this.m_rowSize = this.m_spacing;
        mem[1152921509482284756] = S4 + S8;
    }
    private void InitRow()
    {
        float val_13;
        var val_17;
        var val_18;
        var val_19;
        UnityEngine.Object val_20;
        float val_21;
        float val_22;
        var val_23;
        var val_24;
        var val_25;
        System.Collections.IEnumerator val_1 = this.m_scrollRect.m_Content.GetEnumerator();
        label_22:
        val_17 = 0;
        val_17 = val_17 + 1;
        val_18 = this.m_scrollRect.m_Content;
        if(this.m_scrollRect.m_Content == 0)
        {
            goto label_8;
        }
        
        var val_18 = 0;
        val_18 = val_18 + 1;
        val_19 = this.m_scrollRect.m_Content;
        if(this.m_scrollRect.m_Content != 0)
        {
                if(null == 536892591)
        {
            goto label_15;
        }
        
        }
        
        if(this.m_scrollRect.m_Content == 0)
        {
            goto label_16;
        }
        
        label_15:
        if(null == 536892591)
        {
            goto label_17;
        }
        
        val_20 = 0;
        goto label_19;
        label_16:
        val_20 = 0;
        goto label_19;
        label_17:
        val_20 = this.m_scrollRect.m_Content;
        label_19:
        UnityEngine.GameObject val_4 = val_20.gameObject;
        UnityEngine.Object.Destroy(obj:  val_20);
        goto label_22;
        label_8:
        val_21 = 1;
        val_22 = 0;
        if(this.m_scrollRect.m_Content != 0)
        {
                var val_19 = 0;
            val_17 = 0;
            val_19 = val_19 + 1;
            val_17 = (uint)val_19 & 65535;
            val_23 = this.m_scrollRect.m_Content;
        }
        
        if(val_21 != 0)
        {
                var val_6 = val_21 - 1;
        }
        
        UnityEngine.Transform val_7 = this.m_scrollRect.GetComponent<UnityEngine.Transform>();
        UnityEngine.Rect val_8 = rect;
        float val_9 = height;
        float val_20 = this.m_scrollRect.m_VerticalScrollbarSpacing;
        var val_22 = 0;
        val_20 = 580603128 - val_20;
        val_20 = val_20 / val_8.m_Width;
        val_24 = UnityEngine.Mathf.CeilToInt(f:  val_20);
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.zero;
        if((val_24 + 2) < 1)
        {
                return;
        }
        
        int val_21 = 1;
        val_22 = val_13;
        val_21 = val_21 - val_24;
        val_21 = 4.016402E-38f;
        do
        {
            536887303 = new UnityEngine.GameObject(name:  -1610604843);
            SynchronizationContextBehavoir val_15 = 536887303.AddComponent<SynchronizationContextBehavoir>();
            val_24 = 536887303;
            val_24.SetParent(parent:  this.m_scrollRect.m_Content, worldPositionStays:  false);
            val_25 = 536900949;
            if(((mem[536901136] & true) == 0) && (mem[536901065] == 0))
        {
                val_25 = 536900949;
        }
        
            val_24.anchorMin = new UnityEngine.Vector2() {x = mem[536901041], y = mem[536901041] + 4};
            val_24.anchorMax = new UnityEngine.Vector2() {x = mem[536901041] + 8, y = mem[536901041] + 12};
            val_24.pivot = new UnityEngine.Vector2() {x = mem[536901041] + 16, y = mem[536901041] + 20};
            val_24.sizeDelta = new UnityEngine.Vector2() {x = this.m_rowSize, y = mem[536901041] + 20};
            val_24.anchoredPosition = new UnityEngine.Vector2() {x = val_22, y = val_8.m_Width};
            System.Collections.Generic.LinkedListNode<T> val_16 = this.m_Rows.AddLast(value:  536887303);
            System.Collections.Generic.LinkedListNode<T> val_17 = this.m_Rows.Last;
            this.InitCellInRow(row:  -1073717185);
            val_22 = val_22 - 1;
        }
        while(val_21 != val_22);
    
    }
    private void InitCellInRow(UnityEngine.RectTransform row)
    {
        var val_4;
        var val_9;
        var val_11 = 0;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        if(this.m_columnCount < 1)
        {
                return;
        }
        
        do
        {
            UnityEngine.RectTransform val_2 = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  this.m_prefabCell, parent:  row);
            this.m_prefabCell.SetParent(parent:  row, worldPositionStays:  false);
            val_9 = 536900949;
            if(((mem[536901136] & true) == 0) && (mem[536901065] == 0))
        {
                val_9 = 536900949;
        }
        
            this.m_prefabCell.anchorMin = new UnityEngine.Vector2() {x = mem[536901041], y = mem[536901041] + 4};
            this.m_prefabCell.anchorMax = new UnityEngine.Vector2() {x = mem[536901041] + 8, y = mem[536901041] + 12};
            this.m_prefabCell.sizeDelta = new UnityEngine.Vector2() {x = mem[this.m_cellSize + (0)], y = mem[this.m_cellSize + (4)]};
            UnityEngine.Vector2 val_3 = pivot;
            var val_9 = val_4;
            val_9 = 1f - val_9;
            UnityEngine.Vector2 val_6 = pivot;
            UnityEngine.Vector2 val_10 = this.m_cellSize;
            val_10 = val_10 + this.m_spacing;
            this.m_prefabCell.anchoredPosition = new UnityEngine.Vector2() {x = this.m_padding, y = (S18 * val_9) ^ 2147483648};
            val_11 = val_11 + 1;
        }
        while(val_11 < this.m_columnCount);
    
    }
    private void InitContentSize()
    {
        UnityEngine.Vector2 val_6 = this.m_cellSize;
        val_6 = val_6 + this.m_spacing;
        float val_1 = S4 + S8;
        this.m_rowSize = this.m_spacing;
        mem[1152921509482719060] = val_1;
        UnityEngine.Rect val_2 = rect;
        UnityEngine.Vector2 val_3 = size;
        float val_7 = (float)this.m_columnCount;
        val_7 = (float)this.m_totalCell / val_7;
        int val_4 = UnityEngine.Mathf.CeilToInt(f:  val_7);
        this.m_scrollRect.m_Content.sizeDelta = new UnityEngine.Vector2() {x = this.m_rowSize, y = val_1 + this.m_spacing};
    }
    public void SetTotalCell(int total)
    {
        if(this.m_inited == false)
        {
                this.m_inited = this;
            this.Init();
        }
        
        this.m_totalCell = total;
        this.InitContentSize();
    }
    private void CreateRectSyncer()
    {
        if(this.m_rectSyncer != 0)
        {
                return;
        }
        
        536887303 = new UnityEngine.GameObject(name:  -1610605035);
        SynchronizationContextBehavoir val_3 = 536887303.AddComponent<SynchronizationContextBehavoir>();
        if(536887303 != 0)
        {
                536887303.SetParent(parent:  this.m_scrollRect.m_Viewport, worldPositionStays:  false);
            536887303.anchorMin = new UnityEngine.Vector2() {x = 0f, y = 1f};
            536887303.anchorMax = new UnityEngine.Vector2() {x = 0f, y = 1f};
            536887303.pivot = new UnityEngine.Vector2() {x = 0f, y = 1f};
        }
        else
        {
                0.SetParent(parent:  this.m_scrollRect.m_Viewport, worldPositionStays:  false);
            536887303.anchorMin = new UnityEngine.Vector2() {x = 0f, y = 1f};
            536887303.anchorMax = new UnityEngine.Vector2() {x = 0f, y = 1f};
            536887303.pivot = new UnityEngine.Vector2() {x = 0f, y = 1f};
        }
        
        536887303.sizeDelta = new UnityEngine.Vector2() {x = 0f, y = 0f};
        this.m_rectSyncer = 536887303;
    }
    private UnityEngine.Vector2 GetAnchoredPositionInViewportSpace(UnityEngine.RectTransform rectInContent)
    {
        float val_2;
        float val_3;
        float val_4;
        UnityEngine.Vector3 val_1 = position;
        R6.position = new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4};
        UnityEngine.Vector2 val_5 = anchoredPosition;
        return new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
    }
    private void ScrollRect_OnValueChanged(UnityEngine.Vector2 axis)
    {
        var val_3;
        UnityEngine.Vector2 val_16;
        var val_17;
        System.Collections.Generic.LinkedList<UnityEngine.RectTransform> val_18;
        val_16 = this.t_tempAnchoredPosition;
        var val_16 = 2;
        val_17 = 22734940;
        do
        {
            System.Collections.Generic.LinkedListNode<T> val_1 = this.m_Rows.Next;
            UnityEngine.Vector2 val_2 = GetAnchoredPositionInViewportSpace(rectInContent:  581467408);
            var val_15 = val_3;
            val_15 = val_15 - S2;
            if(this.m_Rows > 0)
        {
                System.Collections.Generic.LinkedListNode<T> val_4 = this.m_Rows.Last;
            UnityEngine.Vector2 val_5 = anchoredPosition;
            val_18 = this.m_Rows;
            this.t_tempAnchoredPosition = new UnityEngine.Vector2();
            mem[1152921509483281772] = ???;
            if(val_18 != 0)
        {
            
        }
        else
        {
                val_18 = this.m_Rows;
            if(val_18 == 0)
        {
                val_18 = 0;
        }
        
        }
        
            val_18.RemoveFirst();
            this.m_Rows.AddLast(node:  R7);
            val_5.x = S2 - val_5.x;
            mem[1152921509483281772] = val_5.x;
            System.Collections.Generic.LinkedListNode<T> val_6 = this.m_Rows.Last;
            this.m_Rows.anchoredPosition = new UnityEngine.Vector2() {x = mem[this.t_tempAnchoredPosition + (0)], y = mem[this.t_tempAnchoredPosition + (4)]};
            val_17 = 22734940;
            System.Collections.Generic.LinkedListNode<T> val_7 = this.m_Rows.Last;
            this.UpdateCellValueAtRow(row:  -1073717185);
        }
        
            System.Collections.Generic.LinkedListNode<T> val_8 = this.m_Rows.Last;
            System.Collections.Generic.LinkedListNode<T> val_9 = this.m_Rows.Previous;
            UnityEngine.Vector2 val_10 = GetAnchoredPositionInViewportSpace(rectInContent:  581467408);
            UnityEngine.Rect val_11 = rect;
            float val_12 = yMin;
            if(this.m_scrollRect.m_Viewport < 0)
        {
                UnityEngine.Vector2 val_13 = anchoredPosition;
            this.t_tempAnchoredPosition = new UnityEngine.Vector2();
            mem[1152921509483281772] = ???;
            System.Collections.Generic.LinkedListNode<T> val_14 = this.m_Rows.Last;
            this.m_Rows.RemoveLast();
            this.m_Rows.AddFirst(node:  this.m_Rows);
            val_13.x = val_11.m_Width + val_13.x;
            mem[1152921509483281772] = val_13.x;
            this.m_Rows.anchoredPosition = new UnityEngine.Vector2() {x = mem[this.t_tempAnchoredPosition + (0)], y = mem[this.t_tempAnchoredPosition + (4)]};
            val_17 = 22734940;
            this.UpdateCellValueAtRow(row:  mem[this.t_tempAnchoredPosition + (0)]);
        }
        
            val_16 = val_16 - 1;
        }
        while(this.m_Rows != 0);
        
        if(this.m_updateSiblingIndex == true)
        {
                this.m_updateSiblingIndex = this;
            this.UpdateSiblingIndex();
        }
    
    }
    private void UpdateAllRowToView()
    {
        var val_3;
        UnityEngine.Vector2 val_15;
        var val_16;
        System.Collections.Generic.LinkedList<UnityEngine.RectTransform> val_17;
        if(this.m_totalCell >= 1)
        {
                val_15 = this.t_tempAnchoredPosition;
            var val_15 = 0;
            val_16 = 22734940;
            do
        {
            System.Collections.Generic.LinkedListNode<T> val_1 = this.m_Rows.Next;
            UnityEngine.Vector2 val_2 = GetAnchoredPositionInViewportSpace(rectInContent:  581702288);
            var val_14 = val_3;
            val_14 = val_14 - S2;
            if(this.m_Rows > 0)
        {
                System.Collections.Generic.LinkedListNode<T> val_4 = this.m_Rows.Last;
            UnityEngine.Vector2 val_5 = anchoredPosition;
            val_17 = this.m_Rows;
            this.t_tempAnchoredPosition = new UnityEngine.Vector2();
            mem[1152921509483516652] = ???;
            if(val_17 != 0)
        {
            
        }
        else
        {
                val_17 = this.m_Rows;
            if(val_17 == 0)
        {
                val_17 = 0;
        }
        
        }
        
            val_17.RemoveFirst();
            this.m_Rows.AddLast(node:  R7);
            val_5.x = S2 - val_5.x;
            mem[1152921509483516652] = val_5.x;
            System.Collections.Generic.LinkedListNode<T> val_6 = this.m_Rows.Last;
            this.m_Rows.anchoredPosition = new UnityEngine.Vector2() {x = mem[this.t_tempAnchoredPosition + (0)], y = mem[this.t_tempAnchoredPosition + (4)]};
            val_16 = 22734940;
        }
        
            System.Collections.Generic.LinkedListNode<T> val_7 = this.m_Rows.Last;
            System.Collections.Generic.LinkedListNode<T> val_8 = this.m_Rows.Previous;
            UnityEngine.Vector2 val_9 = GetAnchoredPositionInViewportSpace(rectInContent:  581702288);
            UnityEngine.Rect val_10 = rect;
            float val_11 = yMin;
            if(this.m_scrollRect.m_Viewport < 0)
        {
                UnityEngine.Vector2 val_12 = anchoredPosition;
            this.t_tempAnchoredPosition = new UnityEngine.Vector2();
            mem[1152921509483516652] = ???;
            System.Collections.Generic.LinkedListNode<T> val_13 = this.m_Rows.Last;
            this.m_Rows.RemoveLast();
            this.m_Rows.AddFirst(node:  this.m_Rows);
            val_12.x = val_10.m_Width + val_12.x;
            mem[1152921509483516652] = val_12.x;
            this.m_Rows.anchoredPosition = new UnityEngine.Vector2() {x = mem[this.t_tempAnchoredPosition + (0)], y = mem[this.t_tempAnchoredPosition + (4)]};
            val_16 = 22734940;
        }
        
            val_15 = val_15 + 1;
        }
        while(val_15 < this.m_totalCell);
        
        }
        
        if(this.m_updateSiblingIndex == true)
        {
                this.m_updateSiblingIndex = this;
            this.UpdateSiblingIndex();
        }
        
        this.UpdateCellValueAllRow();
    }
    private void UpdateSiblingIndex()
    {
        var val_2;
        System.Collections.Generic.LinkedList<UnityEngine.RectTransform> val_4;
        val_4 = this.m_Rows;
        LinkedList.Enumerator<T> val_1 = 0.GetEnumerator();
        goto label_2;
        label_4:
        val_4 = val_2;
        val_4.SetSiblingIndex(index:  0);
        label_2:
        if(0.MoveNext() == true)
        {
            goto label_4;
        }
        
        0.Dispose();
    }
    private int GetRowIndex(UnityEngine.RectTransform row)
    {
        var val_2;
        var val_6;
        UnityEngine.Vector2 val_1 = anchoredPosition;
        float val_6 = -val_2;
        val_6 = val_6 - S2;
        val_6 = val_6 / S4;
        float val_3 = val_6 - (float)(int)val_6;
        if(row >= 0)
        {
                return (int)UnityEngine.Mathf.CeilToInt(f:  val_6 = (float)(int)val_6);
        }
        
        var val_7 = val_6;
        val_7 = val_7 ^ 2147483648;
        val_6 = 0 - (UnityEngine.Mathf.CeilToInt(f:  val_6 = (float)(int)val_6));
        return (int)UnityEngine.Mathf.CeilToInt(f:  val_6);
    }
    private void UpdateCellValueAtRow(UnityEngine.RectTransform row)
    {
        var val_10;
        var val_11;
        object val_12;
        var val_13;
        var val_14;
        var val_15;
        int val_2 = this.m_columnCount * (this.GetRowIndex(row:  row));
        System.Collections.IEnumerator val_3 = row.GetEnumerator();
        goto label_15;
        label_25:
        var val_11 = 0;
        val_11 = val_11 + 1;
        val_11 = row;
        val_12 = 0;
        if(row != 0)
        {
                if(null != 536892591)
        {
            
        }
        else
        {
                val_12 = row;
        }
        
        }
        
        if(val_2 >= 0)
        {
                if(val_2 < this.m_totalCell)
        {
            goto label_12;
        }
        
        }
        
        UnityEngine.GameObject val_5 = val_12.gameObject;
        val_12.SetActive(value:  false);
        goto label_15;
        label_12:
        UnityEngine.GameObject val_6 = val_12.gameObject;
        val_12.SetActive(value:  true);
        UnityEngine.GameObject val_7 = val_12.gameObject;
        this.m_SetCellValue.Invoke(arg0:  val_12, arg1:  val_2);
        val_2 = val_2 + 1;
        label_15:
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_10 = (uint)val_12 & 65535;
        val_13 = row;
        if(row != 0)
        {
            goto label_25;
        }
        
        val_14 = 22711796;
        if(row != 0)
        {
                val_14 = 0;
            val_14 = val_14 + 1;
            val_15 = row;
        }
        
        if(1 == 0)
        {
                return;
        }
        
        var val_10 = 1 - 1;
    }
    public void UpdateCellValueAllRow()
    {
        UnityEngine.RectTransform val_4;
        if(this.m_inited == false)
        {
                this.m_inited = this;
            this.Init();
        }
        
        float val_1 = this.m_scrollRect.verticalNormalizedPosition;
        if(this.m_scrollRect < 0)
        {
                this.m_scrollRect = this;
            this.DOVerticalNormalizedPos(endValue:  this.m_scrollRect, duration:  null);
        }
        
        LinkedList.Enumerator<T> val_2 = 0.GetEnumerator();
        label_4:
        if(0.MoveNext() == false)
        {
            goto label_3;
        }
        
        this.UpdateCellValueAtRow(row:  val_4);
        goto label_4;
        label_3:
        0.Dispose();
    }
    private void DOVerticalNormalizedPos(float endValue, float duration)
    {
        if(this.m_tweenerDOVerticalNormalizedPos != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.m_tweenerDOVerticalNormalizedPos, complete:  false);
        }
        
        DG.Tweening.Tweener val_1 = DG.Tweening.DOTweenModuleUI.DOVerticalNormalizedPos(target:  this.m_scrollRect, endValue:  endValue, duration:  duration, snapping:  false);
        this.m_tweenerDOVerticalNormalizedPos = this.m_scrollRect;
    }
    public void ScrollVerticalToCell(int cellIndex, float duration)
    {
        if(this.m_inited == false)
        {
                this.m_inited = this;
            this.Init();
        }
        
        float val_1 = S4 + S6;
        duration = S4 + duration;
        duration = duration - S2;
        bool val_3 = duration;
        val_3 = val_3 ^ 2147483648;
        DG.Tweening.Tweener val_2 = ScrollRectExtension.ScrollVerticalTo(scrollRect:  this.m_scrollRect, anchoredPositionY:  duration, duration:  null, scrollOutRange:  val_3);
    }
    public UnityEngine.UI.ScrollRect get_ScrollRectAttached()
    {
    
    }
    public void SetVerticalNormalizedPosition(float pos)
    {
        if(this.m_inited == false)
        {
                this.m_inited = this;
            this.Init();
        }
        
        this.m_scrollRect.verticalNormalizedPosition = pos;
        this.UpdateAllRowToView();
    }
    public ScrollViewAdapter()
    {
        this.m_columnCount = 6;
        this.m_cellSize = 1120403456;
        mem[1152921509484672056] = 1120403456;
        536877437 = new System.Collections.Generic.LinkedList<System.Net.WebOperation>();
        this.m_Rows = 536877437;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.m_rowSize = new UnityEngine.Vector2();
        mem[1152921509484672084] = ???;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        this.t_tempAnchoredPosition = new UnityEngine.Vector2();
        mem[1152921509484672108] = ???;
    }
    private void <Init>b__20_0(UnityEngine.Vector2 axis)
    {
        this.ScrollRect_OnValueChanged(axis:  new UnityEngine.Vector2() {x = axis.x, y = axis.y});
    }

}
