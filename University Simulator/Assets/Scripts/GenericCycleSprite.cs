using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericCycleSprite : MonoBehaviour
{
    public Sprite[] sprites;
    public int counter = 0;
    private SpriteRenderer spriteRenderer;
    public PlayerInformation playerInformation;
    public string bodyPart;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log(playerInformation.body.name);
        }
        playerInformation = GameObject.Find("PlayerInformation").gameObject.GetComponent<PlayerInformation>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        if(bodyPart == "Body")
        {
            playerInformation.body = spriteRenderer.sprite;
        }
        if(bodyPart == "Eyes")
        {
            playerInformation.eyes = spriteRenderer.sprite;
        }
        if(bodyPart == "Outfit")
        {
            playerInformation.outfit = spriteRenderer.sprite;
        }
        if(bodyPart == "Hairstyle")
        {
            playerInformation.hairstyle = spriteRenderer.sprite;
        }
        if(bodyPart == "Hat")
        {
            playerInformation.hat = spriteRenderer.sprite;
        }
        if(bodyPart == "Backpack")
        {
            playerInformation.backpack = spriteRenderer.sprite;
        }
        
    }


    public void changeSpriteLeft()
    {
        counter--;
        if(counter == -1)
        {
            counter = sprites.Length - 1;
        }
        spriteRenderer.sprite = sprites[counter];
    }

    public void changeSpriteRight()
    {
        counter++;
        if(counter == sprites.Length)
        {
            counter = 0;
        }
        spriteRenderer.sprite = sprites[counter];
    }
}
