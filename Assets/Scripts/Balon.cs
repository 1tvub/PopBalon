using UnityEngine;

public class Balon : MonoBehaviour
{
    [Header("Can Ayarlari")]
    [SerializeField] private int can = 100;


    [Header("Vurus Ayarlari")]
    [Tooltip("Vurulunca geri itilme gucu (impact force)")]
    [SerializeField] private float itmeGucu = 5f;


    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public bool Vuruldu(int hasar, Vector3 vurusNoktasi, Vector3 atisYonu)
    {
        can -= hasar;
        Debug.Log($"{name} vuruldu! Kalan can: {can}");

        if (can <= 0)
        {
            Patla();
            return true;
        }
        else
        {
            rb.AddForceAtPosition(atisYonu * itmeGucu, vurusNoktasi, ForceMode.Impulse);
            return false;
        }

    }
 
    private void Patla()
    {
        Debug.Log($"{name} PATLADI!");
        Destroy(gameObject);
    }
}
