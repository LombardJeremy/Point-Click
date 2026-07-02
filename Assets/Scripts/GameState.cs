using UnityEngine;

[CreateAssetMenu(fileName = "GameState", menuName = "Scriptable Objects/NewGameState")]
public class GameState : ScriptableObject
{
    //Info a mettre du joueur pour l'inventaire
    public bool isDead;
}
