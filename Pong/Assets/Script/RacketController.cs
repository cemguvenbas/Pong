using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float limitHorizontal;

    public bool isUp;
    private void Update()
    {
        var input = Input.GetAxis("Horizontal");
        var newPosition = transform.position + (Vector3.right * (input * speed * Time.deltaTime));
        newPosition.x = Mathf.Clamp(newPosition.x, -limitHorizontal, limitHorizontal);

        transform.position = newPosition;
    }
}
