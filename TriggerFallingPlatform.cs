using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFallingPlatform : MonoBehaviour
{
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;

        if (body == null || body.useGravity)
        {
            return;
        }

        Debug.Log("OnControllerColliderHit");
        body.useGravity = true;
    }
}
