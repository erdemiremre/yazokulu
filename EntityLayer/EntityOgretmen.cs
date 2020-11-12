using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace EntityLayer
{
    class EntityOgretmen
    {
        private int ogrtid;
        private string ogrtad;
        private int ogrtbrans;

        public int OGRTID
        {
            get { return ogrtid; }
            set { ogrtid = value; }
        }
        public string OGRTAD
        {
            get { return ogrtad; }
            set { ogrtad = value; }

        }

        public int OGRTBRANS
        {
            get { return ogrtbrans; }
            set { ogrtbrans = value; }
        }
    }
}
