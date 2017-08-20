﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RetroManager.Models.Tests
{
    [TestClass]
    public class RevisionDuplicateRemoverTests
    {
        [TestMethod]
        public void RevisionDuplicateRemoverTest()
        {
            var files = new List<string>
            {
                "Game A (REV00)",
                "Game A (REV01)",
                "Game A (REV02)",
                "Game B"
            };

            var expectedFiles = new List<string>
            {
                "Game A (REV00)",
                "Game A (REV01)"
            };

            var rd = new RevisionDuplicateRemover();
            rd.dryRun(files);

            Assert.IsTrue(rd.FilesToDelete.SequenceEqual(expectedFiles));
        }
    }
}