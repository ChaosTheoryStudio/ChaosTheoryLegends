using UnityEngine;
using UnityEngine.InputSystem;

public class BulletHandler : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Rigidbody;
    [SerializeField] private GameObject TestPrefab;

    [SerializeField] private Transform BulletsParent;
    [SerializeField] private Camera PlayerCamera;

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (!context.started)
            return;

        Vector2 realPos = PlayerCamera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        GameObject obj = Instantiate(TestPrefab, BulletsParent);
        obj.transform.position = realPos;
    }
}