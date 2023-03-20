using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float limitHorizontal;

    public bool isUp;
    [SerializeField] private bool isPlayer;

    private void Update()
    {
        Vector3 newPosition = transform.position;
        if (isPlayer)
        {
            var input = Input.GetAxis("Horizontal");
            newPosition = transform.position + (Vector3.right * (input * speed * Time.deltaTime));
            
        }
        else
        {
            var ai = BallController.Instance.transform.position.x;
            newPosition.x = ai;
        }

        newPosition.x = Mathf.Clamp(newPosition.x, -limitHorizontal, limitHorizontal);
        transform.position = newPosition;
    }
}
