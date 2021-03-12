using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class PortalTest
    {
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator PortalTestViaJump()
        {
            // We have a scene set up to load, then make the blue character jump into a portal. If the player's X position has changed we know it's because the portal worked
            SceneManager.LoadScene("PortalTest");
            yield return new WaitForSeconds(.5f);
            GameObject bluePlayer = GameObject.Find("BlueCharacter");
            Debug.Log("is it null? :" + bluePlayer);
            var startingPos = bluePlayer.transform.position.x;
            PlayerController controlReference = bluePlayer.GetComponent(typeof(PlayerController)) as PlayerController;
            controlReference.jump();

            yield return new WaitForSeconds(1.5f);

            var endingPos = bluePlayer.transform.position.x;
            Assert.IsTrue(endingPos != startingPos);
        }
    }
}
