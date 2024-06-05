using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlatGravity : MonoBehaviour
{
    public GameObject platform;
    Rigidbody2D rb;
    public float gravityForce;
    public float gravityDistance;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, platform.transform.position);

        Vector3 v = platform.transform.position - transform.position;

        rb.AddForce(v.normalized * (1f - dist / gravityDistance) * gravityForce);
    }
}
