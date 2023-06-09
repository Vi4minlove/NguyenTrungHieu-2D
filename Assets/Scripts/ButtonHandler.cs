using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isPressed = false;
    public PlayerController player;

    void Start()
    {
        player.GetComponent<Animator>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {

        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }

    private void Update()
    {
        if (isPressed == true)
        {
            player.GetComponent<Animator>().SetBool("Bow", true);
        }else
        {
            player.GetComponent<Animator>().SetBool("Bow", false);
        }
    }
}