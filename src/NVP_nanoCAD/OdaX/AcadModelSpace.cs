using NVP.API.Nodes;

namespace OdaX.AcadModelSpace 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadModelSpace_Constructor : INode 
		{
		public OdaX.IAcadModelSpace _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadModelSpace;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadModelSpace_ConstructorCast : INode 
		{
		public OdaX.IAcadModelSpace _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadModelSpace;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
}
