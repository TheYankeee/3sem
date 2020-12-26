using System;
using System.Collections.Generic;
using System.Text;

namespace Sem3.lab06
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class MyAttribute : Attribute
    {
        public MyAttribute() { }
        public MyAttribute(string NewDesc)
        {
            Desc = NewDesc;
        }

        public string Desc { get; set; }
    }

}
