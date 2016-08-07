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
        private static ImageSource AdmiralTaidhaCovingtonImage => "taidha.png";

        private static string KarkaQueenName => "Karka Queen";
        private static string KarkaQueenDescription => "Defeat the Karka Queen threatening the settlements is the event where you have to defeat the Karka Queen. Completing the event unlocks the Crazed Karka Queen Killer achievement.";
        private static ImageSource KarkaQueenImage => "queen.png";

        private static string TequatlTheSunlessName => "Tequatl the Sunless";
        private static string TequatlTheSunlessDescription => "Defeat Tequatl the Sunless is a level 65 group event that occurs on the Splintered Coast in Sparkfly Fen. The event begins with Tequatl the Sunless flying out of the water, eventually landing in front of the player and beginning combat. Though considered one of the smaller dragons, Tequatl is not alone and the fight occurs with dangerous minions summoned to attack the players as well. Players themselves have access to numerous Hylek Turrets and are backed by the formidable Vigil Megalaser.";
        private static ImageSource TequatlTheSunlessImage => "tequatl.png";

        private static string ModniirUlgothName => "Modniir Ulgoth";
        private static string ModniirUlgothDescription => "Defeat Ulgoth the Modniir and his minions is a level 43 group event in Modniir Gorge.";
        private static ImageSource ModniirUlgothImage => "ulgoth.png";

        private static string SvanirShamanChiefName => "Svanir Shaman Chief";
        private static string SvanirShamanChiefDescription => "Kill the Svanir shaman chief to break his control over the ice elemental is a level 10 event in Wayfarer Foothills. Upon completion, a large chest spawns.";
        private static ImageSource SvanirShamanChiefImage => "maw.png";

        private static string MegadestroyerName => "Megadestoyer";
        private static string MegadestroyerDescription => "Kill the megadestroyer before it blows everyone up is a level 66 group event in Mount Maelstrom. It is the final event of the meta event The Battle for Mount Maelstrom.";
        private static ImageSource MegadestroyerImage => "megades.png";

        private static string FireElementalName => "Fire Elemental";
        private static string FireElementalDescription => "Destroy the fire elemental created from chaotic energy fusing with the C.L.E.A.N. 5000's energy core is a level 15 group event that occurs in Thaumanova Reactor.";
        private static ImageSource FireElementalImage => "fe.png";

        private static string TheShattererName => "The Shatterer";
        private static string TheShattererDescription => "Slay the Shatterer is a group event that occurs in the Lowland Burns. It occurs as the final part of the meta event Kralkatorrik's Legacy.";
        private static ImageSource TheShattererImage => "shatterer.png";

        private static string GreatJungleWurmName => "Great Jungle Wurm";
        private static string GreatJungleWurmDescription => "Defeat the great jungle wurm is a level 15 group event that occurs in Wychmire Swamp. It is the last part of The Battle for Wychmire Swamp, and a Swamp Chest will spawn upon completion.";
        private static ImageSource GreatJungleWurmImage => "wurm.png";

        private static string ShadowBehemothName => "Shadow Behemoth";
        private static string ShadowBehemothDescription => "Defeat the shadow behemoth is a level 15 event that takes place in Godslost Swamp. While being fought, underworld portals appear, spawning Shades and Aatxes.";
        private static ImageSource ShadowBehemothImage => "sb.png";

        private static string GolemMarkIIName => "Golem Mark II";
        private static string GolemMarkIIDescription => "Defeat the Inquest's golem Mark II is a level 68 event that occurs in Whitland Flats.";
        private static ImageSource GolemMarkIIImage => "golem.png";

        private static string ClawOfJormagName => "Claw Of Jormag";
        private static string ClawOfJormagDescription => "Defeat the Claw of Jormag is a level 80 event in Frostwalk Tundra. It is the last event in Breaking the Claw of Jormag where players face down the Claw of Jormag. Upon the dragon's defeat, the Frost Chest will spawn for players.";
        private static ImageSource ClawOfJormagImage => "jormag.png";

        private static string EvolvedJungleWurmName => "Evolved Jungle Wurm";
        private static string EvolvedJungleWurmDescription => "Triple Trouble is a meta event that takes place in the Bloodtide Coast.";
        private static ImageSource EvolvedJungleWurmImage => "triplewurm.png";

        /* Map Meta Events */

        private static string VerdantBrinkName => "Verdant Brink Nighttime";
        private static string VerdantBrinkEventDescription => "Night and the Enemy is a map meta event that occurs in Verdant Brink during the night cycle. It involves securing the various Rally Points and upgrading them, while fending off Mordrem assaults until morning as well as defeating various bosses that appear at night.";
        private static string VerdantBrinkBossDescription => "Once the Pact Choppers descend halfway through the night (20:30 left on the timer until daybreak), bosses appear in the canopy. Each one corresponds to each outpost. Outpost: Noble Crash Site spawns Axemaster Gwyllion, Outpost Jaka Itzel spawns Cotoni and Huetzi, Outpost: Pact Encampment spawns the Wyvern Matriarch, Outpost: Pale Reaver Rally spawns the Wyvern Patriarch, and Outpost: The Ordnance Corps spawns Stavemaster Anwir, Hammermaster Morthwyl, and Bladmaster Cadogg.";
        private static ImageSource VerdantBrinkImage => "verdant.png";

        private static string AuricBasinName => "Octovine";
        private static string AuricBasinEventDescription => "Battle in Tarir is a level 80 meta event that occurs in Auric Basin. Tarir is under assault by the Octovine and the Exalted are attempting to slay it to recapture their city.";
        private static string AuricBasinBossDescription => "Octovines are Mordrem that form barriers around Tarir during the Battle in Tarir. Each octovine has a slime protection that makes it immune to damage until it is removed.";
        private static ImageSource AuricBasinImage => "auric.png";

        private static string TangledDepthsName => "Chak Gerent";
        private static string TangledDepthsEventDescription => "King of the Jungle is the meta-event that exists within Tangled Depths. The event to spawn the Chak Gerent happens every 20 minutes past the hour, at a 2 hour interval rate. Once the 20 minute timer reaches its end, two timers will pop up once more, both having 5 minutes each; giving the people a heads-up that the Gerent is about to spawn. There are 4 lanes that exist, (Rata Novus Lane, Nuhoch Lane, Ogre Lane, and SCAR Lane), all of them having their own mechanics which allows them to spawn the Chak Gerent in order to kill it. Failure to do so will cause the Chak Gerent to burrow straight ahead to the cannon and destroy it in one blow; effectively ending the meta-event in a failure.";
        private static string TangledDepthsBossDescription => "Legendary Chak Gerents are powerful chak which spawn during the King of the Jungle meta-event in each of the four lanes around Ley Line Confluence in Tangled Depths. Killing all four of the Chak Gerents during King of the Jungle is required for the successful completion of the meta-event. The Gerents are called the Chak's 'defensive measure' against the four cannons which are siphoning ley line energy for power.";
        private static ImageSource TangledDepthsImage => "tangled.png";

        private static string DragonsStandName => "Dragon's Stand Assault";
        private static string DragonsStandEventDescription => "Advancing on the Blighting Towers is a map-wide meta event that occurs in Dragon's Stand. The Pact has finally entered Mordremoth's domain, and are assaulting the dragon's defenses in order to reach and finally deal with the jungle dragon itself.";
        private static string DragonsStandBossDescription => "Due to Mordremoth's expansive body, its physical, non-plant-like body is called the \"Mouth of Mordremoth\". Snake-like in appearance, it grows its vines from the base of its tail and remains rooted near a gigantic tree, the Heart of Thorns, within the Dragon's Domain. While the mordrem marched upon Tyria, the Mouth of Mordremoth remained to consume ley energy from the hub that it awoke upon with the intent to use the absorbed magic to annihilate the Pact and all other resistance.";
        private static ImageSource DragonsStandImage => "dragon.png";

        public App()
        {
            InitializeComponent();

            var events = new ObservableCollection<Boss>
            {
                CreateBoss(AdmiralTaidhaCovingtonName, AdmiralTaidhaCovingtonDescription, AdmiralTaidhaCovingtonImage,  new TimeSpan(0, 0, 0)),
                CreateBoss(TequatlTheSunlessName, TequatlTheSunlessDescription, TequatlTheSunlessImage,  new TimeSpan(0, 0, 0)),
                CreateBoss(SvanirShamanChiefName, SvanirShamanChiefDescription, SvanirShamanChiefImage, new TimeSpan(0, 15, 0)),
                CreateBoss(MegadestroyerName, MegadestroyerDescription, MegadestroyerImage,  new TimeSpan(0, 30, 0)),
                CreateBoss(FireElementalName, FireElementalDescription, FireElementalImage,  new TimeSpan(0, 45, 0)),
                CreateBoss(TheShattererName, TheShattererDescription, TheShattererImage,  new TimeSpan(1, 0, 0)),
                CreateBoss(EvolvedJungleWurmName, EvolvedJungleWurmDescription, EvolvedJungleWurmImage, new TimeSpan(1, 0, 0)),
                CreateBoss(GreatJungleWurmName, GreatJungleWurmDescription, GreatJungleWurmImage,  new TimeSpan(1, 15, 0)),
                CreateBoss(ModniirUlgothName, ModniirUlgothDescription, ModniirUlgothImage,  new TimeSpan(1, 30, 0)),
                CreateBoss(ShadowBehemothName, ShadowBehemothDescription, ShadowBehemothImage, new TimeSpan(1, 45, 0)),
                CreateBoss(GolemMarkIIName, GolemMarkIIDescription, GolemMarkIIImage,  new TimeSpan(2, 0, 0)),
                CreateBoss(KarkaQueenName, KarkaQueenDescription, KarkaQueenImage,  new TimeSpan(2, 0, 0)),
                CreateBoss(SvanirShamanChiefName, SvanirShamanChiefDescription, SvanirShamanChiefImage, new TimeSpan(2, 15, 0)),
                CreateBoss(ClawOfJormagName, ClawOfJormagDescription, ClawOfJormagImage,  new TimeSpan(2, 30, 0)),
                CreateBoss(FireElementalName, FireElementalDescription, FireElementalImage,  new TimeSpan(2, 45, 0)),
                CreateBoss(AdmiralTaidhaCovingtonName, AdmiralTaidhaCovingtonDescription, AdmiralTaidhaCovingtonImage,  new TimeSpan(3, 0, 0)),
                CreateBoss(TequatlTheSunlessName, TequatlTheSunlessDescription, TequatlTheSunlessImage,  new TimeSpan(3, 0, 0)),
                CreateBoss(GreatJungleWurmName, GreatJungleWurmDescription, GreatJungleWurmImage,  new TimeSpan(3, 15, 0)),
                CreateBoss(MegadestroyerName, MegadestroyerDescription, MegadestroyerImage,  new TimeSpan(3, 30, 0)),
                CreateBoss(ShadowBehemothName, ShadowBehemothDescription, ShadowBehemothImage, new TimeSpan(3, 45, 0)),
                CreateBoss(TheShattererName, TheShattererDescription, TheShattererImage,  new TimeSpan(4, 0, 0)),
                CreateBoss(EvolvedJungleWurmName, EvolvedJungleWurmDescription, EvolvedJungleWurmImage,  new TimeSpan(4, 0, 0)),
                CreateBoss(SvanirShamanChiefName, SvanirShamanChiefDescription, SvanirShamanChiefImage, new TimeSpan(4, 15, 0)),
                CreateBoss(ModniirUlgothName, ModniirUlgothDescription, ModniirUlgothImage,  new TimeSpan(4, 30, 0)),
                CreateBoss(FireElementalName, FireElementalDescription, FireElementalImage,  new TimeSpan(4, 45, 0)),
                CreateBoss(GolemMarkIIName, GolemMarkIIDescription, GolemMarkIIImage,  new TimeSpan(5, 0, 0)),
                CreateBoss(GreatJungleWurmName, GreatJungleWurmDescription, GreatJungleWurmImage,  new TimeSpan(5, 15, 0)),
                CreateBoss(ClawOfJormagName, ClawOfJormagDescription, ClawOfJormagImage,  new TimeSpan(5, 30, 0)),
                CreateBoss(ShadowBehemothName, ShadowBehemothDescription, ShadowBehemothImage, new TimeSpan(5, 45, 0)),
                CreateBoss(AdmiralTaidhaCovingtonName, AdmiralTaidhaCovingtonDescription, AdmiralTaidhaCovingtonImage,  new TimeSpan(6, 0, 0)),
                CreateBoss(KarkaQueenName, KarkaQueenDescription, KarkaQueenImage,  new TimeSpan(6, 0, 0)),
                CreateBoss(SvanirShamanChiefName, SvanirShamanChiefDescription, SvanirShamanChiefImage, new TimeSpan(6, 15, 0)),
                CreateBoss(MegadestroyerName, MegadestroyerDescription, MegadestroyerImage,  new TimeSpan(6, 30, 0)),
                CreateBoss(FireElementalName, FireElementalDescription, FireElementalImage,  new TimeSpan(6, 45, 0)),
                CreateBoss(TheShattererName, TheShattererDescription, TheShattererImage,  new TimeSpan(3, 0, 0)),
                CreateBoss(TequatlTheSunlessName, TequatlTheSunlessDescription, TequatlTheSunlessImage,  new TimeSpan(7, 0, 0)),
                CreateBoss(GreatJungleWurmName, GreatJungleWurmDescription, GreatJungleWurmImage,  new TimeSpan(7, 15, 0)),
                CreateBoss(ModniirUlgothName, ModniirUlgothDescription, ModniirUlgothImage,  new TimeSpan(7, 30, 0)),
                CreateBoss(ShadowBehemothName, ShadowBehemothDescription, ShadowBehemothImage, new TimeSpan(7, 45, 0)),
                CreateBoss(GolemMarkIIName, GolemMarkIIDescription, GolemMarkIIImage,  new TimeSpan(8, 0, 0)),
                CreateBoss(EvolvedJungleWurmName, EvolvedJungleWurmDescription, EvolvedJungleWurmImage,  new TimeSpan(8, 0, 0)),
                CreateBoss(SvanirShamanChiefName, SvanirShamanChiefDescription, SvanirShamanChiefImage, new TimeSpan(8, 15, 0)),
                CreateBoss(ClawOfJormagName, ClawOfJormagDescription, ClawOfJormagImage,  new TimeSpan(8, 30, 0)),
                CreateBoss(FireElementalName, FireElementalDescription, FireElementalImage,  new TimeSpan(8, 45, 0)),
                CreateBoss(AdmiralTaidhaCovingtonName, AdmiralTaidhaCovingtonDescription, AdmiralTaidhaCovingtonImage,  new TimeSpan(9, 0, 0)),
                CreateBoss(GreatJungleWurmName, GreatJungleWurmDescription, GreatJungleWurmImage,  new TimeSpan(9, 15, 0)),
                CreateBoss(MegadestroyerName, MegadestroyerDescription, MegadestroyerImage,  new TimeSpan(9, 30, 0)),
                CreateBoss(ShadowBehemothName, ShadowBehemothDescription, ShadowBehemothImage, new TimeSpan(9, 45, 0)),
                CreateBoss(TheShattererName, TheShattererDescription, TheShattererImage,  new TimeSpan(10, 0, 0)),
                CreateBoss(SvanirShamanChiefName, SvanirShamanChiefDescription, SvanirShamanChiefImage, new TimeSpan(10, 15, 0)),
                CreateBoss(ModniirUlgothName, ModniirUlgothDescription, ModniirUlgothImage,  new TimeSpan(10, 30, 0)),
                CreateBoss(KarkaQueenName, KarkaQueenDescription, KarkaQueenImage,  new TimeSpan(10, 30, 0)),
                CreateBoss(FireElementalName, FireElementalDescription, FireElementalImage,  new TimeSpan(10, 45, 0)),
                CreateBoss(GolemMarkIIName, GolemMarkIIDescription, GolemMarkIIImage,  new TimeSpan(11, 0, 0)),
                CreateBoss(GreatJungleWurmName, GreatJungleWurmDescription, GreatJungleWurmImage,  new TimeSpan(11, 15, 0)),
                CreateBoss(ClawOfJormagName, ClawOfJormagDescription, ClawOfJormagImage,  new TimeSpan(11, 30, 0)),
                CreateBoss(TequatlTheSunlessName, TequatlTheSunlessDescription, TequatlTheSunlessImage,  new TimeSpan(11, 30, 0)),
                CreateBoss(ShadowBehemothName, ShadowBehemothDescription, ShadowBehemothImage, new TimeSpan(11, 45, 0)),
                CreateBoss(AdmiralTaidhaCovingtonName, AdmiralTaidhaCovingtonDescription, AdmiralTaidhaCovingtonImage,  new TimeSpan(12, 0, 0)),
                CreateBoss(SvanirShamanChiefName, SvanirShamanChiefDescription, SvanirShamanChiefImage, new TimeSpan(12, 15, 0)),
                CreateBoss(MegadestroyerName, MegadestroyerDescription, MegadestroyerImage,  new TimeSpan(12, 30, 0)),
                CreateBoss(EvolvedJungleWurmName, EvolvedJungleWurmDescription, EvolvedJungleWurmImage,  new TimeSpan(12, 30, 0)),
                CreateBoss(FireElementalName, FireElementalDescription, FireElementalImage,  new TimeSpan(12, 45, 0)),
                CreateBoss(TheShattererName, TheShattererDescription, TheShattererImage,  new TimeSpan(13, 0, 0)),
                CreateBoss(GreatJungleWurmName, GreatJungleWurmDescription, GreatJungleWurmImage,  new TimeSpan(13, 15, 0)),
                CreateBoss(ModniirUlgothName, ModniirUlgothDescription, ModniirUlgothImage,  new TimeSpan(13, 30, 0)),
                CreateBoss(ShadowBehemothName, ShadowBehemothDescription, ShadowBehemothImage, new TimeSpan(13, 45, 0)),
                CreateBoss(GolemMarkIIName, GolemMarkIIDescription, GolemMarkIIImage,  new TimeSpan(14, 0, 0)),
                CreateBoss(SvanirShamanChiefName, SvanirShamanChiefDescription, SvanirShamanChiefImage, new TimeSpan(14, 15, 0)),
                CreateBoss(ClawOfJormagName, ClawOfJormagDescription, ClawOfJormagImage,  new TimeSpan(14, 30, 0)),
                CreateBoss(FireElementalName, FireElementalDescription, FireElementalImage,  new TimeSpan(14, 45, 0)),
                CreateBoss(AdmiralTaidhaCovingtonName, AdmiralTaidhaCovingtonDescription, AdmiralTaidhaCovingtonImage,  new TimeSpan(15, 0, 0)),
                CreateBoss(KarkaQueenName, KarkaQueenDescription, KarkaQueenImage,  new TimeSpan(15, 0, 0)),
                CreateBoss(GreatJungleWurmName, GreatJungleWurmDescription, GreatJungleWurmImage,  new TimeSpan(15, 15, 0)),
                CreateBoss(MegadestroyerName, MegadestroyerDescription, MegadestroyerImage,  new TimeSpan(15, 30, 0)),
                CreateBoss(ShadowBehemothName, ShadowBehemothDescription, ShadowBehemothImage, new TimeSpan(15, 45, 0)),
                CreateBoss(TheShattererName, TheShattererDescription, TheShattererImage,  new TimeSpan(16, 0, 0)),
                CreateBoss(TequatlTheSunlessName, TequatlTheSunlessDescription, TequatlTheSunlessImage,  new TimeSpan(16, 0, 0)),
                CreateBoss(SvanirShamanChiefName, SvanirShamanChiefDescription, SvanirShamanChiefImage, new TimeSpan(16, 15, 0)),
                CreateBoss(ModniirUlgothName, ModniirUlgothDescription, ModniirUlgothImage,  new TimeSpan(16, 30, 0)),
                CreateBoss(FireElementalName, FireElementalDescription, FireElementalImage,  new TimeSpan(16, 45, 0)),
                CreateBoss(GolemMarkIIName, GolemMarkIIDescription, GolemMarkIIImage,  new TimeSpan(17, 0, 0)),
                CreateBoss(EvolvedJungleWurmName, EvolvedJungleWurmDescription, EvolvedJungleWurmImage,  new TimeSpan(17, 0, 0)),
                CreateBoss(GreatJungleWurmName, GreatJungleWurmDescription, GreatJungleWurmImage,  new TimeSpan(17, 15, 0)),
                CreateBoss(ClawOfJormagName, ClawOfJormagDescription, ClawOfJormagImage,  new TimeSpan(17, 30, 0)),
                CreateBoss(ShadowBehemothName, ShadowBehemothDescription, ShadowBehemothImage, new TimeSpan(17, 45, 0)),
                CreateBoss(AdmiralTaidhaCovingtonName, AdmiralTaidhaCovingtonDescription, AdmiralTaidhaCovingtonImage,  new TimeSpan(18, 0, 0)),
                CreateBoss(KarkaQueenName, KarkaQueenDescription, KarkaQueenImage,  new TimeSpan(18, 0, 0)),
                CreateBoss(SvanirShamanChiefName, SvanirShamanChiefDescription, SvanirShamanChiefImage, new TimeSpan(18, 15, 0)),
                CreateBoss(MegadestroyerName, MegadestroyerDescription, MegadestroyerImage,  new TimeSpan(18, 30, 0)),
                CreateBoss(FireElementalName, FireElementalDescription, FireElementalImage,  new TimeSpan(18, 45, 0)),
                CreateBoss(TheShattererName, TheShattererDescription, TheShattererImage,  new TimeSpan(19, 0, 0)),
                CreateBoss(TequatlTheSunlessName, TequatlTheSunlessDescription, TequatlTheSunlessImage,  new TimeSpan(19, 0, 0)),
                CreateBoss(GreatJungleWurmName, GreatJungleWurmDescription, GreatJungleWurmImage,  new TimeSpan(19, 15, 0)),
                CreateBoss(ModniirUlgothName, ModniirUlgothDescription, ModniirUlgothImage,  new TimeSpan(19, 30, 0)),
                CreateBoss(ShadowBehemothName, ShadowBehemothDescription, ShadowBehemothImage, new TimeSpan(19, 45, 0)),
                CreateBoss(GolemMarkIIName, GolemMarkIIDescription, GolemMarkIIImage,  new TimeSpan(20, 0, 0)),
                CreateBoss(EvolvedJungleWurmName, EvolvedJungleWurmDescription, EvolvedJungleWurmImage,  new TimeSpan(20, 0, 0)),
                CreateBoss(SvanirShamanChiefName, SvanirShamanChiefDescription, SvanirShamanChiefImage, new TimeSpan(20, 15, 0)),
                CreateBoss(ClawOfJormagName, ClawOfJormagDescription, ClawOfJormagImage,  new TimeSpan(20, 30, 0)),
                CreateBoss(FireElementalName, FireElementalDescription, FireElementalImage,  new TimeSpan(20, 45, 0)),
                CreateBoss(AdmiralTaidhaCovingtonName, AdmiralTaidhaCovingtonDescription, AdmiralTaidhaCovingtonImage,  new TimeSpan(21, 0, 0)),
                CreateBoss(GreatJungleWurmName, GreatJungleWurmDescription, GreatJungleWurmImage,  new TimeSpan(21, 15, 0)),
                CreateBoss(MegadestroyerName, MegadestroyerDescription, MegadestroyerImage,  new TimeSpan(21, 30, 0)),
                CreateBoss(ShadowBehemothName, ShadowBehemothDescription, ShadowBehemothImage, new TimeSpan(21, 45, 0)),
                CreateBoss(TheShattererName, TheShattererDescription, TheShattererImage,  new TimeSpan(22, 0, 0)),
                CreateBoss(SvanirShamanChiefName, SvanirShamanChiefDescription, SvanirShamanChiefImage, new TimeSpan(22, 15, 0)),
                CreateBoss(ModniirUlgothName, ModniirUlgothDescription, ModniirUlgothImage,  new TimeSpan(22, 30, 0)),
                CreateBoss(FireElementalName, FireElementalDescription, FireElementalImage,  new TimeSpan(22, 45, 0)),
                CreateBoss(GolemMarkIIName, GolemMarkIIDescription, GolemMarkIIImage,  new TimeSpan(23, 0, 0)),
                CreateBoss(KarkaQueenName, KarkaQueenDescription, KarkaQueenImage,  new TimeSpan(23, 0 ,0 )),
                CreateBoss(GreatJungleWurmName, GreatJungleWurmDescription, GreatJungleWurmImage,  new TimeSpan(23, 15, 0)),
                CreateBoss(ClawOfJormagName, ClawOfJormagDescription, ClawOfJormagImage,  new TimeSpan(23, 30, 0)),
                CreateBoss(ShadowBehemothName, ShadowBehemothDescription, ShadowBehemothImage, new TimeSpan(23, 45, 0))
            };

            events.CollectionChanged += Events_CollectionChanged;

            var eventEnumerator = events.GetEnumerator();

            var currentTime = DateTime.UtcNow;
            while (true)
            {
                if (!eventEnumerator.MoveNext())
                    return;

                var @event = eventEnumerator.Current;
                if (@event.SpawnTime < currentTime.TimeOfDay - TimeSpan.FromMinutes(15))
                {
                    var expiredEvent = @events.First();
                    events.Remove(expiredEvent);
                    events.Add(expiredEvent);

                    eventEnumerator = events.GetEnumerator();
                }
                else
                    break;
            }

            var viewModel = new
            {
                Title = "Guild Wars 2 Hub",
                ListData = events,
                ListTitle = "My List",
                ListShortName = "List"
            };


            MainPage = new MainPage() { BindingContext = viewModel };
        }

        private void Events_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            
        }

        private static Boss CreateBoss(string name, string description, ImageSource imageSource, TimeSpan spawnTime)
        {
            return new Boss
            {
                Name = name,
                Description = description,
                Image = imageSource,
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
