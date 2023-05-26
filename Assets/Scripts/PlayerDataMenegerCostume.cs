using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class PlayerDataMenegerCostume : MonoBehaviour
{
    public static PlayerDataMenegerCostume Instance;

    public bool gender;
    public int body,hair,top,bottom;




    public List<SpriteLibraryAsset>
        manBodyList, manHairList, manTopList, manBottomList,
        womanBodyList, womanHairList, womanTopList, womanBottomList;


    public SpriteLibrary bodySpriteLibary, hairSpriteLibary, topSpriteLibary, bottomSpriteLibary;






    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        Destroy(this.gameObject);
        DressUp();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void DressUp()
    {
        if (gender)
        {
            bodySpriteLibary.spriteLibraryAsset = manBodyList[body];

            hairSpriteLibary.spriteLibraryAsset = manHairList[hair];

            topSpriteLibary.spriteLibraryAsset = manTopList[top];

            bottomSpriteLibary.spriteLibraryAsset = manBottomList[bottom];
        }
        else
        {
            bodySpriteLibary.spriteLibraryAsset = womanBodyList[body];
            hairSpriteLibary.spriteLibraryAsset = womanHairList[hair];
            topSpriteLibary.spriteLibraryAsset = womanTopList[top];
            bottomSpriteLibary.spriteLibraryAsset = womanBottomList[bottom];
        }
    }



}
