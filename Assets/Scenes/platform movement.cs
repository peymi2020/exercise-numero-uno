using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformmovement : MonoBehaviour
{
    private Vector2 startPosition;
    private Vector2 newPosition;


    // Start is called before the first frame update
    void Start()
    {
      float speed = 10f;  
      startPosition = transform.position;
      newPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.UpArrow)){
          this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
       }
       if(Input.GetKey(KeyCode.LeftArrow)){
          this.transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
          this.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
         newPosition.x = startPosition.x + (maxDistance * Mathf.Sin(Time.time * speed));
    transform.position = newPosition;
}
}