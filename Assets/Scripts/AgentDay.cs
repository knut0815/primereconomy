﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentDay
{
    //Each day will have the time division ratio and number collected of each good
    public int date;
    public float timeAllocationRatio;
    public int numTreesHarvested;
    public int numMangoesHarvested;
    public float utility;

    public AgentDay(int newDate, float ratio)
    {
      date = newDate;
      timeAllocationRatio = ratio;
    }
}
