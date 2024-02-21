using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LocalRecyclers
{
    internal class Recycler : IComparable<Recycler>
    {
        public string ReName { get; set; }
        public string ReAddress { get; set; }
        public string RePhone { get; set; }
        public string ReWebsite { get; set; }
        public string ReType { get; set; }

        // public parameterised constructor method
        public Recycler (string reName, string reAddress, string rePhone, string reWebsite, string reType)
        {
            ReName = reName;
            ReAddress = reAddress;
            RePhone = rePhone;
            ReWebsite = reWebsite;
            ReType = reType;
        }

        // public ToString () method
        // use to display in the application
        public override string ToString()
        {
            string recyclerString = ReName + "\t" + ReAddress + "\t" + RePhone + "\t" + ReWebsite + "\t" + ReType;
            return recyclerString;
        }

        // returns a CSV string version of the recycler instance data
        // use to write to the external file for saving
        public string ToCSVString()
        {
            return ReName + "," + ReAddress + "," + RePhone + "," + ReWebsite + "," + ReType;
        }

        //used to sort
        public int CompareTo(Recycler other)
        {
            return this.ReName.CompareTo(other.ReName);
        }

    }
}
