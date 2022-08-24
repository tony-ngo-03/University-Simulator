using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractObject : MonoBehaviour
{
    // Start is called before the first frame update
    public bool npcBool;
    private bool objectBool;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (npcBool && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("TALKING");
        }
        if (objectBool)
        {
            
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "NPC")
        {
            npcBool = true;
        }
        if(other.tag == "InteractableObject")
        {
            objectBool = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "NPC")
        {
            npcBool = false;
        }
        if(other.tag == "InteractableObject")
        {
            objectBool = false;
        }
    }

}
