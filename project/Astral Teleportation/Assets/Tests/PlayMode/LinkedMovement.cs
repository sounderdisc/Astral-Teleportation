using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class LinkedMovement
    {
        
        [UnityTest]
        public IEnumerator LinkedMovementLeft()
        {
            //Arrange
            SceneManager.LoadScene("LinkedScene");
            yield return new WaitForSeconds(5f);
            //Act
            
            //Assert



            yield return null;
        }
    }
}
