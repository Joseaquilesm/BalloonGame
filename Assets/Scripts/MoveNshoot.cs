using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNshoot : MonoBehaviour
{

    private Vector2 initialPosition;
    private int left = 99;

    public Transform player;
    public Transform joystick;
    public Transform joystickCentro;
    public float speed = 5.0f;

    public GameObject laserPrefab;
    public GameObject alien;
  


    // Start is called before the first frame update
    void Start()
    { 
       
        
    }

    // Update is called once per frame
    void Update()
    {

       
          int i = 0;
        while(i < Input.touchCount && player != null ){
            Touch touch = Input.GetTouch(i);
            Vector2 touchPosition = positionConversion(touch.position);

            //add switch case of types of touches

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if(touch.position.x > Screen.width / 2){
                        shootLaser();
                    }else{
                        left = touch.fingerId;
                        initialPosition = touchPosition;
                    }
                break;

                case TouchPhase.Moved: 

                    if(left == touch.fingerId){
                        Vector2 currentPosition = touchPosition - initialPosition;
                        Vector2 direction = Vector2.ClampMagnitude(currentPosition,1.0f);
                    
                        movement(direction);
                        joystickCentro.transform.position = new Vector2(joystick.position.x + direction.x, joystick.transform.position.y + direction.y);

                    }

                break;


                case TouchPhase.Ended: 
                    if(left == touch.fingerId){
                        left = 99;
                    }

                break;
            }
         

            i++;
        }

         if(player == null && joystick != null && joystickCentro != null){
             Destroy(joystick.gameObject);
             Destroy(joystickCentro.gameObject);
        }
        
    }

    void FixedUpdate(){

    }
    Vector2 positionConversion(Vector2 fingerPosition){
        return GetComponent<Camera>().ScreenToWorldPoint(new Vector3(0,fingerPosition.y,transform.position.z));
    }


    void movement(Vector2 direction){
        player.Translate(direction * speed * Time.deltaTime);
    }
    void shootLaser(){
        GameObject laser = Instantiate(laserPrefab) as GameObject;
        if(player != null){
        laser.transform.position = player.transform.position;
        
        }
       
    }
}
