﻿using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_nanoCAD_COM._OdaX.enum_AcDrawingAreaSCMEdit 
{


	[NVP_Manifest(
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acEdRepeatLastCommand : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDrawingAreaSCMEdit.acEdRepeatLastCommand);

		}
	}


	[NVP_Manifest(
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acEdSCM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDrawingAreaSCMEdit.acEdSCM);

		}
	}
}
