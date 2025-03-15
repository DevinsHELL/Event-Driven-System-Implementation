using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
     public string requiredItem; 

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            if (InventoryManager.Instance.HasItem(requiredItem))
            {
                InventoryManager.Instance.RemoveItem(requiredItem);
                OpenDoor();
            }
            else
            {
                Debug.Log("You need a " + requiredItem + " to open this door.");
            }
        }
    }

    private void OpenDoor()
    {
        Debug.Log("Door opened!");
        Destroy(gameObject); // Remove the door
    }
}
