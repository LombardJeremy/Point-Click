using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject FirstRoom;
    
    public static GameManager _instance;

    public List<Object> _inventory;

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
        if (FirstRoom == null) return;
        
        Instantiate(FirstRoom, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public void LoadNewRoom(GameObject oldRoom, GameObject newRoom)
    {
        if (newRoom == null) return;
        Instantiate(newRoom, new Vector3(0, 0, 0), Quaternion.identity);
        Destroy(oldRoom);
        if (newRoom.GetComponent<Condition>() != null) CheckCondition(newRoom.GetComponent<Condition>());
    }

    private void CheckCondition(Condition condition)
    {
        Debug.Log("CheckCondition");
        condition.CheckCondition();
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
            if (objOfPlayer.id == obj.id && obj.unlocked) return true;
        }
        return false;
    }
}
