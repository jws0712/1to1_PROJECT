using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public Vector3 screenPos;
    public Vector3 worldPos;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        screenPos = Input.mousePosition;
        screenPos.z = Camera.main.nearClipPlane + 1;

        worldPos = Camera.main.ScreenToWorldPoint(screenPos);

        transform.position = worldPos;
    }
}
