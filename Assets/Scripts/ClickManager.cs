using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    private StoryManager storyManager;

    //Set Variables
    public GameObject[] rooms;
    public int roomIndex = 0;

    //Closet Variables
    public SpriteRenderer closetSprite;
    public bool closetClosed;
    public Sprite openCloset;

    //Piggie Variables
    public SpriteRenderer piggieSprite;
    private bool komoDressed;
    public List<Sprite> costumes;
    public int costumeIndex = 0;

    private void Start()
    {
        storyManager = GameObject.Find("Story Manager").GetComponent<StoryManager>();
    }

    public void roomRightClick()
    {
        Debug.Log("Move right");
        Debug.Log("Room amount: " + rooms.Length);
        if (roomIndex + 1 < rooms.Length + 1)
        {
            rooms[roomIndex].SetActive(false);
            rooms[roomIndex + 1].SetActive(true);
            roomIndex++;

            storyManager.UpdateStory(1);
        }
    }

    public void roomLeftClick()
    {
        Debug.Log("Move Left");
        if (roomIndex - 1 >= 0)
        {
            rooms[roomIndex].SetActive(false);
            rooms[roomIndex - 1].SetActive(true);
            roomIndex--;
        }
    }

    public void closetClick()
    {
        Debug.Log("Tapped Closet");
        if (closetClosed)
        {
            closetClosed = false;
            closetSprite.sprite = openCloset;
        }
        else if(!closetClosed)
        {
            if(!komoDressed)
            {
                piggieSprite.sprite = costumes[costumeIndex];
                komoDressed = true;
            }
            else if(komoDressed)
            {
                if (costumeIndex + 1 < costumes.Count)
                {
                    piggieSprite.sprite = costumes[costumeIndex + 1];
                }
                else
                {
                    costumeIndex = 0;
                    piggieSprite.sprite = costumes[costumeIndex];
                }
                costumeIndex++;
            }
        }
    }

    public void friendClick()
    {
        Debug.Log("Tapped Friend");
        if (komoDressed)
        {
            //Among Us costume
            if(costumeIndex == 0)
            {
                storyManager.UpdateStory(2);
            }
            //Banana Costume
            if (costumeIndex == 1)
            {
                storyManager.UpdateStory(0);
            }
            //Superhero Costume
            if (costumeIndex == 2)
            {
                storyManager.UpdateStory(3);
            }
            //Pig
            if (costumeIndex == 3)
            {
                storyManager.UpdateStory(0);
            }
        }
        else
        {
            storyManager.UpdateStory(0);
        }
    }

    public void piggieClick()
    {
        Debug.Log("Tapped Piggie");
    }

    public void tableClick()
    {
        Debug.Log("Tapped Table");
    }
}