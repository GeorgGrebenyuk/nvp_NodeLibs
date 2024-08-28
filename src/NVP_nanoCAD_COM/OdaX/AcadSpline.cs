using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///nonuniform rational B-spline) curve entity
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadSpline 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSpline_Constructor : INode 
	{
		public OdaX.IAcadSpline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSpline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSpline_ConstructorCast : INode 
	{
		public OdaX.IAcadSpline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSpline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of control points defined for a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Specifies or returns the number of control points defined for a spline.
	///</summary>
	public class NumberOfControlPoints : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumberOfControlPoints);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of control points defined for a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Specifies or returns the number of control points defined for a spline.
	///</summary>
	public class ControlPoints : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ControlPoints);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of control points defined for a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("controlPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of control points defined for a spline.
	///</summary>
	public class Set_ControlPoints : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ControlPoints = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the current control point of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Specifies or returns the current control point of a spline.
	///</summary>
	public class NumberOfFitPoints : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumberOfFitPoints);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the current fit points of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Specifies or returns the current fit points of a spline.
	///</summary>
	public class FitPoints : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FitPoints);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the current fit points of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("fitPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the current fit points of a spline.
	///</summary>
	public class Set_FitPoints : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FitPoints = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the degree of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Returns the degree of a spline.
	///</summary>
	public class Degree : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Degree);

		}
	}


	[NVP_Manifest(
		Text = "Returns whether a spline is closed.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Returns whether a spline is closed.
	///</summary>
	public class Closed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Closed);

		}
	}


	[NVP_Manifest(
		Text = "Returns whether a spline is planar.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Returns whether a spline is planar.
	///</summary>
	public class IsPlanar : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsPlanar);

		}
	}


	[NVP_Manifest(
		Text = "Returns whether a spline is rational.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Returns whether a spline is rational.
	///</summary>
	public class IsRational : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsRational);

		}
	}


	[NVP_Manifest(
		Text = "Returns whether a spline is periodic.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Returns whether a spline is periodic.
	///</summary>
	public class IsPeriodic : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsPeriodic);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, z coordinate for the start tangent of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, z coordinate for the start tangent of a spline.
	///</summary>
	public class StartTangent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartTangent);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, z coordinate for the start tangent of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("StartTangent", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, z coordinate for the start tangent of a spline.
	///</summary>
	public class Set_StartTangent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartTangent = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, z coordinate for the end tangent of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, z coordinate for the end tangent of a spline.
	///</summary>
	public class EndTangent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndTangent);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, z coordinate for the end tangent of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("EndTangent", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, z coordinate for the end tangent of a spline.
	///</summary>
	public class Set_EndTangent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndTangent = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the fit tolerance of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Specifies or returns the fit tolerance of a spline.
	///</summary>
	public class FitTolerance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FitTolerance);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the fit tolerance of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("fitTol", typeof(System.Double))]

	///<summary>
	///Specifies or returns the fit tolerance of a spline.
	///</summary>
	public class Set_FitTolerance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FitTolerance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Returns the area of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Not implemented. Returns the area of a spline.
	///</summary>
	public class Area : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Area);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the coordinates for a control point of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("controlPoint", typeof(System.Object))]

	///<summary>
	///Specifies the coordinates for a control point of a spline.
	///</summary>
	public class SetControlPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetControlPoint(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the coordinates for a control point of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Returns the coordinates for a control point of a spline.
	///</summary>
	public class GetControlPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetControlPoint(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Specifies the fit point of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("fitPoint", typeof(System.Object))]

	///<summary>
	///Specifies the fit point of a spline.
	///</summary>
	public class SetFitPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetFitPoint(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the fit point of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Returns the fit point of a spline.
	///</summary>
	public class GetFitPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetFitPoint(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Specifies the weight of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("weight", typeof(System.Double))]

	///<summary>
	///Specifies the weight of a spline.
	///</summary>
	public class SetWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetWeight(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the weight of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Returns the weight of a spline.
	///</summary>
	public class GetWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetWeight(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Adds a fit point to a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("fitPoint", typeof(System.Object))]

	///<summary>
	///Adds a fit point to a spline.
	///</summary>
	public class AddFitPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddFitPoint(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Deletes a fit point from a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Deletes a fit point from a spline.
	///</summary>
	public class DeleteFitPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteFitPoint(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Increases the order of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("Order", typeof(System.Int32))]

	///<summary>
	///Not implemented. Increases the order of a spline.
	///</summary>
	public class ElevateOrder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ElevateOrder(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Creates a new spline at a specified distance from an original spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Not implemented. Creates a new spline at a specified distance from an original spline.
	///</summary>
	public class Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Offset(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Removes the fit data of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Removes the fit data of a spline.
	///</summary>
	public class PurgeFitData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PurgeFitData();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Reverses the direction of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Reverses the direction of a spline.
	///</summary>
	public class Reverse : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Reverse();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the knot vector of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Specifies or returns the knot vector of a spline.
	///</summary>
	public class Knots : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Knots);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the knot vector of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("KnotValues", typeof(System.Object))]

	///<summary>
	///Specifies or returns the knot vector of a spline.
	///</summary>
	public class Set_Knots : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Knots = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the weight vector of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Specifies or returns the weight vector of a spline.
	///</summary>
	public class Weights : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Weights);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the weight vector of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("WeightValues", typeof(System.Object))]

	///<summary>
	///Specifies or returns the weight vector of a spline.
	///</summary>
	public class Set_Weights : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Weights = inputs[1].Value;
			return null;
		}
	}
}
