﻿using UnityEngine;
using System.Collections;

public class Position : MonoBehaviour {

    void OnDrawGizmos(){
        Gizmos.DrawWireSphere(transform.position, 1);
    } // void OnDrawGizmos()

} // public class Position : MonoBehaviour
