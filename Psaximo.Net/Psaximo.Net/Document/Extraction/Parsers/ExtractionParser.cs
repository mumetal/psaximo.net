﻿using System;
using FileEnum = Psaximo.Net.Util.XimEnum;

namespace Psaximo.Net.Document.Extraction.Parsers
{
    /**
     ** Licensed to the Apache Software Foundation (ASF) under one or more
     ** contributor license agreements.  See the NOTICE file distributed with
     ** this work for additional information regarding copyright ownership.
     ** The ASF licenses this file to You under the Apache License, Version 2.0
     ** (the "License"); you may not use this file except in compliance with
     ** the License.  You may obtain a copy of the License at
     **
     **     http://www.apache.org/licenses/LICENSE-2.0
     **
     ** Unless required by applicable law or agreed to in writing, software
     ** distributed under the License is distributed on an "AS IS" BASIS,
     ** WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
     ** See the License for the specific language governing permissions and
     ** limitations under the License.
    **/

    internal abstract class ExtractionParser
    {
        
        protected ExtractionParser() {
            
        }

        protected internal abstract FileEnum.FileType FileType { get; set; }

        public virtual FileEnum.FileType GetFileType() => FileType;

        public override string ToString() {
            return String.Format(@"Extraction Parser => {0} is of {1}", this.GetType().BaseType.Name, this.GetType().Name);
        }
    }
}
