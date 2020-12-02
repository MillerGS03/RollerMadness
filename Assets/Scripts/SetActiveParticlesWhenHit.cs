using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveParticlesWhenHit : MonoBehaviour
{
    public const int DELAY_SECONDS = 7;
    // Start is called before the first frame update
    public GameObject trigger;
    public GameObject[] targets;
    public GameObject collider;

    bool lastActive = false;
    DateTime count;

    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        try
        {
            double distX = Math.Abs(trigger.transform.position.x - collider.transform.position.x);
            double distY = Math.Abs(trigger.transform.position.z - collider.transform.position.z);
            bool active = Math.Sqrt(Math.Pow(distX,2) + Math.Pow(distY,2)) < 14f;

            bool changeToFalse = (active != lastActive) && !active;

            if (changeToFalse)
                count = System.DateTime.UtcNow;

            if ((System.DateTime.UtcNow - count).Seconds > DELAY_SECONDS)
            {
                foreach(GameObject target in targets)
                    target.SetActive(active);
            }

            lastActive = active;

            Debug.Log(count+"");
        }
        catch (Exception ex)
        {

        }
    }
}
