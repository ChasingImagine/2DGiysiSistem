using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D.Animation;

public class PlayerCharacterSelect : MonoBehaviour
{

    
    public bool gender;


    int body = 0, hair = 0, top = 0, bottom = 0;
    


    public void Gender()
    {
       
        if (gender)
        {
            gender = false;
        }
        else
        {
            gender = true;
        }
        ayar();
    }
    
   




    public void BodyRight()
    {
        body += 1;


        if (gender)
        {
           
            if (body > PlayerDataMenegerCostume.Instance.manBodyList.Count-1 || body <0 )
            {
                body = 0;
            }

            
        }
        else
        {
            
            
            if (body > PlayerDataMenegerCostume.Instance.womanBodyList.Count-1 || body < 0)
            {
                body = 0;
            }

            
        }
        ayar();


    }



    public void BodyLeft()
    {
        body -= 1;
        if (gender)
        {

            if (body > PlayerDataMenegerCostume.Instance.manBodyList.Count - 1 || body < 0)
            {
                body = 0;
            }
           
        }
        else
        {

            if (body > PlayerDataMenegerCostume.Instance.womanBodyList.Count - 1 || body < 0)
            {
                body = 0;
            }

        }
        ayar();
    }







    public void HairRight()
    {
        hair += 1;
        if (gender)
        {

            if (hair > PlayerDataMenegerCostume.Instance.manHairList.Count-1 || hair < 0)
            {
                hair = 0;
            }

        }
        else
        {
            if (hair > PlayerDataMenegerCostume.Instance.womanHairList.Count-1 || hair < 0)
            {
                hair = 0;
            }

        }

        ayar();
    }



    public void HairLeft()
    {
        hair -= 1;
        if (gender)
        {

            if (hair > PlayerDataMenegerCostume.Instance.manHairList.Count - 1 || hair < 0)
            {
                hair = 0;
            }

        }
        else
        {
            if (hair > PlayerDataMenegerCostume.Instance.womanHairList.Count - 1 || hair < 0)
            {
                hair = 0;
            }

        }
        ayar();
    }







    public void TopRight()
    {
        top += 1;
        if (gender)
        {

            if (top > PlayerDataMenegerCostume.Instance.manTopList.Count - 1 || top < 0)
            {
                top = 0;
            }

        }
        else
        {

            if (top > PlayerDataMenegerCostume.Instance.womanTopList.Count - 1 || top < 0)
            {
                top = 0;
            }

        }
        ayar();
    }



    public void TopLeft()
    {
        top -= 1;
        if (gender)
        {

            if (top > PlayerDataMenegerCostume.Instance.manTopList.Count - 1 || top < 0)
            {
                top = 0;
            }

        }
        else
        {

            if (top > PlayerDataMenegerCostume.Instance.womanTopList.Count - 1 || top < 0)
            {
                top = 0;
            }
        }
        ayar();
    }







    public void BottomRight()
    {
        bottom += 1;
        if (gender)
        {
            if (bottom > PlayerDataMenegerCostume.Instance.manBottomList.Count - 1 || bottom < 0)
            {
                bottom = 0;
            }
        }
        else
        {

            if (bottom > PlayerDataMenegerCostume.Instance.manBottomList.Count - 1 || bottom < 0)
            {
                bottom = 0;
            }
        }
        ayar();
    }



    public void BottomLeft()
    {
        bottom -= 1;
        if (gender)
        {

            if (bottom > PlayerDataMenegerCostume.Instance.manBottomList.Count - 1 || bottom < 0)
            {
                bottom = 0;
            }
            
        }
        else
        {

            if (bottom > PlayerDataMenegerCostume.Instance.womanBottomList.Count - 1 || bottom < 0)
            {
                bottom = 0;
            }
        }
        ayar();
    }



    void ayar()
    {

        
      
        

        PlayerDataMenegerCostume.Instance.gender = gender;
        PlayerDataMenegerCostume.Instance.body = body;
        PlayerDataMenegerCostume.Instance.hair = hair;
        PlayerDataMenegerCostume.Instance.top = top;
        PlayerDataMenegerCostume.Instance.bottom = bottom;



        PlayerDataMenegerCostume.Instance.DressUp();


    }


    public void Play()
    {
        SceneManager.LoadScene(3);
    }
    

}
