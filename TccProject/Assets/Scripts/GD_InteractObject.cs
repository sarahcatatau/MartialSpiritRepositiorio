using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Events;

public class GD_InteractObject : MonoBehaviour {
    public string interactionText = "Interact";
    public UnityEvent onInteract;


    public string GetInteractionText() {
        return interactionText;
    }

    public void Interact() {
        onInteract.Invoke();
    }
   
}