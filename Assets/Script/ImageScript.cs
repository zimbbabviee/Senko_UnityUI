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
    public GameObject[] inventoryOnCharacter;

    public GameObject sizeSliderWidth;
    public GameObject sizeSliderLength;

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

    public void showChest(bool value)
    {
        inventoryImageHolders[0].SetActive(value);
        inventoryImageHolders[1].SetActive(value);
        inventoryImageHolders[2].SetActive(value);
    }

    public void showHelemt(bool value)
    {
        inventoryImageHolders[3].SetActive(value);
        inventoryImageHolders[4].SetActive(value);
        inventoryImageHolders[5].SetActive(value);
    }

    public void showWeapon(bool value)
    {
        inventoryImageHolders[6].SetActive(value);
        inventoryImageHolders[7].SetActive(value);
        inventoryImageHolders[8].SetActive(value);
    }

    public void changeWidth()
    {
        float size = sizeSliderWidth.GetComponent<Slider>().value;
        imageHolder.transform.localScale = new Vector2(1F * size, imageHolder.transform.localScale.y);
    }

    public void changeLength()
    {
        float size = sizeSliderLength.GetComponent<Slider>().value;
        imageHolder.transform.localScale = new Vector2(imageHolder.transform.localScale.x, 1F * size);
    }

}
