using System;
using UnityEngine;

public class Condition : MonoBehaviour
{
    [SerializeField] private UnlockableObject _objectToFind;
    private IActionTrigger _actionTrigger;

    private void Start()
    {
        CheckCondition();
    }

    public void CheckCondition()
    {
        if (_objectToFind == null) return;
        
        Debug.Log("Check Condition");
        
        _actionTrigger = GetComponent<IActionTrigger>();

        if (GameManager._instance.PossessObject(_objectToFind))
        {
            _actionTrigger?.DoInteraction();
        }
    }
}
