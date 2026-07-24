using System;
using UnityEngine;

public class Condition : MonoBehaviour
{
    [SerializeField] private Object _objectToFind;
    [SerializeField] private GameObject _objectToInteract;
    private IActionTrigger _actionTrigger;

    public void CheckCondition()
    {
        if (_objectToFind == null) return;
        if (_objectToInteract == null) return;
        
        _actionTrigger = _objectToInteract.GetComponent<UnlockRooms>();

        if (GameManager._instance.PossessObject(_objectToFind))
        {
            _actionTrigger?.DoInteraction();
        }
    }
}
