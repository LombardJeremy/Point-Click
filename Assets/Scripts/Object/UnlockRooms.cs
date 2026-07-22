using UnityEngine;

public class UnlockRooms : MonoBehaviour, IActionTrigger
{
    [SerializeField] private Direction _arrowToUnlock;
    
    public void DoInteraction()
    {
        if (_arrowToUnlock.Locked == true) _arrowToUnlock.Locked = false;
    }
}
