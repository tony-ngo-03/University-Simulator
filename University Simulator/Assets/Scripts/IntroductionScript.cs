using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroductionScript : MonoBehaviour
{

    public int counter = 0;
    private Vector3 originalCollegePlace;
    public bool canContinue;
    public GameObject[] text;
    private PlayerInformation script;


    void Start()
    {
        script = GameObject.Find("PlayerInformation").GetComponent<PlayerInformation>();
        originalCollegePlace = GameObject.Find("CollegeMentor").transform.position;
    }
    void Update()
    {
       
       
    }



    public void changeText(int counter)
    {
        if (counter == text.Length - 1)
        {
            SceneManager.LoadScene("MainMap");
        }
        if (counter == 5 || counter == 8)
        {
            GameObject.Find("CollegeMentor").transform.position = Vector3.zero;
        }
        else
        {
            GameObject.Find("CollegeMentor").transform.position = originalCollegePlace;
        }
        text[counter - 1].SetActive(false);
        text[counter].SetActive(true);
    }

    public void changeToTest()
    {
        SceneManager.LoadScene("TestCustomCharacter");
    }

    public void SetMajor(string major)
    {
        script.playerMajor = major;
    }

    public void continueButton()
    {
        if(counter == 2)
        {
            if(!script.playerName.Equals(""))
            {
                counter++;
                changeText(counter);
            }
        }
        else if(counter == 8)
        {
            if (!script.playerMajor.Equals(""))
            {
                counter++;
                changeText(counter);
            }
        }
        else
        {
            counter++;
            changeText(counter);
        }
    }
   
}
