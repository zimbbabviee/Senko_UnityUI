using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public Sprite[] spriteArray;
    public GameObject imageHolder;

    public Sprite[] knightInventory;
    public Sprite[] pirateInventory;
    public GameObject[] inventoryImageHolders;

    public void changeImage(int index)
    {
        if (index == 0)
        {
            imageHolder.GetComponent<Image>().sprite = spriteArray[0];
            for (int i = 0; i < inventoryImageHolders.Length; i++)
            {
                inventoryImageHolders[i].GetComponent<Image>().sprite = knightInventory[i];
                inventoryImageHolders[i].GetComponent<Image>().SetNativeSize();
            }
        }
        else if (index == 1)
        {
            imageHolder.GetComponent<Image>().sprite = spriteArray[1];
            for (int i = 0; i < inventoryImageHolders.Length; i++)
            {
                inventoryImageHolders[i].GetComponent<Image>().sprite = pirateInventory[i];
                inventoryImageHolders[i].GetComponent<Image>().SetNativeSize();
            }
        }
    }

}
