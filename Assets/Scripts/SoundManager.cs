using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SoundManager
{


    public static void BirdJumpSound()
    {
        GameObject gameObject = new GameObject("Sound", typeof(AudioSource));
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.PlayOneShot(GameAssets.GetInstance().birdJump);
    }
    public static void BirdLoseSound()
    {
        GameObject gameObject = new GameObject("Sound", typeof(AudioSource));
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.PlayOneShot(GameAssets.GetInstance().Lose);
    }
    public static void BirdScoreSound()
    {
        GameObject gameObject = new GameObject("Sound", typeof(AudioSource));
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.PlayOneShot(GameAssets.GetInstance().Score);
    }
    public static void ButtonClickSound()
    {
        GameObject gameObject = new GameObject("Sound", typeof(AudioSource));
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.PlayOneShot(GameAssets.GetInstance().ButtonClick);
    }

}
