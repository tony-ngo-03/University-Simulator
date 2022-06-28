using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject topEdge;
    public GameObject bottomEdge;
    public Transform playerTransform;
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    private int counter;
    public float posOffset;
    public float edgeOffset;
    private Vector3 originalTopEdge;
    private Vector3 originalBottomEdge;
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        originalTopEdge = topEdge.gameObject.transform.position;
        originalBottomEdge = bottomEdge.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            // change to lit
            if (counter == 0)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + posOffset, transform.position.z);
                topEdge.transform.position = new Vector3(transform.position.x, transform.position.y + edgeOffset, transform.position.z);
                bottomEdge.transform.position = new Vector3(transform.position.x, transform.position.y - posOffset / 4, transform.position.z);
                counter++;
                spriteRenderer.sprite = sprites[counter];
            }
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - posOffset, transform.position.z);
                topEdge.transform.position = originalTopEdge;
                bottomEdge.transform.position = originalBottomEdge;
                counter--;
                spriteRenderer.sprite = sprites[counter];
            }
        }

        float playerY = playerTransform.position.y;
        float thisY = transform.position.y;

        if(thisY >= playerY)
        {
            bottomEdge.SetActive(false);
            topEdge.SetActive(true);
            spriteRenderer.sortingOrder = 1;

        }
        else
        {
            bottomEdge.SetActive(true);
            topEdge.SetActive(false);
            spriteRenderer.sortingOrder = 5;
        }
    }
}
