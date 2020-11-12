using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class EntityDers
    {
        private string dersad;
        private int Min;
        private int max;
        private int id;
        public string DERSAD
        {
            get { return dersad; }
            set { dersad = value; }
        }

        public int MIN
        {
            get { return Min; }
            set { Min = value; }
        }

        public int MAX
        {
            get { return max; }
            set { max = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
