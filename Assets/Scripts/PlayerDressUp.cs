using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.U2D.Animation;

public class PlayerDressUp : MonoBehaviour
{


    public SpriteLibrary bodySpriteLibary, hairSpriteLibary, topSpriteLibary, bottomSpriteLibary;




    // Start is called before the first frame update
    void Start()
    {
        DressUp();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void DressUp()
    {
        if (PlayerDataMenegerCostume.Instance.gender)
        {
            bodySpriteLibary.spriteLibraryAsset = PlayerDataMenegerCostume.Instance.manBodyList[PlayerDataMenegerCostume.Instance.body];

            hairSpriteLibary.spriteLibraryAsset = PlayerDataMenegerCostume.Instance.manHairList[PlayerDataMenegerCostume.Instance.hair];

            topSpriteLibary.spriteLibraryAsset = PlayerDataMenegerCostume.Instance.manTopList[PlayerDataMenegerCostume.Instance.top];

            bottomSpriteLibary.spriteLibraryAsset = PlayerDataMenegerCostume.Instance.manBottomList[PlayerDataMenegerCostume.Instance.bottom];
        }
        else
        {
            bodySpriteLibary.spriteLibraryAsset = PlayerDataMenegerCostume.Instance.womanBodyList[PlayerDataMenegerCostume.Instance.body];
            hairSpriteLibary.spriteLibraryAsset = PlayerDataMenegerCostume.Instance.womanHairList[PlayerDataMenegerCostume.Instance.hair];
            topSpriteLibary.spriteLibraryAsset = PlayerDataMenegerCostume.Instance.womanTopList[PlayerDataMenegerCostume.Instance.top];
            bottomSpriteLibary.spriteLibraryAsset = PlayerDataMenegerCostume.Instance.womanBottomList[PlayerDataMenegerCostume.Instance.bottom];
        }
    }


}
