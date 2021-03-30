using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenBoundaries : MonoBehaviour
{
    private Vector2 boundaries;
    public bool isLimit = false;
    

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        boundaries = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 pos= transform.position;
        pos.x = Mathf.Clamp(pos.x, boundaries.x * -1, boundaries.x);
        pos.y = Mathf.Clamp(pos.y, boundaries.y * -1, boundaries.y);
        transform.position = pos;

        if(  (pos.y == boundaries.y || pos.y == (boundaries.y * -1)) && isLimit == false  ){
            isLimit = true;

           death();
          
        }

    }
    void death(){
        animator.SetTrigger("death");
        StartCoroutine(deletion());
    }

    IEnumerator deletion(){
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }
}
