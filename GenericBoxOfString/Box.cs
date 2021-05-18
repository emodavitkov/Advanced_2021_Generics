using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T>
    {

        public Box(T value)
        {
            this.Value = value;

        }
        public T Value { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .Append($"{Value.GetType()}")
                .Append($": {Value}");

            return sb.ToString().TrimEnd();

            //return $"{Value.GetType()} : {Value}";
        }


    }
}
