using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public RoomData data;

    public List<Direction> arrows =  new List<Direction>();
    public List<GameObject> arrowsOgPos =  new List<GameObject>();
}
