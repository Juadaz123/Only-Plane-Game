using UnityEngine;

public class LimitPlayer : MonoBehaviour
{
    private Vector2 bottomLimit;
    private Vector2 topLimit;
    private float heightPlayer;
    private float widthPlayer;

    private void Start()
    {
        Vector3 minScreen = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        Vector3 maxScreen = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

        bottomLimit = new Vector2(minScreen.x, minScreen.y);
        topLimit = new Vector2(maxScreen.x, maxScreen.y);

        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if(spriteRenderer != null)
        {
            widthPlayer = spriteRenderer.bounds.size.x / 2;
            heightPlayer = spriteRenderer.bounds.size.y / 2;
        }
    }

    private void LateUpdate()
    {
        Vector3 screenPos = transform.position;

        screenPos.x = Mathf.Clamp(screenPos.x, bottomLimit.x + widthPlayer, topLimit.x - widthPlayer);
        screenPos.y = Mathf.Clamp(screenPos.y, bottomLimit.y + heightPlayer, topLimit.y - heightPlayer);

        transform.position = screenPos;
    }
}