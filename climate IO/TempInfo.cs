using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace climate_IO
{
    [FirestoreData]

    internal class TempInfo
    {
        [FirestoreProperty]
        public string WhenString { get; set; }
        [FirestoreProperty]
        public long WhenUNIX { get; set; }
        [FirestoreProperty]
        public float Temperature { get; set; }
        [FirestoreProperty]
        public float Humidity { get; set; }
    }
}