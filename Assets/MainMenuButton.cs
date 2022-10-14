using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuButton : MonoBehaviour
{
    public bool isstart;
    public bool isquit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonChoice()
    {
        if (isstart)
        {
            SceneManager.LoadScene("MainScene");

            Scene gamesuper = SceneManager.GetSceneByName("MainScene");
            SceneManager.SetActiveScene(gamesuper);
            SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        }
        if (isquit)
        {
            Application.Quit();

        }
    }
}
