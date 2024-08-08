using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ModelView 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ModelView_Constructor : INode 
	{
		public Renga.IModelView _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IModelView;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ModelView_ConstructorCast : INode 
	{
		public Renga.IModelView _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IModelView;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("ModelView", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SetObjectsVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetObjectsVisibility();
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("ModelView", typeof(object))]
	[NodeInput("objectId", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class IsObjectVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsObjectVisible(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("ModelView", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SetObjectsVisualStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetObjectsVisualStyle();
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("ModelView", typeof(object))]
	[NodeInput("objectId", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetObjectVisualStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetObjectVisualStyle(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("ModelView", typeof(object))]
	[NodeInput("Renga.VisualStyle", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_VisualStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VisualStyle = ((Renga.VisualStyle)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("ModelView", typeof(object))]

	///<summary>
	///
	///</summary>
	public class VisualStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VisualStyle);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("ModelView", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ShowObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowObjects();
			return null;
		}
	}
}
