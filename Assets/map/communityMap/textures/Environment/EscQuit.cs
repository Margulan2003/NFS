using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsqQuit : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Bye!");
            Application.Quit();
        }
    }
}
