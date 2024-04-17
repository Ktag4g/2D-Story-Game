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
        //Piggy Costume
        else if (storyPart == 4)
        {
            story.Add("I got a surprise in our room.");
            isKomo.Add(true);

            story.Add("Ok, what's going on here?");
            isKomo.Add(false);

            story.Add("Heya there!");
            isKomo.Add(true);

            story.Add("What's with that costume? I need to get-");
            isKomo.Add(false);

            story.Add("Wanna dance? It'll be fun!");
            isKomo.Add(true);

            story.Add("Fine.");
            isKomo.Add(false);

            story.Add("Get your frustrations outta your system?");
            isKomo.Add(true);

            story.Add("A little. I think getting away might help.");
            isKomo.Add(false);

            story.Add("Sure.");
            isKomo.Add(true);
        }
        //Banana Costume
        else if (storyPart == 5)
        {
            story.Add("I wanna show you something.");
            isKomo.Add(true);

            story.Add("Alright then.");
            isKomo.Add(false);

            story.Add("Sup with the outfit?");
            isKomo.Add(false);

            story.Add("I'm a banana! Peanut butter jelly time!");
            isKomo.Add(true);

            story.Add("Not interested. Sorry.");
            isKomo.Add(false);

            story.Add("Aw man. And I was hoping to ease your saddness.");
            isKomo.Add(true);

            story.Add("That obvious, huh? Well, I might be open to a romp outside.");
            isKomo.Add(false);

            story.Add("Then come on!");
            isKomo.Add(true);
        }
        //Act 2 Begin
        else if (storyPart == 6) 
        {
            story.Add("Is there anywhere in particular you wanna go?");
            isKomo.Add(true);

            story.Add("Let me think...");
            isKomo.Add(false); 
        }
        // Decision made
        else if (storyPart == 7)
        {
            story.Add("Let's go here.");
            isKomo.Add(false);

            story.Add("Sure!");
            isKomo.Add(true);
        }

        inStory = true;
        storyText.text = story[0];
        index = -1;
    }
}
