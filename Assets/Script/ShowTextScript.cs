using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextScript : MonoBehaviour
{
    string text;
    string enteredYears = "0";
    int age;
    int yearNow;

    public GameObject inputFieldName;
    public GameObject inputFieldAge;
    public GameObject displayField;


    public void getText()
    {
        yearNow = System.DateTime.Now.Year;

        if (inputFieldAge.GetComponent<Text>().text != "" && inputFieldAge.GetComponent<Text>().text != "-")
        {
            enteredYears = inputFieldAge.GetComponent<Text>().text;
        }

        age = yearNow - int.Parse(enteredYears);

        text = "Cīnītājs " + inputFieldName.GetComponent<Text>().text;
        displayField.GetComponent<Text>().text =
                                text + " ir " + age + " gadus vecs!";


    }
}
