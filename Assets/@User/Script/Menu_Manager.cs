using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Manager : MonoBehaviour 
{
    public AudioSource AudioButton;
    public GameObject menupanel;
    public GameObject pengertianpanel;
    public GameObject BantuanPanel;
    public GameObject InformasiPanel;

    // Use this for initialization
    void Start()
    {
        menupanel.SetActive(true);
        pengertianpanel.SetActive(false);
        BantuanPanel.SetActive(false);
        InformasiPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void play_btnClicked()
    {
        AudioButton.PlayOneShot(AudioButton.clip);
        Application.LoadLevel("VirusAR");
    }
    public void pengertianvirus_btnClicked()
    {
        AudioButton.PlayOneShot(AudioButton.clip);
        menupanel.SetActive(false);
        pengertianpanel.SetActive(true);
        BantuanPanel.SetActive(false);
        InformasiPanel.SetActive(false);
    }
    public void help_btnClicked()
    {
        AudioButton.PlayOneShot(AudioButton.clip);
        menupanel.SetActive(false);
        pengertianpanel.SetActive(false);
        BantuanPanel.SetActive(true);
        InformasiPanel.SetActive(false);
    }
    public void info_btnClicked()
    {
        AudioButton.PlayOneShot(AudioButton.clip);
        menupanel.SetActive(false);
        pengertianpanel.SetActive(false);
        BantuanPanel.SetActive(false);
        InformasiPanel.SetActive(true);
    }
    public void exit_btnClicked()
    {
        Application.Quit();
    }
    public void back_btnClicked()
    {
        AudioButton.PlayOneShot(AudioButton.clip);
        menupanel.SetActive(true);
        pengertianpanel.SetActive(false);
        BantuanPanel.SetActive(false);
        InformasiPanel.SetActive(false);
    }


}
