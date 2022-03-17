using UnityEngine;

namespace Ferr
{
    public interface IBlendPaintType
    {
        // Properties
        public abstract UnityEngine.Color Color { get; set; }
        public abstract float Size { get; set; }
        public abstract float Strength { get; set; }
        public abstract float Falloff { get; set; }
        public abstract bool Backfaces { get; set; }
        public abstract UnityEngine.Texture2D Cursor { get; }
        public abstract UnityEngine.Vector2 CursorHotspot { get; }
        public abstract bool ShowColorSettings { get; }
        public abstract bool ShowBrushSettings { get; }
        public abstract string Name { get; }
        
        // Methods
        public abstract UnityEngine.Color get_Color(); // 0
        public abstract void set_Color(UnityEngine.Color value); // 0
        public abstract float get_Size(); // 0
        public abstract void set_Size(float value); // 0
        public abstract float get_Strength(); // 0
        public abstract void set_Strength(float value); // 0
        public abstract float get_Falloff(); // 0
        public abstract void set_Falloff(float value); // 0
        public abstract bool get_Backfaces(); // 0
        public abstract void set_Backfaces(bool value); // 0
        public abstract UnityEngine.Texture2D get_Cursor(); // 0
        public abstract UnityEngine.Vector2 get_CursorHotspot(); // 0
        public abstract bool get_ShowColorSettings(); // 0
        public abstract bool get_ShowBrushSettings(); // 0
        public abstract string get_Name(); // 0
        public abstract void PaintObjectsBegin(System.Collections.Generic.List<UnityEngine.GameObject> aObjects, UnityEngine.RaycastHit aHit, System.Nullable<UnityEngine.RaycastHit> aPreviousHit); // 0
        public abstract void PaintObjects(System.Collections.Generic.List<UnityEngine.GameObject> aObjects, UnityEngine.RaycastHit aHit, System.Nullable<UnityEngine.RaycastHit> aPreviousHit); // 0
        public abstract void PaintObjectsEnd(System.Collections.Generic.List<UnityEngine.GameObject> aObjects, UnityEngine.RaycastHit aHit, System.Nullable<UnityEngine.RaycastHit> aPreviousHit); // 0
        public abstract void PaintBegin(UnityEngine.GameObject aObject, UnityEngine.RaycastHit aHit, System.Nullable<UnityEngine.RaycastHit> aPreviousHit); // 0
        public abstract void Paint(UnityEngine.GameObject aObject, UnityEngine.RaycastHit aHit, System.Nullable<UnityEngine.RaycastHit> aPreviousHit); // 0
        public abstract void PaintEnd(UnityEngine.GameObject aObject, UnityEngine.RaycastHit aHit, System.Nullable<UnityEngine.RaycastHit> aPreviousHit); // 0
        public abstract float GetPointInfluence(UnityEngine.Vector3 aObjScale, UnityEngine.Vector3 aHitPt, UnityEngine.Vector3 aHitDirection, UnityEngine.Vector3 aVert, UnityEngine.Vector3 aVertNormal); // 0
        public abstract void RenderScenePreview(UnityEngine.Camera aSceneCamera, UnityEngine.RaycastHit aHit, System.Collections.Generic.List<UnityEngine.GameObject> aObjects); // 0
        public abstract void RenderScenePreview(UnityEngine.Camera aSceneCamera, UnityEngine.RaycastHit aHit, UnityEngine.GameObject aObject); // 0
        public abstract int CheckPriority(UnityEngine.GameObject aOfObject); // 0
        public abstract void OnSelect(System.Collections.Generic.List<UnityEngine.GameObject> aObjects); // 0
        public abstract void OnUnselect(System.Collections.Generic.List<UnityEngine.GameObject> aObjects); // 0
        public abstract void DrawToolGUI(); // 0
        public abstract bool GUIInput(); // 0
    
    }

}
