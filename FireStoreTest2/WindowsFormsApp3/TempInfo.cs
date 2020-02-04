using Google.Cloud.Firestore;

namespace WindowsFormsApp3
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
        public int Humidity { get; set; }

    }
}