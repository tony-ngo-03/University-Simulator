using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterBuildingScript : MonoBehaviour
{
    public GameObject door;
    public string sceneName;
    private SpriteRenderer spriteRenderer;
    public bool enterBuilding;
    public Sprite[] sprites;
    private bool inRange = false;
    // Start is called before the first frame update
    void Start()
    { 
        spriteRenderer = door.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && inRange){
            spriteRenderer.sprite = sprites[1];
            SceneManager.LoadScene(sceneName);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        inRange = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        inRange = false;
    }




    
}
