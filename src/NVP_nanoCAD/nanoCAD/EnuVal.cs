using NVP.API.Nodes;

namespace nanoCAD.EnuVal 
{
	[NodeInput("dynamic", typeof(object))]
	public class EnuVal_Constructor : INode 
	{
		public nanoCAD.IEnuVal _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.IEnuVal;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class EnuVal_ConstructorCast : INode 
	{
		public nanoCAD.IEnuVal _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.IEnuVal;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Retrieves the enum name value
	///</summary>
	[NodeInput("EnuVal", typeof(object))]
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item);

		}
	}
}
