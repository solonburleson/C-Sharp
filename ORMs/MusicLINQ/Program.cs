using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = MusicStore.GetData().AllArtists;
            List<Group> Groups = MusicStore.GetData().AllGroups;
            Console.WriteLine(Artists);

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            IEnumerable<Artist> mtVernon = Artists.Where(artist => artist.Hometown == "Mount Vernon");
            foreach (var artist in mtVernon)
            {
                Console.WriteLine($"Artist Name: {artist.ArtistName}, Age: {artist.Age}");
            }
            

            //Who is the youngest artist in our collection of artists?
            Artist youngest = Artists.OrderBy(artist => artist.Age).First();
            Console.WriteLine($"Artist Name: {youngest.ArtistName}, Real Name: {youngest.RealName}, Hometown: {youngest.Hometown}, Age: {youngest.Age}");


            //Display all artists with 'William' somewhere in their real name
            IEnumerable<Artist> williams = Artists.Where(artist => artist.RealName.Contains("William"));
            foreach (var artist in williams)
            {
                Console.WriteLine($"Artist Name: {artist.ArtistName}, Real Name: {artist.RealName}, Age: {artist.Age}");
            }

            //Display all groups with names less than 8 characters in length.
            IEnumerable<Group> lessthan8 = Groups.Where(group => group.GroupName.Length < 8);
            foreach (var group in lessthan8)
            {
                Console.WriteLine($"Group Name: {group.GroupName}");
            }

            //Display the 3 oldest artist from Atlanta
            IEnumerable<Artist> oldest3 = Artists.OrderByDescending(artist => artist.Age).Take(3);
            foreach (var artist in oldest3)
            {
                Console.WriteLine($"Artist Name: {artist.ArtistName}, Real Name: {artist.RealName}, Age: {artist.Age}");
            }

            //(Optional) Display the Group Name of all groups that have members that are not from New York City
            //IEnumerable<Group> noNY = Groups.Where(group => group.Members.Where(artist => !artist.Hometown.Contains("New York")))

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
            IEnumerable<Group> wutang = Groups.Where(Group => Group.GroupName == "Wu-Tang Clan");
            foreach (var group in wutang)
            {
                foreach (var artist in group.Members)
                {
                    Console.WriteLine($"{artist.ArtistName}");
                }
            }
	        Console.WriteLine(Groups.Count);
        }
    }
}
