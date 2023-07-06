using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidBody;
    public float flapSpeed;
    public LogicScript logic;
    public bool isAlive = true;
    public float lowerDeadZone = -20;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < lowerDeadZone) {
            endGame();
        }
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            birdRigidBody.velocity = Vector2.up * flapSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        endGame();
    }

    private void endGame() {
        logic.gameOver();
        isAlive = false;
    }
}
