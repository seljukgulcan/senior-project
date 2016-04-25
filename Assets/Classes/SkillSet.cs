﻿using UnityEngine;
using System.Collections;

public class SkillSet {
	public Skill[] skills { get; set; }
	public int selectedSkill { get; set; }

	private Player player;

	public SkillSet() {
		player = Player.instance;
		skills = new Skill[6];
        skills[0] = new ShurikenSkill();
        skills[1] = new ShurikenSkill();
        skills[2] = new ShurikenSkill();
        skills[3] = new ShurikenSkill();
        skills[4] = new ShurikenSkill();
        skills[5] = new ShurikenSkill();
		selectedSkill = 0;
	}

	public void Cast(Vector2 target) {
		if (skills[selectedSkill] == null)
			return;
		if (skills[selectedSkill].charges > 0) {
			skills[selectedSkill].Cast(target);
			skills[selectedSkill].charges--;
		}
	}
}