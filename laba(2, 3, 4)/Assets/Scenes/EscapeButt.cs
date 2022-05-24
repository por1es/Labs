using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeButt : MonoBehaviour
{
    public int scenenumber;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            SceneManager.LoadScene(scenenumber);
        }
    }
}
