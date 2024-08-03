using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ContextMenu 
{

	[NVP_Manifest(
		Id = "72EDFB3D-23FD-43AB-A5F8-365483548307", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ContextMenu.ContextMenu_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ContextMenu", 
		NodeName = "_ContextMenu_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ContextMenu_Constructor : INode 
	{
		public Renga.IContextMenu _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IContextMenu;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "90F7F608-3A56-41B1-9D73-F89594D3DB64", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ContextMenu.ContextMenu_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ContextMenu", 
		NodeName = "_ContextMenu_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ContextMenu_ConstructorCast : INode 
	{
		public Renga.IContextMenu _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IContextMenu;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "8430DB22-9E6F-4494-B0E3-E917DE964547", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ContextMenu.AddActionItem", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ContextMenu", 
		NodeName = "AddActionItem", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ContextMenu", typeof(object))]
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
		Id = "6981B9C5-04DC-4A20-B232-57B373C7E319", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ContextMenu.AddNodeItem", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ContextMenu", 
		NodeName = "AddNodeItem", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ContextMenu", typeof(object))]

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
		Id = "94924BDE-D109-4E89-8279-5C46E9498706", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ContextMenu.AddSeparator", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ContextMenu", 
		NodeName = "AddSeparator", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ContextMenu", typeof(object))]

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
}
