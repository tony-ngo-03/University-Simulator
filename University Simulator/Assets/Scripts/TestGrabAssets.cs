using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class TestGrabAssets : MonoBehaviour
{


    public GenericCycleSprite script;
    public Sprite[] tempAllSprites;
    public string targetPath;



    public int target;
    public int numObject;
    public int numVary;

    public bool multiple;
    int counter = -1;
    void Awake()
    {

        if (multiple)
        {
            for (int i = 1; i <= numObject; i++)
            {
                for (int j = 1; j <= numVary; j++)
                {
                    ++counter;
                    string currentPath = targetPath;
                    if (i < 10)
                    {
                        currentPath = currentPath + "0";
                    }
                    currentPath = currentPath + i.ToString() + "_0" + j.ToString();
                    tempAllSprites = Resources.LoadAll<Sprite>(currentPath);
                    script.sprites[counter] = tempAllSprites[target];
                }
            }
        }
        else
        {
            for(int spriteCounter = 1; spriteCounter <= numObject; spriteCounter++)
            {
                ++counter;
                string currentPath = targetPath;
                if(spriteCounter < 10)
                {
                    currentPath = currentPath + "0";
                }
                currentPath = currentPath + spriteCounter.ToString();
                tempAllSprites = Resources.LoadAll<Sprite>(currentPath);
                script.sprites[counter] = tempAllSprites[target];
            }
        }


        //for (int i = 1; i <= 26; i++)
        //{
        //    for (int j = 1; j <= 7; j++)
        //    {
        //        ++counter;
        //        string currentPath = targetPath;
        //        if (i < 10)
        //        {
        //            currentPath = currentPath + "0";
        //        }
        //        currentPath = currentPath + i.ToString() + "_0" + j.ToString();
        //        Debug.Log(currentPath);
        //        temp3 = Resources.LoadAll<Sprite>(currentPath);
        //        script.sprites[counter] = temp3[3];
        //    }
        //}

    }
}
