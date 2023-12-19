using UnityEngine;

public class PlayerMoveMobile : MonoBehaviour
{
    Camera cachedCamera;

    void Start() => cachedCamera = Camera.main;

    void FixedUpdate()
    {
        var worldCursor = cachedCamera.ScreenToWorldPoint(Input.mousePosition + Vector3.forward);
        transform.position = new Vector3(worldCursor.x, worldCursor.y, 0);
    }

}
