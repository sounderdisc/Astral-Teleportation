using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayerControlerTests
    {
        // Assert class api page: https://docs.unity3d.com/ScriptReference/Assertions.Assert.html
        // "yield return null;" will wait for one frame. "yield return new WaitForSeconds(1);" will wait for 1 second 
        [UnityTest]
        public IEnumerator MoveRight()
        {
            var gameObject = new GameObject();
            var player = gameObject.AddComponent<PlayerControler>();
            yield return new WaitForSeconds(1);
        }

        [UnityTest]
        public IEnumerator MoveLeft()
        {
            yield return null;
        }

        [UnityTest]
        public IEnumerator Jump()
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
