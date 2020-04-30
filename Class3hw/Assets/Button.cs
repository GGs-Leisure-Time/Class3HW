using UnityEngine;
using UnityEngine.UI;
using System;


public class Button: MonoBehaviour
{



    public Monster slime;
    public Monster bat;



    [Header("文字：輸出結果")]
    public Text result;



    public void Btatk()
    {
        //輸出結果.文字內容 =
        result.text = "史萊姆受到蝙蝠" + bat.atk + "點的攻擊" +
            "\n" + "史萊姆血量：" + (slime.hp -= bat.atk);
    }

    public void Btheal()
    {
        result.text = "蝙蝠受到" + bat.heal + "點的治癒" +
            "\n" + "蝙蝠血量：" + (bat.hp += bat.heal);
    }

    public void Slatk()
    {
        result.text = "蝙蝠受到史萊姆" + slime.atk + "點的攻擊" +
            "\n" + "蝙蝠血量：" + (bat.hp -= slime.atk);
    }


    public void Slheal()
    {
        result.text = "史萊姆受到" + slime.heal + "點的治癒" +
            "\n" + "史萊姆血量：" + (slime.hp += slime.heal);
    }



}
