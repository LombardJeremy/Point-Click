using UnityEngine;

[CreateAssetMenu(fileName = "ObjectData", menuName = "Scriptable Objects/NewObjectData", order = 2)]

public class UnlockableObject : ScriptableObject
{
    public int id;
    public new string name;
    public Sprite sprite;
    public bool unlocked;
}
