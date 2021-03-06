﻿//Licensed to the Apache Software Foundation(ASF) under one
//or more contributor license agreements.See the NOTICE file
//distributed with this work for additional information
//regarding copyright ownership.The ASF licenses this file
//to you under the Apache License, Version 2.0 (the
//"License"); you may not use this file except in compliance
//with the License.  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
//Unless required by applicable law or agreed to in writing,
//software distributed under the License is distributed on an
//"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
//KIND, either express or implied.  See the License for the
//specific language governing permissions and limitations
//under the License.

using System;

namespace Paragon.Plugins
{
    public class BeginDownloadEventArgs : EventArgs
    {
        public BeginDownloadEventArgs(string uri, string mimeType)
        {
            Uri = uri;
            MimeType = mimeType;
        }
        
        public string DownloadPath { get; set; }
        public string MimeType { get; private set; }
        public string Uri { get; private set; }
        public string SuggestedName { get; set; }
        public bool IsValid { get; set; }
        public uint Id { get; set; }
        public long RecvdBytes { get; set; }
        public bool IsComplete { get; set; }
        public bool IsCanceled { get; set; }

    }
}