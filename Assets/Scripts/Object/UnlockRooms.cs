using UnityEngine;

public class UnlockRooms : MonoBehaviour, IActionTrigger
{
    [SerializeField] private Direction _arrowToUnlock;
    
    public void DoInteraction()
    {
        if (_arrowToUnlock.Locked == true)
        {
            Debug.Log("Unlock Rooms");
            _arrowToUnlock.Locked = false;
        }
    }
}
