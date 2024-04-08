using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectSpawner : MonoBehaviour
{
    public static ObjectSpawner Instance;

    public InputActionReference triggerButtonClick;
    public GameObject selectedObject;
    public Vector3 eulerAngle;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        triggerButtonClick.action.performed += TriggerButtonClick;
    }

    void TriggerButtonClick(InputAction.CallbackContext obj)
    {
        if (PreviewSpawner.Instance.isActive)
        {
            Instantiate(selectedObject, PreviewSpawner.Instance.rayPos, Quaternion.Euler(eulerAngle));
        }
    }
}
