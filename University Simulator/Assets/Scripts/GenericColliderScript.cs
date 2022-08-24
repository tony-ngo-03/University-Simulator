using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericColliderScript : MonoBehaviour
{
    private GameObject topEdge;
    private GameObject bottomEdge;
    private Transform playerPos;
    private SpriteRenderer spriteR;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        topEdge = transform.Find("TopEdge").gameObject;
        bottomEdge = transform.Find("BottomEdge").gameObject;
        playerPos = GameObject.FindGameObjectWithTag("Player").gameObject.transform;
        spriteR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float playerY = playerPos.position.y;
        float thisY = transform.position.y;


        if(thisY >= playerY - offset)
        {
            topEdge.SetActive(true);
            bottomEdge.SetActive(false);
            spriteR.sortingOrder = 1;
        }
        else
        {
            topEdge.SetActive(false);
            bottomEdge.SetActive(true);
            spriteR.sortingOrder = 5;
        }
    }
}
