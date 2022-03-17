using UnityEngine;

namespace WrappingRopeLibrary.Events
{
    public class ObjectWrapEventArgs : CancelEventArgs
    {
        // Fields
        private readonly UnityEngine.Vector3[] _wrapPoints;
        private readonly UnityEngine.GameObject _target;
        
        // Properties
        public UnityEngine.Vector3[] WrapPoints { get; }
        public UnityEngine.GameObject Target { get; }
        
        // Methods
        public UnityEngine.Vector3[] get_WrapPoints()
        {
        
        }
        public UnityEngine.GameObject get_Target()
        {
        
        }
        public ObjectWrapEventArgs(UnityEngine.GameObject target, UnityEngine.Vector3[] wrapPoints)
        {
            this._target = target;
            this._wrapPoints = wrapPoints;
        }
    
    }

}
