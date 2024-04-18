using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public StoryManager storyManager;

    public GameObject gameUI;

    // Start is called before the first frame update
    void Start()
    {
        if (storyManager.inStory)
        {
            gameUI.SetActive(false);
        }
        else if (!storyManager.inStory)
        {
            Debug.Log("Trigger");
            gameUI.SetActive(true);
        }
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        #if UNITY_STANDALONE
        Application.Quit();
        #endif
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
