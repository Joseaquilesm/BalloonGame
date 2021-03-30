using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonSpawn : MonoBehaviour
{
    public GameObject balloon;
    public float respawn = 1.0f;

    private Vector2 screenBoundaries;

    // Start is called before the first frame update
    void Start()
    {
         screenBoundaries = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
         StartCoroutine(balloonWave());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnBalloon(){
        GameObject obj = Instantiate(balloon) as GameObject;
        obj.transform.position = new Vector2(Random.Range(-2.35f, screenBoundaries.x),screenBoundaries.y * -2);
    }

    IEnumerator balloonWave(){
        while(true){
            yield return new WaitForSeconds(respawn);
            spawnBalloon();
        }
        
    }

}
