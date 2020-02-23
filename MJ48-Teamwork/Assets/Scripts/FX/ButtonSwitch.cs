using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Sprite Button_Down;
    [SerializeField] Sprite Button_UP;
    bool isPressed;
    SpriteRenderer rend;
    void Start()
    {
        isPressed = false;
        rend = GetComponent<SpriteRenderer>();
        SetButtonState(isPressed);
    }

    public void SetButtonState(bool _isPressed)
    {
        isPressed = _isPressed;
        if (isPressed)
        {
            rend.sprite = Button_Down;
        }
        else
        {
            rend.sprite = Button_UP;
        }
    }
    public bool GetButtonState()
    {
        return isPressed;
    }
}
