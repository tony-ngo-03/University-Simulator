using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCustomCharacter : MonoBehaviour
{
    public PlayerInformation script;


    // 0 = body
    // 1 = eyes
    // 2 = outfit
    // 3 = hat
    // 4 = backpack
    // 5 = hair
    public GameObject[] bodyParts;
    public TestManualAnimate[] animateScripts;
    private string body = "Bodies/";
    private string eyes = "Eyes/";
    private string outfit = "Outfits/"; // needs custom because loaded is different
    private string hairstyles = "Hairstyle/";
    private string hats = "Hats/";    // needs custom because loaded is different
    private string backpack = "Backpacks/";
    // Start is called before the first frame update
    void Awake()
    {
        script = GameObject.Find("PlayerInformation").GetComponent<PlayerInformation>();


        animateScripts = getAnimateScripts(bodyParts.Length);

        for(int i = 0; i < animateScripts.Length; i++)
        {
            string currentPath;
            Sprite[] tempSprites;
            TestManualAnimate temp = animateScripts[i];
            // body
            if(i == 0)
            {
                //Assets/Resources/Bodies/Body_01.png
                currentPath = body + script.body.name;
                currentPath = currentPath.Substring(0, currentPath.Length - 2);
                Debug.Log(currentPath);
                tempSprites = Resources.LoadAll<Sprite>(currentPath);
                temp.downIdle = loadSprites(22, tempSprites);
                temp.upIdle = loadSprites(10, tempSprites);
                temp.sideIdle = loadSprites(4, tempSprites);

                temp.downWalk = loadSprites(48, tempSprites);
                temp.upWalk = loadSprites(36, tempSprites);
                temp.sideWalk = loadSprites(30, tempSprites);
            }
            // eyes
            if(i == 1)
            {
                currentPath = eyes + script.eyes.name;
                currentPath = currentPath.Substring(0, currentPath.Length - 2);
                tempSprites = Resources.LoadAll<Sprite>(currentPath);
                
                temp.downIdle = loadSprites(15, tempSprites);
                temp.upIdle = loadOnlyOne(tempSprites.Length- 1, tempSprites);
                temp.sideIdle = loadSprites(3, tempSprites);

                temp.downWalk = loadSprites(33, tempSprites);
                temp.upWalk = loadOnlyOne(tempSprites.Length - 1, tempSprites);
                temp.sideWalk = loadSprites(21, tempSprites);
            }
            // outfit
            if(i == 2)
            {
                currentPath = outfit + script.outfit.name;
                currentPath = currentPath.Substring(0, currentPath.Length - 2);
                tempSprites = Resources.LoadAll<Sprite>(currentPath);
                temp.downIdle = loadSprites(22, tempSprites);
                temp.upIdle = loadSprites(10, tempSprites);
                temp.sideIdle = loadSprites(4, tempSprites);

                temp.downWalk = loadSprites(46, tempSprites);
                temp.upWalk = loadSprites(34, tempSprites);
                temp.sideWalk = loadSprites(28, tempSprites);
            }
            // hat
            if(i == 3)
            {
                currentPath = hats + script.hat.name;
                currentPath = currentPath.Substring(0, currentPath.Length - 2);
                tempSprites = Resources.LoadAll<Sprite>(currentPath);
                temp.downIdle = loadSprites(22, tempSprites);
                temp.upIdle = loadSprites(10, tempSprites);
                temp.sideIdle = loadSprites(4, tempSprites);

                temp.downWalk = loadSprites(46, tempSprites);
                temp.upWalk = loadSprites(34, tempSprites);
                temp.sideWalk = loadSprites(28, tempSprites);
            }
            // backpack
            if(i == 4)
            {
                currentPath = backpack + script.backpack.name;
                currentPath = currentPath.Substring(0, currentPath.Length - 2);
                tempSprites = Resources.LoadAll<Sprite>(currentPath);

                temp.downIdle = loadSprites(22, tempSprites);
                temp.upIdle = loadSprites(10, tempSprites);
                temp.sideIdle = loadSprites(4, tempSprites);

                temp.downWalk = loadSprites(46, tempSprites);
                temp.upWalk = loadSprites(34, tempSprites);
                temp.sideWalk = loadSprites(28, tempSprites);
            }
            // hair
            if(i == 5)
            {
                currentPath = hairstyles + script.hairstyle.name;
                currentPath = currentPath.Substring(0, currentPath.Length - 2);
                tempSprites = Resources.LoadAll<Sprite>(currentPath);

                temp.downIdle = loadSprites(22, tempSprites);
                temp.upIdle = loadSprites(10, tempSprites);
                temp.sideIdle = loadSprites(4, tempSprites);

                temp.downWalk = loadSprites(46, tempSprites);
                temp.upWalk = loadSprites(34, tempSprites);
                temp.sideWalk = loadSprites(28, tempSprites);
            }
        }





    }

    private Sprite[] loadOnlyOne(int spriteNum, Sprite[] tempSprites)
    {
        Sprite[] temp = new Sprite[6];
        for(int i = 0; i < temp.Length; i++)
        {
            temp[i] = tempSprites[spriteNum];
        }

        return temp;
    }

    private Sprite[] loadSprites(int begin, Sprite[] tempSprites)
    {
        Sprite[] temp = new Sprite[6];
        for(int i = 0; i < 6; i++)
        {
            temp[i] = tempSprites[begin];
            begin++;
        }

        return temp;
    }

    private TestManualAnimate[] getAnimateScripts(int length)
    {
        TestManualAnimate[] scripts = new TestManualAnimate[length];
        for(int i = 0;i < length; i++)
        {
            scripts[i] = bodyParts[i].GetComponent<TestManualAnimate>();
        }

        return scripts;
    }
   
}
