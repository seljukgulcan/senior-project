﻿using UnityEngine;
using System.Collections;

public class Guardian : Enemy, ISpotable, IApproachable {
    public GameObject exclamationPrefab;

    public void Approach(Vector2 target) {
        float moveSpeed = 1;
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(target.x, transform.position.y), Time.deltaTime * moveSpeed);
    }

    public void Spot(GameObject obj) {
        Player player = obj.GetComponentInParent<Player>();
        if (player != null) {
            Exclamation ex = ((GameObject)Instantiate(exclamationPrefab,
                new Vector2(transform.position.x, transform.position.y + 1),
                Quaternion.identity)).GetComponent<Exclamation>();
            ex.transform.SetParent(gameObject.transform);
            ex.type = ExclamationType.Alerted;
			actionQueue.Insert(reactionAI.React(new GameEvent(player.midPoint, GameEventType.EnemySpotted)));
            return;
        }
        Rock rock = obj.GetComponent<Rock>();
        if (rock != null) {
            if (rock.state != RockState.Ended)
                return;
            Exclamation ex = ((GameObject)Instantiate(exclamationPrefab,
                new Vector2(transform.position.x, transform.position.y),
                Quaternion.identity)).GetComponent<Exclamation>();
            ex.transform.SetParent(gameObject.transform);
            ex.type = ExclamationType.Suspicious;
            return;
        }
    }
}