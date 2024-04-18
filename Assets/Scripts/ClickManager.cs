using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    private StoryManager storyManager;

    //Set Variables
    public GameObject[] rooms;
    public int roomIndex = 0;

        //Act 2 Sets
    public GameObject forest;
    public GameObject carnival;
    public GameObject arcade;
    public GameObject mall;

        //Act 3 Sets
    public GameObject bakery;
    public GameObject shake;
    public GameObject pizza;
    public GameObject mexican;

    //Closet Variables
    public SpriteRenderer closetSprite;
    public bool closetClosed;
    public Sprite openCloset;

    //Piggie Variables
    public SpriteRenderer piggieSprite;
    public Sprite komo;
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
                storyManager.UpdateStory(5);
            }
            //Superhero Costume
            if (costumeIndex == 2)
            {
                storyManager.UpdateStory(3);
            }
            //Piggie Costume
            if (costumeIndex == 3)
            {
                storyManager.UpdateStory(4);
            }
        }
        else
        {
            storyManager.UpdateStory(0);
        }
    }

    public void setForest()
    {
        piggieSprite.sprite = komo;
        rooms[roomIndex].SetActive(false);
        storyManager.Act2Buttons.SetActive(false);
        forest.SetActive(true);
        storyManager.UpdateStory(10);
    }
    public void setCarnival()
    {
        piggieSprite.sprite = komo;
        rooms[roomIndex].SetActive(false);
        storyManager.Act2Buttons.SetActive(false);
        carnival.SetActive(true);
        storyManager.UpdateStory(8);
    }
    public void setArcade()
    {
        piggieSprite.sprite = komo;
        rooms[roomIndex].SetActive(false);
        storyManager.Act2Buttons.SetActive(false);
        arcade.SetActive(true);
        storyManager.UpdateStory(9);
    }
    public void setMall()
    {
        piggieSprite.sprite = komo;
        rooms[roomIndex].SetActive(false);
        storyManager.Act2Buttons.SetActive(false);
        mall.SetActive(true);
        storyManager.UpdateStory(11);
    }

    public void setBakery()
    {
        forest.SetActive(false);
        carnival.SetActive(false);
        arcade.SetActive(false);
        mall.SetActive(false);

        storyManager.Act3Buttons.SetActive(false);
        bakery.SetActive(true);
        storyManager.UpdateStory(17);
    }
    public void setShake()
    {
        forest.SetActive(false);
        carnival.SetActive(false);
        arcade.SetActive(false);
        mall.SetActive(false);

        storyManager.Act3Buttons.SetActive(false);
        shake.SetActive(true);
        storyManager.UpdateStory(16);
    }
    public void setPizza()
    {
        forest.SetActive(false);
        carnival.SetActive(false);
        arcade.SetActive(false);
        mall.SetActive(false);

        storyManager.Act3Buttons.SetActive(false);
        pizza.SetActive(true);
        storyManager.UpdateStory(14);
    }
    public void setMexican()
    {
        forest.SetActive(false);
        carnival.SetActive(false);
        arcade.SetActive(false);
        mall.SetActive(false);

        storyManager.Act3Buttons.SetActive(false);
        mexican.SetActive(true);
        storyManager.UpdateStory(15);
    }
}