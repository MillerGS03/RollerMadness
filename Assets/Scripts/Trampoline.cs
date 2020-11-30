using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float force = 5;
 
    private void OnTriggerEnter (Collider collider) {
    if (collider.attachedRigidbody != null) {
        collider.attachedRigidbody.velocity += transform.TransformDirection(new Vector3 (0, force, 0));
    }
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
