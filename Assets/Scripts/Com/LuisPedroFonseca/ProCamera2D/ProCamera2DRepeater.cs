using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DRepeater : BasePC2D, IPostMover
    {
        // Fields
        public static string ExtensionName;
        public UnityEngine.Transform ObjectToRepeat;
        public UnityEngine.Vector2 ObjectSize;
        public UnityEngine.Vector2 ObjectBottomLeft;
        public bool ObjectOnStage;
        public bool _repeatHorizontal;
        public bool _repeatVertical;
        public UnityEngine.Camera CameraToUse;
        private UnityEngine.Transform _cameraToUseTransform;
        private UnityEngine.Vector3 _objStartPosition;
        private System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.RepeatedObject> _allRepeatedObjects;
        private System.Collections.Generic.Queue<Com.LuisPedroFonseca.ProCamera2D.RepeatedObject> _inactiveRepeatedObjects;
        private Com.LuisPedroFonseca.ProCamera2D.IntPoint _prevStartIndex;
        private Com.LuisPedroFonseca.ProCamera2D.IntPoint _prevEndIndex;
        private System.Collections.Generic.Dictionary<Com.LuisPedroFonseca.ProCamera2D.IntPoint, bool> _occupiedIndices;
        private int _pmOrder;
        
        // Properties
        public bool RepeatHorizontal { get; set; }
        public bool RepeatVertical { get; set; }
        public int PMOrder { get; set; }
        
        // Methods
        public bool get_RepeatHorizontal()
        {
            return (bool)this._repeatHorizontal;
        }
        public void set_RepeatHorizontal(bool value)
        {
            this._repeatHorizontal = value;
            this.Refresh();
        }
        public bool get_RepeatVertical()
        {
            return (bool)this._repeatVertical;
        }
        public void set_RepeatVertical(bool value)
        {
            this._repeatVertical = value;
            this.Refresh();
        }
        protected override void Awake()
        {
            this.Awake();
            this.SetRepeatingObject(objectToRepeat:  this.ObjectToRepeat, isExistingObject:  this.ObjectOnStage);
            UnityEngine.Transform val_1 = this.CameraToUse.transform;
            this._cameraToUseTransform = this.CameraToUse;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.ProCamera2D;
            this.AddPostMover(mover:  1029374160);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if((UnityEngine.Object.op_Implicit(exists:  1029494352)) == false)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = R4.ProCamera2D;
            R4.RemovePostMover(mover:  R4);
        }
        public void PostMove(float deltaTime)
        {
            float val_4;
            float val_5;
            float val_6;
            if(this.enabled == false)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.ProCamera2D;
            UnityEngine.Vector3 val_3 = LocalPosition;
            float val_23 = val_4;
            float val_24 = val_5;
            val_23 = val_23 - this._objStartPosition;
            float val_25 = val_6;
            val_24 = val_24 - S8;
            val_25 = val_25 - S10;
            UnityEngine.Vector2 val_8 = Com.LuisPedroFonseca.ProCamera2D.Utils.GetScreenSizeInWorldCoords(gameCamera:  1029602464, distance:  SB.Invoke(arg:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25}));
            UnityEngine.Vector3 val_9 = position;
            float val_10 = this._cameraToUseTransform.Invoke(arg:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6});
            float val_11 = this._cameraToUseTransform.Invoke(arg:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6});
            UnityEngine.Vector3 val_26 = this._objStartPosition;
            UnityEngine.Vector2 val_27 = this.ObjectBottomLeft;
            UnityEngine.Vector2 val_28 = this.ObjectSize;
            val_26 = this._cameraToUseTransform - val_26;
            val_27 = val_26 - val_27;
            val_28 = val_27 / val_28;
            UnityEngine.Transform val_12 = this._cameraToUseTransform - S10;
            val_12 = (val_12 - this._objStartPosition) / val_12;
            Com.LuisPedroFonseca.ProCamera2D.IntPoint val_16 = new Com.LuisPedroFonseca.ProCamera2D.IntPoint(x:  UnityEngine.Mathf.FloorToInt(f:  val_12), y:  UnityEngine.Mathf.FloorToInt(f:  val_12));
            UnityEngine.Vector2 val_29 = this.ObjectSize;
            val_29 = val_4 / val_29;
            val_29 = val_5 / val_29;
            Com.LuisPedroFonseca.ProCamera2D.IntPoint val_19 = new Com.LuisPedroFonseca.ProCamera2D.IntPoint(x:  UnityEngine.Mathf.CeilToInt(f:  val_29), y:  UnityEngine.Mathf.CeilToInt(f:  val_29));
            int val_30 = val_19.X;
            int val_31 = val_16.Y;
            val_30 = val_30 + val_16.X;
            val_31 = val_19.Y + val_31;
            Com.LuisPedroFonseca.ProCamera2D.IntPoint val_20 = new Com.LuisPedroFonseca.ProCamera2D.IntPoint(x:  val_30, y:  val_31);
            if((val_16.X.Equals(other:  new Com.LuisPedroFonseca.ProCamera2D.IntPoint() {X = this._prevStartIndex, Y = val_31})) != false)
            {
                    if((val_20.X.Equals(other:  new Com.LuisPedroFonseca.ProCamera2D.IntPoint() {X = this._prevEndIndex, Y = val_31})) == true)
            {
                    return;
            }
            
            }
            
            this.FreeOutOfRangeObjects(startIndex:  new Com.LuisPedroFonseca.ProCamera2D.IntPoint() {X = val_16.X, Y = val_16.Y}, endIndex:  new Com.LuisPedroFonseca.ProCamera2D.IntPoint() {X = val_20.X, Y = val_20.Y});
            this.FillGrid(startIndex:  new Com.LuisPedroFonseca.ProCamera2D.IntPoint() {X = val_16.X, Y = val_16.Y}, endIndex:  new Com.LuisPedroFonseca.ProCamera2D.IntPoint() {X = val_20.X, Y = val_20.Y});
        }
        public int get_PMOrder()
        {
            return (int)this._pmOrder;
        }
        public void set_PMOrder(int value)
        {
            this._pmOrder = value;
        }
        public void SetRepeatingObject(UnityEngine.Transform objectToRepeat, bool isExistingObject)
        {
            float val_3;
            float val_4;
            float val_5;
            UnityEngine.Object val_15;
            System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.RepeatedObject> val_16;
            var val_17;
            this.ObjectToRepeat = objectToRepeat;
            if(this.ObjectToRepeat == 0)
            {
                    UnityEngine.Debug.LogWarning(message:  -1610605233);
                return;
            }
            
            UnityEngine.Vector3 val_2 = position;
            float val_6 = this.ObjectToRepeat.Invoke(arg:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_5});
            UnityEngine.Vector3 val_7 = position;
            float val_8 = val_3.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R5, z = R6});
            UnityEngine.Vector3 val_9 = position;
            float val_10 = val_3.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R5, z = R6});
            val_16 = this._allRepeatedObjects;
            mem[1152921509931797660] = this.ObjectToRepeat;
            mem[1152921509931797664] = val_3;
            mem[1152921509931797668] = val_3;
            if((val_16 == 0) || (val_3 < 1))
            {
                goto label_13;
            }
            
            val_17 = 0;
            goto label_14;
            label_22:
            if(val_3 <= val_17)
            {
                    var val_15 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_15 = val_15 + 0;
            UnityEngine.GameObject val_11 = (0 + 0) + 16 + 16.gameObject;
            val_15 = (0 + 0) + 16 + 16;
            UnityEngine.Object.Destroy(obj:  val_15);
            val_16 = val_16;
            val_17 = 1;
            label_14:
            if(val_17 < val_15)
            {
                goto label_22;
            }
            
            label_13:
            536878245 = new System.Collections.Generic.List<Page>();
            this._allRepeatedObjects = 536878245;
            536879323 = new System.Collections.Generic.Queue<CFNetwork.GetProxyData>();
            this._inactiveRepeatedObjects = 536879323;
            536874285 = new System.Collections.Generic.Dictionary<Com.LuisPedroFonseca.ProCamera2D.IntPoint, System.Boolean>();
            this._occupiedIndices = 536874285;
            if(isExistingObject == false)
            {
                    return;
            }
            
            this.InitCopy(newCopy:  this.ObjectToRepeat, positionOffscreen:  true);
        }
        private void FreeOutOfRangeObjects(Com.LuisPedroFonseca.ProCamera2D.IntPoint startIndex, Com.LuisPedroFonseca.ProCamera2D.IntPoint endIndex)
        {
            var val_2;
            var val_3;
            val_2 = 0;
            goto label_1;
            label_16:
            if(true <= val_2)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            if(((0 + 0) + 16 + 8) != (-2147483647))
            {
                    if((((0 + 0) + 16 + 8) < startIndex.X) || (((0 + 0) + 16 + 8) > endIndex.X))
            {
                goto label_9;
            }
            
            }
            
            if(((0 + 0) + 16 + 12) == (-2147483647))
            {
                goto label_10;
            }
            
            if(((0 + 0) + 16 + 12) >= startIndex.Y)
            {
                    if(((0 + 0) + 16 + 12) <= endIndex.Y)
            {
                goto label_10;
            }
            
            }
            
            label_9:
            bool val_1 = this._occupiedIndices.Remove(key:  new Com.LuisPedroFonseca.ProCamera2D.IntPoint() {X = mem[(0 + 0) + 16 + 8 + (0)], Y = mem[(0 + 0) + 16 + 8 + (4)]});
            this._inactiveRepeatedObjects.Enqueue(item:  (0 + 0) + 16);
            val_3 = 536889081;
            if(((mem[536889268] & true) == 0) && (mem[536889197] == 0))
            {
                    val_3 = 536889081;
            }
            
            this.PositionObject(obj:  (0 + 0) + 16, index:  new Com.LuisPedroFonseca.ProCamera2D.IntPoint() {X = mem[mem[536889173] + (0)], Y = mem[mem[536889173] + (4)]});
            label_10:
            val_2 = 1;
            label_1:
            if(val_2 < this)
            {
                goto label_16;
            }
        
        }
        private void FillGrid(Com.LuisPedroFonseca.ProCamera2D.IntPoint startIndex, Com.LuisPedroFonseca.ProCamera2D.IntPoint endIndex)
        {
            var val_6;
            int val_7;
            System.Collections.Generic.Dictionary<Com.LuisPedroFonseca.ProCamera2D.IntPoint, System.Boolean> val_8;
            int val_9;
            val_6 = 0;
            if(this._repeatHorizontal == false)
            {
                    endIndex.X = this._repeatHorizontal;
                val_7 = this._repeatHorizontal;
            }
            
            if(val_7 > endIndex.X)
            {
                    return;
            }
            
            if(this._repeatVertical == false)
            {
                    endIndex.Y = this._repeatVertical;
            }
            
            if(this._repeatVertical == false)
            {
                    startIndex.Y = this._repeatVertical;
            }
            
            do
            {
                if(startIndex.Y <= endIndex.Y)
            {
                    bool val_6 = startIndex.Y;
                do
            {
                Com.LuisPedroFonseca.ProCamera2D.IntPoint val_1 = new Com.LuisPedroFonseca.ProCamera2D.IntPoint(x:  val_7, y:  val_6);
                val_8 = this._occupiedIndices;
                val_9 = val_1.Y;
                bool val_3 = val_8.TryGetValue(key:  new Com.LuisPedroFonseca.ProCamera2D.IntPoint() {X = val_1.X, Y = val_9}, value: out  bool val_2 = true);
                if(val_3 != true)
            {
                    if(val_3 != true)
            {
                    DropdownItem val_4 = UnityEngine.Object.Instantiate<DropdownItem>(original:  this.ObjectToRepeat);
                this.InitCopy(newCopy:  this.ObjectToRepeat, positionOffscreen:  false);
                val_6 = 0;
            }
            
                val_8 = this._occupiedIndices;
                val_9 = val_1.Y;
                val_8.set_Item(key:  new Com.LuisPedroFonseca.ProCamera2D.IntPoint() {X = val_1.X, Y = val_9}, value:  true);
                Com.LuisPedroFonseca.ProCamera2D.RepeatedObject val_5 = this._inactiveRepeatedObjects.Dequeue();
                this.PositionObject(obj:  this._inactiveRepeatedObjects, index:  new Com.LuisPedroFonseca.ProCamera2D.IntPoint() {X = val_1.X, Y = val_1.Y});
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 <= endIndex.Y);
            
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 <= endIndex.X);
        
        }
        private void InitCopy(UnityEngine.Transform newCopy, bool positionOffscreen = True)
        {
            var val_3;
            var val_4;
            Com.LuisPedroFonseca.ProCamera2D.RepeatedObject val_1 = 536892849;
            val_1 = new Com.LuisPedroFonseca.ProCamera2D.RepeatedObject();
            if(val_1 != 0)
            {
                    val_3 = val_1;
                mem[536892865] = newCopy;
            }
            else
            {
                    val_3 = 16;
                mem[16] = newCopy;
            }
            
            UnityEngine.Transform val_2 = this.ObjectToRepeat.parent;
            val_3.parent = this.ObjectToRepeat;
            this._allRepeatedObjects.Add(item:  536892849);
            this._inactiveRepeatedObjects.Enqueue(item:  536892849);
            if(positionOffscreen == false)
            {
                    return;
            }
            
            val_4 = 536889081;
            if(((mem[536889268] & true) == 0) && (mem[536889197] == 0))
            {
                    val_4 = 536889081;
            }
            
            this.PositionObject(obj:  536892849, index:  new Com.LuisPedroFonseca.ProCamera2D.IntPoint() {X = mem[mem[536889173] + (0)], Y = mem[mem[536889173] + (4)]});
        }
        private void PositionObject(Com.LuisPedroFonseca.ProCamera2D.RepeatedObject obj, Com.LuisPedroFonseca.ProCamera2D.IntPoint index)
        {
            if(obj != 0)
            {
                    obj.GridPos = index;
                mem2[0] = index.Y;
            }
            else
            {
                    mem[8] = index.X;
                mem[12] = index.Y;
            }
            
            UnityEngine.Vector3 val_1 = Invoke(arg1:  (float)index.X, arg2:  null, arg3:  (float)index.Y);
            obj.Transform.position = new UnityEngine.Vector3() {x = R4, y = R5, z = R7};
        }
        private void Refresh()
        {
            if(((mem[536889268] & true) == 0) && (mem[536889197] == 0))
            {
                    536889081 = 536889081;
            }
            
            this.FreeOutOfRangeObjects(startIndex:  new Com.LuisPedroFonseca.ProCamera2D.IntPoint() {X = mem[mem[536889173] + (0)], Y = mem[mem[536889173] + (4)]}, endIndex:  new Com.LuisPedroFonseca.ProCamera2D.IntPoint() {X = mem[mem[536889173] + (0)], Y = mem[mem[536889173] + (4)]});
            this.FillGrid(startIndex:  new Com.LuisPedroFonseca.ProCamera2D.IntPoint() {X = mem[this._prevStartIndex + (0)], Y = mem[this._prevStartIndex + (4)]}, endIndex:  new Com.LuisPedroFonseca.ProCamera2D.IntPoint() {X = mem[this._prevStartIndex + (8)], Y = this});
        }
        public ProCamera2DRepeater()
        {
            this.ObjectSize = 1073741824;
            mem[1152921509932617092] = 1073741824;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.ObjectBottomLeft = new UnityEngine.Vector2();
            mem[1152921509932617100] = ???;
            this.ObjectOnStage = true;
            this._repeatHorizontal = true;
            this._repeatVertical = true;
            this._pmOrder = 2000;
        }
        private static ProCamera2DRepeater()
        {
            mem2[0] = -1610604949;
        }
    
    }

}
