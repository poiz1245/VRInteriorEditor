using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class EditMode : MonoBehaviour
{
    [SerializeField] GameObject editUI;
    int count = 0;

    void Start()
    {
    }

    private void Update()
    {

    }

    public void EditUIActivation()
    {
        if (count == 0)
        {
            editUI.SetActive(true);
            ObjectSpawner.Instance.objectInstance = gameObject;
            count++;
        }
        else
        {
            editUI.SetActive(false);
            ObjectSpawner.Instance.objectInstance = null;
            count--;
        }
    }

    public void SelectRelocation()
    {
        ObjectSpawner.Instance.Despawn();
        StateManager.Instance.currentState = StateManager.CurrentState.Build;
    }

    public void SelectDelete()
    {

    }


}
