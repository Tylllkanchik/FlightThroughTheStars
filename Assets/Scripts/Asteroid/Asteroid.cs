using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Asteroid", menuName = "Asteroid")]
public class Asteroid : ScriptableObject {

    public Sprite sprite;
    public float speed;
    public float rotationM;
    public float radiusM;
}
