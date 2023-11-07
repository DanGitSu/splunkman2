using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PacStudentController : MonoBehaviour
{
    public Tweener tweener;
    private Vector3 lastInput;
    private float duration = 0.5f;

    int[,] levelMap =
            {
            {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
            {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
            {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
            {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
            {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
            {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
            {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
            {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
            {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
            {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
            {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
            {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
            {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
            {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
            {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
            };


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            lastInput = new Vector3(0,0.5f,0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            lastInput = new Vector3(-0.5f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            lastInput = new Vector3(0, -0.5f, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            lastInput = new Vector3(0.5f, 0, 0);
        }

        //if (transform.position == )
        if (!tweener.TweenExists(transform))
        {
            tweener.AddTween(transform, transform.position, transform.position + lastInput, duration);
        }

    }
}

