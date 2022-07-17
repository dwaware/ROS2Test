using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 myTarget;
    public Rigidbody rb;

    void Start()
    {
        rb.velocity = new Vector3(0, 0, -20);
        rb.angularVelocity = Vector3.zero;
    }

    public void SetTarget(Vector3 _target)
    {
        myTarget = _target;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 myPosition = this.gameObject.transform.position;
        Vector3 forceDirection = myTarget - myPosition;
        float myDistance = Vector3.Distance(myTarget, myPosition);
        if (myDistance > 0.1f)
        {
            rb.AddForce(1*forceDirection.normalized);
        }
        else
        {
            Debug.Log("Arrived at destination.");
            Debug.Log("Distance from target  x:" + forceDirection.x + " y:" + forceDirection.y + " z:" + forceDirection.z);
            rb.velocity = Vector3.zero;
        }
        rb.angularVelocity = Vector3.zero;
    }
}
