using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoding
{
    class Button
    {
        public delegate void ClickHandler(string message); // Delegate with dynamic input
        public event ClickHandler OnClick;

        public void Click(string message)
        {
            OnClick?.Invoke(message); // Trigger event with user input
        }
    }
}
