using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class heliumScore : MonoBehaviour
{

    public Text heliumText;

    public int helium;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addScore(int heliumPoints){

        helium += heliumPoints;

        heliumText.text = helium.ToString();
    }
}
