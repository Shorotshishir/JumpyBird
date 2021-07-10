using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField]
    private float _speed = 2f;

    [SerializeField]
    private float _randomOffset = 0f;

    private void FixedUpdate()
    {
        transform.position += Time.deltaTime * _speed * Vector3.left;
        if (transform.position.x <= -10)
        {
            if (_randomOffset == 0)
            {
                transform.position = new Vector3(10f, transform.position.y, transform.position.z);
            }
            else
            {
                var randomHeight = Random.Range(-_randomOffset, _randomOffset);
                transform.position = new Vector3(10f, randomHeight, transform.position.z);
            }
        }
    }
}