using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDescription : MonoBehaviour
{
    public GameObject ScrollViewContent;
    public string[] descriptions;
    public void changeDescription(int index)
    {
        ScrollViewContent.GetComponent<Text>().text = descriptions[index];
    }

}
