using Newtonsoft.Json;
using System.IO;

namespace KH1PCMusicRando
{
	class Settings
	{
		public string ExtractedPath { get; set; }
		public string CustomPath { get; set; }
		public bool IncludeKH1 { get; set; }
		public bool IncludeKH2 { get; set; }
		public bool IncludeReCoM { get; set; }
		public bool IncludeBBS { get; set; }
		public bool IncludeDDD { get; set; }
		public bool IncludeCustom { get; set; }
		public bool DMCASafe { get; set; }
		public bool CategorizeSongs { get; set; }

		public static Settings Load()
		{
			if (File.Exists("settings.json"))
				return JsonConvert.DeserializeObject<Settings>(File.ReadAllText("settings.json"));
			return new Settings();
		}

		public void Save() => File.WriteAllText("settings.json", JsonConvert.SerializeObject(this, Formatting.Indented));
	}
}
