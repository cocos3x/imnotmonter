using UnityEngine;

namespace Dmobin
{
    public static class ReflectionWrapper
    {
        // Methods
        public static System.Reflection.FieldInfo GetField(ref System.Type type, string name)
        {
            if(type != 0)
            {
                    return type.GetField(name:  name);
            }
            
            return type.GetField(name:  name);
        }
        public static System.Reflection.FieldInfo[] GetFields(ref System.Type type)
        {
            if(type != 0)
            {
                    return type.GetFields();
            }
            
            return type.GetFields();
        }
        public static bool IsClass(ref System.Type type)
        {
            if(type != 0)
            {
                    return type.IsClass;
            }
            
            return type.IsClass;
        }
        public static bool IsEnum(ref System.Type type)
        {
            if(type == 0)
            {
                
            }
        
        }
        public static bool IsValueType(ref System.Type type)
        {
            if(type != 0)
            {
                    return type.IsValueType;
            }
            
            return type.IsValueType;
        }
        public static System.Type GetBaseType(ref System.Type type)
        {
            if(type == 0)
            {
                
            }
        
        }
        public static System.Reflection.MemberInfo[] GetMembers(ref System.Type type)
        {
            if(type != 0)
            {
                    return type.GetMembers();
            }
            
            return type.GetMembers();
        }
        public static bool IsAssignableFrom(ref System.Type current, ref System.Type toCompare)
        {
            if(current == 0)
            {
                
            }
        
        }
    
    }

}
