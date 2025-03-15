using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<string> inventory = new List<string>();

    
    public event System.Action OnInventoryChanged;

    private void Awake() { Instance = this; }

    public void AddItem(string itemName)
    {
        inventory.Add(itemName);
        Debug.Log($"Picked up {itemName}");
        OnInventoryChanged?.Invoke(); 
    }

    public bool HasItem(string itemName) => inventory.Contains(itemName);

    public void RemoveItem(string itemName)
    {
        if (inventory.Contains(itemName))
        {
            inventory.Remove(itemName);
            Debug.Log($"{itemName} used and removed from inventory.");
            OnInventoryChanged?.Invoke(); 
        }
    }

    public List<string> GetInventory() => inventory;
}


