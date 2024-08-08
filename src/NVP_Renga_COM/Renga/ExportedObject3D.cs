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
