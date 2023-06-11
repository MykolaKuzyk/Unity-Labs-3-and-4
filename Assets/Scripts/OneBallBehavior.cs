using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneBallBehavior : MonoBehaviour
{
    public float XRotation = -2;
    public float YRotation = 1;
    public float ZRotation = 0;
    public float DegreesPerSecond = 180;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(761- Random.value *6, 359 - Random.value*6, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 axis = new Vector3(XRotation, YRotation, ZRotation);
        transform.RotateAround(new Vector3(761, 357, 0), axis, DegreesPerSecond * Time.deltaTime);

        //Debug.DrawRay(new Vector3(761, 359, 0), axis, Color.yellow);
    }
    void OnMouseDown()
    {
        GameController controller = Camera.main.GetComponent<GameController>();
        if (!controller.GameOver)
        {
            controller.ClickedOnBall();
            Destroy(gameObject);
        }
    }
}
