using UnityEngine;
using static UnityEditor.Progress;

public class PickUpItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out itemTracker item))
        {
            InventoryManager.Instance.AddItem(item.itemName);
            Destroy(other.gameObject); // Remove item from scene
        }
    }
}
