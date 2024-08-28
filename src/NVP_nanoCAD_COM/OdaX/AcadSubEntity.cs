using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///SubEntity Interface
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadSubEntity 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSubEntity_Constructor : INode 
	{
		public OdaX.IAcadSubEntity _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSubEntity;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSubEntity_ConstructorCast : INode 
	{
		public OdaX.IAcadSubEntity _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSubEntity;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("AcadSubEntity", typeof(object))]

	///<summary>
	///
	///</summary>
	public class OnModified : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnModified();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the AutoCAD class name of the object", 
		ViewType = "Data")]
	[NodeInput("AcadSubEntity", typeof(object))]

	///<summary>
	///Gets the AutoCAD class name of the object
	///</summary>
	public class ObjectName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectName);

		}
	}


	[NVP_Manifest(
		Text = "Returns the true color of the object.", 
		ViewType = "Data")]
	[NodeInput("AcadSubEntity", typeof(object))]

	///<summary>
	///Returns the true color of the object.
	///</summary>
	public class color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.color);

		}
	}


	[NVP_Manifest(
		Text = "Returns the true color of the object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSubEntity", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Returns the true color of the object.
	///</summary>
	public class Set_color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.color = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the current layer of the object", 
		ViewType = "Data")]
	[NodeInput("AcadSubEntity", typeof(object))]

	///<summary>
	///Specifies the current layer of the object
	///</summary>
	public class Layer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Layer);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the current linetype of the object", 
		ViewType = "Data")]
	[NodeInput("AcadSubEntity", typeof(object))]

	///<summary>
	///Specifies the current linetype of the object
	///</summary>
	public class Linetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Linetype);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the linetype scale factor of the object", 
		ViewType = "Data")]
	[NodeInput("AcadSubEntity", typeof(object))]

	///<summary>
	///Specifies the linetype scale factor of the object
	///</summary>
	public class LinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinetypeScale);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the plotstyle name for the object", 
		ViewType = "Data")]
	[NodeInput("AcadSubEntity", typeof(object))]

	///<summary>
	///Specifies the plotstyle name for the object
	///</summary>
	public class PlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotStyleName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the lineweight for the object", 
		ViewType = "Data")]
	[NodeInput("AcadSubEntity", typeof(object))]

	///<summary>
	///Specifies the lineweight for the object
	///</summary>
	public class Lineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Lineweight);

		}
	}


	[NVP_Manifest(
		Text = "if one is specified)", 
		ViewType = "Data")]
	[NodeInput("AcadSubEntity", typeof(object))]

	///<summary>
	///if one is specified)
	///</summary>
	public class Hyperlinks : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Hyperlinks);

		}
	}
}
