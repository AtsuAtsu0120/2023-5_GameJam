using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgraoudImageManager : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Sprite sprite;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            spriteRenderer.sprite = sprite;
            Destroy(transform.gameObject);
        }
    }
}
