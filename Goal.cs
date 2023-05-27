using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] CharacterController2D player;
    [SerializeField] ReplayAudio ra;
    [SerializeField] GameObject obj;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("GOAL");
            player.goalFlag = true;
            obj.SetActive(true);
        }
    }
}
