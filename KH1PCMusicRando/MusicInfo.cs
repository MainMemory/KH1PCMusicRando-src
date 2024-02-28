using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace KH1PCMusicRando
{
	[JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	class OutputTrackInfo
	{
		public string Filename { get; set; }
		public bool HasDat { get; set; }
		public string Title { get; set; }
		public List<string> Type { get; set; }

		public static OutputTrackInfo[] Load() => JsonConvert.DeserializeObject<OutputTrackInfo[]>(System.IO.File.ReadAllText("musiclist.json"));
	}

	class InputTrackInfo
	{
		public string Name { get; set; }
		public string Kind { get; set; }
		public bool DMCA { get; set; }

		public InputTrackInfo(string name, string kind, bool dmca = false)
		{
			Name = name;
			Kind = kind;
			DMCA = dmca;
		}

		internal static readonly InputTrackInfo[] kh1_music_list = {
			// some music in kh1 is found in .dat folders and others in .bgm folders and somtimes both.
			// the ones in both .dat and .bgm folders are duplicates so you can ignore one of those.
			// DP
			new InputTrackInfo("music101.dat\\music101.win32.scd", "Field"), // Deep Jungle
			new InputTrackInfo("music102.dat\\music102.win32.scd", "Battle"), // Having a Wild Time
			new InputTrackInfo("music157.bgm\\music157.win32.scd", "Battle"), // Holy Bananas
			// OC
			new InputTrackInfo("music103.bgm\\music103.win32.scd", "Field"), // Olympus Coliseum
			new InputTrackInfo("music164.bgm\\music164.win32.scd", "Battle"), // Road To Hero
			new InputTrackInfo("music120.bgm\\music120.win32.scd", "Battle"), // Go For It
			// TT
			new InputTrackInfo("music104.dat\\music104.win32.scd", "Field"), // Traverse Town
			new InputTrackInfo("music112.dat\\music112.win32.scd", "Battle"), // Hand In Hand
			new InputTrackInfo("music184.bgm\\music184.win32.scd", "Field"), // Merlin Magical House
			// DI
			new InputTrackInfo("music105.dat\\music105.win32.scd", "Field"), // Destiny Islands
			new InputTrackInfo("music119.dat\\music119.win32.scd", "Battle"), // Busting Up On The Beach
			// WL
			new InputTrackInfo("music116.dat\\music116.win32.scd", "Field"), // Welcome To Wonderland
			new InputTrackInfo("music118.bgm\\music118.win32.scd", "Battle"), // To Our Surprise
			// AG
			new InputTrackInfo("music127.dat\\music127.win32.scd", "Field"), // A Day In Agrabah
			new InputTrackInfo("music128.dat\\music128.win32.scd", "Battle"), // Arabian Dream
			// HT
			new InputTrackInfo("music144.dat\\music144.win32.scd", "Field", true),  // This Is Halloween
			new InputTrackInfo("music165.bgm\\music165.win32.scd", "Field", true),  // This Is Halloween (Alternative)
			new InputTrackInfo("music149.dat\\music149.win32.scd", "Battle"), // Spooks Of Halloween Town
			// HB
			new InputTrackInfo("music152.dat\\music152.win32.scd", "Field"), // Hollow Bastion
			new InputTrackInfo("music153.dat\\music153.win32.scd", "Battle"), // Scherzo Di Notte
			// EW
			new InputTrackInfo("music154.dat\\music154.win32.scd", "Field"), // End Of The World
			new InputTrackInfo("music155.dat\\music155.win32.scd", "Battle"), // Fragments Of Sorrow
			// PP
			new InputTrackInfo("music129.dat\\music129.win32.scd", "Field"), // Captain Hook Pirate Ship
			new InputTrackInfo("music146.dat\\music146.win32.scd", "Battle"), // Pirate Gigue
			new InputTrackInfo("music130.dat\\music130.win32.scd", "Field"), // Never Land Sky
			// PN
			new InputTrackInfo("music117.dat\\music117.win32.scd", "Field"), // A Very Small Wish
			new InputTrackInfo("music121.dat\\music121.win32.scd", "Battle"), // Monstrous Monstro
			// AT
			new InputTrackInfo("music140.dat\\music140.win32.scd", "Field", true),  // Under The Sea
			new InputTrackInfo("music147.dat\\music147.win32.scd", "Battle"), // An Adventure In Atlantica
			// HAW
			new InputTrackInfo("music141.dat\\music141.win32.scd", "Field"), // Winnie The Pooh
			new InputTrackInfo("music158.bgm\\music158.win32.scd", "Field"), // Bounce-O-Rama
			// Boss/Special
			new InputTrackInfo("music097.bgm\\music097.win32.scd", "Battle"), //Dissapeared (No Intro)
			new InputTrackInfo("music098.bgm\\music098.win32.scd", "Battle"), //One Winged Angel (No Intro)
			new InputTrackInfo("music099.bgm\\music099.win32.scd", "Boss"), // Dissapeared
			new InputTrackInfo("music111.bgm\\music111.win32.scd", "Boss"), // Shrouding Dark Cloud
			new InputTrackInfo("music131.dat\\music131.win32.scd", "Boss"), // Night Of Fate
			new InputTrackInfo("music145.bgm\\music145.win32.scd", "Boss"), // Destiny Force
			new InputTrackInfo("music150.bgm\\music150.win32.scd", "Boss"), // Squirming Evil
			new InputTrackInfo("music151.bgm\\music151.win32.scd", "Boss"), // The Deep End
			new InputTrackInfo("music156.bgm\\music156.win32.scd", "Boss"), // Guardando Nel Buio
			new InputTrackInfo("music173.bgm\\music173.win32.scd", "Boss"), // No Time To Think
			new InputTrackInfo("music174.bgm\\music174.win32.scd", "Boss"), // An Intense Situation
			new InputTrackInfo("music185.bgm\\music185.win32.scd", "Boss"), // Forze Del Male
			new InputTrackInfo("music194.bgm\\music194.win32.scd", "Battle"), //Guardando Nel Buio (No Intro)
			new InputTrackInfo("music196.bgm\\music196.win32.scd", "Boss"), // One Winged Angel
			new InputTrackInfo("music197.bgm\\music197.win32.scd", "Boss", true),  // Night On Bald Mountain
			// Other
			new InputTrackInfo("music110.bgm\\music110.win32.scd", "Title"), // Dearly Beloved
			new InputTrackInfo("music193.bgm\\music193.win32.scd", "Title"), // Dearly Beloved Reprise
			new InputTrackInfo("music122.dat\\music122.win32.scd", "Battle"), // Blast Away Gummi Ship I
			new InputTrackInfo("music123.dat\\music123.win32.scd", "Battle"), // Blast Away Gummi Ship II
			new InputTrackInfo("music124.dat\\music124.win32.scd", "Field"), // Shipmeisters Humoresque
			new InputTrackInfo("music125.dat\\music125.win32.scd", "Field"), // Precious Stars In The Sky
			new InputTrackInfo("music148.dat\\music148.win32.scd", "Battle"), // Blast Away Gummi Ship III
			new InputTrackInfo("music114.bgm\\music114.win32.scd", "Cutscene"), // Unknown 1 [Heartless Has Come, Pt.3]
			new InputTrackInfo("music142.bgm\\music142.win32.scd", "Cutscene"), // Dive Into The Heart (Part 9)
			new InputTrackInfo("music143.bgm\\music143.win32.scd", "Cutscene", true),  // Mickey Mouse Club March
			new InputTrackInfo("music160.bgm\\music160.win32.scd", "Cutscene"), // Kairi I
			new InputTrackInfo("music161.bgm\\music161.win32.scd", "Cutscene"), // Kairi II
			new InputTrackInfo("music163.bgm\\music163.win32.scd", "Cutscene"), // Villains Of A Sort
			new InputTrackInfo("music170.bgm\\music170.win32.scd", "Cutscene"), // A Piece Of Peace
			new InputTrackInfo("music172.bgm\\music172.win32.scd", "Cutscene"), // A Walk In Adante
			new InputTrackInfo("music176.bgm\\music176.win32.scd", "Cutscene"), // Friends In My Heart
			new InputTrackInfo("music178.bgm\\music178.win32.scd", "Cutscene"), // Treasured Memories
			new InputTrackInfo("music180.bgm\\music180.win32.scd", "Cutscene"), // Kairi III
			new InputTrackInfo("music187.bgm\\music187.win32.scd", "Cutscene"), // Just An Itty Bitty Too Much
			new InputTrackInfo("music188.bgm\\music188.win32.scd", "Cutscene"), // It Began With A Letter
			// new InputTrackInfo("music106.bgm\\music106.win32.scd", "Cutscene"), //Where Is This (Part 1) (no loop)
			// new InputTrackInfo("music107.bgm\\music107.win32.scd", "Cutscene"), //Where Is This (Part 2) (no loop)
			// new InputTrackInfo("music108.bgm\\music108.win32.scd", "Cutscene"), //Where Is This (Part 3b) (no loop)
			// new InputTrackInfo("music109.bgm\\music109.win32.scd", "Cutscene"), //Where Is This (Part 4) (no loop)
			// new InputTrackInfo("music113.bgm\\music113.win32.scd", "Cutscene"), //The Heartless Has Come [Heartless Has Come, Pt.1] (no loop)
			// new InputTrackInfo("music115.bgm\\music115.win32.scd", "Cutscene"), //Where Is This (Part 3a) [Heartless Has Come, Pt.2] (no loop)
			// new InputTrackInfo("music126.bgm\\music126.win32.scd", "Cutscene"), //Turning The Key (no loop)
			// new InputTrackInfo("music132.bgm\\music132.win32.scd", "Cutscene"), //Dive Into The Heart (Parts 1-8) (would this actually work? there are 8 tracks in 1 here)
			// new InputTrackInfo("music159.bgm\\music159.win32.scd", "Cutscene"), //Once Upon a Time (no loop)
			// new InputTrackInfo("music162.bgm\\music162.win32.scd", "Cutscene"), //Villains Of A Sort (Short)
			// new InputTrackInfo("music166.bgm\\music166.win32.scd", "Cutscene"), //Strange Whispers (Part 5) (no loop)
			// new InputTrackInfo("music167.bgm\\music167.win32.scd", "Cutscene"), //Strange Whispers (Part 1) (no loop)
			// new InputTrackInfo("music168.bgm\\music168.win32.scd", "Cutscene"), //Strange Whispers
			// new InputTrackInfo("music169.bgm\\music169.win32.scd", "Cutscene"), //Strange Whispers (Part 3) (no loop)
			// new InputTrackInfo("music171.bgm\\music171.win32.scd", "Cutscene"), //Strange Whispers (Part 4) (no loop)
			// new InputTrackInfo("music175.bgm\\music175.win32.scd", "Cutscene"), //Unknown 3 [Kairi In Cabin] (no loop)
			// new InputTrackInfo("music177.bgm\\music177.win32.scd", "Cutscene"), //Tricksy Clock (no loop)
			// new InputTrackInfo("music179.bgm\\music179.win32.scd", "Cutscene"), //Miracle (no loop)
			// new InputTrackInfo("music181.bgm\\music181.win32.scd", "Cutscene"), //Hikari [Sora's Sacrifice] (no loop)
			// new InputTrackInfo("music182.bgm\\music182.win32.scd", "Cutscene"), //Mickey Mouse Club March (Intro) [Queen's Castle Drumroll] (no loop)
			// new InputTrackInfo("music183.bgm\\music183.win32.scd", "Cutscene"), //Oopsy-Daisy (no loop)
			// new InputTrackInfo("music186.bgm\\music186.win32.scd", "Cutscene"), //Unknown 2 [Plenty Of Hunny!] (no loop)
			// new InputTrackInfo("music189.bgm\\music189.win32.scd", "Cutscene"), //Blast Away Gummi Ship I (Sting 2) (no loop)
			// new InputTrackInfo("music190.bgm\\music190.win32.scd", "Cutscene"), //Blast Away Gummi Ship I (Sting) (no loop)
			// new InputTrackInfo("music191.bgm\\music191.win32.scd", "Cutscene"), //Beyond The Door (no loop)
			// new InputTrackInfo("music192.bgm\\music192.win32.scd", "Cutscene"), //Always On My Mind (Final Mix Version) (no loop)
			// new InputTrackInfo("music100.win32.scd", "Cutscene"), //empty 1kb file
			// new InputTrackInfo("music137.win32.scd", "Cutscene"), //empty 1kb file
		};

		internal static readonly InputTrackInfo[] kh2_music_list = {
			new InputTrackInfo("bgm\\music050.win32.scd", "Field"), // Dive into the Heart -Destati-
			new InputTrackInfo("bgm\\music051.win32.scd", "Battle"), // Fragments of Sorrow
			new InputTrackInfo("bgm\\music052.win32.scd", "Field"), // The Afternoon Streets
			new InputTrackInfo("bgm\\music053.win32.scd", "Battle"), // Working Together
			new InputTrackInfo("bgm\\music054.win32.scd", "Field"), // Sacred Moon
			new InputTrackInfo("bgm\\music055.win32.scd", "Battle"), // Deep Drive
			new InputTrackInfo("bgm\\music059.win32.scd", "Boss"), // A Fight to the Death
			new InputTrackInfo("bgm\\music060.win32.scd", "Boss"), // Darkness of the Unknown I
			new InputTrackInfo("bgm\\music061.win32.scd", "Boss"), // Darkness of the Unknown II
			new InputTrackInfo("bgm\\music062.win32.scd", "Boss"), // Darkness of the Unknown III
			new InputTrackInfo("bgm\\music063.win32.scd", "Boss"), // The 13th Reflection
			new InputTrackInfo("bgm\\music064.win32.scd", "Field"), // What a Surprise?!
			new InputTrackInfo("bgm\\music065.win32.scd", "Battle"), // Happy Holidays!
			new InputTrackInfo("bgm\\music066.win32.scd", "Boss"), // The Other Promise
			new InputTrackInfo("bgm\\music067.win32.scd", "Boss"), // Rage Awakened
			new InputTrackInfo("bgm\\music068.win32.scd", "Field"), // Cavern of Remembrance
			new InputTrackInfo("bgm\\music069.win32.scd", "Battle"), // Deep Anxiety
			new InputTrackInfo("bgm\\music081.win32.scd", "Battle"), // Beneath the Ground
			new InputTrackInfo("bgm\\music082.win32.scd", "Field"), // The Escapade
			new InputTrackInfo("bgm\\music084.win32.scd", "Battle"), // Arabian Daydream
			new InputTrackInfo("bgm\\music085.win32.scd", "Battle"), // Byte Striking
			new InputTrackInfo("bgm\\music086.win32.scd", "Battle"), // Spooks of Halloween Town
			new InputTrackInfo("bgm\\music087.win32.scd", "Boss"), // Disappeared
			new InputTrackInfo("bgm\\music088.win32.scd", "Cutscene"), // Sora
			new InputTrackInfo("bgm\\music089.win32.scd", "Cutscene"), // Friends in My Heart
			new InputTrackInfo("bgm\\music090.win32.scd", "Cutscene"), // Riku
			new InputTrackInfo("bgm\\music091.win32.scd", "Cutscene"), // Kairi
			new InputTrackInfo("bgm\\music092.win32.scd", "Cutscene"), // A Walk in Andante
			new InputTrackInfo("bgm\\music093.win32.scd", "Cutscene"), // Villains of a Sort
			new InputTrackInfo("bgm\\music094.win32.scd", "Cutscene"), // Organization XIII
			new InputTrackInfo("bgm\\music095.win32.scd", "Cutscene"), // Apprehension
			new InputTrackInfo("bgm\\music096.win32.scd", "Cutscene"), // Courage
			new InputTrackInfo("bgm\\music097.win32.scd", "Cutscene"), // Laughter and Merriment
			new InputTrackInfo("bgm\\music098.win32.scd", "Cutscene"), // Hesitation
			new InputTrackInfo("bgm\\music099.win32.scd", "Cutscene"), // Missing You
			new InputTrackInfo("bgm\\music100.win32.scd", "Field"), // The Underworld
			new InputTrackInfo("bgm\\music101.win32.scd", "Field"), // Waltz of the Damned
			new InputTrackInfo("bgm\\music102.win32.scd", "Battle"), // What Lies Beneath
			new InputTrackInfo("bgm\\music103.win32.scd", "Field"), // Olympus Coliseum
			new InputTrackInfo("bgm\\music104.win32.scd", "Battle"), // Dance of the Daring
			new InputTrackInfo("bgm\\music106.win32.scd", "Atlantica", true), // Under the Sea (Japanese)
			new InputTrackInfo("bgm\\music107.win32.scd", "Atlantica"), // Ursula's Revenge (Japanese)
			new InputTrackInfo("bgm\\music108.win32.scd", "Atlantica", true), // Part of Your World (Japanese)
			new InputTrackInfo("bgm\\music109.win32.scd", "Atlantica"), // A New Day is Dawning (Japanese)
			new InputTrackInfo("bgm\\music110.win32.scd", "Boss"), // The Encounter
			new InputTrackInfo("bgm\\music111.win32.scd", "Boss"), // Sinister Shadows
			new InputTrackInfo("bgm\\music112.win32.scd", "Battle"), // Fields of Honor
			new InputTrackInfo("bgm\\music113.win32.scd", "Atlantica"), // Swim This Way (Japanese)
			new InputTrackInfo("bgm\\music114.win32.scd", "Boss"), // Tension Rising
			new InputTrackInfo("bgm\\music115.win32.scd", "Boss"), // The Corrupted
			new InputTrackInfo("bgm\\music116.win32.scd", "Field"), // The Home of Dragons
			new InputTrackInfo("bgm\\music117.win32.scd", "Boss"), // Rowdy Rumble
			new InputTrackInfo("bgm\\music118.win32.scd", "Field"), // Lazy Afternoons
			new InputTrackInfo("bgm\\music119.win32.scd", "Battle"), // Sinister Sundowns
			new InputTrackInfo("bgm\\music120.win32.scd", "Battle"), // Beneath the Ground
			new InputTrackInfo("bgm\\music121.win32.scd", "Boss"), // Desire for All That is Lost
			new InputTrackInfo("bgm\\music122.win32.scd", "Field"), // Let's Sing and Dance! I
			new InputTrackInfo("bgm\\music123.win32.scd", "Field"), // Let's Sing and Dance! II
			new InputTrackInfo("bgm\\music127.win32.scd", "Field"), // A Day in Agrabah
			new InputTrackInfo("bgm\\music128.win32.scd", "Battle"), // Arabian Dream
			new InputTrackInfo("bgm\\music129.win32.scd", "Field"), // Isn't It Lovely
			new InputTrackInfo("bgm\\music130.win32.scd", "Field"), // Neverland Sky (KH I)
			new InputTrackInfo("bgm\\music131.win32.scd", "Boss"), // Dance to the Death
			new InputTrackInfo("bgm\\music133.win32.scd", "Field"), // Magical Mystery
			new InputTrackInfo("bgm\\music134.win32.scd", "Battle"), // Working Together
			new InputTrackInfo("bgm\\music135.win32.scd", "Field"), // Space Paranoids
			new InputTrackInfo("bgm\\music136.win32.scd", "Battle"), // Byte Bashing
			new InputTrackInfo("bgm\\music137.win32.scd", "Field"), // A Twinkle in the Sky
			new InputTrackInfo("bgm\\music138.win32.scd", "Battle"), // Shipmeister's Shanty
			new InputTrackInfo("bgm\\music139.win32.scd", "Field"), // Gearing Up
			new InputTrackInfo("bgm\\music140.win32.scd", "Atlantica", true), // Under the Sea (KH I)
			new InputTrackInfo("bgm\\music141.win32.scd", "Field"), // Winnie the Pooh
			new InputTrackInfo("bgm\\music142.win32.scd", "Field"), // Crossing the Finish Line
			new InputTrackInfo("bgm\\music143.win32.scd", "Field", true), // Mickey Mouse Club March
			new InputTrackInfo("bgm\\music144.win32.scd", "Field", true), // This is Halloween
			new InputTrackInfo("bgm\\music145.win32.scd", "Boss"), // Vim and Vigor
			new InputTrackInfo("bgm\\music146.win32.scd", "Cutscene"), // Roxas
			new InputTrackInfo("bgm\\music147.win32.scd", "Battle"), // An Adventure in Atlantica (KH I)
			new InputTrackInfo("bgm\\music148.win32.scd", "Field"), // Blast Off!
			new InputTrackInfo("bgm\\music149.win32.scd", "Battle"), // Spooks of Halloween Town
			new InputTrackInfo("bgm\\music150.win32.scd", "Boss"), // Squirming Evil (KH I)
			new InputTrackInfo("bgm\\music151.win32.scd", "Boss"), // The 13th Struggle
			new InputTrackInfo("bgm\\music152.win32.scd", "Field"), // Reviving Hollow Bastion
			new InputTrackInfo("bgm\\music153.win32.scd", "Battle"), // Scherzo Di Notte
			new InputTrackInfo("bgm\\music154.win32.scd", "Field"), // Nights of the Cursed
			new InputTrackInfo("bgm\\music155.win32.scd", "Battle"), // He's a Pirate (No Intro)
			new InputTrackInfo("bgm\\music156.win32.scd", "Boss"), // Guardando nel buio (KH I)
			new InputTrackInfo("bgm\\music158.win32.scd", "Field"), // Bounce-O-Rama
			new InputTrackInfo("bgm\\music159.win32.scd", "Battle"), // Bounce-O-Rama (Speed Up Ver.)
			new InputTrackInfo("bgm\\music164.win32.scd", "Battle"), // Road to a Hero
			new InputTrackInfo("bgm\\music185.win32.scd", "Boss"), // The 13th Dilemma
			new InputTrackInfo("bgm\\music186.win32.scd", "Field"), // Adventures in the Savannah
			new InputTrackInfo("bgm\\music187.win32.scd", "Battle"), // Savannah Pride
			new InputTrackInfo("bgm\\music188.win32.scd", "Boss"), // One-Winged Angel
			new InputTrackInfo("bgm\\music189.win32.scd", "Field"), // Monochrome Dreams
			new InputTrackInfo("bgm\\music190.win32.scd", "Battle"), // Old Friends, Old Rivals
			new InputTrackInfo("bgm\\music506.win32.scd", "Atlantica", true), // Under the Sea (English)
			new InputTrackInfo("bgm\\music507.win32.scd", "Atlantica"), // Ursula's Revenge (English)
			new InputTrackInfo("bgm\\music508.win32.scd", "Atlantica", true), // Part of Your World (English)
			new InputTrackInfo("bgm\\music509.win32.scd", "Atlantica"), // A New Day is Dawning (English)
			new InputTrackInfo("bgm\\music513.win32.scd", "Atlantica"), // Swim This Way (English)
			new InputTrackInfo("bgm\\music517.win32.scd", "Boss"), // Rowdy Rumble (Timeless River)
			new InputTrackInfo("bgm\\music521.win32.scd", "Boss"), // Desire for All That is Lost (Timeless River)
			new InputTrackInfo("bgm\\music530.win32.scd", "Battle"), // He's a Pirate
			new InputTrackInfo("vagstream\\End_Piano.win32.scd", "Title"), // Dearly Beloved -Reprise-
			new InputTrackInfo("vagstream\\GM1_Asteroid.win32.scd", "Battle"), // Asteroid Attack
			new InputTrackInfo("vagstream\\GM2_Highway.win32.scd", "Battle"), // Hazardous Highway
			new InputTrackInfo("vagstream\\GM3_Cloud.win32.scd", "Battle"), // Cloudchasers
			new InputTrackInfo("vagstream\\GM4_Floating.win32.scd", "Battle"), // Floating in Bliss
			new InputTrackInfo("vagstream\\GM5_Senkan.win32.scd", "Battle"), // Battleship Bravery
			new InputTrackInfo("vagstream\\Title.win32.scd", "Title") // Dearly Beloved
		};

		internal static readonly InputTrackInfo[] recom_music_list = {
			new InputTrackInfo("01F_Town_B.win32.scd", "Battle"),  // Hand in Hand
			new InputTrackInfo("01F_Town_F.win32.scd", "Field"),  // Traverse Town
			new InputTrackInfo("03F_Hercul.win32.scd", "Field"),  // Olympus Coliseum
			new InputTrackInfo("03F_Hercules_B.win32.scd", "Battle"),  // Go for It
			new InputTrackInfo("17_Halloween_F.win32.scd", "Field", true),  // This is Halloween
			new InputTrackInfo("18_Helloween_B.win32.scd", "Battle"),  // Spooks of Halloween Town
			new InputTrackInfo("19_Alice_Field.win32.scd", "Field"),  // Welcome to Wonderland
			new InputTrackInfo("20_Event_13thFloor.win32.scd", "Field"),  // The 13th Floor
			new InputTrackInfo("21_Alice_Battle.win32.scd", "Battle"),  // To Our Surprise
			new InputTrackInfo("22_PeterPan_Field.win32.scd", "Field"),  // Captain Hook's Pirate Ship
			new InputTrackInfo("23_PeterPan_Battle.win32.scd", "Battle"),  // Pirate's Gigue
			new InputTrackInfo("24_Pinocchio_Field.win32.scd", "Field"),  // A Very Small Wish
			new InputTrackInfo("25_Aladdin_F.win32.scd", "Field"),  // A Day in Agrabah
			new InputTrackInfo("26_Aladdin_B.win32.scd", "Battle"),  // Arabian Dream
			new InputTrackInfo("27_Pinocchio_B.win32.scd", "Battle"),  // Monstrous Monstro
			new InputTrackInfo("28_Forget_F.win32.scd", "Field"),  // Castle Oblivion
			new InputTrackInfo("29_Forget_B.win32.scd", "Battle"),  // Forgotten Challenge
			new InputTrackInfo("30_Twilight_F.win32.scd", "Field"),  // Lazy Afternoons
			new InputTrackInfo("31_Twilight_B.win32.scd", "Battle"),  // Sinister Sundown
			new InputTrackInfo("32_Destiny_F.win32.scd", "Field"),  // Destiny Islands (Re:Chain of Memories Version)
			new InputTrackInfo("33_Destiny_B.win32.scd", "Battle"),  // Night of Fate (Re:Chain of Memories Version)
			new InputTrackInfo("36_WinnieThePooh.win32.scd", "Field"),  // Winnie the Pooh
			new InputTrackInfo("38_UnderTheSea.win32.scd", "Field", true),  // Under the Sea
			new InputTrackInfo("39_LittleMermaid_B.win32.scd", "Battle"),  // An Adventure in Atlantica
			new InputTrackInfo("42_Hollow_F.win32.scd", "Field"),  // Hollow Bastion
			new InputTrackInfo("43_Hollow_B.win32.scd", "Battle"),  // Scherzo Di Notte
			new InputTrackInfo("44_PooGame1.win32.scd", "Field"),  // March-A-Long
			new InputTrackInfo("45_PoohGame2.win32.scd", "Battle"),  // Dash-A-Long
			// boss/special
			new InputTrackInfo("16_XIIIBoss1.win32.scd", "Boss"),  // The 13th Struggle (Re:Chain of Memories Version)
			new InputTrackInfo("34_Boss_RikuAnsem.win32.scd", "Boss"),  // Revenge of Chaos
			new InputTrackInfo("35_Boss_NiseRiku.win32.scd", "Boss"),  // The Force in You
			new InputTrackInfo("37_LastBoss1.win32.scd", "Boss"),  // Graceful Assassin
			new InputTrackInfo("40_LastBoss2.win32.scd", "Boss"),  // Scythe of Petals
			new InputTrackInfo("41_LastBoss3.win32.scd", "Boss"),  // Lord of the Castle
			new InputTrackInfo("Boss1.win32.scd", "Boss"),  // Struggle Away
			new InputTrackInfo("Boss2_World.win32.scd", "Boss"),  // The Fight for My Friends
			new InputTrackInfo("Event1_Kinpak.win32.scd", "Boss"),  // Face It!
			// Other
			new InputTrackInfo("Title.win32.scd", "Title"),  // Dearly Beloved (Re:Chain of Memories Version)
			new InputTrackInfo("12_Event_Yuttari.win32.scd", "Cutscene"),  // La Pace
			new InputTrackInfo("13_Event_Namine.win32.scd", "Cutscene"),  // Naminé
			new InputTrackInfo("14_Event_Odayaka.win32.scd", "Cutscene"),  // Piccolo Resto
			new InputTrackInfo("15_Event_XIII.win32.scd", "Cutscene"),  // Thirteenth Discretion
			new InputTrackInfo("Event_Unrest.win32.scd", "Cutscene"),  // Disquieting
			new InputTrackInfo("Event2_.win32.scd", "Cutscene"),  // Just Wondering
			new InputTrackInfo("Event4.win32.scd", "Cutscene"),  // Scent of Silence
		};

		internal static readonly InputTrackInfo[] bbs_music_list = {
			new InputTrackInfo("001sinde_f.win32.scd", "Field", true),  // Bibbidi-Bobbidi-Boo (Castle of Dreams Field Music)
			new InputTrackInfo("002sinde_b.win32.scd", "Battle"), // Castle Escapade (Castle of Dreams Battle Music)
			new InputTrackInfo("003nemure_f.win32.scd", "Field"), // The Silent Forest (Enchanted Dominion Field Music)
			new InputTrackInfo("004nemure_b.win32.scd", "Battle"), // The Rustling Forest (Enchanted Dominion Battle Music)
			new InputTrackInfo("005syugyo_f.win32.scd", "Field"), // The Promised Beginning (The Land of Departure Field Music)
			new InputTrackInfo("006syugyo_b.win32.scd", "Battle"), // Future Masters (The Land of Departure Battle Music)
			new InputTrackInfo("007shira_f.win32.scd", "Field"), // The Secret Whispers (Dwarf Woodlands Field Music)
			new InputTrackInfo("008shira_b.win32.scd", "Battle"), // Risky Romp (Dwarf Woodlands Battle Music)
			new InputTrackInfo("009raydi_f.win32.scd", "Field"), // Radiant Garden (Radiant Garden Field Music)
			new InputTrackInfo("010raydi_b.win32.scd", "Battle"), // Black Garden (Radiant Garden Battle Music)
			new InputTrackInfo("011distow_f.win32.scd", "Field", true),  // Mickey Mouse March (Disney Town Field Music)
			new InputTrackInfo("012distow_b.win32.scd", "Battle"), // Up Down Adventure (Disney Town Battle Music)
			new InputTrackInfo("013never_f.win32.scd", "Field"), // Daydream upon Neverland (Neverland Field Music)
			new InputTrackInfo("014never_b.win32.scd", "Battle"), // Neverland's Scherzo (Neverland Battle Music)
			new InputTrackInfo("015herc_f.win32.scd", "Field"), // Olympus Coliseum (Olympus Coliseum Field Music)
			new InputTrackInfo("016herc_b.win32.scd", "Battle"), // Go for It! (Olympus Coliseum Battle Music)
			new InputTrackInfo("017riro_f.win32.scd", "Field"), // Hau'oli, Hau'oli (Deep Space Field Music)
			new InputTrackInfo("018riro_b.win32.scd", "Battle"), // Mákaukau? (Deep Space Battle Music)
			new InputTrackInfo("019iensid_f.win32.scd", "Field"), // Magical Mystery (Mysterious Tower Field Music)
			new InputTrackInfo("020iensid_b.win32.scd", "Battle"), // Working Together (Mysterious Tower Battle Music)
			new InputTrackInfo("021kouya_f.win32.scd", "Field"), // Keyblade Graveyard Horizon
			new InputTrackInfo("022disice_f.win32.scd", "Field"), // Destiny Islands (Birth by Sleep Version)
			new InputTrackInfo("023tsusin_f.win32.scd", "Field"), // Dearly Dreams
			new InputTrackInfo("030youki.win32.scd", "Cutscene"), // Innocent Times
			new InputTrackInfo("031isamashi.win32.scd", "Cutscene"), // Cheers for the Brave
			new InputTrackInfo("032odayaka.win32.scd", "Cutscene"), // Peaceful Hearts
			new InputTrackInfo("033fuon.win32.scd", "Cutscene"), // Drops of Poison
			new InputTrackInfo("034kanasii.win32.scd", "Cutscene"), // Tears of the Light
			new InputTrackInfo("035kinpaku.win32.scd", "Cutscene"), // Shaded Truths
			new InputTrackInfo("036seisin.win32.scd", "Field"), // Dive into the Heart -Destati-
			new InputTrackInfo("037yami.win32.scd", "Cutscene"), // Beyond the Door
			new InputTrackInfo("038ria_deai.win32.scd", "Cutscene"), // Eternal Moments
			new InputTrackInfo("050title.win32.scd", "Title"), // Dearly Beloved (Birth by Sleep Version)
			new InputTrackInfo("051worldmap.win32.scd", "Field"), // The Worlds
			new InputTrackInfo("060tera.win32.scd", "Battle"), // Terra
			new InputTrackInfo("061aqua.win32.scd", "Cutscene"), // Aqua
			new InputTrackInfo("062ven.win32.scd", "Cutscene"), // Ventus
			new InputTrackInfo("063kairi1.win32.scd", "Cutscene"), // Kairi (Birth by Sleep Version)
			new InputTrackInfo("066peet.win32.scd", "Cutscene"), // Hero or Heel
			new InputTrackInfo("067disvill.win32.scd", "Cutscene"), // Villains of a Sort
			new InputTrackInfo("068zea.win32.scd", "Cutscene"), // Xehanort
			new InputTrackInfo("069braig.win32.scd", "Cutscene"), // Organization XIII
			new InputTrackInfo("070key_l.win32.scd", "Cutscene"), // The Key of Light
			new InputTrackInfo("071key_d.win32.scd", "Cutscene"), // The Key of Darkness
			new InputTrackInfo("072key_l_d.win32.scd", "Battle"), // The Key
			new InputTrackInfo("073kizuna.win32.scd", "Cutscene"), // Destiny's Union
			new InputTrackInfo("074zack.win32.scd", "Cutscene"), // A Date with Fate
			new InputTrackInfo("100ice1_128.win32.scd", "Field"), // It's a Small World
			new InputTrackInfo("101ice1_132.win32.scd", "Field"), // It's a Small World
			new InputTrackInfo("102ice_2.win32.scd", "Field"), // Dessert Paradise
			new InputTrackInfo("103fruit.win32.scd", "Field"), // Fresh Fruit Balls
			new InputTrackInfo("104dice.win32.scd", "Field"), // Dice & Shine
			new InputTrackInfo("105poomini.win32.scd", "Field"), // March-A-Long
			new InputTrackInfo("106cartrace.win32.scd", "Battle"), // Go! Go! Rumble Racer
			new InputTrackInfo("107syugyo.win32.scd", "Field"), // The Promised Beginning (The Land of Departure Field Music) (Command Board)
			new InputTrackInfo("108riro.win32.scd", "Field"), // Hau'oli, Hau'oli (Deep Space Field Music) (Command Board)
			new InputTrackInfo("109training.win32.scd", "Battle"), // Road to a Hero (Birth by Sleep Version)
			new InputTrackInfo("113kh1tit.win32.scd", "Title"), // Dearly Beloved (From KH1, used at Battle Report)
			new InputTrackInfo("114raceview.win32.scd", "Field"), // Big Race
			// new InputTrackInfo("116icon.win32.scd", "Field"), //Dearly Beloved (Birth by Sleep Version) (10-Second Version)
			new InputTrackInfo("117short_l2.win32.scd", "Field"), // Another Side - Battle Ver. - (Birth by Sleep Version)
			new InputTrackInfo("118gumi.win32.scd", "Field"), // Blast Away! -Gummi Ship II- (From Original KH1)
			new InputTrackInfo("119desti.win32.scd", "Field"), // Destiny Islands (From Original KH1)
			new InputTrackInfo("120hand.win32.scd", "Battle"), // Hand in Hand (From Original KH1)
			// new InputTrackInfo("123rev.win32.scd", "Field"), //Mysterious Figure's Time Reverse Loop
			new InputTrackInfo("124dp_amb.win32.scd", "Field"), // Ambient Wind Sounds from Destroyed Land of Departure
			new InputTrackInfo("125yami_f.win32.scd", "Field"), // Night of the Dark Dream (Realm of Darkness Field Music)
			new InputTrackInfo("126yami_b.win32.scd", "Battle"), // Night of Tragedy (Realm of Darkness Battle Music)
			// Boss/Special
			new InputTrackInfo("040anba_b1.win32.scd", "Boss"), // The Tumbling
			new InputTrackInfo("041anba_b2.win32.scd", "Boss"), // Unforgettable
			new InputTrackInfo("042dis_b1.win32.scd", "Boss"), // Vim and Vigor -Birth by Sleep Version-
			new InputTrackInfo("043dis_b2.win32.scd", "Boss"), // The Encounter -Birth by Sleep Version-
			new InputTrackInfo("044vanita_b.win32.scd", "Boss"), // Enter the Darkness
			new InputTrackInfo("045anthem_b.win32.scd", "Boss"), // Black Powder
			new InputTrackInfo("046last_b1.win32.scd", "Boss"), // Unbreakable Chains
			new InputTrackInfo("047last_b2.win32.scd", "Boss"), // Dismiss
			new InputTrackInfo("048hanyo_b1.win32.scd", "Boss"), // Extreme Encounters
			new InputTrackInfo("049hanyo_b2.win32.scd", "Boss"), // Destiny's Force
			new InputTrackInfo("110han_bt1.win32.scd", "Boss"), // Rowdy Rumble -Birth by Sleep Version-
			new InputTrackInfo("111han_bt2.win32.scd", "Boss"), // Shrouding Dark Cloud -Birth by Sleep Version-
			new InputTrackInfo("112rage_bt.win32.scd", "Boss"), // Rage Awakened -The Origin-
			new InputTrackInfo("115boss.win32.scd", "Boss"), // Enter the Void
			new InputTrackInfo("122nazono.win32.scd", "Boss"), // Dark Impetus
			new InputTrackInfo("127Xeha_b.win32.scd", "Boss"), // Forze dell Oscurita
			new InputTrackInfo("128Eraqu_b.win32.scd", "Boss"), // Master, Tell Me the Truth
			new InputTrackInfo("129Pure_b.win32.scd", "Boss"), // Hunter of the Dark
			new InputTrackInfo("130Mons_b.win32.scd", "Boss"), // Monstrous Monstro -Arena Ver.-
		};

		// thanks to 13th Vessel for the names of all these tracks
		internal static readonly InputTrackInfo[] ddd_music_list = {
			new InputTrackInfo("bgm_001.win32.scd", "Field"),  // Traverse in Trance
			new InputTrackInfo("bgm_002.win32.scd", "Field"), // One for All
			new InputTrackInfo("bgm_003.win32.scd", "Field"), // The Fun Fair
			new InputTrackInfo("bgm_004.win32.scd", "Field"), // A Very Small Wish
			new InputTrackInfo("bgm_005.win32.scd", "Field", true), // Symphony No.6 "Pastoral" Op.68
			new InputTrackInfo("bgm_006.win32.scd", "Field", true), // The Nutcracker Suite Op.71
			new InputTrackInfo("bgm_007.win32.scd", "Field", true), // L'Apprenti Sorcier
			new InputTrackInfo("bgm_008.win32.scd", "Boss", true), // A Night on the Bare Mountain
			new InputTrackInfo("bgm_009.win32.scd", "Field"), // La Cloche
			new InputTrackInfo("bgm_010.win32.scd", "Field"), // Magical Mystery
			new InputTrackInfo("bgm_011.win32.scd", "Field"), // Access the Grid
			new InputTrackInfo("bgm_012.win32.scd", "Field"), // Sacred Distance
			new InputTrackInfo("bgm_013.win32.scd", "Field"), // Sacred Moon
			new InputTrackInfo("bgm_014.win32.scd", "Battle"), // Hand to Hand
			new InputTrackInfo("bgm_015.win32.scd", "Battle"), // All for One
			new InputTrackInfo("bgm_016.win32.scd", "Battle"), // Prankster's Party
			new InputTrackInfo("bgm_017.win32.scd", "Battle"), // Monstrous Monstro
			new InputTrackInfo("bgm_018.win32.scd", "Battle"), // Le Sanctuaire
			new InputTrackInfo("bgm_019.win32.scd", "Battle"), // Working Together
			new InputTrackInfo("bgm_020.win32.scd", "Battle"), // Digital Domination
			new InputTrackInfo("bgm_021.win32.scd", "Battle"), // Deep Drop
			new InputTrackInfo("bgm_022.win32.scd", "Battle"), // Deep Drive
			new InputTrackInfo("bgm_023.win32.scd", "Boss"), // Majestic Wings
			new InputTrackInfo("bgm_024.win32.scd", "Boss"), // UNTAMABLE
			new InputTrackInfo("bgm_025.win32.scd", "Boss"), // Ice-hot Lobster
			new InputTrackInfo("bgm_026.win32.scd", "Boss"), // Gigabyte Mantis
			new InputTrackInfo("bgm_027.win32.scd", "Boss"), // Rowdy Rumble
			new InputTrackInfo("bgm_028.win32.scd", "Boss"), // The Encounter
			new InputTrackInfo("bgm_029.win32.scd", "Boss"), // L'Oscurità dell'Ignot
			new InputTrackInfo("bgm_030.win32.scd", "Boss"), // L'Eminenza Oscura I
			new InputTrackInfo("bgm_031.win32.scd", "Boss"), // L'Eminenza Oscura II
			new InputTrackInfo("bgm_032.win32.scd", "Boss"), // L'Impeto Oscuro
			new InputTrackInfo("bgm_033.win32.scd", "Boss"), // Destiny's Force
			new InputTrackInfo("bgm_034.win32.scd", "Boss"), // Shrouding Dark Cloud
			new InputTrackInfo("bgm_035.win32.scd", "Battle"), // Dream Matchup
			new InputTrackInfo("bgm_036.win32.scd", "Battle"), // The Flick Finalist
			new InputTrackInfo("bgm_037.win32.scd", "Field"), // The World of Dream Drops
			new InputTrackInfo("bgm_038.win32.scd", "Title"), // Dearly Beloved
			new InputTrackInfo("bgm_039.win32.scd", "Cutscene"), // Innocent Times
			new InputTrackInfo("bgm_040.win32.scd", "Cutscene"), // Cheers for the Brave
			new InputTrackInfo("bgm_041.win32.scd", "Cutscene"), // Peaceful Hearts
			new InputTrackInfo("bgm_042.win32.scd", "Cutscene"), // Drops of Poison
			new InputTrackInfo("bgm_043.win32.scd", "Cutscene"), // Tears of the Light
			new InputTrackInfo("bgm_044.win32.scd", "Cutscene"), // Shaded Truths
			new InputTrackInfo("bgm_045.win32.scd", "Cutscene"), // Broken Reality
			new InputTrackInfo("bgm_046.win32.scd", "Cutscene"), // Ever After
			new InputTrackInfo("bgm_047.win32.scd", "Cutscene"), // Sora
			new InputTrackInfo("bgm_048.win32.scd", "Cutscene"), // Riku
			new InputTrackInfo("bgm_050.win32.scd", "Battle"), // Road to a Hero
			new InputTrackInfo("bgm_051.win32.scd", "Cutscene"), // Villains of a Sort
			new InputTrackInfo("bgm_052.win32.scd", "Cutscene"), // Strange Whispers
			new InputTrackInfo("bgm_053.win32.scd", "Boss"), // Night of Fate
			new InputTrackInfo("bgm_059.win32.scd", "Cutscene"), // The Key of Light
			new InputTrackInfo("bgm_060.win32.scd", "Cutscene"), // The Key of Darkness
			new InputTrackInfo("bgm_061.win32.scd", "Cutscene"), // Xehanort
			new InputTrackInfo("bgm_062.win32.scd", "Cutscene"), // Xehanort -The Early Years-
			new InputTrackInfo("bgm_063.win32.scd", "Cutscene"), // Xigbar
			new InputTrackInfo("bgm_065.win32.scd", "Cutscene"), // Organization XIII
			new InputTrackInfo("bgm_066.win32.scd", "Cutscene"), // Destiny's Union
			new InputTrackInfo("bgm_067.win32.scd", "Cutscene"), // Dream Eaters
			new InputTrackInfo("bgm_068.win32.scd", "Cutscene"), // TWISTER -KINGDOM MIX- "1st Edit"
			new InputTrackInfo("bgm_069.win32.scd", "Cutscene"), // CALLING -KINGDOM MIX- "1st Edit"
			new InputTrackInfo("bgm_070.win32.scd", "Cutscene"), // "Fantasia" Dearly Beloved ~Strings~
			new InputTrackInfo("bgm_071.win32.scd", "Cutscene"), // "Fantasia" Dearly Beloved ~Piano~
			new InputTrackInfo("bgm_072.win32.scd", "Cutscene", true), // L' apprenti Sorcier ~Part 1~
			new InputTrackInfo("bgm_073.win32.scd", "Cutscene", true), // L' apprenti Sorcier ~Part 2~
			new InputTrackInfo("bgm_074.win32.scd", "Cutscene", true), // L' apprenti Sorcier ~Part 3~
			new InputTrackInfo("bgm_075.win32.scd", "Cutscene"), // The Dream
			new InputTrackInfo("bgm_076.win32.scd", "Cutscene"), // The Nightmare
			new InputTrackInfo("bgm_077.win32.scd", "Cutscene"), // Link to All
			new InputTrackInfo("bgm_078.win32.scd", "Cutscene"), // Distant from You...
			new InputTrackInfo("bgm_083.win32.scd", "Cutscene"), // Sweet Spirits
			new InputTrackInfo("bgm_084.win32.scd", "Cutscene"), // Ready to Rush
			new InputTrackInfo("bgm_085.win32.scd", "Cutscene"), // Victor's Pride
			new InputTrackInfo("bgm_086.win32.scd", "Battle"), // Keyblade Cycle
			new InputTrackInfo("bgm_087.win32.scd", "Battle"), // Storm Diver
			new InputTrackInfo("bgm_088.win32.scd", "Boss"), // Wild Blue
			new InputTrackInfo("bgm_089.win32.scd", "Field"), // My Heart's Descent
			//new InputTrackInfo("bgm_091.win32.scd", "Cutscene"), // Dream Drop Distance -The Next Awakening-
			new InputTrackInfo("bgm_093.win32.scd", "Boss"), // The Eye of Darkness
			new InputTrackInfo("bgm_094.win32.scd", "Boss"), // The Dread of Night
			new InputTrackInfo("bgm_095.win32.scd", "Cutscene"), // SOMEDAY -KINGDOM MIX-
			//new InputTrackInfo("bgm_097.win32.scd", "Cutscene"), // Oopsy-Daisy (no loop)
			new InputTrackInfo("bgm_098.win32.scd", "Cutscene"), // TWISTER -KINGDOM MIX- "2nd Edit"
			new InputTrackInfo("bgm_099.win32.scd", "Cutscene"), // CALLING -KINGDOM MIX- "2nd Edit"
			// not doing all the Symphony of Sorcery Reality Shift tracks
			new InputTrackInfo("bgm_112.win32.scd", "Title"), // Dearly Beloved - KH2
			new InputTrackInfo("bgm_113.win32.scd", "Title"), // Dearly Beloved - KH2 ~Reprise~
			new InputTrackInfo("bgm_114.win32.scd", "Cutscene"), // Roxas
			new InputTrackInfo("bgm_115.win32.scd", "Cutscene"), // Ventus
			new InputTrackInfo("bgm_116.win32.scd", "Boss"), // Rinzler Recompiled
		};
	}
}
