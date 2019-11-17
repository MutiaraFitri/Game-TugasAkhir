using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    Animator charAnimator;
    GameObject attactEffect;
    private Rigidbody2D jump;
    private int countJump=0;

    bool isJumps;
    
    // Start is called before the first frame update
    void Start()
    {
    charAnimator = GetComponent<Animator>(); 
    jump = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionStay2D(Collision2D other) {
        countJump=0;
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
        if ((Input.GetKeyDown(KeyCode.UpArrow)) && (countJump<1))
        {
            jump.AddForce(new Vector3(0f,1f,0f)*10,ForceMode2D.Impulse);
            countJump+=1;
        }
        if(isJumps){
        jump.AddForce(new Vector3(0.0f, 1f, 0.0f)*10f,  ForceMode2D.Impulse);
        isJumps=false;
        }
    }
}
