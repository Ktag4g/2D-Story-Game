using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // Update is called once per frame
    void Update()
    {
        
    }
}
