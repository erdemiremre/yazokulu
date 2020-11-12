using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class EntityBasvuruForm
    {
        private int basvuruid;
        private int basdersid;
        private int basogrid;

        public int BASVURUID
        {
            get { return basvuruid; }
            set { basvuruid = value; }
        }

        public int BASDERSID
        {
            get { return basdersid; }
            set { basdersid = value; }
        }

        public int BASOGRID
        {
            get { return basogrid; }
            set { basogrid = value; }
        }
    }
}
