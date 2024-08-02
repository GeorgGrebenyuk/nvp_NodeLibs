using NVP.API.Nodes;

namespace OdaX.AcadSubEntSolidEdge 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadSubEntSolidEdge_Constructor : INode 
		{
		public OdaX.IAcadSubEntSolidEdge _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadSubEntSolidEdge;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadSubEntSolidEdge_ConstructorCast : INode 
		{
		public OdaX.IAcadSubEntSolidEdge _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadSubEntSolidEdge;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
}
