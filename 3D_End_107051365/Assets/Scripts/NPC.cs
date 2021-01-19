
using UnityEngine;

public class NPC : MonoBehaviour
{
    public bool playerInArea;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "忍者")
        {
            playerInArea = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "忍者")
        {
            playerInArea = false;
        }
    }
 
}
