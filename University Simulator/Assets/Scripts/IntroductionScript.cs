using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroductionScript : MonoBehaviour
{

    private int counter = 0;
    private Vector3 originalCollegePlace;
    public bool canContinue;
    public GameObject[] text;

    void Start()
    {
        originalCollegePlace = GameObject.Find("CollegeStudent").transform.position;
    }
    void Update()
    {
        if(counter == 2)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                canContinue = true;
                counter++;
                Debug.Log(counter);
                changeText(counter);
            }
        }
        if(counter == text.Length - 1)
        {
            canContinue = false;
            SceneManager.LoadScene("MainMap");
        }
        if(counter == 5 && counter == 8)
        {
            GameObject.Find("CollegeStudent").transform.position = Vector3.zero;
        }
        else
        {
            GameObject.Find("CollegeStudent").transform.position = originalCollegePlace;
        }
       if (Input.GetKeyDown(KeyCode.Return) && canContinue)
        {
            counter++;
            Debug.Log(counter);
            changeText(counter);
        }
    }



    private void changeText(int counter)
    {
        text[counter - 1].SetActive(false);
        text[counter].SetActive(true);
    }

    public void changeToTest()
    {
        SceneManager.LoadScene("TestCustomCharacter");
    }

    public void SetMajor()
    {

    }
   
}
