#nullable enable

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
            Move move= GetComponent<Move>();
            if (move.getDirection() == "up")
            {
                Sprite uparrow = Resources.Load<Sprite>("uparrow");
                spriteRenderer.sprite = uparrow;
            }
            if (move.getDirection() == "down")
            {
                Sprite uparrow = Resources.Load<Sprite>("downarrow");
                spriteRenderer.sprite = uparrow;
            }
            if (move.getDirection() == "right")
            {
                Sprite uparrow = Resources.Load<Sprite>("rightarrow");
                spriteRenderer.sprite = uparrow;
            }
            if (move.getDirection() == "left")
            {
                Sprite uparrow = Resources.Load<Sprite>("leftarrow");
                spriteRenderer.sprite = uparrow;
            }
        }
    }
}