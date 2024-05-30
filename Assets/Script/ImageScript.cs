using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public Sprite[] spriteArray;
    public GameObject imageHolder;

    public void changeImage(int index)
    {
        if (index == 0)
        {
            imageHolder.GetComponent<Image>().sprite = spriteArray[0];
        }
        else if (index == 1)
        {
            imageHolder.GetComponent<Image>().sprite = spriteArray[1];
        }
    }

}
