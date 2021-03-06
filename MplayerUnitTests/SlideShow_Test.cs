﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.IO;
using System.Threading.Tasks;

namespace MplayerUnitTests
{
    [TestFixture()]
    public class SlideShow_Test
    {
        [Test()]
        public void Test1()
        {
            var a = new LibMPlayerCommon.SlideShow();

            var b = new List<LibMPlayerCommon.SlideShowInfo>();
            b.Add(new LibMPlayerCommon.SlideShowInfo(Path.Combine(GlobalVariables.BasePath, 
                        "1014298_10153309773648441_4068913891654803342_n.jpg"), 
                    LibMPlayerCommon.SlideShowEffect.TimeWarp));
            b.Add(new LibMPlayerCommon.SlideShowInfo(Path.Combine(GlobalVariables.BasePath,
                        "10338701_10152519957416197_8977706802583474488_n.jpg"), 
                    LibMPlayerCommon.SlideShowEffect.Moire));
            b.Add(new LibMPlayerCommon.SlideShowInfo(Path.Combine(GlobalVariables.BasePath,  
                        "11204921_10153266349078441_6239651282630925977_n.jpg"),
                    LibMPlayerCommon.SlideShowEffect.Water));
            b.Add(new LibMPlayerCommon.SlideShowInfo(Path.Combine(GlobalVariables.BasePath,
                        "12038280_10153157463458441_1902212361551718770_n.jpg"),
                    LibMPlayerCommon.SlideShowEffect.RandomJitter));
            a.CreateSlideShow(b, 
                Path.Combine(GlobalVariables.BasePath, "helloworld.mpg"),
                Path.Combine (GlobalVariables.BasePath,@"Ghost_k_-_Stop_(blue_mix).mp3"),
                5);
        }

        [Test ()]
        public async Task Async_Test1 ()
        {
            var a = new LibMPlayerCommon.SlideShow ();

            var b = new List<LibMPlayerCommon.SlideShowInfo> ();
            b.Add (new LibMPlayerCommon.SlideShowInfo (Path.Combine (GlobalVariables.BasePath,
                        "1014298_10153309773648441_4068913891654803342_n.jpg"),
                    LibMPlayerCommon.SlideShowEffect.TimeWarp));
            b.Add (new LibMPlayerCommon.SlideShowInfo (Path.Combine (GlobalVariables.BasePath,
                        "10338701_10152519957416197_8977706802583474488_n.jpg"),
                    LibMPlayerCommon.SlideShowEffect.Moire));
            b.Add (new LibMPlayerCommon.SlideShowInfo (Path.Combine (GlobalVariables.BasePath,
                        "11204921_10153266349078441_6239651282630925977_n.jpg"),
                    LibMPlayerCommon.SlideShowEffect.Water));
            b.Add (new LibMPlayerCommon.SlideShowInfo (Path.Combine (GlobalVariables.BasePath,
                        "12038280_10153157463458441_1902212361551718770_n.jpg"),
                    LibMPlayerCommon.SlideShowEffect.RandomJitter));
            await a.CreateSlideShowAsync (b,
                Path.Combine (GlobalVariables.BasePath, "helloworld_async_test.mpg"),
                Path.Combine (GlobalVariables.BasePath, @"Ghost_k_-_Stop_(blue_mix).mp3"),
                5);
        }


    }
}
