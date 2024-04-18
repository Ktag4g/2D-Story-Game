using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickDetect : MonoBehaviour
{
    private ClickManager clickManager;
    private StoryManager storyManager;

    private void Start()
    {
        clickManager = GameObject.Find("Click Manager").GetComponent<ClickManager>();
        storyManager = GameObject.Find("Story Manager").GetComponent<StoryManager>();
    }

    private void OnMouseDown()
    {
        if (!storyManager.inStory)
        {
            if (gameObject.tag == "RoomRight")
            {
                clickManager.roomRightClick();
            }

            if (gameObject.tag == "RoomLeft")
            {
                clickManager.roomLeftClick();
            }

            if (gameObject.tag == "Closet")
            {
                clickManager.closetClick();
            }

            if (gameObject.tag == "Friend")
            {
                clickManager.friendClick();
            }
        }
    }
}
