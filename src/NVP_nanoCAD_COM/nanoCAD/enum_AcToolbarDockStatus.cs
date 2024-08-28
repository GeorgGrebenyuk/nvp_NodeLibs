﻿using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_nanoCAD_COM._nanoCAD.enum_AcToolbarDockStatus 
{


	[NVP_Manifest(
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acToolbarDockTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcToolbarDockStatus.acToolbarDockTop);

		}
	}


	[NVP_Manifest(
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acToolbarDockBottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcToolbarDockStatus.acToolbarDockBottom);

		}
	}


	[NVP_Manifest(
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acToolbarDockLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcToolbarDockStatus.acToolbarDockLeft);

		}
	}


	[NVP_Manifest(
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acToolbarDockRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcToolbarDockStatus.acToolbarDockRight);

		}
	}


	[NVP_Manifest(
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acToolbarFloating : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcToolbarDockStatus.acToolbarFloating);

		}
	}
}
