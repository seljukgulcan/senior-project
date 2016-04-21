﻿using UnityEngine;
using System.Collections;

public class ChaseAction : Action {
	Player player;

	public ChaseAction(Player player) {
		this.player = player;
	}
    public ChaseAction()
    {
        this.player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

	public override void Execute(Enemy enemy) {

        IApproachable movingObj = (IApproachable)enemy;
        enemy.actionQueue.Insert(new ApproachAction(enemy.transform.position, AIController.lastKnownPosition));
        //movingObj.Approach(AIController.lastKnownPosition);


	}
}