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
    public void Level1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void Level2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void TRestartTryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);
    }
    public void TRestartChooseLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -4);
    }
    public void TRestartMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -5);
    }
    public void L1RestartTryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    public void L1RestartChooseLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }
    public void L1RestartMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
    }
    public void L2RestartTryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    public void L2RestartChooseLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
    }
    public void L2RestartMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }
}
