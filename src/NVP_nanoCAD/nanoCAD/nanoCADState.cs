using NVP.API.Nodes;

namespace nanoCAD.nanoCADState 
{
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADState_Constructor : INode 
	{
		public nanoCAD.InanoCADState _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADState;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADState_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADState _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADState;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Checks whether App is idle and ready to accept automation calls from out-of-process applications
	///</summary>
	[NodeInput("nanoCADState", typeof(object))]
	public class IsQuiescent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsQuiescent);

		}
	}


	///<summary>
	///Gets the Application object
	///</summary>
	[NodeInput("nanoCADState", typeof(object))]
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}
}
