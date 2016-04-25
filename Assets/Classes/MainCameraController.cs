﻿using UnityEngine;
using System.Collections;

public class MainCameraController : MonoBehaviour {
    Vector3 mouseRelativeToPlayer;
    Vector3 targetPos;
    void Update () {
        mouseRelativeToPlayer = Camera.main.ScreenToWorldPoint(Input.mousePosition)
            - transform.parent.position;
        mouseRelativeToPlayer = new Vector3(mouseRelativeToPlayer.x, mouseRelativeToPlayer.y, transform.position.z);
        targetPos = Vector3.Lerp(new Vector3(0, 0, transform.position.z), mouseRelativeToPlayer,
            Input.GetKey(KeyCode.LeftShift) ? 0.5f : 0.25f);
        transform.localPosition = Vector3.Lerp(transform.localPosition, targetPos, 0.3f);
	}
}
