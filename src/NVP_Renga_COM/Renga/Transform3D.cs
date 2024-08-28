using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_Renga_COM._Renga.Transform3D 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Transform3D_Constructor : INode 
	{
		public Renga.ITransform3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ITransform3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Transform3D_ConstructorCast : INode 
	{
		public Renga.ITransform3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ITransform3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Transform3D", typeof(object))]
	[NodeInput("rowIndex", typeof(System.Int32))]
	[NodeInput("columnIndex", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetElement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetElement(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Transform3D", typeof(object))]
	[NodeInput("rowIndex", typeof(System.Int32))]
	[NodeInput("columnIndex", typeof(System.Int32))]
	[NodeInput("value", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class SetElement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetElement(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Transform3D", typeof(object))]
	[NodeInput("translation", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AddTranslation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddTranslation(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Transform3D", typeof(object))]
	[NodeInput("axis", typeof(System.Object))]
	[NodeInput("angle", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class AddRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddRotation(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Transform3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetCopy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCopy);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Transform3D", typeof(object))]
	[NodeInput("pTransform", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetMultiplied : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetMultiplied(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Transform3D", typeof(object))]
	[NodeInput("pPoint", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class TransformPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TransformPoint(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Transform3D", typeof(object))]
	[NodeInput("pVector", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class TransformVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TransformVector(inputs[1].Value));

		}
	}
}
