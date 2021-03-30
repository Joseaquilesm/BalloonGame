using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    /*
 
     public Transform player;
    public float speed = 5.0f;
    private bool touching = false;
    private Vector2 initialPosition;
    private Vector2 endingPosition;

    public Joystick joystick;

    public GameObject laserPrefab;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       // movement(new Vector2(0, Input.GetAxis("Vertical")));

       if(Input.GetMouseButtonDown(0)){
           initialPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
       }
       if(Input.GetMouseButton(0)){
           touching = true; 
           endingPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
       }else{
           touching = false;
       }
        
      if(Input.GetKeyDown("space")){
          shoot();
      }

    }

   private void FixedUpdate(){
       if(touching){
           Vector2 currentPosition =  endingPosition - initialPosition;
           Vector2 direction = Vector2.ClampMagnitude(currentPosition, 1.0f);
           movement(direction);
       }
   }

    void movement(Vector2 direction){
        direction.x=0;
        player.Translate(direction * speed * Time.deltaTime);
    }



    public void shoot(){
        GameObject laser = Instantiate(laserPrefab) as GameObject;
        laser.transform.position = player.transform.position;
    }
    */

}
