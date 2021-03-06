﻿using NUnit.Framework;
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestContext = System.Object;
using TestProperty = NUnit.Framework.PropertyAttribute;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitCommandsTest.Patch
{
    [TestClass]
    class PatchTest
    {
        [TestMethod]
        public void TestPatchConstructor()
        {
            PatchApply.Patch patch = new PatchApply.Patch();

            Assert.IsNotNull(patch);
        }

        [TestMethod]
        public void TestAppendText()
        {
            PatchApply.Patch patch = new PatchApply.Patch();
            patch.AppendText("text1");
            patch.AppendText("text2");

            Assert.AreEqual("text1text2", patch.Text);
        }

        [TestMethod]
        public void TestAppendTextLine()
        {
            PatchApply.Patch patch = new PatchApply.Patch();

            patch.AppendTextLine("text1");
            patch.AppendTextLine("text2");
            patch.AppendTextLine("text3");

            var expected = "text1\ntext2\ntext3\n";

            Assert.AreEqual(expected, patch.Text);
        }
    }
}
