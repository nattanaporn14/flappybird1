using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigibody;
    public LogicScript logicScript;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();    
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigibody.velocity = Vector2.up * 10;
        }
        
    }
    private void OnCollisionEnter2D()
    {
        logicScript.gameOver();
        birdIsAlive = false;
        
    }
    
}
