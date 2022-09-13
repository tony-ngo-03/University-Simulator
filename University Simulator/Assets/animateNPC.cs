using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateNPC : MonoBehaviour
{
    public Sprite[] idleDown;
    public SpriteRenderer mentor;

    public int frames = 0;
    public int interval;
    public int spriteFrame = 0;

    // Update is called once per frame
    void Update()
    {
        // manually update the sprite every interval to the next one
        frames++;
        if(frames % interval == 0)
        {
            spriteFrame++;
            mentor.sprite = idleDown[spriteFrame];
        }
        if(spriteFrame == 5)
        {
            spriteFrame = 0;
        }
    }
}
