using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Swipe : MonoBehaviour {

    public GameObject poop;

    private Vector2 startSwipe;
    private Vector2 endSwipe;

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
        poop.transform.localScale += new Vector3(0, 0.05f, 0);
        Debug.Log(poop.transform.localScale);

        Vector2 swipe = endSwipe - startSwipe;

        
    }
}
