using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -70;
    public BirdScript bird;
    // Start is called before the first frame update
    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bird.isAlive) {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            if (transform.position.x < deadZone) {
                Destroy(gameObject);
            }
        }
    }
}
