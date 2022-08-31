using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    public int nameIndex;
    public Sprite sprite;
    public TMPro.TMP_Text text;
    public bool fromBack;
    public int numFromBack;
    // Update is called once per frame
    void Update()
    {
        sprite = GetComponent<SpriteRenderer>().sprite;
        if (fromBack)
        {
            text.text = sprite.name.Substring(0, sprite.name.Length - numFromBack);
        }
        else
        {
            text.text = sprite.name.Substring(0, nameIndex);
        }
    }
}
