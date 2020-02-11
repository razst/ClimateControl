using Google.Cloud.Firestore;

namespace ClimateControll
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