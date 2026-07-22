using UnityEngine;

[CreateAssetMenu(fileName = "ObjectData", menuName = "Scriptable Objects/NewObjectData", order = 2)]

public class Object : ScriptableObject
{
    public int id;
    public string name;
    public Sprite sprite;
}
