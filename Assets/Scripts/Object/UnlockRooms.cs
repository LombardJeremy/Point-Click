using System.Collections.Generic;
using UnityEngine;

public class UnlockRooms : MonoBehaviour, IActionTrigger
{
    [SerializeField] private bool Up;
    [SerializeField] private bool Down;
    [SerializeField] private bool Left;
    [SerializeField] private bool Right;
    
    public void DoInteraction()
    {
        Direction[] arrows = GetComponentsInChildren<Direction>(true);
        
        foreach (var arrow in arrows)
        {
            if ((arrow.Up && Up) || (arrow.Down && Down) || (arrow.Left && Left) || (arrow.Right && Right))
            {
                arrow.Locked = false;
                Debug.Log("Arrow Unlocked: " + arrow.gameObject.name);
            }
        }
    }
}
