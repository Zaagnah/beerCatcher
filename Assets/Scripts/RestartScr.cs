using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScr : MonoBehaviour
{
    public void RestartSc()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
   
}
