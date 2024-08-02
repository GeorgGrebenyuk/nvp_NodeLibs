using NVP.API.Nodes;

namespace OdaX.AcadHatch2 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadHatch2_Constructor : INode 
	{
		public OdaX.IAcadHatch2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadHatch2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadHatch2_ConstructorCast : INode 
	{
		public OdaX.IAcadHatch2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadHatch2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Returns the hatch background color.
	///</summary>
	[NodeInput("AcadHatch2", typeof(object))]
	public class BackgroundColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundColor);

		}
	}


	///<summary>
	///Returns the hatch background color.
	///</summary>
	[NodeInput("AcadHatch2", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]
	public class Set_BackgroundColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundColor = inputs[1];
			return null;
		}
	}
}
