using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ThrowBall : MonoBehaviour
{
    public float throwForce = 10f;

    public void shot()
    {
            GetComponent<XRGrabInteractable>().enabled = false;
            Vector3 direction = transform.position - Camera.main.transform.position;
            GetComponent<Rigidbody>().AddForce(direction.normalized * throwForce, ForceMode.Impulse);
    }
}
