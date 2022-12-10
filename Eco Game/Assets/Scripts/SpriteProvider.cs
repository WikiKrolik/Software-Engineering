using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class SpriteProvider : MonoBehaviour
    {

        private SpriteRenderer spriteRenderer;

        // Use this for initialization
        void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        // Update is called once per frame
        void Update()
        {
            if (gameObject.name == "PlayerController")
            {
                spriteRenderer.sprite = null;
            }
        }
    }
}