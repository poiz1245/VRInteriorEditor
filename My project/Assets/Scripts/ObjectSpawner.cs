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
            if(StateManager.Instance.currentState == StateManager.CurrentState.Build)
            {
                objectInstance = Instantiate(selectedObject, PreviewSpawner.Instance.rayPos, Quaternion.Euler(eulerAngle));
                StateManager.Instance.currentState = StateManager.CurrentState.Normal;
            }
            else if(StateManager.Instance.currentState == StateManager.CurrentState.Edit)
            {
                Respawn();
            }
        }
    }

    public void Despawn()
    {
        objectInstance.SetActive(false);
    }

    public void Respawn()
    {
        objectInstance.SetActive(true);
    }
}
