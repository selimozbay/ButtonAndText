using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class buttonScript : MonoBehaviour
{

    public TextMeshProUGUI baslik, tur, icerik;
    int rastgeleIndex = 1, eskiIndex = 0;
    public string[] basliklar = 
    {
        "engineer",
        "mother",
        "home",
        "programmer",
        "firefighter",
        "believe",
        "create"
        
    };
    public string[] turler =
    {
        "noun",
        "noun",
        "noun",
        "noun",
        "noun",
        "verb",
        "verb"
        
    };
    public string[] icerikler =
    {
        "one who gets excited about things no one else cares about.",
        "the person who sees the best in you no matter what.",
        "the house, apartment, etc. where you live, especially with your family.",
        "someone who fixes a problem you did not know you had in a way you do not understand.",
        "someone who is fearsless in saving lives, decisive, courageous and determined, a true hero.",
        "to have confidence or faith in the truth existence, reliability or value of something.",
        "to evolve from one's own tought or imaginatiıns, as a work of art or an invention."

        
    };
    void Start() {
        Click();
    }

public void Click() {

    do
    {
        rastgeleIndex = Random.Range(0, basliklar.Length);
    } while (rastgeleIndex == eskiIndex);


    eskiIndex = rastgeleIndex;

    baslik.text = basliklar[rastgeleIndex];
    tur.text = turler[rastgeleIndex];
    icerik.text = icerikler[rastgeleIndex];
}
}
