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
        public string mailAdress { get; set; }
        [FirestoreProperty]
        public string port { get; set; }

        [FirestoreProperty]
        public int maxHum { get; set; }

        [FirestoreProperty]
        public int maxTemp { get; set; }

        [FirestoreProperty]
        public int minHum { get; set; }

        [FirestoreProperty]
        public int minTemp { get; set; }

        [FirestoreProperty]
        public int ranMaxHum { get; set; }

        [FirestoreProperty]
        public int ranMaxTemp { get; set; }
        [FirestoreProperty]
        public int ranMinHum { get; set; }

        [FirestoreProperty]
        public int ranMinTemp { get; set; }

        [FirestoreProperty]
        public bool sendMail { get; set; }

        [FirestoreProperty]
        public bool testMode { get; set; }

        [FirestoreProperty]
        public bool turnOnAlert { get; set; }

        [FirestoreProperty]
        public int updateDB { get; set; }


    }
}
