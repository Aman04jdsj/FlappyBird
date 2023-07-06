using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isPaused = false;
    private float currentTimeScale;
    public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (isPaused) {
                unPause();
            } else {
                pause();
            }
            callPauseHUD();
        }
    }

    public void pause() {
        currentTimeScale = Time.timeScale;
        Time.timeScale = 0;
        isPaused = true;
    }

    public void unPause() {
        Time.timeScale = currentTimeScale;
        isPaused = false;
    }

    void callPauseHUD(){
        logic.pause(isPaused);
    }
}
