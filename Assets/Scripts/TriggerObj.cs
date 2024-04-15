using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObj : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("123");
            GameVictory.instance.currentNum += 1;
            Destroy(this.gameObject);
           
        }
    }
}
