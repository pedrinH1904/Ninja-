using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerTest : MonoBehaviour


 {
        public float moveH;
        public int velocidade;
        public int forcaPulo;

        private Rigidbody2D rb;
        private Animator anim;
        private SpriteRenderer sprite;
        public bool isJumping = false;
        public bool comVida = true;
    
    
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            anim = GetComponent<Animator>();
            sprite = GetComponent<SpriteRenderer>();
        }
    
        private void FixedUpdate()
        {
            //Andar
            moveH = Input.GetAxis("Horizontal"); // -1 a 1
        
            transform.position += new Vector3(moveH * velocidade * Time.deltaTime, 0, 0);
        }
    
        // Update is called once per frame
        void Update()
        {
            
            //Animação Andar
            if(Input.GetKey(KeyCode.D) && moveH > 0)
            {
                sprite.flipX = false;
                anim.SetLayerWeight(1,1);
                //anim.SetLayerWeight(0,0);
            
            
            }
        
            if(Input.GetKey(KeyCode.A) && moveH < 0)
            {
                sprite.flipX = true;
                anim.SetLayerWeight(1,1);
                //anim.SetLayerWeight(0,0);
            }
        
            if(moveH == 0)
            {
                anim.SetLayerWeight(0,1);
                //anim.SetLayerWeight(1,0);
            
            }
        
    
            //Pular
            if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
            {
                rb.AddForce(transform.up * forcaPulo,ForceMode2D.Impulse);
                isJumping = true;
    
            }
        
        }
    
        private void OnCollisionEnter2D(Collision2D other)
        {
            if(other.gameObject.CompareTag("Chão"))
            {
                isJumping = false;
            }
        
        }
    }