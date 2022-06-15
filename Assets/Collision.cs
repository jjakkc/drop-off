using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log($"{this.name} hit {other.gameObject.name} at {other.GetContact(0)}");
        Debug.Log($"Hit: {other.contactCount}");
        // other.transform.localScale *= 2;
        // SpriteRenderer s = other.gameObject.GetComponent<SpriteRenderer>();
        // s.color = Color.blue;
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log($"{this.name} was triggered");
    }
}
