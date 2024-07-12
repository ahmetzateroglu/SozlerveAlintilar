using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sozler : MonoBehaviour
{


    public List<SozListe> sozler;  

    void Start()
    {

        sozler[0].soruNumara = 0;
        sozler[0].sozText = "Ön yargıları yok etmek, atom çekirdeğini parçalamaktan daha zordur.";
        sozler[0].yazarText = "Albert Einstein";
        sozler[0].kategori = " ";
        sozler[0].aciklama = " ";

        sozler[1].soruNumara = 1;
        sozler[1].sozText = "Bir insanın zekası verdiği cevaplardan değil, sorduğu sorulardan anlaşılır.";
        sozler[1].yazarText = "Albert Einstein";
        sozler[1].kategori = "";
        sozler[1].aciklama = "";

        sozler[2].soruNumara = 2;
        sozler[2].sozText = "Cevapları olan değil soruları olan insanları dinleyin.";
        sozler[2].yazarText = "Albert Einstein";
        sozler[2].kategori = "";
        sozler[2].aciklama = "";

        sozler[3].soruNumara = 3;
        sozler[3].sozText = "Başarılı bir adam olmak için çalışmayın, aksine önemli bir adam olmak için çalışın.";
        sozler[3].yazarText = "Albert Einstein";
        sozler[3].kategori = "";
        sozler[3].aciklama = "";

        sozler[4].soruNumara = 4;
        sozler[4].sozText = "Problemleri, onları üreten kafalarla çözemeyiz.";
        sozler[4].yazarText = "Albert Einstein";
        sozler[4].kategori = "";
        sozler[4].aciklama = "";

        sozler[5].soruNumara = 5;
        sozler[5].sozText = "İnsan aklın sınırlarını zorlamadıkça hiçbir şeye ulaşamaz.";
        sozler[5].yazarText = "Albert Einstein";
        sozler[5].kategori = "";
        sozler[5].aciklama = "";

        sozler[6].soruNumara = 6;
        sozler[6].sozText = "Hayat bisiklet gibidir, dengeyi kaybetmemek için ilerlemek gerekir.";
        sozler[6].yazarText = "Albert Einstein";
        sozler[6].kategori = "";
        sozler[6].aciklama = "";

        sozler[7].soruNumara = 7;
        sozler[7].sozText = "Dehanın 10′da 1′i yetenek 10′da 9′u da çalışmaktır.";
        sozler[7].yazarText = "Albert Einstein";
        sozler[7].kategori = "";
        sozler[7].aciklama = "";

        sozler[8].soruNumara = 8;
        sozler[8].sozText = "Bana güvenilen bir sırrı kutsal bir emanet gibi saklarım, ama sırları elimden geldiği kadar bilmemeye çalışırım.";
        sozler[8].yazarText = "Albert Einstein";
        sozler[8].kategori = "";
        sozler[8].aciklama = "";

        sozler[9].soruNumara = 9;
        sozler[9].sozText = "Yüksek ruhlar, her zaman sıradan akılların şiddetli muhalefetleriyle karşılaşırlar.";
        sozler[9].yazarText = "Albert Einstein";
        sozler[9].kategori = "";
        sozler[9].aciklama = "";

        sozler[10].soruNumara = 10;
        sozler[10].sozText = "Merakınızın peşinden gidin: “Benim özel bir yeteneğim yok. Yalnızca tutkulu bir meraklıyım.”";
        sozler[10].yazarText = "Albert Einstein";
        sozler[10].kategori = "";
        sozler[10].aciklama = "";

        sozler[11].soruNumara = 11;
        sozler[11].sozText = "Dünya; kötülük yapanlar değil, seyirci kalıp hiçbir şey yapmayanlar yüzünden tehlikeli bir yerdir.";
        sozler[11].yazarText = "Albert Einstein";
        sozler[11].kategori = "";
        sozler[11].aciklama = "";

        sozler[12].soruNumara = 12;
        sozler[12].sozText = "İki atı aynı anda süremezsiniz. Bir şeyler yapabilirsiniz ama her şeyi yapamazsınız. Şimdiye odaklanın ve bütün enerjinizi şu anda yaptığınız işe verin.";
        sozler[12].yazarText = "Albert Einstein";
        sozler[12].kategori = "";
        sozler[12].aciklama = "";

        sozler[13].soruNumara = 13;
        sozler[13].sozText = "Mutlu olmak istiyorsan, bir amaca bağlan; insanlara ya da eşyalara değil.";
        sozler[13].yazarText = "Albert Einstein";
        sozler[13].kategori = "";
        sozler[13].aciklama = "";

        sozler[14].soruNumara = 14;
        sozler[14].sozText = "Aptallığın en büyük kanıtı, aynı şeyi defalarca yapıp farklı bir sonuç almayı ummaktır.";
        sozler[14].yazarText = "Albert Einstein";
        sozler[14].kategori = "";
        sozler[14].aciklama = "";

        sozler[15].soruNumara = 15;
        sozler[15].sozText = "Bilgi deneyimden gelir, bilgi malumat değildir. Bilmenin tek yolu deneyimlemektir.";
        sozler[15].yazarText = "Albert Einstein";
        sozler[15].kategori = "";
        sozler[15].aciklama = "";





    }

}



[System.Serializable]

public class SozListe
{
    public int soruNumara;
    public string sozText, yazarText;
    

    public string kategori, aciklama;

   //  public Image image1;  o hintli çocuğu ve bzim youtubedan bakarak resimmde ekleyebilirsin ama o zaman proje çok mu büyür bilmem ekleyebilirsen bile en son dene  2 ayrı projede dene
   // boyut karşılaştırması yap

    public SozListe(int soruNum, string soru, string yazar, string ktgr, string acklma) 
    {
        soruNumara = soruNum;
        sozText = soru;
        yazarText = soru;
        kategori = ktgr;
        aciklama = acklma;
    }

   

}
