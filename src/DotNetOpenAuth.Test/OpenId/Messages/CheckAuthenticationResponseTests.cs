﻿//-----------------------------------------------------------------------
// <copyright file="CheckAuthenticationResponseTests.cs" company="Andrew Arnott">
//     Copyright (c) Andrew Arnott. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.Test.OpenId.Messages {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using DotNetOpenAuth.Messaging.Reflection;
	using DotNetOpenAuth.OpenId;
	using DotNetOpenAuth.OpenId.Messages;
	using NUnit.Framework;

	[TestFixture]
	public class CheckAuthenticationResponseTests : OpenIdTestBase {
		[SetUp]
		public override void SetUp() {
			base.SetUp();
		}

		[TestCase]
		public void IsValid() {
			Protocol protocol = Protocol.Default;
			var request = new CheckAuthenticationRequest(protocol.Version, OPUri);
			var response = new CheckAuthenticationResponse(protocol.Version, request);
			var dictionary = this.MessageDescriptions.GetAccessor(response);
			Assert.AreEqual("false", dictionary["is_valid"]);
			response.IsValid = true;
			Assert.AreEqual("true", dictionary["is_valid"]);
		}
	}
}
