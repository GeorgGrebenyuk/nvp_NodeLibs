using NVP.API.Nodes;

namespace OdaX.AcadObjectEvents 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadObjectEvents_Constructor : INode 
	{
		public OdaX.IAcadObjectEvents _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadObjectEvents;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadObjectEvents_ConstructorCast : INode 
	{
		public OdaX.IAcadObjectEvents _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadObjectEvents;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
