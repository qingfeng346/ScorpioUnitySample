using System.Reflection;
using Scorpio.Exception;
using System;
namespace Scorpio.Userdata {
    public class UserdataProperty : UserdataVariable {
        private Type m_Type;
        private PropertyInfo m_Property;
        public UserdataProperty(Type type, PropertyInfo info) {
            m_Type = type;
            m_Property = info;
            FieldType = info.PropertyType;
        }
        public override object GetValue(object obj) {
            if (m_Property.CanRead)
                return m_Property.GetValue(obj, null);
            throw new ExecutionException($"Type:[{m_Type.FullName}]  Property:[{m_Property.Name}] 不支持 GetValue");
        }
        public override void SetValue(object obj, object val) {
            if (m_Property.CanWrite)
                m_Property.SetValue(obj, val, null);
            else
                throw new ExecutionException($"Type:[{m_Type.FullName}]  Property:[{m_Property.Name}] 不支持 SetValue");
        }
    }
}
