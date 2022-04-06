using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour {
    public AudioSource AudioButton;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void back_btnClicked()
    {
        AudioButton.PlayOneShot(AudioButton.clip);
        Application.LoadLevel("mainmenu");
    }
}
