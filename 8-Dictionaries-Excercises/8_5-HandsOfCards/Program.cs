using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_5_HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string person = null; string currentHand = null;
            var inputLine = new List<string>();
            var playerHands = new Dictionary<string, string>();
            
            while (true)
            {
                // Splits input to Person and Current CardHand
                inputLine = Console.ReadLine().Split(':').ToList();
                if (inputLine[0] == "JOKER")
                {
                    break;
                }
                person = inputLine[0];
                currentHand = inputLine[1];

                // If person already has cards, add the new cards to his old hand. 
                // Otherwise create new player with current hand.
                if (playerHands.ContainsKey(person))
                {
                    playerHands[person] = playerHands[person] + "," + currentHand;
                }
                else
                {
                    playerHands.Add(person, null);
                    playerHands[person] = currentHand;
                }
            }

            // Print results for each player according to their hand
            foreach (var player in playerHands)
            {
                Console.WriteLine($"{player.Key}: {GetHandPoints(player.Value)}");
            }
        }

        static int GetHandPoints(string playerHand)
        {
            int points = 0;
            string cardPower = null; string cardType = null;
            int localMultiplier = 0; int localPower = 0;

            // Format current hand and throw away duplicates
            var handList = playerHand.Split(',').Select(str => str.Trim()).Distinct().ToList();

            for (int i = 0; i < handList.Count; i++)
            {
                // Get Last Character of a card
                cardType = handList[i].Substring(handList[i].Length - 1);
                // Private case when the card power is 10
                if (handList[i].StartsWith("10"))
                {
                    cardPower = "10";
                }
                // Get power of a card (first character)
                else
                {
                    
                    cardPower = handList[i].ToCharArray().First().ToString();
                }

                // Get multiplier (card color)
                switch (cardType)
                {
                    case "S": localMultiplier = 4; break;
                    case "H": localMultiplier = 3; break;
                    case "D": localMultiplier = 2; break;
                    case "C": localMultiplier = 1; break;
                }

                // Get power number
                switch (cardPower)
                {
                    case "J": localPower = 11; break;
                    case "Q": localPower = 12; break;
                    case "K": localPower = 13; break;
                    case "A": localPower = 14; break;
                    default: localPower = int.Parse(cardPower); break;
                }

                // Sum points for the player
                points = points + localMultiplier * localPower;
            }
            return points;
        }
    }
}
