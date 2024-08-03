using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ContextMenuNodeItem 
{

	[NVP_Manifest(
		Id = "159787FE-9E3E-4654-80FF-E076D36FA78A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ContextMenuNodeItem.ContextMenuNodeItem_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ContextMenuNodeItem", 
		NodeName = "_ContextMenuNodeItem_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ContextMenuNodeItem_Constructor : INode 
	{
		public Renga.IContextMenuNodeItem _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IContextMenuNodeItem;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "F0F1D1FA-31B1-481F-AB26-DD715F993C27", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ContextMenuNodeItem.ContextMenuNodeItem_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ContextMenuNodeItem", 
		NodeName = "_ContextMenuNodeItem_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ContextMenuNodeItem_ConstructorCast : INode 
	{
		public Renga.IContextMenuNodeItem _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IContextMenuNodeItem;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "3A939C1D-15FD-4739-99A5-85D6882F0C12", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ContextMenuNodeItem.Set_DisplayName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ContextMenuNodeItem", 
		NodeName = "Set_DisplayName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ContextMenuNodeItem", typeof(object))]
	[NodeInput("displayName_", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_DisplayName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DisplayName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2A10ACF6-37F4-43AF-89F6-926069289401", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ContextMenuNodeItem.AddActionItem", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ContextMenuNodeItem", 
		NodeName = "AddActionItem", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ContextMenuNodeItem", typeof(object))]
	[NodeInput("pAction", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AddActionItem : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddActionItem(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "83259D5A-23C9-47A9-8407-C5E4BAC18084", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ContextMenuNodeItem.AddNodeItem", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ContextMenuNodeItem", 
		NodeName = "AddNodeItem", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ContextMenuNodeItem", typeof(object))]

	///<summary>
	///
	///</summary>
	public class AddNodeItem : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddNodeItem);

		}
	}


	[NVP_Manifest(
		Id = "626F7B2D-6719-47D0-A275-3394FB3F600C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ContextMenuNodeItem.AddSeparator", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ContextMenuNodeItem", 
		NodeName = "AddSeparator", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ContextMenuNodeItem", typeof(object))]

	///<summary>
	///
	///</summary>
	public class AddSeparator : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddSeparator();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "163155AA-D1DD-4442-9589-B1E65509CD9D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ContextMenuNodeItem.DisplayName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ContextMenuNodeItem", 
		NodeName = "DisplayName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ContextMenuNodeItem", typeof(object))]

	///<summary>
	///
	///</summary>
	public class DisplayName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayName);

		}
	}
}
