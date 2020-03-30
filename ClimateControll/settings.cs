using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;


namespace ClimateControll
{
    [FirestoreData]

    internal class settings
    {
        [FirestoreProperty]
        public string WhenString { get; set; }
    }
}
