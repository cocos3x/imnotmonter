using UnityEngine;
public enum Point2DList.PolygonError
{
    // Fields
    None = 0
    ,NotEnoughVertices = 1
    ,NotConvex = 2
    ,NotSimple = 4
    ,AreaTooSmall = 8
    ,SidesTooCloseToParallel = 16
    ,TooThin = 32
    ,Degenerate = 64
    ,Unknown = 1073741824
    

}
