using UnityEngine;

public class Graph : MonoBehaviour {
    [SerializeField]
    Transform point_prefab;

    [SerializeField, Range(10, 100)]
    int resolution = 10;

    
    private void Awake() {
        Vector3 scale = Vector3.one * (2.0f / resolution);
        Vector3 position = Vector3.zero;

        for (int i = 0; i < resolution; i++) {
            Transform point = Instantiate(point_prefab);

            position.x = (i + 0.5f) * (2.0f / resolution) - 1.0f;
            position.y = position.x * position.x * position.x;

            point.localPosition = position;
            point.localScale = scale;

            point.SetParent(transform, false);
        }
    }
}
