using NVP.API.Nodes;

namespace OdaX.AcadSubEntSolidFace 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadSubEntSolidFace_Constructor : INode 
	{
		public OdaX.IAcadSubEntSolidFace _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSubEntSolidFace;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadSubEntSolidFace_ConstructorCast : INode 
	{
		public OdaX.IAcadSubEntSolidFace _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSubEntSolidFace;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Specifies the material
	///</summary>
	[NodeInput("AcadSubEntSolidFace", typeof(object))]
	public class Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Material);

		}
	}


	///<summary>
	///Specifies the material
	///</summary>
	[NodeInput("AcadSubEntSolidFace", typeof(object))]
	[NodeInput("Material", typeof(System.String))]
	public class Set_Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Material = inputs[1];
			return null;
		}
	}
}
