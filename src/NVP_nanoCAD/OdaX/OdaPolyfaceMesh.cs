using NVP.API.Nodes;

namespace OdaX.OdaPolyfaceMesh 
{
	[NodeInput("dynamic", typeof(object))]
	public class OdaPolyfaceMesh_Constructor : INode 
	{
		public OdaX.IOdaPolyfaceMesh _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaPolyfaceMesh;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class OdaPolyfaceMesh_ConstructorCast : INode 
	{
		public OdaX.IOdaPolyfaceMesh _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaPolyfaceMesh;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("OdaPolyfaceMesh", typeof(object))]
	[NodeInput("__MIDL__IOdaPolyfaceMesh0000", typeof(System.Object))]
	public class GetFaces : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetFaces(inputs[1]);
			return null;
		}
	}
}
