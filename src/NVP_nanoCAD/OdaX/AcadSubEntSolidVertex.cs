using NVP.API.Nodes;

namespace OdaX.AcadSubEntSolidVertex 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadSubEntSolidVertex_Constructor : INode 
		{
		public OdaX.IAcadSubEntSolidVertex _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadSubEntSolidVertex;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadSubEntSolidVertex_ConstructorCast : INode 
		{
		public OdaX.IAcadSubEntSolidVertex _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadSubEntSolidVertex;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
}
