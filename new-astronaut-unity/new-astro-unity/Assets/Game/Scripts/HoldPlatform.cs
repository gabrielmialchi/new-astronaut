using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldPlatform : MonoBehaviour
{
    public Collider2D holdCollider;
    public Collider2D oppJump;

    public KeyCode holdKey = KeyCode.Space;

    private void OnValidate()
    {
        holdCollider = GetComponentInChildren<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetKeyDown(holdKey))
        {

        }
    }

}
