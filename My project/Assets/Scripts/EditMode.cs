using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EditMode : MonoBehaviour
{
    public InputActionReference triggerButtonClick;
    void Start()
    {
        triggerButtonClick.action.performed += TriggerButtonClick;
    }

    void TriggerButtonClick(InputAction.CallbackContext obj)
    {
        if (PreviewSpawner.Instance.isActive)
        {

        }
    }
}
