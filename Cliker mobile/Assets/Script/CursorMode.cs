using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMode : MonoBehaviour
{
    Camera cachedCamera;

    void Start() => cachedCamera = Camera.main;

    void Update()
    {
        var worldCursor = cachedCamera.ScreenToWorldPoint(Input.mousePosition + Vector3.forward);
        transform.position = new Vector3(worldCursor.x, worldCursor.y, 0);
    }
}
