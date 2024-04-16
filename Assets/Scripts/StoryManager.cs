using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StoryManager : MonoBehaviour
{
    //Story Variables
    public TextMeshPro storyText;
    public bool inStory;
    public List<string> story;
    public List<bool> isKomo;
    public int index = 0;

    //Text Variables
    public Color komoColor;
    public Color steveColor;

    public GameObject gameUI;

    // Start is called before the first frame update
    void Start()
    {
        inStory = true;
        storyText.text = story[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (inStory)
        {
            gameUI.SetActive(false);
            if (Input.GetMouseButtonUp(0))
            {
                nextLine();
            }
        }
        else if (!inStory)
        {
            gameUI.SetActive(true);
        }
    }

    void nextLine()
    {
        if (index + 1 < story.Count)
        {
            storyText.text = story[index + 1];
            if (isKomo[index + 1])
            {
                storyText.color = komoColor;
                storyText.alignment = TextAlignmentOptions.Left;
            }
            else
            {
                storyText.color = steveColor;
                storyText.alignment = TextAlignmentOptions.Right;
            }
            index++;
        }
        else
        {
            storyText.text = "";
            inStory = false;
        }
    }

    public void UpdateStory(int storyPart)
    {
        story.Clear();
        isKomo.Clear();

        if (storyPart == 0)
        {
            story.Add("I said I don't want to talk...");
            isKomo.Add(false);
        }
        else if (storyPart == 1)
        {
            story.Add("I got it!");
            isKomo.Add(true);

            story.Add("I'll put on a costume!");
            isKomo.Add(true);
        }
        //Among us Costume
        else if (storyPart == 2)
        {
            story.Add("Where did Komo go?");
            isKomo.Add(false);

            story.Add("AMONGUS!!!");
            isKomo.Add(true);

            story.Add("...What are you doing?");
            isKomo.Add(false);

            story.Add("Just thought a bit of roleplay might cheer you up!");
            isKomo.Add(true);

            story.Add("Ehh...A little overplayed, but thanks. Maybe we should get outta the house for a bit.");
            isKomo.Add(false);

            story.Add("Sweet! Let's get our things!");
            isKomo.Add(true);
        }
        //Superhero Costume
        else if (storyPart == 3)
        {
            story.Add("Woah! What's with the outfit?");
            isKomo.Add(false);

            story.Add("I am Dragon-Man! The most powerful hero to ever live!");
            isKomo.Add(true);

            story.Add("pffffttt.");
            isKomo.Add(false);

            story.Add("Did that help?");
            isKomo.Add(true);

            story.Add("A little, but maybe we should get out.");
            isKomo.Add(false);

            story.Add("Alright! Let's go!");
            isKomo.Add(true);
        }

        inStory = true;
        storyText.text = story[0];
        index = -1;
    }
}
