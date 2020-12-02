using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveParticlesWhenHit : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    public GameObject collider;

    public bool active;
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        double distX = Math.Abs(target.transform.position.x - collider.transform.position.x);
        double distY = Math.Abs(target.transform.position.y - collider.transform.position.y);
        target.SetActive(Math.Sqrt(Math.Pow(distX,2) + Math.Pow(distY,2)) < 14f);
    }
}
