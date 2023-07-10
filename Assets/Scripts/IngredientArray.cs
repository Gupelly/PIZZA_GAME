using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "IngredientArray")]
public class IngredientArray : ScriptableObject

{
    [SerializeField] private GameObject pepperoni;
    [SerializeField] private GameObject bacon;
    [SerializeField] private GameObject shrimps;
    [SerializeField] private GameObject cucumber;
    [SerializeField] private GameObject tomato;
    [SerializeField] private GameObject olives;
    [SerializeField] private GameObject mushroom;
    [SerializeField] private GameObject onion;
    [SerializeField] private GameObject greens;

    public Ingredient[] IngredientsList { get; private set; }
    private void Start()
    {
        IngredientsList = new[]
        {
        new Ingredient("Pepperoni", new GameObject(), true, "red"),
        new Ingredient("Bacon", new GameObject(), true, "red"),
        new Ingredient("Shrimps", new GameObject(), true, "red"),
        new Ingredient("Cucumber", new GameObject(), false, "green"),
        new Ingredient("Tomato", new GameObject(), false, "red"),
        new Ingredient("Olives", new GameObject(), false, "black"),
        new Ingredient("Mushroom", new GameObject(), false, "white"),
        new Ingredient("Onion", new GameObject(), false, "purple"),
        new Ingredient("Greens", new GameObject(), false, "green"),};
    }
    

}
