using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BookSocket : MonoBehaviour
{
    [SerializeField] private Rigidbody fallingBook; // The book that will fall
    private XRSocketInteractor socketInteractor;

    private void Start()
    {
        socketInteractor = GetComponent<XRSocketInteractor>();

        // Subscribe to the select event
        socketInteractor.selectEntered.AddListener(OnBookPlaced);
    }

    private void OnDestroy()
    {
        // Unsubscribe to avoid memory leaks
        if (socketInteractor != null)
            socketInteractor.selectEntered.RemoveListener(OnBookPlaced);
    }

    public void OnBookPlaced(SelectEnterEventArgs args)
    {
        // Optional: Ensure the correct book was placed by checking tags or names
        if (args.interactableObject.transform.CompareTag("Book"))
        {
            TriggerFallingBook();
        }
    }

    private void TriggerFallingBook()
    {
        if (fallingBook != null)
        {
            fallingBook.isKinematic = false; // Enable physics
            // Add a force for effect to the left
            fallingBook.AddForce(Vector3.left * 10, ForceMode.Impulse);
        }
    }
}
