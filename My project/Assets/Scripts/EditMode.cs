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
            count++;
        }
        else
        {
            editUI.SetActive(false);
            count--;
        }
    }

    public void SelectRelocation()
    {

    }

    public void SelectDelete()
    {

    }
}
