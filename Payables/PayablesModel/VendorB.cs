using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayablesModel
{
    public partial class Vendor
    {
        public string SingleLineAddress
        {
            get
            {
                string s;
                s = Name + ", " + Address1 + ", ";
                if (Address2 != "")
                    s += Address2 + ",";
                s+= City +", " + State.StateName +
            }
        }
    }
}
