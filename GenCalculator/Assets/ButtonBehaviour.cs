using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{
    public Text Sex_Result_Text;
    public Text Sex_Text;

    public Text Coat_Result_Text;
    public Text Coat_Type_Text;
    public Text FemaleDropdownCoat;
    public Text MaleDropdownCoat;

    public Text FemaleDropdownMane;
    public Text MaleDropdownMane;
    public Text Mane_Result_Text;
    public Text Mane_Type_Text;

    public Text Fur_Result_Text;
    public Text FemaleDropdownFur;
    public Text MaleDropdownFur;
    public Text Fur_Type_Text;

    public int RandomResult;

    public void OnClick_Roll()
    {
        RollForCoat();
        RollForSex();
        RollForMane();
        RollForFur();
        RollForLitter();
        RollForMutations();
    }

    private void RollForMutations()
    {
    }

    private void RollForLitter()
    {
    }

    public void RollForFur()
    {
        RandomResult = UnityEngine.Random.Range(1, 1001);

        Fur_Result_Text.text = "Coat Type: " + RandomResult.ToString();

        // 1 - 125         Heat/Leaf/Cold/Ocean
        if (RandomResult <= 125)
        {
            Fur_Result_Text.text = "Heat/Leaf/Cold/Ocean";
        }
        //        126 - 250           Sand / Jade / Trunk / River
        if (RandomResult >= 126 && RandomResult <= 250)
        {
            Fur_Result_Text.text = "Sand / Jade / Trunk / River";
        }
        //251 - 375   Amber / Shamrock / Earth / Steel     
        if (RandomResult >= 251 && RandomResult <= 375)
        {
            Fur_Result_Text.text = "Amber / Shamrock / Earth / Steel";
        }
        //376 - 500            Sun / Lime / Granite / Mint
        if (RandomResult >= 376 && RandomResult <= 500)
        {
            Fur_Result_Text.text = "Sun / Lime / Granite / Mint";
        }
        //501 - 725                            Mother
        if (RandomResult >= 501 && RandomResult <= 725)
        {
            Fur_Result_Text.text = FemaleDropdownFur.text.ToString();
        }
        //726 - 950                            Father
        if (RandomResult >= 726 && RandomResult <= 950)
        {
            Fur_Result_Text.text = MaleDropdownFur.text.ToString();
        }
        //951 - 990        Stone / Fungi / Kupfer / Berry
        if (RandomResult >= 951 && RandomResult <= 990)
        {
            Fur_Result_Text.text = "Stone / Fungi / Kupfer / Berry";
        }
        //991 - 995   Pear / Caramel / Storm / Coal
        if (RandomResult >= 991 && RandomResult <= 995)
        {
            Fur_Result_Text.text = "Pear / Caramel / Storm / Coal";
        }
        //996 - 1000           Fade / Ice / Pine / Blood
        if (RandomResult >= 996 && RandomResult <= 1000)
        {
            Fur_Result_Text.text = "Fade / Ice / Pine / Blood";
        }

    }

    public void RollForCoat()
    {
        RandomResult = UnityEngine.Random.Range(1, 1001);

        Coat_Type_Text.text = "Coat Type: " + RandomResult.ToString();

        // 1 - 50         Nones
        if (RandomResult <= 50)
        {
            Coat_Result_Text.text = "None";
        }
        // 51 - 75         Silver
        if (RandomResult >= 51 && RandomResult <= 75)
        {
            Coat_Result_Text.text = "Silver";
        }
        // 101 - 200       Pangare
        if (RandomResult >= 101 && RandomResult <= 200)
        {
            Coat_Result_Text.text = "Pangare";
        }
        // 201 - 300            Dun
        if (RandomResult >= 201 && RandomResult <= 300)
        {
            Coat_Result_Text.text = "Dun";
        }
        // 301 - 400         Champagne
        if (RandomResult >= 301 && RandomResult <= 400)
        {
            Coat_Result_Text.text = "Champagne";
        }
        // 401 - 500              Grey
        if (RandomResult >= 401 && RandomResult <= 500)
        {
            Coat_Result_Text.text = "Grey";
        }
        // 501 - 750            Mother
        if (RandomResult >= 501 && RandomResult <= 750)
        {
            Coat_Result_Text.text = FemaleDropdownCoat.text.ToString();
        }
        // 751 - 1000            Father
        if (RandomResult >= 751 && RandomResult <= 1000)
        {
            Coat_Result_Text.text = MaleDropdownCoat.text.ToString();
        }
    }

    public void RollForMane()
    {
        RandomResult = UnityEngine.Random.Range(1, 1001);
        Mane_Type_Text.text = "Coat Type: " + RandomResult.ToString();

        // 1 - 400         Standard
        if (RandomResult <= 400)
        {
            Mane_Result_Text.text = "Standard";
        }
        // 401 - 430      Longer
        if (RandomResult >= 401 && RandomResult <= 430)
        {
            Mane_Result_Text.text = "Silver";
        }
        // 431 - 460      Gap
        if (RandomResult >= 431 && RandomResult <= 460)
        {
            Mane_Result_Text.text = "Pangare";
        }
        // 461 - 490      Forwards
        if (RandomResult >= 461 && RandomResult <= 490)
        {
            Mane_Result_Text.text = "Dun";
        }
        // 491 - 520      Sholders
        if (RandomResult >= 491 && RandomResult <= 520)
        {
            Mane_Result_Text.text = "Champagne";
        }
        // 521 - 530     Full
        if (RandomResult >= 521 && RandomResult <= 530)
        {
            Mane_Result_Text.text = "Grey";
        }
        // 531 - 540     Maneless
        if (RandomResult >= 531 && RandomResult <= 540)
        {
            Mane_Result_Text.text = "Champagne";
        }
        // 541 - 545     Storm
        if (RandomResult >= 541 && RandomResult <= 545)
        {
            Mane_Result_Text.text = "Grey";
        }
        // 546 - 772     Mother
        if (RandomResult >= 546 && RandomResult <= 772)
        {
            Mane_Result_Text.text = FemaleDropdownCoat.text.ToString();
        }
        // 773 - 1000   Father
        if (RandomResult >= 773 && RandomResult <= 1000)
        {
            Mane_Result_Text.text = MaleDropdownCoat.text.ToString(); ;
        }
    }

    public void RollForSex()
    {
        RandomResult = UnityEngine.Random.Range(1, 1001);
        Sex_Text.text = "Sex: " + RandomResult;

        if (RandomResult <= 500)
        {
            Sex_Result_Text.text = "Male";
        }
        else
        {
            Sex_Result_Text.text = "Female";
        }
    }
}
