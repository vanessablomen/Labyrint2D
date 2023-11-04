using UnityEngine;

public class ExitTrigger : MonoBehaviour
{
    private bool playerInside = false;

    public bool IsPlayerInside()
    {
        return playerInside;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
        }
    }


}






