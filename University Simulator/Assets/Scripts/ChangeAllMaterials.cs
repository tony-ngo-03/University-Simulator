using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAllMaterials : MonoBehaviour
{

    public Material newMat;
    void Awake()
    {
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();

        foreach(GameObject go in allObjects){
            if(go.GetComponent<SpriteRenderer>() != null)
            {
                SpriteRenderer temp = go.GetComponent<SpriteRenderer>();
                temp.material = newMat; 
            }
        }
    }
}
