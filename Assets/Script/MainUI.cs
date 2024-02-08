using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainUI : MonoBehaviour
{
    [SerializeField]
    private GameObject selectionMaker;
    public GameObject SelectionMaker { get { return selectionMaker; } }

    [SerializeField] private TextMeshProUGUI unitCountText;
    [SerializeField] private TextMeshProUGUI foodText;
    [SerializeField] private TextMeshProUGUI woodText;
    [SerializeField] private TextMeshProUGUI glodText;
    [SerializeField] private TextMeshProUGUI stoneText;

    public static MainUI instance;

    public void UpdateAllResource(Faction faction)
    {
        unitCountText.text = faction.AliveUnits.Count.ToString();
        foodText.text = faction.Food.ToString();
        woodText.text = faction.Wood.ToString();
        goldText.text = faction.Gold.ToString();
        stoneText.text = faction.Stone.ToString();
    }

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
