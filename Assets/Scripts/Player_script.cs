using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_script : MonoBehaviour
{
    [SerializeField]
    private float _player_speed = 5.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        // Cureent Position
        transform.position = new Vector3(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
       
    }

    void PlayerMovement()
    {
        // Inputs value 
        float horizentalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Player Movement
        Vector3 direction = new Vector3(horizentalInput, verticalInput, 0);

        transform.Translate(direction * _player_speed * Time.deltaTime);

        // Player clamped on Y-axis
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.8f, 5.0f), 0);


     
        // Player wrapping
        if (transform.position.x > 11.3f)
        {
            transform.position = new Vector3(-11.3f, transform.position.y, 0);
        }
        else if (transform.position.x < -11.3f)
        {
            transform.position = new Vector3(11.3f, transform.position.y, 0);
        }
    }
}
