// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.DataLake.StoreFileSystem.Models;

namespace Microsoft.Azure.Management.DataLake.StoreFileSystem.Models
{
    /// <summary>
    /// Data Lake file status properties information
    /// </summary>
    public partial class FileStatusProperties
    {
        private long _accessTime;
        
        /// <summary>
        /// Optional. Gets or sets the last access time.
        /// </summary>
        public long AccessTime
        {
            get { return this._accessTime; }
            set { this._accessTime = value; }
        }
        
        private long _blockSize;
        
        /// <summary>
        /// Optional. Gets or sets the block size for the file.
        /// </summary>
        public long BlockSize
        {
            get { return this._blockSize; }
            set { this._blockSize = value; }
        }
        
        private long _childrenNum;
        
        /// <summary>
        /// Optional. Gets or sets the number of children in the directory.
        /// </summary>
        public long ChildrenNum
        {
            get { return this._childrenNum; }
            set { this._childrenNum = value; }
        }
        
        private long _fileId;
        
        /// <summary>
        /// Optional. Gets or sets the file identifier.
        /// </summary>
        public long FileId
        {
            get { return this._fileId; }
            set { this._fileId = value; }
        }
        
        private string _group;
        
        /// <summary>
        /// Optional. Gets or sets the group owner.
        /// </summary>
        public string Group
        {
            get { return this._group; }
            set { this._group = value; }
        }
        
        private long _length;
        
        /// <summary>
        /// Optional. Gets or sets the number of bytes in a file.
        /// </summary>
        public long Length
        {
            get { return this._length; }
            set { this._length = value; }
        }
        
        private long _modificationTime;
        
        /// <summary>
        /// Optional. Gets or sets the modification time.
        /// </summary>
        public long ModificationTime
        {
            get { return this._modificationTime; }
            set { this._modificationTime = value; }
        }
        
        private string _owner;
        
        /// <summary>
        /// Optional. Gets or sets the user who is the owner.
        /// </summary>
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }
        
        private string _pathSuffix;
        
        /// <summary>
        /// Optional. Gets or sets the path suffix.
        /// </summary>
        public string PathSuffix
        {
            get { return this._pathSuffix; }
            set { this._pathSuffix = value; }
        }
        
        private string _permission;
        
        /// <summary>
        /// Optional. Gets or sets the permission represented as an octal
        /// string.
        /// </summary>
        public string Permission
        {
            get { return this._permission; }
            set { this._permission = value; }
        }
        
        private int _replication;
        
        /// <summary>
        /// Optional. Gets or sets the number of replications of a file.
        /// </summary>
        public int Replication
        {
            get { return this._replication; }
            set { this._replication = value; }
        }
        
        private FileType _type;
        
        /// <summary>
        /// Optional. Gets or sets the type of the path object.
        /// </summary>
        public FileType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the FileStatusProperties class.
        /// </summary>
        public FileStatusProperties()
        {
        }
    }
}
