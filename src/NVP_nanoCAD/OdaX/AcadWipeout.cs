using NVP.API.Nodes;

namespace OdaX.AcadWipeout 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadWipeout_Constructor : INode 
		{
		public OdaX.IAcadWipeout _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadWipeout;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadWipeout_ConstructorCast : INode 
		{
		public OdaX.IAcadWipeout _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadWipeout;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
}
