using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericColliderScript : MonoBehaviour
{
    private GameObject topEdge;
    private GameObject bottomEdge;
    public Transform playerPos;
    private SpriteRenderer spriteR;
    public int playerLayerNum = 7;
    public int thisObjectLayer;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        playerPos = GameObject.Find("Player").gameObject.transform;
        topEdge = transform.Find("TopEdge").gameObject;
        bottomEdge = transform.Find("BottomEdge").gameObject;
           
        spriteR = GetComponent<SpriteRenderer>();
        thisObjectLayer = spriteR.sortingOrder;
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
            spriteR.sortingOrder = thisObjectLayer;
        }
        else
        {
            topEdge.SetActive(false);
            bottomEdge.SetActive(true);
            spriteR.sortingOrder = playerLayerNum + 5;
        }
    }
}
