using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour
{
    public GameObject[] characterInventory;
    //[0] chest
    //[1] helemt
    //[2] weapon
    public AudioSource[] inventorySounds;

    public void setItems(int inventoryClass, GameObject inventory, Vector2 endPosition)
    {
        if (characterInventory[inventoryClass] != null)
        {
            characterInventory[inventoryClass].GetComponent<DragAndDrop>().resetPosition();
        }
        characterInventory[inventoryClass] = inventory;
        inventory.transform.SetParent(gameObject.transform);
        inventory.transform.localScale = new Vector2(1, 1);
        inventory.transform.localPosition = endPosition;
        inventorySounds[inventoryClass].Play();

        //reorder items
        for (int i = 2; i > 0; i--)
        {
            if (characterInventory[i] != null)
            {
                Vector2 tempPosition = characterInventory[i].transform.position;
                characterInventory[i].transform.SetParent(null);
                characterInventory[i].transform.SetParent(gameObject.transform);
                characterInventory[i].transform.position = tempPosition;

            }
        }
    }

}
