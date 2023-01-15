using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManger : MonoBehaviour
{
    public AudioSource[] destroyNoise;

    public void PlayRandomDestroyNOise()
    {
        //chose a random number
        int clipToPlay = Random.Range(0, destroyNoise.Length);
        //play that clip
        destroyNoise[clipToPlay].Play();
    }
     
}
