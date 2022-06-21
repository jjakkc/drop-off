using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private bool hasPackage;

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log($"{this.name} hit {other.gameObject.name} at {other.GetContact(0)}");
        Debug.Log($"Hit: {other.contactCount}");
        if(other.gameObject.tag == "Collidable"){
            Driver driver = GetComponent<Driver>();
            driver.loseHealth(10);
            Debug.Log(driver.getHealth());
        }
        // other.transform.localScale *= 2;
        // SpriteRenderer s = other.gameObject.GetComponent<SpriteRenderer>();
        // s.color = Color.blue;
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Package" && hasPackage == false){
            Debug.Log($"{other.gameObject.name} was triggered");
            hasPackage = true;
            Destroy(other.gameObject);
        }
        if(other.tag == "Customer" && hasPackage){
            hasPackage = false;
            SpriteRenderer customerSprite = other.gameObject.GetComponent<SpriteRenderer>();
            customerSprite.color = Color.green;
            Customer customer = other.gameObject.GetComponent<Customer>();
            customer.setDelivered(true);
            Debug.Log(customer.getDelivered());
        }
    }
}
