// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class NormalEnemy : MonoBehaviour
// {
//     [SerializeField] Transform transform;
//     // Update is called once per frame
//     void Update()
//     {
//         velocity.x = Mathf.MoveTowards(velocity.x, speed * moveInput, acceleration * Time.deltaTime);

//         velocity.y += Physics2D.gravity.y * Time.deltaTime;

//         transform.Translate(velocity * Time.deltaTime);
//     }
// }
