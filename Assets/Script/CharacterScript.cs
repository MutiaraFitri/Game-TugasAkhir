using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    Animator charAnimator;
    GameObject attactEffect;
    public Rigidbody2D jump;

    bool isJumps;
    
    // Start is called before the first frame update
    void Start()
    {
    charAnimator = GetComponent<Animator>(); 
    jump = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        // jika ingin jalaan maka pakai bool jika di lepas false
        //player jalan ke kiri
        if(Input.GetKey(KeyCode.LeftArrow))
        {
        charAnimator.SetBool("isWalk",true);
        charAnimator.transform.Translate(-0.1f,0,0);
        }
        if(Input.GetKeyUp(KeyCode.LeftArrow))
        {
        charAnimator.SetBool("isWalk",false);
        charAnimator.transform.Translate(0f,0,0);
        }
        //player jalan ke kanan
        if(Input.GetKey(KeyCode.RightArrow))
        {
        charAnimator.SetBool("isWalk",true);
        charAnimator.transform.Translate(0.1f,0,0);
        }
        if(Input.GetKeyUp(KeyCode.RightArrow))
        {
        charAnimator.SetBool("isWalk",false);
        charAnimator.transform.Translate(0f,0,0);
        }
        // player lompat 
        // get key down hanya bisa dipakai sekali saja, get key bisa dipakai ditahan
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
        isJumps=true;
        charAnimator.SetTrigger("isJump");
        }
        if(isJumps){
        jump.AddForce(new Vector3(0.0f, -100.0f, 0.0f)*10f,  ForceMode2D.Impulse);
        isJumps=false;
        }
    }
}
