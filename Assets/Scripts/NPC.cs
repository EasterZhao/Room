using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject hiPanel;


    // Called when the NPC is interacted with
    public void OnMouseDown()
    {
        // Show the "hi" panel
        hiPanel.SetActive(true);

        // Call the HidePanel method after 4 seconds
        Invoke("HidePanel", 4f);

    }

    // Hides the "hi" panel
    private void HidePanel()
    {
        hiPanel.SetActive(false);
    }
}
