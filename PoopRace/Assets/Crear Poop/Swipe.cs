using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Swipe : MonoBehaviour {

    public GameObject poop;

    private Vector2 startSwipe;
    private Vector2 endSwipe;
    private int caso = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            startSwipe = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            Debug.Log("start swipe: "+startSwipe);
        }
        if (Input.GetMouseButtonUp(0))
        {
            endSwipe = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            Debug.Log("end swipe: " + endSwipe);
            SwipeScreen();
        }
    }


    void SwipeScreen()
    {
        //validacion caso 1 y 2
        if (startSwipe.y == endSwipe.y || startSwipe.y == endSwipe.y + 0.1 || startSwipe.y == endSwipe.y - 0.1)
        {
            if (startSwipe.x < endSwipe.x)
            {
                caso = 1;
            }
            if (startSwipe.x > endSwipe.x)
            {
                caso = 2;
            }
            else {
                caso = 0;
            }
        }
        //validacion caso 3 y 4
        if (startSwipe.x == endSwipe.x || startSwipe.x == endSwipe.x + 0.1 || startSwipe.x == endSwipe.x - 0.1)
        {
            if (startSwipe.y < endSwipe.y)
            {
                caso = 3;
            }
            if (startSwipe.y > endSwipe.y)
            {
                caso = 4;
            }
            else {
                caso = 0;
            }
        }
        //validacion caso 5 y 8
        if (startSwipe.x < endSwipe.x)
        {
            if (startSwipe.y < endSwipe.y)
            {
                caso = 5;
            }
            if (startSwipe.y > endSwipe.y)
            {
                caso = 8;
            }
        }
        //validacion caso 6 y 7
        if (startSwipe.x > endSwipe.x)
        {
            if (startSwipe.y < endSwipe.y)
            {
                caso = 7;
            }
            if (startSwipe.y > endSwipe.y)
            {
                caso = 6;
            }
        }
        Debug.Log("caso = " + caso);
    }
}
