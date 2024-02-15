using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 100f;
    [SerializeField] float pushForce = 1000f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            pushAction(pushForce);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rotateAction(rotateSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rotateAction(-rotateSpeed);
        }
    }
    void pushAction(float pushForce)
    {
        rb.AddRelativeForce(Vector3.up * pushForce * Time.deltaTime);
    }
    void rotateAction(float rotateSpeed)
    {
        rb.freezeRotation = false;
        transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
        rb.freezeRotation = true;
    }
}
