using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{

    public static HealthDisplay Instance;
    public TextMeshProUGUI healthText;
    private int health = 5;

    void Start()
    {
 
        healthText.text = health.ToString();
    }
    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void UpdatehealthText(int newhealth)
    {
        healthText.text = newhealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
