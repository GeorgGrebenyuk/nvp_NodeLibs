using NVP.API.Nodes;

namespace OdaX.OPMPropertyExtension 
{
		[NodeInput("dynamic", typeof(object))]
		public class OPMPropertyExtension_Constructor : INode 
		{
		public OdaX.IOPMPropertyExtension _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IOPMPropertyExtension;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class OPMPropertyExtension_ConstructorCast : INode 
		{
		public OdaX.IOPMPropertyExtension _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IOPMPropertyExtension;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
}
