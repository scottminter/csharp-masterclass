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

        /// <summary>
        /// This method returns a list of friends with the shortest names.  This number
        /// of friends in this list is equal to the count param
        /// </summary>
        /// <param name="list"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list", "The list cannot be null.");
            }

            // need to make a copy of list
            var buffer = new List<string>(list);
            var partyFriends = new List<string>();

            // use count or partyFriends.Count whichever is less
            var numberOfFriends = count > list.Count ? list.Count : count;
            while (partyFriends.Count < numberOfFriends)
            {
                var currentFriend = GetPartyFriend(null);
                partyFriends.Add(currentFriend);
                buffer.Remove(currentFriend);
            }

            return partyFriends;
        }

        /// <summary>
        /// This method returns the shortest name in the list provded
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string GetPartyFriend(List<string> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list", "The list cannot be null.");
            }

            string shortestName = list.Count > 0 ? list[0] : string.Empty;
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

