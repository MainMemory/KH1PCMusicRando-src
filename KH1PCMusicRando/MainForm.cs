using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YamlDotNet.Serialization;

namespace KH1PCMusicRando
{
	public partial class MainForm : Form
	{
		Settings settings;

		public MainForm()
		{
			InitializeComponent();
		}

		private void EnableExtracted()
		{
			extractedGamesFolderToolStripMenuItem.Checked = true;
			if (Directory.Exists(Path.Combine(settings.ExtractedPath, "kh1")))
			{
				includeKH1CheckBox.Enabled = true;
				includeKH1CheckBox.Checked = settings.IncludeKH1;
			}
			else
				includeKH1CheckBox.Enabled = settings.IncludeKH1 = false;
			if (Directory.Exists(Path.Combine(settings.ExtractedPath, "kh2")))
			{
				includeKH2CheckBox.Enabled = true;
				includeKH2CheckBox.Checked = settings.IncludeKH2;
			}
			else
				includeKH2CheckBox.Enabled = settings.IncludeKH2 = false;
			if (Directory.Exists(Path.Combine(settings.ExtractedPath, "recom")))
			{
				includeReCoMCheckBox.Enabled = true;
				includeReCoMCheckBox.Checked = settings.IncludeReCoM;
			}
			else
				includeReCoMCheckBox.Enabled = settings.IncludeReCoM = false;
			if (Directory.Exists(Path.Combine(settings.ExtractedPath, "bbs")))
			{
				includeBBSCheckBox.Enabled = true;
				includeBBSCheckBox.Checked = settings.IncludeBBS;
			}
			else
				includeBBSCheckBox.Enabled = settings.IncludeBBS = false;
			if (Directory.Exists(Path.Combine(settings.ExtractedPath, "kh3d")))
			{
				includeDDDCheckBox.Enabled = true;
				includeDDDCheckBox.Checked = settings.IncludeDDD;
			}
			else
				includeDDDCheckBox.Enabled = settings.IncludeDDD = false;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			settings = Settings.Load();
			if (settings.ExtractedPath != null && Directory.Exists(settings.ExtractedPath))
			{
				EnableExtracted();
			}
			else
			{
				settings.ExtractedPath = null;
				includeKH1CheckBox.Enabled = settings.IncludeKH1 = false;
				includeKH2CheckBox.Enabled = settings.IncludeKH2 = false;
				includeReCoMCheckBox.Enabled = settings.IncludeReCoM = false;
				includeBBSCheckBox.Enabled = settings.IncludeBBS = false;
				includeDDDCheckBox.Enabled = settings.IncludeDDD = false;
			}
			if (settings.CustomPath != null && Directory.Exists(settings.CustomPath))
				customMusicFolderToolStripMenuItem.Checked = true;
			includeCustomCheckBox.Checked = settings.IncludeCustom;
			dmcaSafeCheckBox.Checked = settings.DMCASafe;
			categorizeSongsCheckBox.Checked = settings.CategorizeSongs;
		}

		private void SaveSettings()
		{
			settings.IncludeKH1 = includeKH1CheckBox.Checked;
			settings.IncludeKH2 = includeKH2CheckBox.Checked;
			settings.IncludeReCoM = includeReCoMCheckBox.Checked;
			settings.IncludeBBS = includeBBSCheckBox.Checked;
			settings.IncludeDDD = includeDDDCheckBox.Checked;
			settings.IncludeCustom = includeCustomCheckBox.Checked;
			settings.DMCASafe = dmcaSafeCheckBox.Checked;
			settings.CategorizeSongs = categorizeSongsCheckBox.Checked;
			settings.Save();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveSettings();
		}

		private void extractedGamesFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var dlg = new Ookii.Dialogs.WinForms.VistaFolderBrowserDialog() { Description = "Select the extracted games directory.", SelectedPath = settings.ExtractedPath })
				if (dlg.ShowDialog(this) == DialogResult.OK)
				{
					settings.ExtractedPath = dlg.SelectedPath;
					EnableExtracted();
				}
		}

		private void customMusicFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var dlg = new Ookii.Dialogs.WinForms.VistaFolderBrowserDialog() { Description = "Select the custom music directory.", SelectedPath = settings.CustomPath })
				if (dlg.ShowDialog(this) == DialogResult.OK)
				{
					settings.CustomPath = dlg.SelectedPath;
					customMusicFolderToolStripMenuItem.Checked = true;
				}
		}

		private static string Base36(long value)
		{
			StringBuilder sb = new StringBuilder();
			while (value > 0)
			{
				int digit = (int)(value % 36);
				if (digit < 10)
					sb.Insert(0, (char)('0' + digit));
				else
					sb.Insert(0, (char)('A' + (digit - 10)));
				value /= 36;
			}
			return sb.ToString();
		}

		private void randomizeButton_Click(object sender, EventArgs e)
		{
			SaveSettings();
			if (seedTextBox.TextLength == 0)
				seedTextBox.Text = Base36(DateTime.Now.Ticks) + Base36((uint)Environment.TickCount);
			Random rand = new Random(seedTextBox.Text.GetHashCode());
			Dictionary<string, List<string>> musicFiles = new Dictionary<string, List<string>>();
			if (settings.IncludeCustom)
				foreach (var dir in new DirectoryInfo(settings.CustomPath ?? Directory.GetCurrentDirectory()).EnumerateDirectories())
				{
					string key = settings.CategorizeSongs ? dir.Name.ToLowerInvariant() : "wild";
					if (!musicFiles.ContainsKey(key))
						musicFiles.Add(key, new List<string>());
					musicFiles[key].AddRange(dir.EnumerateFiles("*.scd", SearchOption.AllDirectories).Select(a => a.FullName));
				}
			if (settings.ExtractedPath != null)
			{
				(bool enabled, InputTrackInfo[] tracks, string folder)[] data =
				{
					(settings.IncludeKH1, InputTrackInfo.kh1_music_list, @"kh1\remastered\amusic"),
					(settings.IncludeKH2, InputTrackInfo.kh2_music_list, "kh2"),
					(settings.IncludeReCoM, InputTrackInfo.recom_music_list, @"recom\STREAM\0001"),
					(settings.IncludeBBS, InputTrackInfo.bbs_music_list, @"bbs\sound\win\bgm"),
					(settings.IncludeDDD, InputTrackInfo.ddd_music_list, @"kh3d\sound\jp\output\BGM")
				};
				foreach (var (enabled, tracks, folder) in data)
					if (enabled)
						foreach (var track in tracks)
							if (!settings.DMCASafe || !track.DMCA)
							{
								string key = settings.CategorizeSongs ? track.Kind.ToLowerInvariant() : "wild";
								if (!musicFiles.ContainsKey(key))
									musicFiles.Add(key, new List<string>());
								musicFiles[key].Add(Path.Combine(settings.ExtractedPath, folder, track.Name));
							}
			}
			var musicCopy = musicFiles.ToDictionary(k => k.Key, v => {
				var tmp = v.Value.ToArray();
				rand.RandomizeArray(tmp);
				return new Queue<string>(tmp);
			});
			Mod mod = new Mod
			{
				Title = "Music Randomizer",
				Description = "Randomizes music. Run the included EXE to randomize the music.",
				Assets = new List<Asset>()
			};
			foreach (var file in OutputTrackInfo.Load())
			{
				var cat = settings.CategorizeSongs ? file.Type[rand.Next(file.Type.Count)].ToLowerInvariant() : "wild";
				if (musicCopy[cat].Count == 0)
				{
					var tmp = musicFiles[cat].ToArray();
					rand.RandomizeArray(tmp);
					musicCopy[cat] = new Queue<string>(tmp);
				}
				string fn = musicCopy[cat].Dequeue();
				mod.Assets.Add(new Asset()
				{
					Method = "copy",
					Name = Path.Combine(@"remastered\amusic", file.Filename),
					Sources = new List<Asset>() { new Asset() { Name = fn } }
				});
				if (file.HasDat)
					mod.Assets.Add(new Asset()
					{
						Method = "copy",
						Name = Path.Combine(@"remastered\amusic", file.Filename.Replace(".bgm", ".dat")),
						Sources = new List<Asset>() { new Asset() { Name = fn } }
					});
			}
			File.WriteAllText("mod.yml", new SerializerBuilder().ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitNull).Build().Serialize(mod));
		}
	}

	static class Extensions
	{
		public static void RandomizeArray<T>(this Random rand, T[] arr)
		{
			int[] keys = new int[arr.Length];
			for (int i = 0; i < arr.Length; i++)
				keys[i] = rand.Next();
			Array.Sort(keys, arr);
		}
	}

	class Mod
	{
		[YamlMember(Alias = "title")]
		public string Title { get; set; }
		[YamlMember(Alias = "description")]
		public string Description { get; set; }
		[YamlMember(Alias = "assets")]
		public List<Asset> Assets { get; set; } = new List<Asset>();
	}

	class Asset
	{
		[YamlMember(Alias = "name")]
		public string Name { get; set; }
		[YamlMember(Alias = "type")]
		public string Type { get; set; }
		[YamlMember(Alias = "method")]
		public string Method { get; set; }
		[YamlMember(Alias = "source")]
		public List<Asset> Sources { get; set; }
	}
}
