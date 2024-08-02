using NVP.API.Nodes;

namespace OdaX.AcadPlaneSurface 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadPlaneSurface_Constructor : INode 
	{
		public OdaX.IAcadPlaneSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadPlaneSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadPlaneSurface_ConstructorCast : INode 
	{
		public OdaX.IAcadPlaneSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadPlaneSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
