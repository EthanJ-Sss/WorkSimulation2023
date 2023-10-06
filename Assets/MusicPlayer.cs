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

    private bool clip1Played = false;
    private bool clip2Played = false;
    private bool clip3Played = false;
    private bool clip4Played = false;

    void Awake()
    {

        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
    }
    void Update()
    {
        var currentScene = SceneManager.GetActiveScene().name;
        switch (currentScene)
        {
            case "Level 04":
                {
                    if (!clip1Played)
                    {
                        clip1Played = true;
                        audioSource.clip = Clip1;
                        audioSource.Play();
                    }
                    break;
                }
            case "Level 08":
                {
                    if (!clip2Played)
                    {
                        clip2Played = true;
                        audioSource.clip = Clip2;
                        audioSource.Play();
                    }
                    break;
                }
            case "Level 12":
                {
                    if (!clip3Played)
                    {
                        clip3Played = true;
                        audioSource.clip = Clip3;
                        audioSource.Play();
                    }
                    break;
                }
            case "Level 16":
                {
                    if (!clip4Played)
                    {
                        clip4Played = true;
                        audioSource.clip = Clip1;
                        audioSource.Play();
                    }
                    break;
                }
            default:
                break;
        }

    }
}
