using UnityEngine;

public class SpriteSwapper : MonoBehaviour
{
    // Assign your different sprites in the Inspector
    public Sprite newSprite1;
    public Sprite newSprite2;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Call this method to change the sprite
    public void ChangeToNewSprite1()
    {
        if (spriteRenderer != null && newSprite1 != null)
        {
            spriteRenderer.sprite = newSprite1;
        }
    }

    public void ChangeToNewSprite2()
    {
        if (spriteRenderer != null && newSprite2 != null)
        {
            spriteRenderer.sprite = newSprite2;
        }
    }
}
