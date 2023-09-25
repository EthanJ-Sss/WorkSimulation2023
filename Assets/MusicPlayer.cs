using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip Clip1;
    public AudioClip Clip2;
    public AudioClip Clip3;
    public AudioSource audioSource;
    
    void Awake() {
        
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Level 04")
        {
            audioSource.clip = Clip1;
            audioSource.Play();
        }
        if(SceneManager.GetActiveScene().name == "Level 08")
        {
            audioSource.clip = Clip1;
            audioSource.Play();
        }

    }
}
