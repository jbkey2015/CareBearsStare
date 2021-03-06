﻿using System;
using System.Collections.Generic;
using System.Linq;
using CareBearsStare.Bears;

namespace CareBearsStare
{
    class Program
    {
        static void Main(string[] args)
        {

            var definitions = new Dictionary<string, List<string>>();

            definitions.Add("Martin", new List<string> { "smart", "strong", "important" });

            Console.WriteLine(string.Join("You is ", definitions["Martin"]));


            var grumpyBear = new GrumpyBear();
            var tenderHeart = new TenderHeart();
            var tinderHeart = new TinderHeart();

            var careBears = new List<CareBearBase> { grumpyBear, tenderHeart, tinderHeart };

            foreach (var bear in careBears)
            {
                bear.Care("Nathan");
                bear.Stare();
            }

            var namesThatStartWithT = careBears.Where(BearColor => BearColor.Name.StartsWith('T'));
            var careBearNames = careBears.Select(bear => bear.Name);

            var careBearNamesThatStartWithT = careBears
                                                .Where(bear => bear.Name.StartsWith('T'))
                                                .Select(bear => bear.Name);

            var anyBears = careBears.Any();
            var anyTinderHearts = careBears.Any(bear => bear is TinderHeart);
            var allTinderHearts = careBears.All(bear => bear is TinderHeart);

            var firstBear = careBears.First();
            var firstBearStartingWithT = careBears.First(bear => bear.Name.StartsWith('T'));
            // Throws an exception:
            // var blowsUp = careBears.First(bear => bear.Name.StartsWith('W'));

            // Returns Null
            var works = careBears.FirstOrDefault(bear => bear.Name.StartsWith('W'));

            var skippedGrumpy = careBears.Skip(1).Take(2);

            var numberOfCharacters = careBears.Sum(bear => bear.Name.Length);

            var orderedBears = careBears.OrderBy(bear => bear.BellyBadge);

            //Bedtime Bear, Birthday Bear, Cheer Bear, Friend Bear, Funshine Bear, Good Luck Bear, Grumpy Bear, Love-a-lot Bear, Tenderheart Bear, and Wish Bear.

        }
    }
}
