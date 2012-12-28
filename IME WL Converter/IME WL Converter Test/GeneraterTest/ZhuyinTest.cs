﻿using System;
using System.Collections.Generic;
using System.Text;
using Studyzy.IMEWLConverter.Generaters;
using NUnit.Framework;
using Studyzy.IMEWLConverter.Helpers;

namespace Studyzy.IMEWLConverter.Test.GeneraterTest
{
    [TestFixture]
    class ZhuyinTest
    {
        private IWordCodeGenerater generater;
        [TestFixtureSetUp]
        public void Setup()
        {
            generater = new ZhuyinGenerater();
        }
        [Test]
        public void TestGetOneWordPinyin()
        {
            
        }
        [TestCase("曾毅", "ㄗㄥ,ㄧˋ")]
        [TestCase("北京吃饭", "ㄅㄟˇ,ㄐㄧㄥ,ㄔ,ㄈㄢˋ")]
        [TestCase("煤矿", "ㄇㄟˊ,ㄎㄨㄤˋ")]
        public void TestGetLongWordsPinyin(string str,string py)
        {
            var result = generater.GetCodeOfString(str, " ");
            Assert.AreEqual(py,CollectionHelper.ListToString(result,","));
        }
    }
}
