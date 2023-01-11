﻿//------------------------------------------------------------------------------
// <copyright file="IOpenContextParser.cs" company="Aras Corporation">
//     © 2017-2023 Aras Corporation. All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Aras.VS.MethodPlugin.OpenMethodInVS
{
	public interface IOpenContextParser
	{
		OpenMethodContext Parse(string openRequestString);
	}
}
