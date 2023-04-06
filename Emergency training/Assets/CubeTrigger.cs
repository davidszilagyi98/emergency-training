using UnityEngine;

public class CubeTrigger : MonoBehaviour
{
    private Collider boxCollider;

    void Start()
    {
        // Get the collider component of the cube
        boxCollider = GetComponent<Collider>();
    }

    public void DisappearOnKeyPress()
    {
        // Set isTrigger to true
        boxCollider.isTrigger = true;
    }
}
