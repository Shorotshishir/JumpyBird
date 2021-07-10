using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField]
    private float scrollSpeed = 5f;

    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void FixedUpdate()
    {
        var currentTextureOffset = _renderer.material.GetTextureOffset("_BaseMap");
        var distanceToScrollLeft = Time.deltaTime * scrollSpeed;
        var newXoffset = currentTextureOffset.x + distanceToScrollLeft;

        var newOffset = new Vector2(newXoffset, currentTextureOffset.y);
        _renderer.material.SetTextureOffset("_BaseMap", newOffset);
    }
}