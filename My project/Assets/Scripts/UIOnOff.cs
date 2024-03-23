using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UIOnOff : MonoBehaviour
{
    public InputActionReference uiOnOff;

    int count = 0;

    void Update()
    {
        uiOnOff.action.performed += UiOnOff;
    }

    void UiOnOff(InputAction.CallbackContext obj)
    {
        if(count == 0 )
        {
            gameObject.SetActive(true);
            count ++;
        }
        else if(count == 1 )
        {
            gameObject.SetActive(false);
            count --;
        }
    }
}
