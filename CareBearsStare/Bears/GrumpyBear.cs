using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearsStare.Bears
{
    class GrumpyBear : CareBearBase
    {
        public GrumpyBear()
        {
            BellyBadge = "Rain Cloud";
            Color = BearColor.Blue;
            Name = "Grumpy Bear";
        }
        public override void Stare()
        {
            Console.WriteLine("Some stuff");
        }

        public override void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"Grumpy Bear hates hugs and instead shuns {careBearToHug.Name}.");
        }
    }
}
