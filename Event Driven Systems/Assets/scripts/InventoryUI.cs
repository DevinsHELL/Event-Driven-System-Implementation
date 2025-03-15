using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public static InventoryUI Instance;
    public Text inventoryText; // Reference to UI Text

    private void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void OnEnable()
    {
        
        if (InventoryManager.Instance != null)
        {
            
            InventoryManager.Instance.OnInventoryChanged += UpdateInventoryUI;
            UpdateInventoryUI(); 
        }
        else
        {
            Debug.LogError("InventoryManager is not initialized yet.");
        }
    }

    private void OnDisable()
    {
        
        if (InventoryManager.Instance != null)
        {
            InventoryManager.Instance.OnInventoryChanged -= UpdateInventoryUI;
        }
    }

    public void UpdateInventoryUI()
    {
        
        if (InventoryManager.Instance != null)
        {
            inventoryText.text = "Inventory: " + string.Join(", ", InventoryManager.Instance.inventory);
        }
    }
}
