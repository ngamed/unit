using UnityEngine;

public sealed class ArrayRandom {
	/// <summary>
	/// https://answers.unity.com/questions/486626/how-can-i-shuffle-alist.html
	/// </summary>
	public static void shuffle<T>(T[] array) {
		T t;

		int count = array.Length;

		for(int index = 0; index < count; index++) {
			int r = index + (int) (Random.value * (count - index));

			t = array[r];
			array[r] = array[index];
			array[index] = t;
		}
	}


	public static T select<T>(T[] array) {
		return array[Random.Range(0, array.Length)];
	}
}
