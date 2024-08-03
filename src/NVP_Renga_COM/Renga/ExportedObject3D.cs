using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ExportedObject3D 
{

	[NVP_Manifest(
		Id = "BC603F7B-1170-43F0-9D65-B5A64C33464E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ExportedObject3D.ExportedObject3D_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ExportedObject3D", 
		NodeName = "_ExportedObject3D_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ExportedObject3D_Constructor : INode 
	{
		public Renga.IExportedObject3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IExportedObject3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "C4C7D6C6-D27E-44E4-985A-C6D6BE9B5263", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ExportedObject3D.ExportedObject3D_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ExportedObject3D", 
		NodeName = "_ExportedObject3D_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ExportedObject3D_ConstructorCast : INode 
	{
		public Renga.IExportedObject3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IExportedObject3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "73BF4A07-DD23-4144-8EBD-CDB79BFCF7C2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ExportedObject3D.ModelObjectId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ExportedObject3D", 
		NodeName = "ModelObjectId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ExportedObject3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ModelObjectId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ModelObjectId);

		}
	}


	[NVP_Manifest(
		Id = "8A06B6DE-AA2C-487D-9BB4-E3A4737A7F9E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ExportedObject3D.MeshCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ExportedObject3D", 
		NodeName = "MeshCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ExportedObject3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class MeshCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MeshCount);

		}
	}


	[NVP_Manifest(
		Id = "11922FF5-F6F0-43FD-8404-0893B5EB03B2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ExportedObject3D.GetMesh", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ExportedObject3D", 
		NodeName = "GetMesh", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ExportedObject3D", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetMesh : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetMesh(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "ED30BDE5-3B16-441A-9ECE-7FFD1807E2E8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ExportedObject3D.ModelObjectType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ExportedObject3D", 
		NodeName = "ModelObjectType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ExportedObject3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ModelObjectType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ModelObjectType);

		}
	}


	[NVP_Manifest(
		Id = "97814406-3770-444D-8A30-884D3A25F916", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ExportedObject3D.ModelObjectTypeS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ExportedObject3D", 
		NodeName = "ModelObjectTypeS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ExportedObject3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ModelObjectTypeS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ModelObjectTypeS);

		}
	}
}
