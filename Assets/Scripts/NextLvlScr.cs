using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLvlScr : PlayerMoveLvl
{
    public GameObject obj;

    // Update is called once per frame
    public void WilLvl()
    {
        if(scoreValuer == 15)
        {
            WinLvl();
        }
    }
    void WinLvl()
    {
        StartCoroutine(NextLevel());
    }

    IEnumerator NextLevel()
    {
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        yield return new WaitForSeconds(1f / slowness);
        Destroy(gameObject);
        obj.SetActive(true);
        Invoke("TimeSca", 1f);
    }
    public void TimeSca()
    {
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;
    }

    public void NextLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
