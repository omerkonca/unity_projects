using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class yazidegistirme : MonoBehaviour
{
    // Start is called before the first frame update
    public Text yazi;
    private enum Bolumler { orman, yol_1, yol_2, yol_3, aslan, yilan, nehir, bahce,  };
    private Bolumler aktifBolum;
    void Start()
    {
        aktifBolum = Bolumler.orman;
    }

    // Update is called once per frame
    void Update()
    {
        if (aktifBolum == Bolumler.orman)
        {
            bolum_orman();
        }
        else if (aktifBolum == Bolumler.yol_1)
        {
            bolum_yol_1();
        }
        else if (aktifBolum == Bolumler.yol_2)
        {
            bolum_yol_2();
        }
        else if (aktifBolum == Bolumler.yol_3)
        {
            bolum_yol_3();
        }
        else if (aktifBolum == Bolumler.aslan)
        {
            bolum_aslan();
        }
        else if (aktifBolum == Bolumler.yilan)
        {
            bolum_yilan();
        }
        else if (aktifBolum == Bolumler.nehir)
        {
            bolum_nehir();
        }
        else if (aktifBolum == Bolumler.bahce)
        {
            bolum_bahce();
        }
    }
    void bolum_orman()
    {
        yazi.text = "karanlık ve ıssız ormanda uyandın. Aç ve susuzsun. Önünde 3 yol var. Hangisini seçersin?\nBirinci yol için 1'e, ikinci yol için 2'ye, üçüncü yol için 3'e bas";
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            aktifBolum = Bolumler.yol_1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            aktifBolum = Bolumler.yol_2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            aktifBolum = Bolumler.yol_3;
        }
    }
    void bolum_yol_1()
    {
        yazi.text = "birinci yola saptın ve uzun bir yürüyüşün ardından karşına bir yol ayrımı çıktı. İlk yolun başında bir aslanın beklediğini gördün. İkinci yolun başında ise yılan beklemekte. Ne yaparsın?\nAslanlı yol için A'ya, yılanlı uol için Y'ye, geri dönmek için G'ye bas";
        if (Input.GetKeyDown(KeyCode.A))
        {
            aktifBolum = Bolumler.aslan;
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            aktifBolum = Bolumler.yilan;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            aktifBolum = Bolumler.orman;
        }
    }
    void bolum_yol_2()
    {
        yazi.text = "bu yolu büyükçe bir kaya kapatmış. Geri dönmek için G'ye bas.";
        if (Input.GetKeyDown(KeyCode.G))
        {
            aktifBolum = Bolumler.orman;
        }
    }
    void bolum_yol_3()
    {
        yazi.text = "karşıma bir yol ayrımı çıktı. Hem açsın hem susuz\nNehre doğru inmek için N'ye, Bahçeye doğru tırmanmak için B'ye, Geri dönmek için G'ye bas";
        if (Input.GetKeyDown(KeyCode.N))
        {
            aktifBolum = Bolumler.nehir;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            aktifBolum = Bolumler.bahce;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            aktifBolum = Bolumler.orman;
        }
    }
    void bolum_yilan()
    {
        yazi.text = "yılanın yanından geçerken bir anda san sarıldı ve önce felç geçirip sonra acı içinde son nefesini verdin.";
        StartCoroutine(GecikmeKaybet());
    }
    void bolum_aslan()
    {
        yazi.text = "aslanla karşılaştın bu kadar aptal olduğunu bilmiyordum.Aslan seni bir lokmada yuttu";
        StartCoroutine(GecikmeKaybet());
    }
    void bolum_nehir()
    {
        yazi.text = "nehirden kana kana su içtin ve yola devam edecek gücü kendinde buldun. Daha sonra karanlık ormandan kurtuldun.";
        StartCoroutine(GecikmeKazan());
    }
    void bolum_bahce()
    {
        yazi.text = "insan susuzluğa 3 gün açlığa 15 gün dayanabilir. Bahçeeye giderek karnını doyurdun fakat ormandan kurtulamadan susuzluğa yenik düştün";
        StartCoroutine(GecikmeKaybet());
    }
    IEnumerator GecikmeKaybet()
    {
        yield return new WaitForSeconds(3);
        Application.LoadLevel("Kaybetme");
    }
    IEnumerator GecikmeKazan()
    {
        yield return new WaitForSeconds(3);
        Application.LoadLevel("Kazanma");
    }
}