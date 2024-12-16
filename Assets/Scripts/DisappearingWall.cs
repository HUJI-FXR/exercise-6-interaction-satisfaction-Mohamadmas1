using UnityEngine;

public class DisappearingWall : MonoBehaviour
{
    public GameObject wall; // Reference to the wall GameObject
    public GameObject ball1; // Reference to the first ball GameObject
    public GameObject ball2; // Reference to the second ball GameObject
    public Transform placementArea1; // First ball placement location
    public Transform placementArea2; // Second ball placement location

    private bool ball1Placed = false;
    private bool ball2Placed = false;

    //check if the ball with tag "Ball" is placed in the correct area with tag "place"
        private void Update()
    {
        if (Vector3.Distance(ball1.transform.position, placementArea1.position)<0.5f||
        Vector3.Distance(ball2.transform.position, placementArea1.position) < 0.5f)
        {
            ball1Placed = true;
        }

        if (Vector3.Distance(ball1.transform.position, placementArea2.position)<0.5f||
        Vector3.Distance(ball2.transform.position, placementArea2.position) < 0.5f)
        {
            ball2Placed = true;
        }

        if (ball1Placed && ball2Placed)
        {
            wall.SetActive(false); // Disable the wall
        }
    }
}
