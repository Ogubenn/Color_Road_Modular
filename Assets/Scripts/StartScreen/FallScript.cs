using UnityEngine;

public class FallScript : MonoBehaviour
{
    public GameObject objePrefab; // B�rak�lacak obje
    public Transform dusmeNoktasi; // D���rme noktas�
    private Rigidbody objeRigidbody; // B�rak�lacak objenin Rigidbody bile�eni
    public GameObject ground;

    void Start()
    {
        objeRigidbody = objePrefab.GetComponent<Rigidbody>(); // Objeye ait Rigidbody bile�enini al
        InvokeRepeating("InstantiateVeBirak", 0f, 10f); // Belirli aral�klarla InstantiateVeBirak fonksiyonunu �a��r
    }

    void InstantiateVeBirak()
    {
        GameObject yeniObje = Instantiate(objePrefab, dusmeNoktasi.position, Quaternion.identity); // Yeni bir obje instantiate et
        yeniObje.SetActive(true); // Objeyi aktifle�tir
        objeRigidbody = yeniObje.GetComponent<Rigidbody>(); // Yeni objenin Rigidbody bile�enini al

        // Yeni objeyi b�rakma i�lemi
        objeRigidbody.isKinematic = false; // Kinematik olmayan bir rigidbody'e sahip olmas� i�in ayarla
        objeRigidbody.velocity = Vector3.zero; // H�z�n� s�f�rla
        objeRigidbody.angularVelocity = Vector3.zero; // A��sal h�z�n� s�f�rla
    }
}
