using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Interface for a Camera entity
///</summary>
namespace NVP_nanoCAD_COM._OdaX.OdaCamera 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaCamera_Constructor : INode 
	{
		public OdaX.IOdaCamera _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaCamera;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaCamera_ConstructorCast : INode 
	{
		public OdaX.IOdaCamera _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaCamera;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Location : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Location);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Location : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Location = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
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
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
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
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
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
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
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
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class FieldOfView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FieldOfView);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_FieldOfView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FieldOfView = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class FrameHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FrameHeight);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_FrameHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FrameHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class FrameWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FrameWidth);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_FrameWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FrameWidth = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class RollAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RollAngle);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_RollAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RollAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IsPlotable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsPlotable);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_IsPlotable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IsPlotable = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class FrontPlane : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FrontPlane);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_FrontPlane : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FrontPlane = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class BackPlane : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackPlane);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_BackPlane : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackPlane = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Clipping : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Clipping);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_Clipping : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Clipping = inputs[1].Value;
			return null;
		}
	}
}
