using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Direction : MonoBehaviour, IInteractable
{
    private Room CurrentRoom;

    [SerializeField] public bool Up;
    [SerializeField] public bool Down;
    [SerializeField] public bool Left;
    [SerializeField] public bool Right;
    public bool Locked;

    private List<bool> Directions = new List<bool>();
    
    private void Start()
    {
        CurrentRoom = GetComponentInParent<Room>();
        
        Directions.Add(Up);
        Directions.Add(Down);
        Directions.Add(Left);
        Directions.Add(Right);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // eventData.button permet de savoir si c'est un clic gauche ou droit
        if (eventData.button == PointerEventData.InputButton.Left && !Locked)
        {
            Debug.Log("DIRECTION cliquée : " + gameObject.name);

            if (Up)
            {
                GameManager._instance.LoadNewRoom(CurrentRoom.gameObject, CurrentRoom.data.Up);
            }
            else if (Down)
            {
                GameManager._instance.LoadNewRoom(CurrentRoom.gameObject, CurrentRoom.data.Down);
            }
            else if (Left)
            {
                GameManager._instance.LoadNewRoom(CurrentRoom.gameObject, CurrentRoom.data.Left);
            }
            else if (Right)
            {
                GameManager._instance.LoadNewRoom(CurrentRoom.gameObject, CurrentRoom.data.Right);
            }
        }
    }
}
