using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditButton : MonoBehaviour
{
    [SerializeField] State stateManager;
    public void ChangeCurrentState()
    {
        stateManager.currentState = State.CurrentState.Edit;
    }
}
