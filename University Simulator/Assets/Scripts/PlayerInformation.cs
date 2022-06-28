using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInformation : MonoBehaviour
{
    public string playerName;
    public string playerMajor;


    public Sprite body;
    public Sprite eyes;
    public Sprite outfit;
    public Sprite hairstyle;
    public Sprite hat;
    public Sprite backpack;
    public IntroductionScript script;


    public static PlayerInformation instance;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void ReadName(string name)
    {
        playerName = name;
        //script.canContinue = true;
        Debug.Log(script.canContinue);
        Debug.Log(name + " HERE ");
    }



}
