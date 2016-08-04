using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GuildWars2Hub
{
    public partial class App : Application
    {
        private static string AdmiralTaidhaCovingtonName => "Admiral Taidha Covington";
        private static string AdmiralTaidhaCovingtonDescription => "Kill Admiral Taidha Covington is a level 50 group event that occurs on Laughing Gull Island. It is the final event of the area's The Campaign Against Taidha Covington meta event.";

        private static string KarkaQueenName => "Karka Queen";
        private static string KarkaQueenDescription => "Defeat the Karka Queen threatening the settlements is the event where you have to defeat the Karka Queen. Completing the event unlocks the Crazed Karka Queen Killer achievement.";

        private static string TequatlTheSunlessName => "Tequatl the Sunless";
        private static string TequatlTheSunlessDescription => "Defeat Tequatl the Sunless is a level 65 group event that occurs on the Splintered Coast in Sparkfly Fen. The event begins with Tequatl the Sunless flying out of the water, eventually landing in front of the player and beginning combat. Though considered one of the smaller dragons, Tequatl is not alone and the fight occurs with dangerous minions summoned to attack the players as well. Players themselves have access to numerous Hylek Turrets and are backed by the formidable Vigil Megalaser.";

        private static string ModniirUlgothName => "Modniir Ulgoth";
        private static string ModniirUlgothDescription => "Defeat Ulgoth the Modniir and his minions is a level 43 group event in Modniir Gorge.";

        private static string SvanirShamanChiefName => "Svanir Shaman Chief";
        private static string SvanirShamanChiefDescription => "Kill the Svanir shaman chief to break his control over the ice elemental is a level 10 event in Wayfarer Foothills. Upon completion, a large chest spawns.";

        private static string MegadestroyerName => "Megadestoyer";
        private static string MegadestroyerDescription => "Kill the megadestroyer before it blows everyone up is a level 66 group event in Mount Maelstrom. It is the final event of the meta event The Battle for Mount Maelstrom.";

        private static string FireElementalName => "Fire Elemental";
        private static string FireElementalDescription => "Destroy the fire elemental created from chaotic energy fusing with the C.L.E.A.N. 5000's energy core is a level 15 group event that occurs in Thaumanova Reactor.";

        private static string TheShattererName => "The Shatterer";
        private static string TheShattererDescription => "Defeat the great jungle wurm is a level 15 group event that occurs in Wychmire Swamp. It is the last part of The Battle for Wychmire Swamp, and a Swamp Chest will spawn upon completion.";

        private static string GreatJungleWurmName => "Great Jungle Wurm";
        private static string GreateJungleWurmDescription => "Defeat Ulgoth the Modniir and his minions is a level 43 group event in Modniir Gorge.";

        private static string ShadowBehemothName => "Shadow Behemoth";
        private static string ShadowBehemothDescription => "Defeat the shadow behemoth is a level 15 event that takes place in Godslost Swamp. While being fought, underworld portals appear, spawning Shades and Aatxes.";

        private static string GolemMarkIIName => "Golem Mark II";
        private static string GolemMarkIIDescription => "Defeat the Inquest's golem Mark II is a level 68 event that occurs in Whitland Flats.";

        private static string ClawOfJormagName => "Claw Of Jormag";
        private static string ClawOfJormagDescription => "Defeat the Claw of Jormag is a level 80 event in Frostwalk Tundra. It is the last event in Breaking the Claw of Jormag where players face down the Claw of Jormag. Upon the dragon's defeat, the Frost Chest will spawn for players.";

        private static string EvolvedJungleWurmName => "Evolved Jungle Wurm";
        private static string EvolvedJungleWurmDescription => "Triple Trouble is a meta event that takes place in the Bloodtide Coast.";

        public App()
        {
            InitializeComponent();

            var viewModel = new
            {
                Title = "Guild Wars 2 Hub",
                ListData = new ObservableCollection<Boss>
                {
                    CreateBoss(AdmiralTaidhaCovingtonName, AdmiralTaidhaCovingtonDescription, new TimeSpan(20, 0, 0)),
                    CreateBoss(TequatlTheSunlessName, TequatlTheSunlessDescription, new TimeSpan(20, 0, 0)),
                    CreateBoss(SvanirShamanChiefName, SvanirShamanChiefDescription, new TimeSpan(20, 15, 0)),
                    CreateBoss(MegadestroyerName, MegadestroyerDescription, new TimeSpan(20, 30, 0)),
                    CreateBoss(FireElementalName, FireElementalDescription, new TimeSpan(20, 45, 0)),
                    CreateBoss(TheShattererName, TheShattererDescription, new TimeSpan(21, 0, 0)),
                    CreateBoss(EvolvedJungleWurmName,EvolvedJungleWurmDescription, new TimeSpan(21, 0, 0)),
                   
                    //new Boss
                    //{
                    //    Name = "Great Jungle Wurm",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Modniir Ulgoth",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Shadow Behemoth",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Golem Mark II",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Karka Queen",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Svanir Shaman Chief",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Claw of Jormag",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Fire Elemental",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Admiral Taidha Covington",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Tequatl the Sunless",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Great Jungle Wurm",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Megadestroyer",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Shadow Behemoth",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "The Shatterer",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Evolved Jungle Wurm",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Svanir Shaman Chief",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Modniir Ulgoth",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Fire Elemental",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Golem Mark II",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Great Jungle Wurm",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Claw of Jormag",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Shadow Behemoth",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Admiral Taidha Covington",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Karka Queen",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Svanir Shaman Chief",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Megadestroyer",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Fire Elemental",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "The Shatterer",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Tequatl the Sunless",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Great Jungle Wurm",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Modniir Ulgoth",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Shadow Behemoth",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Golem Mark II",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Evolved Jungle Wurm",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Svanir Shaman Chief",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Claw of Jormag",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Fire Elemental",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Admiral Taidha Covington",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Great Jungle Wurm",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Megadestroyer",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "Shadow Behemoth",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = "The Shatterer",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = SvanirShamanChiefName,
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = ModniirUlgothName,
                    //    ImageUri = @"..\Resources\image.png",
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                    //new Boss
                    //{
                    //    Name = KarkaQueenName,
                    //    Description = "???",
                    //    SpawnTime = new TimeCounter(TimeSpan.FromSeconds(2160), TimeSpan.FromSeconds(2160))
                    //},
                },
                ListTitle = "My List",
                ListShortName = "List"
            };


            MainPage = new MainPage() { BindingContext = viewModel };
        }

        private static Boss CreateBoss(string name, string description, TimeSpan spawnTime)
        {
            return new Boss
            {
                Name = name,
                Description = description,
                SpawnTime = spawnTime
            };
        }

        

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
