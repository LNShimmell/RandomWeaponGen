using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNameGen
{
	class Program
	{
		static void Main(string[] args)

		{
			//Add or remove as many strings as you would like to the Prefix, Base and Suffix Arrays.
			//Empty quotation marks will add a chance for the weapon to roll without that value.
			string[] Prefix = {"Strong ", "Solid ", "Mighty ", "Smoldering ", "Molten ", "Scorching ", "Frost ", "Frozen ", "Shivering " ,
			"Shocking ", "Conductive ", "Electifying ", "Rancid ", "Putrid ", "Toxic ", "Cultic ", "Enigmatic ", "Rusted ",
			"Demonic ", "Angelic ", "Venomous ", "Courupt","" ,"" ,"" ,"" ,"" ,"" ,"" };
			string[] Base = { "Short Sword", "Long Sword", "Broad Axe", "Hatchet", "Club", "Flail", "Crossbow", "Dagger", "Icepick", "Pike",
			"War Hammer", "Maul", "Katana", "Tanto", "Wakizashi", "Assassin Bow", "Short Bow", "Long Bow", "Gothic Sword", "Gothic Axe",
			"Imperial Blade", "Imperial Bow", "Imperial Crossbow", "Gothic Sword", };
			string[] Suffix = { " of Might", " of Pain", " of Dreams", " of Precision", " of Hatred", " of  the Blizzard", " of Destruction",
			" of Agony", " of Horror", " of Phasing", " of stench", " of Pestilence", " of Plague", " of Sacrifice", " of Justice", "of Loathing",
			" of Giants", "of Reason", " of the Council", " of Calamity" , " of Couruption", " of Ritual", " of Pride",
				" of Grief", "" ,"" ,"" ,"" ,"" ,"" ,"" };
			int prefixlength = Prefix.Length;// Don't mess with these values
			int BaseLength = Base.Length;// Don't mess with these values
			int SuffixLength = Suffix.Length;// Don't mess with these values

			for (int x = 0; x < 100; ++x) { // default setting is 100, the number of weapon names this will generate.
				Random Rpfix = new Random();
				int rpfx = Rpfix.Next(prefixlength);
				System.Threading.Thread.Sleep(10);
				Random ranbase = new Random();
				int rbase = ranbase.Next(BaseLength);
				System.Threading.Thread.Sleep(10);
				Random ransfix = new Random();
				int rsfx = ransfix.Next(SuffixLength);
				System.Threading.Thread.Sleep(10);
				string WeaponName = Prefix[rpfx] + Base[rbase] + Suffix[rsfx];
				Console.WriteLine(WeaponName);
			}

			
		}
	}
}
