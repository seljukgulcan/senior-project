﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// Interface between Gameplay and AI classes. Gameplay adds and event, AI takes event and evaluates
/// </summary>
public class EventManager {

    /// <summary>
    /// Adds an event. It should be used where type of event is not known otherwise related method should be used.
    /// </summary>
    /// <param name="gameEvent">GameEvent to be added</param>
    public static void AddEvent( GameEvent gameEvent) {

        //TODO: Implement
        return;
    }

    /// <summary>
    /// Removes and retrieves an event.
    /// </summary>
    /// <returns>GameEvent to be returned</returns>
    public static GameEvent RemoveEvent() {

        //TODO: Implement
        return null;
    }

    public static Action Spot( SpotEvent gameEvent) {

        Vector2 pos = gameEvent.Source.transform.position;
        ApproachAction actionToReturn = new ApproachAction( pos, gameEvent.Location);
        return actionToReturn;
    }
}
