using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    private bool hasDelivered;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool getDelivered() {
        return hasDelivered;
    }

    public void setDelivered(bool delivered){
        hasDelivered = delivered;
    }
}
