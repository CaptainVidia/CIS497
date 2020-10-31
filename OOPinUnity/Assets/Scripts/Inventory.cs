using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    [SerializeField] private Inventoryitem item;
    public List<Inventoryitem> inventory;
    // Use this for initialization
    void Start()
    {
        item = new Inventoryitem();
        inventory = new List<Inventoryitem>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
