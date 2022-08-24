using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControlScript : MonoBehaviour
{
    public static MusicControlScript instance;
    public AudioClip[] clips;
    private AudioSource source;
   private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        source = FindObjectOfType<AudioSource>();
        source.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!source.isPlaying)
        {
            source.clip = getClip();
            source.Play();
        }
    }

    private AudioClip getClip()
    {
        return clips[Random.Range(0, clips.Length)];
    }
}
