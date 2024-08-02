using NVP.API.Nodes;

namespace OdaX.OPMPropertyExpander 
{
	[NodeInput("dynamic", typeof(object))]
	public class OPMPropertyExpander_Constructor : INode 
	{
		public OdaX.IOPMPropertyExpander _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOPMPropertyExpander;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class OPMPropertyExpander_ConstructorCast : INode 
	{
		public OdaX.IOPMPropertyExpander _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOPMPropertyExpander;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
