using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject firstRoom;
    
    public static GameManager _instance;

    public List<UnlockableObject> _inventory;

    public Room mainRoom;

    private GameObject _currentRoom;

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
        
        _currentRoom = Instantiate(firstRoom, new Vector3(0, 0, 0), Quaternion.identity);
        UpdateVisual(_currentRoom);
    }

    public void LoadNewRoom(GameObject newRoom)
    {
        if (newRoom == null) return;
        Destroy(_currentRoom);
        _currentRoom = Instantiate(newRoom, new Vector3(0, 0, 0), Quaternion.identity);
        UpdateVisual(_currentRoom);
    }

    public void UpdateVisual(GameObject newRoom)
    {
        mainRoom.data = newRoom.GetComponent<RoomSub>().CurrentRoomData;
        Arrow[] UIArrows = newRoom.GetComponentsInChildren<Arrow>();

        List<Direction> UXArrows = mainRoom.arrows;
        List<GameObject> UXArrowsOgPos = mainRoom.arrowsOgPos;

        UXArrows[0].GetComponent<RectTransform>().anchoredPosition = UXArrowsOgPos[0].GetComponent<RectTransform>().anchoredPosition;
        UXArrows[1].GetComponent<RectTransform>().anchoredPosition = UXArrowsOgPos[1].GetComponent<RectTransform>().anchoredPosition;
        UXArrows[2].GetComponent<RectTransform>().anchoredPosition = UXArrowsOgPos[2].GetComponent<RectTransform>().anchoredPosition;
        UXArrows[3].GetComponent<RectTransform>().anchoredPosition = UXArrowsOgPos[3].GetComponent<RectTransform>().anchoredPosition;
        
        foreach (var visualArrow in UIArrows)
        {
            if (visualArrow.Up && visualArrow.isVisible)
            {
                UXArrows[0].GetComponent<RectTransform>().anchoredPosition = visualArrow.GetComponent<RectTransform>().anchoredPosition;
            }
            if (visualArrow.Down && visualArrow.isVisible)
            {
                UXArrows[1].GetComponent<RectTransform>().anchoredPosition = visualArrow.GetComponent<RectTransform>().anchoredPosition;
            }
            if (visualArrow.Left && visualArrow.isVisible)
            {
                UXArrows[2].GetComponent<RectTransform>().anchoredPosition = visualArrow.GetComponent<RectTransform>().anchoredPosition;
            }
            if (visualArrow.Right && visualArrow.isVisible)
            {
                UXArrows[3].GetComponent<RectTransform>().anchoredPosition = visualArrow.GetComponent<RectTransform>().anchoredPosition;
            }
        }
    }
    
    
    //Add object in inventory
    public void AddObject(UnlockableObject obj)
    {
        _inventory.Add(obj);
    }

    //Remove object from inventory
    public void RemoveObject(UnlockableObject obj)
    {
        _inventory.Remove(obj);
    }

    public bool PossessObject(UnlockableObject obj)
    {
        foreach (UnlockableObject objOfPlayer in _inventory)
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
