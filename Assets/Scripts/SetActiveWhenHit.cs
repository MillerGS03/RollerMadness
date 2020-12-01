using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveWhenHit : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    public bool active;
    void Start()
    {
    }
    private void OnTriggerEnter (Collider collider) {
        target.SetActive(active);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
