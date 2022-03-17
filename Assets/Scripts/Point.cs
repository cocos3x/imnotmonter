using UnityEngine;
[Serializable]
public class SVGPath.Point
{
    // Fields
    public UnityEngine.Vector2 point;
    public UnityEngine.Vector2 controlNext;
    public UnityEngine.Vector2 controlPrev;
    public Ferr.SVGPath.PointType type;
    
    // Methods
    public SVGPath.Point()
    {
    
    }

}
