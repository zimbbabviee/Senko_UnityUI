using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler,
    IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rTransform;
    private bool objectOverCharacter;
    public GameObject character;
    public GameObject canvas;

    private Vector2 startPosition;
    public Vector2 endPosition;

    public int inventoryClass;


    void Start()
    {
        rTransform = GetComponent<RectTransform>();
        startPosition = transform.position;

    }

    public void OnPointerDown(PointerEventData data)
    {
        //Debug.Log("Izdarīts klikšis uz velkama objekta!");
    }

    public void OnBeginDrag(PointerEventData data)
    {
        //Debug.Log("Uzsākta vilkšana!");
        gameObject.transform.SetParent(canvas.transform);
        transform.localScale = new Vector2(1, 1);
    }

    public void OnDrag(PointerEventData data)
    {
        Vector2 mousePosition =
            new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        mousePosition.x =
            Mathf.Clamp(mousePosition.x, 0 + rTransform.rect.width / 2,
            Screen.width - rTransform.rect.width / 2);

        mousePosition.y =
            Mathf.Clamp(mousePosition.y, 0 + rTransform.rect.height / 2,
            Screen.height - rTransform.rect.height / 2);

        rTransform.position = mousePosition;
        //Debug.Log("x=" + mousePosition.x + " un y=" + mousePosition.y);

        Vector2 localMousePosition = GameObject.Find("CharacterImage").transform.InverseTransformPoint(mousePosition);
        if (character.GetComponent<RectTransform>().rect.Contains(localMousePosition))
        {
            objectOverCharacter = true;
        }
        else
        {
            objectOverCharacter = false;
        }


    }


    public void OnEndDrag(PointerEventData data)
    {
        //Debug.Log("Objekts atlaists, vilkšana pārtraukta!");
        if (objectOverCharacter)
        {
            character.GetComponent<CharacterInventory>().setItems(inventoryClass, gameObject, endPosition);
        }
        else
        {
            transform.position = startPosition;
        }
    }

    public void resetPosition()
    {
        gameObject.transform.SetParent(canvas.transform);
        transform.localScale = new Vector2(1, 1);
        transform.position = startPosition;

    }

}

