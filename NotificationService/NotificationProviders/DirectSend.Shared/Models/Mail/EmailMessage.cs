﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace DirectSend.Models.Mail
{
    using System.Collections.Generic;

    /// <summary>
    /// EmailMessage.
    /// </summary>
    public class EmailMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailMessage"/> class.
        /// </summary>
        public EmailMessage()
        {
            this.ToAddresses = new List<EmailAddress>();
            this.FromAddresses = new List<EmailAddress>();
        }

        /// <summary>
        /// Gets or sets converts to addresses.
        /// </summary>
        /// <value>
        /// To addresses.
        /// </value>
        public IEnumerable<EmailAddress> ToAddresses { get; set; }

        /// <summary>
        /// Gets or sets converts cc addresses.
        /// </summary>
        /// <value>
        /// To addresses.
        /// </value>
        public IEnumerable<EmailAddress> CcAddresses { get; set; }

        /// <summary>
        /// Gets or sets from addresses.
        /// </summary>
        /// <value>
        /// From addresses.
        /// </value>
        public IEnumerable<EmailAddress> FromAddresses { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>
        /// The subject.
        /// </value>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the File Name.
        /// </summary>
        /// <value>
        /// The File Name.
        /// </value>
        public IEnumerable<string> FileName { get; set; }

        /// <summary>
        /// Gets or sets the File Content.
        /// </summary>
        /// <value>
        /// The File Content in Base64 format.
        /// </value>
        public IEnumerable<string> FileContent { get; set; }
    }
}
