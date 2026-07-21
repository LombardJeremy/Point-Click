using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject FirstRoom;
    
    public static GameManager _instance;

    private List<GameObject> _inventory;

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
    }
    
    //Add object in inventory
    public void AddObject(GameObject obj)
    {
        _inventory.Add(obj);
    }

    //Remove object from inventory
    public void RemoveObject(GameObject obj)
    {
        _inventory.Remove(obj);
    }
}
