using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.WallParams 
{

	[NVP_Manifest(
		Id = "644504C6-2AB3-423D-8714-9BD442924E19", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WallParams.WallParams_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WallParams", 
		NodeName = "_WallParams_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WallParams_Constructor : INode 
	{
		public Renga.IWallParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IWallParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "31601C54-920E-46F1-BA0A-F63C7628E05A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WallParams.WallParams_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WallParams", 
		NodeName = "_WallParams_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WallParams_ConstructorCast : INode 
	{
		public Renga.IWallParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IWallParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "CC75DFB2-5EAC-42BB-9780-3E16D78BC1C9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WallParams.GetContour", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WallParams", 
		NodeName = "GetContour", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("WallParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetContour : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetContour);

		}
	}


	[NVP_Manifest(
		Id = "60A2DB6C-E32A-44BE-830E-43637EBE6109", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WallParams.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WallParams", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("WallParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Id = "F6D44BB5-F938-4364-B9ED-02B7B7F332A2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WallParams.Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WallParams", 
		NodeName = "Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("WallParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Thickness);

		}
	}


	[NVP_Manifest(
		Id = "2B3D9C4E-CE98-4A24-89B6-ACB5D16DABD0", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WallParams.VerticalOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WallParams", 
		NodeName = "VerticalOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("WallParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class VerticalOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalOffset);

		}
	}


	[NVP_Manifest(
		Id = "0FED149D-56E1-4EBE-B88B-C2E39285FDE3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.WallParams.GetDependentObjectIds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.WallParams", 
		NodeName = "GetDependentObjectIds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("WallParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetDependentObjectIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetDependentObjectIds();
			return null;
		}
	}
}
