using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///The set of methods and properties used for plotting layouts
///</summary>
namespace nanoCAD.nanoCADPlotArea2 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPlotArea2_Constructor : INode 
	{
		public nanoCAD.InanoCADPlotArea2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPlotArea2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPlotArea2_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPlotArea2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPlotArea2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Retrieves position val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]

	///<summary>
	///Retrieves position val
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
		Text = "Retrieves position val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves position val
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves target val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]

	///<summary>
	///Retrieves target val
	///</summary>
	public class Target : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Target);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves target val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves target val
	///</summary>
	public class Set_Target : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Target = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves upVector val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]

	///<summary>
	///Retrieves upVector val
	///</summary>
	public class UpVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UpVector);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves upVector val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves upVector val
	///</summary>
	public class Set_UpVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UpVector = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves field val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]

	///<summary>
	///Retrieves field val
	///</summary>
	public class Field : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Field);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves field val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves field val
	///</summary>
	public class Set_Field : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Field = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves Perspective val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]

	///<summary>
	///Retrieves Perspective val
	///</summary>
	public class Perspective : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Perspective);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves Perspective val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves Perspective val
	///</summary>
	public class Set_Perspective : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Perspective = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves lensLength val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]

	///<summary>
	///Retrieves lensLength val
	///</summary>
	public class LensLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LensLength);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves lensLength val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]
	[NodeInput("val", typeof(System.Double))]

	///<summary>
	///Retrieves lensLength val
	///</summary>
	public class Set_LensLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LensLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves elevation val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]

	///<summary>
	///Retrieves elevation val
	///</summary>
	public class Elevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Elevation);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves elevation val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]
	[NodeInput("val", typeof(System.Double))]

	///<summary>
	///Retrieves elevation val
	///</summary>
	public class Set_Elevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Elevation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves viewOffset val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]

	///<summary>
	///Retrieves viewOffset val
	///</summary>
	public class ViewOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewOffset);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves viewOffset val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves viewOffset val
	///</summary>
	public class Set_ViewOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewOffset = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves ptWindow1 val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]

	///<summary>
	///Retrieves ptWindow1 val
	///</summary>
	public class ptWindow1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ptWindow1);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves ptWindow1 val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves ptWindow1 val
	///</summary>
	public class Set_ptWindow1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ptWindow1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves ptWindow2 val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]

	///<summary>
	///Retrieves ptWindow2 val
	///</summary>
	public class ptWindow2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ptWindow2);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves ptWindow2 val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea2", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves ptWindow2 val
	///</summary>
	public class Set_ptWindow2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ptWindow2 = inputs[1].Value;
			return null;
		}
	}
}
