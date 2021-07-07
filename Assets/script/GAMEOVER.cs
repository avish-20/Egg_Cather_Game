using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GAMEOVER : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameoverpanel;
    public GameObject gameplaypanel;
    public void GameEnd()
    {
       gameplaypanel.SetActive(false);
       gameoverpanel.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("main Scene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    
}
