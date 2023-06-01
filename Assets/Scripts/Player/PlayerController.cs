using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//<>
public class PlayerController : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private SpriteRenderer spriterender;
    // Start is called before the first frame update
    private Rigidbody2D rig;
    private void Awake(){
        rig=GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate(){

        float horizontal =Input.GetAxis("Horizontal");
        float vertical =Input.GetAxis("Vertical");
        rig.velocity= new Vector2(horizontal,vertical)*speed;
        if (horizontal < 0){
            spriterender.flipX= true;}
        else if(horizontal > 0){
            spriterender.flipX= false;
        }
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        /*var playerSR = GetComponent<SpriteRenderer>();
        if (Input.GetKey(KeyCode.D)){
            if (playerSR.flipX){
                playerSR.flipX = false;
            }
            var currentPos = transform.position;
            currentPos.x+=speed;       
            transform.position = currentPos;
        }
        if (Input.GetKey(KeyCode.A)){
            if (!playerSR.flipX){
                playerSR.flipX = true;
            }
            var currentPos = transform.position;
            currentPos.x-=speed;       
            transform.position = currentPos;
        }
        if (Input.GetKey(KeyCode.W)){
            var currentPos = transform.position;
            currentPos.y+=speed;       
            transform.position = currentPos;
        }
        if (Input.GetKey(KeyCode.S)){
            var currentPos = transform.position;
            currentPos.y-=speed;       
            transform.position = currentPos;
        }
*/
    }
}
