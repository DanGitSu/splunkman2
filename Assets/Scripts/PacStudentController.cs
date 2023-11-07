using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PacStudentController : MonoBehaviour
{
    public Tweener tweener;
    private Vector3 lastInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            lastInput = new Vector3(0,1,0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            lastInput = new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            lastInput = new Vector3(0, -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            lastInput = new Vector3(1, 0, 0);
        }

        if (!tweener.TweenExists(transform))
        {
            Vector3 flipX = new Vector3(-1, 1, 1);
            target = Vector3.Scale(target, flipX);
            tweener.AddTween(transform, transform.position, target, duration / SpeedManager.SpeedModifier);
        }


        /*if (!tweener.TweenExists(transform))
        {
            Vector3 flipX = new Vector3(-1, 1, 1);
            target = Vector3.Scale(target, flipX);
            tweener.AddTween(transform, transform.position, target, duration / SpeedManager.SpeedModifier);
        }*/
    }
}

