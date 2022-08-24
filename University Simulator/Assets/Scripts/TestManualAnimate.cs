using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManualAnimate : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] downIdle;
    public Sprite[] upIdle;
    public Sprite[] sideIdle;


    public Sprite[] downWalk;
    public Sprite[] upWalk;
    public Sprite[] sideWalk;


    private Sprite[] currentSprite;




    public SpriteRenderer sr;


    public PlayerMovement playerMovementScript;


    public int frames;
    public int interval;
    int counter = 0;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        currentSprite = downIdle;
    }

    // Update is called once per frame
    void Update()
    {
        frames++;


        if (!playerMovementScript.isWalking)
        {
            if (playerMovementScript.facingDown)
            {
                currentSprite = downIdle;
            }
            if (playerMovementScript.facingUp)
            {
                currentSprite = upIdle;
            }
            if (playerMovementScript.facingSide)
            {
                if (playerMovementScript.flip)
                {
                    sr.flipX = true;
                }
                else
                {
                    sr.flipX = false;
                }
                currentSprite = sideIdle;
            }
        }
        else
        {
            if (playerMovementScript.facingDown)
            {
                currentSprite = downWalk;
            }
            if (playerMovementScript.facingUp)
            {
                currentSprite = upWalk;
            }
            if (playerMovementScript.facingSide)
            {
                if (playerMovementScript.flip)
                {
                    sr.flipX = true;
                }
                else
                {
                    sr.flipX = false;
                }
                currentSprite = sideWalk;
            }
        }


        if(frames % interval == 0)
        {
            counter++;
            if(counter == currentSprite.Length)
            {
                counter = 0;
            }
            sr.sprite = currentSprite[counter];
        }
        if(frames == interval * 6)
        {
            frames = 0;
        }
    }
}
