using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlip : MonoBehaviour
{
    [SerializeField] SpriteRenderer _spriteRenderer;

    public void FlipSprite(Vector2 axis) => _spriteRenderer.flipX = axis.x > 0;
}
