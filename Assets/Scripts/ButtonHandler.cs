using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isPressed = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        // Button is pressed
        isPressed = true;
        Debug.Log("Button pressed!");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Button is released
        isPressed = false;
        Debug.Log("Button released!");
    }

    private void Update()
    {
        // Check if the button is continuously held down
        if (isPressed)
        {
            Debug.Log("Button held down!");
        }
    }
}