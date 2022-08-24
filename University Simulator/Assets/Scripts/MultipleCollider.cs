using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleCollider : MonoBehaviour
{
    public GameObject topEdge;
    public GameObject bottomEdge;

    public SpriteRenderer[] sr;

    public float posOffset;

    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        sr = getAllChildren(transform.childCount - 2);
    }


    private SpriteRenderer[] getAllChildren(int howMany)
    {
        SpriteRenderer[] temp = new SpriteRenderer[howMany];
        for(int i = 0;i < howMany; ++i)
        {
            temp[i] = transform.GetChild(i).GetComponent<SpriteRenderer>();
        }

        return temp;
    }


    private void updateSortingOrder(int order, bool changeLayer)
    {
        for(int i = 0; i < sr.Length; ++i)
        {
            if (changeLayer)
            {
                sr[i].sortingLayerName = "Player";
            }
            else
            {
                sr[i].sortingLayerName = "Wall";
            }
            sr[i].sortingOrder = order;
        }
    }
    // Update is called once per frame
    void Update()
    {
        float playerY = playerTransform.position.y;
        float thisY = transform.position.y;
        if (thisY + posOffset <= playerY)
        {
            bottomEdge.SetActive(false);
            topEdge.SetActive(true);
            updateSortingOrder(10, true);

        }
        else
        {
            bottomEdge.SetActive(true);
            topEdge.SetActive(false);
            updateSortingOrder(1, false);
        }
    }
}
