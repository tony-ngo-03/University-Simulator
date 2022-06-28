using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericUseNameInText : MonoBehaviour
{
    // Start is called before the first frame update
    TMPro.TMP_Text text;
    public string beforeName;
    public string afterName;
    void Start()
    {
        text = GetComponent<TMPro.TMP_Text>();
        GameObject accessName = GameObject.Find("PlayerInformation").gameObject;
        PlayerInformation script = accessName.GetComponent<PlayerInformation>();
        text.text = beforeName + script.playerName + afterName;
    }
}
