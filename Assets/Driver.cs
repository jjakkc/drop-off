using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [Header("[Speed Settings]:")]
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] float steerSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        // use -steerAmount because pressing left = -1 but we want to turn left which requires a positive value
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(new Vector2(0, moveAmount));

        if(Input.GetKeyDown(KeyCode.LeftShift)){
            moveSpeed = moveSpeed * 2;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift)){
            moveSpeed = 10f;
        }
    }
}
