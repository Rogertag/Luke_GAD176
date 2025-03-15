using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    // message displayed to player when looking at an interactible
    public string promptMessage; // this will tell the player what is interactible

    // this function will be called from the player

    public void BaseInteract()
    {
        Interact();
    }

    protected virtual void Interact()
    {
        // this function is a stand in for subclases to take it over, because of the amount of veried interactibles 
        // we want to keep this simple, kinda like a reference 
    }
}
