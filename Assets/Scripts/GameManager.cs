using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




public class GameManager : MonoBehaviour
{

    public static int kaldiginYer; 


    public Text sozText, yazarText;

    public int soruNumara; public Text sozNumarasiText;

    public GameObject aciklamaPanel; public Text panelText;

    

    public InputField sayiInput;

    Sozler sr;   
 



    public Text aSozText, aYazarText, aSozNumarasiText;

    public List<int> myList;
    int x ; 

 

    void Start()
    {
        SozListe();

        if (PlayerPrefs.HasKey("kaldiginYer"))
        {
            kaldiginYer = PlayerPrefs.GetInt("kaldiginYer");
        }
        else 
        {
            PlayerPrefs.SetInt("kaldiginYer", 0);
        }


        sr = GetComponent<Sozler>();
       
        aciklamaPanel.SetActive(false);

        KaldiginYer();
        



        if (PlayerPrefs.HasKey("myList_count")) 
        {
           
            x = PlayerPrefs.GetInt("myList_count");

        }
        else 
        {
            PlayerPrefs.SetInt("myList_count", myList.Count);   
            x = myList.Count;

           
        }

       
        for (int i = 0; i < x; i++) 
        {                           

          
            if (PlayerPrefs.HasKey(("myList_" + i))) 
            {
                
                myList.Add(PlayerPrefs.GetInt("myList_" + i));  
            }
            else 
            {
                PlayerPrefs.SetInt("myList_" + i, myList[i]);
            }
            
        }


    }


    void Update()
    {
      
    }

    public void KaldiginYer()
    {
        soruNumara = kaldiginYer;

        sozText.text = sr.sozler[kaldiginYer].sozText;
        yazarText.text = sr.sozler[kaldiginYer].yazarText;
        sozNumarasiText.text = kaldiginYer.ToString();  
       
    }

    public void Ileri()  
    {
        if ((soruNumara += 1) < sr.sozler.Count)
        {
            PlayerPrefs.SetInt("kaldiginYer", soruNumara);

            sozText.text = sr.sozler[soruNumara].sozText;
            yazarText.text = sr.sozler[soruNumara].yazarText;
            sozNumarasiText.text = soruNumara.ToString();
        }
        else
        {
            Debug.Log("Geçerli Bir Sayý Giriniz");
            soruNumara -= 1;
        }
    }

    public void Geri()
    {
        if((soruNumara -= 1) >= 0) 
        {

            PlayerPrefs.SetInt("kaldiginYer", soruNumara); 

            sozText.text = sr.sozler[soruNumara].sozText;
            yazarText.text = sr.sozler[soruNumara].yazarText;
            sozNumarasiText.text = soruNumara.ToString();

        }
        else
        {
            Debug.Log("Geçerli Bir Sayý Giriniz");
            soruNumara += 1; 

        }


    }
    
    public void RandomEkle()
    {

        int sayi = Random.Range(0, sr.sozler.Count -1); 

        soruNumara = sayi;
        PlayerPrefs.SetInt("kaldiginYer", soruNumara); 

        sozText.text = sr.sozler[soruNumara].sozText;
        yazarText.text = sr.sozler[soruNumara].yazarText;
        sozNumarasiText.text = soruNumara.ToString();

    }

    public void NumarayaGit()
    {
        if (int.Parse(sayiInput.text) < sr.sozler.Count && int.Parse(sayiInput.text) >=0) 
        {
            soruNumara = int.Parse(sayiInput.text);
            PlayerPrefs.SetInt("kaldiginYer", soruNumara); 

            sozText.text = sr.sozler[soruNumara].sozText;
            yazarText.text = sr.sozler[soruNumara].yazarText;
            sozNumarasiText.text = soruNumara.ToString();


            sayiInput.text = "";

        }
        else
        {
            Debug.Log("Geçerli Bir Sayý Giriniz");

            sayiInput.text = "";

        }


    }

    public void Kopyala() 
    {

        string x="";

        x += sr.sozler[soruNumara].sozText + " " + sr.sozler[soruNumara].yazarText;
        GUIUtility.systemCopyBuffer = x;
    }



    public void AnaMenuDon()
    {
        SceneManager.LoadScene(0);
    }




    public void SozEkle()
    {


        soruNumara = Random.Range(0, sr.sozler.Count); 

        int TamamMi = 0;

        Debug.Log(sr.sozler.Count);
        Debug.Log(myList.Count);

        for (int i = 0; i < myList.Count; i++) 
        {
           if (myList[i] == soruNumara && myList.Count < sr.sozler.Count) 
           {
                SozEkle(); 
                TamamMi = 0;
                break;

               
            }
           else
           {
                TamamMi = 1;


           }

           

        }


        if ((TamamMi == 1 || myList.Count == 0) && myList.Count < sr.sozler.Count) 
        {
            aSozText.text = sr.sozler[soruNumara].sozText;
            aYazarText.text = sr.sozler[soruNumara].yazarText;
            aSozNumarasiText.text = soruNumara.ToString();

            myList.Add(soruNumara);


            PlayerPrefs.SetInt("myList_count", myList.Count);
            PlayerPrefs.SetInt("myList_" + (myList.Count - 1), myList[myList.Count - 1]);

        }
        else
        {
            Debug.Log("Liste Bitti");
        }




    }


    public void PlayerPrefsSil()
    {
        PlayerPrefs.DeleteAll(); 
        myList.Clear();

    }

    public void PanelYonetimi(int x)
    {
        if (x == 0)
        {
            aciklamaPanel.SetActive(true);
        }
        else if (x == 1)
        {
            aciklamaPanel.SetActive(false);
        }

    }

   

    public void SozListe()
    {

    }


}
