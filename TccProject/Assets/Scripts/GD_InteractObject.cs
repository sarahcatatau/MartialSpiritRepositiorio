using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;

public class GD_InteractObject : MonoBehaviour {
    [SerializeField] DialogoSo DialogData;
    public string interactionText = "Interact";
    public UnityEvent onInteract;
    


    public string GetInteractionText() {
        return interactionText;
    }

    public void Interact() {
        onInteract.Invoke();
        GameEvents.Instance.StartDialog(DialogData);
    }
   
}