using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if( Input.GetKeyDown ("Mouse 0") ){
            // Text my_text = GameObject.Find("Middleground/Coins/Canvas/score").GetComponent<Text>();
            print ("kena");
            Destroy(this.gameObject);
            GlobalScript.Instance.score += 1;
        }        
    }
}
