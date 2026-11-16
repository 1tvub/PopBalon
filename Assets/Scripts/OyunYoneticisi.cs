using UnityEngine;

public class OyunYoneticisi : MonoBehaviour
{
    [Header("Oyun Kurallari")]
    [SerializeField] private int mermiSayisi = 25;
    [SerializeField] private int balonSayisi = 8;

    private bool oyunBittiMi = false;

    public bool AtesEdebilirMi()
    {
        return mermiSayisi > 0 && !oyunBittiMi;
    }

    public void BalonPatladi()
    {
        balonSayisi--;
        Debug.Log($"Kalan balon: {balonSayisi}");

        if (balonSayisi <= 0)
        {
            oyunBittiMi = true;
            Debug.Log($"TEBRIKLER! Tum balonlari patlattin! Artan mermi: {mermiSayisi}");
        }
    }

    public void MermiHarca()
    {
        mermiSayisi--;
        Debug.Log($"Kalan mermi: {mermiSayisi}");

        if (mermiSayisi <= 0 && balonSayisi > 0)
        {
            oyunBittiMi = true;
            Debug.Log("Mermin bitti! KAYBETTIN");
        }
    }
}