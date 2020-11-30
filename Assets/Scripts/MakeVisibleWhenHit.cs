using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeVisibleWhenHit : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    void Start()
    {
        
    }
    private void OnTriggerEnter (Collider collider) {
        target.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
