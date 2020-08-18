﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PSFramework.Utility
{
    /// <summary>
    /// A scriptblock container item
    /// </summary>
    public class ScriptBlockItem
    {
        /// <summary>
        /// Name of the scriptblock
        /// </summary>
        public string Name;

        /// <summary>
        /// The scriptblock stored
        /// </summary>
        public ScriptBlock ScriptBlock
        {
            get
            {
                CountRetrieved++;
                LastRetrieved = DateTime.Now;
                return _ScriptBlock;
            }
            set { _ScriptBlock = value; }
        }
        private ScriptBlock _ScriptBlock;

        /// <summary>
        /// Whether the scriptblock should be invoked as global scriptblock
        /// </summary>
        public bool Global;

        /// <summary>
        /// The number of times this scriptblock has been used
        /// </summary>
        public int CountRetrieved { get; private set; }

        /// <summary>
        /// When the scriptblock has last been used
        /// </summary>
        public DateTime LastRetrieved { get; private set; }

        /// <summary>
        /// Create a new scriptblock item by offering both name and code
        /// </summary>
        /// <param name="Name">The name of the scriptblock</param>
        /// <param name="ScriptBlock">The scriptblock</param>
        /// <param name="Global">Whether the scriptblock should be invoked as global scriptblock</param>
        public ScriptBlockItem(string Name, ScriptBlock ScriptBlock, bool Global = false)
        {
            this.Name = Name;
            this.ScriptBlock = ScriptBlock;
            this.Global = Global;
        }
    }
}
