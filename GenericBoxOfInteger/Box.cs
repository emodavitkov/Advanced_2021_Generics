using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfInteger
{
    public class Box<T>
    {
        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public override string ToString()
        {
            //Type valueType = Value.GetType();
            //string valueTypeFullname = valueType.FullName;
            //in this case valueTypeFullname == Value.GetType() 
            return $"{Value.GetType()}: {Value}"; 
        }
    }
}
