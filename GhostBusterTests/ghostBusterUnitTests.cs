using System;
using WindowsFormsApplication2;
using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;
namespace GhostBusterTests
{
    [TestFixture]
    public class ghostBusterUnitTests
    {
        [Test]
        public void NewPartieShouldHaveSameNumberOfMines()
        { 
            int nbMinesInitial = 4 ;
            int nbMinesRestantes = 4;
            bool enCours= false;
            Partie p1 = new Partie(nbMinesRestantes, nbMinesInitial, enCours);
            Assert.AreEqual(p1.NbMinesRestantes,p1.NbMinesInitial);
            
        }
    }
}
