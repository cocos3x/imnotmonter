using UnityEngine;

namespace Ferr
{
    public class InspectorName : PropertyAttribute
    {
        // Fields
        public string mName;
        
        // Methods
        public InspectorName(string aName)
        {
            this.mName = aName;
        }
    
    }

}
