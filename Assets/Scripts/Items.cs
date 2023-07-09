using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public GameObject hiPanel;


    // Called when the NPC is interacted with
    public void OnMouseDown()
    {
        // Show the "hi" panel
        hiPanel.SetActive(true);
    }

    // Hides the "hi" panel
    private void HidePanel()
    {
        hiPanel.SetActive(false);
    }
}
