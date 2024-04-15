using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    public Text time;
    public float jishi;
    public GameObject defeatPanel;
    public int index;
    private bool isEnd;
    // Start is called before the first frame update
    void Start()
    {
        isEnd = false;
        defeatPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        jishi -= 1*Time.deltaTime;
        time.text = jishi.ToString("f0");
        if(jishi<=0&&isEnd==false)
        {
            isEnd = true;
            Debug.Log("GameOver");
            defeatPanel.SetActive(true);
            Time.timeScale = 0;
        }

    }

    public void ReStart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(index);
    }
}
