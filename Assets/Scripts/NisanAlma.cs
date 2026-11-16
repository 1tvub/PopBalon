using UnityEngine;
using UnityEngine.InputSystem;

public class NisanAlma : MonoBehaviour
{
    [Header("Nisan Ayarlari")]
    [Tooltip("Fare hareketine ne kadar hizli donsun")]
    [SerializeField] private float donusHizi = 0.1f;

    [Tooltip("Saga-sola en fazla kac derece donebilir")]
    [SerializeField] private float yataySinir = 40f;

    [Tooltip("Yukari-asagi en fazla kac derece donebilir")]
    [SerializeField] private float dikeySinir = 30f;

    private float yatayAci = 0f;
    private float dikeyAci = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Mouse.current == null) return;

        NisanAl();
    }

    private void NisanAl()
    {
        Vector2 fareHareketi = Mouse.current.delta.ReadValue();

        yatayAci += fareHareketi.x * donusHizi;
        dikeyAci -= fareHareketi.y * donusHizi;

        yatayAci = Mathf.Clamp(yatayAci, -yataySinir, yataySinir);
        dikeyAci = Mathf.Clamp(dikeyAci, -dikeySinir, dikeySinir);

        transform.rotation = Quaternion.Euler(dikeyAci, yatayAci, 0f);
    }
}