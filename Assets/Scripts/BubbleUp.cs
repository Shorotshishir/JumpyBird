using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleUp : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float _shootUp = 2.5f;

    private float _moveLeft = 2f;

    private void FixedUpdate()
    {
        transform.position += Time.deltaTime * _shootUp * Vector3.up;
        transform.position += Time.deltaTime * _moveLeft * Vector3.left;
        if (transform.position.y > 10 || transform.position.x > 11)
        {
            transform.position = new Vector3(
                3.3f,
                -4.33f,
                transform.position.z);
        }
    }
}