using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MusicControl : MonoBehaviour
{
    public Slider slider;
    public GameObject musicPanel;
    public GameObject despritpionoption;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        musicPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = slider.value;
    }
    public void Despritpion()
    {
       despritpionoption.SetActive(true);

    }

    public void OpenMusicPanel()
    {
        musicPanel.SetActive(true);
     
    }

    public void CloseMusicPanel()
    {
        musicPanel.SetActive(false);
       
    }

    public void ReturnToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
