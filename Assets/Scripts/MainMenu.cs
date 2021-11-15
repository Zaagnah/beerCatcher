using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void LoadFirstLevel()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0; // loop back to start
        }
        SceneManager.LoadScene(nextSceneIndex);
    }
    

    
    
    public void LoadLvl2()
    {
        SceneManager.LoadScene("2_level");
    }public void LoadLvl3()
    {
        SceneManager.LoadScene("3_level");
    }public void LoadLvl4()
    {
        SceneManager.LoadScene("4_level");
    }public void LoadLvl5()
    {
        SceneManager.LoadScene("5_level");
    }public void LoadLvl6()
    {
        SceneManager.LoadScene("6_level");
    }
    public void CloseGame()
    {
        Application.Quit();
    }
    public void MainMenuOpen()
    {
        SceneManager.LoadScene("Menu");
    }

}
