using BountyHunterLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HunterDAL;

namespace BountyHunterLib.Service
{
   public class StaticBountyHunterService
    {
        public void AddNewHunter(HunterModel hm)
        {
            throw new NotImplementedException();
        }

        public void DeleteHunterById(BountyHuntersEntities1 db, int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteHunterById(int id)
        {
            throw new NotImplementedException();
        }

        public HunterListModel GetAllHunters()
        {
            HunterListModel model = new HunterListModel();
            model.Hunters.Add(new HunterModel() { HunterId = 1,Wage="$800,000" ,Name = "Zam Wessel", ImageUrl = "~/Content/Zam.jpg", Description = " A shape-shifting bounty hunter, Zam Wesell is doubly dangerous, and is also a good shot. Hired by Jango Fett to assassinate Senator Padmé Amidala, Wesell was almost successful in her attempts on the senator’s life, first in a bombing of Amidala’s starship, and then with a deposit of two venomous arthropods into her sleeping quarters — an attack thwarted by Jedi Obi-Wan Kenobi and Anakin Skywalker. In the resulting pursuit, she proves a strong match for Kenobi and Skywalker, leading them on a frantic high-speed chase throughout Coruscant, but ultimately could not outrun or outsmart the Jedi.", DetailOne= "A shape-shifting Clawdite assassin from Zolan, Zam Wesell could assume any humanoid form.", DetailTwo= "Accomplice to Jango Fett", DetailThree= "Wesell preferres to strike her targets from afar, utilizing long-range sniper rifles or remote probe droids" });
            model.Hunters.Add(new HunterModel() { HunterId = 2,Wage= "$2,000,000",Name = "Boba Fett", ImageUrl = "~/Content/Boba.png", Description = "Hugely important to Star Wars, Jango Fett is so respected a bounty hunter that he became the clone army blueprint. Wearing blue and grey Mandalorian armor, Jango holds his own against Obi-Wan Kenobi in Attack of the Clones, and in the Battle of Geonosis, blasts a Jedi out of a private box overlooking the planet’s arena — without moving — and kills a reek with a precision shot at point blank range. His arsenal, of course, is awesome: jet pack, flame thrower, rocket launcher, blasters, and more. While he ultimately falls to Mace Windu, Fett lives up to his reputation.", DetailOne= "With his customized Mandalorian armor, deadly weaponry, and silent demeanor, Boba Fett was one of the most feared bounty hunters in the galaxy.",DetailTwo= " A genetic clone of his “father,” bounty hunter Jango Fett, Boba learned combat and martial skills from a young age.",DetailThree= "Over the course of his career, which included contracts for the Empire and the criminal underworld, he became a legend." });
            model.Hunters.Add(new HunterModel() { HunterId = 3,Wage= "$1,500,000",Name = "Jango Fett", ImageUrl = "~/Content/jangojpg.jpg", Description = "Hugely important to Star Wars, Jango Fett is so respected a bounty hunter that he became the clone army blueprint. Wearing blue and grey Mandalorian armor, Jango holds his own against Obi-Wan Kenobi in Attack of the Clones, and in the Battle of Geonosis, blasts a Jedi out of a private box overlooking the planet’s arena — without moving — and kills a reek with a precision shot at point blank range. His arsenal, of course, is awesome: jet pack, flame thrower, rocket launcher, blasters, and more. While he ultimately falls to Mace Windu, Fett lives up to his reputation.",DetailOne= "A proficient marksman and unarmed combatant, Fett was covered in a sleek armored suit that concealed his scarred face.",DetailTwo= "His combat gear featured an arsenal of weaponry, including retractable wrist blades, a snare, dual blaster pistols and other more exotic tools of the trade. In combat, Jango used his harnessed jetpack to gain the advantage of speed and height over his enemies.",DetailThree= "In the final years of the Republic, Jango Fett was regarded as the best bounty hunter in the galaxy." });
            model.Hunters.Add(new HunterModel() { HunterId = 4,Wage= "$1,750,000",Name = "Cad Bane", ImageUrl = "~/Content/Cad.png", Description = "Deadly, no-nonsense, and always dangerous, Cad Bane — who looks like he stepped right out of The Good, The Bad, and The Ugly — is the most effective bounty hunter seen in Star Wars. His resume from Star Wars: The Clone Wars is amazing: Bane frees Ziro the Hutt from a highly-guarded prison on Coruscant; he infiltrates the Jedi Archives and steals a holocron, is later apprehended by Jedi, then still manages to escape; and he holds his own in battles against both Anakin Skywalker and Obi-Wan Kenobi, and captures Ahsoka Tano. He’s also creative — see his zero-gravity fight against Anakin and Ahsoka. With his arsenal and gadgetry, including twin blasters, rocket boots, and weaponized gauntlets, Bane is a formidable foe to everyone — no one is safe, be it fellow bounty hunter or Jedi. While he’s a relatively new character, Bane has become one of the great pure villains of Star Wars, cold and calculating and all business.",DetailOne= "A ruthless bounty hunter from the planet Duro, Cad Bane is the preeminent blaster-for-hire in the galaxy at the time of the Clone Wars.",DetailTwo= "No quarry is too dangerous for Bane... if the price is right.",DetailThree= "Bane carries custom twin blaster pistols, gauntlets studded with control devices, a concealed bola, explosives, integrated breathing apparatus and rocket boots, ensuring that he is always well prepared for any situation that may arise." });
            model.Hunters.Add(new HunterModel() { HunterId = 5,Wage= "$950,000",Name = "Dengar", ImageUrl = "~/Content/Dengar.jpg", Description = "One of the bounty hunters hired by Darth Vader to find the Millennium Falcon in The Empire Strikes Back, Dengar sports distinctive armor, has a unique headdress, and carries heavy weaponry. As seen in Star Wars: The Clone Wars, he’s also adept at hand-to-hand combat, standing his ground against an onslaught of Kage warriors.",DetailOne= "While some hunters prided themselves on finesse and style, Dengar preferred firepower and destruction.",DetailTwo= "Worked previously with Boba Fett who hold him in high regard.",DetailThree= "Crude and slovenly, Dengar is nonetheless an effective bounty hunter." });
            model.Hunters.Add(new HunterModel() { HunterId = 6,Wage= "$750,000",Name = "Bossk", ImageUrl = "~/Content/Bossk.png", Description = "Threatening and intimidating, Bossk became a fan favorite after his snarling I-can-hear-you grunt at an Imperial officer in The Empire Strikes Back. As seen in Star Wars: The Clone Wars, he is among the galaxy’s most in-demand bounty hunters, working closely with Boba Fett, and as a Trandoshan, is a natural hunter. His attitude and original character design — no armor, a reptilian appearance, long arms and legs with clawed hands and feet — make him unique in the Star Wars galaxy.",DetailOne= "One of the most feared bounty hunters of the galaxy, Bossk uses his natural Trandoshan hunting instincts to capture his prey.",DetailTwo= "Partnered with some of the galaxy's most dangerous bounty hunters.",DetailThree= "Bossk doesn't care much for vendettas or politics. He's only in it to get paid." });
            model.Hunters.Add(new HunterModel() { HunterId = 7,Wage= "$1,250,000",Name = "IG-88", ImageUrl = "~/Content/Ig88.png", Description = "A towering, imposing figure, IG-88 is another of Vader’s preferred bounty hunters — and is the only droid on this list. While only seen briefly in The Empire Strikes Back, IG-88 has remained popular with fans, appearing in comic books, video games, and cartoons. What perhaps resonates with fans is the fact that IG-88 is a free agent; he’s beholden to no master or owner, unlike other droids, which represents something truly scary — a bounty hunter with no humanity.",DetailOne= "IG-88 is a battered chrome war droid who has become a bounty hunter.",DetailTwo= "Answered Darth Vader's call to capture the Millennium Falcon during the events surrounding the Battle of Hoth.",DetailThree= "An assassin droid, independently programmed mechanical killer that has no master." });


            return model;
        }

        public HunterModel GetHunterById(int id)
        {
            return GetAllHunters().Hunters.Where(x => x.HunterId == id).First();
        }

        public void UpdateHunter(HunterModel hm)
        {
            throw new NotImplementedException();
        }
    }
}
