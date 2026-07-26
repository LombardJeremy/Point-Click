using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject firstRoom;
    
    public static GameManager _instance;

    public List<Object> _inventory;

    public Room mainRoom;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (firstRoom == null) return;
        
        Instantiate(firstRoom, new Vector3(0, 0, 0), Quaternion.identity);
        UpdateVisual(firstRoom);
    }

    public void LoadNewRoom(GameObject oldRoom, GameObject newRoom)
    {
        if (newRoom == null) return;
        Instantiate(newRoom, new Vector3(0, 0, 0), Quaternion.identity);
        Destroy(oldRoom);
        UpdateVisual(newRoom);
    }

    public void UpdateVisual(GameObject newRoom)
    {
        mainRoom.data = newRoom.GetComponent<RoomSub>().CurrentRoomData;
        //TODO update position of visual & button
    }
    
    
    //Add object in inventory
    public void AddObject(Object obj)
    {
        _inventory.Add(obj);
    }

    //Remove object from inventory
    public void RemoveObject(Object obj)
    {
        _inventory.Remove(obj);
    }

    public bool PossessObject(Object obj)
    {
        foreach (Object objOfPlayer in _inventory)
        {
            Debug.Log(objOfPlayer.unlocked);
            if (objOfPlayer.id == obj.id && objOfPlayer.unlocked)
            {
                Debug.Log(objOfPlayer.unlocked + " c fou ce qui se passe");
                return true;
            }
        }
        return false;
    }
}
