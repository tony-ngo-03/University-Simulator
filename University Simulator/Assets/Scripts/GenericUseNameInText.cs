using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenericUseNameInText : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public string beforeName;
    public string afterName;
    void Start()
    {
        text = GetComponent<Text>();
        GameObject accessName = GameObject.Find("PlayerInformation").gameObject;
        PlayerInformation script = accessName.GetComponent<PlayerInformation>();
        text.text = beforeName + script.playerName + afterName;
    }
}
