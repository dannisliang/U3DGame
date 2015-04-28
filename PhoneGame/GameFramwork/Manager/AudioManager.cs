using System;

namespace GameFramwork
{
	public class AudioManager
	{
		private static AudioManager instance = null;

		public static AudioManager SharedInstance {
			get {
				if (instance == null) {
					instance = MainComponentManager.AddMainComponent<AudioManager> ();
				}
				return instance;
			}
		}
	}
}

