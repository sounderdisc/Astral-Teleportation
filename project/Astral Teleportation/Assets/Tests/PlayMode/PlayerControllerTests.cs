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
            GameObject moveRightTester = new GameObject("placeholderGameObjectt");
            moveRightTester.AddComponent<Rigidbody2D>();
            yield return null;
            PlayerController player = moveRightTester.AddComponent<PlayerController>();
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
            GameObject moveLeftTester = new GameObject("placeholderGameObjectt");
            moveLeftTester.AddComponent<Rigidbody2D>();
            yield return null;
            PlayerController player = moveLeftTester.AddComponent<PlayerController>();
            yield return null;

            var startingPos = player.transform.position.x;

            float timePassed = 0f;
            while( timePassed < 1){
                player.moveLeft();
                timePassed += Time.deltaTime;
                yield return null;
            }
            yield return null;
            var endingPos = player.transform.position.x;
            Assert.IsTrue(endingPos < startingPos);

            UnityEngine.Object.DestroyImmediate(player);
        }

        [UnityTest]
        public IEnumerator jump()
        {
            GameObject jumpTester = new GameObject("placeholderGameObjectt");
            jumpTester.AddComponent<Rigidbody2D>();
            yield return null;
            PlayerController player = jumpTester.AddComponent<PlayerController>();
            yield return null;

            var startingPos = player.transform.position.y;

            float timePassed = 0f;
            while( timePassed < 1){
                player.jump();
                timePassed += Time.deltaTime;
                yield return null;
            }
            yield return null;
            var endingPos = player.transform.position.y;
            Assert.IsTrue(endingPos > startingPos);

            UnityEngine.Object.DestroyImmediate(player);
        }

        [UnityTest]
        public IEnumerator stopMovement()
        {
            GameObject stopMovementTester = new GameObject("placeholderGameObjectt");
            stopMovementTester.AddComponent<Rigidbody2D>();
            yield return null;
            PlayerController player = stopMovementTester.AddComponent<PlayerController>();
            yield return null;

            float timePassed = 0f;
            var movingPos = player.transform.position.x;
            while( timePassed < 1){
                player.moveLeft();
                timePassed += Time.deltaTime;
                movingPos = player.transform.position.x;
                yield return null;
            }
            
            timePassed = 0f;
            while( timePassed < 1){
                timePassed += Time.deltaTime;
                yield return null;
            }
            yield return null;
            var endingPos = player.transform.position.x;
            Assert.IsTrue(endingPos < movingPos);

            UnityEngine.Object.DestroyImmediate(player);
            yield return null;
        }

        [UnityTest]
        public IEnumerator freezePlayerActions()
        {
            GameObject freezePlayerActionsTester = new GameObject("placeholderGameObjectt");
            freezePlayerActionsTester.AddComponent<Rigidbody2D>();
            yield return null;
            PlayerController player = freezePlayerActionsTester.AddComponent<PlayerController>();
            yield return null;

            player.isDead = true;
            var startingPos = player.transform.position.x;

            float timePassed = 0f;
            while( timePassed < 1){
                player.moveLeft();
                timePassed += Time.deltaTime;
                yield return null;
            }
            yield return null;
            var endingPos = player.transform.position.x;
            Assert.IsTrue(endingPos < startingPos);

            UnityEngine.Object.DestroyImmediate(player);
        }

    }
}