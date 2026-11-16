using UnityEngine;
using UnityEngine.InputSystem;

public class Atici : MonoBehaviour
{
    [Header("Atis Ayarlari")]
    [Tooltip("Isının gidebilecegi en uzak mesafe")]
    [SerializeField] private float menzil = 50f;

    [Tooltip("Isının cikacigi nokta (kamera)")]
    [SerializeField] private Transform AtisNoktasi;
    [SerializeField] private int hasar = 50;
    [SerializeField] private OyunYoneticisi oyunYoneticisi;

    private void Awake()
    {
        if (AtisNoktasi == null)
        {
            AtisNoktasi = transform;
        }
    }

    void Update()
    {
        if (Mouse.current == null) return;

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            AtesEt();
        }

    }

    private void AtesEt()
    {
        if (!oyunYoneticisi.AtesEdebilirMi()) return;             

        RaycastHit hit;

        Debug.DrawRay(AtisNoktasi.position, AtisNoktasi.forward * menzil, Color.yellow, 1f);

        if (Physics.Raycast(AtisNoktasi.position, AtisNoktasi.forward, out hit, menzil))
        {
            Debug.Log($"Vurdum: {hit.collider.name}");
            Balon balon = hit.collider.GetComponent<Balon>();
            if (balon != null)
            {
                bool patladiMi = balon.Vuruldu(hasar, hit.point, AtisNoktasi.forward); 
                if (patladiMi)                                                          
                {                                                                       
                    oyunYoneticisi.BalonPatladi();                                      
                }                                                                     
            }
        }
        else
        {
            Debug.Log("Iska!");
        }

        oyunYoneticisi.MermiHarca();                               
    }
}