using Microsoft.VisualStudio.TestTools.UnitTesting;
using womens_race_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace womens_race_project.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            // Form1 form = new Form1();
            ControlGame cg = new ControlGame();
            String h=cg.checkArray("john 10 Katie 120","Katie");
            Assert.AreEqual(h, "130");
        }

        [TestMethod()]
        public void Form2Test()
        {
            // Form1 form = new Form1();
            ControlGame cg = new ControlGame();
            String h = cg.checkArray("Peter 10 Gosy 120", "Katie");
            Assert.AreNotEqual(h, "130");
        }


    }
}