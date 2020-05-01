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
        result.text = "<color=#008000ff>史萊姆</color>"+ "受到" + "<color=#000000ff>蝙蝠</color>" + bat.atk + "點的攻擊" +
            "\n" + "<color=#008000ff>史萊姆</color>" + "血量：" + (slime.hp -= bat.atk);
    }

    public void Btheal()
    {
        result.text = "<color=#000000ff>蝙蝠</color>" +"受到" + bat.heal + "點的治癒" +
            "\n" + "<color=#000000ff>蝙蝠</color>" +"血量：" + (bat.hp += bat.heal);
    }

    public void Slatk()
    {
        result.text = "<color=#000000ff>蝙蝠</color>" + "受到" + "<color=#008000ff>史萊姆</color>" + slime.atk + "點的攻擊" +
            "\n" + "<color=#000000ff>蝙蝠</color>"  + "血量：" + (bat.hp -= slime.atk);
    }


    public void Slheal()
    {
        result.text = "<color=#008000ff>史萊姆</color>"+ "受到" + slime.heal + "點的治癒" +
            "\n" + "<color=#008000ff>史萊姆</color>"+ "血量：" + (slime.hp += slime.heal);
    }



}
