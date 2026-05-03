using UnityEngine;
using System.Collections;


public class soru_ui : MonoBehaviour
{
    public GameObject soru1;
    public GameObject soru2;
    public GameObject soru3;
    public GameObject soru4;
    public GameObject soru5;
    public GameObject soru6;
    public GameObject soru7;
    public GameObject soru8;

    public GameObject pointer;
    public GameObject pointer1;
    public GameObject pointer2;
    public GameObject pointer3;
    public GameObject pointer4;
    public GameObject pointer5;
    public GameObject pointer6;
    public GameObject pointer7;
    public GameObject pointer8;

    public GameObject cevap1;
    public GameObject cevap2;
    public GameObject cevap3;
    public GameObject cevap4;
    public GameObject cevap5;
    public GameObject cevap6;
    public GameObject cevap7;
    public GameObject cevap8;

    public GameObject dogru1;
    public GameObject dogru2;
    public GameObject dogru3;
    public GameObject dogru4;
    public GameObject dogru5;
    public GameObject dogru6;
    public GameObject dogru7;
    public GameObject dogru8;

    public void soruacma1()
    {
        soru1.SetActive(true);
        pointer.SetActive(false);
        pointer1.SetActive(false);
        pointer2.SetActive(false);
        pointer3.SetActive(false);
        pointer4.SetActive(false);
        pointer5.SetActive(false);
        pointer6.SetActive(false);
        pointer7.SetActive(false);
    }

    public void SoruCevap()
    {
        cevap1.SetActive(false);
        dogru1.SetActive(true);
        StartCoroutine(soru01());
    }

    public IEnumerator soru01()
    {
        yield return new WaitForSeconds(1);
        cevap1.SetActive(false);
        dogru1.SetActive(false);
        soru1.SetActive(false);
        pointer.SetActive(true);
        pointer1.SetActive(true);
        pointer2.SetActive(true);
        pointer3.SetActive(true);
        pointer4.SetActive(true);
        pointer5.SetActive(true);
        pointer6.SetActive(true);
        pointer7.SetActive(true);
    }
}
