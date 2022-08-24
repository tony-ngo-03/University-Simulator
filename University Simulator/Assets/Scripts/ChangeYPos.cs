using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeYPos : MonoBehaviour
{
    private float oldY;
    public float newY = -220.72f;
    RectTransform temp;
    public GenericCycleSprite script;
    // Start is called before the first frame update
    void Start()
    {
        temp = GetComponent<RectTransform>();
        oldY = temp.anchoredPosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (script.counter > 7)
        {
            temp.anchoredPosition = new Vector2(temp.anchoredPosition.x, newY);
        }
        else
        {
            temp.anchoredPosition = new Vector2(temp.anchoredPosition.x, oldY);
        }
    }
}
