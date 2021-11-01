using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCanvas
{
    class EventCource
    {

        public event EventHandler statusBarFilled;
        protected virtual void OnStatusBarFilled( EventArgs e)
        {

        }
    }
}
