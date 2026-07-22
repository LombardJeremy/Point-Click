using System;
using UnityEngine;

public class Condition : MonoBehaviour
{
    [SerializeField] private GameObject _objectToFind;
    [SerializeField] private GameObject _objectToInteract;
    private IActionTrigger _actionTrigger;

    private void Awake()
    {
        _actionTrigger = _objectToInteract.GetComponent<IActionTrigger>();
    }

    public void CheckCondition()
    {
        if (_objectToFind == null) return;
        if (_objectToInteract == null) return;

        if (GameManager._instance.PossessObject(_objectToFind))
        {
            _actionTrigger?.DoInteraction();
        }
    }
}
