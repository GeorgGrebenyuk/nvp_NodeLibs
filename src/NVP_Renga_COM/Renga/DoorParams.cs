using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.DoorParams 
{

	[NVP_Manifest(
		Id = "4F4C663D-01AC-4B12-AEC3-F9DFEC13A446", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DoorParams.DoorParams_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DoorParams", 
		NodeName = "_DoorParams_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class DoorParams_Constructor : INode 
	{
		public Renga.IDoorParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IDoorParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "24B46BE7-2726-4C4D-A556-4788CF1F6850", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DoorParams.DoorParams_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DoorParams", 
		NodeName = "_DoorParams_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class DoorParams_ConstructorCast : INode 
	{
		public Renga.IDoorParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IDoorParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "2E9C5B38-90B4-4441-837B-84ABD8570781", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DoorParams.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DoorParams", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("DoorParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Id = "889209C8-29FF-4731-BAD5-3C10C270A8B3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DoorParams.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DoorParams", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("DoorParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	[NVP_Manifest(
		Id = "168371B0-D9D0-44EC-ABD6-6B4DACFA7A84", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DoorParams.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DoorParams", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("DoorParams", typeof(object))]

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
		Id = "8C22FB60-1A75-4CDC-B307-F112E38DD3A0", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DoorParams.VerticalOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DoorParams", 
		NodeName = "VerticalOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("DoorParams", typeof(object))]

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
		Id = "D7C2DED4-5D50-4F56-9141-1FBCE32D5F39", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DoorParams.GetAffectedObjectIds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DoorParams", 
		NodeName = "GetAffectedObjectIds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("DoorParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetAffectedObjectIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetAffectedObjectIds();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B715190F-4315-4F38-8E72-8096E4E3D550", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DoorParams.CalculateProjection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DoorParams", 
		NodeName = "CalculateProjection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("DoorParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class CalculateProjection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CalculateProjection);

		}
	}
}
