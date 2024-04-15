using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject despritpionoption;
    public void StartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Choose");
    }
    public void Despritpion()
    {
       despritpionoption.SetActive(true);
    }
    public void LoadToOne()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("One");
    }
    public void LoadToTwo()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Two");
    }
    public void LoadToThree()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Three");
    }
    public void LoadToFour()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Four");
    }
    public void QuitGame()
    {
       #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; 
        #else
            Application.Quit(); 
        #endif
    }
    public void BackMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Choose");
    }
}
