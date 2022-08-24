using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GenericDialougeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite character;
    public string characterName;
    public bool inRange;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inRange && Input.GetKeyDown(KeyCode.F))
        {
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
