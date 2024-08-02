using NVP.API.Nodes;

namespace Renga.BSTR 
{
	[NodeInput("dynamic", typeof(object))]
	public class BSTR_Constructor : INode 
	{
		public Renga.BSTR _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.BSTR;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class BSTR_ConstructorCast : INode 
	{
		public Renga.BSTR _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.BSTR;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
