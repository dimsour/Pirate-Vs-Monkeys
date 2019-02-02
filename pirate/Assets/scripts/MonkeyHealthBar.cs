using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MonkeyHealthBar : MonoBehaviour {

    public float fillAmount;
    public float tempHealth;
    public float maxHealth;
    
    public monkey monkeyScript;
    public Image content;

    void Update ()
    {
        tempHealth = monkeyScript.tempHealth;
        maxHealth = monkeyScript.maxHealth;
        fillAmount = tempHealth / maxHealth;
        content.fillAmount = fillAmount;

	}
}
