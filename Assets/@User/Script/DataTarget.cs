using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Vuforia
{
    public class DataTarget: MonoBehaviour
    {

        
        public Transform TextDescription;
        public Transform ButtonAction;
        public Transform PanelDescription;

        public AudioSource soundTarget;
        public AudioClip clipTarget;

        // Use this for initialization
        void Start()
        {
            //add Audio Source as new game object component
            soundTarget = (AudioSource)gameObject.AddComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

            foreach (TrackableBehaviour tb in tbs)
            {
                string name = tb.TrackableName;
                ImageTarget it = tb.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);

                //Evertime the target found it will show “name of target” on the TextTargetName. Button, Description and Panel will visible (active)

               
                ButtonAction.gameObject.SetActive(true);
                TextDescription.gameObject.SetActive(true);
                PanelDescription.gameObject.SetActive(true);


                //Apabila Object IPhone dimunculkan maka akan memunculkan deskripsi IPhone.

                if (name == "CoronaMarker")
                {
                    TextDescription.GetComponent<Text>().text = "Coronavirus ialah Coronavirus merupakan keluarga besar virus yang menyebabkan penyakit pada manusia dan hewan. " +
                        "Pada manusia biasanya menyebabkan penyakit infeksi saluran pernapasan, mulai flu biasa hingga penyakit yang serius seperti Middle East Respiratory Syndrome (MERS) " +
                        "dan Sindrom Pernafasan Akut Berat/ Severe Acute Respiratory Syndrome (SARS). ";
                }



                // Apabila Object Laptop Acer dimunculkan maka akan memunculkan deskripsi Laptop Acer.

                if (name == "DengueMarker")
                {
                    TextDescription.GetComponent<Text>().text = "Virus Dengue Penyakit virus yang dibawa oleh nyamuk, yang terjadi di daerah tropis dan subtropis. " +
                        "Orang yang terinfeksi virus ini untuk kedua kalinya memiliki risiko yang jauh lebih besar terserang penyakit parah. " +
                        "Gejalanya adalah demam, ruam, serta nyeri otot dan sendi.Pada kasus yang parah terjadi pendarahan hebat dan syok, yang dapat membahayakan nyawa.";
                }
                if (name == "EbolaMarker")
                {
                    TextDescription.GetComponent<Text>().text = "Virus Ebola adalah penyakit pada manusia yang disebabkan oleh virus Ebola. " +
                        "Masa inkubasi biasanya dimulai dua hari hingga tiga minggu setelah terjangkit virus, dengan adanya demam, sakit tenggorokan, nyeri otot, dan sakit kepala. " +
                        "Gejala ini biasanya diikuti dengan mual, muntah, dan diare, serta menurunnya fungsi liver dan ginjal. Pada kondisi tersebut, orang yang terpapar virus Ebola mulai mengalami masalah pendarahan.";
                }
            }
        }
    }
}
        
        
     