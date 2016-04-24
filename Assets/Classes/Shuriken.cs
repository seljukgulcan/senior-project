﻿using UnityEngine;
using System.Collections;

public class Shuriken : MonoBehaviour {
	private const float RANGE = 10;
	private Vector2 startingPoint;

	void Start() {
		startingPoint = transform.position;
	}

	void Update() {
		if(Vector2.Distance(transform.position, startingPoint) > RANGE) {
			Destroy(gameObject);
		}
	}

    void OnTriggerEnter2D(Collider2D col) {
        if(col.gameObject.layer == LayerMask.NameToLayer("Obstacle")) {
			Sound.GenerateSound(transform.position, 2);
			Destroy(gameObject);
		}
    }
}