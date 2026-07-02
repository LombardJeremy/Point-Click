using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IInteractable
{
    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        // eventData.button permet de savoir si c'est un clic gauche ou droit
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("UI cliquée : " + gameObject.name);
        }
    }
}
