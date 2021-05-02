using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.CukCuk.Core.AttributeCustom
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RequiredField:Attribute
    {
        public string MsgError = string.Empty;
        public RequiredField(string msgError = "")
        {
            MsgError = msgError;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class EmailField : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class PhoneNumberField : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class MaxLengthField : Attribute
    {
        public int MaxLength = 20;
        public string MsgError = string.Empty;
        //public MaxLengthField(int _maxLength = 0, string msg = "")
        //{
        //    MaxLength = _maxLength;
        //    MsgError = msg;
        //}
    }

}
