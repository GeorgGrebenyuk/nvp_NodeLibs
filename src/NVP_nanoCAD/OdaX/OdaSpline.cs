using NVP.API.Nodes;

namespace OdaX.OdaSpline 
{
	[NodeInput("dynamic", typeof(object))]
	public class OdaSpline_Constructor : INode 
	{
		public OdaX.IOdaSpline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaSpline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class OdaSpline_ConstructorCast : INode 
	{
		public OdaX.IOdaSpline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaSpline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Set all nurbs data to the spline
	///</summary>
	[NodeInput("OdaSpline", typeof(object))]
	[NodeInput("Degree", typeof(System.Int32))]
	[NodeInput("ControlPoints", typeof(System.Object))]
	[NodeInput("Knots", typeof(System.Object))]
	[NodeInput("Weights", typeof(System.Object))]
	[NodeInput("controlPtTolerance", typeof(System.Double))]
	[NodeInput("knotTolerance", typeof(System.Double))]
	[NodeInput("periodic", typeof(System.Object))]
	public class SetNurbsData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetNurbsData(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5],inputs[6],inputs[7]);
			return null;
		}
	}
}
