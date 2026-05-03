using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SoruYoneticisi : MonoBehaviour
{
    [System.Serializable]
    public class Soru
    {
        public string soruMetni;
        public string[] secenekler = new string[4];
        public int dogruIndex; // 0-3 arası
    }

    public List<Soru> sorular = new List<Soru>();
    public TextMeshProUGUI soruText;
    public Button secenek1Button;
    public Button secenek2Button;
    public Button secenek3Button;
    public Button secenek4Button;

    private Button[] secenekButonlari;
    private Soru aktifSoru;

    void Start()
    {
        secenekButonlari = new Button[] { secenek1Button, secenek2Button, secenek3Button, secenek4Button };
        SoruYukle();
        YeniSoruGetir();
    }

    void SoruYukle()
    {
        // Örnek sorular
        sorular.Add(new Soru { soruMetni = "Türkiye'nin başkenti neresidir?", secenekler = new[] { "İstanbul", "Ankara", "İzmir", "Bursa" }, dogruIndex = 1 });
        sorular.Add(new Soru { soruMetni = "İslam'ın kutsal kitabı nedir?", secenekler = new[] { "Tevrat", "İncil", "Kur'an", "Zebur" }, dogruIndex = 2 });
        // Buraya daha fazla soru eklenebilir
    }

    void YeniSoruGetir()
    {
        int rastgele = Random.Range(0, sorular.Count);
        aktifSoru = sorular[rastgele];
        soruText.text = aktifSoru.soruMetni;

        

        for (int i = 0; i < secenekButonlari.Length; i++)
        {
            int index = i; // Local kopya
            secenekButonlari[i].GetComponentInChildren<TextMeshProUGUI>().text = aktifSoru.secenekler[i];
            secenekButonlari[i].onClick.RemoveAllListeners();
            secenekButonlari[i].onClick.AddListener(() => CevapKontrol(index));
        }
    }

    void CevapKontrol(int index)
    {
        if (index == aktifSoru.dogruIndex)
        {
            Debug.Log("Doğru cevap!");
        }
        else
        {
            Debug.Log("Yanlış cevap!");
        }

        YeniSoruGetir();
    }
}
