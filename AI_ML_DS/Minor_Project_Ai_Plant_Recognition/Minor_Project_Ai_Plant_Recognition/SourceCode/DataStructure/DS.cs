﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minor_Project_Ai_Plant_Recognition.SourceCode.DataStructure
{
    internal class OrignalImgPath
    {
        public int catagoryId { get; set; }
        public int speciesId { get; set; }
        public string? imgPath { get; set; }

        public struct ImgPathOrignal
        {
            public int catagoryId;
            public int speciesId;
            public string imgPath;
        }
    }

    internal class PreprocessedPath
    {
        public int catagoryId { get; set; }
        public int speciesId { get; set; }
        public int preprocessedId { get; set; }
        public int modifierId { get; set; }
        public string? imgPath { get; set; }

        public struct ImgPathPreprocessed
        {
            public int catagoryId;
            public int speciesId;
            public int preprocessedId;
            public int modifierId;
            public string imgPath;
        }
    }
}