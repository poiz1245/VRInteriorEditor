using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectSpawner : MonoBehaviour
{
    public static ObjectSpawner Instance;

    [SerializeField] InputActionReference triggerButtonClick;
    public GameObject objectInstance;

    public Vector3 eulerAngle { get; set; }

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
        if (PreviewSpawner.Instance.isActive && 
            (StateManager.Instance.currentState == StateManager.CurrentState.Build || 
            StateManager.Instance.currentState == StateManager.CurrentState.Edit))
        {
            if (StateManager.Instance.currentState == StateManager.CurrentState.Build)
            {
                StateManager.Instance.currentState = StateManager.CurrentState.Normal;
            }

            objectInstance = ObjectPool.GetObject(PreviewSpawner.Instance.objectID);
            objectInstance.transform.position = PreviewSpawner.Instance.rayPos;
            objectInstance.transform.rotation = Quaternion.Euler(eulerAngle);
            PreviewSpawner.Instance.Despawn();
        }
    }

    public void Despawn()
    {
        objectInstance.SetActive(false);
    }
}
