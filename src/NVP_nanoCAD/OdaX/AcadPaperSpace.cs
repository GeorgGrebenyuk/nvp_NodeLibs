using NVP.API.Nodes;

namespace OdaX.AcadPaperSpace 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadPaperSpace_Constructor : INode 
	{
		public OdaX.IAcadPaperSpace _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadPaperSpace;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadPaperSpace_ConstructorCast : INode 
	{
		public OdaX.IAcadPaperSpace _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadPaperSpace;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Adds a paperspace viewport to paperspace.
	///</summary>
	[NodeInput("AcadPaperSpace", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("Width", typeof(System.Double))]
	[NodeInput("Height", typeof(System.Double))]
	public class AddPViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddPViewport(inputs[1],inputs[2],inputs[3]));

		}
	}
}
