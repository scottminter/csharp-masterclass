using System;
namespace S8Debugging
{
    public class V123DebuggingBasics
    {
        public static void Lesson()
        {
            var friends = new List<string> { "Frank", "Joe", "Michelle", "Al", "J", "Andy", "Maria", "Carlos", "Angelica" };
            var partyFriends = GetPartyFriends(friends, 4);

            foreach (var name in partyFriends)
            {
                Console.WriteLine($"name: {name}");
            }
        }

        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            var partyFriends = new List<string>();

            while (partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriend(list);
                partyFriends.Add(currentFriend);
                list.Remove(currentFriend);
            }

            return partyFriends;
        }

        public static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].Length < shortestName.Length)
                {
                    shortestName = list[i];
                }
            }

            return shortestName;
        }
    }
}

