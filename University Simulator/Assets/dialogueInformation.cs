using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueInformation : MonoBehaviour
{
    public string npcName;
    public Sprite[] spriteIdle;
    public string[] dialogue;

    public static dialogueInformation instance;

    // keep this object between scenes
    private void Awake()
    {
        DontDestroyOnLoad(this);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
