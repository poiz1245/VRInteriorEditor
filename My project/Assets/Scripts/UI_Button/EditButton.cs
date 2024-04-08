using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditButton : MonoBehaviour
{
    public void ChangeCurrentState()
    {
        StateManager.Instance.currentState = StateManager.CurrentState.Edit;
    }
}
