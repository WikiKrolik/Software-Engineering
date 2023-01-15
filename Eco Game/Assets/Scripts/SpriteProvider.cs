using UnityEngine;

namespace Assets.Scripts
{
    public class SpriteProvider : MonoBehaviour
    {

        private SpriteRenderer spriteRenderer = default!;

        // Use this for initialization
        void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        // Update is called once per frame
        void Update()
        {
            Analyzer analyzer= GetComponent<Analyzer>();
            if (analyzer is not null)
            {
                spriteRenderer.sprite = analyzer.AnalyzeDirection();
            }
        }
    }
}