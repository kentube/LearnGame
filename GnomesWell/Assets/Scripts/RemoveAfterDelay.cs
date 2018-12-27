﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Removes an object after a certain delay.
public class RemoveAfterDelay : MonoBehaviour {
	// How many seconds to wait before removing.
	public float delay = 1.0f;
	void Start () {
		// Kick off the 'Remove' coroutine.
		StartCoroutine("Remove");
	}
	IEnumerator Remove() {
		// Wait 'delay' seconds, and then destroy the
		// gameObject attached to this object.
		yield return new WaitForSeconds(delay);
		Destroy (gameObject);
		// Don't say Destroy(this) - that just destroys this
		// RemoveAfterDelay script.
	}
}