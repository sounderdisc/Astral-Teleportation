using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayerControllerTests
    {
        [UnityTest]
        public IEnumerator moveRight()
        {
            GameObject placeholder = new GameObject("placeholderGameObjectt");
            Rigidbody2D rb2d = placeholder.AddComponent<Rigidbody2D>();
            yield return null;
            rb2d.velocity = new Vector2(0, 0);
            PlayerController player = placeholder.AddComponent<PlayerController>();
            yield return null;

            var startingPos = player.transform.position.x;

            float timePassed = 0f;
            while( timePassed < 1){
                player.moveRight();
                timePassed += Time.deltaTime;
                yield return null;
            }
            yield return null;
            var endingPos = player.transform.position.x;
            Assert.IsTrue(endingPos > startingPos);

            UnityEngine.Object.DestroyImmediate(player);
        }

        [UnityTest]
        public IEnumerator moveLeft()
        {
            yield return null;
        }

        [UnityTest]
        public IEnumerator jump()
        {
            yield return null;
        }

        [UnityTest]
        public IEnumerator stopMovement()
        {
            yield return null;
        }

        [UnityTest]
        public IEnumerator freezePlayerActions()
        {
            yield return null;
        }

    }
}