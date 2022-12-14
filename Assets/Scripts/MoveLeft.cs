using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float speed = 2.5f;
    [SerializeField] private float randomOffset = 2f;

    private void Update()
    {
        transform.position += Time.deltaTime * speed * Vector3.left;
        if(transform.position.x <= -15)
        {
            if(randomOffset ==0)
            {
                transform.position = new Vector3(15, transform.position.y, transform.position.z);

            }
            else
            {
                float randomY = Random.Range(-randomOffset, randomOffset);
                transform.position = new Vector3(15, randomY, transform.position.z);
            }
            
        }
        
    }
}
