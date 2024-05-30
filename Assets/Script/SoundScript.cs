using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public AudioSource[] sounds;

    public void changeImage(int index)
    {
        if (index == 0)
        {
            sounds[0].Play();
        }
        else if (index == 1)
        {
            sounds[1].Play();
        }
    }

}
