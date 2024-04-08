using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditButton : MonoBehaviour
{
    public void ChangeCurrentState()
    {
        State.Instance.currentState = State.CurrentState.Edit;
    }
}
