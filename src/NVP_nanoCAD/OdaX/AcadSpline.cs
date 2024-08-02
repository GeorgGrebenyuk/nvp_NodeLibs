using NVP.API.Nodes;

namespace OdaX.AcadSpline 
{
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


		///<summary>
		///Specifies or returns the number of control points defined for a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		public class NumberOfControlPoints : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.NumberOfControlPoints);

			}
		}


		///<summary>
		///Specifies or returns the number of control points defined for a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		public class ControlPoints : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ControlPoints);

			}
		}


		///<summary>
		///Specifies or returns the number of control points defined for a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		[NodeInput("controlPoint", typeof(System.Object))]
		public class Set_ControlPoints : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ControlPoints = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the current control point of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		public class NumberOfFitPoints : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.NumberOfFitPoints);

			}
		}


		///<summary>
		///Specifies or returns the current fit points of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		public class FitPoints : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.FitPoints);

			}
		}


		///<summary>
		///Specifies or returns the current fit points of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		[NodeInput("fitPoint", typeof(System.Object))]
		public class Set_FitPoints : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.FitPoints = inputs[1];
				return null;
			}
		}


		///<summary>
		///Returns the degree of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		public class Degree : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Degree);

			}
		}


		///<summary>
		///Returns whether a spline is closed.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		public class Closed : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Closed);

			}
		}


		///<summary>
		///Returns whether a spline is planar.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		public class IsPlanar : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IsPlanar);

			}
		}


		///<summary>
		///Returns whether a spline is rational.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		public class IsRational : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IsRational);

			}
		}


		///<summary>
		///Returns whether a spline is periodic.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		public class IsPeriodic : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IsPeriodic);

			}
		}


		///<summary>
		///Specifies or returns the x, y, z coordinate for the start tangent of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		public class StartTangent : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.StartTangent);

			}
		}


		///<summary>
		///Specifies or returns the x, y, z coordinate for the start tangent of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		[NodeInput("StartTangent", typeof(System.Object))]
		public class Set_StartTangent : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.StartTangent = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the x, y, z coordinate for the end tangent of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		public class EndTangent : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.EndTangent);

			}
		}


		///<summary>
		///Specifies or returns the x, y, z coordinate for the end tangent of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		[NodeInput("EndTangent", typeof(System.Object))]
		public class Set_EndTangent : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.EndTangent = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the fit tolerance of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		public class FitTolerance : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.FitTolerance);

			}
		}


		///<summary>
		///Specifies or returns the fit tolerance of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		[NodeInput("fitTol", typeof(System.Double))]
		public class Set_FitTolerance : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.FitTolerance = inputs[1];
				return null;
			}
		}


		///<summary>
		///Not implemented. Returns the area of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		public class Area : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Area);

			}
		}


		///<summary>
		///Specifies the coordinates for a control point of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		[NodeInput("Index", typeof(System.Int32))]
		[NodeInput("controlPoint", typeof(System.Object))]
		public class SetControlPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetControlPoint(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Returns the coordinates for a control point of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		[NodeInput("Index", typeof(System.Int32))]
		public class GetControlPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetControlPoint(inputs[1]));

			}
		}


		///<summary>
		///Specifies the fit point of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		[NodeInput("Index", typeof(System.Int32))]
		[NodeInput("fitPoint", typeof(System.Object))]
		public class SetFitPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetFitPoint(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Returns the fit point of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		[NodeInput("Index", typeof(System.Int32))]
		public class GetFitPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetFitPoint(inputs[1]));

			}
		}


		///<summary>
		///Specifies the weight of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		[NodeInput("Index", typeof(System.Int32))]
		[NodeInput("weight", typeof(System.Double))]
		public class SetWeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetWeight(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Returns the weight of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		[NodeInput("Index", typeof(System.Int32))]
		public class GetWeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetWeight(inputs[1]));

			}
		}


		///<summary>
		///Adds a fit point to a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		[NodeInput("Index", typeof(System.Int32))]
		[NodeInput("fitPoint", typeof(System.Object))]
		public class AddFitPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AddFitPoint(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Deletes a fit point from a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		[NodeInput("Index", typeof(System.Int32))]
		public class DeleteFitPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DeleteFitPoint(inputs[1]);
				return null;
			}
		}


		///<summary>
		///Not implemented. Increases the order of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		[NodeInput("Order", typeof(System.Int32))]
		public class ElevateOrder : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ElevateOrder(inputs[1]);
				return null;
			}
		}


		///<summary>
		///Not implemented. Creates a new spline at a specified distance from an original spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		[NodeInput("Distance", typeof(System.Double))]
		public class Offset : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Offset(inputs[1]));

			}
		}


		///<summary>
		///Removes the fit data of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		public class PurgeFitData : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.PurgeFitData();
				return null;
			}
		}


		///<summary>
		///Reverses the direction of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		public class Reverse : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Reverse();
				return null;
			}
		}


		///<summary>
		///Specifies or returns the knot vector of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		public class Knots : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Knots);

			}
		}


		///<summary>
		///Specifies or returns the knot vector of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		[NodeInput("KnotValues", typeof(System.Object))]
		public class Set_Knots : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Knots = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the weight vector of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		public class Weights : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Weights);

			}
		}


		///<summary>
		///Specifies or returns the weight vector of a spline.
		///</summary>
		[NodeInput("AcadSpline", typeof(object))]
		[NodeInput("WeightValues", typeof(System.Object))]
		public class Set_Weights : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Weights = inputs[1];
				return null;
			}
		}
}
