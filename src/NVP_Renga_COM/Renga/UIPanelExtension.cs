using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.UIPanelExtension 
{

	[NVP_Manifest(
		Id = "876F87FA-A8FE-4A93-8432-EC5556148237", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UIPanelExtension.UIPanelExtension_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UIPanelExtension", 
		NodeName = "_UIPanelExtension_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class UIPanelExtension_Constructor : INode 
	{
		public Renga.IUIPanelExtension _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IUIPanelExtension;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "34D47A7C-F9C2-4450-95F7-126D9F43DA79", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UIPanelExtension.UIPanelExtension_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UIPanelExtension", 
		NodeName = "_UIPanelExtension_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class UIPanelExtension_ConstructorCast : INode 
	{
		public Renga.IUIPanelExtension _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IUIPanelExtension;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "19865E8D-967C-44D2-B397-1930548C3092", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UIPanelExtension.AddToolButton", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UIPanelExtension", 
		NodeName = "AddToolButton", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("UIPanelExtension", typeof(object))]
	[NodeInput("pAction", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AddToolButton : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddToolButton(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7142BCC2-66E4-41BA-A529-7341318A60CE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UIPanelExtension.AddSplitButton", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UIPanelExtension", 
		NodeName = "AddSplitButton", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("UIPanelExtension", typeof(object))]
	[NodeInput("pSplitButton", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AddSplitButton : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddSplitButton(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "357D4D05-0471-4A58-8F49-7C0768A199DB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UIPanelExtension.AddDropDownButton", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UIPanelExtension", 
		NodeName = "AddDropDownButton", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("UIPanelExtension", typeof(object))]
	[NodeInput("pDropDownButton", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AddDropDownButton : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddDropDownButton(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "57B82D42-4254-437D-9699-3DF0ECC1D67E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.UIPanelExtension.AddToolButton2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.UIPanelExtension", 
		NodeName = "AddToolButton2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("UIPanelExtension", typeof(object))]
	[NodeInput("pToolButton", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AddToolButton2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddToolButton2(inputs[1].Value);
			return null;
		}
	}
}
