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
        //Decision made - Act 2
        else if (storyPart == 7)
        {
            story.Add("Let's go here.");
            isKomo.Add(false);

            story.Add("Sure!");
            isKomo.Add(true);
        }
        //Amusement Park
        else if (storyPart == 8)
        {
            story.Add("Which ride do you wanna get on first?");
            isKomo.Add(true);

            story.Add("I dunno. maybe...the merry-go-round?");
            isKomo.Add(false);

            story.Add("We can do the merry-go-round.");
            isKomo.Add(true);

            story.Add("So? How was it?");
            isKomo.Add(true);

            story.Add("Eh, gonna need another ride.");
            isKomo.Add(false);

            story.Add("Sure!");
            isKomo.Add(true);

            story.Add("Okay. Let's try your idea then.");
            isKomo.Add(false);

            story.Add("Wooo! Now how was that?");
            isKomo.Add(true);

            story.Add("*pant* *pant*" + "Tense. but fun. now I'm hungry.");
            isKomo.Add(false);
        }
        //Arcade
        else if (storyPart == 9)
        {
            story.Add("Anything you wanna do first?");
            isKomo.Add(true);

            story.Add("Let's try out some skee ball to get started.");
            isKomo.Add(false);

            story.Add("Sure! But I'm pretty good, ya know?");
            isKomo.Add(true);

            story.Add("Last time we played, not so much.");
            isKomo.Add(false);

            story.Add("I-er...Let's just play.");
            isKomo.Add(true);

            story.Add("Haha! I win!");
            isKomo.Add(true);

            story.Add("Okay, you finally won. That's 1-5 though.");
            isKomo.Add(false);

            story.Add("Aaargh! Basketball next?");
            isKomo.Add(true);

            story.Add("You're on.");
            isKomo.Add(false);

            story.Add("Aww.");
            isKomo.Add(true);

            story.Add("Heh, I'm starting to have fun. Thanks.");
            isKomo.Add(false);

            story.Add("You're welcome. But now I'm hungry.");
            isKomo.Add(true);

            story.Add("Let's grab a bite.");
            isKomo.Add(false);
        }
        //Forest Trail
        else if (storyPart == 10)
        {
            story.Add("Wanted to do something relaxing.");
            isKomo.Add(false);

            story.Add("Okay, I like this.");
            isKomo.Add(true);

            story.Add("Huh, what's that?");
            isKomo.Add(false);

            story.Add("Look at that view!");
            isKomo.Add(true);

            story.Add("Woah. It's beautiful.");
            isKomo.Add(false);

            story.Add("Yes. Let's grab a seat.");
            isKomo.Add(true);

            story.Add("That was nice. Now, let's get outta here. I'm starving.");
            isKomo.Add(false);

            story.Add("I couldn't agree more.");
            isKomo.Add(true);
        }
        //Mall
        else if (storyPart == 11)
        {
            story.Add("Okay, we're here.");
            isKomo.Add(true);

            story.Add("I wanna get some comics.");
            isKomo.Add(false);

            story.Add("Okay, let's go!");
            isKomo.Add(true);

            story.Add("Wait. It says here that the comics are sold out. Well that was a bust.");
            isKomo.Add(false);

            story.Add("Sorry, buddy. I wish I knew beforehand that they were sold out.");
            isKomo.Add(true);

            story.Add("It's not your fault.");
            isKomo.Add(false);

            story.Add("Wanna do something else?");
            isKomo.Add(true);

            story.Add("Let's head for the sneakers stores.");
            isKomo.Add(false);

            story.Add("You want anything?");
            isKomo.Add(true);

            story.Add("There's a new set I want that supports a good cause.");
            isKomo.Add(false);

            story.Add("Time for some kicks!");
            isKomo.Add(true);

            story.Add("We got em! How are they?"");
            isKomo.Add(true);

            story.Add("Worth it. Now, let's grab a bite.");
            isKomo.Add(false);

            story.Add("I'm down.");
            isKomo.Add(true);
        }
        //Act 3 Begin
        else if (storyPart == 12)
        {
            story.Add("So, has this day gotten any better for you?");
            isKomo.Add(true);

            story.Add("Yeah. It has.");
            isKomo.Add(false);

            story.Add("Where do you wanna eat?");
            isKomo.Add(true);

            story.Add("Let's see...I wanna head there.");
            isKomo.Add(false);

        }
        //Decision made - Act 3
        else if (storyPart == 13)
        {
            sotry.Add("Alright, I'm starving.");
            isKomo.Add(true);
        }
        //Pizza Place
        else if (storyPart == 14)
        {
            story.Add("This is some good pizza!");
            isKomo.Add(true);

            story.Add("The sauce and cheese taste great.");
            isKomo.Add(false);

            story.Add("Yeah. I could probably wat this every day!");
            isKomo.Add(true);

            story.Add("You'll get fat.");
            isKomo.Add(false);

            story.Add("Bruh. Leave me alone man.");
            isKomo.Add(true);

            story.Add("Hahahaha!");
            isKomo.Add(false);
        }
        //Mexican Joint
        else if (storyPart == 15)
        {
            story.Add("You got a torta?");
            isKomo.Add(true);

            story.Add("Yeah, wanted to try something different.");
            isKomo.Add(false);

            story.Add("That's the birria quesadilla, right?");
            isKomo.Add(false);

            story.Add("Yeah man, how could I not?");
            isKomo.Add(true);

            story.Add("Kinda feels typical.");
            isKomo.Add(false);

            story.Add("Eaaangh, whatever.");
            isKomo.Add(true);
        }
        //Smoothie Shack
        else if (storyPart == 16)
        {
            story.Add("Got a nice fruit blend.");
            isKomo.Add(false);

            story.Add("Neat! I got a peanut butter/banana/nutella blend.");
            isKomo.Add(true);

            story.Add("See that sweet tooth of yours is still strong.");
            isKomo.Add(false);

            story.Add("Well, sweet things are nice!");
            isKomo.Add(true);

            story.Add("Understandable, just watch yourself.");
            isKomo.Add(false);

            story.Add("Okay, mom.");
            isKomo.Add(true);
        }
        //Bakery
        else if (storyPart == 17)
        {
            story.Add("Alright, here we are. The bakery.");
            isKomo.Add(false);

            story.Add("YEAH! Let's grab some-");
            isKomo.Add(true);

            story.Add("Control yourself. Remember last time?");
            isKomo.Add(false);

            story.Add("Ah, right. I'll ease up. Just getting the smothered donuts.");
            isKomo.Add(true);

            story.Add("Just trying to make sure you're not going too far.");
            isKomo.Add(false);

            story.Add("While we wait...");
            isKomo.Add(false);
        }
        //End
        else
        {
            story.Add("What's been happening?");
            isKomo.Add(true)

            story.Add("You don't have to tell me if you don't find it comfortable, but-");
            isKomo.Add(true)

            story.Add("Nah, I owe you enough for my day.");
            isKomo.Add(false);

            story.Add("So in sum...I got fired.");
            isKomo.Add(false);

            story.Add("What happened?");
            isKomo.Add(true)

            story.Add("I was just working as usual and got called to the boss's office.");
            isKomo.Add(false);

            story.Add("He said that he was restructuring and said there wan't any room for me or some of the other veterans.");
            isKomo.Add(false);

            story.Add("That sucks, man.");
            isKomo.Add(true);

            story.Add("So...have you been doing well?");
            isKomo.Add(true);

            story.Add("I've mostly beed looking for and getting rejected by various job offers.");
            isKomo.Add(false);

            story.Add("Ouch. Maybe you should just take it easy and wait a bit.");
            isKomo.Add(true)

            story.Add("You're more than just your job skills, ya know.");
            isKomo.Add(true);

            story.Add("Thanks. I think I'll do just that.");
            isKomo.Add(false);

            story.Add("Now, let's keep eating.");
            isKomo.Add(true);

            story.Add("Yeah.");
            isKomo.Add(false);
        }
        inStory = true;
        storyText.text = story[0];
        index = -1;
    }
}
