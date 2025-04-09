using UnityEngine;

public class Graph : MonoBehaviour {
    [SerializeField]
    Transform point_prefab;

    private void Awake() {
        for (int i = 0; i < 10; i++) {
            Transform point = Instantiate(point_prefab);
            point.localPosition = Vector3.right * ((i + 0.5f) / 5.0f -1.0f);
            point.localScale = Vector3.one / 5.0f;
        }
    }
}
