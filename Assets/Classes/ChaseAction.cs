﻿using UnityEngine;
using System.Collections;

public class ChaseAction : Action {
	Player player;

	public ChaseAction(Player player) {
		this.player = player;
	}

	public override void Execute(Enemy enemy) {
		enemy.Approach(player.midPoint);
	}
}
