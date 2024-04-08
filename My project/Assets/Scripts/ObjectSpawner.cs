using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectSpawner : MonoBehaviour
{
    public static ObjectSpawner Instance;

    public InputActionReference triggerButtonClick;
    public Vector3 eulerAngle;

    public GameObject selectedObject;
    public GameObject objectInstance;
    public GameObject preObjectInstance;

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
            if(preObjectInstance == null)
            {
                objectInstance = Instantiate(selectedObject, PreviewSpawner.Instance.rayPos, Quaternion.Euler(eulerAngle));
                StateManager.Instance.currentState = StateManager.CurrentState.Normal;
            }
            else if(preObjectInstance != null)
            {
                Respawn();
            }
        }
    }

    public void Despawn()
    {
        objectInstance.SetActive(false);
        preObjectInstance = objectInstance;
        objectInstance = null; 
    }

    public void Respawn()
    {
        preObjectInstance.SetActive(true);
    }
}
