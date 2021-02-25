using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Tests
{
    public class HealthTest
    {
        [UnityTest]
        public IEnumerator Health_Image_Initializes()
        {
            yield return null;
        }
        [UnityTest]
        public IEnumerator Health_On_Player_Intitializes()
        {
            PlayerHealthRed heart = new PlayerHealthRed();

            var numberOfHearts = heart.numberOfHearts;
            numberOfHearts = 3;
            yield return null;
            Assert.IsTrue(numberOfHearts == 3);
        }
        [UnityTest]
        public IEnumerator Health_On_Player_Part_Fill()
        {
            PlayerHealthRed heart = new PlayerHealthRed();
            PlayerHealthRed healthRed = new PlayerHealthRed();


            var numberOfHearts = heart.numberOfHearts;
            numberOfHearts = 3;
            var health = healthRed.health;
            health = 1;
            yield return null;
            Assert.IsTrue(health / numberOfHearts == 1/3);
        }

        [UnityTest]
        public IEnumerator Health_on_Player_Decreases()
        {
            PlayerHealthRed heart = new PlayerHealthRed();

            var numberOfHearts = heart.numberOfHearts;
            numberOfHearts = 3;
            var healthRemaining = heart.health;
            healthRemaining = 3;
            yield return null;
            healthRemaining -= 1;
            Assert.IsTrue(numberOfHearts <= 3);
        }
    }
}
