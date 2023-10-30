using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movimiento : MonoBehaviour
{
    [SerializeField] private GameObject camera;
    [SerializeField] private float speed = 12.5f;
    [SerializeField] private float verticalSpeed = 10f;
    [SerializeField] private Vector3 offset = new Vector3(x: 22, y: 0, z: 0);
    [SerializeField] private float rotateSpeed = 50f;
    
    
    

    private float verticalinput;



    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        verticalinput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        transform.Translate(Vector3.up * Time.deltaTime * verticalSpeed * verticalinput);

        transform.Rotate(Vector3.left * rotateSpeed * Time.deltaTime * verticalinput);

        camera.transform.position = transform.position + offset;

        if (transform.position.z >= 250)
        {
            Debug.Log(message:$"Has Ganado");
        }


    }
}
