using UnityEngine;

namespace Dmobin.FirebaseService
{
    [Serializable]
    public class RemoteParam
    {
        // Fields
        public Dmobin.FirebaseService.VariableType variableType;
        public string paramName;
        
        // Methods
        public string GetvariableType()
        {
            var val_1;
            if(this.variableType <= 6)
            {
                    val_1 = mem[22043232 + (this.variableType) << 2];
                val_1 = 22043232 + (this.variableType) << 2;
                return;
            }
            
            val_1 = 22776880;
        }
        public RemoteParam()
        {
        
        }
    
    }

}
