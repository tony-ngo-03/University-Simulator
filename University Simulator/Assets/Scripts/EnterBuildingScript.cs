using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterBuildingScript : MonoBehaviour
{
    public GameObject door;
    public string sceneName;
    public bool enterBuilding;
    public bool inRange = false;
    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && inRange){
            SceneManager.LoadScene(sceneName);
        }
    }





    
}
