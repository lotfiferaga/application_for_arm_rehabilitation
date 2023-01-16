using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public Animator doorAnimator;

    void Update()
    {
        // Check if player is pressing the "Manipulation" button
        if (Input.GetButtonDown("Manipulation"))
        {
            // Create a raycast
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            RaycastHit hit;

            // Check if the raycast hits a door
            if (Physics.Raycast(ray, out hit, 2f) && hit.transform.CompareTag("Door"))
            {
                // Open the door
                doorAnimator.SetBool("Open", true);
            }
        }
    }
}
