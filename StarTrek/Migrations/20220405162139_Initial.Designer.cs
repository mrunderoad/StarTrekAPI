﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarTrek.Models;

namespace StarTrek.Solution.Migrations
{
    [DbContext(typeof(StarTrekContext))]
    [Migration("20220405162139_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("StarTrek.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bio")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CharacterId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            Bio = "Captain of the USS Enterprise NCC-1701",
                            Name = "James T. Kirk"
                        },
                        new
                        {
                            CharacterId = 2,
                            Bio = "Helmsman on the USS Enterprise NCC-1701",
                            Name = "Hikaru Sulu"
                        },
                        new
                        {
                            CharacterId = 3,
                            Bio = "Chief Communications Officer on the USS Enterprise NCC-1701",
                            Name = "Nyota Uhura"
                        },
                        new
                        {
                            CharacterId = 4,
                            Bio = "Chief Science Officer on the USS Enterprise NCC-1701",
                            Name = "Spock"
                        },
                        new
                        {
                            CharacterId = 5,
                            Bio = "Chief Medical Officer on the USS Enterprise NCC-1701",
                            Name = "Leonard McCoy"
                        },
                        new
                        {
                            CharacterId = 6,
                            Bio = "Chief Engineer on the USS Enterprise NCC-1701",
                            Name = "Montgomery Scott"
                        },
                        new
                        {
                            CharacterId = 7,
                            Bio = "First Officer on the USS Enterprise NCC-1701",
                            Name = "Pavel Chekov"
                        },
                        new
                        {
                            CharacterId = 8,
                            Bio = "Captain of the USS Enterprise C",
                            Name = "Jean Luc Picard"
                        },
                        new
                        {
                            CharacterId = 9,
                            Bio = "Chief Engineer on the USS Enterprise C",
                            Name = "Geordi LeForge"
                        },
                        new
                        {
                            CharacterId = 10,
                            Bio = "Chief of Security on the USS Enterprise C",
                            Name = "Worf"
                        },
                        new
                        {
                            CharacterId = 11,
                            Bio = "Commander on the USS Enterprise C",
                            Name = "William Riker"
                        },
                        new
                        {
                            CharacterId = 12,
                            Bio = "Counselor on the USS Enterprise C",
                            Name = "Dianna Troi"
                        },
                        new
                        {
                            CharacterId = 13,
                            Bio = "Former Chief of Security on the USS Enterprise C",
                            Name = "Dana Yar"
                        },
                        new
                        {
                            CharacterId = 14,
                            Bio = "Chief Medical Officer on the USS Enterprise C",
                            Name = "Beverly Crusher"
                        },
                        new
                        {
                            CharacterId = 15,
                            Bio = "Ensign aboard the USS Enterprise-C, training to become a Starfleet Officer.",
                            Name = "Wesley Crusher"
                        },
                        new
                        {
                            CharacterId = 16,
                            Bio = "Inventor of the first Warp Drive.",
                            Name = "Zefram Cochrane"
                        },
                        new
                        {
                            CharacterId = 17,
                            Bio = "Member of the Q Continuum. Q is the reason the Borg now know about humanity.",
                            Name = "Q"
                        },
                        new
                        {
                            CharacterId = 18,
                            Bio = "Ambassador of Vulcan and father of Spock",
                            Name = "Sarek"
                        });
                });

            modelBuilder.Entity("StarTrek.Models.TrekEvent", b =>
                {
                    b.Property<int>("TrekEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Date")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("TrekEventId");

                    b.ToTable("TrekEvents");

                    b.HasData(
                        new
                        {
                            TrekEventId = 1,
                            Date = 1986,
                            Description = "The crew of the USS Enterprise return back to Earth after their voyage to save Spock, only to find that an alien life-form probing Earth. Earth is destroyed, forcing the crew to find a way to travel back in time to prevent Earth's destruction."
                        },
                        new
                        {
                            TrekEventId = 2,
                            Date = 2026,
                            Description = "World War III starts on Earth. Eco-Terrorists attack the world. 37 Million people die."
                        },
                        new
                        {
                            TrekEventId = 3,
                            Date = 2032,
                            Description = "The creator of the warp drive: Zefram Cochrane, is born."
                        },
                        new
                        {
                            TrekEventId = 4,
                            Date = 2053,
                            Description = "World War III comes to an end. The world is in shambles after a long nuclear war. The aftermath of the war leaves a death rate of 600 Million people."
                        },
                        new
                        {
                            TrekEventId = 5,
                            Date = 2063,
                            Description = "Zefram Cochrane successful launches the first space craft using warp technology into space, The Pheonix. This craft is seen by a Vulcan ship passing by Earth's solar system. The Vulcans land on Earth to meet humanity and welcome them into and Zefram Cochrane is held in a high status. The events of this date are rewritten when the crew of the USS Enterprise C have to travel back in time to stop the Borg from destroying Earth and preventing the launch of the first craft. Captain Jean Luc Picard and his crew successfully thwart the Borg and help Zefram Cochrane launch his."
                        },
                        new
                        {
                            TrekEventId = 6,
                            Date = 2079,
                            Description = "Earth is finally recovering from the nuclear war."
                        },
                        new
                        {
                            TrekEventId = 7,
                            Date = 2119,
                            Description = "Zefram Cochrane sets off from his home on Alpha Centauri on an adventure. The world, never hearing back from him again presumes that he is dead."
                        },
                        new
                        {
                            TrekEventId = 8,
                            Date = 2156,
                            Description = "Star of the Earth and Ramulan War"
                        },
                        new
                        {
                            TrekEventId = 9,
                            Date = 2160,
                            Description = "Earth-Ramulan War comes to a close with the Battle of Cheron, which results in Earth inflicting a humiliating defeat to the Romulans. The Neutral Zone is then later established."
                        },
                        new
                        {
                            TrekEventId = 10,
                            Date = 2161,
                            Description = "The United Federation of Planets is founded by Earth, Tellar, Vulcan and Andoria."
                        },
                        new
                        {
                            TrekEventId = 11,
                            Date = 2165,
                            Description = "Sarek, Vulcan's future Ambassador and Spock's Father is born."
                        },
                        new
                        {
                            TrekEventId = 12,
                            Date = 2222,
                            Description = "Montgomery Scott is born."
                        },
                        new
                        {
                            TrekEventId = 13,
                            Date = 2227,
                            Description = "Leonard McCoy is born."
                        },
                        new
                        {
                            TrekEventId = 14,
                            Date = 2230,
                            Description = "Spock and Hikaru Sulu are born."
                        },
                        new
                        {
                            TrekEventId = 15,
                            Date = 2233,
                            Description = "James T. Kirk and Nyota Uhura is born."
                        },
                        new
                        {
                            TrekEventId = 16,
                            Date = 2245,
                            Description = "Pavel Chekov is born. The USS Enterprise, a Constitution class vessel is launched under the command of Robert April, on a five-year mission of exploration."
                        },
                        new
                        {
                            TrekEventId = 17,
                            Date = 2250,
                            Description = "The USS Enterprise is refitted and renamed NCC-1701. It is launched on a second five-year mission under the command of Captain Christopher Pike."
                        },
                        new
                        {
                            TrekEventId = 18,
                            Date = 2266,
                            Description = "James T Kirk is appointed to Captain of the USS Enterprise NCC-1701. Montgomery Scott 'Scotty' is appointed Chief Engineer. Leonard McCoy 'Bones' is appointed Chief Medical Officer. Hikaru Sulu is appointed Helmsman. Nyota Uhura is appointed Chief Communications Officer. Pavel Chekov is appointed First Officer. Spock is appointed Chief Science Officer. The Enterprise sets out on a 5 year mission to chart out planets, explore and discover new life forms."
                        },
                        new
                        {
                            TrekEventId = 19,
                            Date = 2270,
                            Description = "The USS Enterprise returns home from it's 5 year journey. Captain Kirk is promoted to Admiral and the Enterprise undergoes maintenance and refitting."
                        },
                        new
                        {
                            TrekEventId = 20,
                            Date = 2073,
                            Description = "Admiral Kirk and a new crew take off on a new 5 year voyage in the newly refitted Enterprise. An unknown life-form named V'ger is causing destruction in Klingon space and is approaching the Earth. Kirk leads a mission to investigate and hopefully stop this threat. The threat is avoided but at great cost."
                        },
                        new
                        {
                            TrekEventId = 21,
                            Date = 2279,
                            Description = "The USS Enterprise UCC-1701 returns from it's voyage and is retired from active duty and is repurposed as a training vessel."
                        },
                        new
                        {
                            TrekEventId = 22,
                            Date = 2285,
                            Description = "Admiral Kirk oversees a training exercise aboard the Enterprise NCC-1701. Kahn, an old enemy of Kirk and the crew of the Enterprise takes a science vessel captive to get revenge against the crew of the Enterprise. Spock dies to save the crew of the Enterprise. Upon returning home the Enterprise is marked for complete decommission. After learning that Spock's spirit is still alive, the crew steal the Enterprise to return to the planet where Spock's body was laid to rest in hopes of reviving him. The Enterprise is destroyed to prevent it from landing in enemy hands. The crew of the Enterprise steal a Klingon Warbird vessel."
                        },
                        new
                        {
                            TrekEventId = 23,
                            Date = 2286,
                            Description = "The crew of the Enterprise returns home to find Earth getting destroyed. They travel back in time 100 years to try and prevent Earth's destruction. The newly refit USS Yorktown NCC-1717 is renamed the USS Enterprise NCC-1701-A and is launched on its maiden voyage with Admiral Kirk as it's Captain."
                        },
                        new
                        {
                            TrekEventId = 24,
                            Date = 2287,
                            Description = "A group of separatists take Federation Ambassadors of Earth, Klingon and Ramulas hostage on Nimbus III. Captain Kirk and the crew of the Enterprise is asked to intercept and save the hostages."
                        },
                        new
                        {
                            TrekEventId = 25,
                            Date = 2293,
                            Description = "The Klingon moon of Praxis is destroyed and the Klingon Empire decided to make peace with the Federation. A group of rebel Klingon who oppose this peace treaty, plan to attack the location of the peace treaty. Kirk under command of the Enterprise and Hikaru Sulu, newly appointed Captain of the USS Excelsior intervene and stop the attack. Admiral Kirk joins the newly built Enterprise NCC 1701-B and it's Captain, John Harriman, on a launching mission. The ship is struck by the Nexus and Kirk is lost, and presumed dead."
                        },
                        new
                        {
                            TrekEventId = 26,
                            Date = 2305,
                            Description = "Jean-Luc Picard is born in LaBarre, France on Earth"
                        },
                        new
                        {
                            TrekEventId = 27,
                            Date = 2311,
                            Description = "The Tomed Incident was an alleged terrorist attack by extremist Romulan Admiral Aventeer Vokar and 5 crewmates. Their ship impacted with an asteroid base in the Foxtrot center and and its quantum singularity drive caused a massive explosion disrupting space-time throughout the sector and wiping out dozens of asteroid bases and at least one starship, the USS Agamemnon. Thousands of lives were said to be lost. This incident led to the Klingon Empire siding with Federation Forces and the retreat of the Imperial Fleet. Two months later the Treaty of Alegron is signed banning the development of cloaking weapons in the Federation in exchange for the Star Empire's agreement to withdraw behind its borders and to recall all of its diplomatic missions and citizens."
                        },
                        new
                        {
                            TrekEventId = 28,
                            Date = 2324,
                            Description = "Beverly Howard (Crusher) is born in Copernicus City, Luna"
                        },
                        new
                        {
                            TrekEventId = 29,
                            Date = 2327,
                            Description = "Jean-Luc Picard graduates from Starfleet Academy on Earth"
                        },
                        new
                        {
                            TrekEventId = 30,
                            Date = 2333,
                            Description = "Jean-Luc Picard becomes the Captain of the USS Stargazer."
                        },
                        new
                        {
                            TrekEventId = 31,
                            Date = 2335,
                            Description = "Geordi La Forge is born in Mogadishu, Somalia. William T. Riker is born in Valdez, Alaska"
                        },
                        new
                        {
                            TrekEventId = 32,
                            Date = 2336,
                            Description = "Deanna Troi is born on Betazed."
                        },
                        new
                        {
                            TrekEventId = 33,
                            Date = 2337,
                            Description = "Tasha yar is born in a failed Federation colony on Turkana IV"
                        },
                        new
                        {
                            TrekEventId = 34,
                            Date = 2340,
                            Description = "Worf, son of Mogh, is born on the Kilingon homeworld, Qo'noS"
                        },
                        new
                        {
                            TrekEventId = 35,
                            Date = 2395,
                            Description = "Episode: All good things, TNG Series Finale, The future segment of the episode in which a retired Picard jumps through time as a continuation of humanities continuing trial by the Q continuum, to investigate a spatial anomaly while his friends question Picard's mental health"
                        },
                        new
                        {
                            TrekEventId = 36,
                            Date = 2387,
                            Description = "A star in the Romulan Empire goes Supernova. Ambassador Spock attempts to counter the resulting shockwave using Red Matter, but is unable to save the planet Romulus from destruction. Spock and the Romulan mining ship Narada, commanded by Nero, are dragged into a black hole created by the Red Matter detonation and arrive in the past. Nero's arrival in 2233 and subsequent attack on the USS Kelvin creates the Kelvin Timeline."
                        },
                        new
                        {
                            TrekEventId = 37,
                            Date = 2379,
                            Description = "The events of Star Trek: Nemesis, Discovery of previously unknown Android named 'B-4', a less advanced android designed by Dr.Soong and brother to LT. Commander Data. Lt. Commander Data sacrifices his Life to save Picard and the crew of the Enterprise"
                        },
                        new
                        {
                            TrekEventId = 38,
                            Date = 2375,
                            Description = "The events of Star Trek: Insurrection. Data is transferred to observe the Ba'ku on a joint mission between the Federation and the Son'a. While investigating a sudden malfunction of data that has jeopardized the safety of the observing task force, the Enterprise discovers that the Ba'ku planet has effectively made the inhabitants immortal, that the Son'a are seeking to exploit the resource to reverse their rapidly declining health and in doing so will destroy the planet in the process"
                        },
                        new
                        {
                            TrekEventId = 39,
                            Date = 2373,
                            Description = "The events of Star Trek: First Contact. The Battle of Sector 001 occurs with a Starfleet Task Force engaging in a running battle with a Borg cube en route to Earth. The USS Defiant (NX-74205) is severely damaged but not destroyed, with the crew evacuated to the Enterprise. The USS Enterprise (NCC-1701-E) follows a Borg sphere through a temporal rift and events shift at that point to 2063."
                        },
                        new
                        {
                            TrekEventId = 40,
                            Date = 2372,
                            Description = "Sovereign-class USS Enterprise (NCC-1701-E) is launched under the command of Captain Jean-Luc Picard."
                        },
                        new
                        {
                            TrekEventId = 41,
                            Date = 2371,
                            Description = "The events of Star Trek Generations. The USS Enterprise (NCC-1701-D)'s stardrive section is destroyed by a warp core breach; the saucer section containing the crew makes a forced landing on Veridian III. The ship is subsequently declared a total loss. James T. Kirk reappears from the temporal continuum in which he had been since his disappearance in 2293. Kirk is killed on Veridian III. (Kirk is resurrected a month later in a subsequent story written by William Shatner, called The Return.)"
                        },
                        new
                        {
                            TrekEventId = 42,
                            Date = 2367,
                            Description = "The Borg assimilate Captain Jean-Luc Picard; the Battle of Wolf 359 is fought 7.7 light years from Earth in Sector 001. The battle results in the loss of 39 Starfleet vessels and over 11,000 lives. With the task force lost, the Borg continue to Earth. Picard is rescued and the Borg cube is destroyed via the actions of the crew of the Enterprise-D."
                        },
                        new
                        {
                            TrekEventId = 43,
                            Date = 2370,
                            Description = "The end of Star Trek: The Next Generation series."
                        },
                        new
                        {
                            TrekEventId = 44,
                            Date = 2370,
                            Description = "The beginning of Star Trek: The Next Generation. Jean-Luc Picard is appointed captain of the USS Enterprise(NCC-1701-D), William T. Riker is appointed first officer, Data is appointed second officer operations officer, Geordi La Forge is appointed helmsman and later chief engineer, Tasha Yar is appointed chief of security, Worf (son of Mogh) Rozhenko is appointed to chief of security after Yar's death, Beverly Crusher is appointed chief medical officer, Deanna Troi is appointed ship's, Wesley Crusher son of Beverley Crusher is later appointed to acting ensign."
                        },
                        new
                        {
                            TrekEventId = 45,
                            Date = 2363,
                            Description = "USS Enterprise (NCC-1701-D), the third Galaxy-class starship (following the Galaxy and Yamato) is launched from the Utopia Planitia shipyards in Mars orbit (under the command of Jean-Luc Picard), and becomes the Federation's new flagship."
                        },
                        new
                        {
                            TrekEventId = 46,
                            Date = 2364,
                            Description = "The Stargazer is later recovered in 2364."
                        },
                        new
                        {
                            TrekEventId = 47,
                            Date = 2357,
                            Description = "Worf is the first Klingon to enter Starfleet Academy."
                        },
                        new
                        {
                            TrekEventId = 48,
                            Date = 2355,
                            Description = "The USS Stargazer is attacked by an unknown vessel (later discovered to be Ferengi in origin) in the Maxia Zeta system. Jean-Luc Picard wins the confrontation by devising a tactic which becomes known as the Picard Manoeuvre. However, due to damage suffered during the battle, the crew are forced to abandon ship."
                        },
                        new
                        {
                            TrekEventId = 49,
                            Date = 2346,
                            Description = "Worf's parents are killed by Romulans in the Khitomer massacre. Worf (age 6) is adopted by human parents."
                        },
                        new
                        {
                            TrekEventId = 50,
                            Date = 2334,
                            Description = "The Enterprise-C, under the command of Captain Rachel Garrett, is destroyed defending a Klingon settlement on Narendra III under attack from Romulans. Due to the Enterprise-C's sacrifice, a new era of more open communication begins between the Federation and the Klingon Empire, leading to a formalized alliance."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
