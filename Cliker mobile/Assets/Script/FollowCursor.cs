using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCursor : MonoBehaviour
{

    void Update()
    {
        Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = Vector3.Lerp(transform.up, (mousepos - new Vector2(transform.position.x, transform.position.y)), Time.deltaTime);
    }
}
