using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GenericDialougeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite character;
    public string characterName;
    public string[] dialogueText;
    public string[] optionText;
    public bool inRange;

    public dialogueInformation script;
    void Start()
    {
        script = GameObject.Find("dialogueInformation").gameObject.GetComponent<dialogueInformation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(inRange && Input.GetKeyDown(KeyCode.E))
        {
            // change the dialogue to be transferred to the scence into this;
            // reset the array first
            script.dialogue = new string[this.dialogueText.Length];
            script.dialogue = this.dialogueText;
            SceneManager.LoadScene("Dialogue");
        }
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            inRange = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            inRange = false;
        }
    }


}
