using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Swipe : MonoBehaviour {

    public GameObject poop;

    private Vector2 v1;
    private Vector2 v2;
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
            v1 = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            Debug.Log("start swipe: "+v1);
        }
        if (Input.GetMouseButtonUp(0))
        {
            v2 = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            Debug.Log("end swipe: " + v2);
            SwipeScreen();
        }
    }


    void SwipeScreen()
    {
        float diferx = v2.x - v1.x;
        float difery = v2.y - v1.y;
        #region convertir dif en positivo
        if (diferx < 0 )
        {
            diferx = diferx * -1;
        }
        if (difery < 0)
        {
            difery = difery * -1;
        }
        Debug.Log("Dif x "+diferx);
        Debug.Log("Dif y " + difery);
        #endregion
        if (difery < .1)
        {
            if (v1.x < v2.x) {
                Debug.Log("caso 1");
            }
            if (v1.x > v2.x)
            {
                Debug.Log("caso 2");
            }
        }
        if (diferx < .1)
        {
            if (v1.y < v2.y)
            {
                Debug.Log("caso 3");
            }
            if (v1.y > v2.y)
            {
                Debug.Log("caso 4");
            }
        }
        if (diferx > .1 && difery > .1)
        {
            if (v1.x < v2.x && v1.y < v2.y)
            {
                Debug.Log("caso 5");
            }
            if (v1.x > v2.x && v1.y > v2.y)
            {
                Debug.Log("caso 6");
            }
            if (v1.x > v2.x && v1.y < v2.y)
            {
                Debug.Log("caso 7");
            }
            if (v1.x < v2.x && v1.y > v2.y)
            {
                Debug.Log("caso 8");
            }
        }
    }
}
