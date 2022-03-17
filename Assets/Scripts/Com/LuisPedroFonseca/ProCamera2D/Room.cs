using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    [Serializable]
    public class Room
    {
        // Fields
        public string ID;
        public UnityEngine.Rect Dimensions;
        public float TransitionDuration;
        public Com.LuisPedroFonseca.ProCamera2D.EaseType TransitionEaseType;
        public bool ScaleCameraToFit;
        public bool Zoom;
        public float ZoomScale;
        public int InternalID;
        
        // Methods
        public Room(Com.LuisPedroFonseca.ProCamera2D.Room otherRoom)
        {
            this.ID = -1610612735;
            if(otherRoom != 0)
            {
                    this.TransitionDuration = otherRoom.TransitionDuration;
                this.TransitionEaseType = otherRoom.TransitionEaseType;
                this.ScaleCameraToFit = otherRoom.ScaleCameraToFit;
                this.Zoom = otherRoom.Zoom;
            }
            else
            {
                    this.TransitionDuration = 7.286752E-44f;
                this.TransitionEaseType = 22965384;
                this.ScaleCameraToFit = false;
                this.Zoom = false;
            }
            
            this.ZoomScale = otherRoom.ZoomScale;
        }
        public Room()
        {
            this.ID = -1610612735;
        }
    
    }

}
