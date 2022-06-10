using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0, 0, 2);
        // transform.position = new Vector2(0, 2) * Time.deltaTime;
        // transform.Translate(new Vector2(2, 0) * speed * Time.deltaTime);
        transform.Rotate(new Vector3(0, 0, 10) * speed * Time.deltaTime);
        transform.Translate(new Vector2(0, 2) * speed * Time.deltaTime);
    }
}
