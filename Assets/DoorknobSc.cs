using UnityEngine;

public class DoorknobSc : MonoBehaviour
{
    public float force = 10f; // the force to apply to the door's rigidbody
    public float rayDistance = 2f; // the distance of the raycast
    public float animationTime = 1f; // time to complete the animation
    public Vector3 openRotation; // the euler angles for the open position
    public Vector3 closeRotation; // the euler angles for the close position
    public Animator anim; // Reference to the animator component of the door

    private bool isOpen = false; // keep track of the door's open/close state

    void OnMouseDown()
    {
        // cast a ray from the doorknob towards the door
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            // check if the ray hit the door's collider
            if (hit.collider.CompareTag("Door"))
            {
                // toggle the door's open/close state
                isOpen = !isOpen;
                if (isOpen)
                {
                   
                     hit.collider.transform.Rotate(0f, 20, 0f);
                }
                else
                {
                    
                    hit.collider.transform.Rotate(0f, -20, 0f);
                }
            }
        }
    }
}

