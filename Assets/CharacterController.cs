using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 0.2f;
        float v = Input.GetAxisRaw("Vertical");
        gameObject.transform.position = new Vector2(transform.position.x - (v * speed),0);
    }
}
