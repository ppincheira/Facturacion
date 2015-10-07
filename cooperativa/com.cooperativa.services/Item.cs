using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace com.cooperativa.services
{
    public class Item
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Item(string name, int value)
        {
            Name = name;
            Value = value;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
