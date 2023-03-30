using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
 public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
 public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void Tutorial()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void RestartTryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
    public void RestartChooseLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
    }
    public void RestartMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);
    }
}
