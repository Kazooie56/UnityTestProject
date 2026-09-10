using UnityEngine;

public class RotateScript : MonoBehaviour
{
    [SerializeField] private Vector3 rotateSpeed = new Vector3(0f, 50f, 0f);

    void Update()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime);
    }
}