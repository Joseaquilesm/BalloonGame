using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class laserBehavior : MonoBehaviour
{

    
    public float speed = 10.0f;

    private Rigidbody2D laserRB;
    private Vector2 screenBoundaries; 
    
    private heliumScore helium;


    // Start is called before the first frame update
    void Start()
    {
        helium = GameObject.FindWithTag("Canvas").GetComponent<heliumScore>();
        laserRB = this.GetComponent<Rigidbody2D>();
        laserRB.velocity = new Vector2(speed, 0);
        screenBoundaries = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > screenBoundaries.x * 2){
            Destroy(this.gameObject);
        }
    }

    //collision
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "balloon"){
           // helium ++;
          //  heliumText.text =helium.ToString();
            helium.addScore(1);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);

        }else if (collision.tag =="blueBalloon"){
           // helium = helium + 10;
           // heliumText.text =helium.ToString();
            helium.addScore(10);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    
     
    }
}
