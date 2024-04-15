using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameVictory : MonoBehaviour
{
    public static GameVictory instance;

    public int targetNum;
    public GameObject vicPanel;
    public int currentNum;

    private bool isVic;

    private void Awake()
    {
        if(instance!=null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        vicPanel.SetActive(false);
        isVic = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isVic==false&&currentNum>=targetNum)
        {
            isVic = true;
            Debug.Log("Victory");
            vicPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
