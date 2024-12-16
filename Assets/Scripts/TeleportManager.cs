using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportManager : MonoBehaviour
{
    public XRRayInteractor leftRayInteractor;  // Reference to the XRRayInteractor on the left controller
    public XRRayInteractor rightRayInteractor; // Reference to the XRRayInteractor on the right controller


    private void Start()
    {
        // Disable both XRRayInteractors at the start
        if (leftRayInteractor != null)
        {
            leftRayInteractor.enabled = false; // Disable the left controller's ray interactor
        }

        if (rightRayInteractor != null)
        {
            rightRayInteractor.enabled = false; // Disable the right controller's ray interactor
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger zone is tagged "DesBox"
        if (other.CompareTag("DesBox"))
        {
            Destroy(other.gameObject);  // Destroy the object with the "DesBox" tag
            EnableTeleportation();      // Enable the teleportation area and Ray Interactors
        }
    }

    private void EnableTeleportation()
    {
        // Enable both XRRayInteractors (for teleportation)
        if (leftRayInteractor != null)
        {
            leftRayInteractor.enabled = true;  // Enable the left controller's XR Ray Interactor
        }

        if (rightRayInteractor != null)
        {
            rightRayInteractor.enabled = true; // Enable the right controller's XR Ray Interactor
        }
    }
}
