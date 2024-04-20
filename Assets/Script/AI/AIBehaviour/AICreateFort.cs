using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICreateFort : AICreateHQ
{
    // Start is called before the first frame update
    void Start()
    {
        support = gameObject.GetComponent<AISupport>();

        buildingPrefab = support.Faction.BuildingPrefabs[3];
        buildingGhostPrefab = support.Faction.GhostBuildingPrefabs[3];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool CheckIfAnyUnfinishedHouseAndBarrackAndFort()
    {
        foreach (GameObject houseObj in support.Houses)
        {
            Building h = houseObj.GetComponent<Building>();

            if (!h.IsFunctional && (h.CurHP < h.MaxHP)) //This house is not yet finished
                return true;
        }

        foreach (GameObject barrackObj in support.Barracks)
        {
            Building b = barrackObj.GetComponent<Building>();

            if (!b.IsFunctional && (b.CurHP < b.MaxHP)) //This barrack is not yet finished
                return true;
        }

        foreach (GameObject fortObj in support.Fort)
        {
            Building f = fortObj.GetComponent<Building>();

            if (!f.IsFunctional && (f.CurHP < f.MaxHP)) //This fort is not yet finished
                return true;
        }

        return false;
    }

    public override float GetWeight()
    {
        Building f = buildingPrefab.GetComponent<Building>();

        if (!support.Faction.CheckBuildingCost(f)) //Don't have enough resource to build a barrack
            return 0;

        if (CheckIfAnyUnfinishedHouseAndBarrackAndFort()) //Check if there is any unfinished house or barrack
            return 0;

        if (support.Barracks.Count < 2 && support.Houses.Count > 0 && support.Fort.Count < 2) // If there are less than 2 barracks and there are some houses
            return 2;

        return 0;
    }


}
