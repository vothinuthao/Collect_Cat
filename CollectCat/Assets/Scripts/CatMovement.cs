using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{
    public float moveRadius = 5f;     // Bán kính di chuyển ngẫu nhiên
    public float moveSpeed = 2f;      // Tốc độ di chuyển
    public float changeInterval = 2f; // Khoảng thời gian giữa các lần đổi hướng

    // public LayerMask wallLayer;       // Layer của các đối tượng "Wall"

    private Vector3 targetPosition;   // Vị trí đích đến tiếp theo
    private Vector3 moveDirection;    // Hướng di chuyển hiện tại

    void Start()
    {

        // Đặt mục tiêu ban đầu
        SetNewRandomTarget();
        // Bắt đầu coroutine để thay đổi mục tiêu di chuyển sau mỗi khoảng thời gian
        StartCoroutine(ChangeDirectionRoutine());
        //int catLayer = gameObject.layer;
        //int wallLayer = LayerMask.NameToLayer("Wall");
        //Physics.IgnoreLayerCollision(catLayer, wallLayer, false);
    }

    void Update()
    {
        // Di chuyển tới vị trí mục tiêu với tốc độ chỉ định
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // Kiểm tra nếu đã đến gần mục tiêu, thì đặt mục tiêu mới
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            SetNewRandomTarget();
        }
    }

    // Đặt vị trí đích mới ngẫu nhiên trong bán kính
    void SetNewRandomTarget()
    {
        Vector3 randomDirection = Random.insideUnitSphere * moveRadius;
        randomDirection.y = 0; // Giữ nguyên độ cao y để di chuyển trên mặt phẳng (nếu cần)
        targetPosition = transform.position + randomDirection;
    }

    // Coroutine để thay đổi hướng sau một khoảng thời gian
    IEnumerator ChangeDirectionRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(changeInterval);
            SetNewRandomTarget();
        }
    }
  
}

