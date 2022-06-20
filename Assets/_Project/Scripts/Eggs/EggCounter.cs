using UnityEngine;
using TMPro;

public class EggCounter : MonoBehaviour
{
    int countr;
    TextMeshProUGUI tmp;
    void Start() => tmp = GetComponent<TextMeshProUGUI>();
    void Update() => tmp.text = countr.ToString() + "/3";
    public void Add() => countr++;
}