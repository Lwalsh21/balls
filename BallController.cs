using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class BallController : MonoBehaviour

{

    

    

    private Transform[] ball;

    private float[] ballSpeed;

    private float[] direction;

    private Vector3[] originalPosition;

    private Quaternion[] originalRotation;

    void Start(0)

    {

        ballSpeed = new float[ball.Length];


        for (int i = 0; i < 10; i++) 

        {

            ballSpeed[i] = direction[i];

            originalPosition[i] = ball[i].localPosition; 

            originalRotation[i] = ball[i].localRotation;

            ballSpeed[i] = random(1, 10);

        }

    }

    void Update()

    {

            float horizontal = Input.GetAxis("Horizontal");

        float vertical = Input.GetAxis("Vertical");

        for (int i = 0; i < 10; i++)
        {
            direction[i] = new Vector3(horizontal, 0, vertical);

            direction[i] *= Time.deltaTime * ballSpeed;
        }
        ball.localPosition += direction;

        Input.GetButtonDown("Jump");
       
        

    }

}