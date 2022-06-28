using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestChangeAnimation : MonoBehaviour
{
    private Animator anim;
    public RuntimeAnimatorController[] allAnims; 
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if(counter == 1)
            {
                counter--;
            }
            else
            {
                counter++;
            }
            anim.runtimeAnimatorController = allAnims[counter];
        }
    }
}
