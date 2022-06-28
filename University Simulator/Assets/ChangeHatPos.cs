using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHatPos : MonoBehaviour
{
    private TestManualAnimate script;
    // Start is called before the first frame update
    void Start()
    {
        script = GetComponent<TestManualAnimate>();

        Sprite temp = script.downIdle[0];
        string name = temp.name;

        name = name.Substring(0, name.Length - 6);

        if (name.Contains("Ladybug") || name.Contains("Bee"))
        {
            Debug.Log("TRUE");
            gameObject.transform.localPosition = new Vector2(gameObject.transform.localPosition.x, 0.075f);
        }
        Debug.Log("HAT NAME: " + name);

    }
}
