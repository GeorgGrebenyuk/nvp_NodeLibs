using NVP.API.Nodes;

namespace OdaX.AcadDwfUnderlay 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadDwfUnderlay_Constructor : INode 
	{
		public OdaX.IAcadDwfUnderlay _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadDwfUnderlay;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadDwfUnderlay_ConstructorCast : INode 
	{
		public OdaX.IAcadDwfUnderlay _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadDwfUnderlay;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Specifies the format of DWF file
	///</summary>
	[NodeInput("AcadDwfUnderlay", typeof(object))]
	public class DWFFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DWFFormat);

		}
	}


	///<summary>
	///Specifies the format of DWF file
	///</summary>
	[NodeInput("AcadDwfUnderlay", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	public class Set_DWFFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DWFFormat = inputs[1];
			return null;
		}
	}
}
