using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class loadDialogue : MonoBehaviour
{
    public dialogueInformation script;


    public SpriteRenderer npcSprite;
    public GameObject nameText;

    public GameObject dialogueText;

    public GameObject option1;
    public GameObject option2;
    public GameObject option3;

    public string[] dialogueOptions;
    public int npcSpriteCounter = 0;
    public int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("dialogueInformation").gameObject.GetComponent<dialogueInformation>();
    }

    private void Update()
    {
        ++counter;
        if (counter == 6)
        {
            counter = 0;
        }
        npcSprite.sprite = script.spriteIdle[counter];

    }

    public void changeCounter()
    {
        if (option1.activeInHierarchy)
        {
            option1.SetActive(false);
            option2.SetActive(false);
            option3.SetActive(false);
        }
        counter++;
        changeText(counter);
    }

    // every time the player clicks the continue button we want to
    public void changeText(int counter)
    {
        // FORMAT:
        // dialogue
        // option #
        // question
        // answer
        // answer
        // answer (if needed)
        // option over
        // dialogue
        // ...

        string text = dialogueOptions[counter];
        if(text.Length < 6)
        {
            dialogueText.GetComponent<Text>().text = text;
            
        }
        // this could be an option
        else
        {
            if(text.Substring(0, 6).Equals("option"))
            {
                int howMany = Int32.Parse("" + text[6]);
                // display the options
                if(howMany >= 2)
                {
                    option1.SetActive(true);
                    option2.SetActive(true);
                    dialogueText.GetComponent<Text>().text = text;
                    option1.GetComponent<Text>().text = dialogueOptions[counter + 1];
                    option2.GetComponent<Text>().text = dialogueOptions[counter + 2];
                    counter += 2;
                    // figure out way to skip these now!
                }
                if (howMany == 3)
                {
                    option3.SetActive(true);
                    option3.GetComponent<Text>().text = dialogueOptions[counter + 1];
                    counter += 1;
                }



            }
            else
            {
                dialogueText.GetComponent<Text>().text = text;
            }
        }

        

    }
}
