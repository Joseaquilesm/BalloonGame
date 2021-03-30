using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonBehavior : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody2D balloonRB;
    
    private Vector2 screenBoundaries;

    // Start is called before the first frame update
    void Start()
    {
        balloonRB = this.GetComponent<Rigidbody2D>();
        balloonRB.velocity = new Vector2(0,speed);
        screenBoundaries = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > screenBoundaries.y){
            Destroy(this.gameObject);
        }
    }
}
