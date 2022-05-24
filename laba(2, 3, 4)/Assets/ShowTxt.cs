using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTxt : MonoBehaviour
{
    
    public GameObject item1;
    public string playerTag;

    void Start()
    {
        item1.SetActive(false);
    }
    void OnTriggerStay(Collider collision)
    {
        Debug.Log("!!!");
        item1.SetActive(true);
    }
    void OnTriggerExit(Collider collision)
    {
        Debug.Log("!!!");
        item1.SetActive(false);
    }
}
