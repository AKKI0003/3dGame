using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float interactDistance = 3f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider[] hits = Physics.OverlapSphere(transform.position, interactDistance);

            foreach (Collider hit in hits)
            {
                Interactable interactable = hit.GetComponent<Interactable>();

                if (interactable != null)
                {
                    interactable.Interact();
                    break;
                }
            }
        }
    }
}