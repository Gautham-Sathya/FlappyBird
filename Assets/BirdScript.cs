using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D myRB;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public Animator anim;
    void Start()
    {

        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        anim.GetComponent<Animator>().enabled = true;
    }
    void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive)
            { 
            myRB.velocity = Vector2.up * flapStrength;
     
        }
            if(myRB.position.y>17||myRB.position.y<-17)
        {
            logic.gameOver();
            birdIsAlive=false;
        }
        {

        }
        }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
