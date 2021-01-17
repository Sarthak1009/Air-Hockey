using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip PuckCollision;
    public AudioClip Goal;
    public AudioClip WonGame;
    public AudioClip LostGame;

    private AudioSource audiosource;
    private void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    public void PlayPuckCollision()
    {
        audiosource.PlayOneShot(PuckCollision);
    }
    public void PlayGoal()
    {
        audiosource.PlayOneShot(Goal);
    }
    public void PlayWonGame()
    {
        audiosource.PlayOneShot(WonGame);
    }
    public void PlayLostGame()
    {
        audiosource.PlayOneShot(LostGame);
    }
}
