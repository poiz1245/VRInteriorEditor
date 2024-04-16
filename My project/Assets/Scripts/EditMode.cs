using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class EditMode : MonoBehaviour
{
    [SerializeField] GameObject editUI;
    [SerializeField] GameObject objectPreview;
    public int myObjectID;
    public int myObjectCategory;

    int count = 0;

    public void EditUIActivation()
    {
        if (StateManager.Instance.currentState == StateManager.CurrentState.Edit)
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
    }

    public void SelectRelocation()
    {
        if (StateManager.Instance.currentState == StateManager.CurrentState.Edit)
        {
            editUI.SetActive(false);
            gameObject.SetActive(false);

            PreviewSpawner.Instance.objectID = myObjectID;
            PreviewSpawner.Instance.selectedObjectCategory = myObjectCategory;
            PreviewSpawner.Instance.Spawn();
            count--;
        }
    }

    public void SelectDelete()
    {

    }


}
