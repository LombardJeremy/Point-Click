using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "RoomData", menuName = "Scriptable Objects/NewRoomData", order = 1)]

public class RoomData : ScriptableObject
{
    public GameObject Up;
    public GameObject Down;
    public GameObject Left;
    public GameObject Right;
}
