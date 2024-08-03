using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.SplitButton 
{

	[NVP_Manifest(
		Id = "3B238FA5-F1FF-4378-99CD-5E5FE2F9E459", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SplitButton.SplitButton_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SplitButton", 
		NodeName = "_SplitButton_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SplitButton_Constructor : INode 
	{
		public Renga.ISplitButton _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ISplitButton;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "5123AA96-DF96-4A8E-9446-E368ACE676C7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SplitButton.SplitButton_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SplitButton", 
		NodeName = "_SplitButton_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SplitButton_ConstructorCast : INode 
	{
		public Renga.ISplitButton _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ISplitButton;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "941CBA42-90F2-4C5D-A756-C6943CF6D0D9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SplitButton.AddAction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SplitButton", 
		NodeName = "AddAction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("SplitButton", typeof(object))]
	[NodeInput("pAction", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AddAction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddAction(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EC487DBD-429E-4BD8-A16D-EB8E50EDF0FE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SplitButton.AddSeparator", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SplitButton", 
		NodeName = "AddSeparator", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("SplitButton", typeof(object))]

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
		Id = "8FDA0E59-E8AE-48CA-8F1C-CC8AD1FBDE98", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SplitButton.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SplitButton", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("SplitButton", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	[NVP_Manifest(
		Id = "76AF1EA4-57AC-43D3-815D-39E8468BA30F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SplitButton.IdS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SplitButton", 
		NodeName = "IdS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("SplitButton", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IdS);

		}
	}
}
